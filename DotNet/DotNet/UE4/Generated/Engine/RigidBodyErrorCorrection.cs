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
        ///<summary>Rigid body error correction data</summary>
        [StructLayout( LayoutKind.Explicit, Size=52 )]
        public unsafe struct RigidBodyErrorCorrection {
            [FieldOffset(0)] public float PingExtrapolation;

            [FieldOffset(4)] public float PingLimit;

            [FieldOffset(8)] public float ErrorPerLinearDifference;

            [FieldOffset(12)] public float ErrorPerAngularDifference;

            [FieldOffset(16)] public float MaxRestoredStateError;

            [FieldOffset(20)] public float MaxLinearHardSnapDistance;

            [FieldOffset(24)] public float PositionLerp;

            [FieldOffset(28)] public float AngleLerp;

            [FieldOffset(32)] public float LinearVelocityCoefficient;

            [FieldOffset(36)] public float AngularVelocityCoefficient;

            [FieldOffset(40)] public float ErrorAccumulationSeconds;

            [FieldOffset(44)] public float ErrorAccumulationDistanceSq;

            [FieldOffset(48)] public float ErrorAccumulationSimilarity;

        }
}
