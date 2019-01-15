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
    [StructLayout( LayoutKind.Explicit, Size=160 )]
    internal unsafe struct AnimNotify_PlayParticleEffect_fields {
        [FieldOffset(72)]  public IntPtr  PSTemplate;
        [FieldOffset(80)] public Vector LocationOffset;
        [FieldOffset(92)] public Rotator RotationOffset;
        [FieldOffset(104)] public Vector Scale;
        [FieldOffset(144)] public bool Attached;
        [FieldOffset(148)] public Name SocketName;
    }
    internal unsafe struct AnimNotify_PlayParticleEffect_methods {
    }
    internal unsafe struct AnimNotify_PlayParticleEffect_events {
    }
}
