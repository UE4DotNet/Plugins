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
    ///<summary>Fbx Factory</summary>
    public unsafe partial class FbxFactory : Factory  {
        ///<summary>Import UI</summary>
        public unsafe FbxImportUI ImportUI {
            get {return FbxFactory_ptr->ImportUI;}
            set {FbxFactory_ptr->ImportUI = value;}
        }
        ///<summary>Prevent garbage collection of original when overriding ImportUI property</summary>
        public unsafe FbxImportUI OriginalImportUI {
            get {return FbxFactory_ptr->OriginalImportUI;}
            set {FbxFactory_ptr->OriginalImportUI = value;}
        }
        static FbxFactory() {
            StaticClass = Main.GetClass("FbxFactory");
        }
        internal unsafe FbxFactory_fields* FbxFactory_ptr => (FbxFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxFactory(IntPtr p) => UObject.Make<FbxFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
