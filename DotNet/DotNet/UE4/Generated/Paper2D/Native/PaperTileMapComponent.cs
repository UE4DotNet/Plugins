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
    [StructLayout( LayoutKind.Explicit, Size=1664 )]
    internal unsafe struct PaperTileMapComponent_fields {
        [FieldOffset(1608)] public LinearColor TileMapColor;
        [FieldOffset(1624)] public int UseSingleLayerIndex;
        [FieldOffset(1628)] public bool bUseSingleLayer;
        [FieldOffset(1640)]  public IntPtr  TileMap;
        [FieldOffset(1648)] public bool bShowPerTileGridWhenSelected;
        [FieldOffset(1649)] public bool bShowPerLayerGridWhenSelected;
        [FieldOffset(1650)] public bool bShowOutlineWhenUnselected;
        [FieldOffset(1651)] public bool bShowPerTileGridWhenUnselected;
        [FieldOffset(1652)] public bool bShowPerLayerGridWhenUnselected;
    }
    internal unsafe struct PaperTileMapComponent_methods {
        internal struct AddNewLayer_method {
            static internal IntPtr AddNewLayer_ptr;
            static AddNewLayer_method() {
                AddNewLayer_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "AddNewLayer");
            }

            internal static unsafe PaperTileLayer Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, AddNewLayer_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct CreateNewTileMap_method {
            static internal IntPtr CreateNewTileMap_ptr;
            static CreateNewTileMap_method() {
                CreateNewTileMap_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "CreateNewTileMap");
            }

            internal static unsafe void Invoke(IntPtr obj, int MapWidth, int MapHeight, int TileWidth, int TileHeight, float PixelsPerUnrealUnit, bool bCreateLayer) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MapWidth;
                *((int*)(b+4)) = MapHeight;
                *((int*)(b+8)) = TileWidth;
                *((int*)(b+12)) = TileHeight;
                *((float*)(b+16)) = PixelsPerUnrealUnit;
                *((bool*)(b+20)) = bCreateLayer;
                Main.GetProcessEvent(obj, CreateNewTileMap_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetLayerColor_method {
            static internal IntPtr GetLayerColor_ptr;
            static GetLayerColor_method() {
                GetLayerColor_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "GetLayerColor");
            }

            internal static unsafe LinearColor Invoke(IntPtr obj, int Layer) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Layer;
                Main.GetProcessEvent(obj, GetLayerColor_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+4));
            }
        }
        internal struct GetMapSize_method {
            static internal IntPtr GetMapSize_ptr;
            static GetMapSize_method() {
                GetMapSize_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "GetMapSize");
            }

            internal static unsafe (int, int, int) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMapSize_ptr, new IntPtr(p)); ;
                return (*((int*)(b+0)),*((int*)(b+4)),*((int*)(b+8)));
            }
        }
        internal struct GetTile_method {
            static internal IntPtr GetTile_ptr;
            static GetTile_method() {
                GetTile_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "GetTile");
            }

            internal static unsafe PaperTileInfo Invoke(IntPtr obj, int X, int Y, int Layer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = X;
                *((int*)(b+4)) = Y;
                *((int*)(b+8)) = Layer;
                Main.GetProcessEvent(obj, GetTile_ptr, new IntPtr(p)); ;
                return *((PaperTileInfo*)(b+16));
            }
        }
        internal struct GetTileCenterPosition_method {
            static internal IntPtr GetTileCenterPosition_ptr;
            static GetTileCenterPosition_method() {
                GetTileCenterPosition_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "GetTileCenterPosition");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int TileX, int TileY, int LayerIndex, bool bWorldSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TileX;
                *((int*)(b+4)) = TileY;
                *((int*)(b+8)) = LayerIndex;
                *((bool*)(b+12)) = bWorldSpace;
                Main.GetProcessEvent(obj, GetTileCenterPosition_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct GetTileCornerPosition_method {
            static internal IntPtr GetTileCornerPosition_ptr;
            static GetTileCornerPosition_method() {
                GetTileCornerPosition_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "GetTileCornerPosition");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int TileX, int TileY, int LayerIndex, bool bWorldSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TileX;
                *((int*)(b+4)) = TileY;
                *((int*)(b+8)) = LayerIndex;
                *((bool*)(b+12)) = bWorldSpace;
                Main.GetProcessEvent(obj, GetTileCornerPosition_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct GetTileMapColor_method {
            static internal IntPtr GetTileMapColor_ptr;
            static GetTileMapColor_method() {
                GetTileMapColor_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "GetTileMapColor");
            }

            internal static unsafe LinearColor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTileMapColor_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+0));
            }
        }
        internal struct GetTilePolygon_method {
            static internal IntPtr GetTilePolygon_ptr;
            static GetTilePolygon_method() {
                GetTilePolygon_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "GetTilePolygon");
            }

            internal static unsafe IReadOnlyCollection<Vector> Invoke(IntPtr obj, int TileX, int TileY, int LayerIndex, bool bWorldSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TileX;
                *((int*)(b+4)) = TileY;
                *((int*)(b+24)) = LayerIndex;
                *((bool*)(b+28)) = bWorldSpace;
                Main.GetProcessEvent(obj, GetTilePolygon_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Points
                return UObject.ToUnmangedCollection<Vector>(b+8);
            }
        }
        internal struct MakeTileMapEditable_method {
            static internal IntPtr MakeTileMapEditable_ptr;
            static MakeTileMapEditable_method() {
                MakeTileMapEditable_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "MakeTileMapEditable");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, MakeTileMapEditable_ptr, new IntPtr(p)); ;
            }
        }
        internal struct OwnsTileMap_method {
            static internal IntPtr OwnsTileMap_ptr;
            static OwnsTileMap_method() {
                OwnsTileMap_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "OwnsTileMap");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, OwnsTileMap_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct RebuildCollision_method {
            static internal IntPtr RebuildCollision_ptr;
            static RebuildCollision_method() {
                RebuildCollision_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "RebuildCollision");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RebuildCollision_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResizeMap_method {
            static internal IntPtr ResizeMap_ptr;
            static ResizeMap_method() {
                ResizeMap_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "ResizeMap");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewWidthInTiles, int NewHeightInTiles) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewWidthInTiles;
                *((int*)(b+4)) = NewHeightInTiles;
                Main.GetProcessEvent(obj, ResizeMap_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDefaultCollisionThickness_method {
            static internal IntPtr SetDefaultCollisionThickness_ptr;
            static SetDefaultCollisionThickness_method() {
                SetDefaultCollisionThickness_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "SetDefaultCollisionThickness");
            }

            internal static unsafe void Invoke(IntPtr obj, float Thickness, bool bRebuildCollision) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Thickness;
                *((bool*)(b+4)) = bRebuildCollision;
                Main.GetProcessEvent(obj, SetDefaultCollisionThickness_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLayerCollision_method {
            static internal IntPtr SetLayerCollision_ptr;
            static SetLayerCollision_method() {
                SetLayerCollision_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "SetLayerCollision");
            }

            internal static unsafe void Invoke(IntPtr obj, int Layer, bool bHasCollision, bool bOverrideThickness, float CustomThickness, bool bOverrideOffset, float CustomOffset, bool bRebuildCollision) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Layer;
                *((bool*)(b+4)) = bHasCollision;
                *((bool*)(b+5)) = bOverrideThickness;
                *((float*)(b+8)) = CustomThickness;
                *((bool*)(b+12)) = bOverrideOffset;
                *((float*)(b+16)) = CustomOffset;
                *((bool*)(b+20)) = bRebuildCollision;
                Main.GetProcessEvent(obj, SetLayerCollision_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLayerColor_method {
            static internal IntPtr SetLayerColor_ptr;
            static SetLayerColor_method() {
                SetLayerColor_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "SetLayerColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewColor, int Layer) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewColor;
                *((int*)(b+16)) = Layer;
                Main.GetProcessEvent(obj, SetLayerColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTile_method {
            static internal IntPtr SetTile_ptr;
            static SetTile_method() {
                SetTile_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "SetTile");
            }

            internal static unsafe void Invoke(IntPtr obj, int X, int Y, int Layer, PaperTileInfo NewValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = X;
                *((int*)(b+4)) = Y;
                *((int*)(b+8)) = Layer;
                *((PaperTileInfo*)(b+16)) = NewValue;
                Main.GetProcessEvent(obj, SetTile_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTileMap_method {
            static internal IntPtr SetTileMap_ptr;
            static SetTileMap_method() {
                SetTileMap_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "SetTileMap");
            }

            internal static unsafe bool Invoke(IntPtr obj, PaperTileMap NewTileMap) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewTileMap;
                Main.GetProcessEvent(obj, SetTileMap_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct SetTileMapColor_method {
            static internal IntPtr SetTileMapColor_ptr;
            static SetTileMapColor_method() {
                SetTileMapColor_ptr = Main.GetMethodUFunction(PaperTileMapComponent.StaticClass, "SetTileMapColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewColor;
                Main.GetProcessEvent(obj, SetTileMapColor_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PaperTileMapComponent_events {
    }
}
