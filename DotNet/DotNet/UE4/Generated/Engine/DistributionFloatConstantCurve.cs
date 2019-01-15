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
    ///<summary>Distribution Float Constant Curve</summary>
    public unsafe partial class DistributionFloatConstantCurve : DistributionFloat  {
        ///<summary>Keyframe data for how output constant varies over time.</summary>
        public unsafe InterpCurveFloat ConstantCurve {
            get {return DistributionFloatConstantCurve_ptr->ConstantCurve;}
            set {DistributionFloatConstantCurve_ptr->ConstantCurve = value;}
        }
        static DistributionFloatConstantCurve() {
            StaticClass = Main.GetClass("DistributionFloatConstantCurve");
        }
        internal unsafe DistributionFloatConstantCurve_fields* DistributionFloatConstantCurve_ptr => (DistributionFloatConstantCurve_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionFloatConstantCurve(IntPtr p) => UObject.Make<DistributionFloatConstantCurve>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionFloatConstantCurve DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionFloatConstantCurve New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
