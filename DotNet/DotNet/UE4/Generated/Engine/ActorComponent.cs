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
    ///<summary>ActorComponent is the base class for components that define reusable behavior that can be added to different types of Actors.</summary>
    ///<remarks>
    ///ActorComponents that have a transform are known as SceneComponents and those that can be rendered are PrimitiveComponents.
    ///
    ///@see [ActorComponent](https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors/Components/index.html#actorcomponents)
    ///@see USceneComponent
    ///@see UPrimitiveComponent
    ///</remarks>
    public unsafe partial class ActorComponent : UObject  {

        ///<summary>
        ///Blueprint implementable event for when the component is beginning play, called before its Owner's BeginPlay on Actor BeginPlay
        ///or when the component is dynamically created if the Actor has already BegunPlay.
        ///</summary>
        public event ReceiveBeginPlay_delegate ReceiveBeginPlay;
        public delegate void ReceiveBeginPlay_delegate();
        internal void on_ReceiveBeginPlay() =>
            ReceiveBeginPlay?.Invoke();


        ///<summary>Blueprint implementable event for when the component ends play, generally via destruction or its Actor's EndPlay.</summary>
        public event ReceiveEndPlay_delegate ReceiveEndPlay;
        public delegate void ReceiveEndPlay_delegate(byte EndPlayReason);
        internal void on_ReceiveEndPlay(byte EndPlayReason) =>
            ReceiveEndPlay?.Invoke(EndPlayReason);


        ///<summary>Event called every frame</summary>
        public event ReceiveTick_delegate ReceiveTick;
        public delegate void ReceiveTick_delegate(float DeltaSeconds);
        internal void on_ReceiveTick(float DeltaSeconds) =>
            ReceiveTick?.Invoke(DeltaSeconds);


        ///<summary>
        ///Activates the SceneComponent
        ///@
        ///</summary>
        ///<remarks>param bReset - Whether the activation should be forced even if ShouldActivate returns false.</remarks>
        public void Activate(bool bReset)  => 
            ActorComponent_methods.Activate_method.Invoke(ObjPointer, bReset);

        ///<summary>Make this component tick after PrerequisiteActor</summary>
        public void AddTickPrerequisiteActor(Actor PrerequisiteActor)  => 
            ActorComponent_methods.AddTickPrerequisiteActor_method.Invoke(ObjPointer, PrerequisiteActor);

        ///<summary>Make this component tick after PrerequisiteComponent.</summary>
        public void AddTickPrerequisiteComponent(ActorComponent PrerequisiteComponent)  => 
            ActorComponent_methods.AddTickPrerequisiteComponent_method.Invoke(ObjPointer, PrerequisiteComponent);

        ///<summary>See if this component contains the supplied tag</summary>
        public bool ComponentHasTag(Name Tag)  => 
            ActorComponent_methods.ComponentHasTag_method.Invoke(ObjPointer, Tag);

        ///<summary>Deactivates the SceneComponent.</summary>
        public void Deactivate()  => 
            ActorComponent_methods.Deactivate_method.Invoke(ObjPointer);

        ///<summary>Returns whether this component has tick enabled or not</summary>
        public float GetComponentTickInterval()  => 
            ActorComponent_methods.GetComponentTickInterval_method.Invoke(ObjPointer);

        ///<summary>Follow the Outer chain to get the  AActor  that 'Owns' this component</summary>
        public Actor GetOwner()  => 
            ActorComponent_methods.GetOwner_method.Invoke(ObjPointer);

        ///<summary>
        ///Returns whether the component is active or not
        ///@
        ///</summary>
        ///<remarks>return - The active state of the component.</remarks>
        public bool IsActive()  => 
            ActorComponent_methods.IsActive_method.Invoke(ObjPointer);

        ///<summary>Returns whether the component is in the process of being destroyed.</summary>
        public bool IsBeingDestroyed()  => 
            ActorComponent_methods.IsBeingDestroyed_method.Invoke(ObjPointer);

        ///<summary>Returns whether this component has tick enabled or not</summary>
        public bool IsComponentTickEnabled()  => 
            ActorComponent_methods.IsComponentTickEnabled_method.Invoke(ObjPointer);

        ///<summary>Unregister and mark for pending kill a component.  This may not be used to destroy a component that is owned by an actor unless the owning actor is calling the function.</summary>
        public void K2_DestroyComponent(UObject UObject)  => 
            ActorComponent_methods.K2_DestroyComponent_method.Invoke(ObjPointer, UObject);

        ///<summary>Remove tick dependency on PrerequisiteActor.</summary>
        public void RemoveTickPrerequisiteActor(Actor PrerequisiteActor)  => 
            ActorComponent_methods.RemoveTickPrerequisiteActor_method.Invoke(ObjPointer, PrerequisiteActor);

        ///<summary>Remove tick dependency on PrerequisiteComponent.</summary>
        public void RemoveTickPrerequisiteComponent(ActorComponent PrerequisiteComponent)  => 
            ActorComponent_methods.RemoveTickPrerequisiteComponent_method.Invoke(ObjPointer, PrerequisiteComponent);

        ///<summary>
        ///Sets whether the component is active or not
        ///@
        ///</summary>
        ///<remarks>
        ///param bNewActive - The new active state of the component
        ///@param bReset - Whether the activation should be forced even if ShouldActivate returns false.
        ///</remarks>
        public void SetActive(bool bNewActive, bool bReset)  => 
            ActorComponent_methods.SetActive_method.Invoke(ObjPointer, bNewActive, bReset);

        ///<summary>Sets whether the component should be auto activate or not.</summary>
        ///<remarks>
        ///Only safe during construction scripts.
        ///@param bNewAutoActivate - The new auto activate state of the component
        ///</remarks>
        public void SetAutoActivate(bool bNewAutoActivate)  => 
            ActorComponent_methods.SetAutoActivate_method.Invoke(ObjPointer, bNewAutoActivate);

        ///<summary>Set this component's tick functions to be enabled or disabled.</summary>
        ///<remarks>
        ///Only has an effect if the function is registered
        ///
        ///@param       bEnabled - Whether it should be enabled or not
        ///</remarks>
        public void SetComponentTickEnabled(bool bEnabled)  => 
            ActorComponent_methods.SetComponentTickEnabled_method.Invoke(ObjPointer, bEnabled);

        ///<summary>Sets the tick interval for this component's primary tick function.</summary>
        ///<remarks>
        ///Does not enable the tick interval. Takes effect on next tick.
        ///@param TickInterval   The duration between ticks for this component's primary tick function
        ///</remarks>
        public void SetComponentTickInterval(float TickInterval)  => 
            ActorComponent_methods.SetComponentTickInterval_method.Invoke(ObjPointer, TickInterval);

        ///<summary>Enable or disable replication. This is the equivalent of RemoteRole for actors (only a bool is required for components)</summary>
        public void SetIsReplicated(bool ShouldReplicate)  => 
            ActorComponent_methods.SetIsReplicated_method.Invoke(ObjPointer, ShouldReplicate);

        ///<summary>Sets whether this component can tick when paused.</summary>
        public void SetTickableWhenPaused(bool bTickableWhenPaused)  => 
            ActorComponent_methods.SetTickableWhenPaused_method.Invoke(ObjPointer, bTickableWhenPaused);

        ///<summary>Changes the ticking group for this component</summary>
        public void SetTickGroup(byte NewTickGroup)  => 
            ActorComponent_methods.SetTickGroup_method.Invoke(ObjPointer, NewTickGroup);

        ///<summary>Toggles the active state of the component</summary>
        public void ToggleActive()  => 
            ActorComponent_methods.ToggleActive_method.Invoke(ObjPointer);
        ///<summary>Main tick function for the Actor</summary>
        public unsafe ActorComponentTickFunction PrimaryComponentTick {
            get {return ActorComponent_ptr->PrimaryComponentTick;}
            set {ActorComponent_ptr->PrimaryComponentTick = value;}
        }
         //TODO: array not UObject TArray ComponentTags
        ///<summary>Array of user data stored with the component</summary>
        public ObjectArrayField<AssetUserData> AssetUserData{ get {
            if(AssetUserData_store == null) AssetUserData_store = new ObjectArrayField<AssetUserData> (&ActorComponent_ptr->AssetUserData);
            return AssetUserData_store;
        } }
        private ObjectArrayField<AssetUserData> AssetUserData_store;

        public bool bReplicates {
            get {return Main.GetGetBoolPropertyByName(this, "bReplicates"); }
        }
        public bool bNetAddressable {
            get {return Main.GetGetBoolPropertyByName(this, "bNetAddressable"); }
            set {Main.SetGetBoolPropertyByName(this, "bNetAddressable", value); }
        }
        public bool bAutoActivate {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoActivate"); }
        }
        public bool bIsActive {
            get {return Main.GetGetBoolPropertyByName(this, "bIsActive"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsActive", value); }
        }
        public bool bEditableWhenInherited {
            get {return Main.GetGetBoolPropertyByName(this, "bEditableWhenInherited"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditableWhenInherited", value); }
        }
        public bool bCanEverAffectNavigation {
            get {return Main.GetGetBoolPropertyByName(this, "bCanEverAffectNavigation"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanEverAffectNavigation", value); }
        }
        public bool bIsEditorOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bIsEditorOnly"); }
        }
        public bool bIsVisualizationComponent {
            get {return Main.GetGetBoolPropertyByName(this, "bIsVisualizationComponent"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsVisualizationComponent", value); }
        }
         //TODO: enum EComponentCreationMethod CreationMethod
         //TODO: array not UObject TArray UCSModifiedProperties
         //TODO: multicast delegate FActorComponentActivatedSignature OnComponentActivated
         //TODO: multicast delegate FActorComponentDeactivateSignature OnComponentDeactivated
        static ActorComponent() {
            StaticClass = Main.GetClass("ActorComponent");
            ActorComponent_events.ReceiveBeginPlay_event.Setup();
            ActorComponent_events.ReceiveEndPlay_event.Setup();
            ActorComponent_events.ReceiveTick_event.Setup();
        }
        internal unsafe ActorComponent_fields* ActorComponent_ptr => (ActorComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ActorComponent(IntPtr p) => UObject.Make<ActorComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ActorComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ActorComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
