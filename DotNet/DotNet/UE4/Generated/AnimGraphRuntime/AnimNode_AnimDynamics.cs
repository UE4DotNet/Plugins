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

using UE4.Engine;

namespace UE4.AnimGraphRuntime{
        ///<summary>Anim Node Anim Dynamics</summary>
        [StructLayout( LayoutKind.Explicit, Size=992 )]
        public unsafe struct AnimNode_AnimDynamics {
            [FieldOffset(360)] byte SimulationSpace; //TODO: enum AnimPhysSimSpaceType SimulationSpace

            ///<summary>When in BoneRelative sim space, the simulation will use this bone as the origin</summary>
            [FieldOffset(364)] BoneReference RelativeSpaceBone;

            [FieldOffset(388)] public bool bChain;

            ///<summary>The bone to attach the physics body to, if bChain is true this is the top of the chain</summary>
            [FieldOffset(392)] BoneReference BoundBone;

            ///<summary>If bChain is true this is the bottom of the chain, otherwise ignored</summary>
            [FieldOffset(416)] BoneReference ChainEnd;

            ///<summary>Extents of the box to use for simulation</summary>
            [FieldOffset(440)] Vector BoxExtents;

            ///<summary>Vector relative to the body being simulated to attach the constraint to</summary>
            [FieldOffset(452)] Vector LocalJointOffset;

            [FieldOffset(464)] public float GravityScale;

            [FieldOffset(468)] public bool bLinearSpring;

            [FieldOffset(469)] public bool bAngularSpring;

            [FieldOffset(472)] public float LinearSpringConstant;

            [FieldOffset(476)] public float AngularSpringConstant;

            [FieldOffset(480)] public bool bEnableWind;

            [FieldOffset(481)] public bool bWindWasEnabled;

            [FieldOffset(484)] public float WindScale;

            [FieldOffset(488)] public bool bOverrideLinearDamping;

            [FieldOffset(492)] public float LinearDampingOverride;

            [FieldOffset(496)] public bool bOverrideAngularDamping;

            [FieldOffset(500)] public float AngularDampingOverride;

            [FieldOffset(504)] public bool bOverrideAngularBias;

            [FieldOffset(508)] public float AngularBiasOverride;

            [FieldOffset(512)] public bool bDoUpdate;

            [FieldOffset(513)] public bool bDoEval;

            [FieldOffset(516)] public int NumSolverIterationsPreUpdate;

            [FieldOffset(520)] public int NumSolverIterationsPostUpdate;

            ///<summary>Data describing the constraints we will apply to the body</summary>
            [FieldOffset(524)] AnimPhysConstraintSetup ConstraintSetup;

            [FieldOffset(616)] public bool bUsePlanarLimit;

            [FieldOffset(624)] byte PlanarLimits; //TODO: array TArray PlanarLimits

            [FieldOffset(640)] public bool bUseSphericalLimits;

            [FieldOffset(648)] byte SphericalLimits; //TODO: array TArray SphericalLimits

            [FieldOffset(664)] byte CollisionType; //TODO: enum AnimPhysCollisionType CollisionType

            [FieldOffset(668)] public float SphereCollisionRadius;

            ///<summary>An external force to apply to all bodies in the simulation when ticked, specified in world space</summary>
            [FieldOffset(672)] Vector ExternalForce;

        }
}
