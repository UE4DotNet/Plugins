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
using UE4.Engine;

namespace UE4.BlueprintGraph {
    ///<summary>K2Node Call Function</summary>
    public unsafe partial class K2Node_CallFunction : K2Node  {
        public bool bIsPureFunc {
            get {return Main.GetGetBoolPropertyByName(this, "bIsPureFunc"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsPureFunc", value); }
        }
        public bool bIsConstFunc {
            get {return Main.GetGetBoolPropertyByName(this, "bIsConstFunc"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsConstFunc", value); }
        }
        public bool bWantsEnumToExecExpansion {
            get {return Main.GetGetBoolPropertyByName(this, "bWantsEnumToExecExpansion"); }
            set {Main.SetGetBoolPropertyByName(this, "bWantsEnumToExecExpansion", value); }
        }
        public bool bIsInterfaceCall {
            get {return Main.GetGetBoolPropertyByName(this, "bIsInterfaceCall"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsInterfaceCall", value); }
        }
        public bool bIsFinalFunction {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFinalFunction"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsFinalFunction", value); }
        }
        public bool bIsBeadFunction {
            get {return Main.GetGetBoolPropertyByName(this, "bIsBeadFunction"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsBeadFunction", value); }
        }
        ///<summary>The function to call</summary>
        public unsafe MemberReference FunctionReference {
            get {return K2Node_CallFunction_ptr->FunctionReference;}
            set {K2Node_CallFunction_ptr->FunctionReference = value;}
        }
        static K2Node_CallFunction() {
            StaticClass = Main.GetClass("K2Node_CallFunction");
        }
        internal unsafe K2Node_CallFunction_fields* K2Node_CallFunction_ptr => (K2Node_CallFunction_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_CallFunction(IntPtr p) => UObject.Make<K2Node_CallFunction>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_CallFunction DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_CallFunction New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
