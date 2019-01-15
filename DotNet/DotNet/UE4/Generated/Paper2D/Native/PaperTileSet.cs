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
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct PaperTileSet_fields {
        [FieldOffset(56)] public IntPoint TileSize;
        [FieldOffset(64)]  public IntPtr  TileSheet;
        [FieldOffset(72)] public NativeArray AdditionalSourceTextures;
        [FieldOffset(88)] public IntMargin BorderMargin;
        [FieldOffset(104)] public IntPoint PerTileSpacing;
        [FieldOffset(112)] public IntPoint DrawingOffset;
        [FieldOffset(120)] public LinearColor BackgroundColor;
        [FieldOffset(136)] public int WidthInTiles;
        [FieldOffset(140)] public int HeightInTiles;
        [FieldOffset(144)] public int AllocatedWidth;
        [FieldOffset(148)] public int AllocatedHeight;
        [FieldOffset(152)] public NativeArray PerTileData;
        [FieldOffset(168)] public NativeArray Terrains;
    }
    internal unsafe struct PaperTileSet_methods {
    }
    internal unsafe struct PaperTileSet_events {
    }
}
