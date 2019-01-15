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
    ///<summary>Particle Module Beam Target</summary>
    public unsafe partial class ParticleModuleBeamTarget : ParticleModuleBeamBase  {
        ///<summary>The method flag.</summary>
        public unsafe byte TargetMethod {
            get {return ParticleModuleBeamTarget_ptr->TargetMethod;}
            set {ParticleModuleBeamTarget_ptr->TargetMethod = value;}
        }
        ///<summary>The target point sources of each beam, when using the end point method.</summary>
        public unsafe Name TargetName {
            get {return ParticleModuleBeamTarget_ptr->TargetName;}
            set {ParticleModuleBeamTarget_ptr->TargetName = value;}
        }
        ///<summary>Default target-point information to use if the beam method is endpoint.</summary>
        public unsafe RawDistributionVector Target {
            get {return ParticleModuleBeamTarget_ptr->Target;}
            set {ParticleModuleBeamTarget_ptr->Target = value;}
        }
        public bool bTargetAbsolute {
            get {return Main.GetGetBoolPropertyByName(this, "bTargetAbsolute"); }
            set {Main.SetGetBoolPropertyByName(this, "bTargetAbsolute", value); }
        }
        public bool bLockTarget {
            get {return Main.GetGetBoolPropertyByName(this, "bLockTarget"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockTarget", value); }
        }
        ///<summary>The method to use for the Target tangent.</summary>
        public unsafe byte TargetTangentMethod {
            get {return ParticleModuleBeamTarget_ptr->TargetTangentMethod;}
            set {ParticleModuleBeamTarget_ptr->TargetTangentMethod = value;}
        }
        ///<summary>The tangent for the Target point for each beam.</summary>
        public unsafe RawDistributionVector TargetTangent {
            get {return ParticleModuleBeamTarget_ptr->TargetTangent;}
            set {ParticleModuleBeamTarget_ptr->TargetTangent = value;}
        }
        public bool bLockTargetTangent {
            get {return Main.GetGetBoolPropertyByName(this, "bLockTargetTangent"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockTargetTangent", value); }
        }
        ///<summary>The strength of the tangent from the Target point for each beam.</summary>
        public unsafe RawDistributionFloat TargetStrength {
            get {return ParticleModuleBeamTarget_ptr->TargetStrength;}
            set {ParticleModuleBeamTarget_ptr->TargetStrength = value;}
        }
        public bool bLockTargetStength {
            get {return Main.GetGetBoolPropertyByName(this, "bLockTargetStength"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockTargetStength", value); }
        }
        ///<summary>Default target-point information to use if the beam method is endpoint.</summary>
        public unsafe float LockRadius {
            get {return ParticleModuleBeamTarget_ptr->LockRadius;}
            set {ParticleModuleBeamTarget_ptr->LockRadius = value;}
        }
        static ParticleModuleBeamTarget() {
            StaticClass = Main.GetClass("ParticleModuleBeamTarget");
        }
        internal unsafe ParticleModuleBeamTarget_fields* ParticleModuleBeamTarget_ptr => (ParticleModuleBeamTarget_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleBeamTarget(IntPtr p) => UObject.Make<ParticleModuleBeamTarget>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleBeamTarget DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleBeamTarget New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
