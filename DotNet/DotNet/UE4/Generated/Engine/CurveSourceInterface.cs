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
    ///<summary>Curve Source Interface</summary>
    public unsafe partial class CurveSourceInterface : Interface  {

        ///<summary>Get the name that this curve source can be bound to by.</summary>
        ///<remarks>Clients of this curve source will use this name to identify this source.</remarks>
        public event GetBindingName_delegate GetBindingName;
        public delegate Name GetBindingName_delegate(Name ReturnValue);
        internal Name on_GetBindingName(Name ReturnValue) =>
            GetBindingName != null ? GetBindingName(ReturnValue) : ReturnValue;

        //TODO: class_event: event with array parameter GetCurves

        ///<summary>Get the value for a specified curve</summary>
        public event GetCurveValue_delegate GetCurveValue;
        public delegate float GetCurveValue_delegate(Name CurveName, float ReturnValue);
        internal float on_GetCurveValue(Name CurveName, float ReturnValue) =>
            GetCurveValue != null ? GetCurveValue(CurveName, ReturnValue) : ReturnValue;

        static CurveSourceInterface() {
            StaticClass = Main.GetClass("CurveSourceInterface");
            CurveSourceInterface_events.GetBindingName_event.Setup();
            //TODO: call_event_setup: event with array parameter: GetCurves
            CurveSourceInterface_events.GetCurveValue_event.Setup();
        }
        internal unsafe CurveSourceInterface_fields* CurveSourceInterface_ptr => (CurveSourceInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveSourceInterface(IntPtr p) => UObject.Make<CurveSourceInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveSourceInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveSourceInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
