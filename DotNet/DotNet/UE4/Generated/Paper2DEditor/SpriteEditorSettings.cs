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
    ///<summary>Settings for the Paper2D sprite editor</summary>
    public unsafe partial class SpriteEditorSettings : UObject  {
        ///<summary>Background color in the sprite editor</summary>
        public unsafe Color BackgroundColor {
            get {return SpriteEditorSettings_ptr->BackgroundColor;}
            set {SpriteEditorSettings_ptr->BackgroundColor = value;}
        }
        public bool bShowGridByDefault {
            get {return Main.GetGetBoolPropertyByName(this, "bShowGridByDefault"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowGridByDefault", value); }
        }
        static SpriteEditorSettings() {
            StaticClass = Main.GetClass("SpriteEditorSettings");
        }
        internal unsafe SpriteEditorSettings_fields* SpriteEditorSettings_ptr => (SpriteEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SpriteEditorSettings(IntPtr p) => UObject.Make<SpriteEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SpriteEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SpriteEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
