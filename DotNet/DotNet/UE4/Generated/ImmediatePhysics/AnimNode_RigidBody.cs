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

namespace UE4.ImmediatePhysics{
        ///<summary>Controller that simulates physics based on the physics asset of the skeletal mesh component</summary>
        [StructLayout( LayoutKind.Explicit, Size=1520 )]
        public unsafe struct AnimNode_RigidBody {
            [FieldOffset(360)] 
            private IntPtr  OverridePhysicsAsset_field;
            ///<summary>Physics asset to use. If empty use the skeletal mesh's default physics asset</summary>
            public PhysicsAsset OverridePhysicsAsset {
                get {return OverridePhysicsAsset_field;}
                set {OverridePhysicsAsset_field = value;}
            }

            ///<summary>Override gravity</summary>
            [FieldOffset(368)] Vector OverrideWorldGravity;

            ///<summary>Applies a uniform external force in world space. This allows for easily faking inertia of movement while still simulating in component space for example</summary>
            [FieldOffset(380)] Vector ExternalForce;

            ///<summary>When using non-world-space sim, this controls how much of the components world-space acceleration is passed on to the local-space simulation.</summary>
            [FieldOffset(392)] Vector ComponentLinearAccScale;

            ///<summary>When using non-world-space sim, this applies a 'drag' to the bodies in the local space simulation, based on the components world-space velocity.</summary>
            [FieldOffset(404)] Vector ComponentLinearVelScale;

            ///<summary>When using non-world-space sim, this is an overall clamp on acceleration derived from ComponentLinearAccScale and ComponentLinearVelScale, to ensure it is not too large.</summary>
            [FieldOffset(416)] Vector ComponentAppliedLinearAccClamp;

            [FieldOffset(428)] public byte OverlapChannel;

            [FieldOffset(429)] public bool bEnableWorldGeometry;

            [FieldOffset(432)] byte SimulationSpace; //TODO: enum ESimulationSpace SimulationSpace

            ///<summary>Matters if SimulationSpace is BaseBone</summary>
            [FieldOffset(436)] BoneReference BaseBoneRef;

            [FieldOffset(460)] public bool bOverrideWorldGravity;

            [FieldOffset(464)] public float CachedBoundsScale;

            [FieldOffset(468)] public bool bTransferBoneVelocities;

            [FieldOffset(469)] public bool bFreezeIncomingPoseOnStart;

        }
}
