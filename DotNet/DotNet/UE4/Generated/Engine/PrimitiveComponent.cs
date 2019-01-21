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
    ///<summary>PrimitiveComponents are SceneComponents that contain or generate some sort of geometry, generally to be rendered or used as collision data.</summary>
    ///<remarks>
    ///There are several subclasses for the various types of geometry, but the most common by far are the ShapeComponents (Capsule, Sphere, Box), StaticMeshComponent, and SkeletalMeshComponent.
    ///ShapeComponents generate geometry that is used for collision detection but are not rendered, while StaticMeshComponents and SkeletalMeshComponents contain pre-built geometry that is rendered, but can also be used for collision detection.
    ///</remarks>
    public unsafe partial class PrimitiveComponent : SceneComponent  {

        ///<summary>Add Angular Impulse</summary>
        public void AddAngularImpulse(Vector Impulse, Name BoneName, bool bVelChange)  => 
            PrimitiveComponent_methods.AddAngularImpulse_method.Invoke(ObjPointer, Impulse, BoneName, bVelChange);

        ///<summary>Add an angular impulse to a single rigid body.</summary>
        ///<remarks>
        ///Good for one time instant burst.
        ///
        ///@param  AngularImpulse  Magnitude and direction of impulse to apply. Direction is axis of rotation.
        ///@param  BoneName        If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body.
        ///@param  bVelChange      If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect).
        ///</remarks>
        public void AddAngularImpulseInDegrees(Vector Impulse, Name BoneName, bool bVelChange)  => 
            PrimitiveComponent_methods.AddAngularImpulseInDegrees_method.Invoke(ObjPointer, Impulse, BoneName, bVelChange);

        ///<summary>Add an angular impulse to a single rigid body.</summary>
        ///<remarks>
        ///Good for one time instant burst.
        ///
        ///@param  AngularImpulse  Magnitude and direction of impulse to apply. Direction is axis of rotation.
        ///@param  BoneName        If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body.
        ///@param  bVelChange      If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect).
        ///</remarks>
        public void AddAngularImpulseInRadians(Vector Impulse, Name BoneName, bool bVelChange)  => 
            PrimitiveComponent_methods.AddAngularImpulseInRadians_method.Invoke(ObjPointer, Impulse, BoneName, bVelChange);

        ///<summary>Add a force to a single rigid body.</summary>
        ///<remarks>
        ///This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force.
        ///
        ///@param  Force            Force vector to apply. Magnitude indicates strength of force.
        ///@param  BoneName         If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
        ///@param  bAccelChange If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect).
        ///</remarks>
        public void AddForce(Vector Force, Name BoneName, bool bAccelChange)  => 
            PrimitiveComponent_methods.AddForce_method.Invoke(ObjPointer, Force, BoneName, bAccelChange);

        ///<summary>Add a force to a single rigid body at a particular location in world space.</summary>
        ///<remarks>
        ///This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force.
        ///
        ///@param Force            Force vector to apply. Magnitude indicates strength of force.
        ///@param Location         Location to apply force, in world space.
        ///@param BoneName         If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
        ///</remarks>
        public void AddForceAtLocation(Vector Force, Vector Location, Name BoneName)  => 
            PrimitiveComponent_methods.AddForceAtLocation_method.Invoke(ObjPointer, Force, Location, BoneName);

        ///<summary>Add a force to a single rigid body at a particular location.</summary>
        ///<remarks>
        ///Both Force and Location should be in body space.
        ///This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force.
        ///
        ///@param Force            Force vector to apply. Magnitude indicates strength of force.
        ///@param Location         Location to apply force, in component space.
        ///@param BoneName         If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
        ///</remarks>
        public void AddForceAtLocationLocal(Vector Force, Vector Location, Name BoneName)  => 
            PrimitiveComponent_methods.AddForceAtLocationLocal_method.Invoke(ObjPointer, Force, Location, BoneName);

        ///<summary>Add an impulse to a single rigid body.</summary>
        ///<remarks>
        ///Good for one time instant burst.
        ///
        ///@param  Impulse         Magnitude and direction of impulse to apply.
        ///@param  BoneName        If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body.
        ///@param  bVelChange      If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect).
        ///</remarks>
        public void AddImpulse(Vector Impulse, Name BoneName, bool bVelChange)  => 
            PrimitiveComponent_methods.AddImpulse_method.Invoke(ObjPointer, Impulse, BoneName, bVelChange);

        ///<summary>Add an impulse to a single rigid body at a specific location.</summary>
        ///<remarks>
        ///@param  Impulse         Magnitude and direction of impulse to apply.
        ///@param  Location        Point in world space to apply impulse at.
        ///@param  BoneName        If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body.
        ///</remarks>
        public void AddImpulseAtLocation(Vector Impulse, Vector Location, Name BoneName)  => 
            PrimitiveComponent_methods.AddImpulseAtLocation_method.Invoke(ObjPointer, Impulse, Location, BoneName);

        ///<summary>Add a force to all bodies in this component, originating from the supplied world-space location.</summary>
        ///<remarks>
        ///@param Origin           Origin of force in world space.
        ///@param Radius           Radius within which to apply the force.
        ///@param Strength         Strength of force to apply.
        ///@param Falloff              Allows you to control the strength of the force as a function of distance from Origin.
        ///@param bAccelChange If true, Strength is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect).
        ///</remarks>
        public void AddRadialForce(Vector Origin, float Radius, float Strength, byte Falloff, bool bAccelChange)  => 
            PrimitiveComponent_methods.AddRadialForce_method.Invoke(ObjPointer, Origin, Radius, Strength, Falloff, bAccelChange);

        ///<summary>Add an impulse to all rigid bodies in this component, radiating out from the specified position.</summary>
        ///<remarks>
        ///@param Origin                Point of origin for the radial impulse blast, in world space
        ///@param Radius                Size of radial impulse. Beyond this distance from Origin, there will be no affect.
        ///@param Strength              Maximum strength of impulse applied to body.
        ///@param Falloff               Allows you to control the strength of the impulse as a function of distance from Origin.
        ///@param bVelChange    If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect).
        ///</remarks>
        public void AddRadialImpulse(Vector Origin, float Radius, float Strength, byte Falloff, bool bVelChange)  => 
            PrimitiveComponent_methods.AddRadialImpulse_method.Invoke(ObjPointer, Origin, Radius, Strength, Falloff, bVelChange);

        ///<summary>Add Torque</summary>
        public void AddTorque(Vector Torque, Name BoneName, bool bAccelChange)  => 
            PrimitiveComponent_methods.AddTorque_method.Invoke(ObjPointer, Torque, BoneName, bAccelChange);

        ///<summary>Add a torque to a single rigid body.</summary>
        ///<remarks>
        ///@param Torque           Torque to apply. Direction is axis of rotation and magnitude is strength of torque.
        ///@param BoneName         If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body.
        ///@param bAccelChange If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect).
        ///</remarks>
        public void AddTorqueInDegrees(Vector Torque, Name BoneName, bool bAccelChange)  => 
            PrimitiveComponent_methods.AddTorqueInDegrees_method.Invoke(ObjPointer, Torque, BoneName, bAccelChange);

        ///<summary>Add a torque to a single rigid body.</summary>
        ///<remarks>
        ///@param Torque           Torque to apply. Direction is axis of rotation and magnitude is strength of torque.
        ///@param BoneName         If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body.
        ///@param bAccelChange If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect).
        ///</remarks>
        public void AddTorqueInRadians(Vector Torque, Name BoneName, bool bAccelChange)  => 
            PrimitiveComponent_methods.AddTorqueInRadians_method.Invoke(ObjPointer, Torque, BoneName, bAccelChange);

        ///<summary>Return true if the given Pawn can step up onto this component.</summary>
        ///<remarks>
        ///This controls whether they can try to step up on it when they bump in to it, not whether they can walk on it after landing on it.
        ///@param Pawn the Pawn that wants to step onto this component.
        ///@see CanCharacterStepUpOn
        ///</remarks>
        public bool CanCharacterStepUp(Pawn Pawn)  => 
            PrimitiveComponent_methods.CanCharacterStepUp_method.Invoke(ObjPointer, Pawn);

        ///<summary>Clear the list of actors we ignore when moving.</summary>
        public void ClearMoveIgnoreActors()  => 
            PrimitiveComponent_methods.ClearMoveIgnoreActors_method.Invoke(ObjPointer);

        ///<summary>Clear the list of components we ignore when moving.</summary>
        public void ClearMoveIgnoreComponents()  => 
            PrimitiveComponent_methods.ClearMoveIgnoreComponents_method.Invoke(ObjPointer);

        ///<summary>Returns the list of actors we currently ignore when moving.</summary>
        public IReadOnlyCollection<Actor> CopyArrayOfMoveIgnoreActors()  => 
            PrimitiveComponent_methods.CopyArrayOfMoveIgnoreActors_method.Invoke(ObjPointer);

        ///<summary>Returns the list of actors we currently ignore when moving.</summary>
        public IReadOnlyCollection<PrimitiveComponent> CopyArrayOfMoveIgnoreComponents()  => 
            PrimitiveComponent_methods.CopyArrayOfMoveIgnoreComponents_method.Invoke(ObjPointer);

        ///<summary>Creates a Dynamic Material Instance for the specified element index.</summary>
        ///<remarks>
        ///The parent of the instance is set to the material being replaced.
        ///@param ElementIndex - The index of the skin to replace the material for.  If invalid, the material is unchanged and NULL is returned.
        ///</remarks>
        public MaterialInstanceDynamic CreateAndSetMaterialInstanceDynamic(int ElementIndex)  => 
            PrimitiveComponent_methods.CreateAndSetMaterialInstanceDynamic_method.Invoke(ObjPointer, ElementIndex);

        ///<summary>Creates a Dynamic Material Instance for the specified element index.</summary>
        ///<remarks>
        ///The parent of the instance is set to the material being replaced.
        ///@param ElementIndex - The index of the skin to replace the material for.  If invalid, the material is unchanged and NULL is returned.
        ///</remarks>
        public MaterialInstanceDynamic CreateAndSetMaterialInstanceDynamicFromMaterial(int ElementIndex, MaterialInterface Parent)  => 
            PrimitiveComponent_methods.CreateAndSetMaterialInstanceDynamicFromMaterial_method.Invoke(ObjPointer, ElementIndex, Parent);

        ///<summary>Creates a Dynamic Material Instance for the specified element index, optionally from the supplied material.</summary>
        ///<remarks>
        ///@param ElementIndex - The index of the skin to replace the material for.  If invalid, the material is unchanged and NULL is returned.
        ///</remarks>
        public MaterialInstanceDynamic CreateDynamicMaterialInstance(int ElementIndex, MaterialInterface SourceMaterial, Name OptionalName)  => 
            PrimitiveComponent_methods.CreateDynamicMaterialInstance_method.Invoke(ObjPointer, ElementIndex, SourceMaterial, OptionalName);

        ///<summary>Returns the angular damping of this component.</summary>
        public float GetAngularDamping()  => 
            PrimitiveComponent_methods.GetAngularDamping_method.Invoke(ObjPointer);

        ///<summary>Get the center of mass of a single body.</summary>
        ///<remarks>
        ///In the case of a welded body this will return the center of mass of the entire welded body (including its parent and children)
        ///Objects that are not simulated return (0,0,0) as they do not have COM
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to get center of mass of. 'None' indicates root body.
        ///</remarks>
        public Vector GetCenterOfMass(Name BoneName)  => 
            PrimitiveComponent_methods.GetCenterOfMass_method.Invoke(ObjPointer, BoneName);

        ///<summary>Returns the distance and closest point to the collision surface.</summary>
        ///<remarks>
        ///Component must have simple collision to be queried for closest point.
        ///
        ///@param Point                          World 3D vector
        ///@param OutPointOnBody         Point on the surface of collision closest to Point
        ///@param BoneName                       If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.
        ///
        ///@return               Success if returns > 0.f, if returns 0.f, it is either not convex or inside of the point
        ///                              If returns < 0.f, this primitive does not have collsion
        ///</remarks>
        public (Vector, float) GetClosestPointOnCollision(Vector Point, Name BoneName)  => 
            PrimitiveComponent_methods.GetClosestPointOnCollision_method.Invoke(ObjPointer, Point, BoneName);

        ///<summary>Returns the form of collision for this component</summary>
        public byte GetCollisionEnabled()  => 
            PrimitiveComponent_methods.GetCollisionEnabled_method.Invoke(ObjPointer);

        ///<summary>Gets the collision object type</summary>
        public byte GetCollisionObjectType()  => 
            PrimitiveComponent_methods.GetCollisionObjectType_method.Invoke(ObjPointer);

        ///<summary>Get the collision profile name</summary>
        public Name GetCollisionProfileName()  => 
            PrimitiveComponent_methods.GetCollisionProfileName_method.Invoke(ObjPointer);

        ///<summary>Gets the response type given a specific channel</summary>
        public byte GetCollisionResponseToChannel(byte Channel)  => 
            PrimitiveComponent_methods.GetCollisionResponseToChannel_method.Invoke(ObjPointer, Channel);

        ///<summary>If true, this component will generate overlap events when it is overlapping other components (eg Begin Overlap).</summary>
        ///<remarks>
        ///Both components (this and the other) must have this enabled for overlap events to occur.
        ///
        ///@see [Overlap Events](https://docs.unrealengine.com/latest/INT/Engine/Physics/Collision/index.html#overlapandgenerateoverlapevents)
        ///@see UpdateOverlaps(), BeginComponentOverlap(), EndComponentOverlap()
        ///</remarks>
        public bool GetGenerateOverlapEvents()  => 
            PrimitiveComponent_methods.GetGenerateOverlapEvents_method.Invoke(ObjPointer);

        ///<summary>Returns the inertia tensor of this component in kg cm^2. The inertia tensor is in local component space.</summary>
        public Vector GetInertiaTensor(Name BoneName)  => 
            PrimitiveComponent_methods.GetInertiaTensor_method.Invoke(ObjPointer, BoneName);

        ///<summary>Returns the linear damping of this component.</summary>
        public float GetLinearDamping()  => 
            PrimitiveComponent_methods.GetLinearDamping_method.Invoke(ObjPointer);

        ///<summary>Returns the mass of this component in kg.</summary>
        public float GetMass()  => 
            PrimitiveComponent_methods.GetMass_method.Invoke(ObjPointer);

        ///<summary>Returns the mass scale used to calculate the mass of a single physics body</summary>
        public float GetMassScale(Name BoneName)  => 
            PrimitiveComponent_methods.GetMassScale_method.Invoke(ObjPointer, BoneName);

        ///<summary>
        ///Returns the material used by the element at the specified index
        ///@
        ///</summary>
        ///<remarks>
        ///param ElementIndex - The element to access the material of.
        ///@return the material used by the indexed element of this mesh.
        ///</remarks>
        public MaterialInterface GetMaterial(int ElementIndex)  => 
            PrimitiveComponent_methods.GetMaterial_method.Invoke(ObjPointer, ElementIndex);

        ///<summary>Try and retrieve the material applied to a particular collision face of mesh.</summary>
        ///<remarks>
        ///Used with face index returned from collision trace.
        ///     @param  FaceIndex               Face index from hit result that was hit by a trace
        ///     @param  SectionIndex    Section of the mesh that the face belongs to
        ///     @return                                 Material applied to section that the hit face belongs to
        ///</remarks>
        public (int, MaterialInterface) GetMaterialFromCollisionFaceIndex(int FaceIndex)  => 
            PrimitiveComponent_methods.GetMaterialFromCollisionFaceIndex_method.Invoke(ObjPointer, FaceIndex);

        ///<summary>@return number of material elements in this primitive</summary>
        public int GetNumMaterials()  => 
            PrimitiveComponent_methods.GetNumMaterials_method.Invoke(ObjPointer);

        ///<summary>Returns a list of actors that this component is overlapping.</summary>
        ///<remarks>
        ///@param OverlappingActors             [out] Returned list of overlapping actors
        ///@param ClassFilter                   [optional] If set, only returns actors of this class or subclasses
        ///</remarks>
        public IReadOnlyCollection<Actor> GetOverlappingActors(SubclassOf<Actor> ClassFilter)  => 
            PrimitiveComponent_methods.GetOverlappingActors_method.Invoke(ObjPointer, ClassFilter);

        ///<summary>Returns unique list of components this component is overlapping.</summary>
        public IReadOnlyCollection<PrimitiveComponent> GetOverlappingComponents()  => 
            PrimitiveComponent_methods.GetOverlappingComponents_method.Invoke(ObjPointer);

        ///<summary>Get Physics Angular Velocity</summary>
        public Vector GetPhysicsAngularVelocity(Name BoneName)  => 
            PrimitiveComponent_methods.GetPhysicsAngularVelocity_method.Invoke(ObjPointer, BoneName);

        ///<summary>Get the angular velocity of a single body, in degrees per second.</summary>
        ///<remarks>
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
        ///</remarks>
        public Vector GetPhysicsAngularVelocityInDegrees(Name BoneName)  => 
            PrimitiveComponent_methods.GetPhysicsAngularVelocityInDegrees_method.Invoke(ObjPointer, BoneName);

        ///<summary>Get the angular velocity of a single body, in radians per second.</summary>
        ///<remarks>
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
        ///</remarks>
        public Vector GetPhysicsAngularVelocityInRadians(Name BoneName)  => 
            PrimitiveComponent_methods.GetPhysicsAngularVelocityInRadians_method.Invoke(ObjPointer, BoneName);

        ///<summary>Get the linear velocity of a single body.</summary>
        ///<remarks>
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
        ///</remarks>
        public Vector GetPhysicsLinearVelocity(Name BoneName)  => 
            PrimitiveComponent_methods.GetPhysicsLinearVelocity_method.Invoke(ObjPointer, BoneName);

        ///<summary>Get the linear velocity of a point on a single body.</summary>
        ///<remarks>
        ///@param Point                    Point is specified in world space.
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
        ///</remarks>
        public Vector GetPhysicsLinearVelocityAtPoint(Vector Point, Name BoneName)  => 
            PrimitiveComponent_methods.GetPhysicsLinearVelocityAtPoint_method.Invoke(ObjPointer, Point, BoneName);

        ///<summary>Returns the slope override struct for this component.</summary>
        public void GetWalkableSlopeOverride(WalkableSlopeOverride ReturnValue)  => 
            PrimitiveComponent_methods.GetWalkableSlopeOverride_method.Invoke(ObjPointer, ReturnValue);

        ///<summary>Tells this component whether to ignore collision with all components of a specific Actor when this component is moved.</summary>
        ///<remarks>
        ///Components on the other Actor may also need to be told to do the same when they move.
        ///Does not affect movement of this component when simulating physics.
        ///</remarks>
        public void IgnoreActorWhenMoving(Actor Actor, bool bShouldIgnore)  => 
            PrimitiveComponent_methods.IgnoreActorWhenMoving_method.Invoke(ObjPointer, Actor, bShouldIgnore);

        ///<summary>Tells this component whether to ignore collision with another component when this component is moved.</summary>
        ///<remarks>
        ///The other components may also need to be told to do the same when they move.
        ///Does not affect movement of this component when simulating physics.
        ///</remarks>
        public void IgnoreComponentWhenMoving(PrimitiveComponent Component, bool bShouldIgnore)  => 
            PrimitiveComponent_methods.IgnoreComponentWhenMoving_method.Invoke(ObjPointer, Component, bShouldIgnore);

        ///<summary>Returns if any body in this component is currently awake and simulating.</summary>
        public bool IsAnyRigidBodyAwake()  => 
            PrimitiveComponent_methods.IsAnyRigidBodyAwake_method.Invoke(ObjPointer);

        ///<summary>Returns whether this component is affected by gravity. Returns always false if the component is not simulated.</summary>
        public bool IsGravityEnabled()  => 
            PrimitiveComponent_methods.IsGravityEnabled_method.Invoke(ObjPointer);

        ///<summary>Check whether this component is overlapping any component of the given Actor.</summary>
        ///<remarks>
        ///@param Other Actor to test this component against.
        ///@return Whether this component is overlapping any component of the given Actor.
        ///</remarks>
        public bool IsOverlappingActor(Actor Other)  => 
            PrimitiveComponent_methods.IsOverlappingActor_method.Invoke(ObjPointer, Other);

        ///<summary>Check whether this component is overlapping another component.</summary>
        ///<remarks>
        ///@param OtherComp Component to test this component against.
        ///@return Whether this component is overlapping another component.
        ///</remarks>
        public bool IsOverlappingComponent(PrimitiveComponent OtherComp)  => 
            PrimitiveComponent_methods.IsOverlappingComponent_method.Invoke(ObjPointer, OtherComp);

        ///<summary>
        ///Perform a box overlap against a single component as an AABB (No rotation)
        ///@
        ///</summary>
        ///<remarks>
        ///param InBoxCentre The centre of the box to overlap with the component
        ///@param InBox Description of the box to use in the overlap
        ///@param bTraceComplex Whether or not to trace the complex physics representation or just the simple representation
        ///@param bShowTrace Whether or not to draw the trace in the world (for debugging)
        ///@param bPersistentShowTrace Whether or not to make the debugging draw stay in the world permanently
        ///</remarks>
        public (Vector, Vector, Name, HitResult, bool) K2_BoxOverlapComponent(Vector InBoxCentre, Box InBox, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace)  => 
            PrimitiveComponent_methods.K2_BoxOverlapComponent_method.Invoke(ObjPointer, InBoxCentre, InBox, bTraceComplex, bShowTrace, bPersistentShowTrace);

        ///<summary>Utility to see if there is any form of collision (query or physics) enabled on this component.</summary>
        public bool K2_IsCollisionEnabled()  => 
            PrimitiveComponent_methods.K2_IsCollisionEnabled_method.Invoke(ObjPointer);

        ///<summary>Utility to see if there is any physics collision enabled on this component.</summary>
        public bool K2_IsPhysicsCollisionEnabled()  => 
            PrimitiveComponent_methods.K2_IsPhysicsCollisionEnabled_method.Invoke(ObjPointer);

        ///<summary>Utility to see if there is any query collision enabled on this component.</summary>
        public bool K2_IsQueryCollisionEnabled()  => 
            PrimitiveComponent_methods.K2_IsQueryCollisionEnabled_method.Invoke(ObjPointer);

        ///<summary>
        ///Perform a line trace against a single component
        ///@
        ///</summary>
        ///<remarks>
        ///param TraceStart The start of the trace in world-space
        ///@param TraceEnd The end of the trace in world-space
        ///@param bTraceComplex Whether or not to trace the complex physics representation or just the simple representation
        ///@param bShowTrace Whether or not to draw the trace in the world (for debugging)
        ///@param bPersistentShowTrace Whether or not to make the debugging draw stay in the world permanently
        ///</remarks>
        public (Vector, Vector, Name, HitResult, bool) K2_LineTraceComponent(Vector TraceStart, Vector TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace)  => 
            PrimitiveComponent_methods.K2_LineTraceComponent_method.Invoke(ObjPointer, TraceStart, TraceEnd, bTraceComplex, bShowTrace, bPersistentShowTrace);

        ///<summary>
        ///Perform a sphere overlap against a single component
        ///@
        ///</summary>
        ///<remarks>
        ///param InSphereCentre The centre of the sphere to overlap with the component
        ///@param InSphereRadius The Radius of the sphere to overlap with the component
        ///@param bTraceComplex Whether or not to trace the complex physics representation or just the simple representation
        ///@param bShowTrace Whether or not to draw the trace in the world (for debugging)
        ///@param bPersistentShowTrace Whether or not to make the debugging draw stay in the world permanently
        ///</remarks>
        public (Vector, Vector, Name, HitResult, bool) K2_SphereOverlapComponent(Vector InSphereCentre, float InSphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace)  => 
            PrimitiveComponent_methods.K2_SphereOverlapComponent_method.Invoke(ObjPointer, InSphereCentre, InSphereRadius, bTraceComplex, bShowTrace, bPersistentShowTrace);

        ///<summary>
        ///Perform a sphere trace against a single component
        ///@
        ///</summary>
        ///<remarks>
        ///param TraceStart The start of the trace in world-space
        ///@param TraceEnd The end of the trace in world-space
        ///@param SphereRadius Radius of the sphere to trace against the component
        ///@param bTraceComplex Whether or not to trace the complex physics representation or just the simple representation
        ///@param bShowTrace Whether or not to draw the trace in the world (for debugging)
        ///@param bPersistentShowTrace Whether or not to make the debugging draw stay in the world permanently
        ///</remarks>
        public (Vector, Vector, Name, HitResult, bool) K2_SphereTraceComponent(Vector TraceStart, Vector TraceEnd, float SphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace)  => 
            PrimitiveComponent_methods.K2_SphereTraceComponent_method.Invoke(ObjPointer, TraceStart, TraceEnd, SphereRadius, bTraceComplex, bShowTrace, bPersistentShowTrace);

        ///<summary>Force a single body back to sleep.</summary>
        ///<remarks>
        ///@param  BoneName        If a SkeletalMeshComponent, name of body to put to sleep. 'None' indicates root body.
        ///</remarks>
        public void PutRigidBodyToSleep(Name BoneName)  => 
            PrimitiveComponent_methods.PutRigidBodyToSleep_method.Invoke(ObjPointer, BoneName);

        ///<summary>Scales the given vector by the world space moment of inertia. Useful for computing the torque needed to rotate an object.</summary>
        public Vector ScaleByMomentOfInertia(Vector InputVector, Name BoneName)  => 
            PrimitiveComponent_methods.ScaleByMomentOfInertia_method.Invoke(ObjPointer, InputVector, BoneName);

        ///<summary>Change the mass scale used fo all bodies in this component</summary>
        public void SetAllMassScale(float InMassScale)  => 
            PrimitiveComponent_methods.SetAllMassScale_method.Invoke(ObjPointer, InMassScale);

        ///<summary>Set All Physics Angular Velocity</summary>
        public void SetAllPhysicsAngularVelocity(Vector NewAngVel, bool bAddToCurrent)  => 
            PrimitiveComponent_methods.SetAllPhysicsAngularVelocity_method.Invoke(ObjPointer, NewAngVel, bAddToCurrent);

        ///<summary>Set the angular velocity of all bodies in this component.</summary>
        ///<remarks>
        ///@param NewAngVel                New angular velocity to apply to physics, in degrees per second.
        ///@param bAddToCurrent    If true, NewAngVel is added to the existing angular velocity of all bodies.
        ///</remarks>
        public void SetAllPhysicsAngularVelocityInDegrees(Vector NewAngVel, bool bAddToCurrent)  => 
            PrimitiveComponent_methods.SetAllPhysicsAngularVelocityInDegrees_method.Invoke(ObjPointer, NewAngVel, bAddToCurrent);

        ///<summary>Set the angular velocity of all bodies in this component.</summary>
        ///<remarks>
        ///@param NewAngVel                New angular velocity to apply to physics, in radians per second.
        ///@param bAddToCurrent    If true, NewAngVel is added to the existing angular velocity of all bodies.
        ///</remarks>
        public void SetAllPhysicsAngularVelocityInRadians(Vector NewAngVel, bool bAddToCurrent)  => 
            PrimitiveComponent_methods.SetAllPhysicsAngularVelocityInRadians_method.Invoke(ObjPointer, NewAngVel, bAddToCurrent);

        ///<summary>Set the linear velocity of all bodies in this component.</summary>
        ///<remarks>
        ///@param NewVel                   New linear velocity to apply to physics.
        ///@param bAddToCurrent    If true, NewVel is added to the existing velocity of the body.
        ///</remarks>
        public void SetAllPhysicsLinearVelocity(Vector NewVel, bool bAddToCurrent)  => 
            PrimitiveComponent_methods.SetAllPhysicsLinearVelocity_method.Invoke(ObjPointer, NewVel, bAddToCurrent);

        ///<summary>Set whether all bodies in this component should use Continuous Collision Detection</summary>
        public void SetAllUseCCD(bool InUseCCD)  => 
            PrimitiveComponent_methods.SetAllUseCCD_method.Invoke(ObjPointer, InUseCCD);

        ///<summary>Sets the angular damping of this component.</summary>
        public void SetAngularDamping(float InDamping)  => 
            PrimitiveComponent_methods.SetAngularDamping_method.Invoke(ObjPointer, InDamping);

        ///<summary>Scale the bounds of this object, used for frustum culling. Useful for features like WorldPositionOffset.</summary>
        public void SetBoundsScale(float NewBoundsScale)  => 
            PrimitiveComponent_methods.SetBoundsScale_method.Invoke(ObjPointer, NewBoundsScale);

        ///<summary>Changes the value of CastShadow.</summary>
        public void SetCastShadow(bool NewCastShadow)  => 
            PrimitiveComponent_methods.SetCastShadow_method.Invoke(ObjPointer, NewCastShadow);

        ///<summary>Set the center of mass of a single body.</summary>
        ///<remarks>
        ///This will offset the physx-calculated center of mass.
        ///Note that in the case where multiple bodies are attached together, the center of mass will be set for the entire group.
        ///@param CenterOfMassOffset               User specified offset for the center of mass of this object, from the calculated location.
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.
        ///</remarks>
        public void SetCenterOfMass(Vector CenterOfMassOffset, Name BoneName)  => 
            PrimitiveComponent_methods.SetCenterOfMass_method.Invoke(ObjPointer, CenterOfMassOffset, BoneName);

        ///<summary>Controls what kind of collision is enabled for this body</summary>
        public void SetCollisionEnabled(byte NewType)  => 
            PrimitiveComponent_methods.SetCollisionEnabled_method.Invoke(ObjPointer, NewType);

        ///<summary>
        ///Changes the collision channel that this object uses when it moves
        ///@
        ///</summary>
        ///<remarks>param      Channel     The new channel for this component to use</remarks>
        public void SetCollisionObjectType(byte Channel)  => 
            PrimitiveComponent_methods.SetCollisionObjectType_method.Invoke(ObjPointer, Channel);

        ///<summary>
        ///Set Collision Profile Name
        ///This function is called by constructors when they set ProfileName
        ///This will change current CollisionProfileName to be this, and overwrite Collision Setting
        ///@
        ///</summary>
        ///<remarks>param InCollisionProfileName : New Profile Name</remarks>
        public void SetCollisionProfileName(Name InCollisionProfileName)  => 
            PrimitiveComponent_methods.SetCollisionProfileName_method.Invoke(ObjPointer, InCollisionProfileName);

        ///<summary>Changes all ResponseToChannels container for this PrimitiveComponent.</summary>
        ///<remarks>
        ///to be NewResponse
        ///
        ///@param       NewResponse  What the new response should be to the supplied Channel
        ///</remarks>
        public void SetCollisionResponseToAllChannels(byte NewResponse)  => 
            PrimitiveComponent_methods.SetCollisionResponseToAllChannels_method.Invoke(ObjPointer, NewResponse);

        ///<summary>Changes a member of the ResponseToChannels container for this PrimitiveComponent.</summary>
        ///<remarks>
        ///@param       Channel      The channel to change the response of
        ///@param       NewResponse  What the new response should be to the supplied Channel
        ///</remarks>
        public void SetCollisionResponseToChannel(byte Channel, byte NewResponse)  => 
            PrimitiveComponent_methods.SetCollisionResponseToChannel_method.Invoke(ObjPointer, Channel, NewResponse);

        ///<summary>Sets the constraint mode of the component.</summary>
        ///<remarks>
        ///@param ConstraintMode        The type of constraint to use.
        ///</remarks>
        public void SetConstraintMode(byte ConstraintMode)  => 
            PrimitiveComponent_methods.SetConstraintMode_method.Invoke(ObjPointer, ConstraintMode);

        ///<summary>Changes the value of CullDistance.</summary>
        ///<remarks>
        ///@param NewCullDistance - The value to assign to CullDistance.
        ///</remarks>
        public void SetCullDistance(float NewCullDistance)  => 
            PrimitiveComponent_methods.SetCullDistance_method.Invoke(ObjPointer, NewCullDistance);

        ///<summary>Sets the CustomDepth stencil value (0 - 255) and marks the render state dirty.</summary>
        public void SetCustomDepthStencilValue(int Value)  => 
            PrimitiveComponent_methods.SetCustomDepthStencilValue_method.Invoke(ObjPointer, Value);

        ///<summary>Sets the CustomDepth stencil write mask and marks the render state dirty.</summary>
        public void SetCustomDepthStencilWriteMask(ERendererStencilMask WriteMaskBit)  => 
            PrimitiveComponent_methods.SetCustomDepthStencilWriteMask_method.Invoke(ObjPointer, WriteMaskBit);

        ///<summary>Enables/disables whether this component is affected by gravity. This applies only to components with bSimulatePhysics set to true.</summary>
        public void SetEnableGravity(bool bGravityEnabled)  => 
            PrimitiveComponent_methods.SetEnableGravity_method.Invoke(ObjPointer, bGravityEnabled);

        ///<summary>Set Generate Overlap Events</summary>
        public void SetGenerateOverlapEvents(bool bInGenerateOverlapEvents)  => 
            PrimitiveComponent_methods.SetGenerateOverlapEvents_method.Invoke(ObjPointer, bInGenerateOverlapEvents);

        ///<summary>Sets the linear damping of this component.</summary>
        public void SetLinearDamping(float InDamping)  => 
            PrimitiveComponent_methods.SetLinearDamping_method.Invoke(ObjPointer, InDamping);

        ///<summary>Set Locked Axis</summary>
        public void SetLockedAxis(byte LockedAxis)  => 
            PrimitiveComponent_methods.SetLockedAxis_method.Invoke(ObjPointer, LockedAxis);

        ///<summary>Override the mass (in Kg) of a single physics body.</summary>
        ///<remarks>
        ///Note that in the case where multiple bodies are attached together, the override mass will be set for the entire group.
        ///Set the Override Mass to false if you want to reset the body's mass to the auto-calculated physx mass.
        ///</remarks>
        public void SetMassOverrideInKg(Name BoneName, float MassInKg, bool bOverrideMass)  => 
            PrimitiveComponent_methods.SetMassOverrideInKg_method.Invoke(ObjPointer, BoneName, MassInKg, bOverrideMass);

        ///<summary>Change the mass scale used to calculate the mass of a single physics body</summary>
        public void SetMassScale(Name BoneName, float InMassScale)  => 
            PrimitiveComponent_methods.SetMassScale_method.Invoke(ObjPointer, BoneName, InMassScale);

        ///<summary>Changes the material applied to an element of the mesh.</summary>
        ///<remarks>
        ///@param ElementIndex - The element to access the material of.
        ///@return the material used by the indexed element of this mesh.
        ///</remarks>
        public void SetMaterial(int ElementIndex, MaterialInterface Material)  => 
            PrimitiveComponent_methods.SetMaterial_method.Invoke(ObjPointer, ElementIndex, Material);

        ///<summary>Changes the material applied to an element of the mesh.</summary>
        ///<remarks>
        ///@param MaterialSlotName - The slot name to access the material of.
        ///@return the material used by the indexed element of this mesh.
        ///</remarks>
        public void SetMaterialByName(Name MaterialSlotName, MaterialInterface Material)  => 
            PrimitiveComponent_methods.SetMaterialByName_method.Invoke(ObjPointer, MaterialSlotName, Material);

        ///<summary>
        ///Changes the value of bNotifyRigidBodyCollision
        ///@
        ///</summary>
        ///<remarks>param bNewNotifyRigidBodyCollision - The value to assign to bNotifyRigidBodyCollision</remarks>
        public void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)  => 
            PrimitiveComponent_methods.SetNotifyRigidBodyCollision_method.Invoke(ObjPointer, bNewNotifyRigidBodyCollision);

        ///<summary>Changes the value of bOnlyOwnerSee.</summary>
        public void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)  => 
            PrimitiveComponent_methods.SetOnlyOwnerSee_method.Invoke(ObjPointer, bNewOnlyOwnerSee);

        ///<summary>Changes the value of bOwnerNoSee.</summary>
        public void SetOwnerNoSee(bool bNewOwnerNoSee)  => 
            PrimitiveComponent_methods.SetOwnerNoSee_method.Invoke(ObjPointer, bNewOwnerNoSee);

        ///<summary>Set Physics Angular Velocity</summary>
        public void SetPhysicsAngularVelocity(Vector NewAngVel, bool bAddToCurrent, Name BoneName)  => 
            PrimitiveComponent_methods.SetPhysicsAngularVelocity_method.Invoke(ObjPointer, NewAngVel, bAddToCurrent, BoneName);

        ///<summary>Set the angular velocity of a single body.</summary>
        ///<remarks>
        ///This should be used cautiously - it may be better to use AddTorque or AddImpulse.
        ///
        ///@param NewAngVel                New angular velocity to apply to body, in degrees per second.
        ///@param bAddToCurrent    If true, NewAngVel is added to the existing angular velocity of the body.
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body.
        ///</remarks>
        public void SetPhysicsAngularVelocityInDegrees(Vector NewAngVel, bool bAddToCurrent, Name BoneName)  => 
            PrimitiveComponent_methods.SetPhysicsAngularVelocityInDegrees_method.Invoke(ObjPointer, NewAngVel, bAddToCurrent, BoneName);

        ///<summary>Set the angular velocity of a single body.</summary>
        ///<remarks>
        ///This should be used cautiously - it may be better to use AddTorque or AddImpulse.
        ///
        ///@param NewAngVel                New angular velocity to apply to body, in radians per second.
        ///@param bAddToCurrent    If true, NewAngVel is added to the existing angular velocity of the body.
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body.
        ///</remarks>
        public void SetPhysicsAngularVelocityInRadians(Vector NewAngVel, bool bAddToCurrent, Name BoneName)  => 
            PrimitiveComponent_methods.SetPhysicsAngularVelocityInRadians_method.Invoke(ObjPointer, NewAngVel, bAddToCurrent, BoneName);

        ///<summary>Set the linear velocity of a single body.</summary>
        ///<remarks>
        ///This should be used cautiously - it may be better to use AddForce or AddImpulse.
        ///
        ///@param NewVel                   New linear velocity to apply to physics.
        ///@param bAddToCurrent    If true, NewVel is added to the existing velocity of the body.
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to modify velocity of. 'None' indicates root body.
        ///</remarks>
        public void SetPhysicsLinearVelocity(Vector NewVel, bool bAddToCurrent, Name BoneName)  => 
            PrimitiveComponent_methods.SetPhysicsLinearVelocity_method.Invoke(ObjPointer, NewVel, bAddToCurrent, BoneName);

        ///<summary>Set Physics Max Angular Velocity</summary>
        public void SetPhysicsMaxAngularVelocity(float NewMaxAngVel, bool bAddToCurrent, Name BoneName)  => 
            PrimitiveComponent_methods.SetPhysicsMaxAngularVelocity_method.Invoke(ObjPointer, NewMaxAngVel, bAddToCurrent, BoneName);

        ///<summary>Set the maximum angular velocity of a single body.</summary>
        ///<remarks>
        ///@param NewMaxAngVel             New maximum angular velocity to apply to body, in degrees per second.
        ///@param bAddToCurrent    If true, NewMaxAngVel is added to the existing maximum angular velocity of the body.
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body.
        ///</remarks>
        public void SetPhysicsMaxAngularVelocityInDegrees(float NewMaxAngVel, bool bAddToCurrent, Name BoneName)  => 
            PrimitiveComponent_methods.SetPhysicsMaxAngularVelocityInDegrees_method.Invoke(ObjPointer, NewMaxAngVel, bAddToCurrent, BoneName);

        ///<summary>Set the maximum angular velocity of a single body.</summary>
        ///<remarks>
        ///@param NewMaxAngVel             New maximum angular velocity to apply to body, in radians per second.
        ///@param bAddToCurrent    If true, NewMaxAngVel is added to the existing maximum angular velocity of the body.
        ///@param BoneName                 If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body.
        ///</remarks>
        public void SetPhysicsMaxAngularVelocityInRadians(float NewMaxAngVel, bool bAddToCurrent, Name BoneName)  => 
            PrimitiveComponent_methods.SetPhysicsMaxAngularVelocityInRadians_method.Invoke(ObjPointer, NewMaxAngVel, bAddToCurrent, BoneName);

        ///<summary>Changes the current PhysMaterialOverride for this component.</summary>
        ///<remarks>
        ///Note that if physics is already running on this component, this will _not_ alter its mass/inertia etc,
        ///it will only change its surface properties like friction.
        ///</remarks>
        public void SetPhysMaterialOverride(PhysicalMaterial NewPhysMaterial)  => 
            PrimitiveComponent_methods.SetPhysMaterialOverride_method.Invoke(ObjPointer, NewPhysMaterial);

        ///<summary>Changes the value of bReceivesDecals.</summary>
        public void SetReceivesDecals(bool bNewReceivesDecals)  => 
            PrimitiveComponent_methods.SetReceivesDecals_method.Invoke(ObjPointer, bNewReceivesDecals);

        ///<summary>Sets the bRenderCustomDepth property and marks the render state dirty.</summary>
        public void SetRenderCustomDepth(bool bValue)  => 
            PrimitiveComponent_methods.SetRenderCustomDepth_method.Invoke(ObjPointer, bValue);

        ///<summary>Sets bRenderInMainPass property and marks the render state dirty.</summary>
        public void SetRenderInMainPass(bool bValue)  => 
            PrimitiveComponent_methods.SetRenderInMainPass_method.Invoke(ObjPointer, bValue);

        ///<summary>Sets bRenderInMono property and marks the render state dirty.</summary>
        public void SetRenderInMono(bool bValue)  => 
            PrimitiveComponent_methods.SetRenderInMono_method.Invoke(ObjPointer, bValue);

        ///<summary>Sets whether or not a single body should use physics simulation, or should be 'fixed' (kinematic).</summary>
        ///<remarks>
        ///Note that if this component is currently attached to something, beginning simulation will detach it.
        ///
        ///@param  bSimulate       New simulation state for single body
        ///</remarks>
        public void SetSimulatePhysics(bool bSimulate)  => 
            PrimitiveComponent_methods.SetSimulatePhysics_method.Invoke(ObjPointer, bSimulate);

        ///<summary>Changes the value of bSingleSampleShadowFromStationaryLights.</summary>
        public void SetSingleSampleShadowFromStationaryLights(bool bNewSingleSampleShadowFromStationaryLights)  => 
            PrimitiveComponent_methods.SetSingleSampleShadowFromStationaryLights_method.Invoke(ObjPointer, bNewSingleSampleShadowFromStationaryLights);

        ///<summary>Changes the value of TranslucentSortPriority.</summary>
        public void SetTranslucentSortPriority(int NewTranslucentSortPriority)  => 
            PrimitiveComponent_methods.SetTranslucentSortPriority_method.Invoke(ObjPointer, NewTranslucentSortPriority);

        ///<summary>Set whether this component should use Continuous Collision Detection</summary>
        public void SetUseCCD(bool InUseCCD, Name BoneName)  => 
            PrimitiveComponent_methods.SetUseCCD_method.Invoke(ObjPointer, InUseCCD, BoneName);

        ///<summary>Sets a new slope override for this component instance.</summary>
        public void SetWalkableSlopeOverride(WalkableSlopeOverride NewOverride)  => 
            PrimitiveComponent_methods.SetWalkableSlopeOverride_method.Invoke(ObjPointer, NewOverride);

        ///<summary>Ensure simulation is running for all bodies in this component.</summary>
        public void WakeAllRigidBodies()  => 
            PrimitiveComponent_methods.WakeAllRigidBodies_method.Invoke(ObjPointer);

        ///<summary>'Wake' physics simulation for a single body.</summary>
        ///<remarks>
        ///@param  BoneName        If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body.
        ///</remarks>
        public void WakeRigidBody(Name BoneName)  => 
            PrimitiveComponent_methods.WakeRigidBody_method.Invoke(ObjPointer, BoneName);
        ///<summary>
        ///The minimum distance at which the primitive should be rendered,
        ///measured in world space units from the center of the primitive's bounding sphere to the camera position.
        ///</summary>
        public unsafe float MinDrawDistance {
            get {return PrimitiveComponent_ptr->MinDrawDistance;}
        }
        ///<summary>Max draw distance exposed to LDs. The real max draw distance is the min (disregarding 0) of this and volumes affecting this object.</summary>
        public unsafe float LDMaxDrawDistance {
            get {return PrimitiveComponent_ptr->LDMaxDrawDistance;}
        }
        ///<summary>The distance to cull this primitive at.</summary>
        ///<remarks>A CachedMaxDrawDistance of 0 indicates that the primitive should not be culled by distance.</remarks>
        public unsafe float CachedMaxDrawDistance {
            get {return PrimitiveComponent_ptr->CachedMaxDrawDistance;}
        }
        ///<summary>The scene depth priority group to draw the primitive in.</summary>
        public unsafe byte DepthPriorityGroup {
            get {return PrimitiveComponent_ptr->DepthPriorityGroup;}
            set {PrimitiveComponent_ptr->DepthPriorityGroup = value;}
        }
        ///<summary>The scene depth priority group to draw the primitive in, if it's being viewed by its owner.</summary>
        public unsafe byte ViewOwnerDepthPriorityGroup {
            get {return PrimitiveComponent_ptr->ViewOwnerDepthPriorityGroup;}
            set {PrimitiveComponent_ptr->ViewOwnerDepthPriorityGroup = value;}
        }
        ///<summary>Quality of indirect lighting for Movable primitives.  This has a large effect on Indirect Lighting Cache update time.</summary>
        public unsafe byte IndirectLightingCacheQuality {
            get {return PrimitiveComponent_ptr->IndirectLightingCacheQuality;}
        }
         //TODO: enum ELightmapType LightmapType
        public bool bEnableAutoLODGeneration {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableAutoLODGeneration"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableAutoLODGeneration", value); }
        }
        public bool bUseMaxLODAsImposter {
            get {return Main.GetGetBoolPropertyByName(this, "bUseMaxLODAsImposter"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseMaxLODAsImposter", value); }
        }
         //TODO: array not UObject TArray ExcludeForSpecificHLODLevels
        public bool bNeverDistanceCull {
            get {return Main.GetGetBoolPropertyByName(this, "bNeverDistanceCull"); }
        }
        public bool bAlwaysCreatePhysicsState {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysCreatePhysicsState"); }
        }
        public bool bGenerateOverlapEvents {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateOverlapEvents"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateOverlapEvents", value); }
        }
        public bool bMultiBodyOverlap {
            get {return Main.GetGetBoolPropertyByName(this, "bMultiBodyOverlap"); }
            set {Main.SetGetBoolPropertyByName(this, "bMultiBodyOverlap", value); }
        }
        public bool bCheckAsyncSceneOnMove {
            get {return Main.GetGetBoolPropertyByName(this, "bCheckAsyncSceneOnMove"); }
            set {Main.SetGetBoolPropertyByName(this, "bCheckAsyncSceneOnMove", value); }
        }
        public bool bTraceComplexOnMove {
            get {return Main.GetGetBoolPropertyByName(this, "bTraceComplexOnMove"); }
            set {Main.SetGetBoolPropertyByName(this, "bTraceComplexOnMove", value); }
        }
        public bool bReturnMaterialOnMove {
            get {return Main.GetGetBoolPropertyByName(this, "bReturnMaterialOnMove"); }
            set {Main.SetGetBoolPropertyByName(this, "bReturnMaterialOnMove", value); }
        }
        public bool bUseViewOwnerDepthPriorityGroup {
            get {return Main.GetGetBoolPropertyByName(this, "bUseViewOwnerDepthPriorityGroup"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseViewOwnerDepthPriorityGroup", value); }
        }
        public bool bAllowCullDistanceVolume {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowCullDistanceVolume"); }
        }
        public bool bHasMotionBlurVelocityMeshes {
            get {return Main.GetGetBoolPropertyByName(this, "bHasMotionBlurVelocityMeshes"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasMotionBlurVelocityMeshes", value); }
        }
        public bool bVisibleInReflectionCaptures {
            get {return Main.GetGetBoolPropertyByName(this, "bVisibleInReflectionCaptures"); }
        }
        public bool bRenderInMainPass {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderInMainPass"); }
        }
        public bool bRenderInMono {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderInMono"); }
        }
        public bool bReceivesDecals {
            get {return Main.GetGetBoolPropertyByName(this, "bReceivesDecals"); }
        }
        public bool bOwnerNoSee {
            get {return Main.GetGetBoolPropertyByName(this, "bOwnerNoSee"); }
        }
        public bool bOnlyOwnerSee {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlyOwnerSee"); }
        }
        public bool bTreatAsBackgroundForOcclusion {
            get {return Main.GetGetBoolPropertyByName(this, "bTreatAsBackgroundForOcclusion"); }
        }
        public bool bUseAsOccluder {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAsOccluder"); }
        }
        public bool bSelectable {
            get {return Main.GetGetBoolPropertyByName(this, "bSelectable"); }
            set {Main.SetGetBoolPropertyByName(this, "bSelectable", value); }
        }
        public bool bForceMipStreaming {
            get {return Main.GetGetBoolPropertyByName(this, "bForceMipStreaming"); }
        }
        public bool bHasPerInstanceHitProxies {
            get {return Main.GetGetBoolPropertyByName(this, "bHasPerInstanceHitProxies"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasPerInstanceHitProxies", value); }
        }
        public bool CastShadow {
            get {return Main.GetGetBoolPropertyByName(this, "CastShadow"); }
        }
        public bool bAffectDynamicIndirectLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectDynamicIndirectLighting"); }
        }
        public bool bAffectDistanceFieldLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectDistanceFieldLighting"); }
        }
        public bool bCastDynamicShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastDynamicShadow"); }
        }
        public bool bCastStaticShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastStaticShadow"); }
        }
        public bool bCastVolumetricTranslucentShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastVolumetricTranslucentShadow"); }
        }
        public bool bSelfShadowOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bSelfShadowOnly"); }
        }
        public bool bCastFarShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastFarShadow"); }
        }
        public bool bCastInsetShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastInsetShadow"); }
        }
        public bool bCastCinematicShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastCinematicShadow"); }
        }
        public bool bCastHiddenShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastHiddenShadow"); }
        }
        public bool bCastShadowAsTwoSided {
            get {return Main.GetGetBoolPropertyByName(this, "bCastShadowAsTwoSided"); }
        }
        public bool bLightAttachmentsAsGroup {
            get {return Main.GetGetBoolPropertyByName(this, "bLightAttachmentsAsGroup"); }
        }
        public bool bReceiveMobileCSMShadows {
            get {return Main.GetGetBoolPropertyByName(this, "bReceiveMobileCSMShadows"); }
        }
        public bool bSingleSampleShadowFromStationaryLights {
            get {return Main.GetGetBoolPropertyByName(this, "bSingleSampleShadowFromStationaryLights"); }
        }
        public bool bIgnoreRadialImpulse {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreRadialImpulse"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreRadialImpulse", value); }
        }
        public bool bIgnoreRadialForce {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreRadialForce"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreRadialForce", value); }
        }
        public bool bApplyImpulseOnDamage {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyImpulseOnDamage"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyImpulseOnDamage", value); }
        }
        public bool bReplicatePhysicsToAutonomousProxy {
            get {return Main.GetGetBoolPropertyByName(this, "bReplicatePhysicsToAutonomousProxy"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplicatePhysicsToAutonomousProxy", value); }
        }
        public bool AlwaysLoadOnClient {
            get {return Main.GetGetBoolPropertyByName(this, "AlwaysLoadOnClient"); }
            set {Main.SetGetBoolPropertyByName(this, "AlwaysLoadOnClient", value); }
        }
        public bool AlwaysLoadOnServer {
            get {return Main.GetGetBoolPropertyByName(this, "AlwaysLoadOnServer"); }
            set {Main.SetGetBoolPropertyByName(this, "AlwaysLoadOnServer", value); }
        }
        public bool bUseEditorCompositing {
            get {return Main.GetGetBoolPropertyByName(this, "bUseEditorCompositing"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseEditorCompositing", value); }
        }
        public bool bRenderCustomDepth {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderCustomDepth"); }
        }
        ///<summary>If true then DoCustomNavigableGeometryExport will be called to collect navigable geometry of this component.</summary>
        public unsafe byte bHasCustomNavigableGeometry {
            get {return PrimitiveComponent_ptr->bHasCustomNavigableGeometry;}
            set {PrimitiveComponent_ptr->bHasCustomNavigableGeometry = value;}
        }
        ///<summary>Determine whether a Character can step up onto this component.</summary>
        ///<remarks>
        ///This controls whether they can try to step up on it when they bump in to it, not whether they can walk on it after landing on it.
        ///@see FWalkableSlopeOverride
        ///</remarks>
        public unsafe byte CanCharacterStepUpOn {
            get {return PrimitiveComponent_ptr->CanCharacterStepUpOn;}
            set {PrimitiveComponent_ptr->CanCharacterStepUpOn = value;}
        }
        ///<summary>Channels that this component should be in.</summary>
        ///<remarks>
        ///Lights with matching channels will affect the component.
        ///These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
        ///</remarks>
        public unsafe LightingChannels LightingChannels {
            get {return PrimitiveComponent_ptr->LightingChannels;}
        }
         //TODO: enum ERendererStencilMask CustomDepthStencilWriteMask
        ///<summary>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)</summary>
        public unsafe int CustomDepthStencilValue {
            get {return PrimitiveComponent_ptr->CustomDepthStencilValue;}
        }
        ///<summary>Translucent objects with a lower sort priority draw behind objects with a higher priority.</summary>
        ///<remarks>
        ///Translucent objects with the same priority are rendered from back-to-front based on their bounds origin.
        ///
        ///Ignored if the object is not translucent.  The default priority is zero.
        ///Warning: This should never be set to a non-default value unless you know what you are doing, as it will prevent the renderer from sorting correctly.
        ///It is especially problematic on dynamic gameplay effects.
        ///</remarks>
        public unsafe int TranslucencySortPriority {
            get {return PrimitiveComponent_ptr->TranslucencySortPriority;}
        }
        ///<summary>Used for precomputed visibility</summary>
        public unsafe int VisibilityId {
            get {return PrimitiveComponent_ptr->VisibilityId;}
            set {PrimitiveComponent_ptr->VisibilityId = value;}
        }
        ///<summary>Multiplier used to scale the Light Propagation Volume light injection bias, to reduce light bleeding.</summary>
        ///<remarks>
        ///Set to 0 for no bias, 1 for default or higher for increased biasing (e.g. for
        ///thin geometry such as walls)
        ///</remarks>
        public unsafe float LpvBiasMultiplier {
            get {return PrimitiveComponent_ptr->LpvBiasMultiplier;}
        }
        ///<summary>Scales the bounds of the object.</summary>
        ///<remarks>
        ///This is useful when using World Position Offset to animate the vertices of the object outside of its bounds.
        ///Warning: Increasing the bounds of an object will reduce performance and shadow quality!
        ///Currently only used by StaticMeshComponent and SkeletalMeshComponent.
        ///</remarks>
        public unsafe float BoundsScale {
            get {return PrimitiveComponent_ptr->BoundsScale;}
            set {PrimitiveComponent_ptr->BoundsScale = value;}
        }
        ///<summary>Last time the component was submitted for rendering (called FScene::AddPrimitive).</summary>
        public unsafe float LastSubmitTime {
            get {return PrimitiveComponent_ptr->LastSubmitTime;}
            set {PrimitiveComponent_ptr->LastSubmitTime = value;}
        }
        ///<summary>The value of WorldSettings->TimeSeconds for the frame when this component was last rendered.</summary>
        ///<remarks>
        ///This is written
        ///from the render thread, which is up to a frame behind the game thread, so you should allow this time to
        ///be at least a frame behind the game thread's world time before you consider the actor non-visible.
        ///</remarks>
        public unsafe float LastRenderTime {
            get {return PrimitiveComponent_ptr->LastRenderTime;}
            set {PrimitiveComponent_ptr->LastRenderTime = value;}
        }
        ///<summary>Last Render Time on Screen</summary>
        public unsafe float LastRenderTimeOnScreen {
            get {return PrimitiveComponent_ptr->LastRenderTimeOnScreen;}
            set {PrimitiveComponent_ptr->LastRenderTimeOnScreen = value;}
        }
        ///<summary>Set of actors to ignore during component sweeps in MoveComponent().</summary>
        ///<remarks>
        ///All components owned by these actors will be ignored when this component moves or updates overlaps.
        ///Components on the other Actor may also need to be told to do the same when they move.
        ///Does not affect movement of this component when simulating physics.
        ///@see IgnoreActorWhenMoving()
        ///</remarks>
        public ObjectArrayField<Actor> MoveIgnoreActors{ get {
            if(MoveIgnoreActors_store == null) MoveIgnoreActors_store = new ObjectArrayField<Actor> (&PrimitiveComponent_ptr->MoveIgnoreActors);
            return MoveIgnoreActors_store;
        } }
        private ObjectArrayField<Actor> MoveIgnoreActors_store;

        ///<summary>Set of components to ignore during component sweeps in MoveComponent().</summary>
        ///<remarks>
        ///These components will be ignored when this component moves or updates overlaps.
        ///The other components may also need to be told to do the same when they move.
        ///Does not affect movement of this component when simulating physics.
        ///@see IgnoreComponentWhenMoving()
        ///</remarks>
        public ObjectArrayField<PrimitiveComponent> MoveIgnoreComponents{ get {
            if(MoveIgnoreComponents_store == null) MoveIgnoreComponents_store = new ObjectArrayField<PrimitiveComponent> (&PrimitiveComponent_ptr->MoveIgnoreComponents);
            return MoveIgnoreComponents_store;
        } }
        private ObjectArrayField<PrimitiveComponent> MoveIgnoreComponents_store;

        ///<summary>Physics scene information for this component, holds a single rigid body with multiple shapes.</summary>
        public unsafe BodyInstance BodyInstance {
            get {return PrimitiveComponent_ptr->BodyInstance;}
        }
         //TODO: multicast delegate FComponentHitSignature OnComponentHit
         //TODO: multicast delegate FComponentBeginOverlapSignature OnComponentBeginOverlap
         //TODO: multicast delegate FComponentEndOverlapSignature OnComponentEndOverlap
         //TODO: multicast delegate FComponentWakeSignature OnComponentWake
         //TODO: multicast delegate FComponentSleepSignature OnComponentSleep
         //TODO: multicast delegate FComponentBeginCursorOverSignature OnBeginCursorOver
         //TODO: multicast delegate FComponentEndCursorOverSignature OnEndCursorOver
         //TODO: multicast delegate FComponentOnClickedSignature OnClicked
         //TODO: multicast delegate FComponentOnReleasedSignature OnReleased
         //TODO: multicast delegate FComponentOnInputTouchBeginSignature OnInputTouchBegin
         //TODO: multicast delegate FComponentOnInputTouchEndSignature OnInputTouchEnd
         //TODO: multicast delegate FComponentBeginTouchOverSignature OnInputTouchEnter
         //TODO: multicast delegate FComponentEndTouchOverSignature OnInputTouchLeave
        ///<summary>LOD parent primitive to draw instead of this one (multiple UPrim's will point to the same LODParent )</summary>
        public unsafe PrimitiveComponent LODParentPrimitive {
            get {return PrimitiveComponent_ptr->LODParentPrimitive;}
            set {PrimitiveComponent_ptr->LODParentPrimitive = value;}
        }
        ///<summary>Tick function for physics ticking *</summary>
        public unsafe PrimitiveComponentPostPhysicsTickFunction PostPhysicsComponentTick {
            get {return PrimitiveComponent_ptr->PostPhysicsComponentTick;}
            set {PrimitiveComponent_ptr->PostPhysicsComponentTick = value;}
        }
        static PrimitiveComponent() {
            StaticClass = Main.GetClass("PrimitiveComponent");
        }
        internal unsafe PrimitiveComponent_fields* PrimitiveComponent_ptr => (PrimitiveComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PrimitiveComponent(IntPtr p) => UObject.Make<PrimitiveComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PrimitiveComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PrimitiveComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
