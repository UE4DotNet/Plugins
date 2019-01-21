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
    ///* Any property you're adding to AnimMontage and parent class has to be considered for Child Asset
    ///*
    ///* Child Asset is considered to be only asset mapping feature using everything else in the class
    ///* For example, you can just use all parent's setting  for the montage, but only remap assets
    ///* This isn't magic bullet unfortunately and it is consistent effort of keeping the data synced with parent
    ///* If you add new property, please make sure those property has to be copied for children.
    ///</summary>
    ///<remarks>* If it does, please add the copy in the function RefreshParentAssetData</remarks>
    public unsafe partial class AnimMontage : AnimCompositeBase  {

        ///<summary>Get Default Blend Out Time</summary>
        public float GetDefaultBlendOutTime()  => 
            AnimMontage_methods.GetDefaultBlendOutTime_method.Invoke(ObjPointer);
        ///<summary>Blend in option.</summary>
        public unsafe AlphaBlend BlendIn {
            get {return AnimMontage_ptr->BlendIn;}
            set {AnimMontage_ptr->BlendIn = value;}
        }
        ///<summary>Blend out option. This is only used when it blends out itself. If it's interrupted by other montages, it will use new montage's BlendIn option to blend out.</summary>
        public unsafe AlphaBlend BlendOut {
            get {return AnimMontage_ptr->BlendOut;}
            set {AnimMontage_ptr->BlendOut = value;}
        }
        ///<summary>Time from Sequence End to trigger blend out.</summary>
        ///<remarks>
        ///<0 means using BlendOutTime, so BlendOut finishes as Montage ends.
        ///>=0 means using 'SequenceEnd - BlendOutTriggerTime' to trigger blend out.
        ///</remarks>
        public unsafe float BlendOutTriggerTime {
            get {return AnimMontage_ptr->BlendOutTriggerTime;}
            set {AnimMontage_ptr->BlendOutTriggerTime = value;}
        }
        ///<summary>If you're using marker based sync for this montage, make sure to add sync group name. For now we only support one group</summary>
        public unsafe Name SyncGroup {
            get {return AnimMontage_ptr->SyncGroup;}
            set {AnimMontage_ptr->SyncGroup = value;}
        }
        ///<summary>wip: until we have UI working</summary>
        public unsafe int SyncSlotIndex {
            get {return AnimMontage_ptr->SyncSlotIndex;}
            set {AnimMontage_ptr->SyncSlotIndex = value;}
        }
        ///<summary>Marker Data</summary>
        public unsafe MarkerSyncData MarkerData {
            get {return AnimMontage_ptr->MarkerData;}
            set {AnimMontage_ptr->MarkerData = value;}
        }
         //TODO: array not UObject TArray CompositeSections
         //TODO: array not UObject TArray SlotAnimTracks
        public bool bEnableRootMotionTranslation {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableRootMotionTranslation"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableRootMotionTranslation", value); }
        }
        public bool bEnableRootMotionRotation {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableRootMotionRotation"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableRootMotionRotation", value); }
        }
        public bool bEnableAutoBlendOut {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableAutoBlendOut"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableAutoBlendOut", value); }
        }
        ///<summary>Root Bone will be locked to that position when extracting root motion. DEPRECATED in 4.5 root motion is controlled by anim sequences *</summary>
        public unsafe byte RootMotionRootLock {
            get {return AnimMontage_ptr->RootMotionRootLock;}
            set {AnimMontage_ptr->RootMotionRootLock = value;}
        }
        ///<summary>Preview Base pose for additive BlendSpace *</summary>
        public unsafe AnimSequence PreviewBasePose {
            get {return AnimMontage_ptr->PreviewBasePose;}
            set {AnimMontage_ptr->PreviewBasePose = value;}
        }
         //TODO: array not UObject TArray BranchingPointMarkers
         //TODO: array not UObject TArray BranchingPointStateNotifyIndices
        ///<summary>Time Stretch Curve</summary>
        public unsafe TimeStretchCurve TimeStretchCurve {
            get {return AnimMontage_ptr->TimeStretchCurve;}
            set {AnimMontage_ptr->TimeStretchCurve = value;}
        }
        ///<summary>Name of optional TimeStretchCurveName to look for in Montage.</summary>
        public unsafe Name TimeStretchCurveName {
            get {return AnimMontage_ptr->TimeStretchCurveName;}
            set {AnimMontage_ptr->TimeStretchCurveName = value;}
        }
        static AnimMontage() {
            StaticClass = Main.GetClass("AnimMontage");
        }
        internal unsafe AnimMontage_fields* AnimMontage_ptr => (AnimMontage_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimMontage(IntPtr p) => UObject.Make<AnimMontage>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimMontage DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimMontage New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
