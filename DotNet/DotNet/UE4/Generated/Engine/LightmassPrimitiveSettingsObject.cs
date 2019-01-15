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
    ///<summary>Lightmass Primitive Settings Object</summary>
    public unsafe partial class LightmassPrimitiveSettingsObject : UObject  {
        ///<summary>Lightmass Settings</summary>
        public unsafe LightmassPrimitiveSettings LightmassSettings {
            get {return LightmassPrimitiveSettingsObject_ptr->LightmassSettings;}
            set {LightmassPrimitiveSettingsObject_ptr->LightmassSettings = value;}
        }
        static LightmassPrimitiveSettingsObject() {
            StaticClass = Main.GetClass("LightmassPrimitiveSettingsObject");
        }
        internal unsafe LightmassPrimitiveSettingsObject_fields* LightmassPrimitiveSettingsObject_ptr => (LightmassPrimitiveSettingsObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightmassPrimitiveSettingsObject(IntPtr p) => UObject.Make<LightmassPrimitiveSettingsObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightmassPrimitiveSettingsObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightmassPrimitiveSettingsObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
