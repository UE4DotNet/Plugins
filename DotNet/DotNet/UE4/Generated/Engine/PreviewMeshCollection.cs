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
    ///<summary>A simple collection of skeletal meshes used for in-editor preview</summary>
    public unsafe partial class PreviewMeshCollection : DataAsset  {
        ///<summary>Skeleton</summary>
        public unsafe Skeleton Skeleton {
            get {return PreviewMeshCollection_ptr->Skeleton;}
            set {PreviewMeshCollection_ptr->Skeleton = value;}
        }
         //TODO: array not UObject TArray SkeletalMeshes
        static PreviewMeshCollection() {
            StaticClass = Main.GetClass("PreviewMeshCollection");
        }
        internal unsafe PreviewMeshCollection_fields* PreviewMeshCollection_ptr => (PreviewMeshCollection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PreviewMeshCollection(IntPtr p) => UObject.Make<PreviewMeshCollection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PreviewMeshCollection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PreviewMeshCollection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
