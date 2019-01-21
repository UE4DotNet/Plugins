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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Fbx Scene Import Options Skeletal Mesh</summary>
    public unsafe partial class FbxSceneImportOptionsSkeletalMesh : UObject  {
        public bool bUpdateSkeletonReferencePose {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateSkeletonReferencePose"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateSkeletonReferencePose", value); }
        }
        public bool bCreatePhysicsAsset {
            get {return Main.GetGetBoolPropertyByName(this, "bCreatePhysicsAsset"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreatePhysicsAsset", value); }
        }
        public bool bUseT0AsRefPose {
            get {return Main.GetGetBoolPropertyByName(this, "bUseT0AsRefPose"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseT0AsRefPose", value); }
        }
        public bool bPreserveSmoothingGroups {
            get {return Main.GetGetBoolPropertyByName(this, "bPreserveSmoothingGroups"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreserveSmoothingGroups", value); }
        }
        public bool bImportMeshesInBoneHierarchy {
            get {return Main.GetGetBoolPropertyByName(this, "bImportMeshesInBoneHierarchy"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportMeshesInBoneHierarchy", value); }
        }
        public bool bImportMorphTargets {
            get {return Main.GetGetBoolPropertyByName(this, "bImportMorphTargets"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportMorphTargets", value); }
        }
        ///<summary>Threshold to compare vertex position equality.</summary>
        public unsafe float ThresholdPosition {
            get {return FbxSceneImportOptionsSkeletalMesh_ptr->ThresholdPosition;}
            set {FbxSceneImportOptionsSkeletalMesh_ptr->ThresholdPosition = value;}
        }
        ///<summary>Threshold to compare normal, tangent or bi-normal equality.</summary>
        public unsafe float ThresholdTangentNormal {
            get {return FbxSceneImportOptionsSkeletalMesh_ptr->ThresholdTangentNormal;}
            set {FbxSceneImportOptionsSkeletalMesh_ptr->ThresholdTangentNormal = value;}
        }
        ///<summary>Threshold to compare UV equality.</summary>
        public unsafe float ThresholdUV {
            get {return FbxSceneImportOptionsSkeletalMesh_ptr->ThresholdUV;}
            set {FbxSceneImportOptionsSkeletalMesh_ptr->ThresholdUV = value;}
        }
        public bool bImportAnimations {
            get {return Main.GetGetBoolPropertyByName(this, "bImportAnimations"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportAnimations", value); }
        }
        ///<summary>Type of asset to import from the FBX file</summary>
        public unsafe byte AnimationLength {
            get {return FbxSceneImportOptionsSkeletalMesh_ptr->AnimationLength;}
            set {FbxSceneImportOptionsSkeletalMesh_ptr->AnimationLength = value;}
        }
        ///<summary>Frame range used when Set Range is used in Animation Length</summary>
        public unsafe Int32Interval FrameImportRange {
            get {return FbxSceneImportOptionsSkeletalMesh_ptr->FrameImportRange;}
            set {FbxSceneImportOptionsSkeletalMesh_ptr->FrameImportRange = value;}
        }
        public bool bUseDefaultSampleRate {
            get {return Main.GetGetBoolPropertyByName(this, "bUseDefaultSampleRate"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseDefaultSampleRate", value); }
        }
        ///<summary>Sample fbx animation data at the specified sample rate, 0 find automaticaly the best sample rate</summary>
        public unsafe int CustomSampleRate {
            get {return FbxSceneImportOptionsSkeletalMesh_ptr->CustomSampleRate;}
            set {FbxSceneImportOptionsSkeletalMesh_ptr->CustomSampleRate = value;}
        }
        public bool bImportCustomAttribute {
            get {return Main.GetGetBoolPropertyByName(this, "bImportCustomAttribute"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportCustomAttribute", value); }
        }
        public bool bPreserveLocalTransform {
            get {return Main.GetGetBoolPropertyByName(this, "bPreserveLocalTransform"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreserveLocalTransform", value); }
        }
        public bool bDeleteExistingMorphTargetCurves {
            get {return Main.GetGetBoolPropertyByName(this, "bDeleteExistingMorphTargetCurves"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeleteExistingMorphTargetCurves", value); }
        }
        static FbxSceneImportOptionsSkeletalMesh() {
            StaticClass = Main.GetClass("FbxSceneImportOptionsSkeletalMesh");
        }
        internal unsafe FbxSceneImportOptionsSkeletalMesh_fields* FbxSceneImportOptionsSkeletalMesh_ptr => (FbxSceneImportOptionsSkeletalMesh_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxSceneImportOptionsSkeletalMesh(IntPtr p) => UObject.Make<FbxSceneImportOptionsSkeletalMesh>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxSceneImportOptionsSkeletalMesh DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxSceneImportOptionsSkeletalMesh New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
