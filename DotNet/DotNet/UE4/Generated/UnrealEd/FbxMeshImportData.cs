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
    public unsafe partial class FbxMeshImportData : FbxAssetImportData  {
        public bool bTransformVertexToAbsolute {
            get {return Main.GetGetBoolPropertyByName(this, "bTransformVertexToAbsolute"); }
            set {Main.SetGetBoolPropertyByName(this, "bTransformVertexToAbsolute", value); }
        }
        public bool bBakePivotInVertex {
            get {return Main.GetGetBoolPropertyByName(this, "bBakePivotInVertex"); }
            set {Main.SetGetBoolPropertyByName(this, "bBakePivotInVertex", value); }
        }
        public bool bImportMeshLODs {
            get {return Main.GetGetBoolPropertyByName(this, "bImportMeshLODs"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportMeshLODs", value); }
        }
        ///<summary>Enabling this option will read the tangents(tangent,binormal,normal) from FBX file instead of generating them automatically.</summary>
        public unsafe byte NormalImportMethod {
            get {return FbxMeshImportData_ptr->NormalImportMethod;}
            set {FbxMeshImportData_ptr->NormalImportMethod = value;}
        }
        ///<summary>Use the MikkTSpace tangent space generator for generating normals and tangents on the mesh</summary>
        public unsafe byte NormalGenerationMethod {
            get {return FbxMeshImportData_ptr->NormalGenerationMethod;}
            set {FbxMeshImportData_ptr->NormalGenerationMethod = value;}
        }
         //TODO: array not UObject TArray ImportMaterialOriginalNameData
         //TODO: array not UObject TArray ImportMeshLodData
        static FbxMeshImportData() {
            StaticClass = Main.GetClass("FbxMeshImportData");
        }
        internal unsafe FbxMeshImportData_fields* FbxMeshImportData_ptr => (FbxMeshImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxMeshImportData(IntPtr p) => UObject.Make<FbxMeshImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxMeshImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxMeshImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
