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
    ///<summary>SkeletalMeshActor is an instance of a USkeletalMesh in the world.</summary>
    ///<remarks>
    ///Skeletal meshes are deformable meshes that can be animated and change their geometry at run-time.
    ///Skeletal meshes dragged into the level from the Content Browser are automatically converted to StaticMeshActors.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Content/Types/SkeletalMeshes/
    ///@see USkeletalMesh
    ///</remarks>
    public unsafe partial class SkeletalMeshActor : Actor  {
        public bool bShouldDoAnimNotifies {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldDoAnimNotifies"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldDoAnimNotifies", value); }
        }
        ///<summary>Skeletal Mesh Component</summary>
        public unsafe SkeletalMeshComponent SkeletalMeshComponent {
            get {return SkeletalMeshActor_ptr->SkeletalMeshComponent;}
        }
        ///<summary>Used to replicate mesh to clients</summary>
        public unsafe SkeletalMesh ReplicatedMesh {
            get {return SkeletalMeshActor_ptr->ReplicatedMesh;}
            set {SkeletalMeshActor_ptr->ReplicatedMesh = value;}
        }
        ///<summary>Used to replicate physics asset to clients</summary>
        public unsafe PhysicsAsset ReplicatedPhysAsset {
            get {return SkeletalMeshActor_ptr->ReplicatedPhysAsset;}
            set {SkeletalMeshActor_ptr->ReplicatedPhysAsset = value;}
        }
        ///<summary>used to replicate the material in index 0</summary>
        public unsafe MaterialInterface ReplicatedMaterial0 {
            get {return SkeletalMeshActor_ptr->ReplicatedMaterial0;}
            set {SkeletalMeshActor_ptr->ReplicatedMaterial0 = value;}
        }
        ///<summary>Replicated Material 1</summary>
        public unsafe MaterialInterface ReplicatedMaterial1 {
            get {return SkeletalMeshActor_ptr->ReplicatedMaterial1;}
            set {SkeletalMeshActor_ptr->ReplicatedMaterial1 = value;}
        }
        static SkeletalMeshActor() {
            StaticClass = Main.GetClass("SkeletalMeshActor");
        }
        internal unsafe SkeletalMeshActor_fields* SkeletalMeshActor_ptr => (SkeletalMeshActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkeletalMeshActor(IntPtr p) => UObject.Make<SkeletalMeshActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkeletalMeshActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkeletalMeshActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
