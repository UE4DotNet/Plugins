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
    ///<summary>StaticMeshActor is an instance of a UStaticMesh in the world.</summary>
    ///<remarks>
    ///Static meshes are geometry that do not animate or otherwise deform, and are more efficient to render than other types of geometry.
    ///Static meshes dragged into the level from the Content Browser are automatically converted to StaticMeshActors.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Actors/StaticMeshActor/
    ///@see UStaticMesh
    ///</remarks>
    public unsafe partial class StaticMeshActor : Actor  {

        ///<summary>Function to change mobility type</summary>
        public void SetMobility(byte InMobility)  => 
            StaticMeshActor_methods.SetMobility_method.Invoke(ObjPointer, InMobility);
        ///<summary>Static Mesh Component</summary>
        public unsafe StaticMeshComponent StaticMeshComponent {
            get {return StaticMeshActor_ptr->StaticMeshComponent;}
        }
        public bool bStaticMeshReplicateMovement {
            get {return Main.GetGetBoolPropertyByName(this, "bStaticMeshReplicateMovement"); }
            set {Main.SetGetBoolPropertyByName(this, "bStaticMeshReplicateMovement", value); }
        }
         //TODO: enum ENavDataGatheringMode NavigationGeometryGatheringMode
        static StaticMeshActor() {
            StaticClass = Main.GetClass("StaticMeshActor");
        }
        internal unsafe StaticMeshActor_fields* StaticMeshActor_ptr => (StaticMeshActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator StaticMeshActor(IntPtr p) => UObject.Make<StaticMeshActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static StaticMeshActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static StaticMeshActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
