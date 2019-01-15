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
using UE4.Slate.Native;

namespace UE4.Slate {
    ///<summary>Settings that control Slate functionality</summary>
    public unsafe partial class SlateSettings : UObject  {
        public bool bExplicitCanvasChildZOrder {
            get {return Main.GetGetBoolPropertyByName(this, "bExplicitCanvasChildZOrder"); }
            set {Main.SetGetBoolPropertyByName(this, "bExplicitCanvasChildZOrder", value); }
        }
        static SlateSettings() {
            StaticClass = Main.GetClass("SlateSettings");
        }
        internal unsafe SlateSettings_fields* SlateSettings_ptr => (SlateSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SlateSettings(IntPtr p) => UObject.Make<SlateSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SlateSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SlateSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
