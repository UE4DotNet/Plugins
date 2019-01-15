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
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct InterpTrackInstVectorMaterialParam_fields {
        [FieldOffset(56)] public NativeArray MaterialInstances;
        [FieldOffset(72)] public NativeArray ResetVectors;
        [FieldOffset(88)] public NativeArray PrimitiveMaterialRefs;
        [FieldOffset(104)]  public IntPtr  InstancedTrack;
    }
    internal unsafe struct InterpTrackInstVectorMaterialParam_methods {
    }
    internal unsafe struct InterpTrackInstVectorMaterialParam_events {
    }
}
