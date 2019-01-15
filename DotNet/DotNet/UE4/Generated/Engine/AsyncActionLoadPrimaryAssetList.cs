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
    ///<summary>Async Action Load Primary Asset List</summary>
    public unsafe partial class AsyncActionLoadPrimaryAssetList : AsyncActionLoadPrimaryAssetBase  {

        ///<summary>Load a list primary assets into memory.</summary>
        ///<remarks>
        ///The completed delegate will go off when the load succeeds or fails, you should cast the Loaded object list to verify it is the correct type
        ///If LoadBundles is specified, those bundles are loaded along with the asset list
        ///</remarks>
        public static AsyncActionLoadPrimaryAssetList AsyncLoadPrimaryAssetList(UObject WorldContextObject, byte PrimaryAssetList /*TODO: array TArray */, byte LoadBundles /*TODO: array TArray */)  => 
            AsyncActionLoadPrimaryAssetList_methods.AsyncLoadPrimaryAssetList_method.Invoke(WorldContextObject, PrimaryAssetList, LoadBundles);
         //TODO: multicast delegate FOnPrimaryAssetListLoaded Completed
        static AsyncActionLoadPrimaryAssetList() {
            StaticClass = Main.GetClass("AsyncActionLoadPrimaryAssetList");
        }
        internal unsafe AsyncActionLoadPrimaryAssetList_fields* AsyncActionLoadPrimaryAssetList_ptr => (AsyncActionLoadPrimaryAssetList_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AsyncActionLoadPrimaryAssetList(IntPtr p) => UObject.Make<AsyncActionLoadPrimaryAssetList>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AsyncActionLoadPrimaryAssetList DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AsyncActionLoadPrimaryAssetList New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
