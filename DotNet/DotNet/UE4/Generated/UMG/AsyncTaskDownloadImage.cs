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
using UE4.UMG.Native;
using UE4.Engine;

namespace UE4.UMG {
    ///<summary>Async Task Download Image</summary>
    public unsafe partial class AsyncTaskDownloadImage : BlueprintAsyncActionBase  {

        ///<summary>Download Image</summary>
        public static AsyncTaskDownloadImage DownloadImage(string URL)  => 
            AsyncTaskDownloadImage_methods.DownloadImage_method.Invoke(URL);
         //TODO: multicast delegate FDownloadImageDelegate OnSuccess
         //TODO: multicast delegate FDownloadImageDelegate OnFail
        static AsyncTaskDownloadImage() {
            StaticClass = Main.GetClass("AsyncTaskDownloadImage");
        }
        internal unsafe AsyncTaskDownloadImage_fields* AsyncTaskDownloadImage_ptr => (AsyncTaskDownloadImage_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AsyncTaskDownloadImage(IntPtr p) => UObject.Make<AsyncTaskDownloadImage>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AsyncTaskDownloadImage DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AsyncTaskDownloadImage New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
