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
    ///<summary>K2Node Base MCDelegate</summary>
    public unsafe partial class K2Node_BaseMCDelegate : K2Node  {
        ///<summary>Reference to delegate</summary>
        public unsafe MemberReference DelegateReference {
            get {return K2Node_BaseMCDelegate_ptr->DelegateReference;}
            set {K2Node_BaseMCDelegate_ptr->DelegateReference = value;}
        }
        static K2Node_BaseMCDelegate() {
            StaticClass = Main.GetClass("K2Node_BaseMCDelegate");
        }
        internal unsafe K2Node_BaseMCDelegate_fields* K2Node_BaseMCDelegate_ptr => (K2Node_BaseMCDelegate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_BaseMCDelegate(IntPtr p) => UObject.Make<K2Node_BaseMCDelegate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_BaseMCDelegate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_BaseMCDelegate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
