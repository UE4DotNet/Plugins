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
    ///<summary>K2Node Dynamic Cast</summary>
    public unsafe partial class K2Node_DynamicCast : K2Node  {
        ///<summary>The type that the input should try to be cast to</summary>
        public unsafe SubclassOf<UObject> TargetType {
            get {return K2Node_DynamicCast_ptr->TargetType;}
            set {K2Node_DynamicCast_ptr->TargetType = value;}
        }
        public bool bIsPureCast {
            get {return Main.GetGetBoolPropertyByName(this, "bIsPureCast"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsPureCast", value); }
        }
        static K2Node_DynamicCast() {
            StaticClass = Main.GetClass("K2Node_DynamicCast");
        }
        internal unsafe K2Node_DynamicCast_fields* K2Node_DynamicCast_ptr => (K2Node_DynamicCast_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_DynamicCast(IntPtr p) => UObject.Make<K2Node_DynamicCast>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_DynamicCast DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_DynamicCast New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
