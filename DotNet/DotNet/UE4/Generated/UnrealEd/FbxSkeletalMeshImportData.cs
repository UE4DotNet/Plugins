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
    ///<summary>Import data and options used when importing a static mesh from fbx</summary>
    public unsafe partial class FbxSkeletalMeshImportData : FbxMeshImportData  {
        ///<summary>Filter the content we want to import from the incoming FBX skeletal mesh.</summary>
        public unsafe byte ImportContentType {
            get {return FbxSkeletalMeshImportData_ptr->ImportContentType;}
            set {FbxSkeletalMeshImportData_ptr->ImportContentType = value;}
        }
        public bool bUpdateSkeletonReferencePose {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateSkeletonReferencePose"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateSkeletonReferencePose", value); }
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
            get {return FbxSkeletalMeshImportData_ptr->ThresholdPosition;}
            set {FbxSkeletalMeshImportData_ptr->ThresholdPosition = value;}
        }
        ///<summary>Threshold to compare normal, tangent or bi-normal equality.</summary>
        public unsafe float ThresholdTangentNormal {
            get {return FbxSkeletalMeshImportData_ptr->ThresholdTangentNormal;}
            set {FbxSkeletalMeshImportData_ptr->ThresholdTangentNormal = value;}
        }
        ///<summary>Threshold to compare UV equality.</summary>
        public unsafe float ThresholdUV {
            get {return FbxSkeletalMeshImportData_ptr->ThresholdUV;}
            set {FbxSkeletalMeshImportData_ptr->ThresholdUV = value;}
        }
        static FbxSkeletalMeshImportData() {
            StaticClass = Main.GetClass("FbxSkeletalMeshImportData");
        }
        internal unsafe FbxSkeletalMeshImportData_fields* FbxSkeletalMeshImportData_ptr => (FbxSkeletalMeshImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxSkeletalMeshImportData(IntPtr p) => UObject.Make<FbxSkeletalMeshImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxSkeletalMeshImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxSkeletalMeshImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
