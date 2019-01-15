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
    ///<summary>Determines which ticking group a tick function belongs to.</summary>
    public enum ETickingGroup {
        TG_PrePhysics = 0x00000000, 
        TG_StartPhysics = 0x00000001, 
        TG_DuringPhysics = 0x00000002, 
        TG_EndPhysics = 0x00000003, 
        TG_PostPhysics = 0x00000004, 
        TG_PostUpdateWork = 0x00000005, 
        TG_LastDemotable = 0x00000006, 
        TG_NewlySpawned = 0x00000007, 
        TG_MAX = 0x00000008
    }
}
