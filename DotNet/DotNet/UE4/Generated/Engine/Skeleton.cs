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
    ///<summary>
    ///USkeleton : that links between mesh and animation
    ///        - Bone hierarchy for animations
    ///        - Bone/track linkup between mesh and animation
    ///        - Retargetting related
    ///</summary>
    ///<remarks>- Mirror table</remarks>
    public unsafe partial class Skeleton : UObject  {
         //TODO: array not UObject TArray BoneTree
        ///<summary>Guid for virtual bones.</summary>
        ///<remarks>Separate so that we don't have to dirty the original guid when only changing virtual bones</remarks>
        public unsafe FGuid VirtualBoneGuid {
            get {return Skeleton_ptr->VirtualBoneGuid;}
            set {Skeleton_ptr->VirtualBoneGuid = value;}
        }
         //TODO: array not UObject TArray VirtualBones
        ///<summary>
        ///Array of named socket locations, set up in editor and used as a shortcut instead of specifying
        ///everything explicitly to AttachComponent in the SkeletalMeshComponent.
        ///</summary>
        public ObjectArrayField<SkeletalMeshSocket> Sockets{ get {
            if(Sockets_store == null) Sockets_store = new ObjectArrayField<SkeletalMeshSocket> (&Skeleton_ptr->Sockets);
            return Sockets_store;
        } }
        private ObjectArrayField<SkeletalMeshSocket> Sockets_store;

        ///<summary>Container for smart name mappings</summary>
        public unsafe SmartNameContainer SmartNames {
            get {return Skeleton_ptr->SmartNames;}
            set {Skeleton_ptr->SmartNames = value;}
        }
        ///<summary>List of blend profiles available in this skeleton</summary>
        public ObjectArrayField<BlendProfile> BlendProfiles{ get {
            if(BlendProfiles_store == null) BlendProfiles_store = new ObjectArrayField<BlendProfile> (&Skeleton_ptr->BlendProfiles);
            return BlendProfiles_store;
        } }
        private ObjectArrayField<BlendProfile> BlendProfiles_store;

         //TODO: array not UObject TArray SlotGroups
         //TODO: soft object TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
         //TODO: soft object TSoftObjectPtr<UDataAsset> AdditionalPreviewSkeletalMeshes
        ///<summary>Rig Config</summary>
        public unsafe RigConfiguration RigConfig {
            get {return Skeleton_ptr->RigConfig;}
            set {Skeleton_ptr->RigConfig = value;}
        }
         //TODO: array not UObject TArray AnimationNotifies
        ///<summary>Attached assets component for this skeleton</summary>
        public unsafe PreviewAssetAttachContainer PreviewAttachedAssetContainer {
            get {return Skeleton_ptr->PreviewAttachedAssetContainer;}
            set {Skeleton_ptr->PreviewAttachedAssetContainer = value;}
        }
        ///<summary>Array of user data stored with the asset</summary>
        public ObjectArrayField<AssetUserData> AssetUserData{ get {
            if(AssetUserData_store == null) AssetUserData_store = new ObjectArrayField<AssetUserData> (&Skeleton_ptr->AssetUserData);
            return AssetUserData_store;
        } }
        private ObjectArrayField<AssetUserData> AssetUserData_store;

        static Skeleton() {
            StaticClass = Main.GetClass("Skeleton");
        }
        internal unsafe Skeleton_fields* Skeleton_ptr => (Skeleton_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Skeleton(IntPtr p) => UObject.Make<Skeleton>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Skeleton DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Skeleton New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
