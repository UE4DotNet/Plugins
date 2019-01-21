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
    ///<summary>Skinned Mesh Animation Tick option based on rendered or not. This dictates "TickPose and RefreshBoneTransforms"</summary>
    public enum EVisibilityBasedAnimTickOption {
        AlwaysTickPoseAndRefreshBones = 0x00000000, 
        AlwaysTickPose = 0x00000001, 
        OnlyTickMontagesWhenNotRendered = 0x00000002, 
        OnlyTickPoseWhenRendered = 0x00000003, 
        EVisibilityBasedAnimTickOption_MAX = 0x00000004
    }
}
