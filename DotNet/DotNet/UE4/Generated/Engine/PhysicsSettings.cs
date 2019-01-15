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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Default physics settings.</summary>
    public unsafe partial class PhysicsSettings : DeveloperSettings  {
        ///<summary>Default gravity.</summary>
        public unsafe float DefaultGravityZ {
            get {return PhysicsSettings_ptr->DefaultGravityZ;}
            set {PhysicsSettings_ptr->DefaultGravityZ = value;}
        }
        ///<summary>Default terminal velocity for Physics Volumes.</summary>
        public unsafe float DefaultTerminalVelocity {
            get {return PhysicsSettings_ptr->DefaultTerminalVelocity;}
            set {PhysicsSettings_ptr->DefaultTerminalVelocity = value;}
        }
        ///<summary>Default fluid friction for Physics Volumes.</summary>
        public unsafe float DefaultFluidFriction {
            get {return PhysicsSettings_ptr->DefaultFluidFriction;}
            set {PhysicsSettings_ptr->DefaultFluidFriction = value;}
        }
        ///<summary>Amount of memory to reserve for PhysX simulate(), this is per pxscene and will be rounded up to the next 16K boundary</summary>
        public unsafe int SimulateScratchMemorySize {
            get {return PhysicsSettings_ptr->SimulateScratchMemorySize;}
            set {PhysicsSettings_ptr->SimulateScratchMemorySize = value;}
        }
        ///<summary>Threshold for ragdoll bodies above which they will be added to an aggregate before being added to the scene</summary>
        public unsafe int RagdollAggregateThreshold {
            get {return PhysicsSettings_ptr->RagdollAggregateThreshold;}
            set {PhysicsSettings_ptr->RagdollAggregateThreshold = value;}
        }
        ///<summary>Triangles from triangle meshes (BSP) with an area less than or equal to this value will be removed from physics collision data. Set to less than 0 to disable.</summary>
        public unsafe float TriangleMeshTriangleMinAreaThreshold {
            get {return PhysicsSettings_ptr->TriangleMeshTriangleMinAreaThreshold;}
            set {PhysicsSettings_ptr->TriangleMeshTriangleMinAreaThreshold = value;}
        }
        public bool bEnableAsyncScene {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableAsyncScene"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableAsyncScene", value); }
        }
        public bool bEnableShapeSharing {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableShapeSharing"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableShapeSharing", value); }
        }
        public bool bEnablePCM {
            get {return Main.GetGetBoolPropertyByName(this, "bEnablePCM"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnablePCM", value); }
        }
        public bool bEnableStabilization {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableStabilization"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableStabilization", value); }
        }
        public bool bWarnMissingLocks {
            get {return Main.GetGetBoolPropertyByName(this, "bWarnMissingLocks"); }
            set {Main.SetGetBoolPropertyByName(this, "bWarnMissingLocks", value); }
        }
        public bool bEnable2DPhysics {
            get {return Main.GetGetBoolPropertyByName(this, "bEnable2DPhysics"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnable2DPhysics", value); }
        }
        ///<summary>Error correction data for replicating simulated physics (rigid bodies)</summary>
        public unsafe RigidBodyErrorCorrection PhysicErrorCorrection {
            get {return PhysicsSettings_ptr->PhysicErrorCorrection;}
            set {PhysicsSettings_ptr->PhysicErrorCorrection = value;}
        }
        ///<summary>Useful for constraining all objects in the world, for example if you are making a 2D game using 3D environments.</summary>
        public unsafe byte DefaultDegreesOfFreedom {
            get {return PhysicsSettings_ptr->DefaultDegreesOfFreedom;}
            set {PhysicsSettings_ptr->DefaultDegreesOfFreedom = value;}
        }
        ///<summary>Minimum relative velocity required for an object to bounce. A typical value for simulation stability is about 0.2 * gravity</summary>
        public unsafe float BounceThresholdVelocity {
            get {return PhysicsSettings_ptr->BounceThresholdVelocity;}
            set {PhysicsSettings_ptr->BounceThresholdVelocity = value;}
        }
        ///<summary>Friction combine mode, controls how friction is computed for multiple materials.</summary>
        public unsafe byte FrictionCombineMode {
            get {return PhysicsSettings_ptr->FrictionCombineMode;}
            set {PhysicsSettings_ptr->FrictionCombineMode = value;}
        }
        ///<summary>Restitution combine mode, controls how restitution is computed for multiple materials.</summary>
        public unsafe byte RestitutionCombineMode {
            get {return PhysicsSettings_ptr->RestitutionCombineMode;}
            set {PhysicsSettings_ptr->RestitutionCombineMode = value;}
        }
        ///<summary>Max angular velocity that a simulated object can achieve.</summary>
        public unsafe float MaxAngularVelocity {
            get {return PhysicsSettings_ptr->MaxAngularVelocity;}
            set {PhysicsSettings_ptr->MaxAngularVelocity = value;}
        }
        ///<summary>Max velocity which may be used to depenetrate simulated physics objects. 0 means no maximum.</summary>
        public unsafe float MaxDepenetrationVelocity {
            get {return PhysicsSettings_ptr->MaxDepenetrationVelocity;}
            set {PhysicsSettings_ptr->MaxDepenetrationVelocity = value;}
        }
        ///<summary>Contact offset multiplier. When creating a physics shape we look at its bounding volume and multiply its minimum value by this multiplier. A bigger number will generate contact points earlier which results in higher stability at the cost of performance.</summary>
        public unsafe float ContactOffsetMultiplier {
            get {return PhysicsSettings_ptr->ContactOffsetMultiplier;}
            set {PhysicsSettings_ptr->ContactOffsetMultiplier = value;}
        }
        ///<summary>Min Contact offset.</summary>
        public unsafe float MinContactOffset {
            get {return PhysicsSettings_ptr->MinContactOffset;}
            set {PhysicsSettings_ptr->MinContactOffset = value;}
        }
        ///<summary>Max Contact offset.</summary>
        public unsafe float MaxContactOffset {
            get {return PhysicsSettings_ptr->MaxContactOffset;}
            set {PhysicsSettings_ptr->MaxContactOffset = value;}
        }
        public bool bSimulateSkeletalMeshOnDedicatedServer {
            get {return Main.GetGetBoolPropertyByName(this, "bSimulateSkeletalMeshOnDedicatedServer"); }
            set {Main.SetGetBoolPropertyByName(this, "bSimulateSkeletalMeshOnDedicatedServer", value); }
        }
        ///<summary>Determines the default physics shape complexity.</summary>
        public unsafe byte DefaultShapeComplexity {
            get {return PhysicsSettings_ptr->DefaultShapeComplexity;}
            set {PhysicsSettings_ptr->DefaultShapeComplexity = value;}
        }
        public bool bSuppressFaceRemapTable {
            get {return Main.GetGetBoolPropertyByName(this, "bSuppressFaceRemapTable"); }
            set {Main.SetGetBoolPropertyByName(this, "bSuppressFaceRemapTable", value); }
        }
        public bool bSupportUVFromHitResults {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportUVFromHitResults"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportUVFromHitResults", value); }
        }
        public bool bDisableActiveActors {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableActiveActors"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableActiveActors", value); }
        }
        public bool bDisableKinematicStaticPairs {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableKinematicStaticPairs"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableKinematicStaticPairs", value); }
        }
        public bool bDisableKinematicKinematicPairs {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableKinematicKinematicPairs"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableKinematicKinematicPairs", value); }
        }
        public bool bDisableCCD {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableCCD"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableCCD", value); }
        }
        public bool bEnableEnhancedDeterminism {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableEnhancedDeterminism"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableEnhancedDeterminism", value); }
        }
        ///<summary>Max Physics Delta Time to be clamped.</summary>
        public unsafe float MaxPhysicsDeltaTime {
            get {return PhysicsSettings_ptr->MaxPhysicsDeltaTime;}
            set {PhysicsSettings_ptr->MaxPhysicsDeltaTime = value;}
        }
        public bool bSubstepping {
            get {return Main.GetGetBoolPropertyByName(this, "bSubstepping"); }
            set {Main.SetGetBoolPropertyByName(this, "bSubstepping", value); }
        }
        public bool bSubsteppingAsync {
            get {return Main.GetGetBoolPropertyByName(this, "bSubsteppingAsync"); }
            set {Main.SetGetBoolPropertyByName(this, "bSubsteppingAsync", value); }
        }
        ///<summary>Max delta time (in seconds) for an individual simulation substep.</summary>
        public unsafe float MaxSubstepDeltaTime {
            get {return PhysicsSettings_ptr->MaxSubstepDeltaTime;}
            set {PhysicsSettings_ptr->MaxSubstepDeltaTime = value;}
        }
        ///<summary>Max number of substeps for physics simulation.</summary>
        public unsafe int MaxSubsteps {
            get {return PhysicsSettings_ptr->MaxSubsteps;}
            set {PhysicsSettings_ptr->MaxSubsteps = value;}
        }
        ///<summary>Physics delta time smoothing factor for sync scene.</summary>
        public unsafe float SyncSceneSmoothingFactor {
            get {return PhysicsSettings_ptr->SyncSceneSmoothingFactor;}
            set {PhysicsSettings_ptr->SyncSceneSmoothingFactor = value;}
        }
        ///<summary>Physics delta time smoothing factor for async scene.</summary>
        public unsafe float AsyncSceneSmoothingFactor {
            get {return PhysicsSettings_ptr->AsyncSceneSmoothingFactor;}
            set {PhysicsSettings_ptr->AsyncSceneSmoothingFactor = value;}
        }
        ///<summary>Physics delta time initial average.</summary>
        public unsafe float InitialAverageFrameRate {
            get {return PhysicsSettings_ptr->InitialAverageFrameRate;}
            set {PhysicsSettings_ptr->InitialAverageFrameRate = value;}
        }
        ///<summary>The number of frames it takes to rebuild the PhysX scene query AABB tree. The bigger the number, the smaller fetchResults takes per frame, but the more the tree deteriorates until a new tree is built</summary>
        public unsafe int PhysXTreeRebuildRate {
            get {return PhysicsSettings_ptr->PhysXTreeRebuildRate;}
            set {PhysicsSettings_ptr->PhysXTreeRebuildRate = value;}
        }
         //TODO: array not UObject TArray PhysicalSurfaces
        ///<summary>If we want to Enable MPB or not globally. This is then overridden by project settings if not enabled. *</summary>
        public unsafe BroadphaseSettings DefaultBroadphaseSettings {
            get {return PhysicsSettings_ptr->DefaultBroadphaseSettings;}
            set {PhysicsSettings_ptr->DefaultBroadphaseSettings = value;}
        }
        static PhysicsSettings() {
            StaticClass = Main.GetClass("PhysicsSettings");
        }
        internal unsafe PhysicsSettings_fields* PhysicsSettings_ptr => (PhysicsSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsSettings(IntPtr p) => UObject.Make<PhysicsSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
