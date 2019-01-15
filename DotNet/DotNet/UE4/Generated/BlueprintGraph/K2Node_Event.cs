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
    ///<summary>K2Node Event</summary>
    public unsafe partial class K2Node_Event : K2Node_EditablePinBase  {
        ///<summary>Reference for the function this event is linked to</summary>
        public unsafe MemberReference EventReference {
            get {return K2Node_Event_ptr->EventReference;}
            set {K2Node_Event_ptr->EventReference = value;}
        }
        public bool bOverrideFunction {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideFunction"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideFunction", value); }
        }
        public bool bInternalEvent {
            get {return Main.GetGetBoolPropertyByName(this, "bInternalEvent"); }
            set {Main.SetGetBoolPropertyByName(this, "bInternalEvent", value); }
        }
        ///<summary>If this is not an override, allow user to specify a name for the function created by this entry point</summary>
        public unsafe Name CustomFunctionName {
            get {return K2Node_Event_ptr->CustomFunctionName;}
            set {K2Node_Event_ptr->CustomFunctionName = value;}
        }
         //TODO: numeric uint32 FunctionFlags
        static K2Node_Event() {
            StaticClass = Main.GetClass("K2Node_Event");
        }
        internal unsafe K2Node_Event_fields* K2Node_Event_ptr => (K2Node_Event_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_Event(IntPtr p) => UObject.Make<K2Node_Event>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_Event DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_Event New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
