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
    [StructLayout( LayoutKind.Explicit, Size=280 )]
    internal unsafe struct PaperTileMap_fields {
        [FieldOffset(56)] public int MapWidth;
        [FieldOffset(60)] public int MapHeight;
        [FieldOffset(64)] public int TileWidth;
        [FieldOffset(68)] public int TileHeight;
        [FieldOffset(72)] public float PixelsPerUnrealUnit;
        [FieldOffset(76)] public float SeparationPerTileX;
        [FieldOffset(80)] public float SeparationPerTileY;
        [FieldOffset(84)] public float SeparationPerLayer;
        [FieldOffset(88)] byte SelectedTileSet; //TODO: soft object TSoftObjectPtr<UPaperTileSet> SelectedTileSet
        [FieldOffset(136)]  public IntPtr  Material;
        [FieldOffset(144)] public NativeArray TileLayers;
        [FieldOffset(160)] public float CollisionThickness;
        [FieldOffset(164)] public byte SpriteCollisionDomain;
        [FieldOffset(165)] public byte ProjectionMode;
        [FieldOffset(168)] public int HexSideLength;
        [FieldOffset(176)]  public IntPtr  BodySetup;
        [FieldOffset(184)]  public IntPtr  AssetImportData;
        [FieldOffset(192)] public int SelectedLayerIndex;
        [FieldOffset(196)] public LinearColor BackgroundColor;
        [FieldOffset(212)] public LinearColor TileGridColor;
        [FieldOffset(228)] public LinearColor MultiTileGridColor;
        [FieldOffset(244)] public int MultiTileGridWidth;
        [FieldOffset(248)] public int MultiTileGridHeight;
        [FieldOffset(252)] public int MultiTileGridOffsetX;
        [FieldOffset(256)] public int MultiTileGridOffsetY;
        [FieldOffset(260)] public LinearColor LayerGridColor;
        [FieldOffset(276)] public int LayerNameIndex;
    }
    internal unsafe struct PaperTileMap_methods {
    }
    internal unsafe struct PaperTileMap_events {
    }
}
