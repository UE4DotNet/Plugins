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
    ///<summary>Note: This is mirrored in Lightmass, be sure to update the blend mode structure and logic there if this changes. // Note: Check UMaterialInstance::Serialize if changed!!</summary>
    public enum EBlendMode {
        BLEND_Opaque = 0x00000000, 
        BLEND_Masked = 0x00000001, 
        BLEND_Translucent = 0x00000002, 
        BLEND_Additive = 0x00000003, 
        BLEND_Modulate = 0x00000004, 
        BLEND_AlphaComposite = 0x00000005, 
        BLEND_MAX = 0x00000006
    }
}
