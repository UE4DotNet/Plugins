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
    ///<summary>K2Node Delegate Set</summary>
    public unsafe partial class K2Node_DelegateSet : K2Node  {
        ///<summary>Delegate property name that this event is associated with on the target</summary>
        public unsafe Name DelegatePropertyName {
            get {return K2Node_DelegateSet_ptr->DelegatePropertyName;}
            set {K2Node_DelegateSet_ptr->DelegatePropertyName = value;}
        }
        ///<summary>Class that the delegate property is defined in</summary>
        public unsafe SubclassOf<UObject> DelegatePropertyClass {
            get {return K2Node_DelegateSet_ptr->DelegatePropertyClass;}
            set {K2Node_DelegateSet_ptr->DelegatePropertyClass = value;}
        }
        static K2Node_DelegateSet() {
            StaticClass = Main.GetClass("K2Node_DelegateSet");
        }
        internal unsafe K2Node_DelegateSet_fields* K2Node_DelegateSet_ptr => (K2Node_DelegateSet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_DelegateSet(IntPtr p) => UObject.Make<K2Node_DelegateSet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_DelegateSet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_DelegateSet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
