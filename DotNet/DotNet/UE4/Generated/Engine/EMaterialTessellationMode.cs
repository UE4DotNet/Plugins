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
    ///<summary>This is used by the drawing passes to determine tessellation policy, so changes here need to be supported in native code.</summary>
    public enum EMaterialTessellationMode {
        MTM_NoTessellation = 0x00000000, 
        MTM_FlatTessellation = 0x00000001, 
        MTM_PNTriangles = 0x00000002, 
        MTM_MAX = 0x00000003
    }
}
