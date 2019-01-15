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
    ///<summary>Determines what a particle system will do when all of it's emitters become insignificant.</summary>
    public enum EParticleSystemInsignificanceReaction {
        Auto = 0x00000000, 
        Complete = 0x00000001, 
        DisableTick = 0x00000002, 
        DisableTickAndKill = 0x00000003, 
        Num = 0x00000004, 
        EParticleSystemInsignificanceReaction_MAX = 0x00000005
    }
}
