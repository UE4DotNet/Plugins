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
using UE4.InputCore;

namespace UE4.Engine {
    ///<summary>Actor is the base class for an Object that can be placed or spawned in a level.</summary>
    ///<remarks>
    ///Actors may contain a collection of ActorComponents, which can be used to control how actors move, how they are rendered, etc.
    ///The other main function of an Actor is the replication of properties and function calls across the network during play.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors/
    ///@see UActorComponent
    ///</remarks>
    public unsafe partial class Actor : UObject  {

        ///<summary>Event called when this Actor becomes the view target for the given PlayerController.</summary>
        public event K2_OnBecomeViewTarget_delegate K2_OnBecomeViewTarget;
        public delegate void K2_OnBecomeViewTarget_delegate(PlayerController PC);
        internal void on_K2_OnBecomeViewTarget(PlayerController PC) =>
            K2_OnBecomeViewTarget?.Invoke(PC);


        ///<summary>Event called when this Actor is no longer the view target for the given PlayerController.</summary>
        public event K2_OnEndViewTarget_delegate K2_OnEndViewTarget;
        public delegate void K2_OnEndViewTarget_delegate(PlayerController PC);
        internal void on_K2_OnEndViewTarget(PlayerController PC) =>
            K2_OnEndViewTarget?.Invoke(PC);


        ///<summary>Event called when this Actor is reset to its initial state - used when restarting level without reloading.</summary>
        public event K2_OnReset_delegate K2_OnReset;
        public delegate void K2_OnReset_delegate();
        internal void on_K2_OnReset() =>
            K2_OnReset?.Invoke();


        ///<summary>Event when this actor has the mouse moved over it with the clickable interface.</summary>
        public event ReceiveActorBeginCursorOver_delegate ReceiveActorBeginCursorOver;
        public delegate void ReceiveActorBeginCursorOver_delegate();
        internal void on_ReceiveActorBeginCursorOver() =>
            ReceiveActorBeginCursorOver?.Invoke();


        ///<summary>Event when this actor overlaps another actor, for example a player walking into a trigger.</summary>
        ///<remarks>
        ///For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events.
        ///@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events.
        ///</remarks>
        public event ReceiveActorBeginOverlap_delegate ReceiveActorBeginOverlap;
        public delegate void ReceiveActorBeginOverlap_delegate(Actor OtherActor);
        internal void on_ReceiveActorBeginOverlap(Actor OtherActor) =>
            ReceiveActorBeginOverlap?.Invoke(OtherActor);


        ///<summary>Event when this actor has the mouse moved off of it with the clickable interface.</summary>
        public event ReceiveActorEndCursorOver_delegate ReceiveActorEndCursorOver;
        public delegate void ReceiveActorEndCursorOver_delegate();
        internal void on_ReceiveActorEndCursorOver() =>
            ReceiveActorEndCursorOver?.Invoke();


        ///<summary>Event when an actor no longer overlaps another actor, and they have separated.</summary>
        ///<remarks>
        ///@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events.
        ///</remarks>
        public event ReceiveActorEndOverlap_delegate ReceiveActorEndOverlap;
        public delegate void ReceiveActorEndOverlap_delegate(Actor OtherActor);
        internal void on_ReceiveActorEndOverlap(Actor OtherActor) =>
            ReceiveActorEndOverlap?.Invoke(OtherActor);


        ///<summary>Event when this actor is clicked by the mouse when using the clickable interface.</summary>
        public event ReceiveActorOnClicked_delegate ReceiveActorOnClicked;
        public delegate void ReceiveActorOnClicked_delegate(Key ButtonPressed);
        internal void on_ReceiveActorOnClicked(Key ButtonPressed) =>
            ReceiveActorOnClicked?.Invoke(ButtonPressed);


        ///<summary>Event when this actor is touched when click events are enabled.</summary>
        public event ReceiveActorOnInputTouchBegin_delegate ReceiveActorOnInputTouchBegin;
        public delegate void ReceiveActorOnInputTouchBegin_delegate(byte FingerIndex);
        internal void on_ReceiveActorOnInputTouchBegin(byte FingerIndex) =>
            ReceiveActorOnInputTouchBegin?.Invoke(FingerIndex);


        ///<summary>Event when this actor is under the finger when untouched when click events are enabled.</summary>
        public event ReceiveActorOnInputTouchEnd_delegate ReceiveActorOnInputTouchEnd;
        public delegate void ReceiveActorOnInputTouchEnd_delegate(byte FingerIndex);
        internal void on_ReceiveActorOnInputTouchEnd(byte FingerIndex) =>
            ReceiveActorOnInputTouchEnd?.Invoke(FingerIndex);


        ///<summary>Event when this actor has a finger moved over it with the clickable interface.</summary>
        public event ReceiveActorOnInputTouchEnter_delegate ReceiveActorOnInputTouchEnter;
        public delegate void ReceiveActorOnInputTouchEnter_delegate(byte FingerIndex);
        internal void on_ReceiveActorOnInputTouchEnter(byte FingerIndex) =>
            ReceiveActorOnInputTouchEnter?.Invoke(FingerIndex);


        ///<summary>Event when this actor has a finger moved off of it with the clickable interface.</summary>
        public event ReceiveActorOnInputTouchLeave_delegate ReceiveActorOnInputTouchLeave;
        public delegate void ReceiveActorOnInputTouchLeave_delegate(byte FingerIndex);
        internal void on_ReceiveActorOnInputTouchLeave(byte FingerIndex) =>
            ReceiveActorOnInputTouchLeave?.Invoke(FingerIndex);


        ///<summary>Event when this actor is under the mouse when left mouse button is released while using the clickable interface.</summary>
        public event ReceiveActorOnReleased_delegate ReceiveActorOnReleased;
        public delegate void ReceiveActorOnReleased_delegate(Key ButtonReleased);
        internal void on_ReceiveActorOnReleased(Key ButtonReleased) =>
            ReceiveActorOnReleased?.Invoke(ButtonReleased);


        ///<summary>Event when this actor takes ANY damage</summary>
        public event ReceiveAnyDamage_delegate ReceiveAnyDamage;
        public delegate void ReceiveAnyDamage_delegate(float Damage, DamageType DamageType, Controller InstigatedBy, Actor DamageCauser);
        internal void on_ReceiveAnyDamage(float Damage, DamageType DamageType, Controller InstigatedBy, Actor DamageCauser) =>
            ReceiveAnyDamage?.Invoke(Damage, DamageType, InstigatedBy, DamageCauser);


        ///<summary>Event when play begins for this actor.</summary>
        public event ReceiveBeginPlay_delegate ReceiveBeginPlay;
        public delegate void ReceiveBeginPlay_delegate();
        internal void on_ReceiveBeginPlay() =>
            ReceiveBeginPlay?.Invoke();


        ///<summary>Receive Destroyed</summary>
        public event ReceiveDestroyed_delegate ReceiveDestroyed;
        public delegate void ReceiveDestroyed_delegate();
        internal void on_ReceiveDestroyed() =>
            ReceiveDestroyed?.Invoke();


        ///<summary>Event to notify blueprints this actor is about to be deleted.</summary>
        public event ReceiveEndPlay_delegate ReceiveEndPlay;
        public delegate void ReceiveEndPlay_delegate(byte EndPlayReason);
        internal void on_ReceiveEndPlay(byte EndPlayReason) =>
            ReceiveEndPlay?.Invoke(EndPlayReason);


        ///<summary>Event when this actor bumps into a blocking object, or blocks another actor that bumps into it.</summary>
        ///<remarks>
        ///This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation.
        ///For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event.
        ///
        ///@note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled.
        ///@note When receiving a hit from another object's movement (bSelfMoved is false), the directions of 'Hit.Normal' and 'Hit.ImpactNormal'
        ///will be adjusted to indicate force from the other object against this object.
        ///@note NormalImpulse will be filled in for physics-simulating bodies, but will be zero for swept-component blocking collisions.
        ///</remarks>
        public event ReceiveHit_delegate ReceiveHit;
        public delegate HitResult ReceiveHit_delegate(PrimitiveComponent MyComp, Actor Other, PrimitiveComponent OtherComp, bool bSelfMoved, Vector HitLocation, Vector HitNormal, Vector NormalImpulse, HitResult Hit);
        internal HitResult on_ReceiveHit(PrimitiveComponent MyComp, Actor Other, PrimitiveComponent OtherComp, bool bSelfMoved, Vector HitLocation, Vector HitNormal, Vector NormalImpulse, HitResult Hit) =>
            ReceiveHit != null ? ReceiveHit(MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit) : Hit;


        ///<summary>Event when this actor takes POINT damage</summary>
        public event ReceivePointDamage_delegate ReceivePointDamage;
        public delegate HitResult ReceivePointDamage_delegate(float Damage, DamageType DamageType, Vector HitLocation, Vector HitNormal, PrimitiveComponent HitComponent, Name BoneName, Vector ShotFromDirection, Controller InstigatedBy, Actor DamageCauser, HitResult HitInfo);
        internal HitResult on_ReceivePointDamage(float Damage, DamageType DamageType, Vector HitLocation, Vector HitNormal, PrimitiveComponent HitComponent, Name BoneName, Vector ShotFromDirection, Controller InstigatedBy, Actor DamageCauser, HitResult HitInfo) =>
            ReceivePointDamage != null ? ReceivePointDamage(Damage, DamageType, HitLocation, HitNormal, HitComponent, BoneName, ShotFromDirection, InstigatedBy, DamageCauser, HitInfo) : HitInfo;


        ///<summary>
        ///Event when this actor takes RADIAL damage
        ///@
        ///</summary>
        ///<remarks>todo Pass it the full array of hits instead of just one?</remarks>
        public event ReceiveRadialDamage_delegate ReceiveRadialDamage;
        public delegate HitResult ReceiveRadialDamage_delegate(float DamageReceived, DamageType DamageType, Vector Origin, HitResult HitInfo, Controller InstigatedBy, Actor DamageCauser);
        internal HitResult on_ReceiveRadialDamage(float DamageReceived, DamageType DamageType, Vector Origin, HitResult HitInfo, Controller InstigatedBy, Actor DamageCauser) =>
            ReceiveRadialDamage != null ? ReceiveRadialDamage(DamageReceived, DamageType, Origin, HitInfo, InstigatedBy, DamageCauser) : HitInfo;


        ///<summary>Event called every frame</summary>
        public event ReceiveTick_delegate ReceiveTick;
        public delegate void ReceiveTick_delegate(float DeltaSeconds);
        internal void on_ReceiveTick(float DeltaSeconds) =>
            ReceiveTick?.Invoke(DeltaSeconds);


        ///<summary>Construction script, the place to spawn components and do other setup.</summary>
        ///<remarks>
        ///@note Name used in CreateBlueprint function
        ///@param       Location        The location.
        ///@param       Rotation        The rotation.
        ///</remarks>
        public event UserConstructionScript_delegate UserConstructionScript;
        public delegate void UserConstructionScript_delegate();
        internal void on_UserConstructionScript() =>
            UserConstructionScript?.Invoke();


        ///<summary>See if this actor contains the supplied tag</summary>
        public bool ActorHasTag(Name Tag)  => 
            Actor_methods.ActorHasTag_method.Invoke(ObjPointer, Tag);

        ///<summary>
        ///Creates a new component and assigns ownership to the Actor this is
        ///called for.
        ///</summary>
        ///<remarks>
        ///Automatic attachment causes the first component created to
        ///become the root, and all subsequent components to be attached under that
        ///root. When bManualAttachment is set, automatic attachment is
        ///skipped and it is up to the user to attach the resulting component (or
        ///set it up as the root) themselves.
        ///
        ///@see UK2Node_AddComponent    DO NOT CALL MANUALLY - BLUEPRINT INTERNAL USE ONLY (for Add Component nodes)
        ///
        ///@param TemplateName                                  The name of the Component Template to use.
        ///@param bManualAttachment                             Whether manual or automatic attachment is to be used
        ///@param RelativeTransform                             The relative transform between the new component and its attach parent (automatic only)
        ///@param ComponentTemplateContext              Optional UBlueprintGeneratedClass reference to use to find the template in. If null (or not a BPGC), component is sought in this Actor's class
        ///</remarks>
        public ActorComponent AddComponent(Name TemplateName, bool bManualAttachment, Transform RelativeTransform, UObject ComponentTemplateContext)  => 
            Actor_methods.AddComponent_method.Invoke(ObjPointer, TemplateName, bManualAttachment, RelativeTransform, ComponentTemplateContext);

        ///<summary>Make this actor tick after PrerequisiteActor. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired.</summary>
        public void AddTickPrerequisiteActor(Actor PrerequisiteActor)  => 
            Actor_methods.AddTickPrerequisiteActor_method.Invoke(ObjPointer, PrerequisiteActor);

        ///<summary>Make this actor tick after PrerequisiteComponent. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired.</summary>
        public void AddTickPrerequisiteComponent(ActorComponent PrerequisiteComponent)  => 
            Actor_methods.AddTickPrerequisiteComponent_method.Invoke(ObjPointer, PrerequisiteComponent);

        ///<summary>Detach Root Component from Parent</summary>
        public void DetachRootComponentFromParent(bool bMaintainWorldPosition)  => 
            Actor_methods.DetachRootComponentFromParent_method.Invoke(ObjPointer, bMaintainWorldPosition);

        ///<summary>Removes this actor from the stack of input being handled by a PlayerController.</summary>
        ///<remarks>
        ///@param PlayerController The PlayerController whose input events we no longer want to receive. If null, this actor will stop receiving input from all PlayerControllers.
        ///</remarks>
        public void DisableInput(PlayerController PlayerController)  => 
            Actor_methods.DisableInput_method.Invoke(ObjPointer, PlayerController);

        ///<summary>Pushes this actor on to the stack of input being handled by a PlayerController.</summary>
        ///<remarks>
        ///@param PlayerController The PlayerController whose input events we want to receive.
        ///</remarks>
        public void EnableInput(PlayerController PlayerController)  => 
            Actor_methods.EnableInput_method.Invoke(ObjPointer, PlayerController);

        ///<summary>Forces dormant actor to replicate but doesn't change NetDormancy state (i.e., they will go dormant again if left dormant)</summary>
        public void FlushNetDormancy()  => 
            Actor_methods.FlushNetDormancy_method.Invoke(ObjPointer);

        ///<summary>Force actor to be updated to clients/demo net drivers</summary>
        public void ForceNetUpdate()  => 
            Actor_methods.ForceNetUpdate_method.Invoke(ObjPointer);

        ///<summary>Returns the bounding box of all components that make up this Actor (excluding ChildActorComponents).</summary>
        ///<remarks>
        ///@param       bOnlyCollidingComponents        If true, will only return the bounding box for components with collision enabled.
        ///</remarks>
        public (Vector, Vector) GetActorBounds(bool bOnlyCollidingComponents)  => 
            Actor_methods.GetActorBounds_method.Invoke(ObjPointer, bOnlyCollidingComponents);

        ///<summary>Get current state of collision for the whole actor</summary>
        public bool GetActorEnableCollision()  => 
            Actor_methods.GetActorEnableCollision_method.Invoke(ObjPointer);

        ///<summary>Returns the point of view of the actor.</summary>
        ///<remarks>
        ///Note that this doesn't mean the camera, but the 'eyes' of the actor.
        ///For example, for a Pawn, this would define the eye height location,
        ///and view rotation (which is different from the pawn rotation which has a zeroed pitch component).
        ///A camera first person view will typically use this view point. Most traces (weapon, AI) will be done from this view point.
        ///
        ///@param       OutLocation - location of view point
        ///@param       OutRotation - view rotation of actor.
        ///</remarks>
        public (Vector, Rotator) GetActorEyesViewPoint()  => 
            Actor_methods.GetActorEyesViewPoint_method.Invoke(ObjPointer);

        ///<summary>Get the forward (X) vector (length 1.0) from this Actor, in world space.</summary>
        public Vector GetActorForwardVector()  => 
            Actor_methods.GetActorForwardVector_method.Invoke(ObjPointer);

        ///<summary>Returns this actor's current label.</summary>
        ///<remarks>
        ///Actor labels are only available in development builds.
        ///@return      The label text
        ///</remarks>
        public string GetActorLabel()  => 
            Actor_methods.GetActorLabel_method.Invoke(ObjPointer);

        ///<summary>Return the actor's relative scale 3d</summary>
        public Vector GetActorRelativeScale3D()  => 
            Actor_methods.GetActorRelativeScale3D_method.Invoke(ObjPointer);

        ///<summary>Get the right (Y) vector (length 1.0) from this Actor, in world space.</summary>
        public Vector GetActorRightVector()  => 
            Actor_methods.GetActorRightVector_method.Invoke(ObjPointer);

        ///<summary>Returns the Actor's world-space scale.</summary>
        public Vector GetActorScale3D()  => 
            Actor_methods.GetActorScale3D_method.Invoke(ObjPointer);

        ///<summary>Returns the tick interval of this actor's primary tick function</summary>
        public float GetActorTickInterval()  => 
            Actor_methods.GetActorTickInterval_method.Invoke(ObjPointer);

        ///<summary>Get CustomTimeDilation - this can be used for input control or speed control for slomo.</summary>
        ///<remarks>We don't want to scale input globally because input can be used for UI, which do not care for TimeDilation.</remarks>
        public float GetActorTimeDilation()  => 
            Actor_methods.GetActorTimeDilation_method.Invoke(ObjPointer);

        ///<summary>Get the up (Z) vector (length 1.0) from this Actor, in world space.</summary>
        public Vector GetActorUpVector()  => 
            Actor_methods.GetActorUpVector_method.Invoke(ObjPointer);

        ///<summary>Returns a list of all child actors, including children of children</summary>
        public IReadOnlyCollection<Actor> GetAllChildActors(bool bIncludeDescendants)  => 
            Actor_methods.GetAllChildActors_method.Invoke(ObjPointer, bIncludeDescendants);

        ///<summary>Find all Actors which are attached directly to a component in this actor</summary>
        public IReadOnlyCollection<Actor> GetAttachedActors()  => 
            Actor_methods.GetAttachedActors_method.Invoke(ObjPointer);

        ///<summary>Walk up the attachment chain from RootComponent until we encounter a different actor, and return it. If we are not attached to a component in a different actor, returns nullptr</summary>
        public Actor GetAttachParentActor()  => 
            Actor_methods.GetAttachParentActor_method.Invoke(ObjPointer);

        ///<summary>Walk up the attachment chain from RootComponent until we encounter a different actor, and return the socket name in the component. If we are not attached to a component in a different actor, returns NAME_None</summary>
        public Name GetAttachParentSocketName()  => 
            Actor_methods.GetAttachParentSocketName_method.Invoke(ObjPointer);

        ///<summary>Script exposed version of FindComponentByClass</summary>
        public ActorComponent GetComponentByClass(SubclassOf<ActorComponent> ComponentClass)  => 
            Actor_methods.GetComponentByClass_method.Invoke(ObjPointer, ComponentClass);

        ///<summary>Gets all the components that inherit from the given class.</summary>
        ///<remarks>Currently returns an array of UActorComponent which must be cast to the correct type.</remarks>
        public IReadOnlyCollection<ActorComponent> GetComponentsByClass(SubclassOf<ActorComponent> ComponentClass)  => 
            Actor_methods.GetComponentsByClass_method.Invoke(ObjPointer, ComponentClass);

        ///<summary>Gets all the components that inherit from the given class with a given tag.</summary>
        public IReadOnlyCollection<ActorComponent> GetComponentsByTag(SubclassOf<ActorComponent> ComponentClass, Name Tag)  => 
            Actor_methods.GetComponentsByTag_method.Invoke(ObjPointer, ComponentClass, Tag);

        ///<summary>Returns the distance from this Actor to OtherActor.</summary>
        public float GetDistanceTo(Actor OtherActor)  => 
            Actor_methods.GetDistanceTo_method.Invoke(ObjPointer, OtherActor);

        ///<summary>Returns the dot product from this Actor to OtherActor. Returns -2.0 on failure. Returns 0.0 for coincidental actors.</summary>
        public float GetDotProductTo(Actor OtherActor)  => 
            Actor_methods.GetDotProductTo_method.Invoke(ObjPointer, OtherActor);

        ///<summary>Returns this actor's folder path.</summary>
        ///<remarks>
        ///Actor folder paths are only available in development builds.
        ///@return      The folder path
        ///</remarks>
        public void GetFolderPath(Name ReturnValue)  => 
            Actor_methods.GetFolderPath_method.Invoke(ObjPointer, ReturnValue);

        ///<summary>The number of seconds (in game time) since this Actor was created, relative to Get Game Time In Seconds.</summary>
        public float GetGameTimeSinceCreation()  => 
            Actor_methods.GetGameTimeSinceCreation_method.Invoke(ObjPointer);

        ///<summary>Returns the distance from this Actor to OtherActor, ignoring Z.</summary>
        public float GetHorizontalDistanceTo(Actor OtherActor)  => 
            Actor_methods.GetHorizontalDistanceTo_method.Invoke(ObjPointer, OtherActor);

        ///<summary>Returns the dot product from this Actor to OtherActor, ignoring Z. Returns -2.0 on failure. Returns 0.0 for coincidental actors.</summary>
        public float GetHorizontalDotProductTo(Actor OtherActor)  => 
            Actor_methods.GetHorizontalDotProductTo_method.Invoke(ObjPointer, OtherActor);

        ///<summary>Gets the value of the input axis key if input is enabled for this actor.</summary>
        public float GetInputAxisKeyValue(Key InputAxisKey)  => 
            Actor_methods.GetInputAxisKeyValue_method.Invoke(ObjPointer, InputAxisKey);

        ///<summary>Gets the value of the input axis if input is enabled for this actor.</summary>
        public float GetInputAxisValue(Name InputAxisName)  => 
            Actor_methods.GetInputAxisValue_method.Invoke(ObjPointer, InputAxisName);

        ///<summary>Gets the value of the input axis key if input is enabled for this actor.</summary>
        public Vector GetInputVectorAxisValue(Key InputAxisKey)  => 
            Actor_methods.GetInputVectorAxisValue_method.Invoke(ObjPointer, InputAxisKey);

        ///<summary>Returns the instigator for this actor, or nullptr if there is none.</summary>
        public Pawn GetInstigator()  => 
            Actor_methods.GetInstigator_method.Invoke(ObjPointer);

        ///<summary>Returns the instigator's controller for this actor, or nullptr if there is none.</summary>
        public Controller GetInstigatorController()  => 
            Actor_methods.GetInstigatorController_method.Invoke(ObjPointer);

        ///<summary>Get the remaining lifespan of this actor. If zero is returned the actor lives forever.</summary>
        public float GetLifeSpan()  => 
            Actor_methods.GetLifeSpan_method.Invoke(ObjPointer);

        ///<summary>Returns how much control the local machine has over this actor.</summary>
        public byte GetLocalRole()  => 
            Actor_methods.GetLocalRole_method.Invoke(ObjPointer);

        ///<summary>Returns list of actors this actor is overlapping (any component overlapping any component).</summary>
        ///<remarks>
        ///Does not return itself.
        ///@param OverlappingActors             [out] Returned list of overlapping actors
        ///@param ClassFilter                   [optional] If set, only returns actors of this class or subclasses
        ///</remarks>
        public IReadOnlyCollection<Actor> GetOverlappingActors(SubclassOf<Actor> ClassFilter)  => 
            Actor_methods.GetOverlappingActors_method.Invoke(ObjPointer, ClassFilter);

        ///<summary>Returns list of components this actor is overlapping.</summary>
        public IReadOnlyCollection<PrimitiveComponent> GetOverlappingComponents()  => 
            Actor_methods.GetOverlappingComponents_method.Invoke(ObjPointer);

        ///<summary>Get the owner of this Actor, used primarily for network replication.</summary>
        ///<remarks>
        ///@return Actor that owns this Actor
        ///</remarks>
        public Actor GetOwner()  => 
            Actor_methods.GetOwner_method.Invoke(ObjPointer);

        ///<summary>If this Actor was created by a Child Actor Component returns the Actor that owns that Child Actor Component</summary>
        public Actor GetParentActor()  => 
            Actor_methods.GetParentActor_method.Invoke(ObjPointer);

        ///<summary>If this Actor was created by a Child Actor Component returns that Child Actor Component</summary>
        public ChildActorComponent GetParentComponent()  => 
            Actor_methods.GetParentComponent_method.Invoke(ObjPointer);

        ///<summary>Returns how much control the remote machine has over this actor.</summary>
        public byte GetRemoteRole()  => 
            Actor_methods.GetRemoteRole_method.Invoke(ObjPointer);

        ///<summary>Returns the squared distance from this Actor to OtherActor.</summary>
        public float GetSquaredDistanceTo(Actor OtherActor)  => 
            Actor_methods.GetSquaredDistanceTo_method.Invoke(ObjPointer, OtherActor);

        ///<summary>Gets whether this actor can tick when paused.</summary>
        public bool GetTickableWhenPaused()  => 
            Actor_methods.GetTickableWhenPaused_method.Invoke(ObjPointer);

        ///<summary>Get the actor-to-world transform.</summary>
        ///<remarks>
        ///@return The transform that transforms from actor space to world space.
        ///</remarks>
        public Transform GetTransform()  => 
            Actor_methods.GetTransform_method.Invoke(ObjPointer);

        ///<summary>Returns velocity (in cm/s (Unreal Units/second) of the rootcomponent if it is either using physics or has an associated MovementComponent</summary>
        public Vector GetVelocity()  => 
            Actor_methods.GetVelocity_method.Invoke(ObjPointer);

        ///<summary>Returns the distance from this Actor to OtherActor, ignoring XY.</summary>
        public float GetVerticalDistanceTo(Actor OtherActor)  => 
            Actor_methods.GetVerticalDistanceTo_method.Invoke(ObjPointer, OtherActor);

        ///<summary>Returns whether this actor has network authority</summary>
        public bool HasAuthority()  => 
            Actor_methods.HasAuthority_method.Invoke(ObjPointer);

        ///<summary>Is Actor Being Destroyed</summary>
        public bool IsActorBeingDestroyed()  => 
            Actor_methods.IsActorBeingDestroyed_method.Invoke(ObjPointer);

        ///<summary>Returns whether this actor has tick enabled or not</summary>
        public bool IsActorTickEnabled()  => 
            Actor_methods.IsActorTickEnabled_method.Invoke(ObjPointer);

        ///<summary>Returns whether this Actor was spawned by a child actor component</summary>
        public bool IsChildActor()  => 
            Actor_methods.IsChildActor_method.Invoke(ObjPointer);

        ///<summary>@return        Returns true if this actor is allowed to be displayed, selected and manipulated by the editor.</summary>
        public bool IsEditable()  => 
            Actor_methods.IsEditable_method.Invoke(ObjPointer);

        ///<summary>Returns true if this actor is hidden in the editor viewports.</summary>
        public bool IsHiddenEd()  => 
            Actor_methods.IsHiddenEd_method.Invoke(ObjPointer);

        ///<summary>
        ///Simple accessor to check if the actor is hidden upon editor startup
        ///@
        ///</summary>
        ///<remarks>return      true if the actor is hidden upon editor startup; false if it is not</remarks>
        public bool IsHiddenEdAtStartup()  => 
            Actor_methods.IsHiddenEdAtStartup_method.Invoke(ObjPointer);

        ///<summary>Check whether any component of this Actor is overlapping any component of another Actor.</summary>
        ///<remarks>
        ///@param Other The other Actor to test against
        ///@return Whether any component of this Actor is overlapping any component of another Actor.
        ///</remarks>
        public bool IsOverlappingActor(Actor Other)  => 
            Actor_methods.IsOverlappingActor_method.Invoke(ObjPointer, Other);

        ///<summary>@return        Returns true if this actor can EVER be selected in a level in the editor.  Can be overridden by specific actors to make them unselectable.</summary>
        public bool IsSelectable()  => 
            Actor_methods.IsSelectable_method.Invoke(ObjPointer);

        ///<summary>@</summary>
        ///<remarks>
        ///param  bIncludeParent - Whether to recurse up child actor hierarchy or not
        ///@return Whether or not this actor is hidden in the editor for the duration of the current editor session
        ///</remarks>
        public bool IsTemporarilyHiddenInEditor(bool bIncludeParent)  => 
            Actor_methods.IsTemporarilyHiddenInEditor_method.Invoke(ObjPointer, bIncludeParent);

        ///<summary>Adds a delta to the location of this component in its local reference frame.</summary>
        ///<remarks>
        ///@param DelatLocation         The change in location in local space.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///</remarks>
        public HitResult K2_AddActorLocalOffset(Vector DeltaLocation, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_AddActorLocalOffset_method.Invoke(ObjPointer, DeltaLocation, bSweep, bTeleport);

        ///<summary>
        ///Adds a delta to the rotation of this component in its local reference frame
        ///@
        ///</summary>
        ///<remarks>
        ///param DeltaRotation         The change in rotation in local space.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///</remarks>
        public HitResult K2_AddActorLocalRotation(Rotator DeltaRotation, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_AddActorLocalRotation_method.Invoke(ObjPointer, DeltaRotation, bSweep, bTeleport);

        ///<summary>
        ///Adds a delta to the transform of this component in its local reference frame
        ///@
        ///</summary>
        ///<remarks>
        ///param NewTransform          The change in transform in local space.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///</remarks>
        public HitResult K2_AddActorLocalTransform(Transform NewTransform, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_AddActorLocalTransform_method.Invoke(ObjPointer, NewTransform, bSweep, bTeleport);

        ///<summary>Adds a delta to the location of this actor in world space.</summary>
        ///<remarks>
        ///@param DeltaLocation         The change in location.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///@param SweepHitResult        The hit result from the move if swept.
        ///</remarks>
        public HitResult K2_AddActorWorldOffset(Vector DeltaLocation, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_AddActorWorldOffset_method.Invoke(ObjPointer, DeltaLocation, bSweep, bTeleport);

        ///<summary>Adds a delta to the rotation of this actor in world space.</summary>
        ///<remarks>
        ///@param DeltaRotation         The change in rotation.
        ///@param bSweep                        Whether to sweep to the target rotation (not currently supported for rotation).
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///@param SweepHitResult        The hit result from the move if swept.
        ///</remarks>
        public HitResult K2_AddActorWorldRotation(Rotator DeltaRotation, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_AddActorWorldRotation_method.Invoke(ObjPointer, DeltaRotation, bSweep, bTeleport);

        ///<summary>Adds a delta to the transform of this actor in world space. Scale is unchanged.</summary>
        public HitResult K2_AddActorWorldTransform(Transform DeltaTransform, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_AddActorWorldTransform_method.Invoke(ObjPointer, DeltaTransform, bSweep, bTeleport);

        ///<summary>K2 Attach Root Component To</summary>
        public void K2_AttachRootComponentTo(SceneComponent InParent, Name InSocketName, byte AttachLocationType, bool bWeldSimulatedBodies)  => 
            Actor_methods.K2_AttachRootComponentTo_method.Invoke(ObjPointer, InParent, InSocketName, AttachLocationType, bWeldSimulatedBodies);

        ///<summary>K2 Attach Root Component to Actor</summary>
        public void K2_AttachRootComponentToActor(Actor InParentActor, Name InSocketName, byte AttachLocationType, bool bWeldSimulatedBodies)  => 
            Actor_methods.K2_AttachRootComponentToActor_method.Invoke(ObjPointer, InParentActor, InSocketName, AttachLocationType, bWeldSimulatedBodies);

        ///<summary>Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket.</summary>
        ///<remarks>
        ///It is not valid to call this on components that are not Registered.
        ///@param ParentActor                           Actor to attach this actor's RootComponent to
        ///@param SocketName                            Socket name to attach to, if any
        ///@param LocationRule                          How to handle translation when attaching.
        ///@param RotationRule                          How to handle rotation when attaching.
        ///@param ScaleRule                                     How to handle scale when attaching.
        ///@param bWeldSimulatedBodies          Whether to weld together simulated physics bodies.
        ///</remarks>
        public void K2_AttachToActor(Actor ParentActor, Name SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)  => 
            Actor_methods.K2_AttachToActor_method.Invoke(ObjPointer, ParentActor, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);

        ///<summary>Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket.</summary>
        ///<remarks>
        ///It is not valid to call this on components that are not Registered.
        ///@param  Parent                                       Parent to attach to.
        ///@param  SocketName                           Optional socket to attach to on the parent.
        ///@param  AttachmentRules                      How to handle transforms when attaching.
        ///@param  bWeldSimulatedBodies         Whether to weld together simulated physics bodies.
        ///</remarks>
        public void K2_AttachToComponent(SceneComponent Parent, Name SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)  => 
            Actor_methods.K2_AttachToComponent_method.Invoke(ObjPointer, Parent, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);

        ///<summary>Destroy the actor</summary>
        public void K2_DestroyActor()  => 
            Actor_methods.K2_DestroyActor_method.Invoke(ObjPointer);

        ///<summary>K2 Destroy Component</summary>
        public void K2_DestroyComponent(ActorComponent Component)  => 
            Actor_methods.K2_DestroyComponent_method.Invoke(ObjPointer, Component);

        ///<summary>Detaches the RootComponent of this Actor from any SceneComponent it is currently attached to.</summary>
        ///<remarks>
        ///@param  LocationRule                         How to handle translation when detaching.
        ///@param  RotationRule                         How to handle rotation when detaching.
        ///@param  ScaleRule                            How to handle scale when detaching.
        ///</remarks>
        public void K2_DetachFromActor(EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule)  => 
            Actor_methods.K2_DetachFromActor_method.Invoke(ObjPointer, LocationRule, RotationRule, ScaleRule);

        ///<summary>Returns the location of the RootComponent of this Actor</summary>
        public Vector K2_GetActorLocation()  => 
            Actor_methods.K2_GetActorLocation_method.Invoke(ObjPointer);

        ///<summary>Returns rotation of the RootComponent of this Actor.</summary>
        public Rotator K2_GetActorRotation()  => 
            Actor_methods.K2_GetActorRotation_method.Invoke(ObjPointer);

        ///<summary>Returns the RootComponent of this Actor</summary>
        public SceneComponent K2_GetRootComponent()  => 
            Actor_methods.K2_GetRootComponent_method.Invoke(ObjPointer);

        ///<summary>Move the Actor to the specified location.</summary>
        ///<remarks>
        ///@param NewLocation   The new location to move the Actor to.
        ///@param bSweep                Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                             Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport             Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                             If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                             If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                             If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///@param SweepHitResult        The hit result from the move if swept.
        ///@return      Whether the location was successfully set (if not swept), or whether movement occurred at all (if swept).
        ///</remarks>
        public (HitResult, bool) K2_SetActorLocation(Vector NewLocation, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_SetActorLocation_method.Invoke(ObjPointer, NewLocation, bSweep, bTeleport);

        ///<summary>Move the actor instantly to the specified location and rotation.</summary>
        ///<remarks>
        ///@param NewLocation           The new location to teleport the Actor to.
        ///@param NewRotation           The new rotation for the Actor.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///@param SweepHitResult        The hit result from the move if swept.
        ///@return      Whether the rotation was successfully set.
        ///</remarks>
        public (HitResult, bool) K2_SetActorLocationAndRotation(Vector NewLocation, Rotator NewRotation, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_SetActorLocationAndRotation_method.Invoke(ObjPointer, NewLocation, NewRotation, bSweep, bTeleport);

        ///<summary>Set the actor's RootComponent to the specified relative location.</summary>
        ///<remarks>
        ///@param NewRelativeLocation   New relative location of the actor's root component
        ///@param bSweep                                Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                             Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                             Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                             If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                             If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                             If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///</remarks>
        public HitResult K2_SetActorRelativeLocation(Vector NewRelativeLocation, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_SetActorRelativeLocation_method.Invoke(ObjPointer, NewRelativeLocation, bSweep, bTeleport);

        ///<summary>
        ///Set the actor's RootComponent to the specified relative rotation
        ///@
        ///</summary>
        ///<remarks>
        ///param NewRelativeRotation   New relative rotation of the actor's root component
        ///@param bSweep                                Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                             Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                             Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                             If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                             If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                             If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///</remarks>
        public HitResult K2_SetActorRelativeRotation(Rotator NewRelativeRotation, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_SetActorRelativeRotation_method.Invoke(ObjPointer, NewRelativeRotation, bSweep, bTeleport);

        ///<summary>
        ///Set the actor's RootComponent to the specified relative transform
        ///@
        ///</summary>
        ///<remarks>
        ///param NewRelativeTransform          New relative transform of the actor's root component
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///</remarks>
        public HitResult K2_SetActorRelativeTransform(Transform NewRelativeTransform, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_SetActorRelativeTransform_method.Invoke(ObjPointer, NewRelativeTransform, bSweep, bTeleport);

        ///<summary>Set the Actor's rotation instantly to the specified rotation.</summary>
        ///<remarks>
        ///@param       NewRotation     The new rotation for the Actor.
        ///@param       bTeleportPhysics Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///@return      Whether the rotation was successfully set.
        ///</remarks>
        public bool K2_SetActorRotation(Rotator NewRotation, bool bTeleportPhysics)  => 
            Actor_methods.K2_SetActorRotation_method.Invoke(ObjPointer, NewRotation, bTeleportPhysics);

        ///<summary>Set the Actors transform to the specified one.</summary>
        ///<remarks>
        ///@param NewTransform          The new transform.
        ///@param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
        ///                                                     Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
        ///@param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
        ///                                                     If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
        ///                                                     If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
        ///                                                     If CCD is on and not teleporting, this will affect objects along the entire swept volume.
        ///</remarks>
        public (HitResult, bool) K2_SetActorTransform(Transform NewTransform, bool bSweep, bool bTeleport)  => 
            Actor_methods.K2_SetActorTransform_method.Invoke(ObjPointer, NewTransform, bSweep, bTeleport);

        ///<summary>Teleport this actor to a new location.</summary>
        ///<remarks>
        ///If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such.
        ///
        ///@param DestLocation The target destination point
        ///@param DestRotation The target rotation at the destination
        ///@return true if the actor has been successfully moved, or false if it couldn't fit.
        ///</remarks>
        public bool K2_TeleportTo(Vector DestLocation, Rotator DestRotation)  => 
            Actor_methods.K2_TeleportTo_method.Invoke(ObjPointer, DestLocation, DestRotation);

        ///<summary>Make MIDFor Material</summary>
        public MaterialInstanceDynamic MakeMIDForMaterial(MaterialInterface Parent)  => 
            Actor_methods.MakeMIDForMaterial_method.Invoke(ObjPointer, Parent);

        ///<summary>Trigger a noise caused by a given Pawn, at a given location.</summary>
        ///<remarks>
        ///Note that the NoiseInstigator Pawn MUST have a PawnNoiseEmitterComponent for the noise to be detected by a PawnSensingComponent.
        ///Senders of MakeNoise should have an Instigator if they are not pawns, or pass a NoiseInstigator.
        ///
        ///@param Loudness The relative loudness of this noise. Usual range is 0 (no noise) to 1 (full volume). If MaxRange is used, this scales the max range, otherwise it affects the hearing range specified by the sensor.
        ///@param NoiseInstigator Pawn responsible for this noise.  Uses the actor's Instigator if NoiseInstigator is null
        ///@param NoiseLocation Position of noise source.  If zero vector, use the actor's location.
        ///@param MaxRange Max range at which the sound may be heard. A value of 0 indicates no max range (though perception may have its own range). Loudness scales the range. (Note: not supported for legacy PawnSensingComponent, only for AIPerception)
        ///@param Tag Identifier for the noise.
        ///</remarks>
        public void MakeNoise(float Loudness, Pawn NoiseInstigator, Vector NoiseLocation, float MaxRange, Name Tag)  => 
            Actor_methods.MakeNoise_method.Invoke(ObjPointer, Loudness, NoiseInstigator, NoiseLocation, MaxRange, Tag);

        ///<summary>Calls PrestreamTextures() for all the actor's meshcomponents.</summary>
        ///<remarks>
        ///@param Seconds - Number of seconds to force all mip-levels to be resident
        ///@param bEnableStreaming      - Whether to start (true) or stop (false) streaming
        ///@param CinematicTextureGroups - Bitfield indicating which texture groups that use extra high-resolution mips
        ///</remarks>
        public void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups)  => 
            Actor_methods.PrestreamTextures_method.Invoke(ObjPointer, Seconds, bEnableStreaming, CinematicTextureGroups);

        ///<summary>Remove tick dependency on PrerequisiteActor.</summary>
        public void RemoveTickPrerequisiteActor(Actor PrerequisiteActor)  => 
            Actor_methods.RemoveTickPrerequisiteActor_method.Invoke(ObjPointer, PrerequisiteActor);

        ///<summary>Remove tick dependency on PrerequisiteComponent.</summary>
        public void RemoveTickPrerequisiteComponent(ActorComponent PrerequisiteComponent)  => 
            Actor_methods.RemoveTickPrerequisiteComponent_method.Invoke(ObjPointer, PrerequisiteComponent);

        ///<summary>Allows enabling/disabling collision for the whole actor</summary>
        public void SetActorEnableCollision(bool bNewActorEnableCollision)  => 
            Actor_methods.SetActorEnableCollision_method.Invoke(ObjPointer, bNewActorEnableCollision);

        ///<summary>
        ///Sets the actor to be hidden in the game
        ///@
        ///</summary>
        ///<remarks>param  bNewHidden      Whether or not to hide the actor and all its components</remarks>
        public void SetActorHiddenInGame(bool bNewHidden)  => 
            Actor_methods.SetActorHiddenInGame_method.Invoke(ObjPointer, bNewHidden);

        ///<summary>Assigns a new label to this actor.</summary>
        ///<remarks>
        ///Actor labels are only available in development builds.
        ///@param       NewActorLabel   The new label string to assign to the actor.  If empty, the actor will have a default label.
        ///@param       bMarkDirty              If true the actor's package will be marked dirty for saving.  Otherwise it will not be.  You should pass false for this parameter if dirtying is not allowed (like during loads)
        ///</remarks>
        public void SetActorLabel(string NewActorLabel, bool bMarkDirty)  => 
            Actor_methods.SetActorLabel_method.Invoke(ObjPointer, NewActorLabel, bMarkDirty);

        ///<summary>
        ///Set the actor's RootComponent to the specified relative scale 3d
        ///@
        ///</summary>
        ///<remarks>param NewRelativeScale      New scale to set the actor's RootComponent to</remarks>
        public void SetActorRelativeScale3D(Vector NewRelativeScale)  => 
            Actor_methods.SetActorRelativeScale3D_method.Invoke(ObjPointer, NewRelativeScale);

        ///<summary>Set the Actor's world-space scale.</summary>
        public void SetActorScale3D(Vector NewScale3D)  => 
            Actor_methods.SetActorScale3D_method.Invoke(ObjPointer, NewScale3D);

        ///<summary>Set this actor's tick functions to be enabled or disabled.</summary>
        ///<remarks>
        ///Only has an effect if the function is registered
        ///This only modifies the tick function on actor itself
        ///@param       bEnabled        Whether it should be enabled or not
        ///</remarks>
        public void SetActorTickEnabled(bool bEnabled)  => 
            Actor_methods.SetActorTickEnabled_method.Invoke(ObjPointer, bEnabled);

        ///<summary>Sets the tick interval of this actor's primary tick function.</summary>
        ///<remarks>
        ///Will not enable a disabled tick function. Takes effect on next tick.
        ///@param TickInterval  The rate at which this actor should be ticking
        ///</remarks>
        public void SetActorTickInterval(float TickInterval)  => 
            Actor_methods.SetActorTickInterval_method.Invoke(ObjPointer, TickInterval);

        ///<summary>Assigns a new folder to this actor.</summary>
        ///<remarks>
        ///Actor folder paths are only available in development builds.
        ///@param       NewFolderPath           The new folder to assign to the actor.
        ///</remarks>
        public void SetFolderPath(Name NewFolderPath)  => 
            Actor_methods.SetFolderPath_method.Invoke(ObjPointer, NewFolderPath);

        ///<summary>
        ///Sets whether or not this actor is hidden in the editor for the duration of the current editor session
        ///@
        ///</summary>
        ///<remarks>param bIsHidden     True if the actor is hidden</remarks>
        public void SetIsTemporarilyHiddenInEditor(bool bIsHidden)  => 
            Actor_methods.SetIsTemporarilyHiddenInEditor_method.Invoke(ObjPointer, bIsHidden);

        ///<summary>Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed.</summary>
        public void SetLifeSpan(float InLifespan)  => 
            Actor_methods.SetLifeSpan_method.Invoke(ObjPointer, InLifespan);

        ///<summary>Puts actor in dormant networking state</summary>
        public void SetNetDormancy(byte NewDormancy)  => 
            Actor_methods.SetNetDormancy_method.Invoke(ObjPointer, NewDormancy);

        ///<summary>Set the owner of this Actor, used primarily for network replication.</summary>
        ///<remarks>
        ///@param NewOwner      The Actor whom takes over ownership of this Actor
        ///</remarks>
        public void SetOwner(Actor NewOwner)  => 
            Actor_methods.SetOwner_method.Invoke(ObjPointer, NewOwner);

        ///<summary>Set whether this actor's movement replicates to network clients.</summary>
        ///<remarks>
        ///@param bInReplicateMovement Whether this Actor's movement replicates to clients.
        ///</remarks>
        public void SetReplicateMovement(bool bInReplicateMovement)  => 
            Actor_methods.SetReplicateMovement_method.Invoke(ObjPointer, bInReplicateMovement);

        ///<summary>Set whether this actor replicates to network clients.</summary>
        ///<remarks>
        ///When this actor is spawned on the server it will be sent to clients as well.
        ///Properties flagged for replication will update on clients if they change on the server.
        ///Internally changes the RemoteRole property and handles the cases where the actor needs to be added to the network actor list.
        ///@param bInReplicates Whether this Actor replicates to network clients.
        ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication/
        ///</remarks>
        public void SetReplicates(bool bInReplicates)  => 
            Actor_methods.SetReplicates_method.Invoke(ObjPointer, bInReplicates);

        ///<summary>Sets whether this actor can tick when paused.</summary>
        public void SetTickableWhenPaused(bool bTickableWhenPaused)  => 
            Actor_methods.SetTickableWhenPaused_method.Invoke(ObjPointer, bTickableWhenPaused);

        ///<summary>Sets the ticking group for this actor.</summary>
        ///<remarks>
        ///@param NewTickGroup the new value to assign
        ///</remarks>
        public void SetTickGroup(byte NewTickGroup)  => 
            Actor_methods.SetTickGroup_method.Invoke(ObjPointer, NewTickGroup);

        ///<summary>Snap Root Component To</summary>
        public void SnapRootComponentTo(Actor InParentActor, Name InSocketName)  => 
            Actor_methods.SnapRootComponentTo_method.Invoke(ObjPointer, InParentActor, InSocketName);

        ///<summary>Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true.</summary>
        public void TearOff()  => 
            Actor_methods.TearOff_method.Invoke(ObjPointer);

        ///<summary>Returns true if this actor has been rendered "recently", with a tolerance in seconds to define what "recent" means.</summary>
        ///<remarks>
        ///e.g.: If a tolerance of 0.1 is used, this function will return true only if the actor was rendered in the last 0.1 seconds of game time.
        ///
        ///@param Tolerance  How many seconds ago the actor last render time can be and still count as having been "recently" rendered.
        ///@return Whether this actor was recently rendered.
        ///</remarks>
        public bool WasRecentlyRendered(float Tolerance)  => 
            Actor_methods.WasRecentlyRendered_method.Invoke(ObjPointer, Tolerance);
        ///<summary>Primary Actor tick function, which calls TickActor().</summary>
        ///<remarks>
        ///Tick functions can be configured to control whether ticking is enabled, at what time during a frame the update occurs, and to set up tick dependencies.
        ///@see https://docs.unrealengine.com/latest/INT/API/Runtime/Engine/Engine/FTickFunction/
        ///@see AddTickPrerequisiteActor(), AddTickPrerequisiteComponent()
        ///</remarks>
        public unsafe ActorTickFunction PrimaryActorTick {
            get {return Actor_ptr->PrimaryActorTick;}
            set {Actor_ptr->PrimaryActorTick = value;}
        }
        public bool bHidden {
            get {return Main.GetGetBoolPropertyByName(this, "bHidden"); }
        }
        public bool bNetTemporary {
            get {return Main.GetGetBoolPropertyByName(this, "bNetTemporary"); }
            set {Main.SetGetBoolPropertyByName(this, "bNetTemporary", value); }
        }
        public bool bNetStartup {
            get {return Main.GetGetBoolPropertyByName(this, "bNetStartup"); }
            set {Main.SetGetBoolPropertyByName(this, "bNetStartup", value); }
        }
        public bool bOnlyRelevantToOwner {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlyRelevantToOwner"); }
        }
        public bool bAlwaysRelevant {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysRelevant"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysRelevant", value); }
        }
        public bool bReplicateMovement {
            get {return Main.GetGetBoolPropertyByName(this, "bReplicateMovement"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplicateMovement", value); }
        }
        public bool bTearOff {
            get {return Main.GetGetBoolPropertyByName(this, "bTearOff"); }
            set {Main.SetGetBoolPropertyByName(this, "bTearOff", value); }
        }
        public bool bExchangedRoles {
            get {return Main.GetGetBoolPropertyByName(this, "bExchangedRoles"); }
            set {Main.SetGetBoolPropertyByName(this, "bExchangedRoles", value); }
        }
        public bool bNetLoadOnClient {
            get {return Main.GetGetBoolPropertyByName(this, "bNetLoadOnClient"); }
            set {Main.SetGetBoolPropertyByName(this, "bNetLoadOnClient", value); }
        }
        public bool bNetUseOwnerRelevancy {
            get {return Main.GetGetBoolPropertyByName(this, "bNetUseOwnerRelevancy"); }
            set {Main.SetGetBoolPropertyByName(this, "bNetUseOwnerRelevancy", value); }
        }
        public bool bRelevantForNetworkReplays {
            get {return Main.GetGetBoolPropertyByName(this, "bRelevantForNetworkReplays"); }
            set {Main.SetGetBoolPropertyByName(this, "bRelevantForNetworkReplays", value); }
        }
        public bool bReplayRewindable {
            get {return Main.GetGetBoolPropertyByName(this, "bReplayRewindable"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplayRewindable", value); }
        }
        public bool bAllowTickBeforeBeginPlay {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowTickBeforeBeginPlay"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowTickBeforeBeginPlay", value); }
        }
        public bool bAutoDestroyWhenFinished {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoDestroyWhenFinished"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoDestroyWhenFinished", value); }
        }
        public bool bBlockInput {
            get {return Main.GetGetBoolPropertyByName(this, "bBlockInput"); }
            set {Main.SetGetBoolPropertyByName(this, "bBlockInput", value); }
        }
        public bool bCanBeDamaged {
            get {return Main.GetGetBoolPropertyByName(this, "bCanBeDamaged"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanBeDamaged", value); }
        }
        public bool bCollideWhenPlacing {
            get {return Main.GetGetBoolPropertyByName(this, "bCollideWhenPlacing"); }
            set {Main.SetGetBoolPropertyByName(this, "bCollideWhenPlacing", value); }
        }
        public bool bFindCameraComponentWhenViewTarget {
            get {return Main.GetGetBoolPropertyByName(this, "bFindCameraComponentWhenViewTarget"); }
            set {Main.SetGetBoolPropertyByName(this, "bFindCameraComponentWhenViewTarget", value); }
        }
        public bool bGenerateOverlapEventsDuringLevelStreaming {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateOverlapEventsDuringLevelStreaming"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateOverlapEventsDuringLevelStreaming", value); }
        }
        public bool bIgnoresOriginShifting {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoresOriginShifting"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoresOriginShifting", value); }
        }
        public bool bEnableAutoLODGeneration {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableAutoLODGeneration"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableAutoLODGeneration", value); }
        }
        public bool bIsEditorOnlyActor {
            get {return Main.GetGetBoolPropertyByName(this, "bIsEditorOnlyActor"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsEditorOnlyActor", value); }
        }
        public bool bActorSeamlessTraveled {
            get {return Main.GetGetBoolPropertyByName(this, "bActorSeamlessTraveled"); }
            set {Main.SetGetBoolPropertyByName(this, "bActorSeamlessTraveled", value); }
        }
        public bool bReplicates {
            get {return Main.GetGetBoolPropertyByName(this, "bReplicates"); }
        }
        public bool bCanBeInCluster {
            get {return Main.GetGetBoolPropertyByName(this, "bCanBeInCluster"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanBeInCluster", value); }
        }
        public bool bAllowReceiveTickEventOnDedicatedServer {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowReceiveTickEventOnDedicatedServer"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowReceiveTickEventOnDedicatedServer", value); }
        }
        public bool bActorEnableCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bActorEnableCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bActorEnableCollision", value); }
        }
        public bool bActorIsBeingDestroyed {
            get {return Main.GetGetBoolPropertyByName(this, "bActorIsBeingDestroyed"); }
            set {Main.SetGetBoolPropertyByName(this, "bActorIsBeingDestroyed", value); }
        }
        ///<summary>Describes how much control the remote machine has over the actor.</summary>
        public unsafe byte RemoteRole {
            get {return Actor_ptr->RemoteRole;}
            set {Actor_ptr->RemoteRole = value;}
        }
        ///<summary>Used for replication of our RootComponent's position and velocity</summary>
        public unsafe RepMovement ReplicatedMovement {
            get {return Actor_ptr->ReplicatedMovement;}
            set {Actor_ptr->ReplicatedMovement = value;}
        }
        ///<summary>How long this Actor lives before dying, 0=forever. Note this is the INITIAL value and should not be modified once play has begun.</summary>
        public unsafe float InitialLifeSpan {
            get {return Actor_ptr->InitialLifeSpan;}
        }
        ///<summary>Allow each actor to run at a different time speed. The DeltaTime for a frame is multiplied by the global TimeDilation (in WorldSettings) and this CustomTimeDilation for this actor's tick.</summary>
        public unsafe float CustomTimeDilation {
            get {return Actor_ptr->CustomTimeDilation;}
            set {Actor_ptr->CustomTimeDilation = value;}
        }
        ///<summary>Used for replicating attachment of this actor's RootComponent to another actor.</summary>
        ///<remarks>This is filled in via GatherCurrentMovement() when the RootComponent has an AttachParent.</remarks>
        public unsafe RepAttachment AttachmentReplication {
            get {return Actor_ptr->AttachmentReplication;}
            set {Actor_ptr->AttachmentReplication = value;}
        }
        ///<summary>
        ///Owner of this Actor, used primarily for replication (bNetUseOwnerRelevancy & bOnlyRelevantToOwner) and visibility (PrimitiveComponent bOwnerNoSee and bOnlyOwnerSee)
        ///@
        ///</summary>
        ///<remarks>see SetOwner(), GetOwner()</remarks>
        public unsafe Actor Owner {
            get {return Actor_ptr->Owner;}
            set {Actor_ptr->Owner = value;}
        }
        ///<summary>Used to specify the net driver to replicate on (NAME_None || NAME_GameNetDriver is the default net driver)</summary>
        public unsafe Name NetDriverName {
            get {return Actor_ptr->NetDriverName;}
            set {Actor_ptr->NetDriverName = value;}
        }
        ///<summary>Describes how much control the local machine has over the actor.</summary>
        public unsafe byte Role {
            get {return Actor_ptr->Role;}
            set {Actor_ptr->Role = value;}
        }
        ///<summary>Dormancy setting for actor to take itself off of the replication list without being destroyed on clients.</summary>
        public unsafe byte NetDormancy {
            get {return Actor_ptr->NetDormancy;}
        }
         //TODO: enum ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingMethod
        ///<summary>Automatically registers this actor to receive input from a player.</summary>
        public unsafe byte AutoReceiveInput {
            get {return Actor_ptr->AutoReceiveInput;}
            set {Actor_ptr->AutoReceiveInput = value;}
        }
        ///<summary>The priority of this input component when pushed in to the stack.</summary>
        public unsafe int InputPriority {
            get {return Actor_ptr->InputPriority;}
            set {Actor_ptr->InputPriority = value;}
        }
        ///<summary>Component that handles input for this actor, if input is enabled.</summary>
        public unsafe InputComponent InputComponent {
            get {return Actor_ptr->InputComponent;}
            set {Actor_ptr->InputComponent = value;}
        }
        ///<summary>Square of the max distance from the client's viewpoint that this actor is relevant and will be replicated.</summary>
        public unsafe float NetCullDistanceSquared {
            get {return Actor_ptr->NetCullDistanceSquared;}
        }
        ///<summary>Internal - used by UNetDriver</summary>
        public unsafe int NetTag {
            get {return Actor_ptr->NetTag;}
            set {Actor_ptr->NetTag = value;}
        }
        ///<summary>How often (per second) this actor will be considered for replication, used to determine NetUpdateTime</summary>
        public unsafe float NetUpdateFrequency {
            get {return Actor_ptr->NetUpdateFrequency;}
            set {Actor_ptr->NetUpdateFrequency = value;}
        }
        ///<summary>Used to determine what rate to throttle down to when replicated properties are changing infrequently</summary>
        public unsafe float MinNetUpdateFrequency {
            get {return Actor_ptr->MinNetUpdateFrequency;}
            set {Actor_ptr->MinNetUpdateFrequency = value;}
        }
        ///<summary>Priority for this actor when checking for replication in a low bandwidth or saturated situation, higher priority means it is more likely to replicate</summary>
        public unsafe float NetPriority {
            get {return Actor_ptr->NetPriority;}
            set {Actor_ptr->NetPriority = value;}
        }
        ///<summary>Pawn responsible for damage caused by this actor.</summary>
        public unsafe Pawn Instigator {
            get {return Actor_ptr->Instigator;}
            set {Actor_ptr->Instigator = value;}
        }
        ///<summary>Array of Actors whose Owner is this actor</summary>
        public ObjectArrayField<Actor> Children{ get {
            if(Children_store == null) Children_store = new ObjectArrayField<Actor> (&Actor_ptr->Children);
            return Children_store;
        } }
        private ObjectArrayField<Actor> Children_store;

        ///<summary>Collision primitive that defines the transform (location, rotation, scale) of this Actor.</summary>
        public unsafe SceneComponent RootComponent {
            get {return Actor_ptr->RootComponent;}
        }
        ///<summary>Local space pivot offset for the actor</summary>
        public unsafe Vector PivotOffset {
            get {return Actor_ptr->PivotOffset;}
        }
        ///<summary>The matinee actors that control this actor.</summary>
        public ObjectArrayField<MatineeActor> ControllingMatineeActors{ get {
            if(ControllingMatineeActors_store == null) ControllingMatineeActors_store = new ObjectArrayField<MatineeActor> (&Actor_ptr->ControllingMatineeActors);
            return ControllingMatineeActors_store;
        } }
        private ObjectArrayField<MatineeActor> ControllingMatineeActors_store;

         //TODO: array not UObject TArray Layers
         //TODO: weak object TWeakObjectPtr<UChildActorComponent> ParentComponent
        ///<summary>The group this actor is a part of.</summary>
        public unsafe Actor GroupActor {
            get {return Actor_ptr->GroupActor;}
            set {Actor_ptr->GroupActor = value;}
        }
        ///<summary>The scale to apply to any billboard components in editor builds (happens in any WITH_EDITOR build, including non-cooked games).</summary>
        public unsafe float SpriteScale {
            get {return Actor_ptr->SpriteScale;}
            set {Actor_ptr->SpriteScale = value;}
        }
         //TODO: numeric uint64 HiddenEditorViews
         //TODO: string FString ActorLabel
        ///<summary>The folder path of this actor in the world (empty=root, / separated)</summary>
        public unsafe Name FolderPath {
            get {return Actor_ptr->FolderPath;}
            set {Actor_ptr->FolderPath = value;}
        }
        public bool bHiddenEd {
            get {return Main.GetGetBoolPropertyByName(this, "bHiddenEd"); }
            set {Main.SetGetBoolPropertyByName(this, "bHiddenEd", value); }
        }
        public bool bIsEditorPreviewActor {
            get {return Main.GetGetBoolPropertyByName(this, "bIsEditorPreviewActor"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsEditorPreviewActor", value); }
        }
        public bool bHiddenEdLayer {
            get {return Main.GetGetBoolPropertyByName(this, "bHiddenEdLayer"); }
            set {Main.SetGetBoolPropertyByName(this, "bHiddenEdLayer", value); }
        }
        public bool bHiddenEdLevel {
            get {return Main.GetGetBoolPropertyByName(this, "bHiddenEdLevel"); }
            set {Main.SetGetBoolPropertyByName(this, "bHiddenEdLevel", value); }
        }
        public bool bLockLocation {
            get {return Main.GetGetBoolPropertyByName(this, "bLockLocation"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockLocation", value); }
        }
        public bool bActorLabelEditable {
            get {return Main.GetGetBoolPropertyByName(this, "bActorLabelEditable"); }
            set {Main.SetGetBoolPropertyByName(this, "bActorLabelEditable", value); }
        }
        public bool bEditable {
            get {return Main.GetGetBoolPropertyByName(this, "bEditable"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditable", value); }
        }
        public bool bListedInSceneOutliner {
            get {return Main.GetGetBoolPropertyByName(this, "bListedInSceneOutliner"); }
            set {Main.SetGetBoolPropertyByName(this, "bListedInSceneOutliner", value); }
        }
        public bool bHiddenEdTemporary {
            get {return Main.GetGetBoolPropertyByName(this, "bHiddenEdTemporary"); }
            set {Main.SetGetBoolPropertyByName(this, "bHiddenEdTemporary", value); }
        }
         //TODO: array not UObject TArray Tags
         //TODO: multicast delegate FTakeAnyDamageSignature OnTakeAnyDamage
         //TODO: multicast delegate FTakePointDamageSignature OnTakePointDamage
         //TODO: multicast delegate FTakeRadialDamageSignature OnTakeRadialDamage
         //TODO: multicast delegate FActorBeginOverlapSignature OnActorBeginOverlap
         //TODO: multicast delegate FActorEndOverlapSignature OnActorEndOverlap
         //TODO: multicast delegate FActorBeginCursorOverSignature OnBeginCursorOver
         //TODO: multicast delegate FActorEndCursorOverSignature OnEndCursorOver
         //TODO: multicast delegate FActorOnClickedSignature OnClicked
         //TODO: multicast delegate FActorOnReleasedSignature OnReleased
         //TODO: multicast delegate FActorOnInputTouchBeginSignature OnInputTouchBegin
         //TODO: multicast delegate FActorOnInputTouchEndSignature OnInputTouchEnd
         //TODO: multicast delegate FActorBeginTouchOverSignature OnInputTouchEnter
         //TODO: multicast delegate FActorEndTouchOverSignature OnInputTouchLeave
         //TODO: multicast delegate FActorHitSignature OnActorHit
         //TODO: multicast delegate FActorDestroyedSignature OnDestroyed
         //TODO: multicast delegate FActorEndPlaySignature OnEndPlay
        ///<summary>Array of ActorComponents that have been added by the user on a per-instance basis.</summary>
        public ObjectArrayField<ActorComponent> InstanceComponents{ get {
            if(InstanceComponents_store == null) InstanceComponents_store = new ObjectArrayField<ActorComponent> (&Actor_ptr->InstanceComponents);
            return InstanceComponents_store;
        } }
        private ObjectArrayField<ActorComponent> InstanceComponents_store;

        ///<summary>Array of ActorComponents that are created by blueprints and serialized per-instance.</summary>
        public ObjectArrayField<ActorComponent> BlueprintCreatedComponents{ get {
            if(BlueprintCreatedComponents_store == null) BlueprintCreatedComponents_store = new ObjectArrayField<ActorComponent> (&Actor_ptr->BlueprintCreatedComponents);
            return BlueprintCreatedComponents_store;
        } }
        private ObjectArrayField<ActorComponent> BlueprintCreatedComponents_store;

        static Actor() {
            StaticClass = Main.GetClass("Actor");
            Actor_events.K2_OnBecomeViewTarget_event.Setup();
            Actor_events.K2_OnEndViewTarget_event.Setup();
            Actor_events.K2_OnReset_event.Setup();
            Actor_events.ReceiveActorBeginCursorOver_event.Setup();
            Actor_events.ReceiveActorBeginOverlap_event.Setup();
            Actor_events.ReceiveActorEndCursorOver_event.Setup();
            Actor_events.ReceiveActorEndOverlap_event.Setup();
            Actor_events.ReceiveActorOnClicked_event.Setup();
            Actor_events.ReceiveActorOnInputTouchBegin_event.Setup();
            Actor_events.ReceiveActorOnInputTouchEnd_event.Setup();
            Actor_events.ReceiveActorOnInputTouchEnter_event.Setup();
            Actor_events.ReceiveActorOnInputTouchLeave_event.Setup();
            Actor_events.ReceiveActorOnReleased_event.Setup();
            Actor_events.ReceiveAnyDamage_event.Setup();
            Actor_events.ReceiveBeginPlay_event.Setup();
            Actor_events.ReceiveDestroyed_event.Setup();
            Actor_events.ReceiveEndPlay_event.Setup();
            Actor_events.ReceiveHit_event.Setup();
            Actor_events.ReceivePointDamage_event.Setup();
            Actor_events.ReceiveRadialDamage_event.Setup();
            Actor_events.ReceiveTick_event.Setup();
            Actor_events.UserConstructionScript_event.Setup();
        }
        internal unsafe Actor_fields* Actor_ptr => (Actor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Actor(IntPtr p) => UObject.Make<Actor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Actor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Actor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
