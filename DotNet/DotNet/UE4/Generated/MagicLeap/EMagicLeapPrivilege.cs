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

namespace UE4.MagicLeap {
    ///<summary>Priviliges an app can request for from the system.</summary>
    public enum EMagicLeapPrivilege {
        Invalid = 0x00000000, 
        AudioRecognizer = 0x00000001, 
        BatteryInfo = 0x00000002, 
        CameraCapture = 0x00000003, 
        WorldReconstruction = 0x00000004, 
        InAppPurchase = 0x00000005, 
        AudioCaptureMic = 0x00000006, 
        DrmCertificates = 0x00000007, 
        Occlusion = 0x00000008, 
        LowLatencyLightwear = 0x00000009, 
        Internet = 0x0000000a, 
        IdentityRead = 0x0000000b, 
        BackgroundDownload = 0x0000000c, 
        BackgroundUpload = 0x0000000d, 
        MediaDrm = 0x0000000e, 
        Media = 0x0000000f, 
        MediaMetadata = 0x00000010, 
        PowerInfo = 0x00000011, 
        LocalAreaNetwork = 0x00000012, 
        VoiceInput = 0x00000013, 
        Documents = 0x00000014, 
        ConnectBackgroundMusicService = 0x00000015, 
        RegisterBackgroundMusicService = 0x00000016, 
        PwFoundObjRead = 0x00000017, 
        NormalNotificationsUsage = 0x00000018, 
        MusicService = 0x00000019, 
        ControllerPose = 0x0000001a, 
        ScreensProvider = 0x0000001b, 
        GesturesSubscribe = 0x0000001c, 
        GesturesConfig = 0x0000001d, 
        EMagicLeapPrivilege_MAX = 0x0000001e
    }
}
