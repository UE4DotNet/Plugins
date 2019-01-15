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
    ///<summary>Fbx_AddToBlueprint UMETA(DisplayName = "Add to an existing Blueprint asset"),</summary>
    public unsafe partial class FbxSceneImportOptions : UObject  {
        public bool bCreateContentFolderHierarchy {
            get {return Main.GetGetBoolPropertyByName(this, "bCreateContentFolderHierarchy"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreateContentFolderHierarchy", value); }
        }
        public bool bImportAsDynamic {
            get {return Main.GetGetBoolPropertyByName(this, "bImportAsDynamic"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportAsDynamic", value); }
        }
        ///<summary>Choose if you want to generate the scene hierarchy with normal level actors, one actor with multiple components, or one blueprint asset with multiple components.</summary>
        public unsafe byte HierarchyType {
            get {return FbxSceneImportOptions_ptr->HierarchyType;}
            set {FbxSceneImportOptions_ptr->HierarchyType = value;}
        }
        public bool bForceFrontXAxis {
            get {return Main.GetGetBoolPropertyByName(this, "bForceFrontXAxis"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceFrontXAxis", value); }
        }
        ///<summary>Import Translation</summary>
        public unsafe Vector ImportTranslation {
            get {return FbxSceneImportOptions_ptr->ImportTranslation;}
            set {FbxSceneImportOptions_ptr->ImportTranslation = value;}
        }
        ///<summary>Import Rotation</summary>
        public unsafe Rotator ImportRotation {
            get {return FbxSceneImportOptions_ptr->ImportRotation;}
            set {FbxSceneImportOptions_ptr->ImportRotation = value;}
        }
        ///<summary>Import Uniform Scale</summary>
        public unsafe float ImportUniformScale {
            get {return FbxSceneImportOptions_ptr->ImportUniformScale;}
            set {FbxSceneImportOptions_ptr->ImportUniformScale = value;}
        }
        public bool bTransformVertexToAbsolute {
            get {return Main.GetGetBoolPropertyByName(this, "bTransformVertexToAbsolute"); }
            set {Main.SetGetBoolPropertyByName(this, "bTransformVertexToAbsolute", value); }
        }
        public bool bBakePivotInVertex {
            get {return Main.GetGetBoolPropertyByName(this, "bBakePivotInVertex"); }
            set {Main.SetGetBoolPropertyByName(this, "bBakePivotInVertex", value); }
        }
        public bool bImportStaticMeshLODs {
            get {return Main.GetGetBoolPropertyByName(this, "bImportStaticMeshLODs"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportStaticMeshLODs", value); }
        }
        public bool bImportSkeletalMeshLODs {
            get {return Main.GetGetBoolPropertyByName(this, "bImportSkeletalMeshLODs"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportSkeletalMeshLODs", value); }
        }
        public bool bInvertNormalMaps {
            get {return Main.GetGetBoolPropertyByName(this, "bInvertNormalMaps"); }
            set {Main.SetGetBoolPropertyByName(this, "bInvertNormalMaps", value); }
        }
        static FbxSceneImportOptions() {
            StaticClass = Main.GetClass("FbxSceneImportOptions");
        }
        internal unsafe FbxSceneImportOptions_fields* FbxSceneImportOptions_ptr => (FbxSceneImportOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxSceneImportOptions(IntPtr p) => UObject.Make<FbxSceneImportOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxSceneImportOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxSceneImportOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
