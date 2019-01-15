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
    ///<summary>PhysicsAsset contains a set of rigid bodies and constraints that make up a single ragdoll.</summary>
    ///<remarks>
    ///The asset is not limited to human ragdolls, and can be used for any physical simulation using bodies and constraints.
    ///A SkeletalMesh has a single PhysicsAsset, which allows for easily turning ragdoll physics on or off for many SkeletalMeshComponents
    ///The asset can be configured inside the Physics Asset Editor.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Physics/PhAT/Reference/index.html
    ///@see USkeletalMesh
    ///</remarks>
    public unsafe partial class PhysicsAsset : UObject  {
         //TODO: soft object TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
         //TODO: array not UObject TArray PhysicalAnimationProfiles
         //TODO: array not UObject TArray ConstraintProfiles
        ///<summary>Current Physical Animation Profile Name</summary>
        public unsafe Name CurrentPhysicalAnimationProfileName {
            get {return PhysicsAsset_ptr->CurrentPhysicalAnimationProfileName;}
            set {PhysicsAsset_ptr->CurrentPhysicalAnimationProfileName = value;}
        }
        ///<summary>Current Constraint Profile Name</summary>
        public unsafe Name CurrentConstraintProfileName {
            get {return PhysicsAsset_ptr->CurrentConstraintProfileName;}
            set {PhysicsAsset_ptr->CurrentConstraintProfileName = value;}
        }
         //TODO: array not UObject TArray BoundsBodies
        ///<summary>Array of SkeletalBodySetup objects.</summary>
        ///<remarks>
        ///Stores information about collision shape etc. for each body.
        ///Does not include body position - those are taken from mesh.
        ///</remarks>
        public ObjectArrayField<SkeletalBodySetup> SkeletalBodySetups{ get {
            if(SkeletalBodySetups_store == null) SkeletalBodySetups_store = new ObjectArrayField<SkeletalBodySetup> (&PhysicsAsset_ptr->SkeletalBodySetups);
            return SkeletalBodySetups_store;
        } }
        private ObjectArrayField<SkeletalBodySetup> SkeletalBodySetups_store;

        ///<summary>Array of RB_ConstraintSetup objects.</summary>
        ///<remarks>Stores information about a joint between two bodies, such as position relative to each body, joint limits etc.</remarks>
        public ObjectArrayField<PhysicsConstraintTemplate> ConstraintSetup{ get {
            if(ConstraintSetup_store == null) ConstraintSetup_store = new ObjectArrayField<PhysicsConstraintTemplate> (&PhysicsAsset_ptr->ConstraintSetup);
            return ConstraintSetup_store;
        } }
        private ObjectArrayField<PhysicsConstraintTemplate> ConstraintSetup_store;

        public bool bUseAsyncScene {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAsyncScene"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseAsyncScene", value); }
        }
        public bool bNotForDedicatedServer {
            get {return Main.GetGetBoolPropertyByName(this, "bNotForDedicatedServer"); }
            set {Main.SetGetBoolPropertyByName(this, "bNotForDedicatedServer", value); }
        }
        ///<summary>Information for thumbnail rendering</summary>
        public unsafe ThumbnailInfo ThumbnailInfo {
            get {return PhysicsAsset_ptr->ThumbnailInfo;}
            set {PhysicsAsset_ptr->ThumbnailInfo = value;}
        }
        static PhysicsAsset() {
            StaticClass = Main.GetClass("PhysicsAsset");
        }
        internal unsafe PhysicsAsset_fields* PhysicsAsset_ptr => (PhysicsAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsAsset(IntPtr p) => UObject.Make<PhysicsAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
