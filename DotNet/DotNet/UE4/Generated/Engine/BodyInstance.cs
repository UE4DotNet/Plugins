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
        ///<summary>Container for a physics representation of an object</summary>
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        public unsafe struct BodyInstance {
            [FieldOffset(6)] public byte ObjectType;

            [FieldOffset(8)] public byte CollisionEnabled;

            [FieldOffset(10)] byte SleepFamily; //TODO: enum ESleepFamily SleepFamily

            [FieldOffset(11)] public byte DOFMode;

            [FieldOffset(12)] public bool bUseCCD;

            [FieldOffset(12)] public bool bNotifyRigidBodyCollision;

            [FieldOffset(12)] public bool bSimulatePhysics;

            [FieldOffset(12)] public bool bOverrideMass;

            [FieldOffset(12)] public bool bEnableGravity;

            [FieldOffset(12)] public bool bAutoWeld;

            [FieldOffset(12)] public bool bStartAwake;

            [FieldOffset(13)] public bool bGenerateWakeEvents;

            [FieldOffset(13)] public bool bUpdateMassWhenScaleChanges;

            [FieldOffset(13)] public bool bLockTranslation;

            [FieldOffset(13)] public bool bLockRotation;

            [FieldOffset(13)] public bool bLockXTranslation;

            [FieldOffset(13)] public bool bLockYTranslation;

            [FieldOffset(13)] public bool bLockZTranslation;

            [FieldOffset(13)] public bool bLockXRotation;

            [FieldOffset(14)] public bool bLockYRotation;

            [FieldOffset(14)] public bool bLockZRotation;

            [FieldOffset(14)] public bool bOverrideMaxAngularVelocity;

            [FieldOffset(14)] public bool bUseAsyncScene;

            [FieldOffset(14)] public bool bOverrideMaxDepenetrationVelocity;

            [FieldOffset(14)] public bool bOverrideWalkableSlopeOnInstance;

            [FieldOffset(15)] public bool bInterpolateWhenSubStepping;

            [FieldOffset(60)] public Name CollisionProfileName;

            ///<summary>Custom Channels for Responses</summary>
            [FieldOffset(72)] CollisionResponse CollisionResponses;

            [FieldOffset(120)] public float MaxDepenetrationVelocity;

            [FieldOffset(124)] public float MassInKgOverride;

            [FieldOffset(136)] public float LinearDamping;

            [FieldOffset(140)] public float AngularDamping;

            ///<summary>Locks physical movement along a custom plane for a given normal.</summary>
            [FieldOffset(144)] Vector CustomDOFPlaneNormal;

            ///<summary>User specified offset for the center of mass of this object, from the calculated location</summary>
            [FieldOffset(156)] Vector COMNudge;

            [FieldOffset(168)] public float MassScale;

            ///<summary>Per-instance scaling of inertia (bigger number means  it'll be harder to rotate)</summary>
            [FieldOffset(172)] Vector InertiaTensorScale;

            ///<summary>Custom walkable slope override setting for this instance.</summary>
            ///<remarks>
            ///@see GetWalkableSlopeOverride(), SetWalkableSlopeOverride()
            ///</remarks>
            [FieldOffset(200)] WalkableSlopeOverride WalkableSlopeOverride;

            [FieldOffset(216)] 
            private IntPtr  PhysMaterialOverride_field;
            ///<summary>Allows you to override the PhysicalMaterial to use for simple collision on this body.</summary>
            public PhysicalMaterial PhysMaterialOverride {
                get {return PhysMaterialOverride_field;}
            }

            [FieldOffset(224)] public float MaxAngularVelocity;

            [FieldOffset(228)] public float CustomSleepThresholdMultiplier;

            [FieldOffset(232)] public float StabilizationThresholdMultiplier;

            [FieldOffset(236)] public float PhysicsBlendWeight;

            [FieldOffset(240)] public int PositionSolverIterationCount;

            [FieldOffset(244)] public int VelocitySolverIterationCount;

        }
}
