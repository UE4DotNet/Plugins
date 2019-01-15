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


namespace UE4.Paper2D.Native {
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct PaperSpriteAtlas_fields {
        [FieldOffset(56)] byte AtlasDescription; //TODO: string FString AtlasDescription
        [FieldOffset(72)] public int MaxWidth;
        [FieldOffset(76)] public int MaxHeight;
        [FieldOffset(80)] public int MipCount;
        [FieldOffset(84)] byte PaddingType; //TODO: enum EPaperSpriteAtlasPadding PaddingType
        [FieldOffset(88)] public int Padding;
        [FieldOffset(92)] public byte CompressionSettings;
        [FieldOffset(93)] public byte Filter;
        [FieldOffset(96)] public NativeArray GeneratedTextures;
        [FieldOffset(112)] public FGuid AtlasGUID;
        [FieldOffset(128)] public bool bRebuildAtlas;
        [FieldOffset(136)] public NativeArray AtlasSlots;
        [FieldOffset(152)] public int NumIncrementalBuilds;
        [FieldOffset(156)] public int BuiltWidth;
        [FieldOffset(160)] public int BuiltHeight;
        [FieldOffset(164)] public int BuiltPadding;
    }
    internal unsafe struct PaperSpriteAtlas_methods {
    }
    internal unsafe struct PaperSpriteAtlas_events {
    }
}
