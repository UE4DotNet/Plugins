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


namespace UE4.MeshPaint.Native {
    [StructLayout( LayoutKind.Explicit, Size=80 )]
    internal unsafe struct PaintBrushSettings_fields {
        [FieldOffset(56)] public float BrushRadius;
        [FieldOffset(68)] public float BrushStrength;
        [FieldOffset(72)] public float BrushFalloffAmount;
        [FieldOffset(76)] public bool bEnableFlow;
        [FieldOffset(77)] public bool bOnlyFrontFacingTriangles;
        [FieldOffset(78)] byte ColorViewMode; //TODO: enum EMeshPaintColorViewMode ColorViewMode
    }
    internal unsafe struct PaintBrushSettings_methods {
    }
    internal unsafe struct PaintBrushSettings_events {
    }
}
