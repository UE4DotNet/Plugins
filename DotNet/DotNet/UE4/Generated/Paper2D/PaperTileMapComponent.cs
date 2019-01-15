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
    ///<summary>A component that handles rendering and collision for a single instance of a UPaperTileMap asset.</summary>
    ///<remarks>
    ///This component is created when you drag a tile map asset from the content browser into a Blueprint, or
    ///contained inside of the actor created when you drag one into the level.
    ///
    ///NOTE: This is an early access preview class.  While not considered production-ready, it is a step beyond
    ///'experimental' and is being provided as a preview of things to come:
    /// - We will try to provide forward-compatibility for content you create.
    /// - The classes may change significantly in the future.
    /// - The code is in an early state and may not meet the desired polish / quality bar.
    /// - There is probably no documentation or example content yet.
    /// - They will be promoted out of 'Early Access' when they are production ready.
    ///
    ///@see UPrimitiveComponent, UPaperTileMap
    ///</remarks>
    public unsafe partial class PaperTileMapComponent : MeshComponent  {

        ///<summary>Creates and adds a new layer to the tile map</summary>
        ///<remarks>Note: This will only work on components that own their own tile map (OwnsTileMap returns true), you cannot modify standalone tile map assets</remarks>
        public PaperTileLayer AddNewLayer()  => 
            PaperTileMapComponent_methods.AddNewLayer_method.Invoke(ObjPointer);

        ///<summary>
        ///Creates a new tile map of the specified size, replacing the TileMap reference (or dropping the previous owned one)
        ///@
        ///</summary>
        ///<remarks>
        ///param MapWidth Width of the map (in tiles)
        ///@param MapHeight Height of the map (in tiles)
        ///@param TileWidth Width of one tile (in pixels)
        ///@param TileHeight Height of one tile (in pixels)
        ///@param bCreateLayer Should an empty layer be created?
        ///</remarks>
        public void CreateNewTileMap(int MapWidth, int MapHeight, int TileWidth, int TileHeight, float PixelsPerUnrealUnit, bool bCreateLayer)  => 
            PaperTileMapComponent_methods.CreateNewTileMap_method.Invoke(ObjPointer, MapWidth, MapHeight, TileWidth, TileHeight, PixelsPerUnrealUnit, bCreateLayer);

        ///<summary>Gets the per-layer color multiplier for a specific layer (multiplied with the tile map color and passed to the material as a vertex color)</summary>
        public LinearColor GetLayerColor(int Layer)  => 
            PaperTileMapComponent_methods.GetLayerColor_method.Invoke(ObjPointer, Layer);

        ///<summary>Returns the size of the tile map</summary>
        public (int, int, int) GetMapSize()  => 
            PaperTileMapComponent_methods.GetMapSize_method.Invoke(ObjPointer);

        ///<summary>Returns the contents of a specified tile cell</summary>
        public PaperTileInfo GetTile(int X, int Y, int Layer)  => 
            PaperTileMapComponent_methods.GetTile_method.Invoke(ObjPointer, X, Y, Layer);

        ///<summary>Returns the position of the center of the specified tile</summary>
        public Vector GetTileCenterPosition(int TileX, int TileY, int LayerIndex, bool bWorldSpace)  => 
            PaperTileMapComponent_methods.GetTileCenterPosition_method.Invoke(ObjPointer, TileX, TileY, LayerIndex, bWorldSpace);

        ///<summary>Returns the position of the top left corner of the specified tile</summary>
        public Vector GetTileCornerPosition(int TileX, int TileY, int LayerIndex, bool bWorldSpace)  => 
            PaperTileMapComponent_methods.GetTileCornerPosition_method.Invoke(ObjPointer, TileX, TileY, LayerIndex, bWorldSpace);

        ///<summary>Gets the tile map global color multiplier (multiplied with the per-layer color and passed to the material as a vertex color)</summary>
        public LinearColor GetTileMapColor()  => 
            PaperTileMapComponent_methods.GetTileMapColor_method.Invoke(ObjPointer);

        ///<summary>Returns the polygon for the specified tile (will be 4 or 6 vertices as a rectangle, diamond, or hexagon)</summary>
        public IReadOnlyCollection<Vector> GetTilePolygon(int TileX, int TileY, int LayerIndex, bool bWorldSpace)  => 
            PaperTileMapComponent_methods.GetTilePolygon_method.Invoke(ObjPointer, TileX, TileY, LayerIndex, bWorldSpace);

        ///<summary>Makes the tile map asset pointed to by this component editable.</summary>
        ///<remarks>
        ///Nothing happens if it was already instanced, but
        ///if the tile map is an asset reference, it is cloned to make a unique instance.
        ///</remarks>
        public void MakeTileMapEditable()  => 
            PaperTileMapComponent_methods.MakeTileMapEditable_method.Invoke(ObjPointer);

        ///<summary>Does this component own the tile map (is it instanced instead of being an asset reference)?</summary>
        public bool OwnsTileMap()  => 
            PaperTileMapComponent_methods.OwnsTileMap_method.Invoke(ObjPointer);

        ///<summary>Rebuilds collision for the tile map</summary>
        public void RebuildCollision()  => 
            PaperTileMapComponent_methods.RebuildCollision_method.Invoke(ObjPointer);

        ///<summary>Resizes the tile map (Note: This will only work on components that own their own tile map (OwnsTileMap returns true), you cannot modify standalone tile map assets)</summary>
        public void ResizeMap(int NewWidthInTiles, int NewHeightInTiles)  => 
            PaperTileMapComponent_methods.ResizeMap_method.Invoke(ObjPointer, NewWidthInTiles, NewHeightInTiles);

        ///<summary>Sets the default thickness for any layers that don't override the collision thickness</summary>
        ///<remarks>Note: This will only work on components that own their own tile map (OwnsTileMap returns true), you cannot modify standalone tile map assets</remarks>
        public void SetDefaultCollisionThickness(float Thickness, bool bRebuildCollision)  => 
            PaperTileMapComponent_methods.SetDefaultCollisionThickness_method.Invoke(ObjPointer, Thickness, bRebuildCollision);

        ///<summary>Sets the collision thickness for a specific layer</summary>
        ///<remarks>Note: This will only work on components that own their own tile map (OwnsTileMap returns true), you cannot modify standalone tile map assets</remarks>
        public void SetLayerCollision(int Layer, bool bHasCollision, bool bOverrideThickness, float CustomThickness, bool bOverrideOffset, float CustomOffset, bool bRebuildCollision)  => 
            PaperTileMapComponent_methods.SetLayerCollision_method.Invoke(ObjPointer, Layer, bHasCollision, bOverrideThickness, CustomThickness, bOverrideOffset, CustomOffset, bRebuildCollision);

        ///<summary>Sets the per-layer color multiplier for a specific layer (multiplied with the tile map color and passed to the material as a vertex color)</summary>
        ///<remarks>Note: This will only work on components that own their own tile map (OwnsTileMap returns true), you cannot modify standalone tile map assets</remarks>
        public void SetLayerColor(LinearColor NewColor, int Layer)  => 
            PaperTileMapComponent_methods.SetLayerColor_method.Invoke(ObjPointer, NewColor, Layer);

        ///<summary>Modifies the contents of a specified tile cell (Note: This will only work on components that own their own tile map (OwnsTileMap returns true), you cannot modify standalone tile map assets)</summary>
        ///<remarks>Note: Does not update collision by default, call RebuildCollision after all edits have been done in a frame if necessary</remarks>
        public void SetTile(int X, int Y, int Layer, PaperTileInfo NewValue)  => 
            PaperTileMapComponent_methods.SetTile_method.Invoke(ObjPointer, X, Y, Layer, NewValue);

        ///<summary>Change the PaperTileMap used by this instance.</summary>
        public bool SetTileMap(PaperTileMap NewTileMap)  => 
            PaperTileMapComponent_methods.SetTileMap_method.Invoke(ObjPointer, NewTileMap);

        ///<summary>Sets the tile map global color multiplier (multiplied with the per-layer color and passed to the material as a vertex color)</summary>
        public void SetTileMapColor(LinearColor NewColor)  => 
            PaperTileMapComponent_methods.SetTileMapColor_method.Invoke(ObjPointer, NewColor);
        ///<summary>The color of the tile map (multiplied with the per-layer color and passed to the material as a vertex color)</summary>
        public unsafe LinearColor TileMapColor {
            get {return PaperTileMapComponent_ptr->TileMapColor;}
            set {PaperTileMapComponent_ptr->TileMapColor = value;}
        }
        ///<summary>The index of the single layer to use if enabled</summary>
        public unsafe int UseSingleLayerIndex {
            get {return PaperTileMapComponent_ptr->UseSingleLayerIndex;}
            set {PaperTileMapComponent_ptr->UseSingleLayerIndex = value;}
        }
        public bool bUseSingleLayer {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSingleLayer"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSingleLayer", value); }
        }
        ///<summary>The tile map used by this component</summary>
        public unsafe PaperTileMap TileMap {
            get {return PaperTileMapComponent_ptr->TileMap;}
        }
        public bool bShowPerTileGridWhenSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPerTileGridWhenSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPerTileGridWhenSelected", value); }
        }
        public bool bShowPerLayerGridWhenSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPerLayerGridWhenSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPerLayerGridWhenSelected", value); }
        }
        public bool bShowOutlineWhenUnselected {
            get {return Main.GetGetBoolPropertyByName(this, "bShowOutlineWhenUnselected"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowOutlineWhenUnselected", value); }
        }
        public bool bShowPerTileGridWhenUnselected {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPerTileGridWhenUnselected"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPerTileGridWhenUnselected", value); }
        }
        public bool bShowPerLayerGridWhenUnselected {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPerLayerGridWhenUnselected"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPerLayerGridWhenUnselected", value); }
        }
        static PaperTileMapComponent() {
            StaticClass = Main.GetClass("PaperTileMapComponent");
        }
        internal unsafe PaperTileMapComponent_fields* PaperTileMapComponent_ptr => (PaperTileMapComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTileMapComponent(IntPtr p) => UObject.Make<PaperTileMapComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTileMapComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTileMapComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
