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
    ///<summary>K2Node Multi Gate</summary>
    public unsafe partial class K2Node_MultiGate : K2Node_ExecutionSequence  {
        ///<summary>Reference to the integer that contains</summary>
        public unsafe K2Node_TemporaryVariable DataNode {
            get {return K2Node_MultiGate_ptr->DataNode;}
            set {K2Node_MultiGate_ptr->DataNode = value;}
        }
        static K2Node_MultiGate() {
            StaticClass = Main.GetClass("K2Node_MultiGate");
        }
        internal unsafe K2Node_MultiGate_fields* K2Node_MultiGate_ptr => (K2Node_MultiGate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_MultiGate(IntPtr p) => UObject.Make<K2Node_MultiGate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_MultiGate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_MultiGate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
