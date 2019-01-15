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
    ///<summary>Settings for the Paper2D tile set editor</summary>
    public unsafe partial class TileSetEditorSettings : UObject  {
        ///<summary>Default background color for new tile set assets</summary>
        public unsafe Color DefaultBackgroundColor {
            get {return TileSetEditorSettings_ptr->DefaultBackgroundColor;}
            set {TileSetEditorSettings_ptr->DefaultBackgroundColor = value;}
        }
        public bool bShowGridByDefault {
            get {return Main.GetGetBoolPropertyByName(this, "bShowGridByDefault"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowGridByDefault", value); }
        }
        ///<summary>The amount to extrude out from the edge of each tile (in pixels)</summary>
        public unsafe int ExtrusionAmount {
            get {return TileSetEditorSettings_ptr->ExtrusionAmount;}
            set {TileSetEditorSettings_ptr->ExtrusionAmount = value;}
        }
        public bool bPadToPowerOf2 {
            get {return Main.GetGetBoolPropertyByName(this, "bPadToPowerOf2"); }
            set {Main.SetGetBoolPropertyByName(this, "bPadToPowerOf2", value); }
        }
        public bool bFillWithTransparentBlack {
            get {return Main.GetGetBoolPropertyByName(this, "bFillWithTransparentBlack"); }
            set {Main.SetGetBoolPropertyByName(this, "bFillWithTransparentBlack", value); }
        }
        static TileSetEditorSettings() {
            StaticClass = Main.GetClass("TileSetEditorSettings");
        }
        internal unsafe TileSetEditorSettings_fields* TileSetEditorSettings_ptr => (TileSetEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TileSetEditorSettings(IntPtr p) => UObject.Make<TileSetEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TileSetEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TileSetEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
