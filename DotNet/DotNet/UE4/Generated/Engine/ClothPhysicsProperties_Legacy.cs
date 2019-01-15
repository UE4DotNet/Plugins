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
        ///<summary>Legacy object for back-compat loading, no longer used by clothing system</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct ClothPhysicsProperties_Legacy {
            [FieldOffset(0)] public float VerticalResistance;

            [FieldOffset(4)] public float HorizontalResistance;

            [FieldOffset(8)] public float BendResistance;

            [FieldOffset(12)] public float ShearResistance;

            [FieldOffset(16)] public float Friction;

            [FieldOffset(20)] public float Damping;

            [FieldOffset(24)] public float TetherStiffness;

            [FieldOffset(28)] public float TetherLimit;

            [FieldOffset(32)] public float Drag;

            [FieldOffset(36)] public float StiffnessFrequency;

            [FieldOffset(40)] public float GravityScale;

            [FieldOffset(44)] public float MassScale;

            [FieldOffset(48)] public float InertiaBlend;

            [FieldOffset(52)] public float SelfCollisionThickness;

            [FieldOffset(56)] public float SelfCollisionSquashScale;

            [FieldOffset(60)] public float SelfCollisionStiffness;

            [FieldOffset(64)] public float SolverFrequency;

            [FieldOffset(68)] public float FiberCompression;

            [FieldOffset(72)] public float FiberExpansion;

            [FieldOffset(76)] public float FiberResistance;

        }
}
