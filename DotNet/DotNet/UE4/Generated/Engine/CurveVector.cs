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
    ///<summary>Curve Vector</summary>
    public unsafe partial class CurveVector : CurveBase  {

        ///<summary>Evaluate this float curve at the specified time</summary>
        public Vector GetVectorValue(float InTime)  => 
            CurveVector_methods.GetVectorValue_method.Invoke(ObjPointer, InTime);
        ///<summary>Keyframe data, one curve for X, Y and Z</summary>
        public unsafe RichCurve FloatCurves {
            get {return CurveVector_ptr->FloatCurves;}
            set {CurveVector_ptr->FloatCurves = value;}
        }
        static CurveVector() {
            StaticClass = Main.GetClass("CurveVector");
        }
        internal unsafe CurveVector_fields* CurveVector_ptr => (CurveVector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveVector(IntPtr p) => UObject.Make<CurveVector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveVector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveVector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
