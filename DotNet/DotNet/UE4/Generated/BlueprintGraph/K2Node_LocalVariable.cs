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
    ///<summary>K2Node Local Variable</summary>
    public unsafe partial class K2Node_LocalVariable : K2Node_TemporaryVariable  {
        ///<summary>If this is not an override, allow user to specify a name for the function created by this entry point</summary>
        public unsafe Name CustomVariableName {
            get {return K2Node_LocalVariable_ptr->CustomVariableName;}
            set {K2Node_LocalVariable_ptr->CustomVariableName = value;}
        }
         //TODO: text FText VariableTooltip
        static K2Node_LocalVariable() {
            StaticClass = Main.GetClass("K2Node_LocalVariable");
        }
        internal unsafe K2Node_LocalVariable_fields* K2Node_LocalVariable_ptr => (K2Node_LocalVariable_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_LocalVariable(IntPtr p) => UObject.Make<K2Node_LocalVariable>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_LocalVariable DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_LocalVariable New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
