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
using UE4.InputCore;

namespace UE4.BlueprintGraph {
    ///<summary>K2Node Get Input Axis Key Value</summary>
    public unsafe partial class K2Node_GetInputAxisKeyValue : K2Node_CallFunction  {
        ///<summary>Input Axis Key</summary>
        public unsafe Key InputAxisKey {
            get {return K2Node_GetInputAxisKeyValue_ptr->InputAxisKey;}
            set {K2Node_GetInputAxisKeyValue_ptr->InputAxisKey = value;}
        }
        public bool bConsumeInput {
            get {return Main.GetGetBoolPropertyByName(this, "bConsumeInput"); }
            set {Main.SetGetBoolPropertyByName(this, "bConsumeInput", value); }
        }
        public bool bExecuteWhenPaused {
            get {return Main.GetGetBoolPropertyByName(this, "bExecuteWhenPaused"); }
            set {Main.SetGetBoolPropertyByName(this, "bExecuteWhenPaused", value); }
        }
        static K2Node_GetInputAxisKeyValue() {
            StaticClass = Main.GetClass("K2Node_GetInputAxisKeyValue");
        }
        internal unsafe K2Node_GetInputAxisKeyValue_fields* K2Node_GetInputAxisKeyValue_ptr => (K2Node_GetInputAxisKeyValue_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_GetInputAxisKeyValue(IntPtr p) => UObject.Make<K2Node_GetInputAxisKeyValue>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_GetInputAxisKeyValue DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_GetInputAxisKeyValue New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
