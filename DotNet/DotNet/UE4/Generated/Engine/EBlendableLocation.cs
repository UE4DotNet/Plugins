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
    ///<summary>Where to place a material node in the post processing graph.</summary>
    public enum EBlendableLocation {
        BL_AfterTonemapping = 0x00000000, 
        BL_BeforeTonemapping = 0x00000001, 
        BL_BeforeTranslucency = 0x00000002, 
        BL_ReplacingTonemapper = 0x00000003, 
        BL_SSRInput = 0x00000004, 
        BL_MAX = 0x00000005
    }
}
