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
        ///<summary>Input parameters to PredictProjectilePath functions.</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct PredictProjectilePathParams {
            ///<summary>Location of the start of the trace.</summary>
            [FieldOffset(0)] Vector StartLocation;

            ///<summary>Initial launch velocity at the start of the trace.</summary>
            [FieldOffset(12)] Vector LaunchVelocity;

            [FieldOffset(24)] public bool bTraceWithCollision;

            [FieldOffset(28)] public float ProjectileRadius;

            [FieldOffset(32)] public float MaxSimTime;

            [FieldOffset(36)] public bool bTraceWithChannel;

            [FieldOffset(37)] public byte TraceChannel;

            [FieldOffset(40)] byte ObjectTypes; //TODO: array TArray ObjectTypes

            [FieldOffset(56)] byte ActorsToIgnore; //TODO: array TArray ActorsToIgnore

            [FieldOffset(72)] public float SimFrequency;

            [FieldOffset(76)] public float OverrideGravityZ;

            [FieldOffset(80)] public byte DrawDebugType;

            [FieldOffset(84)] public float DrawDebugTime;

            [FieldOffset(88)] public bool bTraceComplex;

        }
}
