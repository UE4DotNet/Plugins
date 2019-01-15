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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Landscape Material Instance Constant</summary>
    public unsafe partial class LandscapeMaterialInstanceConstant : MaterialInstanceConstant  {
        public bool bIsLayerThumbnail {
            get {return Main.GetGetBoolPropertyByName(this, "bIsLayerThumbnail"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsLayerThumbnail", value); }
        }
        public bool bDisableTessellation {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableTessellation"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableTessellation", value); }
        }
        public bool bMobile {
            get {return Main.GetGetBoolPropertyByName(this, "bMobile"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobile", value); }
        }
        public bool bEditorToolUsage {
            get {return Main.GetGetBoolPropertyByName(this, "bEditorToolUsage"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditorToolUsage", value); }
        }
        static LandscapeMaterialInstanceConstant() {
            StaticClass = Main.GetClass("LandscapeMaterialInstanceConstant");
        }
        internal unsafe LandscapeMaterialInstanceConstant_fields* LandscapeMaterialInstanceConstant_ptr => (LandscapeMaterialInstanceConstant_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeMaterialInstanceConstant(IntPtr p) => UObject.Make<LandscapeMaterialInstanceConstant>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeMaterialInstanceConstant DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeMaterialInstanceConstant New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
