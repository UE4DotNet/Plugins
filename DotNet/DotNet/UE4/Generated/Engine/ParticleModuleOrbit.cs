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
    ///<summary>Particle Module Orbit</summary>
    public unsafe partial class ParticleModuleOrbit : ParticleModuleOrbitBase  {
        ///<summary>Orbit modules will chain together in the order they appear in the module stack.</summary>
        ///<remarks>
        ///The combination of a module with the one prior to it is defined by using one
        ///of the following enumerations:
        ///        EOChainMode_Add         Add the values to the previous results
        ///        EOChainMode_Scale       Multiply the values by the previous results
        ///        EOChainMode_Link        'Break' the chain and apply the values from the previous results
        ///</remarks>
        public unsafe byte ChainMode {
            get {return ParticleModuleOrbit_ptr->ChainMode;}
            set {ParticleModuleOrbit_ptr->ChainMode = value;}
        }
        ///<summary>The amount to offset the sprite from the particle position.</summary>
        public unsafe RawDistributionVector OffsetAmount {
            get {return ParticleModuleOrbit_ptr->OffsetAmount;}
            set {ParticleModuleOrbit_ptr->OffsetAmount = value;}
        }
        ///<summary>The options associated with the OffsetAmount look-up.</summary>
        public unsafe OrbitOptions OffsetOptions {
            get {return ParticleModuleOrbit_ptr->OffsetOptions;}
            set {ParticleModuleOrbit_ptr->OffsetOptions = value;}
        }
        ///<summary>The amount (in 'turns') to rotate the offset about the particle position.</summary>
        ///<remarks>
        ///0.0 = no rotation
        ///        0.5     = 180 degree rotation
        ///        1.0 = 360 degree rotation
        ///</remarks>
        public unsafe RawDistributionVector RotationAmount {
            get {return ParticleModuleOrbit_ptr->RotationAmount;}
            set {ParticleModuleOrbit_ptr->RotationAmount = value;}
        }
        ///<summary>The options associated with the RotationAmount look-up.</summary>
        public unsafe OrbitOptions RotationOptions {
            get {return ParticleModuleOrbit_ptr->RotationOptions;}
            set {ParticleModuleOrbit_ptr->RotationOptions = value;}
        }
        ///<summary>The rate (in 'turns') at which to rotate the offset about the particle positon.</summary>
        ///<remarks>
        ///0.0 = no rotation
        ///        0.5     = 180 degree rotation
        ///        1.0 = 360 degree rotation
        ///</remarks>
        public unsafe RawDistributionVector RotationRateAmount {
            get {return ParticleModuleOrbit_ptr->RotationRateAmount;}
            set {ParticleModuleOrbit_ptr->RotationRateAmount = value;}
        }
        ///<summary>The options associated with the RotationRateAmount look-up.</summary>
        public unsafe OrbitOptions RotationRateOptions {
            get {return ParticleModuleOrbit_ptr->RotationRateOptions;}
            set {ParticleModuleOrbit_ptr->RotationRateOptions = value;}
        }
        static ParticleModuleOrbit() {
            StaticClass = Main.GetClass("ParticleModuleOrbit");
        }
        internal unsafe ParticleModuleOrbit_fields* ParticleModuleOrbit_ptr => (ParticleModuleOrbit_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleOrbit(IntPtr p) => UObject.Make<ParticleModuleOrbit>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleOrbit DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleOrbit New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
