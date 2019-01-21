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
    ///<summary>Particle Emitter</summary>
    public unsafe partial class ParticleEmitter : UObject  {
        ///<summary>The name of the emitter.</summary>
        public unsafe Name EmitterName {
            get {return ParticleEmitter_ptr->EmitterName;}
            set {ParticleEmitter_ptr->EmitterName = value;}
        }
        ///<summary>Sub UVData Offset</summary>
        public unsafe int SubUVDataOffset {
            get {return ParticleEmitter_ptr->SubUVDataOffset;}
            set {ParticleEmitter_ptr->SubUVDataOffset = value;}
        }
        ///<summary>How to render the emitter particles.</summary>
        ///<remarks>
        ///Can be one of the following:
        ///        ERM_Normal      - As the intended sprite/mesh
        ///        ERM_Point       - As a 2x2 pixel block with no scaling and the color set in EmitterEditorColor
        ///        ERM_Cross       - As a cross of lines, scaled to the size of the particle in EmitterEditorColor
        ///        ERM_None        - Do not render
        ///</remarks>
        public unsafe byte EmitterRenderMode {
            get {return ParticleEmitter_ptr->EmitterRenderMode;}
            set {ParticleEmitter_ptr->EmitterRenderMode = value;}
        }
         //TODO: enum EParticleSignificanceLevel SignificanceLevel
        public bool bUseLegacySpawningBehavior {
            get {return Main.GetGetBoolPropertyByName(this, "bUseLegacySpawningBehavior"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseLegacySpawningBehavior", value); }
        }
        public bool ConvertedModules {
            get {return Main.GetGetBoolPropertyByName(this, "ConvertedModules"); }
            set {Main.SetGetBoolPropertyByName(this, "ConvertedModules", value); }
        }
        public bool bIsSoloing {
            get {return Main.GetGetBoolPropertyByName(this, "bIsSoloing"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsSoloing", value); }
        }
        public bool bCookedOut {
            get {return Main.GetGetBoolPropertyByName(this, "bCookedOut"); }
            set {Main.SetGetBoolPropertyByName(this, "bCookedOut", value); }
        }
        public bool bDisabledLODsKeepEmitterAlive {
            get {return Main.GetGetBoolPropertyByName(this, "bDisabledLODsKeepEmitterAlive"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisabledLODsKeepEmitterAlive", value); }
        }
        public bool bDisableWhenInsignficant {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableWhenInsignficant"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableWhenInsignficant", value); }
        }
        public bool bCollapsed {
            get {return Main.GetGetBoolPropertyByName(this, "bCollapsed"); }
            set {Main.SetGetBoolPropertyByName(this, "bCollapsed", value); }
        }
        ///<summary>The color of the emitter in the curve editor and debug rendering modes.</summary>
        public unsafe Color EmitterEditorColor {
            get {return ParticleEmitter_ptr->EmitterEditorColor;}
            set {ParticleEmitter_ptr->EmitterEditorColor = value;}
        }
        ///<summary>'Private' data - not required by the editor</summary>
        public ObjectArrayField<ParticleLODLevel> LODLevels{ get {
            if(LODLevels_store == null) LODLevels_store = new ObjectArrayField<ParticleLODLevel> (&ParticleEmitter_ptr->LODLevels);
            return LODLevels_store;
        } }
        private ObjectArrayField<ParticleLODLevel> LODLevels_store;

        ///<summary>Peak Active Particles</summary>
        public unsafe int PeakActiveParticles {
            get {return ParticleEmitter_ptr->PeakActiveParticles;}
            set {ParticleEmitter_ptr->PeakActiveParticles = value;}
        }
        ///<summary>Initial allocation count - overrides calculated peak count if > 0</summary>
        public unsafe int InitialAllocationCount {
            get {return ParticleEmitter_ptr->InitialAllocationCount;}
            set {ParticleEmitter_ptr->InitialAllocationCount = value;}
        }
        ///<summary>Quality Level Spawn Rate Scale</summary>
        public unsafe float QualityLevelSpawnRateScale {
            get {return ParticleEmitter_ptr->QualityLevelSpawnRateScale;}
            set {ParticleEmitter_ptr->QualityLevelSpawnRateScale = value;}
        }
         //TODO: numeric uint32 DetailModeBitmask
         //TODO: string FString DetailModeDisplay
        static ParticleEmitter() {
            StaticClass = Main.GetClass("ParticleEmitter");
        }
        internal unsafe ParticleEmitter_fields* ParticleEmitter_ptr => (ParticleEmitter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleEmitter(IntPtr p) => UObject.Make<ParticleEmitter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleEmitter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleEmitter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
