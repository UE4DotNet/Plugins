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

using UE4.InputCore;

namespace UE4.GameplayDebugger.Native {
    [StructLayout( LayoutKind.Explicit, Size=712 )]
    internal unsafe struct GameplayDebuggerConfig_fields {
        [FieldOffset(56)] public Key ActivationKey;
        [FieldOffset(88)] public Key CategoryRowNextKey;
        [FieldOffset(120)] public Key CategoryRowPrevKey;
        [FieldOffset(152)] public Key CategorySlot0;
        [FieldOffset(184)] public Key CategorySlot1;
        [FieldOffset(216)] public Key CategorySlot2;
        [FieldOffset(248)] public Key CategorySlot3;
        [FieldOffset(280)] public Key CategorySlot4;
        [FieldOffset(312)] public Key CategorySlot5;
        [FieldOffset(344)] public Key CategorySlot6;
        [FieldOffset(376)] public Key CategorySlot7;
        [FieldOffset(408)] public Key CategorySlot8;
        [FieldOffset(440)] public Key CategorySlot9;
        [FieldOffset(472)] public float DebugCanvasPaddingLeft;
        [FieldOffset(476)] public float DebugCanvasPaddingRight;
        [FieldOffset(480)] public float DebugCanvasPaddingTop;
        [FieldOffset(484)] public float DebugCanvasPaddingBottom;
        [FieldOffset(488)] public NativeArray Categories;
        [FieldOffset(504)] public NativeArray Extensions;
    }
    internal unsafe struct GameplayDebuggerConfig_methods {
    }
    internal unsafe struct GameplayDebuggerConfig_events {
    }
}
