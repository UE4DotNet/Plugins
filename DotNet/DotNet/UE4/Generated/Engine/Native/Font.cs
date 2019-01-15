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

namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=496 )]
    internal unsafe struct Font_fields {
        [FieldOffset(64)] byte FontCacheType; //TODO: enum EFontCacheType FontCacheType
        [FieldOffset(72)] public NativeArray Characters;
        [FieldOffset(88)] public NativeArray Textures;
        [FieldOffset(104)] public int IsRemapped;
        [FieldOffset(108)] public float EmScale;
        [FieldOffset(112)] public float Ascent;
        [FieldOffset(116)] public float Descent;
        [FieldOffset(120)] public float Leading;
        [FieldOffset(124)] public int Kerning;
        [FieldOffset(128)] public FontImportOptionsData ImportOptions;
        [FieldOffset(304)] public int NumCharacters;
        [FieldOffset(312)] public NativeArray MaxCharHeight;
        [FieldOffset(328)] public float ScalingFactor;
        [FieldOffset(332)] public int LegacyFontSize;
        [FieldOffset(336)] public Name LegacyFontName;
        [FieldOffset(352)] public CompositeFont CompositeFont;
    }
    internal unsafe struct Font_methods {
    }
    internal unsafe struct Font_events {
    }
}
