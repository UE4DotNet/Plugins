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
using UE4.ClothingSystemRuntimeInterface.Native;

namespace UE4.ClothingSystemRuntimeInterface {
    ///<summary>An interface object for any clothing asset the engine can use.</summary>
    ///<remarks>
    ///Any
    ///clothing asset concrete object should derive from this.
    ///</remarks>
    public unsafe partial class ClothingAssetBase : UObject  {
         //TODO: string FString ImportedFilePath
        ///<summary>Guid to identify this asset. Will be embedded into chunks that are created using this asset</summary>
        public unsafe FGuid AssetGuid {
            get {return ClothingAssetBase_ptr->AssetGuid;}
            set {ClothingAssetBase_ptr->AssetGuid = value;}
        }
        static ClothingAssetBase() {
            StaticClass = Main.GetClass("ClothingAssetBase");
        }
        internal unsafe ClothingAssetBase_fields* ClothingAssetBase_ptr => (ClothingAssetBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClothingAssetBase(IntPtr p) => UObject.Make<ClothingAssetBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClothingAssetBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClothingAssetBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
