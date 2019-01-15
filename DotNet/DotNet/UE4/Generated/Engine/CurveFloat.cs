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
    ///<summary>Curve Float</summary>
    public unsafe partial class CurveFloat : CurveBase  {

        ///<summary>Evaluate this float curve at the specified time</summary>
        public float GetFloatValue(float InTime)  => 
            CurveFloat_methods.GetFloatValue_method.Invoke(ObjPointer, InTime);
        ///<summary>Keyframe data</summary>
        public unsafe RichCurve FloatCurve {
            get {return CurveFloat_ptr->FloatCurve;}
            set {CurveFloat_ptr->FloatCurve = value;}
        }
        public bool bIsEventCurve {
            get {return Main.GetGetBoolPropertyByName(this, "bIsEventCurve"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsEventCurve", value); }
        }
        static CurveFloat() {
            StaticClass = Main.GetClass("CurveFloat");
        }
        internal unsafe CurveFloat_fields* CurveFloat_ptr => (CurveFloat_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveFloat(IntPtr p) => UObject.Make<CurveFloat>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveFloat DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveFloat New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
