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
using UE4.Paper2DEditor.Native;

namespace UE4.Paper2DEditor {
    ///<summary>Settings for the Paper2D tile map editor</summary>
    public unsafe partial class TileMapEditorSettings : UObject  {
        ///<summary>Default background color for new tile map assets</summary>
        public unsafe Color DefaultBackgroundColor {
            get {return TileMapEditorSettings_ptr->DefaultBackgroundColor;}
            set {TileMapEditorSettings_ptr->DefaultBackgroundColor = value;}
        }
        public bool bShowGridByDefault {
            get {return Main.GetGetBoolPropertyByName(this, "bShowGridByDefault"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowGridByDefault", value); }
        }
        ///<summary>Default per tile grid color for new tile map assets</summary>
        public unsafe Color DefaultTileGridColor {
            get {return TileMapEditorSettings_ptr->DefaultTileGridColor;}
            set {TileMapEditorSettings_ptr->DefaultTileGridColor = value;}
        }
        ///<summary>Default multi tile grid color for new tile map assets</summary>
        public unsafe Color DefaultMultiTileGridColor {
            get {return TileMapEditorSettings_ptr->DefaultMultiTileGridColor;}
            set {TileMapEditorSettings_ptr->DefaultMultiTileGridColor = value;}
        }
        ///<summary>Default number of tiles the multi tile grid spans horizontally for new tile map assets. 0 removes vertical lines</summary>
        public unsafe int DefaultMultiTileGridWidth {
            get {return TileMapEditorSettings_ptr->DefaultMultiTileGridWidth;}
            set {TileMapEditorSettings_ptr->DefaultMultiTileGridWidth = value;}
        }
        ///<summary>Default number of tiles the multi tile grid spans vertically for new tile map assets. 0 removes horizontal lines</summary>
        public unsafe int DefaultMultiTileGridHeight {
            get {return TileMapEditorSettings_ptr->DefaultMultiTileGridHeight;}
            set {TileMapEditorSettings_ptr->DefaultMultiTileGridHeight = value;}
        }
        ///<summary>Default number of tiles the multi tile grid is shifted to the right for new tile map assets</summary>
        public unsafe int DefaultMultiTileGridOffsetX {
            get {return TileMapEditorSettings_ptr->DefaultMultiTileGridOffsetX;}
            set {TileMapEditorSettings_ptr->DefaultMultiTileGridOffsetX = value;}
        }
        ///<summary>Default number of tiles the multi tile grid is shifted downwards for new tile map assets</summary>
        public unsafe int DefaultMultiTileGridOffsetY {
            get {return TileMapEditorSettings_ptr->DefaultMultiTileGridOffsetY;}
            set {TileMapEditorSettings_ptr->DefaultMultiTileGridOffsetY = value;}
        }
        ///<summary>Default layer grid color for new tile map assets</summary>
        public unsafe Color DefaultLayerGridColor {
            get {return TileMapEditorSettings_ptr->DefaultLayerGridColor;}
            set {TileMapEditorSettings_ptr->DefaultLayerGridColor = value;}
        }
        static TileMapEditorSettings() {
            StaticClass = Main.GetClass("TileMapEditorSettings");
        }
        internal unsafe TileMapEditorSettings_fields* TileMapEditorSettings_ptr => (TileMapEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TileMapEditorSettings(IntPtr p) => UObject.Make<TileMapEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TileMapEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TileMapEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
