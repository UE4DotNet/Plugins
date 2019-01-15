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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct BTTask_PlayAnimation_fields {
        [FieldOffset(136)]  public IntPtr  AnimationToPlay;
        [FieldOffset(144)] public bool bLooping;
        [FieldOffset(144)] public bool bNonBlocking;
        [FieldOffset(152)]  public IntPtr  MyOwnerComp;
        [FieldOffset(160)]  public IntPtr  CachedSkelMesh;
    }
    internal unsafe struct BTTask_PlayAnimation_methods {
    }
    internal unsafe struct BTTask_PlayAnimation_events {
    }
}
