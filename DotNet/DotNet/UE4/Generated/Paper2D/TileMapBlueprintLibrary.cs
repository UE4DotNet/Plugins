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

#pragma warning disable CS0108
using UE4.Paper2D.Native;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>
    ///A collection of utility methods for working with tile map components
    ///@
    ///</summary>
    ///<remarks>see UPaperTileMap, UPaperTileMapComponent</remarks>
    public unsafe partial class TileMapBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Breaks out the information for a tile</summary>
        public static (int, PaperTileSet, bool, bool, bool) BreakTile(PaperTileInfo Tile)  => 
            TileMapBlueprintLibrary_methods.BreakTile_method.Invoke(Tile);

        ///<summary>Returns the transform for a tile</summary>
        public static Transform GetTileTransform(PaperTileInfo Tile)  => 
            TileMapBlueprintLibrary_methods.GetTileTransform_method.Invoke(Tile);

        ///<summary>Returns the user data name for the specified tile, or NAME_None if there is no user-specified data</summary>
        public static Name GetTileUserData(PaperTileInfo Tile)  => 
            TileMapBlueprintLibrary_methods.GetTileUserData_method.Invoke(Tile);

        ///<summary>Creates a tile from the specified information</summary>
        public static PaperTileInfo MakeTile(int TileIndex, PaperTileSet TileSet, bool bFlipH, bool bFlipV, bool bFlipD)  => 
            TileMapBlueprintLibrary_methods.MakeTile_method.Invoke(TileIndex, TileSet, bFlipH, bFlipV, bFlipD);
        static TileMapBlueprintLibrary() {
            StaticClass = Main.GetClass("TileMapBlueprintLibrary");
        }
        internal unsafe TileMapBlueprintLibrary_fields* TileMapBlueprintLibrary_ptr => (TileMapBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TileMapBlueprintLibrary(IntPtr p) => UObject.Make<TileMapBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TileMapBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TileMapBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
