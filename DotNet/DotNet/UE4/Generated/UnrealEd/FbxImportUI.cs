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
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Fbx Import UI</summary>
    public unsafe partial class FbxImportUI : UObject  {

        ///<summary>Reset to Default</summary>
        public void ResetToDefault()  => 
            FbxImportUI_methods.ResetToDefault_method.Invoke(ObjPointer);
        public bool bIsObjImport {
            get {return Main.GetGetBoolPropertyByName(this, "bIsObjImport"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsObjImport", value); }
        }
        ///<summary>The original detected type of this import</summary>
        public unsafe byte OriginalImportType {
            get {return FbxImportUI_ptr->OriginalImportType;}
            set {FbxImportUI_ptr->OriginalImportType = value;}
        }
        ///<summary>Type of asset to import from the FBX file</summary>
        public unsafe byte MeshTypeToImport {
            get {return FbxImportUI_ptr->MeshTypeToImport;}
            set {FbxImportUI_ptr->MeshTypeToImport = value;}
        }
        public bool bOverrideFullName {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideFullName"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideFullName", value); }
        }
        public bool bImportAsSkeletal {
            get {return Main.GetGetBoolPropertyByName(this, "bImportAsSkeletal"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportAsSkeletal", value); }
        }
        public bool bImportMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bImportMesh"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportMesh", value); }
        }
        ///<summary>Skeleton to use for imported asset. When importing a mesh, leaving this as "None" will create a new skeleton. When importing an animation this MUST be specified to import the asset.</summary>
        public unsafe Skeleton Skeleton {
            get {return FbxImportUI_ptr->Skeleton;}
            set {FbxImportUI_ptr->Skeleton = value;}
        }
        public bool bCreatePhysicsAsset {
            get {return Main.GetGetBoolPropertyByName(this, "bCreatePhysicsAsset"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreatePhysicsAsset", value); }
        }
        ///<summary>If this is set, use this PhysicsAsset. It is possible bCreatePhysicsAsset == false, and PhysicsAsset == NULL. It is possible they do not like to create anything.</summary>
        public unsafe PhysicsAsset PhysicsAsset {
            get {return FbxImportUI_ptr->PhysicsAsset;}
            set {FbxImportUI_ptr->PhysicsAsset = value;}
        }
        public bool bAutoComputeLodDistances {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoComputeLodDistances"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoComputeLodDistances", value); }
        }
        ///<summary>Specify the LOD distance for LOD 0</summary>
        public unsafe float LodDistance0 {
            get {return FbxImportUI_ptr->LodDistance0;}
            set {FbxImportUI_ptr->LodDistance0 = value;}
        }
        ///<summary>Specify the LOD distance for LOD 1</summary>
        public unsafe float LodDistance1 {
            get {return FbxImportUI_ptr->LodDistance1;}
            set {FbxImportUI_ptr->LodDistance1 = value;}
        }
        ///<summary>Specify the LOD distance for LOD 2</summary>
        public unsafe float LodDistance2 {
            get {return FbxImportUI_ptr->LodDistance2;}
            set {FbxImportUI_ptr->LodDistance2 = value;}
        }
        ///<summary>Specify the LOD distance for LOD 3</summary>
        public unsafe float LodDistance3 {
            get {return FbxImportUI_ptr->LodDistance3;}
            set {FbxImportUI_ptr->LodDistance3 = value;}
        }
        ///<summary>Specify the LOD distance for LOD 4</summary>
        public unsafe float LodDistance4 {
            get {return FbxImportUI_ptr->LodDistance4;}
            set {FbxImportUI_ptr->LodDistance4 = value;}
        }
        ///<summary>Specify the LOD distance for LOD 5</summary>
        public unsafe float LodDistance5 {
            get {return FbxImportUI_ptr->LodDistance5;}
            set {FbxImportUI_ptr->LodDistance5 = value;}
        }
        ///<summary>Specify the LOD distance for LOD 6</summary>
        public unsafe float LodDistance6 {
            get {return FbxImportUI_ptr->LodDistance6;}
            set {FbxImportUI_ptr->LodDistance6 = value;}
        }
        ///<summary>Specify the LOD distance for LOD 7</summary>
        public unsafe float LodDistance7 {
            get {return FbxImportUI_ptr->LodDistance7;}
            set {FbxImportUI_ptr->LodDistance7 = value;}
        }
        ///<summary>Set the minimum LOD number. A value of 0 disable the option.</summary>
        public unsafe int MinimumLodNumber {
            get {return FbxImportUI_ptr->MinimumLodNumber;}
            set {FbxImportUI_ptr->MinimumLodNumber = value;}
        }
        ///<summary>Set the number of LODs. A value of 0 disable the option.</summary>
        public unsafe int LodNumber {
            get {return FbxImportUI_ptr->LodNumber;}
            set {FbxImportUI_ptr->LodNumber = value;}
        }
        public bool bImportAnimations {
            get {return Main.GetGetBoolPropertyByName(this, "bImportAnimations"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportAnimations", value); }
        }
         //TODO: string FString OverrideAnimationName
        public bool bImportRigidMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bImportRigidMesh"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportRigidMesh", value); }
        }
        public bool bImportMaterials {
            get {return Main.GetGetBoolPropertyByName(this, "bImportMaterials"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportMaterials", value); }
        }
        public bool bImportTextures {
            get {return Main.GetGetBoolPropertyByName(this, "bImportTextures"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportTextures", value); }
        }
        ///<summary>Import data used when importing static meshes</summary>
        public unsafe FbxStaticMeshImportData StaticMeshImportData {
            get {return FbxImportUI_ptr->StaticMeshImportData;}
            set {FbxImportUI_ptr->StaticMeshImportData = value;}
        }
        ///<summary>Import data used when importing skeletal meshes</summary>
        public unsafe FbxSkeletalMeshImportData SkeletalMeshImportData {
            get {return FbxImportUI_ptr->SkeletalMeshImportData;}
            set {FbxImportUI_ptr->SkeletalMeshImportData = value;}
        }
        ///<summary>Import data used when importing animations</summary>
        public unsafe FbxAnimSequenceImportData AnimSequenceImportData {
            get {return FbxImportUI_ptr->AnimSequenceImportData;}
            set {FbxImportUI_ptr->AnimSequenceImportData = value;}
        }
        ///<summary>Import data used when importing textures</summary>
        public unsafe FbxTextureImportData TextureImportData {
            get {return FbxImportUI_ptr->TextureImportData;}
            set {FbxImportUI_ptr->TextureImportData = value;}
        }
        public bool bAutomatedImportShouldDetectType {
            get {return Main.GetGetBoolPropertyByName(this, "bAutomatedImportShouldDetectType"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutomatedImportShouldDetectType", value); }
        }
         //TODO: string FString FileVersion
         //TODO: string FString FileCreator
         //TODO: string FString FileCreatorApplication
         //TODO: string FString FileUnits
         //TODO: string FString FileAxisDirection
         //TODO: string FString FileSampleRate
         //TODO: string FString AnimStartFrame
         //TODO: string FString AnimEndFrame
        static FbxImportUI() {
            StaticClass = Main.GetClass("FbxImportUI");
        }
        internal unsafe FbxImportUI_fields* FbxImportUI_ptr => (FbxImportUI_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxImportUI(IntPtr p) => UObject.Make<FbxImportUI>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxImportUI DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxImportUI New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
