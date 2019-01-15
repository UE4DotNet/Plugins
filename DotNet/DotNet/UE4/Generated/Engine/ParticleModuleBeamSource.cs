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
    ///<summary>Particle Module Beam Source</summary>
    public unsafe partial class ParticleModuleBeamSource : ParticleModuleBeamBase  {
        ///<summary>The method flag.</summary>
        public unsafe byte SourceMethod {
            get {return ParticleModuleBeamSource_ptr->SourceMethod;}
            set {ParticleModuleBeamSource_ptr->SourceMethod = value;}
        }
        ///<summary>The strength of the tangent from the source point for each beam.</summary>
        public unsafe Name SourceName {
            get {return ParticleModuleBeamSource_ptr->SourceName;}
            set {ParticleModuleBeamSource_ptr->SourceName = value;}
        }
        public bool bSourceAbsolute {
            get {return Main.GetGetBoolPropertyByName(this, "bSourceAbsolute"); }
            set {Main.SetGetBoolPropertyByName(this, "bSourceAbsolute", value); }
        }
        ///<summary>Default source-point to use.</summary>
        public unsafe RawDistributionVector Source {
            get {return ParticleModuleBeamSource_ptr->Source;}
            set {ParticleModuleBeamSource_ptr->Source = value;}
        }
        public bool bLockSource {
            get {return Main.GetGetBoolPropertyByName(this, "bLockSource"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockSource", value); }
        }
        ///<summary>The method to use for the source tangent.</summary>
        public unsafe byte SourceTangentMethod {
            get {return ParticleModuleBeamSource_ptr->SourceTangentMethod;}
            set {ParticleModuleBeamSource_ptr->SourceTangentMethod = value;}
        }
        ///<summary>The tangent for the source point for each beam.</summary>
        public unsafe RawDistributionVector SourceTangent {
            get {return ParticleModuleBeamSource_ptr->SourceTangent;}
            set {ParticleModuleBeamSource_ptr->SourceTangent = value;}
        }
        public bool bLockSourceTangent {
            get {return Main.GetGetBoolPropertyByName(this, "bLockSourceTangent"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockSourceTangent", value); }
        }
        ///<summary>The strength of the tangent from the source point for each beam.</summary>
        public unsafe RawDistributionFloat SourceStrength {
            get {return ParticleModuleBeamSource_ptr->SourceStrength;}
            set {ParticleModuleBeamSource_ptr->SourceStrength = value;}
        }
        public bool bLockSourceStength {
            get {return Main.GetGetBoolPropertyByName(this, "bLockSourceStength"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockSourceStength", value); }
        }
        static ParticleModuleBeamSource() {
            StaticClass = Main.GetClass("ParticleModuleBeamSource");
        }
        internal unsafe ParticleModuleBeamSource_fields* ParticleModuleBeamSource_ptr => (ParticleModuleBeamSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleBeamSource(IntPtr p) => UObject.Make<ParticleModuleBeamSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleBeamSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleBeamSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
