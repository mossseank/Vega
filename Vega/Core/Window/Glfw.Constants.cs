﻿/*
 * Microsoft Public License (Ms-PL) - Copyright (c) 2020-2021 Sean Moss
 * This file is subject to the terms and conditions of the Microsoft Public License, the text of which can be found in
 * the 'LICENSE' file at the root of this repository, or online at <https://opensource.org/licenses/MS-PL>.
 */

using System;

namespace Vega
{
	internal static partial class Glfw
	{
		#region Boolean
		public const int TRUE = 1;
		public const int FALSE = 0;
		#endregion // Boolean

		#region Key Events
		public const int RELEASE = 0;
		public const int PRESS = 1;
		public const int REPEAT = 2;
		#endregion // Key Events

		#region Hat Switch
		public const int HAT_CENTERED = 0;
		public const int HAT_UP = 1;
		public const int HAT_RIGHT = 2;
		public const int HAT_DOWN = 4;
		public const int HAT_LEFT = 8;
		public const int HAT_RIGHT_UP = HAT_RIGHT | HAT_UP;
		public const int HAT_RIGHT_DOWN = HAT_RIGHT | HAT_DOWN;
		public const int HAT_LEFT_UP = HAT_LEFT | HAT_UP;
		public const int HAT_LEFT_DOWN = HAT_LEFT | HAT_DOWN;
		#endregion // Hat Swtich

		#region Keys
		public const int KEY_UNKNOWN = -1;
		public const int KEY_SPACE = 32;
		public const int KEY_APOSTROPHE = 39;
		public const int KEY_COMMA = 44;
		public const int KEY_MINUS = 45;
		public const int KEY_PERIOD = 46;
		public const int KEY_SLASH = 47;
		public const int KEY_0 = 48;
		public const int KEY_1 = 49;
		public const int KEY_2 = 50;
		public const int KEY_3 = 51;
		public const int KEY_4 = 52;
		public const int KEY_5 = 53;
		public const int KEY_6 = 54;
		public const int KEY_7 = 55;
		public const int KEY_8 = 56;
		public const int KEY_9 = 57;
		public const int KEY_SEMICOLON = 59;
		public const int KEY_EQUAL = 61;
		public const int KEY_A = 65;
		public const int KEY_B = 66;
		public const int KEY_C = 67;
		public const int KEY_D = 68;
		public const int KEY_E = 69;
		public const int KEY_F = 70;
		public const int KEY_G = 71;
		public const int KEY_H = 72;
		public const int KEY_I = 73;
		public const int KEY_J = 74;
		public const int KEY_K = 75;
		public const int KEY_L = 76;
		public const int KEY_M = 77;
		public const int KEY_N = 78;
		public const int KEY_O = 79;
		public const int KEY_P = 80;
		public const int KEY_Q = 81;
		public const int KEY_R = 82;
		public const int KEY_S = 83;
		public const int KEY_T = 84;
		public const int KEY_U = 85;
		public const int KEY_V = 86;
		public const int KEY_W = 87;
		public const int KEY_X = 88;
		public const int KEY_Y = 89;
		public const int KEY_Z = 90;
		public const int KEY_LEFT_BRACKET = 91;
		public const int KEY_BACKSLASH = 92;
		public const int KEY_RIGHT_BRACKET = 93;
		public const int KEY_GRAVE_ACCENT = 96;
		public const int KEY_WORLD_1 = 161;
		public const int KEY_WORLD_2 = 162;

		public const int KEY_ESCAPE = 256;
		public const int KEY_ENTER = 257;
		public const int KEY_TAB = 258;
		public const int KEY_BACKSPACE = 259;
		public const int KEY_INSERT = 260;
		public const int KEY_DELETE = 261;
		public const int KEY_RIGHT = 262;
		public const int KEY_LEFT = 263;
		public const int KEY_DOWN = 264;
		public const int KEY_UP = 265;
		public const int KEY_PAGE_UP = 266;
		public const int KEY_PAGE_DOWN = 267;
		public const int KEY_HOME = 268;
		public const int KEY_END = 269;
		public const int KEY_CAPS_LOCK = 280;
		public const int KEY_SCROLL_LOCK = 281;
		public const int KEY_NUM_LOCK = 282;
		public const int KEY_PRINT_SCREEN = 283;
		public const int KEY_PAUSE = 284;
		public const int KEY_F1 = 290;
		public const int KEY_F2 = 291;
		public const int KEY_F3 = 292;
		public const int KEY_F4 = 293;
		public const int KEY_F5 = 294;
		public const int KEY_F6 = 295;
		public const int KEY_F7 = 296;
		public const int KEY_F8 = 297;
		public const int KEY_F9 = 298;
		public const int KEY_F10 = 299;
		public const int KEY_F11 = 300;
		public const int KEY_F12 = 301;
		public const int KEY_F13 = 302;
		public const int KEY_F14 = 303;
		public const int KEY_F15 = 304;
		public const int KEY_F16 = 305;
		public const int KEY_F17 = 306;
		public const int KEY_F18 = 307;
		public const int KEY_F19 = 308;
		public const int KEY_F20 = 309;
		public const int KEY_F21 = 310;
		public const int KEY_F22 = 311;
		public const int KEY_F23 = 312;
		public const int KEY_F24 = 313;
		public const int KEY_F25 = 314;
		public const int KEY_KP_0 = 320;
		public const int KEY_KP_1 = 321;
		public const int KEY_KP_2 = 322;
		public const int KEY_KP_3 = 323;
		public const int KEY_KP_4 = 324;
		public const int KEY_KP_5 = 325;
		public const int KEY_KP_6 = 326;
		public const int KEY_KP_7 = 327;
		public const int KEY_KP_8 = 328;
		public const int KEY_KP_9 = 329;
		public const int KEY_KP_DECIMAL = 330;
		public const int KEY_KP_DIVIDE = 331;
		public const int KEY_KP_MULTIPLY = 332;
		public const int KEY_KP_SUBTRACT = 333;
		public const int KEY_KP_ADD = 334;
		public const int KEY_KP_ENTER = 335;
		public const int KEY_KP_EQUAL = 336;
		public const int KEY_LEFT_SHIFT = 340;
		public const int KEY_LEFT_CONTROL = 341;
		public const int KEY_LEFT_ALT = 342;
		public const int KEY_LEFT_SUPER = 343;
		public const int KEY_RIGHT_SHIFT = 344;
		public const int KEY_RIGHT_CONTROL = 345;
		public const int KEY_RIGHT_ALT = 346;
		public const int KEY_RIGHT_SUPER = 347;
		public const int KEY_MENU = 348;
		public const int KEY_LAST = KEY_MENU;

		public const int MOD_SHIFT = 0x0001;
		public const int MOD_CONTROL = 0x0002;
		public const int MOD_ALT = 0x0004;
		public const int MOD_SUPER = 0x0008;
		public const int MOD_CAPS_LOCK = 0x0010;
		public const int MOD_NUM_LOCK = 0x0020;
		#endregion // Keys

		#region Mouse Buttons
		public const int MOUSE_BUTTON_1 = 0;
		public const int MOUSE_BUTTON_2 = 1;
		public const int MOUSE_BUTTON_3 = 2;
		public const int MOUSE_BUTTON_4 = 3;
		public const int MOUSE_BUTTON_5 = 4;
		public const int MOUSE_BUTTON_6 = 5;
		public const int MOUSE_BUTTON_7 = 6;
		public const int MOUSE_BUTTON_8 = 7;
		public const int MOUSE_BUTTON_LAST = MOUSE_BUTTON_8;
		public const int MOUSE_BUTTON_LEFT = MOUSE_BUTTON_1;
		public const int MOUSE_BUTTON_RIGHT = MOUSE_BUTTON_2;
		public const int MOUSE_BUTTON_MIDDLE = MOUSE_BUTTON_3;
		#endregion // Mouse Buttons

		#region Joystick
		public const int JOYSTICK_1 = 0;
		public const int JOYSTICK_2 = 1;
		public const int JOYSTICK_3 = 2;
		public const int JOYSTICK_4 = 3;
		public const int JOYSTICK_5 = 4;
		public const int JOYSTICK_6 = 5;
		public const int JOYSTICK_7 = 6;
		public const int JOYSTICK_8 = 7;
		public const int JOYSTICK_9 = 8;
		public const int JOYSTICK_10 = 9;
		public const int JOYSTICK_11 = 10;
		public const int JOYSTICK_12 = 11;
		public const int JOYSTICK_13 = 12;
		public const int JOYSTICK_14 = 13;
		public const int JOYSTICK_15 = 14;
		public const int JOYSTICK_16 = 15;
		public const int JOYSTICK_LAST = JOYSTICK_16;
		#endregion // Joystick

		#region Gamepad
		public const int GAMEPAD_BUTTON_A = 0;
		public const int GAMEPAD_BUTTON_B = 1;
		public const int GAMEPAD_BUTTON_X = 2;
		public const int GAMEPAD_BUTTON_Y = 3;
		public const int GAMEPAD_BUTTON_LEFT_BUMPER = 4;
		public const int GAMEPAD_BUTTON_RIGHT_BUMPER = 5;
		public const int GAMEPAD_BUTTON_BACK = 6;
		public const int GAMEPAD_BUTTON_START = 7;
		public const int GAMEPAD_BUTTON_GUIDE = 8;
		public const int GAMEPAD_BUTTON_LEFT_THUMB = 9;
		public const int GAMEPAD_BUTTON_RIGHT_THUMB = 10;
		public const int GAMEPAD_BUTTON_DPAD_UP = 11;
		public const int GAMEPAD_BUTTON_DPAD_RIGHT = 12;
		public const int GAMEPAD_BUTTON_DPAD_DOWN = 13;
		public const int GAMEPAD_BUTTON_DPAD_LEFT = 14;
		public const int GAMEPAD_BUTTON_LAST = GAMEPAD_BUTTON_DPAD_LEFT;
		public const int GAMEPAD_BUTTON_CROSS = GAMEPAD_BUTTON_A;
		public const int GAMEPAD_BUTTON_CIRCLE = GAMEPAD_BUTTON_B;
		public const int GAMEPAD_BUTTON_SQUARE = GAMEPAD_BUTTON_X;
		public const int GAMEPAD_BUTTON_TRIANGLE = GAMEPAD_BUTTON_Y;
		public const int GAMEPAD_AXIS_LEFT_X = 0;
		public const int GAMEPAD_AXIS_LEFT_Y = 1;
		public const int GAMEPAD_AXIS_RIGHT_X = 2;
		public const int GAMEPAD_AXIS_RIGHT_Y = 3;
		public const int GAMEPAD_AXIS_LEFT_TRIGGER = 4;
		public const int GAMEPAD_AXIS_RIGHT_TRIGGER = 5;
		public const int GAMEPAD_AXIS_LAST = GAMEPAD_AXIS_RIGHT_TRIGGER;
		#endregion // Gamepad

		#region Constants
		public const int NO_ERROR = 0;
		public const int NOT_INITIALIZED = 0x00010001;
		public const int NO_CURRENT_CONTEXT = 0x00010002;
		public const int INVALID_ENUM = 0x00010003;
		public const int INVALID_VALUE = 0x00010004;
		public const int OUT_OF_MEMORY = 0x00010005;
		public const int API_UNAVAILABLE = 0x00010006;
		public const int VERSION_UNAVAILABLE = 0x00010007;
		public const int PLATFORM_ERROR = 0x00010008;
		public const int FORMAT_UNAVAILABLE = 0x00010009;
		public const int NO_WINDOW_CONTEXT = 0x0001000A;
		public const int FOCUSED = 0x00020001;
		public const int ICONIFIED = 0x00020002;
		public const int RESIZABLE = 0x00020003;
		public const int VISIBLE = 0x00020004;
		public const int DECORATED = 0x00020005;
		public const int AUTO_ICONIFY = 0x00020006;
		public const int FLOATING = 0x00020007;
		public const int MAXIMIZED = 0x00020008;
		public const int CENTER_CURSOR = 0x00020009;
		public const int TRANSPARENT_FRAMEBUFFER = 0x0002000A;
		public const int HOVERED = 0x0002000B;
		public const int FOCUS_ON_SHOW = 0x0002000C;
		public const int RED_BITS = 0x00021001;
		public const int GREEN_BITS = 0x00021002;
		public const int BLUE_BITS = 0x00021003;
		public const int ALPHA_BITS = 0x00021004;
		public const int DEPTH_BITS = 0x00021005;
		public const int STENCIL_BITS = 0x00021006;
		public const int ACCUM_RED_BITS = 0x00021007;
		public const int ACCUM_GREEN_BITS = 0x00021008;
		public const int ACCUM_BLUE_BITS = 0x00021009;
		public const int ACCUM_ALPHA_BITS = 0x0002100A;
		public const int AUX_BUFFERS = 0x0002100B;
		public const int STEREO = 0x0002100C;
		public const int SAMPLES = 0x0002100D;
		public const int SRGB_CAPABLE = 0x0002100E;
		public const int REFRESH_RATE = 0x0002100F;
		public const int DOUBLEBUFFER = 0x00021010;
		public const int CLIENT_API = 0x00022001;
		public const int CONTEXT_VERSION_MAJOR = 0x00022002;
		public const int CONTEXT_VERSION_MINOR = 0x00022003;
		public const int CONTEXT_REVISION = 0x00022004;
		public const int CONTEXT_ROBUSTNESS = 0x00022005;
		public const int OPENGL_FORWARD_COMPAT = 0x00022006;
		public const int OPENGL_DEBUG_CONTEXT = 0x00022007;
		public const int OPENGL_PROFILE = 0x00022008;
		public const int CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
		public const int CONTEXT_NO_ERROR = 0x0002200A;
		public const int CONTEXT_CREATION_API = 0x0002200B;
		public const int SCALE_TO_MONITOR = 0x0002200C;
		public const int COCOA_RETINA_FRAMEBUFFER = 0x00023001;
		public const int COCOA_FRAME_NAME = 0x00023002;
		public const int COCOA_GRAPHICS_SWITCHING = 0x00023003;
		public const int X11_CLASS_NAME = 0x00024001;
		public const int X11_INSTANCE_NAME = 0x00024002;
		public const int NO_API = 0;
		public const int OPENGL_API = 0x00030001;
		public const int OPENGL_ES_API = 0x00030002;
		public const int NO_ROBUSTNESS = 0;
		public const int NO_RESET_NOTIFICATION = 0x00031001;
		public const int LOSE_CONTEXT_ON_RESET = 0x00031002;
		public const int OPENGL_ANY_PROFILE = 0;
		public const int OPENGL_CORE_PROFILE = 0x00032001;
		public const int OPENGL_COMPAT_PROFILE = 0x00032002;
		public const int CURSOR = 0x00033001;
		public const int STICKY_KEYS = 0x00033002;
		public const int STICKY_MOUSE_BUTTONS = 0x00033003;
		public const int LOCK_KEY_MODS = 0x00033004;
		public const int RAW_MOUSE_MOTION = 0x00033005;
		public const int CURSOR_NORMAL = 0x00034001;
		public const int CURSOR_HIDDEN = 0x00034002;
		public const int CURSOR_DISABLED = 0x00034003;
		public const int ANY_RELEASE_BEHAVIOR = 0;
		public const int RELEASE_BEHAVIOR_FLUSH = 0x00035001;
		public const int RELEASE_BEHAVIOR_NONE = 0x00035002;
		public const int NATIVE_CONTEXT_API = 0x00036001;
		public const int EGL_CONTEXT_API = 0x00036002;
		public const int OSMESA_CONTEXT_API = 0x00036003;
		public const int ARROW_CURSOR = 0x00036001;
		public const int IBEAM_CURSOR = 0x00036002;
		public const int CROSSHAIR_CURSOR = 0x00036003;
		public const int HAND_CURSOR = 0x00036004;
		public const int HRESIZE_CURSOR = 0x00036005;
		public const int VRESIZE_CURSOR = 0x00036006;
		public const int CONNECTED = 0x00040001;
		public const int DISCONNECTED = 0x00040002;
		public const int JOYSTICK_HAT_BUTTONS = 0x00050001;
		public const int COCOA_CHDIR_RESOURCES = 0x00051001;
		public const int COCOA_MENUBAR = 0x00051002;
		public const int DONT_CARE = -1;
		#endregion // Constants
	}
}
