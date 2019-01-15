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
    ///<summary>Implements the settings for the Paper2D plugin.</summary>
    public unsafe partial class PaperRuntimeSettings : UObject  {
        public bool bEnableSpriteAtlasGroups {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableSpriteAtlasGroups"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableSpriteAtlasGroups", value); }
        }
        public bool bEnableTerrainSplineEditing {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableTerrainSplineEditing"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableTerrainSplineEditing", value); }
        }
        public bool bResizeSpriteDataToMatchTextures {
            get {return Main.GetGetBoolPropertyByName(this, "bResizeSpriteDataToMatchTextures"); }
            set {Main.SetGetBoolPropertyByName(this, "bResizeSpriteDataToMatchTextures", value); }
        }
        static PaperRuntimeSettings() {
            StaticClass = Main.GetClass("PaperRuntimeSettings");
        }
        internal unsafe PaperRuntimeSettings_fields* PaperRuntimeSettings_ptr => (PaperRuntimeSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperRuntimeSettings(IntPtr p) => UObject.Make<PaperRuntimeSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperRuntimeSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperRuntimeSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
