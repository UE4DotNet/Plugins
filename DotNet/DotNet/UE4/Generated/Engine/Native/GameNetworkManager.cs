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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1152 )]
    internal unsafe struct GameNetworkManager_fields {
        [FieldOffset(1016)] public int AdjustedNetSpeed;
        [FieldOffset(1020)] public float LastNetSpeedUpdateTime;
        [FieldOffset(1024)] public int TotalNetBandwidth;
        [FieldOffset(1028)] public int MinDynamicBandwidth;
        [FieldOffset(1032)] public int MaxDynamicBandwidth;
        [FieldOffset(1036)] public bool bIsStandbyCheckingEnabled;
        [FieldOffset(1036)] public bool bHasStandbyCheatTriggered;
        [FieldOffset(1040)] public float StandbyRxCheatTime;
        [FieldOffset(1044)] public float StandbyTxCheatTime;
        [FieldOffset(1048)] public int BadPingThreshold;
        [FieldOffset(1052)] public float PercentMissingForRxStandby;
        [FieldOffset(1056)] public float PercentMissingForTxStandby;
        [FieldOffset(1060)] public float PercentForBadPing;
        [FieldOffset(1064)] public float JoinInProgressStandbyWaitTime;
        [FieldOffset(1068)] public float MoveRepSize;
        [FieldOffset(1072)] public float MAXPOSITIONERRORSQUARED;
        [FieldOffset(1076)] public float MAXNEARZEROVELOCITYSQUARED;
        [FieldOffset(1080)] public float CLIENTADJUSTUPDATECOST;
        [FieldOffset(1084)] public float MAXCLIENTUPDATEINTERVAL;
        [FieldOffset(1088)] public float MaxMoveDeltaTime;
        [FieldOffset(1092)] public float ClientNetSendMoveDeltaTime;
        [FieldOffset(1096)] public float ClientNetSendMoveDeltaTimeThrottled;
        [FieldOffset(1100)] public float ClientNetSendMoveDeltaTimeStationary;
        [FieldOffset(1104)] public int ClientNetSendMoveThrottleAtNetSpeed;
        [FieldOffset(1108)] public int ClientNetSendMoveThrottleOverPlayerCount;
        [FieldOffset(1112)] public bool ClientAuthorativePosition;
        [FieldOffset(1116)] public float ClientErrorUpdateRateLimit;
        [FieldOffset(1120)] public bool bMovementTimeDiscrepancyDetection;
        [FieldOffset(1121)] public bool bMovementTimeDiscrepancyResolution;
        [FieldOffset(1124)] public float MovementTimeDiscrepancyMaxTimeMargin;
        [FieldOffset(1128)] public float MovementTimeDiscrepancyMinTimeMargin;
        [FieldOffset(1132)] public float MovementTimeDiscrepancyResolutionRate;
        [FieldOffset(1136)] public float MovementTimeDiscrepancyDriftAllowance;
        [FieldOffset(1140)] public bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution;
        [FieldOffset(1141)] public bool bUseDistanceBasedRelevancy;
    }
    internal unsafe struct GameNetworkManager_methods {
    }
    internal unsafe struct GameNetworkManager_events {
    }
}
