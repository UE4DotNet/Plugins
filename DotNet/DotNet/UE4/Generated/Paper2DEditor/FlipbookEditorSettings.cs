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
    public unsafe partial class FlipbookEditorSettings : UObject  {
        ///<summary>Background color in the flipbook editor</summary>
        public unsafe Color BackgroundColor {
            get {return FlipbookEditorSettings_ptr->BackgroundColor;}
            set {FlipbookEditorSettings_ptr->BackgroundColor = value;}
        }
        public bool bShowGridByDefault {
            get {return Main.GetGetBoolPropertyByName(this, "bShowGridByDefault"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowGridByDefault", value); }
        }
        static FlipbookEditorSettings() {
            StaticClass = Main.GetClass("FlipbookEditorSettings");
        }
        internal unsafe FlipbookEditorSettings_fields* FlipbookEditorSettings_ptr => (FlipbookEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FlipbookEditorSettings(IntPtr p) => UObject.Make<FlipbookEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FlipbookEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FlipbookEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
