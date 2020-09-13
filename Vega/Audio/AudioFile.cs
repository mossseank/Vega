﻿/*
 * Microsoft Public License (Ms-PL) - Copyright (c) 2020 Sean Moss
 * This file is subject to the terms and conditions of the Microsoft Public License, the text of which can be found in
 * the 'LICENSE' file at the root of this repository, or online at <https://opensource.org/licenses/MS-PL>.
 */

using System;
using System.IO;
using Vega.Content;

namespace Vega.Audio
{
	// Represents a handle to a AudioFile object in the native content loader
	internal sealed class AudioFile : IDisposable
	{
		#region Fields
		// The content loader native handle
		private readonly IntPtr _handle;

		// Audio file info
		public readonly string Path;
		public readonly ulong FrameCount;
		public readonly uint SampleRate;
		public readonly bool Stereo;
		public readonly AudioType AudioType;

		// Error info
		public AudioError Error => NativeLoader.AudioGetError(_handle);

		// Streaming info
		public ulong RemainingFrames => NativeLoader.AudioGetRemainingFrames(_handle);
		public bool EOF => RemainingFrames == 0;
		#endregion // Fields

		public AudioFile(string path)
		{
			// Ensure file
			if (!File.Exists(path)) {
				throw new IOException($"The audio file '{path}' does not exist or is an invalid path");
			}
			Path = path;

			// Try to load the file
			_handle = NativeLoader.AudioOpenFile(path, out var error);
			if (_handle == IntPtr.Zero || error != AudioError.NoError) {
				throw new ContentLoadException(path, $"audio file loading failed with {error}");
			}

			// Get the file info
			NativeLoader.AudioGetInfo(_handle, out var frames, out var rate, out var channels);
			if (rate < 8_000 || rate > 48_000) {
				throw new ContentLoadException(path, 
					$"audio files must have sample rates in [8000, 48000] (actual {rate})");
			}
			if (channels == 0 || channels > 2) {
				throw new ContentLoadException(path, 
					$"audio files must have either 1 (mono) or 2 (stereo) channels (actual {channels})");
			}
			FrameCount = frames;
			SampleRate = rate;
			Stereo = (channels == 2);
			AudioType = NativeLoader.AudioGetType(_handle);
		}
		~AudioFile()
		{
			dispose(false);
		}

		// Read frames - throws an exception on error, instead of returning 0
		public ulong ReadFrames(ReadOnlySpan<short> buffer)
		{
			if (EOF) {
				return 0;
			}

			ulong fCount = (uint)buffer.Length / (Stereo ? 2u : 1u);
			ulong read = NativeLoader.AudioReadFrames(_handle, fCount, buffer);
			if (read == 0) {
				throw new ContentLoadException(Path, $"audio file data read error ({Error})");
			}
			return read;
		}

		#region IDisposable
		public void Dispose()
		{
			dispose(true);
			GC.SuppressFinalize(this);
		}

		private void dispose(bool disposing)
		{
			if (_handle != IntPtr.Zero) {
				NativeLoader.AudioCloseFile(_handle);
			}
		}
		#endregion // IDisposable
	}
}