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

namespace UE4.Engine {
    ///<summary>Async Action Change Primary Asset Bundles</summary>
    public unsafe partial class AsyncActionChangePrimaryAssetBundles : AsyncActionLoadPrimaryAssetBase  {

        ///<summary>Change the bundle state of all assets that match OldBundles to instead contain NewBundles.</summary>
        public static AsyncActionChangePrimaryAssetBundles AsyncChangeBundleStateForMatchingPrimaryAssets(UObject WorldContextObject, byte NewBundles /*TODO: array TArray */, byte OldBundles /*TODO: array TArray */)  => 
            AsyncActionChangePrimaryAssetBundles_methods.AsyncChangeBundleStateForMatchingPrimaryAssets_method.Invoke(WorldContextObject, NewBundles, OldBundles);

        ///<summary>Change the bundle state of assets in PrimaryAssetList. AddBundles are added and RemoveBundles are removed, both must be filled in but an empty array is allowed</summary>
        public static AsyncActionChangePrimaryAssetBundles AsyncChangeBundleStateForPrimaryAssetList(UObject WorldContextObject, byte PrimaryAssetList /*TODO: array TArray */, byte AddBundles /*TODO: array TArray */, byte RemoveBundles /*TODO: array TArray */)  => 
            AsyncActionChangePrimaryAssetBundles_methods.AsyncChangeBundleStateForPrimaryAssetList_method.Invoke(WorldContextObject, PrimaryAssetList, AddBundles, RemoveBundles);
         //TODO: multicast delegate FOnPrimaryAssetBundlesChanged Completed
        static AsyncActionChangePrimaryAssetBundles() {
            StaticClass = Main.GetClass("AsyncActionChangePrimaryAssetBundles");
        }
        internal unsafe AsyncActionChangePrimaryAssetBundles_fields* AsyncActionChangePrimaryAssetBundles_ptr => (AsyncActionChangePrimaryAssetBundles_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AsyncActionChangePrimaryAssetBundles(IntPtr p) => UObject.Make<AsyncActionChangePrimaryAssetBundles>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AsyncActionChangePrimaryAssetBundles DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AsyncActionChangePrimaryAssetBundles New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
