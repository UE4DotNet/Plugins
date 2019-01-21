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


namespace UE4.ClothingSystemRuntime{
        ///<summary>Holds initial, asset level config for clothing actors.</summary>
        [StructLayout( LayoutKind.Explicit, Size=212 )]
        public unsafe struct ClothConfig {
            [FieldOffset(0)] byte WindMethod; //TODO: enum EClothingWindMethod WindMethod

            ///<summary>Constraint data for vertical constraints</summary>
            [FieldOffset(4)] ClothConstraintSetup VerticalConstraintConfig;

            ///<summary>Constraint data for horizontal constraints</summary>
            [FieldOffset(20)] ClothConstraintSetup HorizontalConstraintConfig;

            ///<summary>Constraint data for bend constraints</summary>
            [FieldOffset(36)] ClothConstraintSetup BendConstraintConfig;

            ///<summary>Constraint data for shear constraints</summary>
            [FieldOffset(52)] ClothConstraintSetup ShearConstraintConfig;

            [FieldOffset(68)] public float SelfCollisionRadius;

            [FieldOffset(72)] public float SelfCollisionStiffness;

            [FieldOffset(76)] public float SelfCollisionCullScale;

            ///<summary>Damping of particle motion per-axis</summary>
            [FieldOffset(80)] Vector Damping;

            [FieldOffset(92)] public float Friction;

            [FieldOffset(96)] public float WindDragCoefficient;

            [FieldOffset(100)] public float WindLiftCoefficient;

            ///<summary>Drag applied to linear particle movement per-axis</summary>
            [FieldOffset(104)] Vector LinearDrag;

            ///<summary>Drag applied to angular particle movement, higher values should limit material bending (per-axis)</summary>
            [FieldOffset(116)] Vector AngularDrag;

            ///<summary>Scale for linear particle inertia, how much movement should translate to linear motion (per-axis)</summary>
            [FieldOffset(128)] Vector LinearInertiaScale;

            ///<summary>Scale for angular particle inertia, how much movement should translate to angular motion (per-axis)</summary>
            [FieldOffset(140)] Vector AngularInertiaScale;

            ///<summary>Scale for centrifugal particle inertia, how much movement should translate to angular motion (per-axis)</summary>
            [FieldOffset(152)] Vector CentrifugalInertiaScale;

            [FieldOffset(164)] public float SolverFrequency;

            [FieldOffset(168)] public float StiffnessFrequency;

            [FieldOffset(172)] public float GravityScale;

            ///<summary>Direct gravity override value</summary>
            [FieldOffset(176)] Vector GravityOverride;

            [FieldOffset(188)] public bool bUseGravityOverride;

            [FieldOffset(192)] public float TetherStiffness;

            [FieldOffset(196)] public float TetherLimit;

            [FieldOffset(200)] public float CollisionThickness;

            [FieldOffset(204)] public float AnimDriveSpringStiffness;

            [FieldOffset(208)] public float AnimDriveDamperStiffness;

        }
}
