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
    ///<summary>Blueprint Async Action Base</summary>
    public unsafe partial class BlueprintAsyncActionBase : UObject  {

        ///<summary>Called to trigger the action once the delegates have been bound</summary>
        public void Activate()  => 
            BlueprintAsyncActionBase_methods.Activate_method.Invoke(ObjPointer);
        static BlueprintAsyncActionBase() {
            StaticClass = Main.GetClass("BlueprintAsyncActionBase");
        }
        internal unsafe BlueprintAsyncActionBase_fields* BlueprintAsyncActionBase_ptr => (BlueprintAsyncActionBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintAsyncActionBase(IntPtr p) => UObject.Make<BlueprintAsyncActionBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintAsyncActionBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintAsyncActionBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
