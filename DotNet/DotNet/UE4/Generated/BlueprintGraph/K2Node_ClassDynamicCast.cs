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
    ///<summary>K2Node Class Dynamic Cast</summary>
    public unsafe partial class K2Node_ClassDynamicCast : K2Node_DynamicCast  {
        static K2Node_ClassDynamicCast() {
            StaticClass = Main.GetClass("K2Node_ClassDynamicCast");
        }
        internal unsafe K2Node_ClassDynamicCast_fields* K2Node_ClassDynamicCast_ptr => (K2Node_ClassDynamicCast_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_ClassDynamicCast(IntPtr p) => UObject.Make<K2Node_ClassDynamicCast>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_ClassDynamicCast DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_ClassDynamicCast New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
