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
using UE4.DatasmithContent.Native;
using UE4.Engine;

namespace UE4.DatasmithContent {
    ///<summary>Datasmith Static Mesh Component Template</summary>
    public unsafe partial class DatasmithStaticMeshComponentTemplate : DatasmithSceneComponentTemplate  {
        ///<summary>Static Mesh</summary>
        public unsafe StaticMesh StaticMesh {
            get {return DatasmithStaticMeshComponentTemplate_ptr->StaticMesh;}
            set {DatasmithStaticMeshComponentTemplate_ptr->StaticMesh = value;}
        }
        ///<summary>Override Materials</summary>
        public ObjectArrayField<MaterialInterface> OverrideMaterials{ get {
            if(OverrideMaterials_store == null) OverrideMaterials_store = new ObjectArrayField<MaterialInterface> (&DatasmithStaticMeshComponentTemplate_ptr->OverrideMaterials);
            return OverrideMaterials_store;
        } }
        private ObjectArrayField<MaterialInterface> OverrideMaterials_store;

        static DatasmithStaticMeshComponentTemplate() {
            StaticClass = Main.GetClass("DatasmithStaticMeshComponentTemplate");
        }
        internal unsafe DatasmithStaticMeshComponentTemplate_fields* DatasmithStaticMeshComponentTemplate_ptr => (DatasmithStaticMeshComponentTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithStaticMeshComponentTemplate(IntPtr p) => UObject.Make<DatasmithStaticMeshComponentTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithStaticMeshComponentTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithStaticMeshComponentTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
