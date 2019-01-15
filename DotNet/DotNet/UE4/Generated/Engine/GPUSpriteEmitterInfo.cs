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


namespace UE4.Engine{
        ///<summary>The data needed by the runtime to simulate sprites.</summary>
        [StructLayout( LayoutKind.Explicit, Size=704 )]
        public unsafe struct GPUSpriteEmitterInfo {
            [FieldOffset(0)] 
            private IntPtr  RequiredModule_field;
            ///<summary>The required module. Needed for now, but should be divorced from the runtime.</summary>
            public ParticleModuleRequired RequiredModule {
                get {return RequiredModule_field;}
                set {RequiredModule_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  SpawnModule_field;
            ///<summary>The spawn module. Needed for now, but should be divorced from the runtime.</summary>
            public ParticleModuleSpawn SpawnModule {
                get {return SpawnModule_field;}
                set {SpawnModule_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  SpawnPerUnitModule_field;
            ///<summary>The spawn-per-unit module.</summary>
            public ParticleModuleSpawnPerUnit SpawnPerUnitModule {
                get {return SpawnPerUnitModule_field;}
                set {SpawnPerUnitModule_field = value;}
            }

            [FieldOffset(24)] byte SpawnModules; //TODO: array TArray SpawnModules

            ///<summary>Local vector field info.</summary>
            [FieldOffset(48)] GPUSpriteLocalVectorFieldInfo LocalVectorField;

            ///<summary>Per-particle vector field scale.</summary>
            [FieldOffset(160)] FloatDistribution VectorFieldScale;

            ///<summary>Per-particle drag coefficient.</summary>
            [FieldOffset(200)] FloatDistribution DragCoefficient;

            ///<summary>Point attractor strength over time.</summary>
            [FieldOffset(240)] FloatDistribution PointAttractorStrength;

            ///<summary>Damping factor applied to particle collisions.</summary>
            [FieldOffset(280)] FloatDistribution Resilience;

            ///<summary>Constant acceleration to apply to particles.</summary>
            [FieldOffset(320)] Vector ConstantAcceleration;

            ///<summary>Point attractor position.</summary>
            [FieldOffset(332)] Vector PointAttractorPosition;

            [FieldOffset(344)] public float PointAttractorRadiusSq;

            ///<summary>Amount by which to offset particles when they are spawned.</summary>
            [FieldOffset(348)] Vector OrbitOffsetBase;

            ///<summary>Orbit Offset Range</summary>
            [FieldOffset(360)] Vector OrbitOffsetRange;

            ///<summary>One over the maximum size of a sprite particle.</summary>
            [FieldOffset(372)] Vector2D InvMaxSize;

            [FieldOffset(380)] public float InvRotationRateScale;

            [FieldOffset(384)] public float MaxLifetime;

            [FieldOffset(388)] public int MaxParticleCount;

            [FieldOffset(392)] public byte ScreenAlignment;

            [FieldOffset(393)] public byte LockAxisFlag;

            [FieldOffset(396)] public bool bEnableCollision;

            [FieldOffset(400)] public byte CollisionMode;

            [FieldOffset(404)] public bool bRemoveHMDRoll;

            [FieldOffset(408)] public float MinFacingCameraBlendDistance;

            [FieldOffset(412)] public float MaxFacingCameraBlendDistance;

            ///<summary>Dynamic color scale from the ColorOverLife module.</summary>
            [FieldOffset(416)] RawDistributionVector DynamicColor;

            ///<summary>Dynamic alpha scale from the ColorOverLife module.</summary>
            [FieldOffset(496)] RawDistributionFloat DynamicAlpha;

            ///<summary>Dynamic color scale from the ColorScaleOverLife module.</summary>
            [FieldOffset(552)] RawDistributionVector DynamicColorScale;

            ///<summary>Dynamic alpha scale from the ColorScaleOverLife module.</summary>
            [FieldOffset(632)] RawDistributionFloat DynamicAlphaScale;

        }
}
