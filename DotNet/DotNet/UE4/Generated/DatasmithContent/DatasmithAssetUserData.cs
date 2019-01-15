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
using UE4.DatasmithContent.Native;
using UE4.Engine;

namespace UE4.DatasmithContent {
    ///<summary>Asset user data that can be used with Datasmith on Actors and other objects</summary>
    public unsafe partial class DatasmithAssetUserData : AssetUserData  {
         //TODO: map TMap MetaData
         //TODO: map TMap ObjectTemplates
        static DatasmithAssetUserData() {
            StaticClass = Main.GetClass("DatasmithAssetUserData");
        }
        internal unsafe DatasmithAssetUserData_fields* DatasmithAssetUserData_ptr => (DatasmithAssetUserData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithAssetUserData(IntPtr p) => UObject.Make<DatasmithAssetUserData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithAssetUserData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithAssetUserData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
