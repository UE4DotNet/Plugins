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


namespace UE4.DatasmithContent.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct DatasmithLightComponentTemplate_fields {
        [FieldOffset(56)] public bool bVisible;
        [FieldOffset(60)] public bool CastShadows;
        [FieldOffset(60)] public bool bUseTemperature;
        [FieldOffset(60)] public bool bUseIESBrightness;
        [FieldOffset(64)] public float Intensity;
        [FieldOffset(68)] public float Temperature;
        [FieldOffset(72)] public float IESBrightnessScale;
        [FieldOffset(76)] public LinearColor LightColor;
        [FieldOffset(96)]  public IntPtr  LightFunctionMaterial;
        [FieldOffset(104)]  public IntPtr  IESTexture;
    }
    internal unsafe struct DatasmithLightComponentTemplate_methods {
    }
    internal unsafe struct DatasmithLightComponentTemplate_events {
    }
}
