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

namespace UE4.Engine {
    ///<summary>Types of server travel failures broadcast by the engine</summary>
    public enum ETravelFailure {
        NoLevel = 0x00000000, 
        LoadMapFailure = 0x00000001, 
        InvalidURL = 0x00000002, 
        PackageMissing = 0x00000003, 
        PackageVersion = 0x00000004, 
        NoDownload = 0x00000005, 
        TravelFailure = 0x00000006, 
        CheatCommands = 0x00000007, 
        PendingNetGameCreateFailure = 0x00000008, 
        CloudSaveFailure = 0x00000009, 
        ServerTravelFailure = 0x0000000a, 
        ClientTravelFailure = 0x0000000b, 
        ETravelFailure_MAX = 0x0000000c
    }
}
