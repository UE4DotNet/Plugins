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


namespace UE4.EngineSettings.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct GameNetworkManagerSettings_fields {
        [FieldOffset(56)] public int MinDynamicBandwidth;
        [FieldOffset(60)] public int MaxDynamicBandwidth;
        [FieldOffset(64)] public int TotalNetBandwidth;
        [FieldOffset(68)] public int BadPingThreshold;
        [FieldOffset(72)] public bool bIsStandbyCheckingEnabled;
        [FieldOffset(76)] public float StandbyRxCheatTime;
        [FieldOffset(80)] public float StandbyTxCheatTime;
        [FieldOffset(84)] public float PercentMissingForRxStandby;
        [FieldOffset(88)] public float PercentMissingForTxStandby;
        [FieldOffset(92)] public float PercentForBadPing;
        [FieldOffset(96)] public float JoinInProgressStandbyWaitTime;
    }
    internal unsafe struct GameNetworkManagerSettings_methods {
    }
    internal unsafe struct GameNetworkManagerSettings_events {
    }
}
