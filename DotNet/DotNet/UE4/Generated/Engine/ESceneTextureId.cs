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
    ///<summary>like EPassInputId but can expose more e.g. GBuffer</summary>
    public enum ESceneTextureId {
        PPI_SceneColor = 0x00000000, 
        PPI_SceneDepth = 0x00000001, 
        PPI_DiffuseColor = 0x00000002, 
        PPI_SpecularColor = 0x00000003, 
        PPI_SubsurfaceColor = 0x00000004, 
        PPI_BaseColor = 0x00000005, 
        PPI_Specular = 0x00000006, 
        PPI_Metallic = 0x00000007, 
        PPI_WorldNormal = 0x00000008, 
        PPI_SeparateTranslucency = 0x00000009, 
        PPI_Opacity = 0x0000000a, 
        PPI_Roughness = 0x0000000b, 
        PPI_MaterialAO = 0x0000000c, 
        PPI_CustomDepth = 0x0000000d, 
        PPI_PostProcessInput0 = 0x0000000e, 
        PPI_PostProcessInput1 = 0x0000000f, 
        PPI_PostProcessInput2 = 0x00000010, 
        PPI_PostProcessInput3 = 0x00000011, 
        PPI_PostProcessInput4 = 0x00000012, 
        PPI_PostProcessInput5 = 0x00000013, 
        PPI_PostProcessInput6 = 0x00000014, 
        PPI_DecalMask = 0x00000015, 
        PPI_ShadingModelColor = 0x00000016, 
        PPI_ShadingModelID = 0x00000017, 
        PPI_AmbientOcclusion = 0x00000018, 
        PPI_CustomStencil = 0x00000019, 
        PPI_StoredBaseColor = 0x0000001a, 
        PPI_StoredSpecular = 0x0000001b, 
        PPI_MAX = 0x0000001c
    }
}
