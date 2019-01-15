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
    ///<summary>K2Node Variable Set Ref</summary>
    public unsafe partial class K2Node_VariableSetRef : K2Node  {
        static K2Node_VariableSetRef() {
            StaticClass = Main.GetClass("K2Node_VariableSetRef");
        }
        internal unsafe K2Node_VariableSetRef_fields* K2Node_VariableSetRef_ptr => (K2Node_VariableSetRef_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_VariableSetRef(IntPtr p) => UObject.Make<K2Node_VariableSetRef>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_VariableSetRef DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_VariableSetRef New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
