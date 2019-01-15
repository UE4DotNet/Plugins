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
    ///<summary>Distribution Float Uniform Curve</summary>
    public unsafe partial class DistributionFloatUniformCurve : DistributionFloat  {
        ///<summary>Keyframe data for how output constant varies over time.</summary>
        public unsafe InterpCurveVector2D ConstantCurve {
            get {return DistributionFloatUniformCurve_ptr->ConstantCurve;}
            set {DistributionFloatUniformCurve_ptr->ConstantCurve = value;}
        }
        static DistributionFloatUniformCurve() {
            StaticClass = Main.GetClass("DistributionFloatUniformCurve");
        }
        internal unsafe DistributionFloatUniformCurve_fields* DistributionFloatUniformCurve_ptr => (DistributionFloatUniformCurve_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionFloatUniformCurve(IntPtr p) => UObject.Make<DistributionFloatUniformCurve>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionFloatUniformCurve DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionFloatUniformCurve New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
