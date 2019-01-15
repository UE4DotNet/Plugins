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
    ///<summary>Particle LODLevel</summary>
    public unsafe partial class ParticleLODLevel : UObject  {
        ///<summary>The index value of the LOD level</summary>
        public unsafe int Level {
            get {return ParticleLODLevel_ptr->Level;}
            set {ParticleLODLevel_ptr->Level = value;}
        }
        public bool bEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnabled", value); }
        }
        ///<summary>The required module for this LOD level</summary>
        public unsafe ParticleModuleRequired RequiredModule {
            get {return ParticleLODLevel_ptr->RequiredModule;}
            set {ParticleLODLevel_ptr->RequiredModule = value;}
        }
        ///<summary>An array of particle modules that contain the adjusted data for the LOD level</summary>
        public ObjectArrayField<ParticleModule> Modules{ get {
            if(Modules_store == null) Modules_store = new ObjectArrayField<ParticleModule> (&ParticleLODLevel_ptr->Modules);
            return Modules_store;
        } }
        private ObjectArrayField<ParticleModule> Modules_store;

        ///<summary>Module<SINGULAR> used for emitter type "extension".</summary>
        public unsafe ParticleModuleTypeDataBase TypeDataModule {
            get {return ParticleLODLevel_ptr->TypeDataModule;}
            set {ParticleLODLevel_ptr->TypeDataModule = value;}
        }
        ///<summary>The SpawnRate/Burst module - required by all emitters.</summary>
        public unsafe ParticleModuleSpawn SpawnModule {
            get {return ParticleLODLevel_ptr->SpawnModule;}
            set {ParticleLODLevel_ptr->SpawnModule = value;}
        }
        ///<summary>The optional EventGenerator module.</summary>
        public unsafe ParticleModuleEventGenerator EventGenerator {
            get {return ParticleLODLevel_ptr->EventGenerator;}
            set {ParticleLODLevel_ptr->EventGenerator = value;}
        }
        ///<summary>SpawningModules - These are called to determine how many particles to spawn.</summary>
        public ObjectArrayField<ParticleModuleSpawnBase> SpawningModules{ get {
            if(SpawningModules_store == null) SpawningModules_store = new ObjectArrayField<ParticleModuleSpawnBase> (&ParticleLODLevel_ptr->SpawningModules);
            return SpawningModules_store;
        } }
        private ObjectArrayField<ParticleModuleSpawnBase> SpawningModules_store;

        ///<summary>SpawnModules - These are called when particles are spawned.</summary>
        public ObjectArrayField<ParticleModule> SpawnModules{ get {
            if(SpawnModules_store == null) SpawnModules_store = new ObjectArrayField<ParticleModule> (&ParticleLODLevel_ptr->SpawnModules);
            return SpawnModules_store;
        } }
        private ObjectArrayField<ParticleModule> SpawnModules_store;

        ///<summary>UpdateModules - These are called when particles are updated.</summary>
        public ObjectArrayField<ParticleModule> UpdateModules{ get {
            if(UpdateModules_store == null) UpdateModules_store = new ObjectArrayField<ParticleModule> (&ParticleLODLevel_ptr->UpdateModules);
            return UpdateModules_store;
        } }
        private ObjectArrayField<ParticleModule> UpdateModules_store;

        ///<summary>
        ///OrbitModules
        ///    These are used to do offsets of the sprite from the particle location.
        ///</summary>
        public ObjectArrayField<ParticleModuleOrbit> OrbitModules{ get {
            if(OrbitModules_store == null) OrbitModules_store = new ObjectArrayField<ParticleModuleOrbit> (&ParticleLODLevel_ptr->OrbitModules);
            return OrbitModules_store;
        } }
        private ObjectArrayField<ParticleModuleOrbit> OrbitModules_store;

        ///<summary>Event receiver modules only!</summary>
        public ObjectArrayField<ParticleModuleEventReceiverBase> EventReceiverModules{ get {
            if(EventReceiverModules_store == null) EventReceiverModules_store = new ObjectArrayField<ParticleModuleEventReceiverBase> (&ParticleLODLevel_ptr->EventReceiverModules);
            return EventReceiverModules_store;
        } }
        private ObjectArrayField<ParticleModuleEventReceiverBase> EventReceiverModules_store;

        public bool ConvertedModules {
            get {return Main.GetGetBoolPropertyByName(this, "ConvertedModules"); }
            set {Main.SetGetBoolPropertyByName(this, "ConvertedModules", value); }
        }
        ///<summary>Peak Active Particles</summary>
        public unsafe int PeakActiveParticles {
            get {return ParticleLODLevel_ptr->PeakActiveParticles;}
            set {ParticleLODLevel_ptr->PeakActiveParticles = value;}
        }
        static ParticleLODLevel() {
            StaticClass = Main.GetClass("ParticleLODLevel");
        }
        internal unsafe ParticleLODLevel_fields* ParticleLODLevel_ptr => (ParticleLODLevel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleLODLevel(IntPtr p) => UObject.Make<ParticleLODLevel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleLODLevel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleLODLevel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
