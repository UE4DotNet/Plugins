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
    ///<summary>Particle Module Mesh Material</summary>
    public unsafe partial class ParticleModuleMeshMaterial : ParticleModuleMaterialBase  {
        ///<summary>The array of materials to apply to the mesh particles.</summary>
        public ObjectArrayField<MaterialInterface> MeshMaterials{ get {
            if(MeshMaterials_store == null) MeshMaterials_store = new ObjectArrayField<MaterialInterface> (&ParticleModuleMeshMaterial_ptr->MeshMaterials);
            return MeshMaterials_store;
        } }
        private ObjectArrayField<MaterialInterface> MeshMaterials_store;

        static ParticleModuleMeshMaterial() {
            StaticClass = Main.GetClass("ParticleModuleMeshMaterial");
        }
        internal unsafe ParticleModuleMeshMaterial_fields* ParticleModuleMeshMaterial_ptr => (ParticleModuleMeshMaterial_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleMeshMaterial(IntPtr p) => UObject.Make<ParticleModuleMeshMaterial>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleMeshMaterial DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleMeshMaterial New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
