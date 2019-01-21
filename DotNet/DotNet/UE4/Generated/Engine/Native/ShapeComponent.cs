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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1536 )]
    internal unsafe struct ShapeComponent_fields {
        [FieldOffset(1504)]  public IntPtr  ShapeBodySetup;
        [FieldOffset(1512)] public Color ShapeColor;
        [FieldOffset(1516)] public bool bDrawOnlyIfSelected;
        [FieldOffset(1516)] public bool bShouldCollideWhenPlacing;
        [FieldOffset(1516)] public bool bDynamicObstacle;
        [FieldOffset(1520)] public IntPtr AreaClass;
    }
    internal unsafe struct ShapeComponent_methods {
    }
    internal unsafe struct ShapeComponent_events {
    }
}
