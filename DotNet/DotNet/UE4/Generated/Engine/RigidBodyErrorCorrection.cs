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
        [StructLayout( LayoutKind.Explicit, Size=44 )]
        public unsafe struct RigidBodyErrorCorrection {
            [FieldOffset(0)] public float PingExtrapolation;

            [FieldOffset(4)] public float ErrorPerLinearDifference;

            [FieldOffset(8)] public float ErrorPerAngularDifference;

            [FieldOffset(12)] public float MaxRestoredStateError;

            [FieldOffset(16)] public float PositionLerp;

            [FieldOffset(20)] public float AngleLerp;

            [FieldOffset(24)] public float LinearVelocityCoefficient;

            [FieldOffset(28)] public float AngularVelocityCoefficient;

            [FieldOffset(32)] public float ErrorAccumulationSeconds;

            [FieldOffset(36)] public float ErrorAccumulationDistanceSq;

            [FieldOffset(40)] public float ErrorAccumulationSimilarity;

        }
}
