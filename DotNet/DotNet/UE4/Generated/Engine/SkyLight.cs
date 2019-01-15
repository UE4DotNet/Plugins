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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Sky Light</summary>
    public unsafe partial class SkyLight : Info  {
        ///<summary>@todo document</summary>
        public unsafe SkyLightComponent LightComponent {
            get {return SkyLight_ptr->LightComponent;}
        }
        public bool bEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnabled", value); }
        }
        static SkyLight() {
            StaticClass = Main.GetClass("SkyLight");
        }
        internal unsafe SkyLight_fields* SkyLight_ptr => (SkyLight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkyLight(IntPtr p) => UObject.Make<SkyLight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkyLight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkyLight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
