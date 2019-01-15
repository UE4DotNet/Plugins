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
using UE4.ClothingSystemEditorInterface.Native;

namespace UE4.ClothingSystemEditorInterface {
    ///<summary>
    ///Clothing asset factories should inherit this interface/uobject to provide functionality
    ///to build clothing assets from .
    ///</summary>
    ///<remarks>apx files imported to the engine</remarks>
    public unsafe partial class ClothingAssetFactoryBase : UObject  {
        static ClothingAssetFactoryBase() {
            StaticClass = Main.GetClass("ClothingAssetFactoryBase");
        }
        internal unsafe ClothingAssetFactoryBase_fields* ClothingAssetFactoryBase_ptr => (ClothingAssetFactoryBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClothingAssetFactoryBase(IntPtr p) => UObject.Make<ClothingAssetFactoryBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClothingAssetFactoryBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClothingAssetFactoryBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
