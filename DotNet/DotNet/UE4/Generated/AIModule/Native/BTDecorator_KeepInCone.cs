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
    [StructLayout( LayoutKind.Explicit, Size=240 )]
    internal unsafe struct BTDecorator_KeepInCone_fields {
        [FieldOffset(128)] public float ConeHalfAngle;
        [FieldOffset(136)] public BlackboardKeySelector ConeOrigin;
        [FieldOffset(184)] public BlackboardKeySelector Observed;
        [FieldOffset(232)] public bool bUseSelfAsOrigin;
        [FieldOffset(232)] public bool bUseSelfAsObserved;
    }
    internal unsafe struct BTDecorator_KeepInCone_methods {
    }
    internal unsafe struct BTDecorator_KeepInCone_events {
    }
}
