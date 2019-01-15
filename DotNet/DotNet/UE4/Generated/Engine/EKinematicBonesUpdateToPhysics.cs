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
    ///<summary>This enum defines how you'd like to update bones to physics world.</summary>
    ///<remarks>
    ///If bone is simulating, you don't have to waste time on updating bone transform from kinematic.
    ///      But also sometimes you don't like fixed bones to be updated by animation data.
    ///</remarks>
    public enum EKinematicBonesUpdateToPhysics {
        SkipSimulatingBones = 0x00000000, 
        SkipAllBones = 0x00000001, 
        EKinematicBonesUpdateToPhysics_MAX = 0x00000002
    }
}
