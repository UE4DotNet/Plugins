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
    ///<summary>Fbx Static Mesh Import Data</summary>
    public unsafe partial class FbxStaticMeshImportData : FbxMeshImportData  {
        ///<summary>The LODGroup to associate with this mesh when it is imported</summary>
        public unsafe Name StaticMeshLODGroup {
            get {return FbxStaticMeshImportData_ptr->StaticMeshLODGroup;}
            set {FbxStaticMeshImportData_ptr->StaticMeshLODGroup = value;}
        }
        ///<summary>Specify how vertex colors should be imported</summary>
        public unsafe byte VertexColorImportOption {
            get {return FbxStaticMeshImportData_ptr->VertexColorImportOption;}
            set {FbxStaticMeshImportData_ptr->VertexColorImportOption = value;}
        }
        ///<summary>Specify override color in the case that VertexColorImportOption is set to Override</summary>
        public unsafe Color VertexOverrideColor {
            get {return FbxStaticMeshImportData_ptr->VertexOverrideColor;}
            set {FbxStaticMeshImportData_ptr->VertexOverrideColor = value;}
        }
        public bool bRemoveDegenerates {
            get {return Main.GetGetBoolPropertyByName(this, "bRemoveDegenerates"); }
            set {Main.SetGetBoolPropertyByName(this, "bRemoveDegenerates", value); }
        }
        public bool bBuildAdjacencyBuffer {
            get {return Main.GetGetBoolPropertyByName(this, "bBuildAdjacencyBuffer"); }
            set {Main.SetGetBoolPropertyByName(this, "bBuildAdjacencyBuffer", value); }
        }
        public bool bBuildReversedIndexBuffer {
            get {return Main.GetGetBoolPropertyByName(this, "bBuildReversedIndexBuffer"); }
            set {Main.SetGetBoolPropertyByName(this, "bBuildReversedIndexBuffer", value); }
        }
        public bool bGenerateLightmapUVs {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateLightmapUVs"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateLightmapUVs", value); }
        }
        public bool bOneConvexHullPerUCX {
            get {return Main.GetGetBoolPropertyByName(this, "bOneConvexHullPerUCX"); }
            set {Main.SetGetBoolPropertyByName(this, "bOneConvexHullPerUCX", value); }
        }
        public bool bAutoGenerateCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoGenerateCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoGenerateCollision", value); }
        }
        public bool bCombineMeshes {
            get {return Main.GetGetBoolPropertyByName(this, "bCombineMeshes"); }
            set {Main.SetGetBoolPropertyByName(this, "bCombineMeshes", value); }
        }
        static FbxStaticMeshImportData() {
            StaticClass = Main.GetClass("FbxStaticMeshImportData");
        }
        internal unsafe FbxStaticMeshImportData_fields* FbxStaticMeshImportData_ptr => (FbxStaticMeshImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxStaticMeshImportData(IntPtr p) => UObject.Make<FbxStaticMeshImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxStaticMeshImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxStaticMeshImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
