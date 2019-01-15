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
    [StructLayout( LayoutKind.Explicit, Size=1152 )]
    internal unsafe struct ParticleModuleTypeDataGpu_fields {
        [FieldOffset(80)] public GPUSpriteEmitterInfo EmitterInfo;
        [FieldOffset(784)] public GPUSpriteResourceData ResourceData;
        [FieldOffset(1136)] public float CameraMotionBlurAmount;
        [FieldOffset(1140)] public bool bClearExistingParticlesOnInit;
    }
    internal unsafe struct ParticleModuleTypeDataGpu_methods {
    }
    internal unsafe struct ParticleModuleTypeDataGpu_events {
    }
}
