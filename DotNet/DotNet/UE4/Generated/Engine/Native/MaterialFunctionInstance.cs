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
    [StructLayout( LayoutKind.Explicit, Size=216 )]
    internal unsafe struct MaterialFunctionInstance_fields {
        [FieldOffset(96)]  public IntPtr  Parent;
        [FieldOffset(104)]  public IntPtr  Base;
        [FieldOffset(112)] public NativeArray ScalarParameterValues;
        [FieldOffset(128)] public NativeArray VectorParameterValues;
        [FieldOffset(144)] public NativeArray TextureParameterValues;
        [FieldOffset(160)] public NativeArray FontParameterValues;
        [FieldOffset(176)] public NativeArray StaticSwitchParameterValues;
        [FieldOffset(192)] public NativeArray StaticComponentMaskParameterValues;
        [FieldOffset(208)]  public IntPtr  PreviewMaterial;
    }
    internal unsafe struct MaterialFunctionInstance_methods {
    }
    internal unsafe struct MaterialFunctionInstance_events {
    }
}
