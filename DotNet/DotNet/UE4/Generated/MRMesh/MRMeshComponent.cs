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
using UE4.MRMesh.Native;
using UE4.Engine;

namespace UE4.MRMesh {
    ///<summary>MRMesh Component</summary>
    public unsafe partial class MRMeshComponent : PrimitiveComponent  {

        ///<summary>Clear</summary>
        public void Clear()  => 
            MRMeshComponent_methods.Clear_method.Invoke(ObjPointer);

        ///<summary>Force Nav Mesh Update</summary>
        public void ForceNavMeshUpdate()  => 
            MRMeshComponent_methods.ForceNavMeshUpdate_method.Invoke(ObjPointer);

        ///<summary>Is Connected</summary>
        public bool IsConnected()  => 
            MRMeshComponent_methods.IsConnected_method.Invoke(ObjPointer);
        ///<summary>Material</summary>
        public unsafe MaterialInterface Material {
            get {return MRMeshComponent_ptr->Material;}
            set {MRMeshComponent_ptr->Material = value;}
        }
        public bool bCreateMeshProxySections {
            get {return Main.GetGetBoolPropertyByName(this, "bCreateMeshProxySections"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreateMeshProxySections", value); }
        }
        public bool bUpdateNavMeshOnMeshUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateNavMeshOnMeshUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateNavMeshOnMeshUpdate", value); }
        }
        ///<summary>Body Setups</summary>
        public ObjectArrayField<BodySetup> BodySetups{ get {
            if(BodySetups_store == null) BodySetups_store = new ObjectArrayField<BodySetup> (&MRMeshComponent_ptr->BodySetups);
            return BodySetups_store;
        } }
        private ObjectArrayField<BodySetup> BodySetups_store;

        static MRMeshComponent() {
            StaticClass = Main.GetClass("MRMeshComponent");
        }
        internal unsafe MRMeshComponent_fields* MRMeshComponent_ptr => (MRMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MRMeshComponent(IntPtr p) => UObject.Make<MRMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MRMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MRMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
