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
    ///<summary>Distribution Vector Uniform Curve</summary>
    public unsafe partial class DistributionVectorUniformCurve : DistributionVector  {
        ///<summary>Keyframe data for how output constant varies over time.</summary>
        public unsafe InterpCurveTwoVectors ConstantCurve {
            get {return DistributionVectorUniformCurve_ptr->ConstantCurve;}
            set {DistributionVectorUniformCurve_ptr->ConstantCurve = value;}
        }
        public bool bLockAxes1 {
            get {return Main.GetGetBoolPropertyByName(this, "bLockAxes1"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockAxes1", value); }
        }
        public bool bLockAxes2 {
            get {return Main.GetGetBoolPropertyByName(this, "bLockAxes2"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockAxes2", value); }
        }
        ///<summary>Locked Axes</summary>
        public unsafe byte LockedAxes {
            get {return DistributionVectorUniformCurve_ptr->LockedAxes;}
            set {DistributionVectorUniformCurve_ptr->LockedAxes = value;}
        }
        ///<summary>Mirror Flags</summary>
        public unsafe byte MirrorFlags {
            get {return DistributionVectorUniformCurve_ptr->MirrorFlags;}
            set {DistributionVectorUniformCurve_ptr->MirrorFlags = value;}
        }
        public bool bUseExtremes {
            get {return Main.GetGetBoolPropertyByName(this, "bUseExtremes"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseExtremes", value); }
        }
        static DistributionVectorUniformCurve() {
            StaticClass = Main.GetClass("DistributionVectorUniformCurve");
        }
        internal unsafe DistributionVectorUniformCurve_fields* DistributionVectorUniformCurve_ptr => (DistributionVectorUniformCurve_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionVectorUniformCurve(IntPtr p) => UObject.Make<DistributionVectorUniformCurve>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionVectorUniformCurve DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionVectorUniformCurve New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
