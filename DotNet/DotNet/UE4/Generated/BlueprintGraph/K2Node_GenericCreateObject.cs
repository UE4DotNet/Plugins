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
    ///<summary>K2Node Generic Create Object</summary>
    public unsafe partial class K2Node_GenericCreateObject : K2Node_ConstructObjectFromClass  {
        static K2Node_GenericCreateObject() {
            StaticClass = Main.GetClass("K2Node_GenericCreateObject");
        }
        internal unsafe K2Node_GenericCreateObject_fields* K2Node_GenericCreateObject_ptr => (K2Node_GenericCreateObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_GenericCreateObject(IntPtr p) => UObject.Make<K2Node_GenericCreateObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_GenericCreateObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_GenericCreateObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
