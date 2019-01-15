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
    ///<summary>K2Node Macro Instance</summary>
    public unsafe partial class K2Node_MacroInstance : K2Node_Tunnel  {
        ///<summary>Macro Graph Reference</summary>
        public unsafe GraphReference MacroGraphReference {
            get {return K2Node_MacroInstance_ptr->MacroGraphReference;}
            set {K2Node_MacroInstance_ptr->MacroGraphReference = value;}
        }
        ///<summary>Stored type info for what type the wildcard pins in this macro should become.</summary>
        public unsafe EdGraphPinType ResolvedWildcardType {
            get {return K2Node_MacroInstance_ptr->ResolvedWildcardType;}
            set {K2Node_MacroInstance_ptr->ResolvedWildcardType = value;}
        }
        static K2Node_MacroInstance() {
            StaticClass = Main.GetClass("K2Node_MacroInstance");
        }
        internal unsafe K2Node_MacroInstance_fields* K2Node_MacroInstance_ptr => (K2Node_MacroInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_MacroInstance(IntPtr p) => UObject.Make<K2Node_MacroInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_MacroInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_MacroInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
