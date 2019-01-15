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
    ///<summary>A SceneComponent has a transform and supports attachment, but has no rendering or collision capabilities.</summary>
    ///<remarks>
    ///Useful as a 'dummy' component in the hierarchy to offset others.
    ///@see [Scene Components](https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors/Components/index.html#scenecomponents)
    ///</remarks>
    public unsafe partial class SceneComponent : ActorComponent  {

        ///<summary>Detach from Parent</summary>
        public void DetachFromParent(bool bMaintainWorldPosition, bool bCallModify)  => 
            SceneComponent_methods.DetachFromParent_method.Invoke(ObjPointer, bMaintainWorldPosition, bCallModify);

        ///<summary>
        ///return true if socket with the given name exists
        ///@
        ///</summary>
        ///<remarks>
        ///param InSocketName Name of the socket or the bone to get the transform
        ///@return true if the socket with the given name exists. Otherwise, return false
        ///</remarks>
        public bool DoesSocketExist(Name InSocketName)  => 
            SceneComponent_methods.DoesSocketExist_method.Invoke(ObjPointer, InSocketName);

        ///<summary>Gets the names of all the sockets on the component.</summary>
        ///<remarks>
        ///@return Get the names of all the sockets on the component.
        ///</remarks>
        public IReadOnlyCollection<Name> GetAllSocketNames()  => 
            SceneComponent_methods.GetAllSocketNames_method.Invoke(ObjPointer);

        ///<summary>Get the SceneComponent we are attached to.</summary>
        public SceneComponent GetAttachParent()  => 
            SceneComponent_methods.GetAttachParent_method.Invoke(ObjPointer);

        ///<summary>Get the socket we are attached to.</summary>
        public Name GetAttachSocketName()  => 
            SceneComponent_methods.GetAttachSocketName_method.Invoke(ObjPointer);

        ///<summary>Gets the attached child component at the specified location</summary>
        public SceneComponent GetChildComponent(int ChildIndex)  => 
            SceneComponent_methods.GetChildComponent_method.Invoke(ObjPointer, ChildIndex);

        ///<summary>
        ///Gets all the attached child components
        ///@
        ///</summary>
        ///<remarks>
        ///param bIncludeAllDescendants Whether to include all descendants in the list of children (i.e. grandchildren, great grandchildren, etc.)
        ///@param Children The list of attached child components
        ///</remarks>
        public IReadOnlyCollection<SceneComponent> GetChildrenComponents(bool bIncludeAllDescendants)  => 
            SceneComponent_methods.GetChildrenComponents_method.Invoke(ObjPointer, bIncludeAllDescendants);

        ///<summary>Get velocity of the component: either ComponentVelocity, or the velocity of the physics body if simulating physics.</summary>
        ///<remarks>
        ///@return Velocity of the component
        ///</remarks>
        public Vector GetComponentVelocity()  => 
            SceneComponent_methods.GetComponentVelocity_method.Invoke(ObjPointer);

        ///<summary>Get the forward (X) unit direction vector from this component, in world space.</summary>
        public Vector GetForwardVector()  => 
            SceneComponent_methods.GetForwardVector_method.Invoke(ObjPointer);

        ///<summary>Gets the number of attached children components</summary>
        public int GetNumChildrenComponents()  => 
            SceneComponent_methods.GetNumChildrenComponents_method.Invoke(ObjPointer);

        ///<summary>Gets all parent components up to and including the root component</summary>
        public IReadOnlyCollection<SceneComponent> GetParentComponents()  => 
            SceneComponent_methods.GetParentComponents_method.Invoke(ObjPointer);

        ///<summary>Get the PhysicsVolume overlapping this component.</summary>
        public PhysicsVolume GetPhysicsVolume()  => 
            SceneComponent_methods.GetPhysicsVolume_method.Invoke(ObjPointer);

        ///<summary>Returns the transform of the component relative to its parent</summary>
        public Transform GetRelativeTransform()  => 
            SceneComponent_methods.GetRelativeTransform_method.Invoke(ObjPointer);

        ///<summary>Get the right (Y) unit direction vector from this component, in world space.</summary>
        public Vector GetRightVector()  => 
            SceneComponent_methods.GetRightVector_method.Invoke(ObjPointer);

        ///<summary>Get Should Update Physics Volume</summary>
        public bool GetShouldUpdatePhysicsVolume()  => 
            SceneComponent_methods.GetShouldUpdatePhysicsVolume_method.Invoke(ObjPointer);

        ///<summary>Get world-space socket or bone location.</summary>
        ///<remarks>
        ///@param InSocketName Name of the socket or the bone to get the transform
        ///@return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
        ///</remarks>
        public Vector GetSocketLocation(Name InSocketName)  => 
            SceneComponent_methods.GetSocketLocation_method.Invoke(ObjPointer, InSocketName);

        ///<summary>Get world-space socket or bone FQuat rotation.</summary>
        ///<remarks>
        ///@param InSocketName Name of the socket or the bone to get the transform
        ///@return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
        ///</remarks>
        public Quat GetSocketQuaternion(Name InSocketName)  => 
            SceneComponent_methods.GetSocketQuaternion_method.Invoke(ObjPointer, InSocketName);

        ///<summary>Get world-space socket or bone  FRotator rotation.</summary>
        ///<remarks>
        ///@param InSocketName Name of the socket or the bone to get the transform
        ///@return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
        ///</remarks>
        public Rotator GetSocketRotation(Name InSocketName)  => 
            SceneComponent_methods.GetSocketRotation_method.Invoke(ObjPointer, InSocketName);

        ///<summary>Get world-space socket transform.</summary>
        ///<remarks>
        ///@param InSocketName Name of the socket or the bone to get the transform
        ///@return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
        ///</remarks>
        public Transform GetSocketTransform(Name InSocketName, byte TransformSpace)  => 
            SceneComponent_methods.GetSocketTransform_method.Invoke(ObjPointer, InSocketName, TransformSpace);

        ///<summary>Get the up (Z) unit direction vector from this component, in world space.</summary>
        public Vector GetUpVector()  => 
            SceneComponent_methods.GetUpVector_method.Invoke(ObjPointer);

        ///<summary>Returns whether the specified body is currently using physics simulation</summary>
        public bool IsAnySimulatingPhysics()  => 
            SceneComponent_methods.IsAnySimulatingPhysics_method.Invoke(ObjPointer);

        ///<summary>Returns whether the specified body is currently using physics simulation</summary>
        public bool IsSimulatingPhysics(Name BoneName)  => 
            SceneComponent_methods.IsSimulatingPhysics_method.Invoke(ObjPointer, BoneName);

        ///<summary>
        ///Is this component visible or not in game
        ///@
        ///</summary>
        ///<remarks>return true if visible</remarks>
        public bool IsVisible()  => 
            SceneComponent_methods.IsVisible_method.Invoke(ObjPointer);

        ///<summary>
        ///Adds a delta to the location of the component in its local reference frame
        ///@
        ///</summary>
        ///<remarks>
        ///param DeltaLocation         Change in location of the component in its local reference frame.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_AddLocalOffset(Vector DeltaLocation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_AddLocalOffset_method.Invoke(ObjPointer, DeltaLocation, bSweep, bTeleport);

        ///<summary>
        ///Adds a delta to the rotation of the component in its local reference frame
        ///@
        ///</summary>
        ///<remarks>
        ///param DeltaRotation         Change in rotation of the component in its local reference frame.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///</remarks>
        public HitResult K2_AddLocalRotation(Rotator DeltaRotation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_AddLocalRotation_method.Invoke(ObjPointer, DeltaRotation, bSweep, bTeleport);

        ///<summary>Adds a delta to the transform of the component in its local reference frame.</summary>
        ///<remarks>
        ///Scale is unchanged.
        ///@param DeltaTransform        Change in transform of the component in its local reference frame. Scale is unchanged.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_AddLocalTransform(Transform DeltaTransform, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_AddLocalTransform_method.Invoke(ObjPointer, DeltaTransform, bSweep, bTeleport);

        ///<summary>
        ///Adds a delta to the translation of the component relative to its parent
        ///@
        ///</summary>
        ///<remarks>
        ///param DeltaLocation         Change in location of the component relative to its parent
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_AddRelativeLocation(Vector DeltaLocation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_AddRelativeLocation_method.Invoke(ObjPointer, DeltaLocation, bSweep, bTeleport);

        ///<summary>
        ///Adds a delta the rotation of the component relative to its parent
        ///@
        ///</summary>
        ///<remarks>
        ///param DeltaRotation         Change in rotation of the component relative to is parent.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///</remarks>
        public HitResult K2_AddRelativeRotation(Rotator DeltaRotation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_AddRelativeRotation_method.Invoke(ObjPointer, DeltaRotation, bSweep, bTeleport);

        ///<summary>Adds a delta to the location of the component in world space.</summary>
        ///<remarks>
        ///@param DeltaLocation         Change in location in world space for the component.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_AddWorldOffset(Vector DeltaLocation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_AddWorldOffset_method.Invoke(ObjPointer, DeltaLocation, bSweep, bTeleport);

        ///<summary>Adds a delta to the rotation of the component in world space.</summary>
        ///<remarks>
        ///@param DeltaRotation         Change in rotation in world space for the component.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_AddWorldRotation(Rotator DeltaRotation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_AddWorldRotation_method.Invoke(ObjPointer, DeltaRotation, bSweep, bTeleport);

        ///<summary>Adds a delta to the transform of the component in world space.</summary>
        ///<remarks>
        ///Scale is unchanged.
        ///@param DeltaTransform        Change in transform in world space for the component. Scale is unchanged.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_AddWorldTransform(Transform DeltaTransform, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_AddWorldTransform_method.Invoke(ObjPointer, DeltaTransform, bSweep, bTeleport);

        ///<summary>K2 Attach To</summary>
        public bool K2_AttachTo(SceneComponent InParent, Name InSocketName, byte AttachType, bool bWeldSimulatedBodies)  => 
            SceneComponent_methods.K2_AttachTo_method.Invoke(ObjPointer, InParent, InSocketName, AttachType, bWeldSimulatedBodies);

        ///<summary>Attach this component to another scene component, optionally at a named socket.</summary>
        ///<remarks>
        ///It is valid to call this on components whether or not they have been Registered.
        ///@param  Parent                                        Parent to attach to.
        ///@param  SocketName                            Optional socket to attach to on the parent.
        ///@param  LocationRule                          How to handle translation when attaching.
        ///@param  RotationRule                          How to handle rotation when attaching.
        ///@param  ScaleRule                                     How to handle scale when attaching.
        ///@param  bWeldSimulatedBodies          Whether to weld together simulated physics bodies.
        ///@return True if attachment is successful (or already attached to requested parent/socket), false if attachment is rejected and there is no change in AttachParent.
        ///</remarks>
        public bool K2_AttachToComponent(SceneComponent Parent, Name SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)  => 
            SceneComponent_methods.K2_AttachToComponent_method.Invoke(ObjPointer, Parent, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);

        ///<summary>Detach this component from whatever it is attached to.</summary>
        ///<remarks>
        ///Automatically unwelds components that are welded together (See WeldTo)
        ///@param LocationRule                          How to handle translations when detaching.
        ///@param RotationRule                          How to handle rotation when detaching.
        ///@param ScaleRule                                     How to handle scales when detaching.
        ///@param bCallModify                           If true, call Modify() on the component and the current attach parent component
        ///</remarks>
        public void K2_DetachFromComponent(EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, bool bCallModify)  => 
            SceneComponent_methods.K2_DetachFromComponent_method.Invoke(ObjPointer, LocationRule, RotationRule, ScaleRule, bCallModify);

        ///<summary>Return location of the component, in world space</summary>
        public Vector K2_GetComponentLocation()  => 
            SceneComponent_methods.K2_GetComponentLocation_method.Invoke(ObjPointer);

        ///<summary>Returns rotation of the component, in world space.</summary>
        public Rotator K2_GetComponentRotation()  => 
            SceneComponent_methods.K2_GetComponentRotation_method.Invoke(ObjPointer);

        ///<summary>Returns scale of the component, in world space.</summary>
        public Vector K2_GetComponentScale()  => 
            SceneComponent_methods.K2_GetComponentScale_method.Invoke(ObjPointer);

        ///<summary>Get the current component-to-world transform for this component</summary>
        public Transform K2_GetComponentToWorld()  => 
            SceneComponent_methods.K2_GetComponentToWorld_method.Invoke(ObjPointer);

        ///<summary>
        ///Set the location of the component relative to its parent
        ///@
        ///</summary>
        ///<remarks>
        ///param NewLocation           New location of the component relative to its parent.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_SetRelativeLocation(Vector NewLocation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_SetRelativeLocation_method.Invoke(ObjPointer, NewLocation, bSweep, bTeleport);

        ///<summary>
        ///Set the location and rotation of the component relative to its parent
        ///@
        ///</summary>
        ///<remarks>
        ///param NewLocation           New location of the component relative to its parent.
        ///@param NewRotation           New rotation of the component relative to its parent.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_SetRelativeLocationAndRotation(Vector NewLocation, Rotator NewRotation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_SetRelativeLocationAndRotation_method.Invoke(ObjPointer, NewLocation, NewRotation, bSweep, bTeleport);

        ///<summary>
        ///Set the rotation of the component relative to its parent
        ///@
        ///</summary>
        ///<remarks>
        ///param NewRotation           New rotation of the component relative to its parent
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///</remarks>
        public HitResult K2_SetRelativeRotation(Rotator NewRotation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_SetRelativeRotation_method.Invoke(ObjPointer, NewRotation, bSweep, bTeleport);

        ///<summary>
        ///Set the transform of the component relative to its parent
        ///@
        ///</summary>
        ///<remarks>
        ///param NewTransform          New transform of the component relative to its parent.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///</remarks>
        public HitResult K2_SetRelativeTransform(Transform NewTransform, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_SetRelativeTransform_method.Invoke(ObjPointer, NewTransform, bSweep, bTeleport);

        ///<summary>Put this component at the specified location in world space.</summary>
        ///<remarks>
        ///Updates relative location to achieve the final world location.
        ///@param NewLocation           New location in world space for the component.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_SetWorldLocation(Vector NewLocation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_SetWorldLocation_method.Invoke(ObjPointer, NewLocation, bSweep, bTeleport);

        ///<summary>Set the relative location and rotation of the component to put it at the supplied pose in world space.</summary>
        ///<remarks>
        ///@param NewLocation           New location in world space for the component.
        ///@param NewRotation           New rotation in world space for the component.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_SetWorldLocationAndRotation(Vector NewLocation, Rotator NewRotation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_SetWorldLocationAndRotation_method.Invoke(ObjPointer, NewLocation, NewRotation, bSweep, bTeleport);

        ///<summary>* Put this component at the specified rotation in world space.</summary>
        ///<remarks>
        ///Updates relative rotation to achieve the final world rotation.
        ///* @param NewRotation           New rotation in world space for the component.
        ///* @param SweepHitResult        Hit result from any impact if sweep is true.
        ///* @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
        ///* @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///*                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///*                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///*                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_SetWorldRotation(Rotator NewRotation, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_SetWorldRotation_method.Invoke(ObjPointer, NewRotation, bSweep, bTeleport);

        ///<summary>Set the transform of the component in world space.</summary>
        ///<remarks>
        ///@param NewTransform          New transform in world space for the component.
        ///@param SweepHitResult        Hit result from any impact if sweep is true.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
        ///</remarks>
        public HitResult K2_SetWorldTransform(Transform NewTransform, bool bSweep, bool bTeleport)  => 
            SceneComponent_methods.K2_SetWorldTransform_method.Invoke(ObjPointer, NewTransform, bSweep, bTeleport);

        ///<summary>Reset the transform of the component relative to its parent. Sets relative location to zero, relative rotation to no rotation, and Scale to 1.</summary>
        public void ResetRelativeTransform()  => 
            SceneComponent_methods.ResetRelativeTransform_method.Invoke(ObjPointer);

        ///<summary>Set which parts of the relative transform should be relative to parent, and which should be relative to world</summary>
        public void SetAbsolute(bool bNewAbsoluteLocation, bool bNewAbsoluteRotation, bool bNewAbsoluteScale)  => 
            SceneComponent_methods.SetAbsolute_method.Invoke(ObjPointer, bNewAbsoluteLocation, bNewAbsoluteRotation, bNewAbsoluteScale);

        ///<summary>Changes the value of HiddenGame.</summary>
        ///<remarks>
        ///@param NewHidden     - The value to assign to HiddenGame.
        ///</remarks>
        public void SetHiddenInGame(bool NewHidden, bool bPropagateToChildren)  => 
            SceneComponent_methods.SetHiddenInGame_method.Invoke(ObjPointer, NewHidden, bPropagateToChildren);

        ///<summary>Set the non-uniform scale of the component relative to its parent</summary>
        public void SetRelativeScale3D(Vector NewScale3D)  => 
            SceneComponent_methods.SetRelativeScale3D_method.Invoke(ObjPointer, NewScale3D);

        ///<summary>Set Should Update Physics Volume</summary>
        public void SetShouldUpdatePhysicsVolume(bool bInShouldUpdatePhysicsVolume)  => 
            SceneComponent_methods.SetShouldUpdatePhysicsVolume_method.Invoke(ObjPointer, bInShouldUpdatePhysicsVolume);

        ///<summary>Set visibility of the component, if during game use this to turn on/off</summary>
        public void SetVisibility(bool bNewVisibility, bool bPropagateToChildren)  => 
            SceneComponent_methods.SetVisibility_method.Invoke(ObjPointer, bNewVisibility, bPropagateToChildren);

        ///<summary>Set the relative scale of the component to put it at the supplied scale in world space.</summary>
        ///<remarks>
        ///@param NewScale              New scale in world space for this component.
        ///</remarks>
        public void SetWorldScale3D(Vector NewScale)  => 
            SceneComponent_methods.SetWorldScale3D_method.Invoke(ObjPointer, NewScale);

        ///<summary>Snap To</summary>
        public bool SnapTo(SceneComponent InParent, Name InSocketName)  => 
            SceneComponent_methods.SnapTo_method.Invoke(ObjPointer, InParent, InSocketName);

        ///<summary>Toggle visibility of the component</summary>
        public void ToggleVisibility(bool bPropagateToChildren)  => 
            SceneComponent_methods.ToggleVisibility_method.Invoke(ObjPointer, bPropagateToChildren);
         //TODO: weak object TWeakObjectPtr<APhysicsVolume> PhysicsVolume
        ///<summary>What we are currently attached to. If valid, RelativeLocation etc. are used relative to this object</summary>
        public unsafe SceneComponent AttachParent {
            get {return SceneComponent_ptr->AttachParent;}
            set {SceneComponent_ptr->AttachParent = value;}
        }
        ///<summary>Optional socket name on AttachParent that we are attached to.</summary>
        public unsafe Name AttachSocketName {
            get {return SceneComponent_ptr->AttachSocketName;}
            set {SceneComponent_ptr->AttachSocketName = value;}
        }
        ///<summary>List of child SceneComponents that are attached to us.</summary>
        public ObjectArrayField<SceneComponent> AttachChildren{ get {
            if(AttachChildren_store == null) AttachChildren_store = new ObjectArrayField<SceneComponent> (&SceneComponent_ptr->AttachChildren);
            return AttachChildren_store;
        } }
        private ObjectArrayField<SceneComponent> AttachChildren_store;

        ///<summary>Set of attached SceneComponents that were attached by the client so we can fix up AttachChildren when it is replicated to us.</summary>
        public ObjectArrayField<SceneComponent> ClientAttachedChildren{ get {
            if(ClientAttachedChildren_store == null) ClientAttachedChildren_store = new ObjectArrayField<SceneComponent> (&SceneComponent_ptr->ClientAttachedChildren);
            return ClientAttachedChildren_store;
        } }
        private ObjectArrayField<SceneComponent> ClientAttachedChildren_store;

        ///<summary>Location of the component relative to its parent</summary>
        public unsafe Vector RelativeLocation {
            get {return SceneComponent_ptr->RelativeLocation;}
        }
        ///<summary>Rotation of the component relative to its parent</summary>
        public unsafe Rotator RelativeRotation {
            get {return SceneComponent_ptr->RelativeRotation;}
        }
        ///<summary>Non-uniform scaling of the component relative to its parent.</summary>
        ///<remarks>Note that scaling is always applied in local space (no shearing etc)</remarks>
        public unsafe Vector RelativeScale3D {
            get {return SceneComponent_ptr->RelativeScale3D;}
        }
        ///<summary>Velocity of the component.</summary>
        ///<remarks>
        ///@see GetComponentVelocity()
        ///</remarks>
        public unsafe Vector ComponentVelocity {
            get {return SceneComponent_ptr->ComponentVelocity;}
            set {SceneComponent_ptr->ComponentVelocity = value;}
        }
        public bool bComponentToWorldUpdated {
            get {return Main.GetGetBoolPropertyByName(this, "bComponentToWorldUpdated"); }
            set {Main.SetGetBoolPropertyByName(this, "bComponentToWorldUpdated", value); }
        }
        public bool bAbsoluteLocation {
            get {return Main.GetGetBoolPropertyByName(this, "bAbsoluteLocation"); }
            set {Main.SetGetBoolPropertyByName(this, "bAbsoluteLocation", value); }
        }
        public bool bAbsoluteRotation {
            get {return Main.GetGetBoolPropertyByName(this, "bAbsoluteRotation"); }
            set {Main.SetGetBoolPropertyByName(this, "bAbsoluteRotation", value); }
        }
        public bool bAbsoluteScale {
            get {return Main.GetGetBoolPropertyByName(this, "bAbsoluteScale"); }
            set {Main.SetGetBoolPropertyByName(this, "bAbsoluteScale", value); }
        }
        public bool bVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bVisible"); }
        }
        public bool bHiddenInGame {
            get {return Main.GetGetBoolPropertyByName(this, "bHiddenInGame"); }
        }
        public bool bShouldUpdatePhysicsVolume {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldUpdatePhysicsVolume"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldUpdatePhysicsVolume", value); }
        }
        public bool bBoundsChangeTriggersStreamingDataRebuild {
            get {return Main.GetGetBoolPropertyByName(this, "bBoundsChangeTriggersStreamingDataRebuild"); }
            set {Main.SetGetBoolPropertyByName(this, "bBoundsChangeTriggersStreamingDataRebuild", value); }
        }
        public bool bUseAttachParentBound {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAttachParentBound"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseAttachParentBound", value); }
        }
        public bool bVisualizeComponent {
            get {return Main.GetGetBoolPropertyByName(this, "bVisualizeComponent"); }
            set {Main.SetGetBoolPropertyByName(this, "bVisualizeComponent", value); }
        }
        ///<summary>How often this component is allowed to move, used to make various optimizations. Only safe to set in constructor.</summary>
        public unsafe byte Mobility {
            get {return SceneComponent_ptr->Mobility;}
        }
        ///<summary>If detail mode is >= system detail mode, primitive won't be rendered.</summary>
        public unsafe byte DetailMode {
            get {return SceneComponent_ptr->DetailMode;}
        }
         //TODO: multicast delegate FPhysicsVolumeChanged PhysicsVolumeChangedDelegate
        static SceneComponent() {
            StaticClass = Main.GetClass("SceneComponent");
        }
        internal unsafe SceneComponent_fields* SceneComponent_ptr => (SceneComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SceneComponent(IntPtr p) => UObject.Make<SceneComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SceneComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SceneComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
