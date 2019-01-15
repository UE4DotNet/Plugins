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
    internal unsafe struct ParticleModuleTypeDataMesh_fields {
        [FieldOffset(72)]  public IntPtr  Mesh;
        [FieldOffset(80)] public bool bUseStaticMeshLODs;
        [FieldOffset(84)] public float LODSizeScale;
        [FieldOffset(88)] public bool CastShadows;
        [FieldOffset(88)] public bool DoCollisions;
        [FieldOffset(92)] public byte MeshAlignment;
        [FieldOffset(96)] public bool bOverrideMaterial;
        [FieldOffset(96)] public bool bOverrideDefaultMotionBlurSettings;
        [FieldOffset(96)] public bool bEnableMotionBlur;
        [FieldOffset(112)] public RawDistributionVector RollPitchYawRange;
        [FieldOffset(200)] public byte AxisLockOption;
        [FieldOffset(204)] public bool bCameraFacing;
        [FieldOffset(209)] public byte CameraFacingOption;
        [FieldOffset(212)] public bool bApplyParticleRotationAsSpin;
        [FieldOffset(212)] public bool bFaceCameraDirectionRatherThanPosition;
        [FieldOffset(212)] public bool bCollisionsConsiderPartilceSize;
    }
    internal unsafe struct ParticleModuleTypeDataMesh_methods {
    }
    internal unsafe struct ParticleModuleTypeDataMesh_events {
    }
}
