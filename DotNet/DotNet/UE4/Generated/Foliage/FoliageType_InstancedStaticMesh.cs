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
using UE4.Foliage.Native;
using UE4.Engine;

namespace UE4.Foliage {
    ///<summary>Foliage Type Instanced Static Mesh</summary>
    public unsafe partial class FoliageType_InstancedStaticMesh : FoliageType  {
        ///<summary>Mesh</summary>
        public unsafe StaticMesh Mesh {
            get {return FoliageType_InstancedStaticMesh_ptr->Mesh;}
            set {FoliageType_InstancedStaticMesh_ptr->Mesh = value;}
        }
        ///<summary>Material overrides for foliage instances.</summary>
        public ObjectArrayField<MaterialInterface> OverrideMaterials{ get {
            if(OverrideMaterials_store == null) OverrideMaterials_store = new ObjectArrayField<MaterialInterface> (&FoliageType_InstancedStaticMesh_ptr->OverrideMaterials);
            return OverrideMaterials_store;
        } }
        private ObjectArrayField<MaterialInterface> OverrideMaterials_store;

        ///<summary>The component class to use for foliage instances.</summary>
        ///<remarks>You can make a Blueprint subclass of FoliageInstancedStaticMeshComponent to implement custom behavior and assign that class here.</remarks>
        public unsafe SubclassOf<FoliageInstancedStaticMeshComponent> ComponentClass {
            get {return FoliageType_InstancedStaticMesh_ptr->ComponentClass;}
            set {FoliageType_InstancedStaticMesh_ptr->ComponentClass = value;}
        }
        static FoliageType_InstancedStaticMesh() {
            StaticClass = Main.GetClass("FoliageType_InstancedStaticMesh");
        }
        internal unsafe FoliageType_InstancedStaticMesh_fields* FoliageType_InstancedStaticMesh_ptr => (FoliageType_InstancedStaticMesh_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FoliageType_InstancedStaticMesh(IntPtr p) => UObject.Make<FoliageType_InstancedStaticMesh>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FoliageType_InstancedStaticMesh DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FoliageType_InstancedStaticMesh New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
