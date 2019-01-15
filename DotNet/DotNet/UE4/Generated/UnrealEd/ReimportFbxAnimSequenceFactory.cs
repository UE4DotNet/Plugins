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
    ///<summary>Reimport Fbx Anim Sequence Factory</summary>
    public unsafe partial class ReimportFbxAnimSequenceFactory : FbxFactory  {
        static ReimportFbxAnimSequenceFactory() {
            StaticClass = Main.GetClass("ReimportFbxAnimSequenceFactory");
        }
        internal unsafe ReimportFbxAnimSequenceFactory_fields* ReimportFbxAnimSequenceFactory_ptr => (ReimportFbxAnimSequenceFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ReimportFbxAnimSequenceFactory(IntPtr p) => UObject.Make<ReimportFbxAnimSequenceFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ReimportFbxAnimSequenceFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ReimportFbxAnimSequenceFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
