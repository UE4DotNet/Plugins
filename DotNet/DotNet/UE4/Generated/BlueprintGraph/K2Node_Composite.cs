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
    ///<summary>K2Node Composite</summary>
    public unsafe partial class K2Node_Composite : K2Node_Tunnel  {
        ///<summary>The graph that this composite node is representing</summary>
        public unsafe EdGraph BoundGraph {
            get {return K2Node_Composite_ptr->BoundGraph;}
            set {K2Node_Composite_ptr->BoundGraph = value;}
        }
        static K2Node_Composite() {
            StaticClass = Main.GetClass("K2Node_Composite");
        }
        internal unsafe K2Node_Composite_fields* K2Node_Composite_ptr => (K2Node_Composite_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_Composite(IntPtr p) => UObject.Make<K2Node_Composite>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_Composite DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_Composite New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
