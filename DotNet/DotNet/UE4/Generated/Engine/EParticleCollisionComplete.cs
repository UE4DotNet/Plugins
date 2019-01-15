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
    ///<summary>Flags indicating what to do with the particle when MaxCollisions is reached</summary>
    public enum EParticleCollisionComplete {
        EPCC_Kill = 0x00000000, 
        EPCC_Freeze = 0x00000001, 
        EPCC_HaltCollisions = 0x00000002, 
        EPCC_FreezeTranslation = 0x00000003, 
        EPCC_FreezeRotation = 0x00000004, 
        EPCC_FreezeMovement = 0x00000005, 
        EPCC_MAX = 0x00000006
    }
}
