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
using UE4.UnrealEd;
using UE4.Paper2D;

namespace UE4.Paper2DEditor {
    ///<summary>Factory used to pad out each individual tile in a tile sheet texture</summary>
    public unsafe partial class TileSheetPaddingFactory : Factory  {
        ///<summary>Source tile sheet texture</summary>
        public unsafe PaperTileSet SourceTileSet {
            get {return TileSheetPaddingFactory_ptr->SourceTileSet;}
            set {TileSheetPaddingFactory_ptr->SourceTileSet = value;}
        }
        ///<summary>The amount to extrude out from each tile (in pixels)</summary>
        public unsafe int ExtrusionAmount {
            get {return TileSheetPaddingFactory_ptr->ExtrusionAmount;}
            set {TileSheetPaddingFactory_ptr->ExtrusionAmount = value;}
        }
        public bool bPadToPowerOf2 {
            get {return Main.GetGetBoolPropertyByName(this, "bPadToPowerOf2"); }
            set {Main.SetGetBoolPropertyByName(this, "bPadToPowerOf2", value); }
        }
        public bool bFillWithTransparentBlack {
            get {return Main.GetGetBoolPropertyByName(this, "bFillWithTransparentBlack"); }
            set {Main.SetGetBoolPropertyByName(this, "bFillWithTransparentBlack", value); }
        }
        static TileSheetPaddingFactory() {
            StaticClass = Main.GetClass("TileSheetPaddingFactory");
        }
        internal unsafe TileSheetPaddingFactory_fields* TileSheetPaddingFactory_ptr => (TileSheetPaddingFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TileSheetPaddingFactory(IntPtr p) => UObject.Make<TileSheetPaddingFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TileSheetPaddingFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TileSheetPaddingFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
