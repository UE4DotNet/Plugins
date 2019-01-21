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
    ///<summary>Import data and options used when importing any mesh from FBX</summary>
    public unsafe partial class FbxAnimSequenceImportData : FbxAssetImportData  {
        public bool bImportMeshesInBoneHierarchy {
            get {return Main.GetGetBoolPropertyByName(this, "bImportMeshesInBoneHierarchy"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportMeshesInBoneHierarchy", value); }
        }
        ///<summary>Which animation range to import. The one defined at Exported, at Animated time or define a range manually</summary>
        public unsafe byte AnimationLength {
            get {return FbxAnimSequenceImportData_ptr->AnimationLength;}
            set {FbxAnimSequenceImportData_ptr->AnimationLength = value;}
        }
        ///<summary>Frame range used when Set Range is used in Animation Length</summary>
        public unsafe Int32Interval FrameImportRange {
            get {return FbxAnimSequenceImportData_ptr->FrameImportRange;}
            set {FbxAnimSequenceImportData_ptr->FrameImportRange = value;}
        }
        public bool bUseDefaultSampleRate {
            get {return Main.GetGetBoolPropertyByName(this, "bUseDefaultSampleRate"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseDefaultSampleRate", value); }
        }
        ///<summary>Sample fbx animation data at the specified sample rate, 0 find automaticaly the best sample rate</summary>
        public unsafe int CustomSampleRate {
            get {return FbxAnimSequenceImportData_ptr->CustomSampleRate;}
            set {FbxAnimSequenceImportData_ptr->CustomSampleRate = value;}
        }
         //TODO: string FString SourceAnimationName
        public bool bImportCustomAttribute {
            get {return Main.GetGetBoolPropertyByName(this, "bImportCustomAttribute"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportCustomAttribute", value); }
        }
        public bool bImportBoneTracks {
            get {return Main.GetGetBoolPropertyByName(this, "bImportBoneTracks"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportBoneTracks", value); }
        }
        public bool bSetMaterialDriveParameterOnCustomAttribute {
            get {return Main.GetGetBoolPropertyByName(this, "bSetMaterialDriveParameterOnCustomAttribute"); }
            set {Main.SetGetBoolPropertyByName(this, "bSetMaterialDriveParameterOnCustomAttribute", value); }
        }
         //TODO: array not UObject TArray MaterialCurveSuffixes
        public bool bRemoveRedundantKeys {
            get {return Main.GetGetBoolPropertyByName(this, "bRemoveRedundantKeys"); }
            set {Main.SetGetBoolPropertyByName(this, "bRemoveRedundantKeys", value); }
        }
        public bool bDeleteExistingMorphTargetCurves {
            get {return Main.GetGetBoolPropertyByName(this, "bDeleteExistingMorphTargetCurves"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeleteExistingMorphTargetCurves", value); }
        }
        public bool bDoNotImportCurveWithZero {
            get {return Main.GetGetBoolPropertyByName(this, "bDoNotImportCurveWithZero"); }
            set {Main.SetGetBoolPropertyByName(this, "bDoNotImportCurveWithZero", value); }
        }
        public bool bPreserveLocalTransform {
            get {return Main.GetGetBoolPropertyByName(this, "bPreserveLocalTransform"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreserveLocalTransform", value); }
        }
        static FbxAnimSequenceImportData() {
            StaticClass = Main.GetClass("FbxAnimSequenceImportData");
        }
        internal unsafe FbxAnimSequenceImportData_fields* FbxAnimSequenceImportData_ptr => (FbxAnimSequenceImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxAnimSequenceImportData(IntPtr p) => UObject.Make<FbxAnimSequenceImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxAnimSequenceImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxAnimSequenceImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
