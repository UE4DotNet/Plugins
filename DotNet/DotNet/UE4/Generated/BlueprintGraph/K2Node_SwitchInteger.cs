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
    ///<summary>K2Node Switch Integer</summary>
    public unsafe partial class K2Node_SwitchInteger : K2Node_Switch  {
        ///<summary>Set the starting index for the node</summary>
        public unsafe int StartIndex {
            get {return K2Node_SwitchInteger_ptr->StartIndex;}
            set {K2Node_SwitchInteger_ptr->StartIndex = value;}
        }
        static K2Node_SwitchInteger() {
            StaticClass = Main.GetClass("K2Node_SwitchInteger");
        }
        internal unsafe K2Node_SwitchInteger_fields* K2Node_SwitchInteger_ptr => (K2Node_SwitchInteger_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_SwitchInteger(IntPtr p) => UObject.Make<K2Node_SwitchInteger>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_SwitchInteger DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_SwitchInteger New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
