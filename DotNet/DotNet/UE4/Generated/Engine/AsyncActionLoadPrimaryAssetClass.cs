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
    ///<summary>Async Action Load Primary Asset Class</summary>
    public unsafe partial class AsyncActionLoadPrimaryAssetClass : AsyncActionLoadPrimaryAssetBase  {

        ///<summary>Load a primary asset class into memory.</summary>
        ///<remarks>
        ///The completed delegate will go off when the load succeeds or fails, you should cast the Loaded class to verify it is the correct type
        ///If LoadBundles is specified, those bundles are loaded along with the asset
        ///</remarks>
        public static AsyncActionLoadPrimaryAssetClass AsyncLoadPrimaryAssetClass(UObject WorldContextObject, PrimaryAssetId PrimaryAsset, byte LoadBundles /*TODO: array TArray */)  => 
            AsyncActionLoadPrimaryAssetClass_methods.AsyncLoadPrimaryAssetClass_method.Invoke(WorldContextObject, PrimaryAsset, LoadBundles);
         //TODO: multicast delegate FOnPrimaryAssetClassLoaded Completed
        static AsyncActionLoadPrimaryAssetClass() {
            StaticClass = Main.GetClass("AsyncActionLoadPrimaryAssetClass");
        }
        internal unsafe AsyncActionLoadPrimaryAssetClass_fields* AsyncActionLoadPrimaryAssetClass_ptr => (AsyncActionLoadPrimaryAssetClass_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AsyncActionLoadPrimaryAssetClass(IntPtr p) => UObject.Make<AsyncActionLoadPrimaryAssetClass>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AsyncActionLoadPrimaryAssetClass DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AsyncActionLoadPrimaryAssetClass New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
