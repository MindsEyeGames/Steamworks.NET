// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2022 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#if !(UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX || STEAMWORKS_WIN || STEAMWORKS_LIN_OSX)
	#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Steamworks {
	public static class SteamRemotePlay {
		/// <summary>
		/// <para> Get the number of currently connected Steam Remote Play sessions</para>
		/// </summary>
		public static uint GetSessionCount() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_GetSessionCount(CSteamAPIContext.GetSteamRemotePlay());
		}

		/// <summary>
		/// <para> Get the currently connected Steam Remote Play session ID at the specified index. Returns zero if index is out of bounds.</para>
		/// </summary>
		public static RemotePlaySessionID_t GetSessionID(int iSessionIndex) {
			InteropHelp.TestIfAvailableClient();
			return (RemotePlaySessionID_t)NativeMethods.ISteamRemotePlay_GetSessionID(CSteamAPIContext.GetSteamRemotePlay(), iSessionIndex);
		}

		/// <summary>
		/// <para> Get the SteamID of the connected user</para>
		/// </summary>
		public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamRemotePlay_GetSessionSteamID(CSteamAPIContext.GetSteamRemotePlay(), unSessionID);
		}

		/// <summary>
		/// <para> Get the name of the session client device</para>
		/// <para> This returns NULL if the sessionID is not valid</para>
		/// </summary>
		public static string GetSessionClientName(RemotePlaySessionID_t unSessionID) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamRemotePlay_GetSessionClientName(CSteamAPIContext.GetSteamRemotePlay(), unSessionID));
		}

		/// <summary>
		/// <para> Get the form factor of the session client device</para>
		/// </summary>
		public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_GetSessionClientFormFactor(CSteamAPIContext.GetSteamRemotePlay(), unSessionID);
		}

		/// <summary>
		/// <para> Get the resolution, in pixels, of the session client device</para>
		/// <para> This is set to 0x0 if the resolution is not available</para>
		/// </summary>
		public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_BGetSessionClientResolution(CSteamAPIContext.GetSteamRemotePlay(), unSessionID, out pnResolutionX, out pnResolutionY);
		}

		/// <summary>
		/// <para> Show the Remote Play Together UI in the game overlay</para>
		/// <para> This returns false if your game is not configured for Remote Play Together</para>
		/// </summary>
		public static bool ShowRemotePlayTogetherUI() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_ShowRemotePlayTogetherUI(CSteamAPIContext.GetSteamRemotePlay());
		}

		/// <summary>
		/// <para> Invite a friend to Remote Play Together, or create a guest invite if steamIDFriend is empty</para>
		/// <para> This will automatically start Remote Play Together if it hasn't already been started</para>
		/// <para> This returns false if the invite can't be sent or your game is not configured for Remote Play Together</para>
		/// </summary>
		public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_BSendRemotePlayTogetherInvite(CSteamAPIContext.GetSteamRemotePlay(), steamIDFriend);
		}

		/// <summary>
		/// <para> Make mouse and keyboard input for Remote Play Together sessions available via GetInput() instead of being merged with local input</para>
		/// </summary>
		public static bool BEnableRemotePlayTogetherDirectInput() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_BEnableRemotePlayTogetherDirectInput(CSteamAPIContext.GetSteamRemotePlay());
		}

		/// <summary>
		/// <para> Merge Remote Play Together mouse and keyboard input with local input</para>
		/// </summary>
		public static void DisableRemotePlayTogetherDirectInput() {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamRemotePlay_DisableRemotePlayTogetherDirectInput(CSteamAPIContext.GetSteamRemotePlay());
		}

		/// <summary>
		/// <para> Get input events from Remote Play Together sessions</para>
		/// <para> This is available after calling BEnableRemotePlayTogetherDirectInput()</para>
		/// <para> pInput is an array of input events that will be filled in by this function, up to unMaxEvents.</para>
		/// <para> This returns the number of events copied to pInput, or the number of events available if pInput is nullptr.</para>
		/// </summary>
		public static uint GetInput(RemotePlayInput_t[] pInput, uint unMaxEvents) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_GetInput(CSteamAPIContext.GetSteamRemotePlay(), pInput, unMaxEvents);
		}

		/// <summary>
		/// <para> Set the mouse cursor visibility for a remote player</para>
		/// <para> This is available after calling BEnableRemotePlayTogetherDirectInput()</para>
		/// </summary>
		public static void SetMouseVisibility(RemotePlaySessionID_t unSessionID, bool bVisible) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamRemotePlay_SetMouseVisibility(CSteamAPIContext.GetSteamRemotePlay(), unSessionID, bVisible);
		}

		/// <summary>
		/// <para> Set the mouse cursor position for a remote player</para>
		/// <para> This is available after calling BEnableRemotePlayTogetherDirectInput()</para>
		/// <para> This is used to warp the cursor to a specific location and isn't needed during normal event processing.</para>
		/// <para> The position is normalized relative to the window, where 0,0 is the upper left, and 1,1 is the lower right.</para>
		/// </summary>
		public static void SetMousePosition(RemotePlaySessionID_t unSessionID, float flNormalizedX, float flNormalizedY) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamRemotePlay_SetMousePosition(CSteamAPIContext.GetSteamRemotePlay(), unSessionID, flNormalizedX, flNormalizedY);
		}

		/// <summary>
		/// <para> Create a cursor that can be used with SetMouseCursor()</para>
		/// <para> This is available after calling BEnableRemotePlayTogetherDirectInput()</para>
		/// <para> Parameters:</para>
		/// <para> nWidth - The width of the cursor, in pixels</para>
		/// <para> nHeight - The height of the cursor, in pixels</para>
		/// <para> nHotX - The X coordinate of the cursor hot spot in pixels, offset from the left of the cursor</para>
		/// <para> nHotY - The Y coordinate of the cursor hot spot in pixels, offset from the top of the cursor</para>
		/// <para> pBGRA - A pointer to the cursor pixels, with the color channels in red, green, blue, alpha order</para>
		/// <para> nPitch - The distance between pixel rows in bytes, defaults to nWidth * 4</para>
		/// </summary>
		public static RemotePlayCursorID_t CreateMouseCursor(int nWidth, int nHeight, int nHotX, int nHotY, IntPtr pBGRA, int nPitch = 0) {
			InteropHelp.TestIfAvailableClient();
			return (RemotePlayCursorID_t)NativeMethods.ISteamRemotePlay_CreateMouseCursor(CSteamAPIContext.GetSteamRemotePlay(), nWidth, nHeight, nHotX, nHotY, pBGRA, nPitch);
		}

		/// <summary>
		/// <para> Set the mouse cursor for a remote player</para>
		/// <para> This is available after calling BEnableRemotePlayTogetherDirectInput()</para>
		/// <para> The cursor ID is a value returned by CreateMouseCursor()</para>
		/// </summary>
		public static void SetMouseCursor(RemotePlaySessionID_t unSessionID, RemotePlayCursorID_t unCursorID) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamRemotePlay_SetMouseCursor(CSteamAPIContext.GetSteamRemotePlay(), unSessionID, unCursorID);
		}
	}
}

#endif // !DISABLESTEAMWORKS
