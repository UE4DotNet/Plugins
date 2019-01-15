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
    ///<summary>Enumerates available options for alpha channel through post processing.</summary>
    ///<remarks>
    ///The renderer will always generate premultiplied RGBA
    ///with alpha as translucency (0 = fully opaque; 1 = fully translucent).
    ///</remarks>
    public enum EAlphaChannelMode {
        Disabled = 0x00000000, 
        LinearColorSpaceOnly = 0x00000001, 
        AllowThroughTonemapper = 0x00000002, 
        EAlphaChannelMode_MAX = 0x00000003
    }
}
