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
using UE4.ClothingSystemRuntimeInterface;
using UE4.Engine;

namespace UE4.ClothingSystemRuntime {
    ///<summary>Clothing Asset</summary>
    public unsafe partial class ClothingAsset : ClothingAssetBase  {
        ///<summary>The physics asset to extract collisions from when building a simulation</summary>
        public unsafe PhysicsAsset PhysicsAsset {
            get {return ClothingAsset_ptr->PhysicsAsset;}
            set {ClothingAsset_ptr->PhysicsAsset = value;}
        }
        ///<summary>Configuration of the cloth, contains all the parameters for how the clothing behaves</summary>
        public unsafe ClothConfig ClothConfig {
            get {return ClothingAsset_ptr->ClothConfig;}
            set {ClothingAsset_ptr->ClothConfig = value;}
        }
         //TODO: array not UObject TArray LodData
         //TODO: array not UObject TArray LodMap
         //TODO: array not UObject TArray UsedBoneNames
         //TODO: array not UObject TArray UsedBoneIndices
        ///<summary>Bone to treat as the root of the simulation space</summary>
        public unsafe int ReferenceBoneIndex {
            get {return ClothingAsset_ptr->ReferenceBoneIndex;}
            set {ClothingAsset_ptr->ReferenceBoneIndex = value;}
        }
        ///<summary>Custom data applied by the importer depending on where the asset was imported from</summary>
        public unsafe ClothingAssetCustomData CustomData {
            get {return ClothingAsset_ptr->CustomData;}
            set {ClothingAsset_ptr->CustomData = value;}
        }
        static ClothingAsset() {
            StaticClass = Main.GetClass("ClothingAsset");
        }
        internal unsafe ClothingAsset_fields* ClothingAsset_ptr => (ClothingAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClothingAsset(IntPtr p) => UObject.Make<ClothingAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClothingAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClothingAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
