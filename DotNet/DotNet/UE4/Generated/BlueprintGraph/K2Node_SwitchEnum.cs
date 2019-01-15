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
    ///<summary>K2Node Switch Enum</summary>
    public unsafe partial class K2Node_SwitchEnum : K2Node_Switch  {
        ///<summary>Name of the enum being switched on</summary>
        public unsafe UEnum UEnum {
            get {return K2Node_SwitchEnum_ptr->UEnum;}
            set {K2Node_SwitchEnum_ptr->UEnum = value;}
        }
         //TODO: array not UObject TArray EnumEntries
         //TODO: array not UObject TArray EnumFriendlyNames
        static K2Node_SwitchEnum() {
            StaticClass = Main.GetClass("K2Node_SwitchEnum");
        }
        internal unsafe K2Node_SwitchEnum_fields* K2Node_SwitchEnum_ptr => (K2Node_SwitchEnum_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_SwitchEnum(IntPtr p) => UObject.Make<K2Node_SwitchEnum>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_SwitchEnum DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_SwitchEnum New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
