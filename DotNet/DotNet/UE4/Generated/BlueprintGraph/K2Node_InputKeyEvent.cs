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
using UE4.Slate;

namespace UE4.BlueprintGraph {
    ///<summary>K2Node Input Key Event</summary>
    public unsafe partial class K2Node_InputKeyEvent : K2Node_Event  {
        ///<summary>Input Chord</summary>
        public unsafe InputChord InputChord {
            get {return K2Node_InputKeyEvent_ptr->InputChord;}
            set {K2Node_InputKeyEvent_ptr->InputChord = value;}
        }
        ///<summary>Input Key Event</summary>
        public unsafe byte InputKeyEvent {
            get {return K2Node_InputKeyEvent_ptr->InputKeyEvent;}
            set {K2Node_InputKeyEvent_ptr->InputKeyEvent = value;}
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
        static K2Node_InputKeyEvent() {
            StaticClass = Main.GetClass("K2Node_InputKeyEvent");
        }
        internal unsafe K2Node_InputKeyEvent_fields* K2Node_InputKeyEvent_ptr => (K2Node_InputKeyEvent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_InputKeyEvent(IntPtr p) => UObject.Make<K2Node_InputKeyEvent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_InputKeyEvent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_InputKeyEvent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
