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
    ///<summary>Animation Asset</summary>
    public unsafe partial class AnimationAsset : UObject  {
        ///<summary>Pointer to the Skeleton this asset can be played on .</summary>
        public unsafe Skeleton Skeleton {
            get {return AnimationAsset_ptr->Skeleton;}
            set {AnimationAsset_ptr->Skeleton = value;}
        }
        ///<summary>Meta data that can be saved with the asset</summary>
        ///<remarks>You can query by GetMetaData function</remarks>
        public ObjectArrayField<AnimMetaData> MetaData{ get {
            if(MetaData_store == null) MetaData_store = new ObjectArrayField<AnimMetaData> (&AnimationAsset_ptr->MetaData);
            return MetaData_store;
        } }
        private ObjectArrayField<AnimMetaData> MetaData_store;

        ///<summary>Parent Asset, if set, you won't be able to edit any data in here but just mapping table</summary>
        ///<remarks>During cooking, this data will be used to bake out to normal asset</remarks>
        public unsafe AnimationAsset ParentAsset {
            get {return AnimationAsset_ptr->ParentAsset;}
            set {AnimationAsset_ptr->ParentAsset = value;}
        }
        ///<summary>note this is transient as they're added as they're loaded</summary>
        public ObjectArrayField<AnimationAsset> ChildrenAssets{ get {
            if(ChildrenAssets_store == null) ChildrenAssets_store = new ObjectArrayField<AnimationAsset> (&AnimationAsset_ptr->ChildrenAssets);
            return ChildrenAssets_store;
        } }
        private ObjectArrayField<AnimationAsset> ChildrenAssets_store;

        ///<summary>Asset mapping table when ParentAsset is set</summary>
        public unsafe AssetMappingTable AssetMappingTable {
            get {return AnimationAsset_ptr->AssetMappingTable;}
            set {AnimationAsset_ptr->AssetMappingTable = value;}
        }
        ///<summary>Array of user data stored with the asset</summary>
        public ObjectArrayField<AssetUserData> AssetUserData{ get {
            if(AssetUserData_store == null) AssetUserData_store = new ObjectArrayField<AssetUserData> (&AnimationAsset_ptr->AssetUserData);
            return AssetUserData_store;
        } }
        private ObjectArrayField<AssetUserData> AssetUserData_store;

        ///<summary>Information for thumbnail rendering</summary>
        public unsafe ThumbnailInfo ThumbnailInfo {
            get {return AnimationAsset_ptr->ThumbnailInfo;}
            set {AnimationAsset_ptr->ThumbnailInfo = value;}
        }
        ///<summary>The default skeletal mesh to use when previewing this asset - this only applies when you open Persona using this asset// @todo: note that this doesn't retarget right now</summary>
        public unsafe PoseAsset PreviewPoseAsset {
            get {return AnimationAsset_ptr->PreviewPoseAsset;}
            set {AnimationAsset_ptr->PreviewPoseAsset = value;}
        }
         //TODO: soft object TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
        static AnimationAsset() {
            StaticClass = Main.GetClass("AnimationAsset");
        }
        internal unsafe AnimationAsset_fields* AnimationAsset_ptr => (AnimationAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationAsset(IntPtr p) => UObject.Make<AnimationAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
