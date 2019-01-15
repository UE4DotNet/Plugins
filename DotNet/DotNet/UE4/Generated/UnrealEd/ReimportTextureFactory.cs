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
    ///<summary>Reimport Texture Factory</summary>
    public unsafe partial class ReimportTextureFactory : TextureFactory  {
        ///<summary>P Original Tex</summary>
        public unsafe Texture pOriginalTex {
            get {return ReimportTextureFactory_ptr->pOriginalTex;}
            set {ReimportTextureFactory_ptr->pOriginalTex = value;}
        }
        static ReimportTextureFactory() {
            StaticClass = Main.GetClass("ReimportTextureFactory");
        }
        internal unsafe ReimportTextureFactory_fields* ReimportTextureFactory_ptr => (ReimportTextureFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ReimportTextureFactory(IntPtr p) => UObject.Make<ReimportTextureFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ReimportTextureFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ReimportTextureFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
