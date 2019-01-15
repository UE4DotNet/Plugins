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

namespace UE4.CoreUObject {
    ///<summary>Secondary condition to check before considering the replication of a lifetime property.</summary>
    public enum ELifetimeCondition {
        COND_None = 0x00000000, 
        COND_InitialOnly = 0x00000001, 
        COND_OwnerOnly = 0x00000002, 
        COND_SkipOwner = 0x00000003, 
        COND_SimulatedOnly = 0x00000004, 
        COND_AutonomousOnly = 0x00000005, 
        COND_SimulatedOrPhysics = 0x00000006, 
        COND_InitialOrOwner = 0x00000007, 
        COND_Custom = 0x00000008, 
        COND_ReplayOrOwner = 0x00000009, 
        COND_ReplayOnly = 0x0000000a, 
        COND_SimulatedOnlyNoReplay = 0x0000000b, 
        COND_SimulatedOrPhysicsNoReplay = 0x0000000c, 
        COND_SkipReplay = 0x0000000d, 
        COND_Max = 0x0000000e, 
        COND_MAX = 0x0000000f
    }
}
