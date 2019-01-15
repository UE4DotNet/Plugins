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


namespace UE4.PaperSpriteSheetImporter.Native {
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct PaperSpriteSheet_fields {
        [FieldOffset(56)] public NativeArray SpriteNames;
        [FieldOffset(72)] public NativeArray Sprites;
        [FieldOffset(88)] byte TextureName; //TODO: string FString TextureName
        [FieldOffset(104)]  public IntPtr  Texture;
        [FieldOffset(112)] byte NormalMapTextureName; //TODO: string FString NormalMapTextureName
        [FieldOffset(128)]  public IntPtr  NormalMapTexture;
        [FieldOffset(136)]  public IntPtr  AssetImportData;
    }
    internal unsafe struct PaperSpriteSheet_methods {
    }
    internal unsafe struct PaperSpriteSheet_events {
    }
}
