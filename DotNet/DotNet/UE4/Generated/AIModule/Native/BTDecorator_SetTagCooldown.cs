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

using UE4.GameplayTags;

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct BTDecorator_SetTagCooldown_fields {
        [FieldOffset(128)] public GameplayTag CooldownTag;
        [FieldOffset(140)] public float CooldownDuration;
        [FieldOffset(144)] public bool bAddToExistingDuration;
    }
    internal unsafe struct BTDecorator_SetTagCooldown_methods {
    }
    internal unsafe struct BTDecorator_SetTagCooldown_events {
    }
}
