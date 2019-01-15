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
    ///<summary>Online Blueprint Call Proxy Base</summary>
    public unsafe partial class OnlineBlueprintCallProxyBase : UObject  {

        ///<summary>Called to trigger the actual online action once the delegates have been bound</summary>
        public void Activate()  => 
            OnlineBlueprintCallProxyBase_methods.Activate_method.Invoke(ObjPointer);
        static OnlineBlueprintCallProxyBase() {
            StaticClass = Main.GetClass("OnlineBlueprintCallProxyBase");
        }
        internal unsafe OnlineBlueprintCallProxyBase_fields* OnlineBlueprintCallProxyBase_ptr => (OnlineBlueprintCallProxyBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OnlineBlueprintCallProxyBase(IntPtr p) => UObject.Make<OnlineBlueprintCallProxyBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OnlineBlueprintCallProxyBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OnlineBlueprintCallProxyBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
