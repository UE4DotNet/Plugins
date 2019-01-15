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

using UE4.InputCore;

namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1008 )]
    internal unsafe struct Actor_fields {
        [FieldOffset(56)] public ActorTickFunction PrimaryActorTick;
        [FieldOffset(144)] public bool bHidden;
        [FieldOffset(144)] public bool bNetTemporary;
        [FieldOffset(144)] public bool bNetStartup;
        [FieldOffset(144)] public bool bOnlyRelevantToOwner;
        [FieldOffset(144)] public bool bAlwaysRelevant;
        [FieldOffset(144)] public bool bReplicateMovement;
        [FieldOffset(144)] public bool bTearOff;
        [FieldOffset(144)] public bool bExchangedRoles;
        [FieldOffset(145)] public bool bNetLoadOnClient;
        [FieldOffset(145)] public bool bNetUseOwnerRelevancy;
        [FieldOffset(145)] public bool bRelevantForNetworkReplays;
        [FieldOffset(145)] public bool bReplayRewindable;
        [FieldOffset(145)] public bool bAllowTickBeforeBeginPlay;
        [FieldOffset(145)] public bool bAutoDestroyWhenFinished;
        [FieldOffset(145)] public bool bBlockInput;
        [FieldOffset(145)] public bool bCanBeDamaged;
        [FieldOffset(146)] public bool bCollideWhenPlacing;
        [FieldOffset(146)] public bool bFindCameraComponentWhenViewTarget;
        [FieldOffset(146)] public bool bGenerateOverlapEventsDuringLevelStreaming;
        [FieldOffset(146)] public bool bIgnoresOriginShifting;
        [FieldOffset(146)] public bool bEnableAutoLODGeneration;
        [FieldOffset(146)] public bool bIsEditorOnlyActor;
        [FieldOffset(146)] public bool bActorSeamlessTraveled;
        [FieldOffset(146)] public bool bReplicates;
        [FieldOffset(147)] public bool bCanBeInCluster;
        [FieldOffset(147)] public bool bAllowReceiveTickEventOnDedicatedServer;
        [FieldOffset(148)] public bool bActorEnableCollision;
        [FieldOffset(148)] public bool bActorIsBeingDestroyed;
        [FieldOffset(149)] public byte RemoteRole;
        [FieldOffset(152)] public RepMovement ReplicatedMovement;
        [FieldOffset(204)] public float InitialLifeSpan;
        [FieldOffset(208)] public float CustomTimeDilation;
        [FieldOffset(216)] public RepAttachment AttachmentReplication;
        [FieldOffset(280)]  public IntPtr  Owner;
        [FieldOffset(288)] public Name NetDriverName;
        [FieldOffset(300)] public byte Role;
        [FieldOffset(301)] public byte NetDormancy;
        [FieldOffset(302)] byte SpawnCollisionHandlingMethod; //TODO: enum ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingMethod
        [FieldOffset(303)] public byte AutoReceiveInput;
        [FieldOffset(308)] public int InputPriority;
        [FieldOffset(312)]  public IntPtr  InputComponent;
        [FieldOffset(320)] public float NetCullDistanceSquared;
        [FieldOffset(324)] public int NetTag;
        [FieldOffset(328)] public float NetUpdateFrequency;
        [FieldOffset(332)] public float MinNetUpdateFrequency;
        [FieldOffset(336)] public float NetPriority;
        [FieldOffset(344)]  public IntPtr  Instigator;
        [FieldOffset(352)] public NativeArray Children;
        [FieldOffset(368)]  public IntPtr  RootComponent;
        [FieldOffset(376)] public Vector PivotOffset;
        [FieldOffset(392)] public NativeArray ControllingMatineeActors;
        [FieldOffset(416)] public NativeArray Layers;
        [FieldOffset(440)] byte ParentComponent; //TODO: weak object TWeakObjectPtr<UChildActorComponent> ParentComponent
        [FieldOffset(448)]  public IntPtr  GroupActor;
        [FieldOffset(456)] public float SpriteScale;
        [FieldOffset(464)] byte HiddenEditorViews; //TODO: numeric uint64 HiddenEditorViews
        [FieldOffset(472)] byte ActorLabel; //TODO: string FString ActorLabel
        [FieldOffset(488)] public Name FolderPath;
        [FieldOffset(500)] public bool bHiddenEd;
        [FieldOffset(500)] public bool bIsEditorPreviewActor;
        [FieldOffset(500)] public bool bHiddenEdLayer;
        [FieldOffset(500)] public bool bHiddenEdLevel;
        [FieldOffset(500)] public bool bLockLocation;
        [FieldOffset(500)] public bool bActorLabelEditable;
        [FieldOffset(500)] public bool bEditable;
        [FieldOffset(501)] public bool bListedInSceneOutliner;
        [FieldOffset(501)] public bool bHiddenEdTemporary;
        [FieldOffset(504)] public NativeArray Tags;
        [FieldOffset(520)] byte OnTakeAnyDamage; //TODO: multicast delegate FTakeAnyDamageSignature OnTakeAnyDamage
        [FieldOffset(536)] byte OnTakePointDamage; //TODO: multicast delegate FTakePointDamageSignature OnTakePointDamage
        [FieldOffset(552)] byte OnTakeRadialDamage; //TODO: multicast delegate FTakeRadialDamageSignature OnTakeRadialDamage
        [FieldOffset(568)] byte OnActorBeginOverlap; //TODO: multicast delegate FActorBeginOverlapSignature OnActorBeginOverlap
        [FieldOffset(584)] byte OnActorEndOverlap; //TODO: multicast delegate FActorEndOverlapSignature OnActorEndOverlap
        [FieldOffset(600)] byte OnBeginCursorOver; //TODO: multicast delegate FActorBeginCursorOverSignature OnBeginCursorOver
        [FieldOffset(616)] byte OnEndCursorOver; //TODO: multicast delegate FActorEndCursorOverSignature OnEndCursorOver
        [FieldOffset(632)] byte OnClicked; //TODO: multicast delegate FActorOnClickedSignature OnClicked
        [FieldOffset(648)] byte OnReleased; //TODO: multicast delegate FActorOnReleasedSignature OnReleased
        [FieldOffset(664)] byte OnInputTouchBegin; //TODO: multicast delegate FActorOnInputTouchBeginSignature OnInputTouchBegin
        [FieldOffset(680)] byte OnInputTouchEnd; //TODO: multicast delegate FActorOnInputTouchEndSignature OnInputTouchEnd
        [FieldOffset(696)] byte OnInputTouchEnter; //TODO: multicast delegate FActorBeginTouchOverSignature OnInputTouchEnter
        [FieldOffset(712)] byte OnInputTouchLeave; //TODO: multicast delegate FActorEndTouchOverSignature OnInputTouchLeave
        [FieldOffset(728)] byte OnActorHit; //TODO: multicast delegate FActorHitSignature OnActorHit
        [FieldOffset(744)] byte OnDestroyed; //TODO: multicast delegate FActorDestroyedSignature OnDestroyed
        [FieldOffset(760)] byte OnEndPlay; //TODO: multicast delegate FActorEndPlaySignature OnEndPlay
        [FieldOffset(968)] public NativeArray InstanceComponents;
        [FieldOffset(984)] public NativeArray BlueprintCreatedComponents;
    }
    internal unsafe struct Actor_methods {
        internal struct ActorHasTag_method {
            static internal IntPtr ActorHasTag_ptr;
            static ActorHasTag_method() {
                ActorHasTag_ptr = Main.GetMethodUFunction(Actor.StaticClass, "ActorHasTag");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name Tag) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = Tag;
                Main.GetProcessEvent(obj, ActorHasTag_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct AddComponent_method {
            static internal IntPtr AddComponent_ptr;
            static AddComponent_method() {
                AddComponent_ptr = Main.GetMethodUFunction(Actor.StaticClass, "AddComponent");
            }

            internal static unsafe ActorComponent Invoke(IntPtr obj, Name TemplateName, bool bManualAttachment, Transform RelativeTransform, UObject ComponentTemplateContext) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = TemplateName;
                *((bool*)(b+12)) = bManualAttachment;
                *((Transform*)(b+16)) = RelativeTransform;
                *((IntPtr*)(b+64)) = ComponentTemplateContext;
                Main.GetProcessEvent(obj, AddComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+72));
            }
        }
        internal struct AddTickPrerequisiteActor_method {
            static internal IntPtr AddTickPrerequisiteActor_ptr;
            static AddTickPrerequisiteActor_method() {
                AddTickPrerequisiteActor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "AddTickPrerequisiteActor");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor PrerequisiteActor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PrerequisiteActor;
                Main.GetProcessEvent(obj, AddTickPrerequisiteActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddTickPrerequisiteComponent_method {
            static internal IntPtr AddTickPrerequisiteComponent_ptr;
            static AddTickPrerequisiteComponent_method() {
                AddTickPrerequisiteComponent_ptr = Main.GetMethodUFunction(Actor.StaticClass, "AddTickPrerequisiteComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, ActorComponent PrerequisiteComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PrerequisiteComponent;
                Main.GetProcessEvent(obj, AddTickPrerequisiteComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DetachRootComponentFromParent_method {
            static internal IntPtr DetachRootComponentFromParent_ptr;
            static DetachRootComponentFromParent_method() {
                DetachRootComponentFromParent_ptr = Main.GetMethodUFunction(Actor.StaticClass, "DetachRootComponentFromParent");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bMaintainWorldPosition) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bMaintainWorldPosition;
                Main.GetProcessEvent(obj, DetachRootComponentFromParent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DisableInput_method {
            static internal IntPtr DisableInput_ptr;
            static DisableInput_method() {
                DisableInput_ptr = Main.GetMethodUFunction(Actor.StaticClass, "DisableInput");
            }

            internal static unsafe void Invoke(IntPtr obj, PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                Main.GetProcessEvent(obj, DisableInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableInput_method {
            static internal IntPtr EnableInput_ptr;
            static EnableInput_method() {
                EnableInput_ptr = Main.GetMethodUFunction(Actor.StaticClass, "EnableInput");
            }

            internal static unsafe void Invoke(IntPtr obj, PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                Main.GetProcessEvent(obj, EnableInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FlushNetDormancy_method {
            static internal IntPtr FlushNetDormancy_ptr;
            static FlushNetDormancy_method() {
                FlushNetDormancy_ptr = Main.GetMethodUFunction(Actor.StaticClass, "FlushNetDormancy");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, FlushNetDormancy_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ForceNetUpdate_method {
            static internal IntPtr ForceNetUpdate_ptr;
            static ForceNetUpdate_method() {
                ForceNetUpdate_ptr = Main.GetMethodUFunction(Actor.StaticClass, "ForceNetUpdate");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ForceNetUpdate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetActorBounds_method {
            static internal IntPtr GetActorBounds_ptr;
            static GetActorBounds_method() {
                GetActorBounds_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorBounds");
            }

            internal static unsafe (Vector, Vector) Invoke(IntPtr obj, bool bOnlyCollidingComponents) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bOnlyCollidingComponents;
                Main.GetProcessEvent(obj, GetActorBounds_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+4)),*((Vector*)(b+16)));
            }
        }
        internal struct GetActorEnableCollision_method {
            static internal IntPtr GetActorEnableCollision_ptr;
            static GetActorEnableCollision_method() {
                GetActorEnableCollision_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorEnableCollision");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActorEnableCollision_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetActorEyesViewPoint_method {
            static internal IntPtr GetActorEyesViewPoint_ptr;
            static GetActorEyesViewPoint_method() {
                GetActorEyesViewPoint_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorEyesViewPoint");
            }

            internal static unsafe (Vector, Rotator) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActorEyesViewPoint_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+0)),*((Rotator*)(b+12)));
            }
        }
        internal struct GetActorForwardVector_method {
            static internal IntPtr GetActorForwardVector_ptr;
            static GetActorForwardVector_method() {
                GetActorForwardVector_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorForwardVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActorForwardVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetActorLabel_method {
            static internal IntPtr GetActorLabel_ptr;
            static GetActorLabel_method() {
                GetActorLabel_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorLabel");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActorLabel_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetActorRelativeScale3D_method {
            static internal IntPtr GetActorRelativeScale3D_ptr;
            static GetActorRelativeScale3D_method() {
                GetActorRelativeScale3D_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorRelativeScale3D");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActorRelativeScale3D_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetActorRightVector_method {
            static internal IntPtr GetActorRightVector_ptr;
            static GetActorRightVector_method() {
                GetActorRightVector_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorRightVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActorRightVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetActorScale3D_method {
            static internal IntPtr GetActorScale3D_ptr;
            static GetActorScale3D_method() {
                GetActorScale3D_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorScale3D");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActorScale3D_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetActorTickInterval_method {
            static internal IntPtr GetActorTickInterval_ptr;
            static GetActorTickInterval_method() {
                GetActorTickInterval_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorTickInterval");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActorTickInterval_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetActorTimeDilation_method {
            static internal IntPtr GetActorTimeDilation_ptr;
            static GetActorTimeDilation_method() {
                GetActorTimeDilation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorTimeDilation");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActorTimeDilation_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetActorUpVector_method {
            static internal IntPtr GetActorUpVector_ptr;
            static GetActorUpVector_method() {
                GetActorUpVector_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetActorUpVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActorUpVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetAllChildActors_method {
            static internal IntPtr GetAllChildActors_ptr;
            static GetAllChildActors_method() {
                GetAllChildActors_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetAllChildActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj, bool bIncludeDescendants) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+16)) = bIncludeDescendants;
                Main.GetProcessEvent(obj, GetAllChildActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ChildActors
                return UObject.ToUObjectCollection<Actor>(b+0);
            }
        }
        internal struct GetAttachedActors_method {
            static internal IntPtr GetAttachedActors_ptr;
            static GetAttachedActors_method() {
                GetAttachedActors_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetAttachedActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAttachedActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutActors
                return UObject.ToUObjectCollection<Actor>(b+0);
            }
        }
        internal struct GetAttachParentActor_method {
            static internal IntPtr GetAttachParentActor_ptr;
            static GetAttachParentActor_method() {
                GetAttachParentActor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetAttachParentActor");
            }

            internal static unsafe Actor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAttachParentActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetAttachParentSocketName_method {
            static internal IntPtr GetAttachParentSocketName_ptr;
            static GetAttachParentSocketName_method() {
                GetAttachParentSocketName_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetAttachParentSocketName");
            }

            internal static unsafe Name Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAttachParentSocketName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+0));
            }
        }
        internal struct GetComponentByClass_method {
            static internal IntPtr GetComponentByClass_ptr;
            static GetComponentByClass_method() {
                GetComponentByClass_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetComponentByClass");
            }

            internal static unsafe ActorComponent Invoke(IntPtr obj, SubclassOf<ActorComponent> ComponentClass) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ComponentClass;
                Main.GetProcessEvent(obj, GetComponentByClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetComponentsByClass_method {
            static internal IntPtr GetComponentsByClass_ptr;
            static GetComponentsByClass_method() {
                GetComponentsByClass_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetComponentsByClass");
            }

            internal static unsafe IReadOnlyCollection<ActorComponent> Invoke(IntPtr obj, SubclassOf<ActorComponent> ComponentClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ComponentClass;
                Main.GetProcessEvent(obj, GetComponentsByClass_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<ActorComponent>(b+8);
            }
        }
        internal struct GetComponentsByTag_method {
            static internal IntPtr GetComponentsByTag_ptr;
            static GetComponentsByTag_method() {
                GetComponentsByTag_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetComponentsByTag");
            }

            internal static unsafe IReadOnlyCollection<ActorComponent> Invoke(IntPtr obj, SubclassOf<ActorComponent> ComponentClass, Name Tag) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ComponentClass;
                *((Name*)(b+8)) = Tag;
                Main.GetProcessEvent(obj, GetComponentsByTag_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<ActorComponent>(b+24);
            }
        }
        internal struct GetDistanceTo_method {
            static internal IntPtr GetDistanceTo_ptr;
            static GetDistanceTo_method() {
                GetDistanceTo_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetDistanceTo");
            }

            internal static unsafe float Invoke(IntPtr obj, Actor OtherActor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = OtherActor;
                Main.GetProcessEvent(obj, GetDistanceTo_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetDotProductTo_method {
            static internal IntPtr GetDotProductTo_ptr;
            static GetDotProductTo_method() {
                GetDotProductTo_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetDotProductTo");
            }

            internal static unsafe float Invoke(IntPtr obj, Actor OtherActor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = OtherActor;
                Main.GetProcessEvent(obj, GetDotProductTo_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetFolderPath_method {
            static internal IntPtr GetFolderPath_ptr;
            static GetFolderPath_method() {
                GetFolderPath_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetFolderPath");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ReturnValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ReturnValue;
                Main.GetProcessEvent(obj, GetFolderPath_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetGameTimeSinceCreation_method {
            static internal IntPtr GetGameTimeSinceCreation_ptr;
            static GetGameTimeSinceCreation_method() {
                GetGameTimeSinceCreation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetGameTimeSinceCreation");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetGameTimeSinceCreation_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetHorizontalDistanceTo_method {
            static internal IntPtr GetHorizontalDistanceTo_ptr;
            static GetHorizontalDistanceTo_method() {
                GetHorizontalDistanceTo_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetHorizontalDistanceTo");
            }

            internal static unsafe float Invoke(IntPtr obj, Actor OtherActor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = OtherActor;
                Main.GetProcessEvent(obj, GetHorizontalDistanceTo_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetHorizontalDotProductTo_method {
            static internal IntPtr GetHorizontalDotProductTo_ptr;
            static GetHorizontalDotProductTo_method() {
                GetHorizontalDotProductTo_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetHorizontalDotProductTo");
            }

            internal static unsafe float Invoke(IntPtr obj, Actor OtherActor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = OtherActor;
                Main.GetProcessEvent(obj, GetHorizontalDotProductTo_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetInputAxisKeyValue_method {
            static internal IntPtr GetInputAxisKeyValue_ptr;
            static GetInputAxisKeyValue_method() {
                GetInputAxisKeyValue_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetInputAxisKeyValue");
            }

            internal static unsafe float Invoke(IntPtr obj, Key InputAxisKey) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = InputAxisKey;
                Main.GetProcessEvent(obj, GetInputAxisKeyValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+32));
            }
        }
        internal struct GetInputAxisValue_method {
            static internal IntPtr GetInputAxisValue_ptr;
            static GetInputAxisValue_method() {
                GetInputAxisValue_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetInputAxisValue");
            }

            internal static unsafe float Invoke(IntPtr obj, Name InputAxisName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InputAxisName;
                Main.GetProcessEvent(obj, GetInputAxisValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetInputVectorAxisValue_method {
            static internal IntPtr GetInputVectorAxisValue_ptr;
            static GetInputVectorAxisValue_method() {
                GetInputVectorAxisValue_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetInputVectorAxisValue");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Key InputAxisKey) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = InputAxisKey;
                Main.GetProcessEvent(obj, GetInputVectorAxisValue_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+32));
            }
        }
        internal struct GetInstigator_method {
            static internal IntPtr GetInstigator_ptr;
            static GetInstigator_method() {
                GetInstigator_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetInstigator");
            }

            internal static unsafe Pawn Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetInstigator_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetInstigatorController_method {
            static internal IntPtr GetInstigatorController_ptr;
            static GetInstigatorController_method() {
                GetInstigatorController_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetInstigatorController");
            }

            internal static unsafe Controller Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetInstigatorController_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetLifeSpan_method {
            static internal IntPtr GetLifeSpan_ptr;
            static GetLifeSpan_method() {
                GetLifeSpan_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetLifeSpan");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLifeSpan_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetLocalRole_method {
            static internal IntPtr GetLocalRole_ptr;
            static GetLocalRole_method() {
                GetLocalRole_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetLocalRole");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLocalRole_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetOverlappingActors_method {
            static internal IntPtr GetOverlappingActors_ptr;
            static GetOverlappingActors_method() {
                GetOverlappingActors_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetOverlappingActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj, SubclassOf<Actor> ClassFilter) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+16)) = ClassFilter;
                Main.GetProcessEvent(obj, GetOverlappingActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OverlappingActors
                return UObject.ToUObjectCollection<Actor>(b+0);
            }
        }
        internal struct GetOverlappingComponents_method {
            static internal IntPtr GetOverlappingComponents_ptr;
            static GetOverlappingComponents_method() {
                GetOverlappingComponents_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetOverlappingComponents");
            }

            internal static unsafe IReadOnlyCollection<PrimitiveComponent> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOverlappingComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OverlappingComponents
                return UObject.ToUObjectCollection<PrimitiveComponent>(b+0);
            }
        }
        internal struct GetOwner_method {
            static internal IntPtr GetOwner_ptr;
            static GetOwner_method() {
                GetOwner_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetOwner");
            }

            internal static unsafe Actor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwner_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetParentActor_method {
            static internal IntPtr GetParentActor_ptr;
            static GetParentActor_method() {
                GetParentActor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetParentActor");
            }

            internal static unsafe Actor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetParentActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetParentComponent_method {
            static internal IntPtr GetParentComponent_ptr;
            static GetParentComponent_method() {
                GetParentComponent_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetParentComponent");
            }

            internal static unsafe ChildActorComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetParentComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetRemoteRole_method {
            static internal IntPtr GetRemoteRole_ptr;
            static GetRemoteRole_method() {
                GetRemoteRole_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetRemoteRole");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetRemoteRole_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetSquaredDistanceTo_method {
            static internal IntPtr GetSquaredDistanceTo_ptr;
            static GetSquaredDistanceTo_method() {
                GetSquaredDistanceTo_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetSquaredDistanceTo");
            }

            internal static unsafe float Invoke(IntPtr obj, Actor OtherActor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = OtherActor;
                Main.GetProcessEvent(obj, GetSquaredDistanceTo_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetTickableWhenPaused_method {
            static internal IntPtr GetTickableWhenPaused_ptr;
            static GetTickableWhenPaused_method() {
                GetTickableWhenPaused_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetTickableWhenPaused");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTickableWhenPaused_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetTransform_method {
            static internal IntPtr GetTransform_ptr;
            static GetTransform_method() {
                GetTransform_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetTransform");
            }

            internal static unsafe Transform Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+0));
            }
        }
        internal struct GetVelocity_method {
            static internal IntPtr GetVelocity_ptr;
            static GetVelocity_method() {
                GetVelocity_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetVelocity");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetVelocity_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetVerticalDistanceTo_method {
            static internal IntPtr GetVerticalDistanceTo_ptr;
            static GetVerticalDistanceTo_method() {
                GetVerticalDistanceTo_ptr = Main.GetMethodUFunction(Actor.StaticClass, "GetVerticalDistanceTo");
            }

            internal static unsafe float Invoke(IntPtr obj, Actor OtherActor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = OtherActor;
                Main.GetProcessEvent(obj, GetVerticalDistanceTo_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct HasAuthority_method {
            static internal IntPtr HasAuthority_ptr;
            static HasAuthority_method() {
                HasAuthority_ptr = Main.GetMethodUFunction(Actor.StaticClass, "HasAuthority");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasAuthority_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsActorBeingDestroyed_method {
            static internal IntPtr IsActorBeingDestroyed_ptr;
            static IsActorBeingDestroyed_method() {
                IsActorBeingDestroyed_ptr = Main.GetMethodUFunction(Actor.StaticClass, "IsActorBeingDestroyed");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsActorBeingDestroyed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsActorTickEnabled_method {
            static internal IntPtr IsActorTickEnabled_ptr;
            static IsActorTickEnabled_method() {
                IsActorTickEnabled_ptr = Main.GetMethodUFunction(Actor.StaticClass, "IsActorTickEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsActorTickEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsChildActor_method {
            static internal IntPtr IsChildActor_ptr;
            static IsChildActor_method() {
                IsChildActor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "IsChildActor");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsChildActor_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsEditable_method {
            static internal IntPtr IsEditable_ptr;
            static IsEditable_method() {
                IsEditable_ptr = Main.GetMethodUFunction(Actor.StaticClass, "IsEditable");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsEditable_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsHiddenEd_method {
            static internal IntPtr IsHiddenEd_ptr;
            static IsHiddenEd_method() {
                IsHiddenEd_ptr = Main.GetMethodUFunction(Actor.StaticClass, "IsHiddenEd");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsHiddenEd_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsHiddenEdAtStartup_method {
            static internal IntPtr IsHiddenEdAtStartup_ptr;
            static IsHiddenEdAtStartup_method() {
                IsHiddenEdAtStartup_ptr = Main.GetMethodUFunction(Actor.StaticClass, "IsHiddenEdAtStartup");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsHiddenEdAtStartup_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsOverlappingActor_method {
            static internal IntPtr IsOverlappingActor_ptr;
            static IsOverlappingActor_method() {
                IsOverlappingActor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "IsOverlappingActor");
            }

            internal static unsafe bool Invoke(IntPtr obj, Actor Other) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Other;
                Main.GetProcessEvent(obj, IsOverlappingActor_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsSelectable_method {
            static internal IntPtr IsSelectable_ptr;
            static IsSelectable_method() {
                IsSelectable_ptr = Main.GetMethodUFunction(Actor.StaticClass, "IsSelectable");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsSelectable_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsTemporarilyHiddenInEditor_method {
            static internal IntPtr IsTemporarilyHiddenInEditor_ptr;
            static IsTemporarilyHiddenInEditor_method() {
                IsTemporarilyHiddenInEditor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "IsTemporarilyHiddenInEditor");
            }

            internal static unsafe bool Invoke(IntPtr obj, bool bIncludeParent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bIncludeParent;
                Main.GetProcessEvent(obj, IsTemporarilyHiddenInEditor_ptr, new IntPtr(p)); ;
                return *((bool*)(b+1));
            }
        }
        internal struct K2_AddActorLocalOffset_method {
            static internal IntPtr K2_AddActorLocalOffset_ptr;
            static K2_AddActorLocalOffset_method() {
                K2_AddActorLocalOffset_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_AddActorLocalOffset");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Vector DeltaLocation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = DeltaLocation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddActorLocalOffset_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_AddActorLocalRotation_method {
            static internal IntPtr K2_AddActorLocalRotation_ptr;
            static K2_AddActorLocalRotation_method() {
                K2_AddActorLocalRotation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_AddActorLocalRotation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Rotator DeltaRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = DeltaRotation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddActorLocalRotation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_AddActorLocalTransform_method {
            static internal IntPtr K2_AddActorLocalTransform_ptr;
            static K2_AddActorLocalTransform_method() {
                K2_AddActorLocalTransform_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_AddActorLocalTransform");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Transform NewTransform, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = NewTransform;
                *((bool*)(b+48)) = bSweep;
                *((bool*)(b+196)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddActorLocalTransform_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+52));
            }
        }
        internal struct K2_AddActorWorldOffset_method {
            static internal IntPtr K2_AddActorWorldOffset_ptr;
            static K2_AddActorWorldOffset_method() {
                K2_AddActorWorldOffset_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_AddActorWorldOffset");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Vector DeltaLocation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = DeltaLocation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddActorWorldOffset_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_AddActorWorldRotation_method {
            static internal IntPtr K2_AddActorWorldRotation_ptr;
            static K2_AddActorWorldRotation_method() {
                K2_AddActorWorldRotation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_AddActorWorldRotation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Rotator DeltaRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = DeltaRotation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddActorWorldRotation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_AddActorWorldTransform_method {
            static internal IntPtr K2_AddActorWorldTransform_ptr;
            static K2_AddActorWorldTransform_method() {
                K2_AddActorWorldTransform_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_AddActorWorldTransform");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Transform DeltaTransform, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = DeltaTransform;
                *((bool*)(b+48)) = bSweep;
                *((bool*)(b+196)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddActorWorldTransform_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+52));
            }
        }
        internal struct K2_AttachRootComponentTo_method {
            static internal IntPtr K2_AttachRootComponentTo_ptr;
            static K2_AttachRootComponentTo_method() {
                K2_AttachRootComponentTo_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_AttachRootComponentTo");
            }

            internal static unsafe void Invoke(IntPtr obj, SceneComponent InParent, Name InSocketName, byte AttachLocationType, bool bWeldSimulatedBodies) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InParent;
                *((Name*)(b+8)) = InSocketName;
                *(b+20) = AttachLocationType;
                *((bool*)(b+21)) = bWeldSimulatedBodies;
                Main.GetProcessEvent(obj, K2_AttachRootComponentTo_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_AttachRootComponentToActor_method {
            static internal IntPtr K2_AttachRootComponentToActor_ptr;
            static K2_AttachRootComponentToActor_method() {
                K2_AttachRootComponentToActor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_AttachRootComponentToActor");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor InParentActor, Name InSocketName, byte AttachLocationType, bool bWeldSimulatedBodies) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InParentActor;
                *((Name*)(b+8)) = InSocketName;
                *(b+20) = AttachLocationType;
                *((bool*)(b+21)) = bWeldSimulatedBodies;
                Main.GetProcessEvent(obj, K2_AttachRootComponentToActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_AttachToActor_method {
            static internal IntPtr K2_AttachToActor_ptr;
            static K2_AttachToActor_method() {
                K2_AttachToActor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_AttachToActor");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor ParentActor, Name SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ParentActor;
                *((Name*)(b+8)) = SocketName;
                *(b+20) = (byte)LocationRule;
                *(b+21) = (byte)RotationRule;
                *(b+22) = (byte)ScaleRule;
                *((bool*)(b+23)) = bWeldSimulatedBodies;
                Main.GetProcessEvent(obj, K2_AttachToActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_AttachToComponent_method {
            static internal IntPtr K2_AttachToComponent_ptr;
            static K2_AttachToComponent_method() {
                K2_AttachToComponent_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_AttachToComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, SceneComponent Parent, Name SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Parent;
                *((Name*)(b+8)) = SocketName;
                *(b+20) = (byte)LocationRule;
                *(b+21) = (byte)RotationRule;
                *(b+22) = (byte)ScaleRule;
                *((bool*)(b+23)) = bWeldSimulatedBodies;
                Main.GetProcessEvent(obj, K2_AttachToComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_DestroyActor_method {
            static internal IntPtr K2_DestroyActor_ptr;
            static K2_DestroyActor_method() {
                K2_DestroyActor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_DestroyActor");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_DestroyActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_DestroyComponent_method {
            static internal IntPtr K2_DestroyComponent_ptr;
            static K2_DestroyComponent_method() {
                K2_DestroyComponent_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_DestroyComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, ActorComponent Component) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                Main.GetProcessEvent(obj, K2_DestroyComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_DetachFromActor_method {
            static internal IntPtr K2_DetachFromActor_ptr;
            static K2_DetachFromActor_method() {
                K2_DetachFromActor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_DetachFromActor");
            }

            internal static unsafe void Invoke(IntPtr obj, EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)LocationRule;
                *(b+1) = (byte)RotationRule;
                *(b+2) = (byte)ScaleRule;
                Main.GetProcessEvent(obj, K2_DetachFromActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_GetActorLocation_method {
            static internal IntPtr K2_GetActorLocation_ptr;
            static K2_GetActorLocation_method() {
                K2_GetActorLocation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_GetActorLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetActorLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct K2_GetActorRotation_method {
            static internal IntPtr K2_GetActorRotation_ptr;
            static K2_GetActorRotation_method() {
                K2_GetActorRotation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_GetActorRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetActorRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct K2_GetRootComponent_method {
            static internal IntPtr K2_GetRootComponent_ptr;
            static K2_GetRootComponent_method() {
                K2_GetRootComponent_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_GetRootComponent");
            }

            internal static unsafe SceneComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetRootComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct K2_SetActorLocation_method {
            static internal IntPtr K2_SetActorLocation_ptr;
            static K2_SetActorLocation_method() {
                K2_SetActorLocation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_SetActorLocation");
            }

            internal static unsafe (HitResult, bool) Invoke(IntPtr obj, Vector NewLocation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLocation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetActorLocation_ptr, new IntPtr(p)); ;
                return (*((HitResult*)(b+16)),*((bool*)(b+161)));
            }
        }
        internal struct K2_SetActorLocationAndRotation_method {
            static internal IntPtr K2_SetActorLocationAndRotation_ptr;
            static K2_SetActorLocationAndRotation_method() {
                K2_SetActorLocationAndRotation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_SetActorLocationAndRotation");
            }

            internal static unsafe (HitResult, bool) Invoke(IntPtr obj, Vector NewLocation, Rotator NewRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLocation;
                *((Rotator*)(b+12)) = NewRotation;
                *((bool*)(b+24)) = bSweep;
                *((bool*)(b+172)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetActorLocationAndRotation_ptr, new IntPtr(p)); ;
                return (*((HitResult*)(b+28)),*((bool*)(b+173)));
            }
        }
        internal struct K2_SetActorRelativeLocation_method {
            static internal IntPtr K2_SetActorRelativeLocation_ptr;
            static K2_SetActorRelativeLocation_method() {
                K2_SetActorRelativeLocation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_SetActorRelativeLocation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Vector NewRelativeLocation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewRelativeLocation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetActorRelativeLocation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_SetActorRelativeRotation_method {
            static internal IntPtr K2_SetActorRelativeRotation_ptr;
            static K2_SetActorRelativeRotation_method() {
                K2_SetActorRelativeRotation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_SetActorRelativeRotation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Rotator NewRelativeRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = NewRelativeRotation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetActorRelativeRotation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_SetActorRelativeTransform_method {
            static internal IntPtr K2_SetActorRelativeTransform_ptr;
            static K2_SetActorRelativeTransform_method() {
                K2_SetActorRelativeTransform_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_SetActorRelativeTransform");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Transform NewRelativeTransform, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = NewRelativeTransform;
                *((bool*)(b+48)) = bSweep;
                *((bool*)(b+196)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetActorRelativeTransform_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+52));
            }
        }
        internal struct K2_SetActorRotation_method {
            static internal IntPtr K2_SetActorRotation_ptr;
            static K2_SetActorRotation_method() {
                K2_SetActorRotation_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_SetActorRotation");
            }

            internal static unsafe bool Invoke(IntPtr obj, Rotator NewRotation, bool bTeleportPhysics) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = NewRotation;
                *((bool*)(b+12)) = bTeleportPhysics;
                Main.GetProcessEvent(obj, K2_SetActorRotation_ptr, new IntPtr(p)); ;
                return *((bool*)(b+13));
            }
        }
        internal struct K2_SetActorTransform_method {
            static internal IntPtr K2_SetActorTransform_ptr;
            static K2_SetActorTransform_method() {
                K2_SetActorTransform_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_SetActorTransform");
            }

            internal static unsafe (HitResult, bool) Invoke(IntPtr obj, Transform NewTransform, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = NewTransform;
                *((bool*)(b+48)) = bSweep;
                *((bool*)(b+196)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetActorTransform_ptr, new IntPtr(p)); ;
                return (*((HitResult*)(b+52)),*((bool*)(b+197)));
            }
        }
        internal struct K2_TeleportTo_method {
            static internal IntPtr K2_TeleportTo_ptr;
            static K2_TeleportTo_method() {
                K2_TeleportTo_ptr = Main.GetMethodUFunction(Actor.StaticClass, "K2_TeleportTo");
            }

            internal static unsafe bool Invoke(IntPtr obj, Vector DestLocation, Rotator DestRotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = DestLocation;
                *((Rotator*)(b+12)) = DestRotation;
                Main.GetProcessEvent(obj, K2_TeleportTo_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct MakeMIDForMaterial_method {
            static internal IntPtr MakeMIDForMaterial_ptr;
            static MakeMIDForMaterial_method() {
                MakeMIDForMaterial_ptr = Main.GetMethodUFunction(Actor.StaticClass, "MakeMIDForMaterial");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj, MaterialInterface Parent) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Parent;
                Main.GetProcessEvent(obj, MakeMIDForMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct MakeNoise_method {
            static internal IntPtr MakeNoise_ptr;
            static MakeNoise_method() {
                MakeNoise_ptr = Main.GetMethodUFunction(Actor.StaticClass, "MakeNoise");
            }

            internal static unsafe void Invoke(IntPtr obj, float Loudness, Pawn NoiseInstigator, Vector NoiseLocation, float MaxRange, Name Tag) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Loudness;
                *((IntPtr*)(b+8)) = NoiseInstigator;
                *((Vector*)(b+16)) = NoiseLocation;
                *((float*)(b+28)) = MaxRange;
                *((Name*)(b+32)) = Tag;
                Main.GetProcessEvent(obj, MakeNoise_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PrestreamTextures_method {
            static internal IntPtr PrestreamTextures_ptr;
            static PrestreamTextures_method() {
                PrestreamTextures_ptr = Main.GetMethodUFunction(Actor.StaticClass, "PrestreamTextures");
            }

            internal static unsafe void Invoke(IntPtr obj, float Seconds, bool bEnableStreaming, int CinematicTextureGroups) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Seconds;
                *((bool*)(b+4)) = bEnableStreaming;
                *((int*)(b+8)) = CinematicTextureGroups;
                Main.GetProcessEvent(obj, PrestreamTextures_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveTickPrerequisiteActor_method {
            static internal IntPtr RemoveTickPrerequisiteActor_ptr;
            static RemoveTickPrerequisiteActor_method() {
                RemoveTickPrerequisiteActor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "RemoveTickPrerequisiteActor");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor PrerequisiteActor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PrerequisiteActor;
                Main.GetProcessEvent(obj, RemoveTickPrerequisiteActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveTickPrerequisiteComponent_method {
            static internal IntPtr RemoveTickPrerequisiteComponent_ptr;
            static RemoveTickPrerequisiteComponent_method() {
                RemoveTickPrerequisiteComponent_ptr = Main.GetMethodUFunction(Actor.StaticClass, "RemoveTickPrerequisiteComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, ActorComponent PrerequisiteComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PrerequisiteComponent;
                Main.GetProcessEvent(obj, RemoveTickPrerequisiteComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetActorEnableCollision_method {
            static internal IntPtr SetActorEnableCollision_ptr;
            static SetActorEnableCollision_method() {
                SetActorEnableCollision_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetActorEnableCollision");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewActorEnableCollision) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewActorEnableCollision;
                Main.GetProcessEvent(obj, SetActorEnableCollision_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetActorHiddenInGame_method {
            static internal IntPtr SetActorHiddenInGame_ptr;
            static SetActorHiddenInGame_method() {
                SetActorHiddenInGame_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetActorHiddenInGame");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewHidden) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewHidden;
                Main.GetProcessEvent(obj, SetActorHiddenInGame_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetActorLabel_method {
            static internal IntPtr SetActorLabel_ptr;
            static SetActorLabel_method() {
                SetActorLabel_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetActorLabel");
            }

            internal static unsafe void Invoke(IntPtr obj, string NewActorLabel, bool bMarkDirty) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var NewActorLabel_handle = GCHandle.Alloc(NewActorLabel, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = NewActorLabel_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = NewActorLabel.Length;
                *(int*)(b+IntPtr.Size+4+0) = NewActorLabel.Length;
                *((bool*)(b+16)) = bMarkDirty;
                Main.GetProcessEvent(obj, SetActorLabel_ptr, new IntPtr(p)); ;
                NewActorLabel_handle.Free();
            }
        }
        internal struct SetActorRelativeScale3D_method {
            static internal IntPtr SetActorRelativeScale3D_ptr;
            static SetActorRelativeScale3D_method() {
                SetActorRelativeScale3D_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetActorRelativeScale3D");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewRelativeScale) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewRelativeScale;
                Main.GetProcessEvent(obj, SetActorRelativeScale3D_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetActorScale3D_method {
            static internal IntPtr SetActorScale3D_ptr;
            static SetActorScale3D_method() {
                SetActorScale3D_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetActorScale3D");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewScale3D) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewScale3D;
                Main.GetProcessEvent(obj, SetActorScale3D_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetActorTickEnabled_method {
            static internal IntPtr SetActorTickEnabled_ptr;
            static SetActorTickEnabled_method() {
                SetActorTickEnabled_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetActorTickEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnabled;
                Main.GetProcessEvent(obj, SetActorTickEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetActorTickInterval_method {
            static internal IntPtr SetActorTickInterval_ptr;
            static SetActorTickInterval_method() {
                SetActorTickInterval_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetActorTickInterval");
            }

            internal static unsafe void Invoke(IntPtr obj, float TickInterval) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = TickInterval;
                Main.GetProcessEvent(obj, SetActorTickInterval_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFolderPath_method {
            static internal IntPtr SetFolderPath_ptr;
            static SetFolderPath_method() {
                SetFolderPath_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetFolderPath");
            }

            internal static unsafe void Invoke(IntPtr obj, Name NewFolderPath) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = NewFolderPath;
                Main.GetProcessEvent(obj, SetFolderPath_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIsTemporarilyHiddenInEditor_method {
            static internal IntPtr SetIsTemporarilyHiddenInEditor_ptr;
            static SetIsTemporarilyHiddenInEditor_method() {
                SetIsTemporarilyHiddenInEditor_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetIsTemporarilyHiddenInEditor");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bIsHidden) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bIsHidden;
                Main.GetProcessEvent(obj, SetIsTemporarilyHiddenInEditor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLifeSpan_method {
            static internal IntPtr SetLifeSpan_ptr;
            static SetLifeSpan_method() {
                SetLifeSpan_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetLifeSpan");
            }

            internal static unsafe void Invoke(IntPtr obj, float InLifespan) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InLifespan;
                Main.GetProcessEvent(obj, SetLifeSpan_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetNetDormancy_method {
            static internal IntPtr SetNetDormancy_ptr;
            static SetNetDormancy_method() {
                SetNetDormancy_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetNetDormancy");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewDormancy) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = NewDormancy;
                Main.GetProcessEvent(obj, SetNetDormancy_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOwner_method {
            static internal IntPtr SetOwner_ptr;
            static SetOwner_method() {
                SetOwner_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetOwner");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor NewOwner) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewOwner;
                Main.GetProcessEvent(obj, SetOwner_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetReplicateMovement_method {
            static internal IntPtr SetReplicateMovement_ptr;
            static SetReplicateMovement_method() {
                SetReplicateMovement_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetReplicateMovement");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInReplicateMovement) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInReplicateMovement;
                Main.GetProcessEvent(obj, SetReplicateMovement_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetReplicates_method {
            static internal IntPtr SetReplicates_ptr;
            static SetReplicates_method() {
                SetReplicates_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetReplicates");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInReplicates) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInReplicates;
                Main.GetProcessEvent(obj, SetReplicates_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTickableWhenPaused_method {
            static internal IntPtr SetTickableWhenPaused_ptr;
            static SetTickableWhenPaused_method() {
                SetTickableWhenPaused_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetTickableWhenPaused");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bTickableWhenPaused) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bTickableWhenPaused;
                Main.GetProcessEvent(obj, SetTickableWhenPaused_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTickGroup_method {
            static internal IntPtr SetTickGroup_ptr;
            static SetTickGroup_method() {
                SetTickGroup_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SetTickGroup");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewTickGroup) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = NewTickGroup;
                Main.GetProcessEvent(obj, SetTickGroup_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SnapRootComponentTo_method {
            static internal IntPtr SnapRootComponentTo_ptr;
            static SnapRootComponentTo_method() {
                SnapRootComponentTo_ptr = Main.GetMethodUFunction(Actor.StaticClass, "SnapRootComponentTo");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor InParentActor, Name InSocketName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InParentActor;
                *((Name*)(b+8)) = InSocketName;
                Main.GetProcessEvent(obj, SnapRootComponentTo_ptr, new IntPtr(p)); ;
            }
        }
        internal struct TearOff_method {
            static internal IntPtr TearOff_ptr;
            static TearOff_method() {
                TearOff_ptr = Main.GetMethodUFunction(Actor.StaticClass, "TearOff");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, TearOff_ptr, new IntPtr(p)); ;
            }
        }
        internal struct WasRecentlyRendered_method {
            static internal IntPtr WasRecentlyRendered_ptr;
            static WasRecentlyRendered_method() {
                WasRecentlyRendered_ptr = Main.GetMethodUFunction(Actor.StaticClass, "WasRecentlyRendered");
            }

            internal static unsafe bool Invoke(IntPtr obj, float Tolerance) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Tolerance;
                Main.GetProcessEvent(obj, WasRecentlyRendered_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
    }
    internal unsafe struct Actor_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct K2_OnBecomeViewTarget_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnBecomeViewTarget_link;
            private static unsafe void K2_OnBecomeViewTarget_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnBecomeViewTarget(UObject.Make<PlayerController>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                K2_OnBecomeViewTarget_link = new DelegateHolder<NativeFuncDelegate>(K2_OnBecomeViewTarget_process_event);
                var uf = Main.GetUFunction("K2_OnBecomeViewTarget");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnBecomeViewTarget_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct K2_OnEndViewTarget_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnEndViewTarget_link;
            private static unsafe void K2_OnEndViewTarget_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnEndViewTarget(UObject.Make<PlayerController>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                K2_OnEndViewTarget_link = new DelegateHolder<NativeFuncDelegate>(K2_OnEndViewTarget_process_event);
                var uf = Main.GetUFunction("K2_OnEndViewTarget");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnEndViewTarget_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct K2_OnReset_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnReset_link;
            private static unsafe void K2_OnReset_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnReset();
            }
            internal static void Setup() {
                K2_OnReset_link = new DelegateHolder<NativeFuncDelegate>(K2_OnReset_process_event);
                var uf = Main.GetUFunction("K2_OnReset");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnReset_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceiveActorBeginCursorOver_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActorBeginCursorOver_link;
            private static unsafe void ReceiveActorBeginCursorOver_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActorBeginCursorOver();
            }
            internal static void Setup() {
                ReceiveActorBeginCursorOver_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActorBeginCursorOver_process_event);
                var uf = Main.GetUFunction("ReceiveActorBeginCursorOver");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActorBeginCursorOver_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveActorBeginOverlap_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActorBeginOverlap_link;
            private static unsafe void ReceiveActorBeginOverlap_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActorBeginOverlap(UObject.Make<Actor>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveActorBeginOverlap_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActorBeginOverlap_process_event);
                var uf = Main.GetUFunction("ReceiveActorBeginOverlap");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActorBeginOverlap_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceiveActorEndCursorOver_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActorEndCursorOver_link;
            private static unsafe void ReceiveActorEndCursorOver_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActorEndCursorOver();
            }
            internal static void Setup() {
                ReceiveActorEndCursorOver_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActorEndCursorOver_process_event);
                var uf = Main.GetUFunction("ReceiveActorEndCursorOver");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActorEndCursorOver_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveActorEndOverlap_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActorEndOverlap_link;
            private static unsafe void ReceiveActorEndOverlap_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActorEndOverlap(UObject.Make<Actor>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveActorEndOverlap_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActorEndOverlap_process_event);
                var uf = Main.GetUFunction("ReceiveActorEndOverlap");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActorEndOverlap_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        internal unsafe struct ReceiveActorOnClicked_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActorOnClicked_link;
            private static unsafe void ReceiveActorOnClicked_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActorOnClicked(*(Key*)(b+0));
            }
            internal static void Setup() {
                ReceiveActorOnClicked_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActorOnClicked_process_event);
                var uf = Main.GetUFunction("ReceiveActorOnClicked");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActorOnClicked_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct ReceiveActorOnInputTouchBegin_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActorOnInputTouchBegin_link;
            private static unsafe void ReceiveActorOnInputTouchBegin_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActorOnInputTouchBegin(*(b+0));
            }
            internal static void Setup() {
                ReceiveActorOnInputTouchBegin_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActorOnInputTouchBegin_process_event);
                var uf = Main.GetUFunction("ReceiveActorOnInputTouchBegin");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActorOnInputTouchBegin_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct ReceiveActorOnInputTouchEnd_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActorOnInputTouchEnd_link;
            private static unsafe void ReceiveActorOnInputTouchEnd_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActorOnInputTouchEnd(*(b+0));
            }
            internal static void Setup() {
                ReceiveActorOnInputTouchEnd_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActorOnInputTouchEnd_process_event);
                var uf = Main.GetUFunction("ReceiveActorOnInputTouchEnd");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActorOnInputTouchEnd_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct ReceiveActorOnInputTouchEnter_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActorOnInputTouchEnter_link;
            private static unsafe void ReceiveActorOnInputTouchEnter_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActorOnInputTouchEnter(*(b+0));
            }
            internal static void Setup() {
                ReceiveActorOnInputTouchEnter_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActorOnInputTouchEnter_process_event);
                var uf = Main.GetUFunction("ReceiveActorOnInputTouchEnter");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActorOnInputTouchEnter_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct ReceiveActorOnInputTouchLeave_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActorOnInputTouchLeave_link;
            private static unsafe void ReceiveActorOnInputTouchLeave_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActorOnInputTouchLeave(*(b+0));
            }
            internal static void Setup() {
                ReceiveActorOnInputTouchLeave_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActorOnInputTouchLeave_process_event);
                var uf = Main.GetUFunction("ReceiveActorOnInputTouchLeave");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActorOnInputTouchLeave_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        internal unsafe struct ReceiveActorOnReleased_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActorOnReleased_link;
            private static unsafe void ReceiveActorOnReleased_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActorOnReleased(*(Key*)(b+0));
            }
            internal static void Setup() {
                ReceiveActorOnReleased_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActorOnReleased_process_event);
                var uf = Main.GetUFunction("ReceiveActorOnReleased");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActorOnReleased_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        internal unsafe struct ReceiveAnyDamage_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveAnyDamage_link;
            private static unsafe void ReceiveAnyDamage_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveAnyDamage(*(float*)(b+0), UObject.Make<DamageType>(*(IntPtr*)(b+8)), UObject.Make<Controller>(*(IntPtr*)(b+16)), UObject.Make<Actor>(*(IntPtr*)(b+24)));
            }
            internal static void Setup() {
                ReceiveAnyDamage_link = new DelegateHolder<NativeFuncDelegate>(ReceiveAnyDamage_process_event);
                var uf = Main.GetUFunction("ReceiveAnyDamage");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveAnyDamage_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceiveBeginPlay_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveBeginPlay_link;
            private static unsafe void ReceiveBeginPlay_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveBeginPlay();
            }
            internal static void Setup() {
                ReceiveBeginPlay_link = new DelegateHolder<NativeFuncDelegate>(ReceiveBeginPlay_process_event);
                var uf = Main.GetUFunction("ReceiveBeginPlay");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveBeginPlay_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceiveDestroyed_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveDestroyed_link;
            private static unsafe void ReceiveDestroyed_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveDestroyed();
            }
            internal static void Setup() {
                ReceiveDestroyed_link = new DelegateHolder<NativeFuncDelegate>(ReceiveDestroyed_process_event);
                var uf = Main.GetUFunction("ReceiveDestroyed");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveDestroyed_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct ReceiveEndPlay_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveEndPlay_link;
            private static unsafe void ReceiveEndPlay_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveEndPlay(*(b+0));
            }
            internal static void Setup() {
                ReceiveEndPlay_link = new DelegateHolder<NativeFuncDelegate>(ReceiveEndPlay_process_event);
                var uf = Main.GetUFunction("ReceiveEndPlay");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveEndPlay_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        internal unsafe struct ReceiveHit_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveHit_link;
            private static unsafe void ReceiveHit_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveHit(UObject.Make<PrimitiveComponent>(*(IntPtr*)(b+0)), UObject.Make<Actor>(*(IntPtr*)(b+8)), UObject.Make<PrimitiveComponent>(*(IntPtr*)(b+16)), *(bool*)(b+24), *(Vector*)(b+28), *(Vector*)(b+40), *(Vector*)(b+52), *(HitResult*)(b+64));
            }
            internal static void Setup() {
                ReceiveHit_link = new DelegateHolder<NativeFuncDelegate>(ReceiveHit_process_event);
                var uf = Main.GetUFunction("ReceiveHit");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveHit_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=232 )]
        internal unsafe struct ReceivePointDamage_event {
            private static DelegateHolder<NativeFuncDelegate> ReceivePointDamage_link;
            private static unsafe void ReceivePointDamage_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceivePointDamage(*(float*)(b+0), UObject.Make<DamageType>(*(IntPtr*)(b+8)), *(Vector*)(b+16), *(Vector*)(b+28), UObject.Make<PrimitiveComponent>(*(IntPtr*)(b+40)), *(Name*)(b+48), *(Vector*)(b+60), UObject.Make<Controller>(*(IntPtr*)(b+72)), UObject.Make<Actor>(*(IntPtr*)(b+80)), *(HitResult*)(b+88));
            }
            internal static void Setup() {
                ReceivePointDamage_link = new DelegateHolder<NativeFuncDelegate>(ReceivePointDamage_process_event);
                var uf = Main.GetUFunction("ReceivePointDamage");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceivePointDamage_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=192 )]
        internal unsafe struct ReceiveRadialDamage_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveRadialDamage_link;
            private static unsafe void ReceiveRadialDamage_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveRadialDamage(*(float*)(b+0), UObject.Make<DamageType>(*(IntPtr*)(b+8)), *(Vector*)(b+16), *(HitResult*)(b+28), UObject.Make<Controller>(*(IntPtr*)(b+176)), UObject.Make<Actor>(*(IntPtr*)(b+184)));
            }
            internal static void Setup() {
                ReceiveRadialDamage_link = new DelegateHolder<NativeFuncDelegate>(ReceiveRadialDamage_process_event);
                var uf = Main.GetUFunction("ReceiveRadialDamage");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveRadialDamage_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        internal unsafe struct ReceiveTick_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveTick_link;
            private static unsafe void ReceiveTick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveTick(*(float*)(b+0));
            }
            internal static void Setup() {
                ReceiveTick_link = new DelegateHolder<NativeFuncDelegate>(ReceiveTick_process_event);
                var uf = Main.GetUFunction("ReceiveTick");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveTick_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct UserConstructionScript_event {
            private static DelegateHolder<NativeFuncDelegate> UserConstructionScript_link;
            private static unsafe void UserConstructionScript_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Actor>(context);
                var b = (byte*) theStack->Locals;

                obj.on_UserConstructionScript();
            }
            internal static void Setup() {
                UserConstructionScript_link = new DelegateHolder<NativeFuncDelegate>(UserConstructionScript_process_event);
                var uf = Main.GetUFunction("UserConstructionScript");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(UserConstructionScript_link.Delegate));
            }
        }
    }
}
