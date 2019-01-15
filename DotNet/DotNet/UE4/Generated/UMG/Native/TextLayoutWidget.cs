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
    [StructLayout( LayoutKind.Explicit, Size=416 )]
    internal unsafe struct TextLayoutWidget_fields {
        [FieldOffset(384)] public ShapedTextOptions ShapedTextOptions;
        [FieldOffset(387)] public byte Justification;
        [FieldOffset(388)] byte WrappingPolicy; //TODO: enum ETextWrappingPolicy WrappingPolicy
        [FieldOffset(389)] public bool AutoWrapText;
        [FieldOffset(392)] public float WrapTextAt;
        [FieldOffset(396)] public Margin Margin;
        [FieldOffset(412)] public float LineHeightPercentage;
    }
    internal unsafe struct TextLayoutWidget_methods {
    }
    internal unsafe struct TextLayoutWidget_events {
    }
}
