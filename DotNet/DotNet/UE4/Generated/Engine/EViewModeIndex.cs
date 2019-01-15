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
    ///<summary>Define view modes to get specific show flag settings (some on, some off and some are not altered)</summary>
    ///<remarks>Don't change the order, the ID is serialized with the editor</remarks>
    public enum EViewModeIndex {
        VMI_BrushWireframe = 0x00000000, 
        VMI_Wireframe = 0x00000001, 
        VMI_Unlit = 0x00000002, 
        VMI_Lit = 0x00000003, 
        VMI_Lit_DetailLighting = 0x00000004, 
        VMI_LightingOnly = 0x00000005, 
        VMI_LightComplexity = 0x00000006, 
        VMI_ShaderComplexity = 0x00000008, 
        VMI_LightmapDensity = 0x00000009, 
        VMI_LitLightmapDensity = 0x0000000a, 
        VMI_ReflectionOverride = 0x0000000b, 
        VMI_VisualizeBuffer = 0x0000000c, 
        VMI_StationaryLightOverlap = 0x0000000e, 
        VMI_CollisionPawn = 0x0000000f, 
        VMI_CollisionVisibility = 0x00000010, 
        VMI_LODColoration = 0x00000012, 
        VMI_QuadOverdraw = 0x00000013, 
        VMI_PrimitiveDistanceAccuracy = 0x00000014, 
        VMI_MeshUVDensityAccuracy = 0x00000015, 
        VMI_ShaderComplexityWithQuadOverdraw = 0x00000016, 
        VMI_HLODColoration = 0x00000017, 
        VMI_GroupLODColoration = 0x00000018, 
        VMI_MaterialTextureScaleAccuracy = 0x00000019, 
        VMI_RequiredTextureResolution = 0x0000001a, 
        VMI_Max = 0x0000001b, 
        VMI_Unknown = 0x000000ff, 
        VMI_MAX = 0x00000100
    }
}
