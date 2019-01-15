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
    ///<summary>Particle Module Spawn Per Unit</summary>
    public unsafe partial class ParticleModuleSpawnPerUnit : ParticleModuleSpawnBase  {
        ///<summary>The scalar to apply to the distance traveled.</summary>
        ///<remarks>
        ///The value from SpawnPerUnit is divided by this value to give the actual
        ///number of particles per unit.
        ///</remarks>
        public unsafe float UnitScalar {
            get {return ParticleModuleSpawnPerUnit_ptr->UnitScalar;}
            set {ParticleModuleSpawnPerUnit_ptr->UnitScalar = value;}
        }
        ///<summary>The amount to spawn per meter distribution.</summary>
        ///<remarks>The value is retrieved using the EmitterTime.</remarks>
        public unsafe RawDistributionFloat SpawnPerUnit {
            get {return ParticleModuleSpawnPerUnit_ptr->SpawnPerUnit;}
            set {ParticleModuleSpawnPerUnit_ptr->SpawnPerUnit = value;}
        }
        public bool bIgnoreSpawnRateWhenMoving {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreSpawnRateWhenMoving"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreSpawnRateWhenMoving", value); }
        }
        ///<summary>The tolerance for moving vs.</summary>
        ///<remarks>
        ///not moving w.r.t. the bIgnoreSpawnRateWhenMoving flag.
        ///Ie, if (DistanceMoved < (UnitScalar x MovementTolerance)) then consider it not moving.
        ///</remarks>
        public unsafe float MovementTolerance {
            get {return ParticleModuleSpawnPerUnit_ptr->MovementTolerance;}
            set {ParticleModuleSpawnPerUnit_ptr->MovementTolerance = value;}
        }
        ///<summary>The maximum valid movement for a single frame.</summary>
        ///<remarks>
        ///If 0.0, then the check is not performed.
        ///Currently, if the distance moved between frames is greater than this
        ///then NO particles will be spawned.
        ///This is primiarily intended to cover cases where the PSystem is
        ///attached to teleporting objects.
        ///</remarks>
        public unsafe float MaxFrameDistance {
            get {return ParticleModuleSpawnPerUnit_ptr->MaxFrameDistance;}
            set {ParticleModuleSpawnPerUnit_ptr->MaxFrameDistance = value;}
        }
        public bool bIgnoreMovementAlongX {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreMovementAlongX"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreMovementAlongX", value); }
        }
        public bool bIgnoreMovementAlongY {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreMovementAlongY"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreMovementAlongY", value); }
        }
        public bool bIgnoreMovementAlongZ {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreMovementAlongZ"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreMovementAlongZ", value); }
        }
        static ParticleModuleSpawnPerUnit() {
            StaticClass = Main.GetClass("ParticleModuleSpawnPerUnit");
        }
        internal unsafe ParticleModuleSpawnPerUnit_fields* ParticleModuleSpawnPerUnit_ptr => (ParticleModuleSpawnPerUnit_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleSpawnPerUnit(IntPtr p) => UObject.Make<ParticleModuleSpawnPerUnit>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleSpawnPerUnit DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleSpawnPerUnit New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
