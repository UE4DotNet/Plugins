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
    ///<summary>Particle Module Type Data Ribbon</summary>
    public unsafe partial class ParticleModuleTypeDataRibbon : ParticleModuleTypeDataBase  {
        ///<summary>The maximum amount to tessellate between two particles of the trail.</summary>
        ///<remarks>
        ///Depending on the distance between the particles and the tangent change, the
        ///system will select a number of tessellation points
        ///        [0..MaxTessellationBetweenParticles]
        ///</remarks>
        public unsafe int MaxTessellationBetweenParticles {
            get {return ParticleModuleTypeDataRibbon_ptr->MaxTessellationBetweenParticles;}
            set {ParticleModuleTypeDataRibbon_ptr->MaxTessellationBetweenParticles = value;}
        }
        ///<summary>The number of sheets to render for the trail.</summary>
        public unsafe int SheetsPerTrail {
            get {return ParticleModuleTypeDataRibbon_ptr->SheetsPerTrail;}
            set {ParticleModuleTypeDataRibbon_ptr->SheetsPerTrail = value;}
        }
        ///<summary>The number of live trails</summary>
        public unsafe int MaxTrailCount {
            get {return ParticleModuleTypeDataRibbon_ptr->MaxTrailCount;}
            set {ParticleModuleTypeDataRibbon_ptr->MaxTrailCount = value;}
        }
        ///<summary>Max particles per trail</summary>
        public unsafe int MaxParticleInTrailCount {
            get {return ParticleModuleTypeDataRibbon_ptr->MaxParticleInTrailCount;}
            set {ParticleModuleTypeDataRibbon_ptr->MaxParticleInTrailCount = value;}
        }
        public bool bDeadTrailsOnDeactivate {
            get {return Main.GetGetBoolPropertyByName(this, "bDeadTrailsOnDeactivate"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeadTrailsOnDeactivate", value); }
        }
        public bool bDeadTrailsOnSourceLoss {
            get {return Main.GetGetBoolPropertyByName(this, "bDeadTrailsOnSourceLoss"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeadTrailsOnSourceLoss", value); }
        }
        public bool bClipSourceSegement {
            get {return Main.GetGetBoolPropertyByName(this, "bClipSourceSegement"); }
            set {Main.SetGetBoolPropertyByName(this, "bClipSourceSegement", value); }
        }
        public bool bEnablePreviousTangentRecalculation {
            get {return Main.GetGetBoolPropertyByName(this, "bEnablePreviousTangentRecalculation"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnablePreviousTangentRecalculation", value); }
        }
        public bool bTangentRecalculationEveryFrame {
            get {return Main.GetGetBoolPropertyByName(this, "bTangentRecalculationEveryFrame"); }
            set {Main.SetGetBoolPropertyByName(this, "bTangentRecalculationEveryFrame", value); }
        }
        public bool bSpawnInitialParticle {
            get {return Main.GetGetBoolPropertyByName(this, "bSpawnInitialParticle"); }
            set {Main.SetGetBoolPropertyByName(this, "bSpawnInitialParticle", value); }
        }
        ///<summary>
        ///The 'render' axis for the trail (what axis the trail is stretched out on)
        ///        Trails_CameraUp - Traditional camera-facing trail.
        ///</summary>
        ///<remarks>
        ///Trails_SourceUp - Use the up axis of the source for each spawned particle.
        ///        Trails_WorldUp  - Use the world up axis.
        ///</remarks>
        public unsafe byte RenderAxis {
            get {return ParticleModuleTypeDataRibbon_ptr->RenderAxis;}
            set {ParticleModuleTypeDataRibbon_ptr->RenderAxis = value;}
        }
        ///<summary>The tangent scalar for spawning.</summary>
        ///<remarks>
        ///Angles between tangent A and B are mapped to [0.0f .. 1.0f]
        ///This is then multiplied by TangentTessellationScalar to give the number of particles to spawn
        ///</remarks>
        public unsafe float TangentSpawningScalar {
            get {return ParticleModuleTypeDataRibbon_ptr->TangentSpawningScalar;}
            set {ParticleModuleTypeDataRibbon_ptr->TangentSpawningScalar = value;}
        }
        public bool bRenderGeometry {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderGeometry"); }
            set {Main.SetGetBoolPropertyByName(this, "bRenderGeometry", value); }
        }
        public bool bRenderSpawnPoints {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderSpawnPoints"); }
            set {Main.SetGetBoolPropertyByName(this, "bRenderSpawnPoints", value); }
        }
        public bool bRenderTangents {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderTangents"); }
            set {Main.SetGetBoolPropertyByName(this, "bRenderTangents", value); }
        }
        public bool bRenderTessellation {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderTessellation"); }
            set {Main.SetGetBoolPropertyByName(this, "bRenderTessellation", value); }
        }
        ///<summary>The (estimated) covered distance to tile the 2nd UV set at.</summary>
        ///<remarks>If 0.0, a second UV set will not be passed in.</remarks>
        public unsafe float TilingDistance {
            get {return ParticleModuleTypeDataRibbon_ptr->TilingDistance;}
            set {ParticleModuleTypeDataRibbon_ptr->TilingDistance = value;}
        }
        ///<summary>The distance step size for tessellation.</summary>
        ///<remarks># Tessellation Points = TruncToInt((Distance Between Spawned Particles) / DistanceTessellationStepSize))</remarks>
        public unsafe float DistanceTessellationStepSize {
            get {return ParticleModuleTypeDataRibbon_ptr->DistanceTessellationStepSize;}
            set {ParticleModuleTypeDataRibbon_ptr->DistanceTessellationStepSize = value;}
        }
        public bool bEnableTangentDiffInterpScale {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableTangentDiffInterpScale"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableTangentDiffInterpScale", value); }
        }
        ///<summary>The tangent scalar for tessellation.</summary>
        ///<remarks>
        ///Angles between tangent A and B are mapped to [0.0f .. 1.0f]
        ///This is then multiplied by TangentTessellationScalar to give the number of points to tessellate
        ///</remarks>
        public unsafe float TangentTessellationScalar {
            get {return ParticleModuleTypeDataRibbon_ptr->TangentTessellationScalar;}
            set {ParticleModuleTypeDataRibbon_ptr->TangentTessellationScalar = value;}
        }
        static ParticleModuleTypeDataRibbon() {
            StaticClass = Main.GetClass("ParticleModuleTypeDataRibbon");
        }
        internal unsafe ParticleModuleTypeDataRibbon_fields* ParticleModuleTypeDataRibbon_ptr => (ParticleModuleTypeDataRibbon_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleTypeDataRibbon(IntPtr p) => UObject.Make<ParticleModuleTypeDataRibbon>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleTypeDataRibbon DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleTypeDataRibbon New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
