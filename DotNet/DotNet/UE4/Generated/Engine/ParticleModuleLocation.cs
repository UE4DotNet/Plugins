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
    ///<summary>Particle Module Location</summary>
    public unsafe partial class ParticleModuleLocation : ParticleModuleLocationBase  {
        ///<summary>The location the particle should be emitted.</summary>
        ///<remarks>
        ///Relative in local space to the emitter by default.
        ///Relative in world space as a WorldOffset module or when the emitter's UseLocalSpace is off.
        ///Retrieved using the EmitterTime at the spawn of the particle.
        ///</remarks>
        public unsafe RawDistributionVector StartLocation {
            get {return ParticleModuleLocation_ptr->StartLocation;}
            set {ParticleModuleLocation_ptr->StartLocation = value;}
        }
        ///<summary>
        ///When set to a non-zero value this will force the particles to only spawn on evenly distributed
        ///positions between the two points specified.
        ///</summary>
        public unsafe float DistributeOverNPoints {
            get {return ParticleModuleLocation_ptr->DistributeOverNPoints;}
            set {ParticleModuleLocation_ptr->DistributeOverNPoints = value;}
        }
        ///<summary>
        ///When DistributeOverNPoints is set to a non-zero value, this specifies the ratio of particles spawned
        ///that should use the distribution.
        ///</summary>
        ///<remarks>
        ///(For example setting this to 1 will cause all the particles to
        ///be distributed evenly whereas .75 would cause 1/4 of the particles to be randomly placed).
        ///</remarks>
        public unsafe float DistributeThreshold {
            get {return ParticleModuleLocation_ptr->DistributeThreshold;}
            set {ParticleModuleLocation_ptr->DistributeThreshold = value;}
        }
        static ParticleModuleLocation() {
            StaticClass = Main.GetClass("ParticleModuleLocation");
        }
        internal unsafe ParticleModuleLocation_fields* ParticleModuleLocation_ptr => (ParticleModuleLocation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocation(IntPtr p) => UObject.Make<ParticleModuleLocation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
