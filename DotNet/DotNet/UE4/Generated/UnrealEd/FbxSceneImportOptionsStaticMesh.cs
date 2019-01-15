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
    ///<summary>Fbx Scene Import Options Static Mesh</summary>
    public unsafe partial class FbxSceneImportOptionsStaticMesh : UObject  {
        ///<summary>For static meshes, enabling this option will combine all meshes in the FBX into a single monolithic mesh in Unreal</summary>
        public unsafe Name StaticMeshLODGroup {
            get {return FbxSceneImportOptionsStaticMesh_ptr->StaticMeshLODGroup;}
            set {FbxSceneImportOptionsStaticMesh_ptr->StaticMeshLODGroup = value;}
        }
        public bool bAutoGenerateCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoGenerateCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoGenerateCollision", value); }
        }
        ///<summary>Specify how vertex colors should be imported</summary>
        public unsafe byte VertexColorImportOption {
            get {return FbxSceneImportOptionsStaticMesh_ptr->VertexColorImportOption;}
            set {FbxSceneImportOptionsStaticMesh_ptr->VertexColorImportOption = value;}
        }
        ///<summary>Specify override color in the case that VertexColorImportOption is set to Override</summary>
        public unsafe Color VertexOverrideColor {
            get {return FbxSceneImportOptionsStaticMesh_ptr->VertexOverrideColor;}
            set {FbxSceneImportOptionsStaticMesh_ptr->VertexOverrideColor = value;}
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
        ///<summary>Enabling this option will read the tangents(tangent,binormal,normal) from FBX file instead of generating them automatically.</summary>
        public unsafe byte NormalImportMethod {
            get {return FbxSceneImportOptionsStaticMesh_ptr->NormalImportMethod;}
            set {FbxSceneImportOptionsStaticMesh_ptr->NormalImportMethod = value;}
        }
        ///<summary>Use the MikkTSpace tangent space generator for generating normals and tangents on the mesh</summary>
        public unsafe byte NormalGenerationMethod {
            get {return FbxSceneImportOptionsStaticMesh_ptr->NormalGenerationMethod;}
            set {FbxSceneImportOptionsStaticMesh_ptr->NormalGenerationMethod = value;}
        }
        static FbxSceneImportOptionsStaticMesh() {
            StaticClass = Main.GetClass("FbxSceneImportOptionsStaticMesh");
        }
        internal unsafe FbxSceneImportOptionsStaticMesh_fields* FbxSceneImportOptionsStaticMesh_ptr => (FbxSceneImportOptionsStaticMesh_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxSceneImportOptionsStaticMesh(IntPtr p) => UObject.Make<FbxSceneImportOptionsStaticMesh>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxSceneImportOptionsStaticMesh DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxSceneImportOptionsStaticMesh New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
