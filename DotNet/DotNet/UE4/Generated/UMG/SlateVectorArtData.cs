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
using UE4.UMG.Native;
using UE4.Engine;

namespace UE4.UMG {
    ///<summary>Turn static mesh data into Slate's simple vector art format.</summary>
    public unsafe partial class SlateVectorArtData : UObject  {
        ///<summary>The mesh data asset from which the vector art is sourced</summary>
        public unsafe StaticMesh MeshAsset {
            get {return SlateVectorArtData_ptr->MeshAsset;}
            set {SlateVectorArtData_ptr->MeshAsset = value;}
        }
        ///<summary>The material which we are using, or the material from with the MIC was constructed.</summary>
        public unsafe MaterialInterface SourceMaterial {
            get {return SlateVectorArtData_ptr->SourceMaterial;}
            set {SlateVectorArtData_ptr->SourceMaterial = value;}
        }
         //TODO: array not UObject TArray VertexData
         //TODO: array not UObject TArray IndexData
        ///<summary>@see GetMaterial()</summary>
        public unsafe MaterialInterface Material {
            get {return SlateVectorArtData_ptr->Material;}
            set {SlateVectorArtData_ptr->Material = value;}
        }
        ///<summary>Extent Min</summary>
        public unsafe Vector2D ExtentMin {
            get {return SlateVectorArtData_ptr->ExtentMin;}
            set {SlateVectorArtData_ptr->ExtentMin = value;}
        }
        ///<summary>Extent Max</summary>
        public unsafe Vector2D ExtentMax {
            get {return SlateVectorArtData_ptr->ExtentMax;}
            set {SlateVectorArtData_ptr->ExtentMax = value;}
        }
        static SlateVectorArtData() {
            StaticClass = Main.GetClass("SlateVectorArtData");
        }
        internal unsafe SlateVectorArtData_fields* SlateVectorArtData_ptr => (SlateVectorArtData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SlateVectorArtData(IntPtr p) => UObject.Make<SlateVectorArtData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SlateVectorArtData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SlateVectorArtData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
