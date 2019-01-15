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


namespace UE4.OnlineSubsystemUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=1128 )]
    internal unsafe struct OnlineBeaconClient_fields {
        [FieldOffset(1048)]  public IntPtr  BeaconOwner;
        [FieldOffset(1056)]  public IntPtr  BeaconConnection;
        [FieldOffset(1064)] byte ConnectionState; //TODO: enum EBeaconConnectionState ConnectionState
    }
    internal unsafe struct OnlineBeaconClient_methods {
    }
    internal unsafe struct OnlineBeaconClient_events {
    }
}
