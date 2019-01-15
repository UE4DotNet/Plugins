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
    ///<summary>Defines how the GBuffer channels are getting manipulated by a decal material pass. Actual index is used to control shader parameters so don't change order.</summary>
    public enum EDecalBlendMode {
        DBM_Translucent = 0x00000000, 
        DBM_Stain = 0x00000001, 
        DBM_Normal = 0x00000002, 
        DBM_Emissive = 0x00000003, 
        DBM_DBuffer_ColorNormalRoughness = 0x00000004, 
        DBM_DBuffer_Color = 0x00000005, 
        DBM_DBuffer_ColorNormal = 0x00000006, 
        DBM_DBuffer_ColorRoughness = 0x00000007, 
        DBM_DBuffer_Normal = 0x00000008, 
        DBM_DBuffer_NormalRoughness = 0x00000009, 
        DBM_DBuffer_Roughness = 0x0000000a, 
        DBM_Volumetric_DistanceFunction = 0x0000000b, 
        DBM_AlphaComposite = 0x0000000c, 
        DBM_AmbientOcclusion = 0x0000000d, 
        DBM_MAX = 0x0000000e
    }
}
