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
    ///<summary>Factory for creating SlateBrushAssets</summary>
    public unsafe partial class SlateBrushAssetFactory : Factory  {
        ///<summary>An initial texture to assign to the newly created slate brush</summary>
        public unsafe Texture2D InitialTexture {
            get {return SlateBrushAssetFactory_ptr->InitialTexture;}
            set {SlateBrushAssetFactory_ptr->InitialTexture = value;}
        }
        static SlateBrushAssetFactory() {
            StaticClass = Main.GetClass("SlateBrushAssetFactory");
        }
        internal unsafe SlateBrushAssetFactory_fields* SlateBrushAssetFactory_ptr => (SlateBrushAssetFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SlateBrushAssetFactory(IntPtr p) => UObject.Make<SlateBrushAssetFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SlateBrushAssetFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SlateBrushAssetFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
