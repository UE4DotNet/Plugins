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
    ///<summary>Options that define how to blend when changing view targets.</summary>
    ///<remarks>
    ///@see FViewTargetTransitionParams, SetViewTarget
    ///</remarks>
    public enum EViewTargetBlendFunction {
        VTBlend_Linear = 0x00000000, 
        VTBlend_Cubic = 0x00000001, 
        VTBlend_EaseIn = 0x00000002, 
        VTBlend_EaseOut = 0x00000003, 
        VTBlend_EaseInOut = 0x00000004, 
        VTBlend_MAX = 0x00000005
    }
}
