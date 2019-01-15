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
    ///<summary>Controls behavior of WalkableSlopeOverride, determining how to affect walkability of surfaces for Characters.</summary>
    ///<remarks>
    ///@see FWalkableSlopeOverride
    ///@see UCharacterMovementComponent::GetWalkableFloorAngle(), UCharacterMovementComponent::SetWalkableFloorAngle()
    ///</remarks>
    public enum EWalkableSlopeBehavior {
        WalkableSlope_Default = 0x00000000, 
        WalkableSlope_Increase = 0x00000001, 
        WalkableSlope_Decrease = 0x00000002, 
        WalkableSlope_Unwalkable = 0x00000003, 
        WalkableSlope_Max = 0x00000004, 
        WalkableSlope_MAX = 0x00000005
    }
}
