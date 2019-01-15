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
        ///<summary>Stores info on the type of motor that will be used for a given bone</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct PhysicalAnimationData {
            [FieldOffset(0)] public Name BodyName;

            [FieldOffset(12)] public bool bIsLocalSimulation;

            [FieldOffset(16)] public float OrientationStrength;

            [FieldOffset(20)] public float AngularVelocityStrength;

            [FieldOffset(24)] public float PositionStrength;

            [FieldOffset(28)] public float VelocityStrength;

            [FieldOffset(32)] public float MaxLinearForce;

            [FieldOffset(36)] public float MaxAngularForce;

        }
}
