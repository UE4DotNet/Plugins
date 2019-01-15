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
    ///<summary>Specifies which shader generated offsets should included in the world position (displacement/WPO etc.)</summary>
    public enum EWorldPositionIncludedOffsets {
        WPT_Default = 0x00000000, 
        WPT_ExcludeAllShaderOffsets = 0x00000001, 
        WPT_CameraRelative = 0x00000002, 
        WPT_CameraRelativeNoOffsets = 0x00000003, 
        WPT_MAX = 0x00000004
    }
}
