﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Crestron.SimplSharpPro.DeviceSupport;

namespace PepperDash.Essentials
{
	/// <summary>
	/// Common string join number constants
	/// </summary>
	public class UIStringJoin
	{
        //******************************************************
        // Codec
        /// <summary>
        /// 1001
        /// </summary>
        public const uint CodecAddressEntryText = 1001;
        /// <summary>
        /// 1002
        /// </summary>
        public const uint CodecDirectorySearchEntryText = 1002;
        /// <summary>
        /// 1004
        /// </summary>
        public const uint CallSharedSourceNameText = 1004;


        /// <summary>
        /// 1201 - 1230 range of joins for recents list
        /// </summary>
        public const uint VCRecentListTextStart = 1201;
		//									RANGE IN USE
		public const uint VCRecentListTextEnd = 1230;
		/// <summary>
		/// 1231 - 1261 range of joins for recent list time 
		/// </summary>
		public const uint VCRecentListTimeTextStart = 1231;
        //									RANGE IN USE
        public const uint VCRecentListTimeTextEnd = 1260;
		/// <summary>
		/// 1291 - the current layout mode
		/// </summary>
		public const uint VCLayoutModeText = 1291;

		/// <summary>
		/// 1301 - 1400
		/// </summary>
		public const uint VCDirectoryListTextStart = 1301;
		//									RANGE IN USE
		public const uint VCDirectoryListTextEnd = 1400;

        /// <summary>
        /// 141112
        /// </summary>
        public const uint VCFavorites1Text = 1411;

        /// <summary>
        /// 1412
        /// </summary>
        public const uint VCFavorites2Text = 1412;

        /// <summary>
        /// 1413
        /// </summary>
        public const uint VCFavorites3Text = 1413;

        /// <summary>
        /// 1414
        /// </summary>
        public const uint VCFavorites4Text = 1414;

        /// <summary>
        /// 1415
        /// </summary>
        public const uint VCFavorites5Text = 1415;


        //******************************************************
        // Keyboard
        /// <summary>
        /// 1901
        /// </summary>
        //public const uint KeypadText = 2901;

        /// <summary>
        /// 3101 - This is the start of the range 3101 - 3120
        /// </summary>
        public const uint TechMenuButtonTextStart = 3101;

        //----- through 3120


        /// <summary>
        /// 3812
        /// </summary>
        public const uint AdvancedVolumeSlider1Text = 3812;
        /// <summary>
        /// 3822
        /// </summary>
        public const uint AdvancedVolumeSlider2Text = 3822;
        /// <summary>
        /// 3832
        /// </summary>
        public const uint AdvancedVolumeSlider3Text = 3832;
        /// <summary>
        /// 3842
        /// </summary>
        public const uint AdvancedVolumeSlider4Text = 3842;
        /// <summary>
        /// 3852
        /// </summary>
        public const uint AdvancedVolumeSlider5Text = 3852;
        /// <summary>
        /// 3862
        /// </summary>
        public const uint AdvancedVolumeSlider6Text = 3862;

        /// <summary>
        /// 3901
        /// </summary>
		public const uint CurrentRoomName = 3901;
        /// <summary>
        /// 3902
        /// </summary>
		public const uint CurrentSourceName = 3902;
        /// <summary>
        /// 3903
        /// </summary>
		public const uint CurrentSourceIcon = 3903;
        /// <summary>
        /// 3904 - Phone number for room header
        /// </summary>
        public const uint RoomPhoneText = 3904;
        /// <summary>
        /// 3905 - SIP address for room header
        /// </summary>
        public const uint RoomSipText = 3905;
        /// <summary>
        /// 3906 - The separator for verbose-header text on addresses
        /// </summary>
        public const uint RoomAddressPipeText = 3906;
        /// <summary>
        /// 3911
        /// </summary>
		public const uint PowerOffMessage = 3911;
        /// <summary>
        /// 3912
        /// </summary>
        public const uint StartPageMessage = 3912;
        /// <summary>
        /// 3913
        /// </summary>
        public const uint StartActivityText = 3913;
        /// <summary>
        /// 3914 Title bar label for source overlay
        /// </summary>
        public const uint SourceBackgroundOverlayTitle = 3914;

        /// <summary>
        /// 3915
        /// </summary>
        public const uint NotificationRibbonText = 3915;
		/// <summary>
		/// 3916 The "active call" label
		/// </summary>
		public const uint HeaderCallStatusLabel = 3916;

        /// <summary>
        /// 3922
        /// </summary>
        public const uint HelpMessage = 3922;
        /// <summary>
        /// 3923
        /// </summary>
        public const uint LogoUrl = 3923;
        /// <summary>
        /// 3924 - the text on the "call help desk" button
        /// </summary>
        public const uint HelpPageCallButtonText = 3924;

        /// <summary>
        /// 3961 Name of source on display 1
        /// </summary>
        public const uint Display1SourceLabel = 3961;
        /// <summary>
        /// 3962 Title above display 1
        /// </summary>
        public const uint Display1TitleLabel = 3962;
        /// <summary>
        /// 3964 Name of source on display 2
        /// </summary>
        public const uint Display2SourceLabel = 3964;
        /// <summary>
        /// 3965 Title above display 2
        /// </summary>
        public const uint Display2TitleLabel = 3965;

		/// <summary>
		/// 3966
		/// </summary>
		public const uint NextMeetingRibbonStartText = 3966;
		/// <summary>
		/// 3967
		/// </summary>
		public const uint NextMeetingRibbonEndText = 3967;
		/// <summary>
		/// 3968
		/// </summary>
		public const uint NextMeetingRibbonTitleText = 3968;
		/// <summary>
		/// 3969
		/// </summary>
		public const uint NextMettingRibbonNameText = 3969;
		/// <summary>
		/// 3970
		/// </summary>
		public const uint NextMeetingRibbonButtonLabel = 3970;
		/// <summary>
		/// 3971
		/// </summary>
		public const uint NextMeetingSecondaryButtonLabel = 3971;
		/// <summary>
		/// 3972
		/// </summary>
		public const uint NextMeetingFollowingMeetingText = 3972;

        /// <summary>
        /// 3996
        /// </summary>
        public const uint MeetingsOrContactMethodListIcon = 3996;

        /// <summary>
        /// 3997
        /// </summary>
        public const uint MeetingsOrContactMethodListTitleText = 3997;
 
    }
}