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

namespace UE4.NetcodeUnitTest {
    ///<summary>Flags for configuring the minimal client, what parts of the netcode should be enabled etc.</summary>
    public enum EMinClientFlags {
        None = 0x00000000, 
        AcceptActors = 0x00000001, 
        AcceptRPCs = 0x00000002, 
        SendRPCs = 0x00000004, 
        SkipControlJoin = 0x00000008, 
        BeaconConnect = 0x00000010, 
        NotifyNetActors = 0x00000100, 
        NotifyProcessNetEvent = 0x00000200, 
        DumpReceivedRaw = 0x00001000, 
        DumpSendRaw = 0x00002000, 
        DumpReceivedRPC = 0x00004000, 
        DumpSendRPC = 0x00008000, 
        EMinClientFlags_MAX = 0x00008001
    }
}
