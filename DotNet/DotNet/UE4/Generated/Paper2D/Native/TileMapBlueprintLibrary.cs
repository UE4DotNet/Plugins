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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct TileMapBlueprintLibrary_fields {
    }
    internal unsafe struct TileMapBlueprintLibrary_methods {
        internal struct BreakTile_method {
            static internal IntPtr BreakTile_ptr;
            static BreakTile_method() {
                BreakTile_ptr = Main.GetMethodUFunction(TileMapBlueprintLibrary.StaticClass, "BreakTile");
            }

            internal static unsafe (int, PaperTileSet, bool, bool, bool) Invoke(PaperTileInfo Tile) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PaperTileInfo*)(b+0)) = Tile;
                Main.GetProcessEvent(TileMapBlueprintLibrary.DefaultObject, BreakTile_ptr, new IntPtr(p)); ;
                return (*((int*)(b+16)),*((IntPtr*)(b+24)),*((bool*)(b+32)),*((bool*)(b+33)),*((bool*)(b+34)));
            }
        }
        internal struct GetTileTransform_method {
            static internal IntPtr GetTileTransform_ptr;
            static GetTileTransform_method() {
                GetTileTransform_ptr = Main.GetMethodUFunction(TileMapBlueprintLibrary.StaticClass, "GetTileTransform");
            }

            internal static unsafe Transform Invoke(PaperTileInfo Tile) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PaperTileInfo*)(b+0)) = Tile;
                Main.GetProcessEvent(TileMapBlueprintLibrary.DefaultObject, GetTileTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct GetTileUserData_method {
            static internal IntPtr GetTileUserData_ptr;
            static GetTileUserData_method() {
                GetTileUserData_ptr = Main.GetMethodUFunction(TileMapBlueprintLibrary.StaticClass, "GetTileUserData");
            }

            internal static unsafe Name Invoke(PaperTileInfo Tile) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PaperTileInfo*)(b+0)) = Tile;
                Main.GetProcessEvent(TileMapBlueprintLibrary.DefaultObject, GetTileUserData_ptr, new IntPtr(p)); ;
                return *((Name*)(b+16));
            }
        }
        internal struct MakeTile_method {
            static internal IntPtr MakeTile_ptr;
            static MakeTile_method() {
                MakeTile_ptr = Main.GetMethodUFunction(TileMapBlueprintLibrary.StaticClass, "MakeTile");
            }

            internal static unsafe PaperTileInfo Invoke(int TileIndex, PaperTileSet TileSet, bool bFlipH, bool bFlipV, bool bFlipD) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TileIndex;
                *((IntPtr*)(b+8)) = TileSet;
                *((bool*)(b+16)) = bFlipH;
                *((bool*)(b+17)) = bFlipV;
                *((bool*)(b+18)) = bFlipD;
                Main.GetProcessEvent(TileMapBlueprintLibrary.DefaultObject, MakeTile_ptr, new IntPtr(p)); ;
                return *((PaperTileInfo*)(b+24));
            }
        }
    }
    internal unsafe struct TileMapBlueprintLibrary_events {
    }
}
