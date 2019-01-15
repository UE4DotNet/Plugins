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
    ///<summary>K2Node Select</summary>
    public unsafe partial class K2Node_Select : K2Node  {
        ///<summary>The number of selectable options this node currently has</summary>
        public unsafe int NumOptionPins {
            get {return K2Node_Select_ptr->NumOptionPins;}
            set {K2Node_Select_ptr->NumOptionPins = value;}
        }
        ///<summary>The pin type of the index pin</summary>
        public unsafe EdGraphPinType IndexPinType {
            get {return K2Node_Select_ptr->IndexPinType;}
            set {K2Node_Select_ptr->IndexPinType = value;}
        }
        ///<summary>Name of the enum being switched on</summary>
        public unsafe UEnum UEnum {
            get {return K2Node_Select_ptr->UEnum;}
            set {K2Node_Select_ptr->UEnum = value;}
        }
         //TODO: array not UObject TArray EnumEntries
         //TODO: array not UObject TArray EnumEntryFriendlyNames
        public bool bReconstructNode {
            get {return Main.GetGetBoolPropertyByName(this, "bReconstructNode"); }
            set {Main.SetGetBoolPropertyByName(this, "bReconstructNode", value); }
        }
        static K2Node_Select() {
            StaticClass = Main.GetClass("K2Node_Select");
        }
        internal unsafe K2Node_Select_fields* K2Node_Select_ptr => (K2Node_Select_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_Select(IntPtr p) => UObject.Make<K2Node_Select>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_Select DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_Select New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
