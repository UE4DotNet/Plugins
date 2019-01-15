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
using UE4.FunctionalTesting.Native;
using UE4.Engine;

namespace UE4.FunctionalTesting {
    ///<summary>Phased Automation Actor Base</summary>
    public unsafe partial class PhasedAutomationActorBase : Actor  {

        ///<summary>On Functional Testing Begin</summary>
        public event OnFunctionalTestingBegin_delegate OnFunctionalTestingBegin;
        public delegate void OnFunctionalTestingBegin_delegate();
        internal void on_OnFunctionalTestingBegin() =>
            OnFunctionalTestingBegin?.Invoke();


        ///<summary>On Functional Testing Complete</summary>
        public event OnFunctionalTestingComplete_delegate OnFunctionalTestingComplete;
        public delegate void OnFunctionalTestingComplete_delegate();
        internal void on_OnFunctionalTestingComplete() =>
            OnFunctionalTestingComplete?.Invoke();

        static PhasedAutomationActorBase() {
            StaticClass = Main.GetClass("PhasedAutomationActorBase");
            PhasedAutomationActorBase_events.OnFunctionalTestingBegin_event.Setup();
            PhasedAutomationActorBase_events.OnFunctionalTestingComplete_event.Setup();
        }
        internal unsafe PhasedAutomationActorBase_fields* PhasedAutomationActorBase_ptr => (PhasedAutomationActorBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhasedAutomationActorBase(IntPtr p) => UObject.Make<PhasedAutomationActorBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhasedAutomationActorBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhasedAutomationActorBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
