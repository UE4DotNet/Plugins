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
using UE4.Engine.Native;
using UE4.AssetRegistry;

namespace UE4.Engine {
    ///<summary>
    ///A DataAsset that implements GetPrimaryAssetId and has asset bundle support, which makes it something that can be manually loaded/unloaded from the AssetManager
    ///Making blueprint subclasses of this is useful because you can make blueprint-only primary asset types
    ///Blueprint subclasses will end up with a PrimaryAssetType equal to the name of the first native class found going up the hierarchy, or the top level blueprint class that directly subclasses this
    ///IE, if you have PrimaryDataAsset -> ParentNativeClass -> ChildNativeClass -> BlueprintAsset the type will be ChildNativeClass
    ///Whereas if you have PrimaryDataAsset -> ParentBlueprintClass -> ChildBlueprintClass the type will be ParentBlueprintClass
    ///</summary>
    ///<remarks>To override this behavior, override GetPrimaryAssetId in your native class</remarks>
    public unsafe partial class PrimaryDataAsset : DataAsset  {
        ///<summary>Asset Bundle data computed at save time. In cooked builds this is accessible from AssetRegistry</summary>
        public unsafe AssetBundleData AssetBundleData {
            get {return PrimaryDataAsset_ptr->AssetBundleData;}
            set {PrimaryDataAsset_ptr->AssetBundleData = value;}
        }
        static PrimaryDataAsset() {
            StaticClass = Main.GetClass("PrimaryDataAsset");
        }
        internal unsafe PrimaryDataAsset_fields* PrimaryDataAsset_ptr => (PrimaryDataAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PrimaryDataAsset(IntPtr p) => UObject.Make<PrimaryDataAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PrimaryDataAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PrimaryDataAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
