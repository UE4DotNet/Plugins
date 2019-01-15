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
using UE4.OnlineBlueprintSupport.Native;
using UE4.BlueprintGraph;

namespace UE4.OnlineBlueprintSupport {
    ///<summary>This node is a latent online subsystem call (handles scanning all UOnlineBlueprintCallProxyBase classes for static factory calls)</summary>
    public unsafe partial class K2Node_LatentOnlineCall : K2Node_BaseAsyncTask  {
        static K2Node_LatentOnlineCall() {
            StaticClass = Main.GetClass("K2Node_LatentOnlineCall");
        }
        internal unsafe K2Node_LatentOnlineCall_fields* K2Node_LatentOnlineCall_ptr => (K2Node_LatentOnlineCall_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_LatentOnlineCall(IntPtr p) => UObject.Make<K2Node_LatentOnlineCall>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_LatentOnlineCall DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_LatentOnlineCall New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
