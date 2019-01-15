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
    ///<summary>More bounding vertices results in reduced overdraw, but adds more triangle overhead.</summary>
    ///<remarks>
    ///The eight vertex mode is best used when the SubUV texture has a lot of space to cut out that is not captured by the four vertex version,
    ///and when the particles using the texture will be few and large.
    ///</remarks>
    public enum ESubUVBoundingVertexCount {
        BVC_FourVertices = 0x00000000, 
        BVC_EightVertices = 0x00000001, 
        BVC_MAX = 0x00000002
    }
}
