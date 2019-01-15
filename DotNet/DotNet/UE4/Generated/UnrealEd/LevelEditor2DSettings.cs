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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Configure settings for the 2D Level Editor</summary>
    public unsafe partial class LevelEditor2DSettings : DeveloperSettings  {
        public bool bEnable2DWidget {
            get {return Main.GetGetBoolPropertyByName(this, "bEnable2DWidget"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnable2DWidget", value); }
        }
        public bool bEnableSnapLayers {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableSnapLayers"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableSnapLayers", value); }
        }
         //TODO: enum ELevelEditor2DAxis SnapAxis
         //TODO: array not UObject TArray SnapLayers
        static LevelEditor2DSettings() {
            StaticClass = Main.GetClass("LevelEditor2DSettings");
        }
        internal unsafe LevelEditor2DSettings_fields* LevelEditor2DSettings_ptr => (LevelEditor2DSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelEditor2DSettings(IntPtr p) => UObject.Make<LevelEditor2DSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelEditor2DSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelEditor2DSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
