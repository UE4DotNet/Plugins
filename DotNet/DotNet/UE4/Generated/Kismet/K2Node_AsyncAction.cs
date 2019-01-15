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
using UE4.Kismet.Native;
using UE4.BlueprintGraph;

namespace UE4.Kismet {
    ///<summary>!!! The proxy object should have RF_StrongRefOnFrame flag. !!!</summary>
    public unsafe partial class K2Node_AsyncAction : K2Node_BaseAsyncTask  {
        static K2Node_AsyncAction() {
            StaticClass = Main.GetClass("K2Node_AsyncAction");
        }
        internal unsafe K2Node_AsyncAction_fields* K2Node_AsyncAction_ptr => (K2Node_AsyncAction_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_AsyncAction(IntPtr p) => UObject.Make<K2Node_AsyncAction>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_AsyncAction DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_AsyncAction New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
