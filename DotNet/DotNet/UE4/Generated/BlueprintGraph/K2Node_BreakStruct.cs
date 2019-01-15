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
    ///<summary>K2Node Break Struct</summary>
    public unsafe partial class K2Node_BreakStruct : K2Node_StructMemberGet  {
        public bool bMadeAfterOverridePinRemoval {
            get {return Main.GetGetBoolPropertyByName(this, "bMadeAfterOverridePinRemoval"); }
            set {Main.SetGetBoolPropertyByName(this, "bMadeAfterOverridePinRemoval", value); }
        }
        static K2Node_BreakStruct() {
            StaticClass = Main.GetClass("K2Node_BreakStruct");
        }
        internal unsafe K2Node_BreakStruct_fields* K2Node_BreakStruct_ptr => (K2Node_BreakStruct_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_BreakStruct(IntPtr p) => UObject.Make<K2Node_BreakStruct>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_BreakStruct DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_BreakStruct New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
