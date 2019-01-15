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
    ///<summary>Defines how the material reacts on DBuffer decals, later we can expose more variants between None and Default.</summary>
    public enum EMaterialDecalResponse {
        MDR_None = 0x00000000, 
        MDR_ColorNormalRoughness = 0x00000001, 
        MDR_Color = 0x00000002, 
        MDR_ColorNormal = 0x00000003, 
        MDR_ColorRoughness = 0x00000004, 
        MDR_Normal = 0x00000005, 
        MDR_NormalRoughness = 0x00000006, 
        MDR_Roughness = 0x00000007, 
        MDR_MAX = 0x00000008
    }
}
