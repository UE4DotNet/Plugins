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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>AIAsync Task Blueprint Proxy</summary>
    public unsafe partial class AIAsyncTaskBlueprintProxy : UObject  {
         //TODO: multicast delegate FOAISimpleDelegate OnSuccess
         //TODO: multicast delegate FOAISimpleDelegate OnFail
        static AIAsyncTaskBlueprintProxy() {
            StaticClass = Main.GetClass("AIAsyncTaskBlueprintProxy");
        }
        internal unsafe AIAsyncTaskBlueprintProxy_fields* AIAsyncTaskBlueprintProxy_ptr => (AIAsyncTaskBlueprintProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIAsyncTaskBlueprintProxy(IntPtr p) => UObject.Make<AIAsyncTaskBlueprintProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIAsyncTaskBlueprintProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIAsyncTaskBlueprintProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
