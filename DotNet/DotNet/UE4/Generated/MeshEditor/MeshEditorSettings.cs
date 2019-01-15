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
using UE4.MeshEditor.Native;

namespace UE4.MeshEditor {
    ///<summary>Implements the Mesh Editor's settings.</summary>
    public unsafe partial class MeshEditorSettings : UObject  {
        public bool bSeparateSelectionSetPerMode {
            get {return Main.GetGetBoolPropertyByName(this, "bSeparateSelectionSetPerMode"); }
            set {Main.SetGetBoolPropertyByName(this, "bSeparateSelectionSetPerMode", value); }
        }
        public bool bOnlySelectVisibleMeshes {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlySelectVisibleMeshes"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlySelectVisibleMeshes", value); }
        }
        public bool bOnlySelectVisibleElements {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlySelectVisibleElements"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlySelectVisibleElements", value); }
        }
        public bool bAllowGrabberSphere {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowGrabberSphere"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowGrabberSphere", value); }
        }
        public bool bAutoQuadrangulate {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoQuadrangulate"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoQuadrangulate", value); }
        }
        static MeshEditorSettings() {
            StaticClass = Main.GetClass("MeshEditorSettings");
        }
        internal unsafe MeshEditorSettings_fields* MeshEditorSettings_ptr => (MeshEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshEditorSettings(IntPtr p) => UObject.Make<MeshEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
