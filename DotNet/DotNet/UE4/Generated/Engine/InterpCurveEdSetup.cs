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
    ///<summary>Interp Curve Ed Setup</summary>
    public unsafe partial class InterpCurveEdSetup : UObject  {
         //TODO: array not UObject TArray Tabs
        ///<summary>Active Tab</summary>
        public unsafe int ActiveTab {
            get {return InterpCurveEdSetup_ptr->ActiveTab;}
            set {InterpCurveEdSetup_ptr->ActiveTab = value;}
        }
        static InterpCurveEdSetup() {
            StaticClass = Main.GetClass("InterpCurveEdSetup");
        }
        internal unsafe InterpCurveEdSetup_fields* InterpCurveEdSetup_ptr => (InterpCurveEdSetup_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpCurveEdSetup(IntPtr p) => UObject.Make<InterpCurveEdSetup>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpCurveEdSetup DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpCurveEdSetup New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
