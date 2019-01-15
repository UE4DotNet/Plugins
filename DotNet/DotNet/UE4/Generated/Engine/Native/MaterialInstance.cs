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
    [StructLayout( LayoutKind.Explicit, Size=752 )]
    internal unsafe struct MaterialInstance_fields {
        [FieldOffset(304)]  public IntPtr  PhysMaterial;
        [FieldOffset(312)]  public IntPtr  Parent;
        [FieldOffset(320)] public bool bHasStaticPermutationResource;
        [FieldOffset(320)] public bool bOverrideSubsurfaceProfile;
        [FieldOffset(328)] public NativeArray ScalarParameterValues;
        [FieldOffset(344)] public NativeArray VectorParameterValues;
        [FieldOffset(360)] public NativeArray TextureParameterValues;
        [FieldOffset(376)] public NativeArray FontParameterValues;
        [FieldOffset(396)] public MaterialInstanceBasePropertyOverrides BasePropertyOverrides;
        [FieldOffset(456)] public NativeArray PermutationTextureReferences;
        [FieldOffset(472)] public NativeArray ReferencedTextureGuids;
        [FieldOffset(488)] public StaticParameterSet StaticParameters;
    }
    internal unsafe struct MaterialInstance_methods {
    }
    internal unsafe struct MaterialInstance_events {
    }
}
