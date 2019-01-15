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
    ///<summary>Async Action Load Primary Asset</summary>
    public unsafe partial class AsyncActionLoadPrimaryAsset : AsyncActionLoadPrimaryAssetBase  {

        ///<summary>Load a primary asset into memory.</summary>
        ///<remarks>
        ///The completed delegate will go off when the load succeeds or fails, you should cast the Loaded object to verify it is the correct type.
        ///If LoadBundles is specified, those bundles are loaded along with the asset
        ///</remarks>
        public static AsyncActionLoadPrimaryAsset AsyncLoadPrimaryAsset(UObject WorldContextObject, PrimaryAssetId PrimaryAsset, byte LoadBundles /*TODO: array TArray */)  => 
            AsyncActionLoadPrimaryAsset_methods.AsyncLoadPrimaryAsset_method.Invoke(WorldContextObject, PrimaryAsset, LoadBundles);
         //TODO: multicast delegate FOnPrimaryAssetLoaded Completed
        static AsyncActionLoadPrimaryAsset() {
            StaticClass = Main.GetClass("AsyncActionLoadPrimaryAsset");
        }
        internal unsafe AsyncActionLoadPrimaryAsset_fields* AsyncActionLoadPrimaryAsset_ptr => (AsyncActionLoadPrimaryAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AsyncActionLoadPrimaryAsset(IntPtr p) => UObject.Make<AsyncActionLoadPrimaryAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AsyncActionLoadPrimaryAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AsyncActionLoadPrimaryAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
