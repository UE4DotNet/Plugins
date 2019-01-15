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
    ///<summary>K2Node Variable</summary>
    public unsafe partial class K2Node_Variable : K2Node  {
        ///<summary>Reference to variable we want to set/get</summary>
        public unsafe MemberReference VariableReference {
            get {return K2Node_Variable_ptr->VariableReference;}
            set {K2Node_Variable_ptr->VariableReference = value;}
        }
        ///<summary>Self Context Info</summary>
        public unsafe byte SelfContextInfo {
            get {return K2Node_Variable_ptr->SelfContextInfo;}
            set {K2Node_Variable_ptr->SelfContextInfo = value;}
        }
        static K2Node_Variable() {
            StaticClass = Main.GetClass("K2Node_Variable");
        }
        internal unsafe K2Node_Variable_fields* K2Node_Variable_ptr => (K2Node_Variable_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_Variable(IntPtr p) => UObject.Make<K2Node_Variable>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_Variable DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_Variable New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
