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
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct DatasmithAreaLightActorTemplate_fields {
        [FieldOffset(56)] byte LightShape; //TODO: enum EDatasmithAreaLightActorShape LightShape
        [FieldOffset(60)] public Vector2D Dimensions;
        [FieldOffset(68)] public LinearColor Color;
        [FieldOffset(84)] public float Intensity;
        [FieldOffset(88)] public bool bHidden;
    }
    internal unsafe struct DatasmithAreaLightActorTemplate_methods {
    }
    internal unsafe struct DatasmithAreaLightActorTemplate_events {
    }
}
