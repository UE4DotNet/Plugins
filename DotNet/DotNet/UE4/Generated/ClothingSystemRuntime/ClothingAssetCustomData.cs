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
using UE4.ClothingSystemRuntime.Native;

namespace UE4.ClothingSystemRuntime {
    ///<summary>
    ///Custom data wrapper for clothing assets
    ///If writing a new clothing asset importer, creating a new derived custom data is how to store importer (and possibly simulation)
    ///data that importer will create.
    ///</summary>
    ///<remarks>
    ///This needs to be set to the CustomData member on the asset your factory creates.
    ///Testing whether a UClothingAsset was made from a custom plugin can be achieved with
    ///if(AssetPtr->CustomData->IsA(UMyCustomData::StaticClass()))
    ///</remarks>
    public unsafe partial class ClothingAssetCustomData : UObject  {
        static ClothingAssetCustomData() {
            StaticClass = Main.GetClass("ClothingAssetCustomData");
        }
        internal unsafe ClothingAssetCustomData_fields* ClothingAssetCustomData_ptr => (ClothingAssetCustomData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClothingAssetCustomData(IntPtr p) => UObject.Make<ClothingAssetCustomData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClothingAssetCustomData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClothingAssetCustomData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
