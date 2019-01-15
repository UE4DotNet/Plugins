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
    ///<summary>Particle Module Acceleration</summary>
    public unsafe partial class ParticleModuleAcceleration : ParticleModuleAccelerationBase  {
        ///<summary>The initial acceleration of the particle.</summary>
        ///<remarks>
        ///Value is obtained using the EmitterTime at particle spawn.
        ///Each frame, the current and base velocity of the particle
        ///is then updated using the formula
        ///        velocity += acceleration * DeltaTime
        ///where DeltaTime is the time passed since the last frame.
        ///</remarks>
        public unsafe RawDistributionVector Acceleration {
            get {return ParticleModuleAcceleration_ptr->Acceleration;}
            set {ParticleModuleAcceleration_ptr->Acceleration = value;}
        }
        public bool bApplyOwnerScale {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyOwnerScale"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyOwnerScale", value); }
        }
        static ParticleModuleAcceleration() {
            StaticClass = Main.GetClass("ParticleModuleAcceleration");
        }
        internal unsafe ParticleModuleAcceleration_fields* ParticleModuleAcceleration_ptr => (ParticleModuleAcceleration_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleAcceleration(IntPtr p) => UObject.Make<ParticleModuleAcceleration>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleAcceleration DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleAcceleration New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
