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
    ///<summary>Mesh Simplification Settings</summary>
    public unsafe partial class MeshSimplificationSettings : DeveloperSettings  {
        ///<summary>Mesh reduction plugin to use when simplifying mesh geometry</summary>
        public unsafe Name MeshReductionModuleName {
            get {return MeshSimplificationSettings_ptr->MeshReductionModuleName;}
            set {MeshSimplificationSettings_ptr->MeshReductionModuleName = value;}
        }
        static MeshSimplificationSettings() {
            StaticClass = Main.GetClass("MeshSimplificationSettings");
        }
        internal unsafe MeshSimplificationSettings_fields* MeshSimplificationSettings_ptr => (MeshSimplificationSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshSimplificationSettings(IntPtr p) => UObject.Make<MeshSimplificationSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshSimplificationSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshSimplificationSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
