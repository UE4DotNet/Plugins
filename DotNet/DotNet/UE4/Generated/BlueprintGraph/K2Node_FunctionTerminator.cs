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
    ///<summary>K2Node Function Terminator</summary>
    public unsafe partial class K2Node_FunctionTerminator : K2Node_EditablePinBase  {
        ///<summary>Reference to the function signature.</summary>
        public unsafe MemberReference FunctionReference {
            get {return K2Node_FunctionTerminator_ptr->FunctionReference;}
            set {K2Node_FunctionTerminator_ptr->FunctionReference = value;}
        }
        static K2Node_FunctionTerminator() {
            StaticClass = Main.GetClass("K2Node_FunctionTerminator");
        }
        internal unsafe K2Node_FunctionTerminator_fields* K2Node_FunctionTerminator_ptr => (K2Node_FunctionTerminator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_FunctionTerminator(IntPtr p) => UObject.Make<K2Node_FunctionTerminator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_FunctionTerminator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_FunctionTerminator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
