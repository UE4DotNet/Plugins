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
        [StructLayout( LayoutKind.Explicit, Size=1008 )]
        public unsafe struct AnimNode_AnimDynamics {
            [FieldOffset(336)] byte SimulationSpace; //TODO: enum AnimPhysSimSpaceType SimulationSpace

            ///<summary>When in BoneRelative sim space, the simulation will use this bone as the origin</summary>
            [FieldOffset(340)] BoneReference RelativeSpaceBone;

            [FieldOffset(364)] public bool bChain;

            ///<summary>The bone to attach the physics body to, if bChain is true this is the top of the chain</summary>
            [FieldOffset(368)] BoneReference BoundBone;

            ///<summary>If bChain is true this is the bottom of the chain, otherwise ignored</summary>
            [FieldOffset(392)] BoneReference ChainEnd;

            ///<summary>Extents of the box to use for simulation</summary>
            [FieldOffset(416)] Vector BoxExtents;

            ///<summary>Vector relative to the body being simulated to attach the constraint to</summary>
            [FieldOffset(428)] Vector LocalJointOffset;

            [FieldOffset(440)] public float GravityScale;

            ///<summary>Gravity Override Value</summary>
            [FieldOffset(444)] Vector GravityOverride;

            [FieldOffset(456)] public bool bUseGravityOverride;

            [FieldOffset(457)] public bool bLinearSpring;

            [FieldOffset(458)] public bool bAngularSpring;

            [FieldOffset(460)] public float LinearSpringConstant;

            [FieldOffset(464)] public float AngularSpringConstant;

            [FieldOffset(468)] public bool bEnableWind;

            [FieldOffset(469)] public bool bWindWasEnabled;

            [FieldOffset(472)] public float WindScale;

            ///<summary>When using non-world-space sim, this controls how much of the components world-space acceleration is passed on to the local-space simulation.</summary>
            [FieldOffset(476)] Vector ComponentLinearAccScale;

            ///<summary>When using non-world-space sim, this applies a 'drag' to the bodies in the local space simulation, based on the components world-space velocity.</summary>
            [FieldOffset(488)] Vector ComponentLinearVelScale;

            ///<summary>When using non-world-space sim, this is an overall clamp on acceleration derived from ComponentLinearAccScale and ComponentLinearVelScale, to ensure it is not too large.</summary>
            [FieldOffset(500)] Vector ComponentAppliedLinearAccClamp;

            [FieldOffset(512)] public bool bOverrideLinearDamping;

            [FieldOffset(516)] public float LinearDampingOverride;

            [FieldOffset(520)] public bool bOverrideAngularDamping;

            [FieldOffset(524)] public float AngularDampingOverride;

            [FieldOffset(528)] public bool bOverrideAngularBias;

            [FieldOffset(532)] public float AngularBiasOverride;

            [FieldOffset(536)] public bool bDoUpdate;

            [FieldOffset(537)] public bool bDoEval;

            [FieldOffset(540)] public int NumSolverIterationsPreUpdate;

            [FieldOffset(544)] public int NumSolverIterationsPostUpdate;

            ///<summary>Data describing the constraints we will apply to the body</summary>
            [FieldOffset(548)] AnimPhysConstraintSetup ConstraintSetup;

            [FieldOffset(640)] public bool bUsePlanarLimit;

            [FieldOffset(648)] byte PlanarLimits; //TODO: array TArray PlanarLimits

            [FieldOffset(664)] public bool bUseSphericalLimits;

            [FieldOffset(672)] byte SphericalLimits; //TODO: array TArray SphericalLimits

            [FieldOffset(688)] byte CollisionType; //TODO: enum AnimPhysCollisionType CollisionType

            [FieldOffset(692)] public float SphereCollisionRadius;

            ///<summary>An external force to apply to all bodies in the simulation when ticked, specified in world space</summary>
            [FieldOffset(696)] Vector ExternalForce;

        }
}
