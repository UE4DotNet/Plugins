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
    ///<summary>Particle Module Collision GPU</summary>
    public unsafe partial class ParticleModuleCollisionGPU : ParticleModuleCollisionBase  {
        ///<summary>The bounciness of the particle.</summary>
        public unsafe RawDistributionFloat Resilience {
            get {return ParticleModuleCollisionGPU_ptr->Resilience;}
            set {ParticleModuleCollisionGPU_ptr->Resilience = value;}
        }
        ///<summary>Scales the bounciness of the particle over its life.</summary>
        public unsafe RawDistributionFloat ResilienceScaleOverLife {
            get {return ParticleModuleCollisionGPU_ptr->ResilienceScaleOverLife;}
            set {ParticleModuleCollisionGPU_ptr->ResilienceScaleOverLife = value;}
        }
        ///<summary>
        ///Friction applied to all particles during a collision or while moving
        ///along a surface.
        ///</summary>
        public unsafe float Friction {
            get {return ParticleModuleCollisionGPU_ptr->Friction;}
            set {ParticleModuleCollisionGPU_ptr->Friction = value;}
        }
        ///<summary>Controls how wide the bouncing particles are distributed (0 = disabled).</summary>
        public unsafe float RandomSpread {
            get {return ParticleModuleCollisionGPU_ptr->RandomSpread;}
            set {ParticleModuleCollisionGPU_ptr->RandomSpread = value;}
        }
        ///<summary>Controls bouncing particles distribution (1 = uniform distribution; 2 = squared distribution).</summary>
        public unsafe float RandomDistribution {
            get {return ParticleModuleCollisionGPU_ptr->RandomDistribution;}
            set {ParticleModuleCollisionGPU_ptr->RandomDistribution = value;}
        }
        ///<summary>Scale applied to the size of the particle to obtain the collision radius.</summary>
        public unsafe float RadiusScale {
            get {return ParticleModuleCollisionGPU_ptr->RadiusScale;}
            set {ParticleModuleCollisionGPU_ptr->RadiusScale = value;}
        }
        ///<summary>Bias applied to the collision radius.</summary>
        public unsafe float RadiusBias {
            get {return ParticleModuleCollisionGPU_ptr->RadiusBias;}
            set {ParticleModuleCollisionGPU_ptr->RadiusBias = value;}
        }
        ///<summary>How particles respond to a collision event.</summary>
        public unsafe byte Response {
            get {return ParticleModuleCollisionGPU_ptr->Response;}
            set {ParticleModuleCollisionGPU_ptr->Response = value;}
        }
        ///<summary>Collision Mode</summary>
        public unsafe byte CollisionMode {
            get {return ParticleModuleCollisionGPU_ptr->CollisionMode;}
            set {ParticleModuleCollisionGPU_ptr->CollisionMode = value;}
        }
        static ParticleModuleCollisionGPU() {
            StaticClass = Main.GetClass("ParticleModuleCollisionGPU");
        }
        internal unsafe ParticleModuleCollisionGPU_fields* ParticleModuleCollisionGPU_ptr => (ParticleModuleCollisionGPU_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleCollisionGPU(IntPtr p) => UObject.Make<ParticleModuleCollisionGPU>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleCollisionGPU DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleCollisionGPU New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
