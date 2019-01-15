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
using UE4.ClothingSystemEditor.Native;
using UE4.ClothingSystemEditorInterface;

namespace UE4.ClothingSystemEditor {
    ///<summary>Clothing Asset Factory</summary>
    public unsafe partial class ClothingAssetFactory : ClothingAssetFactoryBase  {
        static ClothingAssetFactory() {
            StaticClass = Main.GetClass("ClothingAssetFactory");
        }
        internal unsafe ClothingAssetFactory_fields* ClothingAssetFactory_ptr => (ClothingAssetFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClothingAssetFactory(IntPtr p) => UObject.Make<ClothingAssetFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClothingAssetFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClothingAssetFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
