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
using UE4.BlueprintGraph.Native;

namespace UE4.BlueprintGraph {
    ///<summary>!!! The proxy object should have RF_StrongRefOnFrame flag. !!!</summary>
    public unsafe partial class K2Node_BaseAsyncTask : K2Node  {
        ///<summary>The name of the function to call to create a proxy object</summary>
        public unsafe Name ProxyFactoryFunctionName {
            get {return K2Node_BaseAsyncTask_ptr->ProxyFactoryFunctionName;}
            set {K2Node_BaseAsyncTask_ptr->ProxyFactoryFunctionName = value;}
        }
        ///<summary>The class containing the proxy object functions</summary>
        public unsafe SubclassOf<UObject> ProxyFactoryClass {
            get {return K2Node_BaseAsyncTask_ptr->ProxyFactoryClass;}
            set {K2Node_BaseAsyncTask_ptr->ProxyFactoryClass = value;}
        }
        ///<summary>The type of proxy object that will be created</summary>
        public unsafe SubclassOf<UObject> ProxyClass {
            get {return K2Node_BaseAsyncTask_ptr->ProxyClass;}
            set {K2Node_BaseAsyncTask_ptr->ProxyClass = value;}
        }
        ///<summary>The name of the 'go' function on the proxy object that will be called after delegates are in place, can be NAME_None</summary>
        public unsafe Name ProxyActivateFunctionName {
            get {return K2Node_BaseAsyncTask_ptr->ProxyActivateFunctionName;}
            set {K2Node_BaseAsyncTask_ptr->ProxyActivateFunctionName = value;}
        }
        static K2Node_BaseAsyncTask() {
            StaticClass = Main.GetClass("K2Node_BaseAsyncTask");
        }
        internal unsafe K2Node_BaseAsyncTask_fields* K2Node_BaseAsyncTask_ptr => (K2Node_BaseAsyncTask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_BaseAsyncTask(IntPtr p) => UObject.Make<K2Node_BaseAsyncTask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_BaseAsyncTask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_BaseAsyncTask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
