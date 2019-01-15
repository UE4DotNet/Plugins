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
    ///<summary>Distribution Vector Constant Curve</summary>
    public unsafe partial class DistributionVectorConstantCurve : DistributionVector  {
        ///<summary>Keyframe data for each component (X,Y,Z) over time.</summary>
        public unsafe InterpCurveVector ConstantCurve {
            get {return DistributionVectorConstantCurve_ptr->ConstantCurve;}
            set {DistributionVectorConstantCurve_ptr->ConstantCurve = value;}
        }
        public bool bLockAxes {
            get {return Main.GetGetBoolPropertyByName(this, "bLockAxes"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockAxes", value); }
        }
        ///<summary>Locked Axes</summary>
        public unsafe byte LockedAxes {
            get {return DistributionVectorConstantCurve_ptr->LockedAxes;}
            set {DistributionVectorConstantCurve_ptr->LockedAxes = value;}
        }
        static DistributionVectorConstantCurve() {
            StaticClass = Main.GetClass("DistributionVectorConstantCurve");
        }
        internal unsafe DistributionVectorConstantCurve_fields* DistributionVectorConstantCurve_ptr => (DistributionVectorConstantCurve_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionVectorConstantCurve(IntPtr p) => UObject.Make<DistributionVectorConstantCurve>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionVectorConstantCurve DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionVectorConstantCurve New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
