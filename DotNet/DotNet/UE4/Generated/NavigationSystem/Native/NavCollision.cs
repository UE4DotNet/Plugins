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


namespace UE4.NavigationSystem.Native {
    [StructLayout( LayoutKind.Explicit, Size=272 )]
    internal unsafe struct NavCollision_fields {
        [FieldOffset(184)] public NativeArray CylinderCollision;
        [FieldOffset(200)] public NativeArray BoxCollision;
        [FieldOffset(216)] public IntPtr AreaClass;
        [FieldOffset(224)] public bool bGatherConvexGeometry;
    }
    internal unsafe struct NavCollision_methods {
    }
    internal unsafe struct NavCollision_events {
    }
}
