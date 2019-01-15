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
using UE4.InputCore;

namespace UE4.BlueprintGraph {
    ///<summary>K2Node Input Axis Key Event</summary>
    public unsafe partial class K2Node_InputAxisKeyEvent : K2Node_Event  {
        ///<summary>Axis Key</summary>
        public unsafe Key AxisKey {
            get {return K2Node_InputAxisKeyEvent_ptr->AxisKey;}
            set {K2Node_InputAxisKeyEvent_ptr->AxisKey = value;}
        }
        public bool bConsumeInput {
            get {return Main.GetGetBoolPropertyByName(this, "bConsumeInput"); }
            set {Main.SetGetBoolPropertyByName(this, "bConsumeInput", value); }
        }
        public bool bExecuteWhenPaused {
            get {return Main.GetGetBoolPropertyByName(this, "bExecuteWhenPaused"); }
            set {Main.SetGetBoolPropertyByName(this, "bExecuteWhenPaused", value); }
        }
        public bool bOverrideParentBinding {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideParentBinding"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideParentBinding", value); }
        }
        static K2Node_InputAxisKeyEvent() {
            StaticClass = Main.GetClass("K2Node_InputAxisKeyEvent");
        }
        internal unsafe K2Node_InputAxisKeyEvent_fields* K2Node_InputAxisKeyEvent_ptr => (K2Node_InputAxisKeyEvent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_InputAxisKeyEvent(IntPtr p) => UObject.Make<K2Node_InputAxisKeyEvent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_InputAxisKeyEvent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_InputAxisKeyEvent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
