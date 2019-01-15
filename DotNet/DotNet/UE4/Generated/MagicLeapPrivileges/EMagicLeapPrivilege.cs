// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;

namespace UE4.MagicLeapPrivileges {
    ///<summary>Priviliges an app can request for from the system.</summary>
    public enum EMagicLeapPrivilege {
        Invalid = 0x00000000, 
        AddressBookRead = 0x00000001, 
        AddressBookWrite = 0x00000002, 
        AudioRecognizer = 0x00000003, 
        AudioSettings = 0x00000004, 
        BatteryInfo = 0x00000005, 
        CalendarRead = 0x00000006, 
        CalendarWrite = 0x00000007, 
        CameraCapture = 0x00000008, 
        DenseMap = 0x00000009, 
        EmailSend = 0x0000000a, 
        Eyetrack = 0x0000000b, 
        Headpose = 0x0000000c, 
        InAppPurchase = 0x0000000d, 
        Location = 0x0000000e, 
        AudioCaptureMic = 0x0000000f, 
        DrmCertificates = 0x00000010, 
        Occlusion = 0x00000011, 
        ScreenCapture = 0x00000012, 
        Internet = 0x00000013, 
        AudioCaptureMixed = 0x00000014, 
        IdentityRead = 0x00000015, 
        IdentityModify = 0x00000016, 
        BackgroundDownload = 0x00000017, 
        BackgroundUpload = 0x00000018, 
        MediaDrm = 0x00000019, 
        Media = 0x0000001a, 
        MediaMetadata = 0x0000001b, 
        PowerInfo = 0x0000001c, 
        AudioCaptureVirtual = 0x0000001d, 
        CalibrationRigModelRead = 0x0000001e, 
        NetworkServer = 0x0000001f, 
        LocalAreaNetwork = 0x00000020, 
        VoiceInput = 0x00000021, 
        ConnectBackgroundMusicService = 0x00000022, 
        RegisterBackgroundMusicService = 0x00000023, 
        NormalNotificationsUsage = 0x00000024, 
        MusicService = 0x00000025, 
        BackgroundLowLatencyLightwear = 0x00000026, 
        EMagicLeapPrivilege_MAX = 0x00000027
    }
}
