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

namespace UE4.Paper2D {
    ///<summary>This class represents a single layer in a tile map.  All layers in the map must have the size dimensions.</summary>
    public unsafe partial class PaperTileLayer : UObject  {
         //TODO: text FText LayerName
        ///<summary>Width of the layer (in tiles)</summary>
        public unsafe int LayerWidth {
            get {return PaperTileLayer_ptr->LayerWidth;}
        }
        ///<summary>Height of the layer (in tiles)</summary>
        public unsafe int LayerHeight {
            get {return PaperTileLayer_ptr->LayerHeight;}
        }
        public bool bHiddenInEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bHiddenInEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bHiddenInEditor", value); }
        }
        public bool bHiddenInGame {
            get {return Main.GetGetBoolPropertyByName(this, "bHiddenInGame"); }
        }
        public bool bLayerCollides {
            get {return Main.GetGetBoolPropertyByName(this, "bLayerCollides"); }
        }
        public bool bOverrideCollisionThickness {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideCollisionThickness"); }
        }
        public bool bOverrideCollisionOffset {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideCollisionOffset"); }
        }
        ///<summary>The override thickness of the collision for this layer (when bOverrideCollisionThickness is set)</summary>
        public unsafe float CollisionThicknessOverride {
            get {return PaperTileLayer_ptr->CollisionThicknessOverride;}
        }
        ///<summary>
        ///The override offset of the collision for this layer (when bOverrideCollisionOffset is set)
        ///Note: This is measured in Unreal Units (cm) from the center of the tile map component, not from the previous layer.
        ///</summary>
        public unsafe float CollisionOffsetOverride {
            get {return PaperTileLayer_ptr->CollisionOffsetOverride;}
        }
        ///<summary>The color of this layer (multiplied with the tile map color and passed to the material as a vertex color)</summary>
        public unsafe LinearColor LayerColor {
            get {return PaperTileLayer_ptr->LayerColor;}
        }
        ///<summary>The allocated width of the tile data (used to handle resizing without data loss)</summary>
        public unsafe int AllocatedWidth {
            get {return PaperTileLayer_ptr->AllocatedWidth;}
            set {PaperTileLayer_ptr->AllocatedWidth = value;}
        }
        ///<summary>The allocated height of the tile data (used to handle resizing without data loss)</summary>
        public unsafe int AllocatedHeight {
            get {return PaperTileLayer_ptr->AllocatedHeight;}
            set {PaperTileLayer_ptr->AllocatedHeight = value;}
        }
         //TODO: array not UObject TArray AllocatedCells
        static PaperTileLayer() {
            StaticClass = Main.GetClass("PaperTileLayer");
        }
        internal unsafe PaperTileLayer_fields* PaperTileLayer_ptr => (PaperTileLayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTileLayer(IntPtr p) => UObject.Make<PaperTileLayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTileLayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTileLayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
