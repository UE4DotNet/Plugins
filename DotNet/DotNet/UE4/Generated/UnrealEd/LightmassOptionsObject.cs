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
    ///<summary>Lightmass Options Object</summary>
    public unsafe partial class LightmassOptionsObject : UObject  {
        ///<summary>Debug Settings</summary>
        public unsafe LightmassDebugOptions DebugSettings {
            get {return LightmassOptionsObject_ptr->DebugSettings;}
            set {LightmassOptionsObject_ptr->DebugSettings = value;}
        }
        ///<summary>Swarm Settings</summary>
        public unsafe SwarmDebugOptions SwarmSettings {
            get {return LightmassOptionsObject_ptr->SwarmSettings;}
            set {LightmassOptionsObject_ptr->SwarmSettings = value;}
        }
        static LightmassOptionsObject() {
            StaticClass = Main.GetClass("LightmassOptionsObject");
        }
        internal unsafe LightmassOptionsObject_fields* LightmassOptionsObject_ptr => (LightmassOptionsObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightmassOptionsObject(IntPtr p) => UObject.Make<LightmassOptionsObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightmassOptionsObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightmassOptionsObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
