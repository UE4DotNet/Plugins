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
    ///<summary>EParticle Sort Mode</summary>
    public enum EParticleSortMode {
        PSORTMODE_None = 0x00000000, 
        PSORTMODE_ViewProjDepth = 0x00000001, 
        PSORTMODE_DistanceToView = 0x00000002, 
        PSORTMODE_Age_OldestFirst = 0x00000003, 
        PSORTMODE_Age_NewestFirst = 0x00000004, 
        PSORTMODE_MAX = 0x00000005
    }
}
