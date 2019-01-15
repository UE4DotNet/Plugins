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
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct AnimNotifyState_TimedParticleEffect_fields {
        [FieldOffset(64)]  public IntPtr  PSTemplate;
        [FieldOffset(72)] public Name SocketName;
        [FieldOffset(84)] public Vector LocationOffset;
        [FieldOffset(96)] public Rotator RotationOffset;
        [FieldOffset(108)] public bool bDestroyAtEnd;
        [FieldOffset(112)] public NativeArray PreviousPSTemplates;
        [FieldOffset(128)] public NativeArray PreviousSocketNames;
    }
    internal unsafe struct AnimNotifyState_TimedParticleEffect_methods {
    }
    internal unsafe struct AnimNotifyState_TimedParticleEffect_events {
    }
}
