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
    ///<summary>A tile map is a 2D grid with a defined width and height (in tiles).  There can be multiple layers, each of which can specify which tile should appear in each cell of the map for that layer.</summary>
    public unsafe partial class PaperTileMap : UObject  {
        ///<summary>Width of map (in tiles)</summary>
        public unsafe int MapWidth {
            get {return PaperTileMap_ptr->MapWidth;}
        }
        ///<summary>Height of map (in tiles)</summary>
        public unsafe int MapHeight {
            get {return PaperTileMap_ptr->MapHeight;}
        }
        ///<summary>Width of one tile (in pixels)</summary>
        public unsafe int TileWidth {
            get {return PaperTileMap_ptr->TileWidth;}
        }
        ///<summary>Height of one tile (in pixels)</summary>
        public unsafe int TileHeight {
            get {return PaperTileMap_ptr->TileHeight;}
        }
        ///<summary>The scaling factor between pixels and Unreal units (cm) (e.g., 0.64 would make a 64 pixel wide tile take up 100 cm)</summary>
        public unsafe float PixelsPerUnrealUnit {
            get {return PaperTileMap_ptr->PixelsPerUnrealUnit;}
            set {PaperTileMap_ptr->PixelsPerUnrealUnit = value;}
        }
        ///<summary>The Z-separation incurred as you travel in X (not strictly applied, batched tiles will be put at the same Z level)</summary>
        public unsafe float SeparationPerTileX {
            get {return PaperTileMap_ptr->SeparationPerTileX;}
            set {PaperTileMap_ptr->SeparationPerTileX = value;}
        }
        ///<summary>The Z-separation incurred as you travel in Y (not strictly applied, batched tiles will be put at the same Z level)</summary>
        public unsafe float SeparationPerTileY {
            get {return PaperTileMap_ptr->SeparationPerTileY;}
            set {PaperTileMap_ptr->SeparationPerTileY = value;}
        }
        ///<summary>The Z-separation between each layer of the tile map</summary>
        public unsafe float SeparationPerLayer {
            get {return PaperTileMap_ptr->SeparationPerLayer;}
        }
         //TODO: soft object TSoftObjectPtr<UPaperTileSet> SelectedTileSet
        ///<summary>The material to use on a tile map instance if not overridden</summary>
        public unsafe MaterialInterface Material {
            get {return PaperTileMap_ptr->Material;}
        }
        ///<summary>The list of layers</summary>
        public ObjectArrayField<PaperTileLayer> TileLayers{ get {
            if(TileLayers_store == null) TileLayers_store = new ObjectArrayField<PaperTileLayer> (&PaperTileMap_ptr->TileLayers);
            return TileLayers_store;
        } }
        private ObjectArrayField<PaperTileLayer> TileLayers_store;

        ///<summary>The extrusion thickness of collision geometry when using a 3D collision domain</summary>
        public unsafe float CollisionThickness {
            get {return PaperTileMap_ptr->CollisionThickness;}
        }
        ///<summary>Collision domain (no collision, 2D, or 3D)</summary>
        public unsafe byte SpriteCollisionDomain {
            get {return PaperTileMap_ptr->SpriteCollisionDomain;}
        }
        ///<summary>Tile map type</summary>
        public unsafe byte ProjectionMode {
            get {return PaperTileMap_ptr->ProjectionMode;}
        }
        ///<summary>The vertical height of the sides of the hex cell for a tile.</summary>
        ///<remarks>Note: This value should already be included as part of the TileHeight, and is purely cosmetic; it only affects how the tile cursor preview is drawn.</remarks>
        public unsafe int HexSideLength {
            get {return PaperTileMap_ptr->HexSideLength;}
            set {PaperTileMap_ptr->HexSideLength = value;}
        }
        ///<summary>Baked physics data.</summary>
        public unsafe BodySetup BodySetup {
            get {return PaperTileMap_ptr->BodySetup;}
            set {PaperTileMap_ptr->BodySetup = value;}
        }
        ///<summary>Importing data and options used for this tile map</summary>
        public unsafe AssetImportData AssetImportData {
            get {return PaperTileMap_ptr->AssetImportData;}
            set {PaperTileMap_ptr->AssetImportData = value;}
        }
        ///<summary>The currently selected layer index</summary>
        public unsafe int SelectedLayerIndex {
            get {return PaperTileMap_ptr->SelectedLayerIndex;}
            set {PaperTileMap_ptr->SelectedLayerIndex = value;}
        }
        ///<summary>The background color displayed in the tile map editor</summary>
        public unsafe LinearColor BackgroundColor {
            get {return PaperTileMap_ptr->BackgroundColor;}
            set {PaperTileMap_ptr->BackgroundColor = value;}
        }
        ///<summary>The color of the tile grid</summary>
        public unsafe LinearColor TileGridColor {
            get {return PaperTileMap_ptr->TileGridColor;}
            set {PaperTileMap_ptr->TileGridColor = value;}
        }
        ///<summary>The color of the multi tile grid</summary>
        public unsafe LinearColor MultiTileGridColor {
            get {return PaperTileMap_ptr->MultiTileGridColor;}
            set {PaperTileMap_ptr->MultiTileGridColor = value;}
        }
        ///<summary>Number of tiles the multi tile grid spans horizontally. 0 removes vertical lines</summary>
        public unsafe int MultiTileGridWidth {
            get {return PaperTileMap_ptr->MultiTileGridWidth;}
            set {PaperTileMap_ptr->MultiTileGridWidth = value;}
        }
        ///<summary>Number of tiles the multi tile grid spans vertically. 0 removes horizontal lines</summary>
        public unsafe int MultiTileGridHeight {
            get {return PaperTileMap_ptr->MultiTileGridHeight;}
            set {PaperTileMap_ptr->MultiTileGridHeight = value;}
        }
        ///<summary>Number of tiles the multi tile grid is shifted to the right</summary>
        public unsafe int MultiTileGridOffsetX {
            get {return PaperTileMap_ptr->MultiTileGridOffsetX;}
            set {PaperTileMap_ptr->MultiTileGridOffsetX = value;}
        }
        ///<summary>Number of tiles the multi tile grid is shifted downwards</summary>
        public unsafe int MultiTileGridOffsetY {
            get {return PaperTileMap_ptr->MultiTileGridOffsetY;}
            set {PaperTileMap_ptr->MultiTileGridOffsetY = value;}
        }
        ///<summary>The color of the layer grid</summary>
        public unsafe LinearColor LayerGridColor {
            get {return PaperTileMap_ptr->LayerGridColor;}
            set {PaperTileMap_ptr->LayerGridColor = value;}
        }
        ///<summary>The naming index to start at when trying to create a new layer</summary>
        public unsafe int LayerNameIndex {
            get {return PaperTileMap_ptr->LayerNameIndex;}
            set {PaperTileMap_ptr->LayerNameIndex = value;}
        }
        static PaperTileMap() {
            StaticClass = Main.GetClass("PaperTileMap");
        }
        internal unsafe PaperTileMap_fields* PaperTileMap_ptr => (PaperTileMap_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTileMap(IntPtr p) => UObject.Make<PaperTileMap>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTileMap DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTileMap New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
