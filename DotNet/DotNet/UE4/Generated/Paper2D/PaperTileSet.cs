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
    ///<summary>A tile set is a collection of tiles pulled from a texture that can be used to fill out a tile map.</summary>
    ///<remarks>
    ///@see UPaperTileMap, UPaperTileMapComponent
    ///</remarks>
    public unsafe partial class PaperTileSet : UObject  {
        ///<summary>The width and height of a single tile (in pixels)</summary>
        public unsafe IntPoint TileSize {
            get {return PaperTileSet_ptr->TileSize;}
        }
        ///<summary>The tile sheet texture associated with this tile set</summary>
        public unsafe Texture2D TileSheet {
            get {return PaperTileSet_ptr->TileSheet;}
        }
        ///<summary>Additional source textures for other slots</summary>
        public ObjectArrayField<Texture> AdditionalSourceTextures{ get {
            if(AdditionalSourceTextures_store == null) AdditionalSourceTextures_store = new ObjectArrayField<Texture> (&PaperTileSet_ptr->AdditionalSourceTextures);
            return AdditionalSourceTextures_store;
        } }
        private ObjectArrayField<Texture> AdditionalSourceTextures_store;

        ///<summary>The amount of padding around the border of the tile sheet (in pixels)</summary>
        public unsafe IntMargin BorderMargin {
            get {return PaperTileSet_ptr->BorderMargin;}
        }
        ///<summary>The amount of padding between tiles in the tile sheet (in pixels)</summary>
        public unsafe IntPoint PerTileSpacing {
            get {return PaperTileSet_ptr->PerTileSpacing;}
        }
        ///<summary>The drawing offset for tiles from this set (in pixels)</summary>
        public unsafe IntPoint DrawingOffset {
            get {return PaperTileSet_ptr->DrawingOffset;}
        }
        ///<summary>The background color displayed in the tile set viewer</summary>
        public unsafe LinearColor BackgroundColor {
            get {return PaperTileSet_ptr->BackgroundColor;}
            set {PaperTileSet_ptr->BackgroundColor = value;}
        }
        ///<summary>Cached width of this tile set (in tiles)</summary>
        public unsafe int WidthInTiles {
            get {return PaperTileSet_ptr->WidthInTiles;}
            set {PaperTileSet_ptr->WidthInTiles = value;}
        }
        ///<summary>Cached height of this tile set (in tiles)</summary>
        public unsafe int HeightInTiles {
            get {return PaperTileSet_ptr->HeightInTiles;}
            set {PaperTileSet_ptr->HeightInTiles = value;}
        }
        ///<summary>Allocated width of the per-tile data</summary>
        public unsafe int AllocatedWidth {
            get {return PaperTileSet_ptr->AllocatedWidth;}
            set {PaperTileSet_ptr->AllocatedWidth = value;}
        }
        ///<summary>Allocated height of the per-tile data</summary>
        public unsafe int AllocatedHeight {
            get {return PaperTileSet_ptr->AllocatedHeight;}
            set {PaperTileSet_ptr->AllocatedHeight = value;}
        }
         //TODO: array not UObject TArray PerTileData
         //TODO: array not UObject TArray Terrains
        static PaperTileSet() {
            StaticClass = Main.GetClass("PaperTileSet");
        }
        internal unsafe PaperTileSet_fields* PaperTileSet_ptr => (PaperTileSet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTileSet(IntPtr p) => UObject.Make<PaperTileSet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTileSet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTileSet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
