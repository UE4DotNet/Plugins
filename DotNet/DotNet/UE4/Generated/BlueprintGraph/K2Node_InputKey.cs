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
    ///<summary>K2Node Input Key</summary>
    public unsafe partial class K2Node_InputKey : K2Node  {
        ///<summary>The key that is bound</summary>
        public unsafe Key InputKey {
            get {return K2Node_InputKey_ptr->InputKey;}
            set {K2Node_InputKey_ptr->InputKey = value;}
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
        public bool bControl {
            get {return Main.GetGetBoolPropertyByName(this, "bControl"); }
            set {Main.SetGetBoolPropertyByName(this, "bControl", value); }
        }
        public bool bAlt {
            get {return Main.GetGetBoolPropertyByName(this, "bAlt"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlt", value); }
        }
        public bool bShift {
            get {return Main.GetGetBoolPropertyByName(this, "bShift"); }
            set {Main.SetGetBoolPropertyByName(this, "bShift", value); }
        }
        public bool bCommand {
            get {return Main.GetGetBoolPropertyByName(this, "bCommand"); }
            set {Main.SetGetBoolPropertyByName(this, "bCommand", value); }
        }
        static K2Node_InputKey() {
            StaticClass = Main.GetClass("K2Node_InputKey");
        }
        internal unsafe K2Node_InputKey_fields* K2Node_InputKey_ptr => (K2Node_InputKey_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_InputKey(IntPtr p) => UObject.Make<K2Node_InputKey>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_InputKey DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_InputKey New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
