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
using UE4.ClothingSystemRuntimeInterface;

namespace UE4.Engine {
    ///<summary>SkeletalMeshComponent is used to create an instance of an animated SkeletalMesh asset.</summary>
    ///<remarks>
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Content/Types/SkeletalMeshes/
    ///@see USkeletalMesh
    ///</remarks>
    public unsafe partial class SkeletalMeshComponent : SkinnedMeshComponent  {

        ///<summary>Accumulate AddPhysicsBlendWeight to physics blendweight for all of the bones below passed in bone to be simulated</summary>
        public void AccumulateAllBodiesBelowPhysicsBlendWeight(Name InBoneName, float AddPhysicsBlendWeight, bool bSkipCustomPhysicsType)  => 
            SkeletalMeshComponent_methods.AccumulateAllBodiesBelowPhysicsBlendWeight_method.Invoke(ObjPointer, InBoneName, AddPhysicsBlendWeight, bSkipCustomPhysicsType);

        ///<summary>Add a force to all rigid bodies below.</summary>
        ///<remarks>
        ///This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force.
        ///
        ///@param  Force            Force vector to apply. Magnitude indicates strength of force.
        ///@param  BoneName         If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
        ///@param  bAccelChange If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect).
        ///@param  bIncludeSelf If false, Force is only applied to bodies below but not given bone name.
        ///</remarks>
        public void AddForceToAllBodiesBelow(Vector Force, Name BoneName, bool bAccelChange, bool bIncludeSelf)  => 
            SkeletalMeshComponent_methods.AddForceToAllBodiesBelow_method.Invoke(ObjPointer, Force, BoneName, bAccelChange, bIncludeSelf);

        ///<summary>Add impulse to all single rigid bodies below.</summary>
        ///<remarks>
        ///Good for one time instant burst.
        ///
        ///@param  Impulse         Magnitude and direction of impulse to apply.
        ///@param  BoneName        If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body.
        ///@param  bVelChange      If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect).
        ///@param bIncludeSelf If false, Force is only applied to bodies below but not given bone name.
        ///</remarks>
        public void AddImpulseToAllBodiesBelow(Vector Impulse, Name BoneName, bool bVelChange, bool bIncludeSelf)  => 
            SkeletalMeshComponent_methods.AddImpulseToAllBodiesBelow_method.Invoke(ObjPointer, Impulse, BoneName, bVelChange, bIncludeSelf);

        ///<summary>Allow Anim Curve Evaluation</summary>
        public void AllowAnimCurveEvaluation(Name NameOfCurve, bool bAllow)  => 
            SkeletalMeshComponent_methods.AllowAnimCurveEvaluation_method.Invoke(ObjPointer, NameOfCurve, bAllow);

        ///<summary>
        ///If this component has a valid MasterPoseComponent then this function makes cloth items on the slave component
        ///take the transforms of the cloth items on the master component instead of simulating separately.
        ///</summary>
        ///<remarks>
        ///@Note This will FORCE any cloth actor on the master component to simulate in local space. Also
        ///The meshes used in the components must be identical for the cloth to bind correctly
        ///</remarks>
        public void BindClothToMasterPoseComponent()  => 
            SkeletalMeshComponent_methods.BindClothToMasterPoseComponent_method.Invoke(ObjPointer);

        ///<summary>Break a constraint off a Gore mesh.</summary>
        ///<remarks>
        ///@param       Impulse vector of impulse
        ///@param       HitLocation     location of the hit
        ///@param       InBoneName      Name of bone to break constraint for
        ///</remarks>
        public void BreakConstraint(Vector Impulse, Vector HitLocation, Name InBoneName)  => 
            SkeletalMeshComponent_methods.BreakConstraint_method.Invoke(ObjPointer, Impulse, HitLocation, InBoneName);

        ///<summary>Clear all Morph Target that are set to this mesh</summary>
        public void ClearMorphTargets()  => 
            SkeletalMeshComponent_methods.ClearMorphTargets_method.Invoke(ObjPointer);

        ///<summary>
        ///Find Constraint Name from index
        ///@
        ///</summary>
        ///<remarks>
        ///param       ConstraintIndex Index of constraint to look for
        ///@return      Constraint Joint Name
        ///</remarks>
        public Name FindConstraintBoneName(int ConstraintIndex)  => 
            SkeletalMeshComponent_methods.FindConstraintBoneName_method.Invoke(ObjPointer, ConstraintIndex);

        ///<summary>
        ///Used to indicate we should force 'teleport' during the next call to UpdateClothState,
        ///This will transform positions and velocities and thus keep the simulation state, just translate it to a new pose.
        ///</summary>
        public void ForceClothNextUpdateTeleport()  => 
            SkeletalMeshComponent_methods.ForceClothNextUpdateTeleport_method.Invoke(ObjPointer);

        ///<summary>Used to indicate we should force 'teleport and reset' during the next call to UpdateClothState.</summary>
        ///<remarks>This can be used to reset it from a bad state or by a teleport where the old state is not important anymore.</remarks>
        public void ForceClothNextUpdateTeleportAndReset()  => 
            SkeletalMeshComponent_methods.ForceClothNextUpdateTeleportAndReset_method.Invoke(ObjPointer);

        ///<summary>Get Allowed Anim Curve Evaluate</summary>
        public bool GetAllowedAnimCurveEvaluate()  => 
            SkeletalMeshComponent_methods.GetAllowedAnimCurveEvaluate_method.Invoke(ObjPointer);

        ///<summary>Get Animation Mode</summary>
        public byte GetAnimationMode()  => 
            SkeletalMeshComponent_methods.GetAnimationMode_method.Invoke(ObjPointer);

        ///<summary>Returns the animation instance that is driving the class (if available).</summary>
        ///<remarks>
        ///This is typically an instance of
        ///the class set as AnimBlueprintGeneratedClass (generated by an animation blueprint)
        ///Since this instance is transient, it is not safe to be used during construction script
        ///</remarks>
        public AnimInstance GetAnimInstance()  => 
            SkeletalMeshComponent_methods.GetAnimInstance_method.Invoke(ObjPointer);

        ///<summary>
        ///Returns the mass (in kg) of the given bone
        ///@
        ///</summary>
        ///<remarks>
        ///param BoneName         Name of the body to return. 'None' indicates root body.
        ///@param bScaleMass       If true, the mass is scaled by the bone's MassScale.
        ///</remarks>
        public float GetBoneMass(Name BoneName, bool bScaleMass)  => 
            SkeletalMeshComponent_methods.GetBoneMass_method.Invoke(ObjPointer, BoneName, bScaleMass);

        ///<summary>Get the current interactor for a clothing simulation, if the current simulation supports runtime interaction.</summary>
        public ClothingSimulationInteractor GetClothingSimulationInteractor()  => 
            SkeletalMeshComponent_methods.GetClothingSimulationInteractor_method.Invoke(ObjPointer);

        ///<summary>Get/Set the max distance scale of clothing mesh vertices</summary>
        public float GetClothMaxDistanceScale()  => 
            SkeletalMeshComponent_methods.GetClothMaxDistanceScale_method.Invoke(ObjPointer);

        ///<summary>
        ///Gets the current Angular state for a named bone constraint
        ///@
        ///</summary>
        ///<remarks>
        ///param InBoneName  Name of bone to get constraint ranges for
        ///@param Swing1Angle current angular state of the constraint
        ///@param TwistAngle  current angular state of the constraint
        ///@param Swing2Angle current angular state of the constraint
        ///</remarks>
        public (float, float, float) GetCurrentJointAngles(Name InBoneName)  => 
            SkeletalMeshComponent_methods.GetCurrentJointAngles_method.Invoke(ObjPointer, InBoneName);

        ///<summary>Get Disable Anim Curves</summary>
        public bool GetDisableAnimCurves()  => 
            SkeletalMeshComponent_methods.GetDisableAnimCurves_method.Invoke(ObjPointer);

        ///<summary>Gets whether the post process blueprint is currently disabled for this component</summary>
        public bool GetDisablePostProcessBlueprint()  => 
            SkeletalMeshComponent_methods.GetDisablePostProcessBlueprint_method.Invoke(ObjPointer);

        ///<summary>Get Morph target with given name</summary>
        public float GetMorphTarget(Name MorphTargetName)  => 
            SkeletalMeshComponent_methods.GetMorphTarget_method.Invoke(ObjPointer, MorphTargetName);

        ///<summary>
        ///Animation play functions
        ///      *
        ///      * These changes status of animation instance, which is transient data, which means it won't serialize with this component
        ///      * Because of that reason, it is not safe to be used during construction script
        ///      * Please use OverrideAnimationDatat for construction script.
        ///</summary>
        ///<remarks>That will override AnimationData to be serialized</remarks>
        public float GetPlayRate()  => 
            SkeletalMeshComponent_methods.GetPlayRate_method.Invoke(ObjPointer);

        ///<summary>
        ///Animation play functions
        ///      *
        ///      * These changes status of animation instance, which is transient data, which means it won't serialize with this component
        ///      * Because of that reason, it is not safe to be used during construction script
        ///      * Please use OverrideAnimationDatat for construction script.
        ///</summary>
        ///<remarks>That will override AnimationData to be serialized</remarks>
        public float GetPosition()  => 
            SkeletalMeshComponent_methods.GetPosition_method.Invoke(ObjPointer);

        ///<summary>Returns the active post process instance is one is available.</summary>
        ///<remarks>
        ///This is set on the mesh that this
        ///component is using, and is evaluated immediately after the main instance.
        ///</remarks>
        public AnimInstance GetPostProcessInstance()  => 
            SkeletalMeshComponent_methods.GetPostProcessInstance_method.Invoke(ObjPointer);

        ///<summary>Returns the center of mass of the skeletal mesh, instead of the root body's location</summary>
        public Vector GetSkeletalCenterOfMass()  => 
            SkeletalMeshComponent_methods.GetSkeletalCenterOfMass_method.Invoke(ObjPointer);

        ///<summary>Returns the a tagged sub-instance node.</summary>
        ///<remarks>
        ///If non sub instances are found or none are tagged with the
        ///supplied name, this will return NULL.
        ///</remarks>
        public AnimInstance GetSubInstanceByName(Name InName)  => 
            SkeletalMeshComponent_methods.GetSubInstanceByName_method.Invoke(ObjPointer, InName);

        ///<summary>Gets the teleportation distance threshold.</summary>
        ///<remarks>
        ///@return Threshold value.
        ///</remarks>
        public float GetTeleportDistanceThreshold()  => 
            SkeletalMeshComponent_methods.GetTeleportDistanceThreshold_method.Invoke(ObjPointer);

        ///<summary>Gets the teleportation rotation threshold.</summary>
        ///<remarks>
        ///@return Threshold in degrees.
        ///</remarks>
        public float GetTeleportRotationThreshold()  => 
            SkeletalMeshComponent_methods.GetTeleportRotationThreshold_method.Invoke(ObjPointer);

        ///<summary>
        ///Returns whether there are any valid instances to run, currently this means whether we have
        ///have an animation instance or a post process instance available to process.
        ///</summary>
        public bool HasValidAnimationInstance()  => 
            SkeletalMeshComponent_methods.HasValidAnimationInstance_method.Invoke(ObjPointer);

        ///<summary>Checks whether or not gravity is enabled on the given bone.</summary>
        ///<remarks>
        ///NAME_None indicates the root body should be queried.
        ///If the bone name given is otherwise invalid, false is returned.
        ///
        ///@param BoneName The name of the bone to check.
        ///@return True if gravity is enabled on the bone.
        ///</remarks>
        public bool IsBodyGravityEnabled(Name BoneName)  => 
            SkeletalMeshComponent_methods.IsBodyGravityEnabled_method.Invoke(ObjPointer, BoneName);

        ///<summary>Gets whether or not the clothing simulation is currently suspended</summary>
        public bool IsClothingSimulationSuspended()  => 
            SkeletalMeshComponent_methods.IsClothingSimulationSuspended_method.Invoke(ObjPointer);

        ///<summary>
        ///Animation play functions
        ///      *
        ///      * These changes status of animation instance, which is transient data, which means it won't serialize with this component
        ///      * Because of that reason, it is not safe to be used during construction script
        ///      * Please use OverrideAnimationDatat for construction script.
        ///</summary>
        ///<remarks>That will override AnimationData to be serialized</remarks>
        public bool IsPlaying()  => 
            SkeletalMeshComponent_methods.IsPlaying_method.Invoke(ObjPointer);

        ///<summary>Given a world position, find the closest point on the physics asset.</summary>
        ///<remarks>
        ///Note that this is independent of collision and welding. This is based purely on animation position
        ///@param      WorldPosition                           The point we want the closest point to (i.e. for all bodies in the physics asset, find the one that has a point closest to WorldPosition)
        ///@param      ClosestPointOnPhysicsAsset      The data associated with the closest point (position, normal, etc...)
        ///@return     true if we found a closest point
        ///</remarks>
        public (Vector, Vector, Name, float, bool) K2_GetClosestPointOnPhysicsAsset(Vector WorldPosition)  => 
            SkeletalMeshComponent_methods.K2_GetClosestPointOnPhysicsAsset_method.Invoke(ObjPointer, WorldPosition);

        ///<summary>Set the anim instance class. Clears and re-initializes the anim instance with the new class and sets animation mode to 'AnimationBlueprint'</summary>
        public void K2_SetAnimInstanceClass(SubclassOf<UObject> NewClass)  => 
            SkeletalMeshComponent_methods.K2_SetAnimInstanceClass_method.Invoke(ObjPointer, NewClass);

        ///<summary>This overrides current AnimationData parameter in the SkeletalMeshComponent.</summary>
        ///<remarks>
        ///This will serialize when the component serialize
        ///so it can be used during construction script. However note that this will override current existing data
        ///This can be useful if you'd like to make a blueprint with custom default animation per component
        ///This sets single player mode, which means you can't use AnimBlueprint with it
        ///</remarks>
        public void OverrideAnimationData(AnimationAsset InAnimToPlay, bool bIsLooping, bool bIsPlaying, float Position, float PlayRate)  => 
            SkeletalMeshComponent_methods.OverrideAnimationData_method.Invoke(ObjPointer, InAnimToPlay, bIsLooping, bIsPlaying, Position, PlayRate);

        ///<summary>
        ///Animation play functions
        ///      *
        ///      * These changes status of animation instance, which is transient data, which means it won't serialize with this component
        ///      * Because of that reason, it is not safe to be used during construction script
        ///      * Please use OverrideAnimationDatat for construction script.
        ///</summary>
        ///<remarks>That will override AnimationData to be serialized</remarks>
        public void Play(bool bLooping)  => 
            SkeletalMeshComponent_methods.Play_method.Invoke(ObjPointer, bLooping);

        ///<summary>
        ///Animation play functions
        ///       *
        ///       * These changes status of animation instance, which is transient data, which means it won't serialize with this component
        ///       * Because of that reason, it is not safe to be used during construction script
        ///       * Please use OverrideAnimationDatat for construction script.
        ///</summary>
        ///<remarks>That will override AnimationData to be serialized</remarks>
        public void PlayAnimation(AnimationAsset NewAnimToPlay, bool bLooping)  => 
            SkeletalMeshComponent_methods.PlayAnimation_method.Invoke(ObjPointer, NewAnimToPlay, bLooping);

        ///<summary>Allows you to reset bodies Simulate state based on where bUsePhysics is set to true in the BodySetup.</summary>
        public void ResetAllBodiesSimulatePhysics()  => 
            SkeletalMeshComponent_methods.ResetAllBodiesSimulatePhysics_method.Invoke(ObjPointer);

        ///<summary>By reset, it will allow all the curves to be evaluated</summary>
        public void ResetAllowedAnimCurveEvaluation()  => 
            SkeletalMeshComponent_methods.ResetAllowedAnimCurveEvaluation_method.Invoke(ObjPointer);

        ///<summary>
        ///Informs any active anim instances (main instance, sub instances, post instance) that a dynamics reset is required
        ///for example if a teleport occurs.
        ///</summary>
        public void ResetAnimInstanceDynamics(ETeleportType InTeleportType)  => 
            SkeletalMeshComponent_methods.ResetAnimInstanceDynamics_method.Invoke(ObjPointer, InTeleportType);

        ///<summary>Reset the teleport mode of a next update to 'Continuous'</summary>
        public void ResetClothTeleportMode()  => 
            SkeletalMeshComponent_methods.ResetClothTeleportMode_method.Invoke(ObjPointer);

        ///<summary>Resumes a previously suspended clothing simulation, teleporting the clothing on the next tick</summary>
        public void ResumeClothingSimulation()  => 
            SkeletalMeshComponent_methods.ResumeClothingSimulation_method.Invoke(ObjPointer);

        ///<summary>Set all of the bones below passed in bone to be simulated</summary>
        public void SetAllBodiesBelowPhysicsBlendWeight(Name InBoneName, float PhysicsBlendWeight, bool bSkipCustomPhysicsType, bool bIncludeSelf)  => 
            SkeletalMeshComponent_methods.SetAllBodiesBelowPhysicsBlendWeight_method.Invoke(ObjPointer, InBoneName, PhysicsBlendWeight, bSkipCustomPhysicsType, bIncludeSelf);

        ///<summary>Set all of the bones below passed in bone to be simulated</summary>
        public void SetAllBodiesBelowSimulatePhysics(Name InBoneName, bool bNewSimulate, bool bIncludeSelf)  => 
            SkeletalMeshComponent_methods.SetAllBodiesBelowSimulatePhysics_method.Invoke(ObjPointer, InBoneName, bNewSimulate, bIncludeSelf);

        ///<summary>Set All Bodies Physics Blend Weight</summary>
        public void SetAllBodiesPhysicsBlendWeight(float PhysicsBlendWeight, bool bSkipCustomPhysicsType)  => 
            SkeletalMeshComponent_methods.SetAllBodiesPhysicsBlendWeight_method.Invoke(ObjPointer, PhysicsBlendWeight, bSkipCustomPhysicsType);

        ///<summary>Set bSimulatePhysics to true for all bone bodies. Does not change the component bSimulatePhysics flag.</summary>
        public void SetAllBodiesSimulatePhysics(bool bNewSimulate)  => 
            SkeletalMeshComponent_methods.SetAllBodiesSimulatePhysics_method.Invoke(ObjPointer, bNewSimulate);

        ///<summary>Set Angular Drive motors params for all constraint instances</summary>
        public void SetAllMotorsAngularDriveParams(float InSpring, float InDamping, float InForceLimit, bool bSkipCustomPhysicsType)  => 
            SkeletalMeshComponent_methods.SetAllMotorsAngularDriveParams_method.Invoke(ObjPointer, InSpring, InDamping, InForceLimit, bSkipCustomPhysicsType);

        ///<summary>Enable or Disable AngularPositionDrive. If motor is in SLERP mode it will be turned on if either EnableSwingDrive OR EnableTwistDrive are enabled. In Twist and Swing mode the twist and the swing can be controlled individually.</summary>
        public void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType)  => 
            SkeletalMeshComponent_methods.SetAllMotorsAngularPositionDrive_method.Invoke(ObjPointer, bEnableSwingDrive, bEnableTwistDrive, bSkipCustomPhysicsType);

        ///<summary>Enable or Disable AngularVelocityDrive. If motor is in SLERP mode it will be turned on if either EnableSwingDrive OR EnableTwistDrive are enabled. In Twist and Swing mode the twist and the swing can be controlled individually.</summary>
        public void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType)  => 
            SkeletalMeshComponent_methods.SetAllMotorsAngularVelocityDrive_method.Invoke(ObjPointer, bEnableSwingDrive, bEnableTwistDrive, bSkipCustomPhysicsType);

        ///<summary>Set Allow Anim Curve Evaluation</summary>
        public void SetAllowAnimCurveEvaluation(bool bInAllow)  => 
            SkeletalMeshComponent_methods.SetAllowAnimCurveEvaluation_method.Invoke(ObjPointer, bInAllow);

        ///<summary>resets, and then only allow the following list to be allowed/disallowed</summary>
        public void SetAllowedAnimCurvesEvaluation(byte List /*TODO: array TArray */, bool bAllow)  => 
            SkeletalMeshComponent_methods.SetAllowedAnimCurvesEvaluation_method.Invoke(ObjPointer, List, bAllow);

        ///<summary>
        ///Sets the Angular Motion Ranges for a named bone
        ///@
        ///</summary>
        ///<remarks>
        ///param InBoneName  Name of bone to adjust constraint ranges for
        ///@param Swing1LimitAngle       Size of limit in degrees, 0 means locked, 180 means free
        ///@param TwistLimitAngle        Size of limit in degrees, 0 means locked, 180 means free
        ///@param Swing2LimitAngle       Size of limit in degrees, 0 means locked, 180 means free
        ///</remarks>
        public void SetAngularLimits(Name InBoneName, float Swing1LimitAngle, float TwistLimitAngle, float Swing2LimitAngle)  => 
            SkeletalMeshComponent_methods.SetAngularLimits_method.Invoke(ObjPointer, InBoneName, Swing1LimitAngle, TwistLimitAngle, Swing2LimitAngle);

        ///<summary>
        ///Animation play functions
        ///      *
        ///      * These changes status of animation instance, which is transient data, which means it won't serialize with this component
        ///      * Because of that reason, it is not safe to be used during construction script
        ///      * Please use OverrideAnimationDatat for construction script.
        ///</summary>
        ///<remarks>That will override AnimationData to be serialized</remarks>
        public void SetAnimation(AnimationAsset NewAnimToPlay)  => 
            SkeletalMeshComponent_methods.SetAnimation_method.Invoke(ObjPointer, NewAnimToPlay);

        ///<summary>Below are the interface to control animation when animation mode, not blueprint mode *</summary>
        public void SetAnimationMode(byte InAnimationMode)  => 
            SkeletalMeshComponent_methods.SetAnimationMode_method.Invoke(ObjPointer, InAnimationMode);

        ///<summary>
        ///Changes the value of bNotifyRigidBodyCollision for a given body
        ///@
        ///</summary>
        ///<remarks>
        ///param bNewNotifyRigidBodyCollision   The value to assign to bNotifyRigidBodyCollision
        ///@param BoneName                                               Name of the body to turn hit notifies on/off. None implies root body
        ///</remarks>
        public void SetBodyNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision, Name BoneName)  => 
            SkeletalMeshComponent_methods.SetBodyNotifyRigidBodyCollision_method.Invoke(ObjPointer, bNewNotifyRigidBodyCollision, BoneName);

        ///<summary>Set Cloth Max Distance Scale</summary>
        public void SetClothMaxDistanceScale(float Scale)  => 
            SkeletalMeshComponent_methods.SetClothMaxDistanceScale_method.Invoke(ObjPointer, Scale);

        ///<summary>Sets the constraint profile properties (limits, motors, etc...) to match the constraint profile as defined in the physics asset. If profile name is not found the joint is set to use the default constraint profile.</summary>
        public void SetConstraintProfile(Name JointName, Name ProfileName, bool bDefaultIfNotFound)  => 
            SkeletalMeshComponent_methods.SetConstraintProfile_method.Invoke(ObjPointer, JointName, ProfileName, bDefaultIfNotFound);

        ///<summary>Sets the constraint profile properties (limits, motors, etc...) to match the constraint profile as defined in the physics asset for all constraints. If profile name is not found the joint is set to use the default constraint profile.</summary>
        public void SetConstraintProfileForAll(Name ProfileName, bool bDefaultIfNotFound)  => 
            SkeletalMeshComponent_methods.SetConstraintProfileForAll_method.Invoke(ObjPointer, ProfileName, bDefaultIfNotFound);

        ///<summary>Set Disable Anim Curves</summary>
        public void SetDisableAnimCurves(bool bInDisableAnimCurves)  => 
            SkeletalMeshComponent_methods.SetDisableAnimCurves_method.Invoke(ObjPointer, bInDisableAnimCurves);

        ///<summary>Sets whether the post process blueprint is currently running for this component.</summary>
        ///<remarks>If it is not currently running, and is set to run, the instance will be reinitialized</remarks>
        public void SetDisablePostProcessBlueprint(bool bInDisablePostProcess)  => 
            SkeletalMeshComponent_methods.SetDisablePostProcessBlueprint_method.Invoke(ObjPointer, bInDisablePostProcess);

        ///<summary>Enables or disables gravity for the given bone.</summary>
        ///<remarks>
        ///NAME_None indicates the root body will be edited.
        ///If the bone name given is otherwise invalid, nothing happens.
        ///
        ///@param bEnableGravity   Whether gravity should be enabled or disabled.
        ///@param BoneName                 The name of the bone to modify.
        ///</remarks>
        public void SetEnableBodyGravity(bool bEnableGravity, Name BoneName)  => 
            SkeletalMeshComponent_methods.SetEnableBodyGravity_method.Invoke(ObjPointer, bEnableGravity, BoneName);

        ///<summary>Enables or disables gravity to all bodies below the given bone.</summary>
        ///<remarks>
        ///NAME_None indicates all bodies will be edited.
        ///In that case, consider using UPrimitiveComponent::EnableGravity.
        ///
        ///@param bEnableGravity   Whether gravity should be enabled or disabled.
        ///@param BoneName                 The name of the top most bone.
        ///@param bIncludeSelf             Whether the bone specified should be edited.
        ///</remarks>
        public void SetEnableGravityOnAllBodiesBelow(bool bEnableGravity, Name BoneName, bool bIncludeSelf)  => 
            SkeletalMeshComponent_methods.SetEnableGravityOnAllBodiesBelow_method.Invoke(ObjPointer, bEnableGravity, BoneName, bIncludeSelf);

        ///<summary>Disable physics blending of bones *</summary>
        public void SetEnablePhysicsBlending(bool bNewBlendPhysics)  => 
            SkeletalMeshComponent_methods.SetEnablePhysicsBlending_method.Invoke(ObjPointer, bNewBlendPhysics);

        ///<summary>
        ///Set Morph Target with Name and Value(0-1)
        ///@
        ///</summary>
        ///<remarks>param bRemoveZeroWeight : Used by editor code when it should stay in the active list with zero weight</remarks>
        public void SetMorphTarget(Name MorphTargetName, float Value, bool bRemoveZeroWeight)  => 
            SkeletalMeshComponent_methods.SetMorphTarget_method.Invoke(ObjPointer, MorphTargetName, Value, bRemoveZeroWeight);

        ///<summary>
        ///Changes the value of bNotifyRigidBodyCollision on all bodies below a given bone
        ///@
        ///</summary>
        ///<remarks>
        ///param bNewNotifyRigidBodyCollision   The value to assign to bNotifyRigidBodyCollision
        ///@param BoneName                                               Name of the body to turn hit notifies on (and below)
        ///@param bIncludeSelf                                   Whether to modify the given body (useful for roots with multiple children)
        ///</remarks>
        public void SetNotifyRigidBodyCollisionBelow(bool bNewNotifyRigidBodyCollision, Name BoneName, bool bIncludeSelf)  => 
            SkeletalMeshComponent_methods.SetNotifyRigidBodyCollisionBelow_method.Invoke(ObjPointer, bNewNotifyRigidBodyCollision, BoneName, bIncludeSelf);

        ///<summary>
        ///This is global set up for setting physics blend weight
        ///This does multiple things automatically
        ///If PhysicsBlendWeight == 1.
        ///</summary>
        ///<remarks>
        ///f, it will enable Simulation, and if PhysicsBlendWeight == 0.f, it will disable Simulation.
        ///Also it will respect each body's setup, so if the body is fixed, it won't simulate. Vice versa
        ///So if you'd like all bodies to change manually, do not use this function, but SetAllBodiesPhysicsBlendWeight
        ///</remarks>
        public void SetPhysicsBlendWeight(float PhysicsBlendWeight)  => 
            SkeletalMeshComponent_methods.SetPhysicsBlendWeight_method.Invoke(ObjPointer, PhysicsBlendWeight);

        ///<summary>
        ///Animation play functions
        ///      *
        ///      * These changes status of animation instance, which is transient data, which means it won't serialize with this component
        ///      * Because of that reason, it is not safe to be used during construction script
        ///      * Please use OverrideAnimationDatat for construction script.
        ///</summary>
        ///<remarks>That will override AnimationData to be serialized</remarks>
        public void SetPlayRate(float Rate)  => 
            SkeletalMeshComponent_methods.SetPlayRate_method.Invoke(ObjPointer, Rate);

        ///<summary>
        ///Animation play functions
        ///      *
        ///      * These changes status of animation instance, which is transient data, which means it won't serialize with this component
        ///      * Because of that reason, it is not safe to be used during construction script
        ///      * Please use OverrideAnimationDatat for construction script.
        ///</summary>
        ///<remarks>That will override AnimationData to be serialized</remarks>
        public void SetPosition(float InPos, bool bFireNotifies)  => 
            SkeletalMeshComponent_methods.SetPosition_method.Invoke(ObjPointer, InPos, bFireNotifies);

        ///<summary>Sets the teleportation distance threshold.</summary>
        ///<remarks>
        ///@param threshold Threshold value.
        ///</remarks>
        public void SetTeleportDistanceThreshold(float Threshold)  => 
            SkeletalMeshComponent_methods.SetTeleportDistanceThreshold_method.Invoke(ObjPointer, Threshold);

        ///<summary>Sets the teleportation rotation threshold.</summary>
        ///<remarks>
        ///@param threshold Threshold in degrees.
        ///</remarks>
        public void SetTeleportRotationThreshold(float Threshold)  => 
            SkeletalMeshComponent_methods.SetTeleportRotationThreshold_method.Invoke(ObjPointer, Threshold);

        ///<summary>Sets whether or not to force tick component in order to update animation and refresh transform for this component</summary>
        ///<remarks>This is supported only in the editor</remarks>
        public void SetUpdateAnimationInEditor(bool NewUpdateState)  => 
            SkeletalMeshComponent_methods.SetUpdateAnimationInEditor_method.Invoke(ObjPointer, NewUpdateState);

        ///<summary>Takes a snapshot of this skeletal mesh component's pose and saves it to the specified snapshot.</summary>
        ///<remarks>
        ///The snapshot is taken at the current LOD, so if for example you took the snapshot at LOD1
        ///and then used it at LOD0 any bones not in LOD1 will use the reference pose
        ///</remarks>
        public void SnapshotPose(PoseSnapshot Snapshot)  => 
            SkeletalMeshComponent_methods.SnapshotPose_method.Invoke(ObjPointer, Snapshot);

        ///<summary>
        ///Animation play functions
        ///      *
        ///      * These changes status of animation instance, which is transient data, which means it won't serialize with this component
        ///      * Because of that reason, it is not safe to be used during construction script
        ///      * Please use OverrideAnimationDatat for construction script.
        ///</summary>
        ///<remarks>That will override AnimationData to be serialized</remarks>
        public void Stop()  => 
            SkeletalMeshComponent_methods.Stop_method.Invoke(ObjPointer);

        ///<summary>Stops simulating clothing, but does not show clothing ref pose. Keeps the last known simulation state</summary>
        public void SuspendClothingSimulation()  => 
            SkeletalMeshComponent_methods.SuspendClothingSimulation_method.Invoke(ObjPointer);

        ///<summary>Terminate physics on all bodies below the named bone, effectively disabling collision forever. If you terminate, you won't be able to re-init later.</summary>
        public void TermBodiesBelow(Name ParentBoneName)  => 
            SkeletalMeshComponent_methods.TermBodiesBelow_method.Invoke(ObjPointer, ParentBoneName);

        ///<summary>Toggles whether the post process blueprint will run for this component</summary>
        public void ToggleDisablePostProcessBlueprint()  => 
            SkeletalMeshComponent_methods.ToggleDisablePostProcessBlueprint_method.Invoke(ObjPointer);

        ///<summary>
        ///If this component has a valid MasterPoseComponent and has previously had its cloth bound to the
        ///MCP, this function will unbind the cloth and resume simulation.
        ///</summary>
        ///<remarks>
        ///@param bRestoreSimulationSpace if true and the master pose cloth was originally simulating in world
        ///space, we will restore this setting. This will cause the master component to reset which may be
        ///undesirable.
        ///</remarks>
        public void UnbindClothFromMasterPoseComponent(bool bRestoreSimulationSpace)  => 
            SkeletalMeshComponent_methods.UnbindClothFromMasterPoseComponent_method.Invoke(ObjPointer, bRestoreSimulationSpace);
        ///<summary>Anim Blueprint Generated Class</summary>
        public unsafe SubclassOf<UObject> AnimBlueprintGeneratedClass {
            get {return SkeletalMeshComponent_ptr->AnimBlueprintGeneratedClass;}
        }
        ///<summary>The AnimBlueprint class to use. Use 'SetAnimInstanceClass' to change at runtime.</summary>
        public unsafe SubclassOf<AnimInstance> AnimClass {
            get {return SkeletalMeshComponent_ptr->AnimClass;}
        }
        ///<summary>The active animation graph program instance.</summary>
        public unsafe AnimInstance AnimScriptInstance {
            get {return SkeletalMeshComponent_ptr->AnimScriptInstance;}
            set {SkeletalMeshComponent_ptr->AnimScriptInstance = value;}
        }
        ///<summary>Any running sub anim instances that need to be updates on the game thread</summary>
        public ObjectArrayField<AnimInstance> SubInstances{ get {
            if(SubInstances_store == null) SubInstances_store = new ObjectArrayField<AnimInstance> (&SkeletalMeshComponent_ptr->SubInstances);
            return SubInstances_store;
        } }
        private ObjectArrayField<AnimInstance> SubInstances_store;

        ///<summary>An instance created from the PostPhysicsBlueprint property of the skeletal mesh we're using,</summary>
        ///<remarks>Runs after physics has been blended</remarks>
        public unsafe AnimInstance PostProcessAnimInstance {
            get {return SkeletalMeshComponent_ptr->PostProcessAnimInstance;}
            set {SkeletalMeshComponent_ptr->PostProcessAnimInstance = value;}
        }
        ///<summary>Animation Data</summary>
        public unsafe SingleAnimationPlayData AnimationData {
            get {return SkeletalMeshComponent_ptr->AnimationData;}
            set {SkeletalMeshComponent_ptr->AnimationData = value;}
        }
        ///<summary>Offset of the root bone from the reference pose. Used to offset bounding box.</summary>
        public unsafe Vector RootBoneTranslation {
            get {return SkeletalMeshComponent_ptr->RootBoneTranslation;}
            set {SkeletalMeshComponent_ptr->RootBoneTranslation = value;}
        }
        ///<summary>If bEnableLineCheckWithBounds is true, scale the bounds by this value before doing line check.</summary>
        public unsafe Vector LineCheckBoundsScale {
            get {return SkeletalMeshComponent_ptr->LineCheckBoundsScale;}
            set {SkeletalMeshComponent_ptr->LineCheckBoundsScale = value;}
        }
         //TODO: array not UObject TArray CachedBoneSpaceTransforms
         //TODO: array not UObject TArray CachedComponentSpaceTransforms
        ///<summary>Used to scale speed of all animations on this skeletal mesh.</summary>
        public unsafe float GlobalAnimRateScale {
            get {return SkeletalMeshComponent_ptr->GlobalAnimRateScale;}
            set {SkeletalMeshComponent_ptr->GlobalAnimRateScale = value;}
        }
         //TODO: enum EDynamicActorScene UseAsyncScene
        ///<summary>If we are running physics, should we update non-simulated bones based on the animation bone positions.</summary>
        public unsafe byte KinematicBonesUpdateType {
            get {return SkeletalMeshComponent_ptr->KinematicBonesUpdateType;}
            set {SkeletalMeshComponent_ptr->KinematicBonesUpdateType = value;}
        }
        ///<summary>Whether physics simulation updates component transform.</summary>
        public unsafe byte PhysicsTransformUpdateMode {
            get {return SkeletalMeshComponent_ptr->PhysicsTransformUpdateMode;}
            set {SkeletalMeshComponent_ptr->PhysicsTransformUpdateMode = value;}
        }
        ///<summary>Whether to use Animation Blueprint or play Single Animation Asset.</summary>
        public unsafe byte AnimationMode {
            get {return SkeletalMeshComponent_ptr->AnimationMode;}
        }
        public bool bDisablePostProcessBlueprint {
            get {return Main.GetGetBoolPropertyByName(this, "bDisablePostProcessBlueprint"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisablePostProcessBlueprint", value); }
        }
        public bool bUpdateOverlapsOnAnimationFinalize {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateOverlapsOnAnimationFinalize"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateOverlapsOnAnimationFinalize", value); }
        }
        public bool bHasValidBodies {
            get {return Main.GetGetBoolPropertyByName(this, "bHasValidBodies"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasValidBodies", value); }
        }
        public bool bBlendPhysics {
            get {return Main.GetGetBoolPropertyByName(this, "bBlendPhysics"); }
            set {Main.SetGetBoolPropertyByName(this, "bBlendPhysics", value); }
        }
        public bool bEnablePhysicsOnDedicatedServer {
            get {return Main.GetGetBoolPropertyByName(this, "bEnablePhysicsOnDedicatedServer"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnablePhysicsOnDedicatedServer", value); }
        }
        public bool bUpdateJointsFromAnimation {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateJointsFromAnimation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateJointsFromAnimation", value); }
        }
        public bool bDisableClothSimulation {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableClothSimulation"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableClothSimulation", value); }
        }
        public bool bAllowAnimCurveEvaluation {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowAnimCurveEvaluation"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowAnimCurveEvaluation", value); }
        }
        public bool bCollideWithEnvironment {
            get {return Main.GetGetBoolPropertyByName(this, "bCollideWithEnvironment"); }
            set {Main.SetGetBoolPropertyByName(this, "bCollideWithEnvironment", value); }
        }
        public bool bCollideWithAttachedChildren {
            get {return Main.GetGetBoolPropertyByName(this, "bCollideWithAttachedChildren"); }
            set {Main.SetGetBoolPropertyByName(this, "bCollideWithAttachedChildren", value); }
        }
        public bool bLocalSpaceSimulation {
            get {return Main.GetGetBoolPropertyByName(this, "bLocalSpaceSimulation"); }
            set {Main.SetGetBoolPropertyByName(this, "bLocalSpaceSimulation", value); }
        }
        public bool bResetAfterTeleport {
            get {return Main.GetGetBoolPropertyByName(this, "bResetAfterTeleport"); }
            set {Main.SetGetBoolPropertyByName(this, "bResetAfterTeleport", value); }
        }
        public bool bNoSkeletonUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bNoSkeletonUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bNoSkeletonUpdate", value); }
        }
        public bool bPauseAnims {
            get {return Main.GetGetBoolPropertyByName(this, "bPauseAnims"); }
            set {Main.SetGetBoolPropertyByName(this, "bPauseAnims", value); }
        }
        public bool bUseRefPoseOnInitAnim {
            get {return Main.GetGetBoolPropertyByName(this, "bUseRefPoseOnInitAnim"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseRefPoseOnInitAnim", value); }
        }
        public bool bEnablePerPolyCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bEnablePerPolyCollision"); }
        }
        public bool bForceRefpose {
            get {return Main.GetGetBoolPropertyByName(this, "bForceRefpose"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceRefpose", value); }
        }
        public bool bOnlyAllowAutonomousTickPose {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlyAllowAutonomousTickPose"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlyAllowAutonomousTickPose", value); }
        }
        public bool bIsAutonomousTickPose {
            get {return Main.GetGetBoolPropertyByName(this, "bIsAutonomousTickPose"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsAutonomousTickPose", value); }
        }
        public bool bOldForceRefPose {
            get {return Main.GetGetBoolPropertyByName(this, "bOldForceRefPose"); }
            set {Main.SetGetBoolPropertyByName(this, "bOldForceRefPose", value); }
        }
        public bool bShowPrePhysBones {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPrePhysBones"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPrePhysBones", value); }
        }
        public bool bRequiredBonesUpToDate {
            get {return Main.GetGetBoolPropertyByName(this, "bRequiredBonesUpToDate"); }
            set {Main.SetGetBoolPropertyByName(this, "bRequiredBonesUpToDate", value); }
        }
        public bool bAnimTreeInitialised {
            get {return Main.GetGetBoolPropertyByName(this, "bAnimTreeInitialised"); }
            set {Main.SetGetBoolPropertyByName(this, "bAnimTreeInitialised", value); }
        }
        public bool bIncludeComponentLocationIntoBounds {
            get {return Main.GetGetBoolPropertyByName(this, "bIncludeComponentLocationIntoBounds"); }
        }
        public bool bEnableLineCheckWithBounds {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableLineCheckWithBounds"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableLineCheckWithBounds", value); }
        }
        public bool bUseBendingElements {
            get {return Main.GetGetBoolPropertyByName(this, "bUseBendingElements"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseBendingElements", value); }
        }
        public bool bUseTetrahedralConstraints {
            get {return Main.GetGetBoolPropertyByName(this, "bUseTetrahedralConstraints"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseTetrahedralConstraints", value); }
        }
        public bool bUseThinShellVolumeConstraints {
            get {return Main.GetGetBoolPropertyByName(this, "bUseThinShellVolumeConstraints"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseThinShellVolumeConstraints", value); }
        }
        public bool bUseSelfCollisions {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSelfCollisions"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSelfCollisions", value); }
        }
        public bool bUseContinuousCollisionDetection {
            get {return Main.GetGetBoolPropertyByName(this, "bUseContinuousCollisionDetection"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseContinuousCollisionDetection", value); }
        }
        public bool bUpdateAnimationInEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateAnimationInEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateAnimationInEditor", value); }
        }
        public bool bNeedsQueuedAnimEventsDispatched {
            get {return Main.GetGetBoolPropertyByName(this, "bNeedsQueuedAnimEventsDispatched"); }
            set {Main.SetGetBoolPropertyByName(this, "bNeedsQueuedAnimEventsDispatched", value); }
        }
         //TODO: numeric uint16 CachedAnimCurveUidVersion
        ///<summary>
        ///weight to blend between simulated results and key-framed positions
        ///if weight is 1.
        ///</summary>
        ///<remarks>0, shows only cloth simulation results and 0.0 will show only skinned results</remarks>
        public unsafe float ClothBlendWeight {
            get {return SkeletalMeshComponent_ptr->ClothBlendWeight;}
            set {SkeletalMeshComponent_ptr->ClothBlendWeight = value;}
        }
        ///<summary>Edge Stiffness</summary>
        public unsafe float EdgeStiffness {
            get {return SkeletalMeshComponent_ptr->EdgeStiffness;}
            set {SkeletalMeshComponent_ptr->EdgeStiffness = value;}
        }
        ///<summary>Bending Stiffness</summary>
        public unsafe float BendingStiffness {
            get {return SkeletalMeshComponent_ptr->BendingStiffness;}
            set {SkeletalMeshComponent_ptr->BendingStiffness = value;}
        }
        ///<summary>Area Stiffness</summary>
        public unsafe float AreaStiffness {
            get {return SkeletalMeshComponent_ptr->AreaStiffness;}
            set {SkeletalMeshComponent_ptr->AreaStiffness = value;}
        }
        ///<summary>Volume Stiffness</summary>
        public unsafe float VolumeStiffness {
            get {return SkeletalMeshComponent_ptr->VolumeStiffness;}
            set {SkeletalMeshComponent_ptr->VolumeStiffness = value;}
        }
        ///<summary>Strain Limiting Stiffness</summary>
        public unsafe float StrainLimitingStiffness {
            get {return SkeletalMeshComponent_ptr->StrainLimitingStiffness;}
            set {SkeletalMeshComponent_ptr->StrainLimitingStiffness = value;}
        }
        ///<summary>Shape Target Stiffness</summary>
        public unsafe float ShapeTargetStiffness {
            get {return SkeletalMeshComponent_ptr->ShapeTargetStiffness;}
            set {SkeletalMeshComponent_ptr->ShapeTargetStiffness = value;}
        }
         //TODO: array not UObject TArray DisallowedAnimCurves
        ///<summary>Used for per poly collision.</summary>
        ///<remarks>
        ///In 99% of cases you will be better off using a Physics Asset.
        ///This BodySetup is per instance because all modification of vertices is done in place
        ///</remarks>
        public unsafe BodySetup BodySetup {
            get {return SkeletalMeshComponent_ptr->BodySetup;}
            set {SkeletalMeshComponent_ptr->BodySetup = value;}
        }
         //TODO: multicast delegate FConstraintBrokenSignature OnConstraintBroken
        ///<summary>Class of the object responsible for</summary>
        public unsafe SubclassOf<ClothingSimulationFactory> ClothingSimulationFactory {
            get {return SkeletalMeshComponent_ptr->ClothingSimulationFactory;}
            set {SkeletalMeshComponent_ptr->ClothingSimulationFactory = value;}
        }
        ///<summary>Conduct teleportation if the character's movement is greater than this threshold in 1 frame.</summary>
        ///<remarks>
        ///Zero or negative values will skip the check.
        ///You can also do force teleport manually using ForceNextUpdateTeleport() / ForceNextUpdateTeleportAndReset().
        ///</remarks>
        public unsafe float TeleportDistanceThreshold {
            get {return SkeletalMeshComponent_ptr->TeleportDistanceThreshold;}
            set {SkeletalMeshComponent_ptr->TeleportDistanceThreshold = value;}
        }
        ///<summary>Rotation threshold in degrees, ranging from 0 to 180.</summary>
        ///<remarks>
        ///Conduct teleportation if the character's rotation is greater than this threshold in 1 frame.
        ///Zero or negative values will skip the check.
        ///</remarks>
        public unsafe float TeleportRotationThreshold {
            get {return SkeletalMeshComponent_ptr->TeleportRotationThreshold;}
            set {SkeletalMeshComponent_ptr->TeleportRotationThreshold = value;}
        }
         //TODO: numeric uint32 LastPoseTickFrame
        ///<summary>Object responsible for interacting with the clothing simulation.</summary>
        ///<remarks>
        ///Blueprints and code can call/set data on this from the game thread and the next time
        ///it is safe to do so the interactor will sync to the simulation context
        ///</remarks>
        public unsafe ClothingSimulationInteractor ClothingInteractor {
            get {return SkeletalMeshComponent_ptr->ClothingInteractor;}
            set {SkeletalMeshComponent_ptr->ClothingInteractor = value;}
        }
         //TODO: multicast delegate FOnAnimInitialized OnAnimInitialized
        static SkeletalMeshComponent() {
            StaticClass = Main.GetClass("SkeletalMeshComponent");
        }
        internal unsafe SkeletalMeshComponent_fields* SkeletalMeshComponent_ptr => (SkeletalMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkeletalMeshComponent(IntPtr p) => UObject.Make<SkeletalMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkeletalMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkeletalMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
