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
    ///<summary>UPoseableMeshComponent that allows bone transforms to be driven by blueprint.</summary>
    public unsafe partial class PoseableMeshComponent : SkinnedMeshComponent  {

        ///<summary>Copy Pose from Skeletal Component</summary>
        public void CopyPoseFromSkeletalComponent(SkeletalMeshComponent InComponentToCopy)  => 
            PoseableMeshComponent_methods.CopyPoseFromSkeletalComponent_method.Invoke(ObjPointer, InComponentToCopy);

        ///<summary>Get Bone Location by Name</summary>
        public Vector GetBoneLocationByName(Name BoneName, byte BoneSpace)  => 
            PoseableMeshComponent_methods.GetBoneLocationByName_method.Invoke(ObjPointer, BoneName, BoneSpace);

        ///<summary>Get Bone Rotation by Name</summary>
        public Rotator GetBoneRotationByName(Name BoneName, byte BoneSpace)  => 
            PoseableMeshComponent_methods.GetBoneRotationByName_method.Invoke(ObjPointer, BoneName, BoneSpace);

        ///<summary>Get Bone Scale by Name</summary>
        public Vector GetBoneScaleByName(Name BoneName, byte BoneSpace)  => 
            PoseableMeshComponent_methods.GetBoneScaleByName_method.Invoke(ObjPointer, BoneName, BoneSpace);

        ///<summary>Get Bone Transform by Name</summary>
        public Transform GetBoneTransformByName(Name BoneName, byte BoneSpace)  => 
            PoseableMeshComponent_methods.GetBoneTransformByName_method.Invoke(ObjPointer, BoneName, BoneSpace);

        ///<summary>Reset Bone Transform by Name</summary>
        public void ResetBoneTransformByName(Name BoneName)  => 
            PoseableMeshComponent_methods.ResetBoneTransformByName_method.Invoke(ObjPointer, BoneName);

        ///<summary>Set Bone Location by Name</summary>
        public void SetBoneLocationByName(Name BoneName, Vector InLocation, byte BoneSpace)  => 
            PoseableMeshComponent_methods.SetBoneLocationByName_method.Invoke(ObjPointer, BoneName, InLocation, BoneSpace);

        ///<summary>Set Bone Rotation by Name</summary>
        public void SetBoneRotationByName(Name BoneName, Rotator InRotation, byte BoneSpace)  => 
            PoseableMeshComponent_methods.SetBoneRotationByName_method.Invoke(ObjPointer, BoneName, InRotation, BoneSpace);

        ///<summary>Set Bone Scale by Name</summary>
        public void SetBoneScaleByName(Name BoneName, Vector InScale3D, byte BoneSpace)  => 
            PoseableMeshComponent_methods.SetBoneScaleByName_method.Invoke(ObjPointer, BoneName, InScale3D, BoneSpace);

        ///<summary>Set Bone Transform by Name</summary>
        public void SetBoneTransformByName(Name BoneName, Transform InTransform, byte BoneSpace)  => 
            PoseableMeshComponent_methods.SetBoneTransformByName_method.Invoke(ObjPointer, BoneName, InTransform, BoneSpace);
        static PoseableMeshComponent() {
            StaticClass = Main.GetClass("PoseableMeshComponent");
        }
        internal unsafe PoseableMeshComponent_fields* PoseableMeshComponent_ptr => (PoseableMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PoseableMeshComponent(IntPtr p) => UObject.Make<PoseableMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PoseableMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PoseableMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
