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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Breakpoint</summary>
    public unsafe partial class Breakpoint : UObject  {
        public bool bEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnabled", value); }
        }
        ///<summary>Node that the breakpoint is placed on</summary>
        public unsafe EdGraphNode Node {
            get {return Breakpoint_ptr->Node;}
            set {Breakpoint_ptr->Node = value;}
        }
        public bool bStepOnce {
            get {return Main.GetGetBoolPropertyByName(this, "bStepOnce"); }
            set {Main.SetGetBoolPropertyByName(this, "bStepOnce", value); }
        }
        public bool bStepOnce_WasPreviouslyDisabled {
            get {return Main.GetGetBoolPropertyByName(this, "bStepOnce_WasPreviouslyDisabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bStepOnce_WasPreviouslyDisabled", value); }
        }
        public bool bStepOnce_RemoveAfterHit {
            get {return Main.GetGetBoolPropertyByName(this, "bStepOnce_RemoveAfterHit"); }
            set {Main.SetGetBoolPropertyByName(this, "bStepOnce_RemoveAfterHit", value); }
        }
        static Breakpoint() {
            StaticClass = Main.GetClass("Breakpoint");
        }
        internal unsafe Breakpoint_fields* Breakpoint_ptr => (Breakpoint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Breakpoint(IntPtr p) => UObject.Make<Breakpoint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Breakpoint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Breakpoint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
