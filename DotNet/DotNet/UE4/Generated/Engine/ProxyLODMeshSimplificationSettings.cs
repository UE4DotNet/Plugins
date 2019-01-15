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
    ///<summary>Controls the system used to generate proxy LODs with merged meshes (i.e. the HLOD system).</summary>
    public unsafe partial class ProxyLODMeshSimplificationSettings : DeveloperSettings  {
        ///<summary>Mesh reduction plugin to use when simplifying mesh geometry for Hierarchical LOD</summary>
        public unsafe Name ProxyLODMeshReductionModuleName {
            get {return ProxyLODMeshSimplificationSettings_ptr->ProxyLODMeshReductionModuleName;}
            set {ProxyLODMeshSimplificationSettings_ptr->ProxyLODMeshReductionModuleName = value;}
        }
        static ProxyLODMeshSimplificationSettings() {
            StaticClass = Main.GetClass("ProxyLODMeshSimplificationSettings");
        }
        internal unsafe ProxyLODMeshSimplificationSettings_fields* ProxyLODMeshSimplificationSettings_ptr => (ProxyLODMeshSimplificationSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProxyLODMeshSimplificationSettings(IntPtr p) => UObject.Make<ProxyLODMeshSimplificationSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProxyLODMeshSimplificationSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProxyLODMeshSimplificationSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
