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
    ///<summary>Types of network failures broadcast from the engine</summary>
    public enum ENetworkFailure {
        NetDriverAlreadyExists = 0x00000000, 
        NetDriverCreateFailure = 0x00000001, 
        NetDriverListenFailure = 0x00000002, 
        ConnectionLost = 0x00000003, 
        ConnectionTimeout = 0x00000004, 
        FailureReceived = 0x00000005, 
        OutdatedClient = 0x00000006, 
        OutdatedServer = 0x00000007, 
        PendingConnectionFailure = 0x00000008, 
        NetGuidMismatch = 0x00000009, 
        NetChecksumMismatch = 0x0000000a, 
        ENetworkFailure_MAX = 0x0000000b
    }
}
