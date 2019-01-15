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
    ///<summary>K2Node Do Once Multi Input</summary>
    public unsafe partial class K2Node_DoOnceMultiInput : K2Node  {
        ///<summary>The number of additional input pins to generate for this node (2 base pins are not included)</summary>
        public unsafe int NumAdditionalInputs {
            get {return K2Node_DoOnceMultiInput_ptr->NumAdditionalInputs;}
            set {K2Node_DoOnceMultiInput_ptr->NumAdditionalInputs = value;}
        }
        ///<summary>Reference to the integer that contains</summary>
        public unsafe K2Node_TemporaryVariable DataNode {
            get {return K2Node_DoOnceMultiInput_ptr->DataNode;}
            set {K2Node_DoOnceMultiInput_ptr->DataNode = value;}
        }
        static K2Node_DoOnceMultiInput() {
            StaticClass = Main.GetClass("K2Node_DoOnceMultiInput");
        }
        internal unsafe K2Node_DoOnceMultiInput_fields* K2Node_DoOnceMultiInput_ptr => (K2Node_DoOnceMultiInput_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_DoOnceMultiInput(IntPtr p) => UObject.Make<K2Node_DoOnceMultiInput>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_DoOnceMultiInput DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_DoOnceMultiInput New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
