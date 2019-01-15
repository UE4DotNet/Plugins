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
    internal unsafe struct DistributionVectorUniform_fields {
        [FieldOffset(72)] public Vector Max;
        [FieldOffset(84)] public Vector Min;
        [FieldOffset(96)] public bool bLockAxes;
        [FieldOffset(100)] public byte LockedAxes;
        [FieldOffset(101)] public byte MirrorFlags;
        [FieldOffset(104)] public bool bUseExtremes;
    }
    internal unsafe struct DistributionVectorUniform_methods {
    }
    internal unsafe struct DistributionVectorUniform_events {
    }
}
