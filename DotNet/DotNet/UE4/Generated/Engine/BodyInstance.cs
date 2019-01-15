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
        [StructLayout( LayoutKind.Explicit, Size=384 )]
        public unsafe struct BodyInstance {
            [FieldOffset(10)] public byte ObjectType;

            [FieldOffset(12)] public byte CollisionEnabled;

            [FieldOffset(14)] byte SleepFamily; //TODO: enum ESleepFamily SleepFamily

            [FieldOffset(15)] public byte DOFMode;

            [FieldOffset(16)] public bool bUseCCD;

            [FieldOffset(16)] public bool bNotifyRigidBodyCollision;

            [FieldOffset(16)] public bool bSimulatePhysics;

            [FieldOffset(16)] public bool bOverrideMass;

            [FieldOffset(16)] public bool bEnableGravity;

            [FieldOffset(16)] public bool bAutoWeld;

            [FieldOffset(16)] public bool bStartAwake;

            [FieldOffset(17)] public bool bGenerateWakeEvents;

            [FieldOffset(17)] public bool bUpdateMassWhenScaleChanges;

            [FieldOffset(17)] public bool bLockTranslation;

            [FieldOffset(17)] public bool bLockRotation;

            [FieldOffset(17)] public bool bLockXTranslation;

            [FieldOffset(17)] public bool bLockYTranslation;

            [FieldOffset(17)] public bool bLockZTranslation;

            [FieldOffset(17)] public bool bLockXRotation;

            [FieldOffset(18)] public bool bLockYRotation;

            [FieldOffset(18)] public bool bLockZRotation;

            [FieldOffset(18)] public bool bOverrideMaxAngularVelocity;

            [FieldOffset(18)] public bool bUseAsyncScene;

            [FieldOffset(18)] public bool bOverrideMaxDepenetrationVelocity;

            [FieldOffset(18)] public bool bOverrideWalkableSlopeOnInstance;

            [FieldOffset(19)] public bool bInterpolateWhenSubStepping;

            [FieldOffset(64)] public Name CollisionProfileName;

            ///<summary>Custom Channels for Responses</summary>
            [FieldOffset(80)] CollisionResponse CollisionResponses;

            [FieldOffset(128)] public float MaxDepenetrationVelocity;

            [FieldOffset(132)] public float MassInKgOverride;

            [FieldOffset(144)] public float LinearDamping;

            [FieldOffset(148)] public float AngularDamping;

            ///<summary>Locks physical movement along a custom plane for a given normal.</summary>
            [FieldOffset(152)] Vector CustomDOFPlaneNormal;

            ///<summary>User specified offset for the center of mass of this object, from the calculated location</summary>
            [FieldOffset(164)] Vector COMNudge;

            [FieldOffset(176)] public float MassScale;

            ///<summary>Per-instance scaling of inertia (bigger number means  it'll be harder to rotate)</summary>
            [FieldOffset(180)] Vector InertiaTensorScale;

            ///<summary>Custom walkable slope override setting for this instance.</summary>
            ///<remarks>
            ///@see GetWalkableSlopeOverride(), SetWalkableSlopeOverride()
            ///</remarks>
            [FieldOffset(208)] WalkableSlopeOverride WalkableSlopeOverride;

            [FieldOffset(224)] 
            private IntPtr  PhysMaterialOverride_field;
            ///<summary>Allows you to override the PhysicalMaterial to use for simple collision on this body.</summary>
            public PhysicalMaterial PhysMaterialOverride {
                get {return PhysMaterialOverride_field;}
            }

            [FieldOffset(232)] public float MaxAngularVelocity;

            [FieldOffset(236)] public float CustomSleepThresholdMultiplier;

            [FieldOffset(240)] public float StabilizationThresholdMultiplier;

            [FieldOffset(244)] public float PhysicsBlendWeight;

            [FieldOffset(248)] public int PositionSolverIterationCount;

            [FieldOffset(252)] public int VelocitySolverIterationCount;

        }
}
