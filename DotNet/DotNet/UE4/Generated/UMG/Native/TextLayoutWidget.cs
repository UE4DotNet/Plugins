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

using UE4.SlateCore;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=432 )]
    internal unsafe struct TextLayoutWidget_fields {
        [FieldOffset(400)] public ShapedTextOptions ShapedTextOptions;
        [FieldOffset(403)] public byte Justification;
        [FieldOffset(404)] byte WrappingPolicy; //TODO: enum ETextWrappingPolicy WrappingPolicy
        [FieldOffset(405)] public bool AutoWrapText;
        [FieldOffset(408)] public float WrapTextAt;
        [FieldOffset(412)] public Margin Margin;
        [FieldOffset(428)] public float LineHeightPercentage;
    }
    internal unsafe struct TextLayoutWidget_methods {
    }
    internal unsafe struct TextLayoutWidget_events {
    }
}
