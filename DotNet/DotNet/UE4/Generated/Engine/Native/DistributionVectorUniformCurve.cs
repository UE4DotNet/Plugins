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
    internal unsafe struct DistributionVectorUniformCurve_fields {
        [FieldOffset(72)] public InterpCurveTwoVectors ConstantCurve;
        [FieldOffset(96)] public bool bLockAxes1;
        [FieldOffset(96)] public bool bLockAxes2;
        [FieldOffset(100)] public byte LockedAxes;
        [FieldOffset(102)] public byte MirrorFlags;
        [FieldOffset(108)] public bool bUseExtremes;
    }
    internal unsafe struct DistributionVectorUniformCurve_methods {
    }
    internal unsafe struct DistributionVectorUniformCurve_events {
    }
}
