﻿/*
 * Microsoft Public License (Ms-PL) - Copyright (c) 2020-2021 Sean Moss
 * This file is subject to the terms and conditions of the Microsoft Public License, the text of which can be found in
 * the 'LICENSE' file at the root of this repository, or online at <https://opensource.org/licenses/MS-PL>.
 */

using System;
using Vega.Graphics;

namespace Vega.Content
{
	// Enums specific to the native content library
	internal unsafe static partial class NativeContent
	{
		// Maps to the AudioError enum in the ContentLoader library
		public enum AudioError : uint
		{
			NoError = 0,            // Special no error state
			FileNotFound = 1,       // The file does not exist
			UnknownType = 2,        // The file is not a known audio type
			InvalidFile = 3,        // The file failed to open (most likely an invalid header)
			BadDataRead = 4,        // Reading samples failed (most likely corrupt frame data)
			ReadAtEnd = 5,          // Attempting to read a fully consumed file
			BadStateRead = 6,       // Attempting to read from a file object that is already errored
		}

		// Maps to the AudioType enum in the ContentLoader library
		public enum AudioType : uint
		{
			Unknown = 0,            // Special unknown type signifying and error or uninitialized data
			Wav = 1,                // WAVE file
			Vorbis = 2,             // OGG/Vorbis file
			Flac = 3,               // Flac file
		}

		// Maps to the ImageError enum in the ContentLoader library
		public enum ImageError : uint
		{
			NoError = 0,            // Special no error state
			FileNotFound = 1,       // The file to open does not exist
			UnknownType = 2,        // The file is not a known image type
			InvalidFile = 3,        // The file failed to open (most likely an invalid header)
			InvalidChannels = 4,    // The file has an unsupported channel count
			BadDataRead = 5,        // Reading samples failed (most likely corrupt image data)
			BadStateRead = 6,       // Attempting to read from a file object that is already errored
		}

		// Maps to the ImageType enum in the ContentLoader library
		public enum ImageType : uint
		{
			Unknown = 0,            // Special unknown type signifying an error or uninitialized data
			Jpeg = 1,               // JPEG file
			Png = 2,                // PNG file
			Tga = 3,                // TGA file
			Bmp = 4,                // BMP file
		}

		// Maps to the ImageChannels enum in the ContentLoader library
		public enum ImageChannels : uint
		{
			Unknown = 0,            // Unknown or unsupported channel data
			Gray = 1,               // Grayscale color data only
			GrayAlpha = 2,          // Grayscale color data with alpha
			RGB = 3,                // RGB color data
			RGBA = 4                // RBG color data with alpha
		}
	}
}
