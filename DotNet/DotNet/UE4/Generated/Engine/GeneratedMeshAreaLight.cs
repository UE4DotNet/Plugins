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
    ///<summary>Implements a light that is created after a lighting build with Lightmass and handles mesh area light influence on dynamic objects.</summary>
    public unsafe partial class GeneratedMeshAreaLight : SpotLight  {
        static GeneratedMeshAreaLight() {
            StaticClass = Main.GetClass("GeneratedMeshAreaLight");
        }
        internal unsafe GeneratedMeshAreaLight_fields* GeneratedMeshAreaLight_ptr => (GeneratedMeshAreaLight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeneratedMeshAreaLight(IntPtr p) => UObject.Make<GeneratedMeshAreaLight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeneratedMeshAreaLight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeneratedMeshAreaLight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
