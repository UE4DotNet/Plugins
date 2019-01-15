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
    ///<summary>An Anim Blueprint is essentially a specialized Blueprint whose graphs control the animation of a Skeletal Mesh.</summary>
    ///<remarks>
    ///It can perform blending of animations, directly control the bones of the skeleton, and output a final pose
    ///for a Skeletal Mesh each frame.
    ///</remarks>
    public unsafe partial class AnimBlueprint : Blueprint  {
        ///<summary>The kind of skeleton that animation graphs compiled from the blueprint will animate</summary>
        public unsafe Skeleton TargetSkeleton {
            get {return AnimBlueprint_ptr->TargetSkeleton;}
            set {AnimBlueprint_ptr->TargetSkeleton = value;}
        }
         //TODO: array not UObject TArray Groups
        public bool bUseMultiThreadedAnimationUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bUseMultiThreadedAnimationUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseMultiThreadedAnimationUpdate", value); }
        }
        public bool bWarnAboutBlueprintUsage {
            get {return Main.GetGetBoolPropertyByName(this, "bWarnAboutBlueprintUsage"); }
            set {Main.SetGetBoolPropertyByName(this, "bWarnAboutBlueprintUsage", value); }
        }
         //TODO: array not UObject TArray ParentAssetOverrides
        ///<summary>Array of active pose watches (pose watch allows us to see the bone pose at a</summary>
        ///<remarks>particular point of the anim graph)</remarks>
        public ObjectArrayField<PoseWatch> PoseWatches{ get {
            if(PoseWatches_store == null) PoseWatches_store = new ObjectArrayField<PoseWatch> (&AnimBlueprint_ptr->PoseWatches);
            return PoseWatches_store;
        } }
        private ObjectArrayField<PoseWatch> PoseWatches_store;

         //TODO: soft object TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
        static AnimBlueprint() {
            StaticClass = Main.GetClass("AnimBlueprint");
        }
        internal unsafe AnimBlueprint_fields* AnimBlueprint_ptr => (AnimBlueprint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimBlueprint(IntPtr p) => UObject.Make<AnimBlueprint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimBlueprint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimBlueprint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
