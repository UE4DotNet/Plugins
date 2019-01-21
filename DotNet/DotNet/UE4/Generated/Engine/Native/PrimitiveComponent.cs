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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1504 )]
    internal unsafe struct PrimitiveComponent_fields {
        [FieldOffset(632)] public float MinDrawDistance;
        [FieldOffset(636)] public float LDMaxDrawDistance;
        [FieldOffset(640)] public float CachedMaxDrawDistance;
        [FieldOffset(644)] public byte DepthPriorityGroup;
        [FieldOffset(645)] public byte ViewOwnerDepthPriorityGroup;
        [FieldOffset(646)] public byte IndirectLightingCacheQuality;
        [FieldOffset(647)] byte LightmapType; //TODO: enum ELightmapType LightmapType
        [FieldOffset(648)] public bool bEnableAutoLODGeneration;
        [FieldOffset(648)] public bool bUseMaxLODAsImposter;
        [FieldOffset(656)] public NativeArray ExcludeForSpecificHLODLevels;
        [FieldOffset(672)] public bool bNeverDistanceCull;
        [FieldOffset(672)] public bool bAlwaysCreatePhysicsState;
        [FieldOffset(672)] public bool bGenerateOverlapEvents;
        [FieldOffset(672)] public bool bMultiBodyOverlap;
        [FieldOffset(673)] public bool bCheckAsyncSceneOnMove;
        [FieldOffset(673)] public bool bTraceComplexOnMove;
        [FieldOffset(673)] public bool bReturnMaterialOnMove;
        [FieldOffset(673)] public bool bUseViewOwnerDepthPriorityGroup;
        [FieldOffset(673)] public bool bAllowCullDistanceVolume;
        [FieldOffset(673)] public bool bHasMotionBlurVelocityMeshes;
        [FieldOffset(673)] public bool bVisibleInReflectionCaptures;
        [FieldOffset(673)] public bool bRenderInMainPass;
        [FieldOffset(674)] public bool bRenderInMono;
        [FieldOffset(674)] public bool bReceivesDecals;
        [FieldOffset(674)] public bool bOwnerNoSee;
        [FieldOffset(674)] public bool bOnlyOwnerSee;
        [FieldOffset(674)] public bool bTreatAsBackgroundForOcclusion;
        [FieldOffset(674)] public bool bUseAsOccluder;
        [FieldOffset(674)] public bool bSelectable;
        [FieldOffset(674)] public bool bForceMipStreaming;
        [FieldOffset(675)] public bool bHasPerInstanceHitProxies;
        [FieldOffset(675)] public bool CastShadow;
        [FieldOffset(675)] public bool bAffectDynamicIndirectLighting;
        [FieldOffset(675)] public bool bAffectDistanceFieldLighting;
        [FieldOffset(675)] public bool bCastDynamicShadow;
        [FieldOffset(675)] public bool bCastStaticShadow;
        [FieldOffset(675)] public bool bCastVolumetricTranslucentShadow;
        [FieldOffset(675)] public bool bSelfShadowOnly;
        [FieldOffset(676)] public bool bCastFarShadow;
        [FieldOffset(676)] public bool bCastInsetShadow;
        [FieldOffset(676)] public bool bCastCinematicShadow;
        [FieldOffset(676)] public bool bCastHiddenShadow;
        [FieldOffset(676)] public bool bCastShadowAsTwoSided;
        [FieldOffset(676)] public bool bLightAttachmentsAsGroup;
        [FieldOffset(676)] public bool bReceiveMobileCSMShadows;
        [FieldOffset(677)] public bool bSingleSampleShadowFromStationaryLights;
        [FieldOffset(677)] public bool bIgnoreRadialImpulse;
        [FieldOffset(677)] public bool bIgnoreRadialForce;
        [FieldOffset(677)] public bool bApplyImpulseOnDamage;
        [FieldOffset(677)] public bool bReplicatePhysicsToAutonomousProxy;
        [FieldOffset(677)] public bool AlwaysLoadOnClient;
        [FieldOffset(677)] public bool AlwaysLoadOnServer;
        [FieldOffset(677)] public bool bUseEditorCompositing;
        [FieldOffset(678)] public bool bRenderCustomDepth;
        [FieldOffset(679)] public byte bHasCustomNavigableGeometry;
        [FieldOffset(682)] public byte CanCharacterStepUpOn;
        [FieldOffset(683)] public LightingChannels LightingChannels;
        [FieldOffset(684)] byte CustomDepthStencilWriteMask; //TODO: enum ERendererStencilMask CustomDepthStencilWriteMask
        [FieldOffset(688)] public int CustomDepthStencilValue;
        [FieldOffset(692)] public int TranslucencySortPriority;
        [FieldOffset(696)] public int VisibilityId;
        [FieldOffset(704)] public float LpvBiasMultiplier;
        [FieldOffset(716)] public float BoundsScale;
        [FieldOffset(720)] public float LastSubmitTime;
        [FieldOffset(724)] public float LastRenderTime;
        [FieldOffset(728)] public float LastRenderTimeOnScreen;
        [FieldOffset(736)] public NativeArray MoveIgnoreActors;
        [FieldOffset(752)] public NativeArray MoveIgnoreComponents;
        [FieldOffset(800)] public BodyInstance BodyInstance;
        [FieldOffset(1168)] byte OnComponentHit; //TODO: multicast delegate FComponentHitSignature OnComponentHit
        [FieldOffset(1184)] byte OnComponentBeginOverlap; //TODO: multicast delegate FComponentBeginOverlapSignature OnComponentBeginOverlap
        [FieldOffset(1200)] byte OnComponentEndOverlap; //TODO: multicast delegate FComponentEndOverlapSignature OnComponentEndOverlap
        [FieldOffset(1216)] byte OnComponentWake; //TODO: multicast delegate FComponentWakeSignature OnComponentWake
        [FieldOffset(1232)] byte OnComponentSleep; //TODO: multicast delegate FComponentSleepSignature OnComponentSleep
        [FieldOffset(1264)] byte OnBeginCursorOver; //TODO: multicast delegate FComponentBeginCursorOverSignature OnBeginCursorOver
        [FieldOffset(1280)] byte OnEndCursorOver; //TODO: multicast delegate FComponentEndCursorOverSignature OnEndCursorOver
        [FieldOffset(1296)] byte OnClicked; //TODO: multicast delegate FComponentOnClickedSignature OnClicked
        [FieldOffset(1312)] byte OnReleased; //TODO: multicast delegate FComponentOnReleasedSignature OnReleased
        [FieldOffset(1328)] byte OnInputTouchBegin; //TODO: multicast delegate FComponentOnInputTouchBeginSignature OnInputTouchBegin
        [FieldOffset(1344)] byte OnInputTouchEnd; //TODO: multicast delegate FComponentOnInputTouchEndSignature OnInputTouchEnd
        [FieldOffset(1360)] byte OnInputTouchEnter; //TODO: multicast delegate FComponentBeginTouchOverSignature OnInputTouchEnter
        [FieldOffset(1376)] byte OnInputTouchLeave; //TODO: multicast delegate FComponentEndTouchOverSignature OnInputTouchLeave
        [FieldOffset(1408)]  public IntPtr  LODParentPrimitive;
        [FieldOffset(1416)] public PrimitiveComponentPostPhysicsTickFunction PostPhysicsComponentTick;
    }
    internal unsafe struct PrimitiveComponent_methods {
        internal struct AddAngularImpulse_method {
            static internal IntPtr AddAngularImpulse_ptr;
            static AddAngularImpulse_method() {
                AddAngularImpulse_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddAngularImpulse");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Impulse, Name BoneName, bool bVelChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Impulse;
                *((Name*)(b+12)) = BoneName;
                *((bool*)(b+24)) = bVelChange;
                Main.GetProcessEvent(obj, AddAngularImpulse_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddAngularImpulseInDegrees_method {
            static internal IntPtr AddAngularImpulseInDegrees_ptr;
            static AddAngularImpulseInDegrees_method() {
                AddAngularImpulseInDegrees_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddAngularImpulseInDegrees");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Impulse, Name BoneName, bool bVelChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Impulse;
                *((Name*)(b+12)) = BoneName;
                *((bool*)(b+24)) = bVelChange;
                Main.GetProcessEvent(obj, AddAngularImpulseInDegrees_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddAngularImpulseInRadians_method {
            static internal IntPtr AddAngularImpulseInRadians_ptr;
            static AddAngularImpulseInRadians_method() {
                AddAngularImpulseInRadians_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddAngularImpulseInRadians");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Impulse, Name BoneName, bool bVelChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Impulse;
                *((Name*)(b+12)) = BoneName;
                *((bool*)(b+24)) = bVelChange;
                Main.GetProcessEvent(obj, AddAngularImpulseInRadians_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddForce_method {
            static internal IntPtr AddForce_ptr;
            static AddForce_method() {
                AddForce_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddForce");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Force, Name BoneName, bool bAccelChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Force;
                *((Name*)(b+12)) = BoneName;
                *((bool*)(b+24)) = bAccelChange;
                Main.GetProcessEvent(obj, AddForce_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddForceAtLocation_method {
            static internal IntPtr AddForceAtLocation_ptr;
            static AddForceAtLocation_method() {
                AddForceAtLocation_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddForceAtLocation");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Force, Vector Location, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Force;
                *((Vector*)(b+12)) = Location;
                *((Name*)(b+24)) = BoneName;
                Main.GetProcessEvent(obj, AddForceAtLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddForceAtLocationLocal_method {
            static internal IntPtr AddForceAtLocationLocal_ptr;
            static AddForceAtLocationLocal_method() {
                AddForceAtLocationLocal_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddForceAtLocationLocal");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Force, Vector Location, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Force;
                *((Vector*)(b+12)) = Location;
                *((Name*)(b+24)) = BoneName;
                Main.GetProcessEvent(obj, AddForceAtLocationLocal_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddImpulse_method {
            static internal IntPtr AddImpulse_ptr;
            static AddImpulse_method() {
                AddImpulse_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddImpulse");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Impulse, Name BoneName, bool bVelChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Impulse;
                *((Name*)(b+12)) = BoneName;
                *((bool*)(b+24)) = bVelChange;
                Main.GetProcessEvent(obj, AddImpulse_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddImpulseAtLocation_method {
            static internal IntPtr AddImpulseAtLocation_ptr;
            static AddImpulseAtLocation_method() {
                AddImpulseAtLocation_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddImpulseAtLocation");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Impulse, Vector Location, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Impulse;
                *((Vector*)(b+12)) = Location;
                *((Name*)(b+24)) = BoneName;
                Main.GetProcessEvent(obj, AddImpulseAtLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddRadialForce_method {
            static internal IntPtr AddRadialForce_ptr;
            static AddRadialForce_method() {
                AddRadialForce_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddRadialForce");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Origin, float Radius, float Strength, byte Falloff, bool bAccelChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Origin;
                *((float*)(b+12)) = Radius;
                *((float*)(b+16)) = Strength;
                *(b+20) = Falloff;
                *((bool*)(b+21)) = bAccelChange;
                Main.GetProcessEvent(obj, AddRadialForce_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddRadialImpulse_method {
            static internal IntPtr AddRadialImpulse_ptr;
            static AddRadialImpulse_method() {
                AddRadialImpulse_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddRadialImpulse");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Origin, float Radius, float Strength, byte Falloff, bool bVelChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Origin;
                *((float*)(b+12)) = Radius;
                *((float*)(b+16)) = Strength;
                *(b+20) = Falloff;
                *((bool*)(b+21)) = bVelChange;
                Main.GetProcessEvent(obj, AddRadialImpulse_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddTorque_method {
            static internal IntPtr AddTorque_ptr;
            static AddTorque_method() {
                AddTorque_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddTorque");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Torque, Name BoneName, bool bAccelChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Torque;
                *((Name*)(b+12)) = BoneName;
                *((bool*)(b+24)) = bAccelChange;
                Main.GetProcessEvent(obj, AddTorque_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddTorqueInDegrees_method {
            static internal IntPtr AddTorqueInDegrees_ptr;
            static AddTorqueInDegrees_method() {
                AddTorqueInDegrees_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddTorqueInDegrees");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Torque, Name BoneName, bool bAccelChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Torque;
                *((Name*)(b+12)) = BoneName;
                *((bool*)(b+24)) = bAccelChange;
                Main.GetProcessEvent(obj, AddTorqueInDegrees_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddTorqueInRadians_method {
            static internal IntPtr AddTorqueInRadians_ptr;
            static AddTorqueInRadians_method() {
                AddTorqueInRadians_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "AddTorqueInRadians");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Torque, Name BoneName, bool bAccelChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Torque;
                *((Name*)(b+12)) = BoneName;
                *((bool*)(b+24)) = bAccelChange;
                Main.GetProcessEvent(obj, AddTorqueInRadians_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CanCharacterStepUp_method {
            static internal IntPtr CanCharacterStepUp_ptr;
            static CanCharacterStepUp_method() {
                CanCharacterStepUp_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "CanCharacterStepUp");
            }

            internal static unsafe bool Invoke(IntPtr obj, Pawn Pawn) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Pawn;
                Main.GetProcessEvent(obj, CanCharacterStepUp_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct ClearMoveIgnoreActors_method {
            static internal IntPtr ClearMoveIgnoreActors_ptr;
            static ClearMoveIgnoreActors_method() {
                ClearMoveIgnoreActors_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "ClearMoveIgnoreActors");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMoveIgnoreActors_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMoveIgnoreComponents_method {
            static internal IntPtr ClearMoveIgnoreComponents_ptr;
            static ClearMoveIgnoreComponents_method() {
                ClearMoveIgnoreComponents_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "ClearMoveIgnoreComponents");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMoveIgnoreComponents_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CopyArrayOfMoveIgnoreActors_method {
            static internal IntPtr CopyArrayOfMoveIgnoreActors_ptr;
            static CopyArrayOfMoveIgnoreActors_method() {
                CopyArrayOfMoveIgnoreActors_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "CopyArrayOfMoveIgnoreActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CopyArrayOfMoveIgnoreActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<Actor>(b+0);
            }
        }
        internal struct CopyArrayOfMoveIgnoreComponents_method {
            static internal IntPtr CopyArrayOfMoveIgnoreComponents_ptr;
            static CopyArrayOfMoveIgnoreComponents_method() {
                CopyArrayOfMoveIgnoreComponents_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "CopyArrayOfMoveIgnoreComponents");
            }

            internal static unsafe IReadOnlyCollection<PrimitiveComponent> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CopyArrayOfMoveIgnoreComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<PrimitiveComponent>(b+0);
            }
        }
        internal struct CreateAndSetMaterialInstanceDynamic_method {
            static internal IntPtr CreateAndSetMaterialInstanceDynamic_ptr;
            static CreateAndSetMaterialInstanceDynamic_method() {
                CreateAndSetMaterialInstanceDynamic_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "CreateAndSetMaterialInstanceDynamic");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj, int ElementIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ElementIndex;
                Main.GetProcessEvent(obj, CreateAndSetMaterialInstanceDynamic_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct CreateAndSetMaterialInstanceDynamicFromMaterial_method {
            static internal IntPtr CreateAndSetMaterialInstanceDynamicFromMaterial_ptr;
            static CreateAndSetMaterialInstanceDynamicFromMaterial_method() {
                CreateAndSetMaterialInstanceDynamicFromMaterial_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "CreateAndSetMaterialInstanceDynamicFromMaterial");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj, int ElementIndex, MaterialInterface Parent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ElementIndex;
                *((IntPtr*)(b+8)) = Parent;
                Main.GetProcessEvent(obj, CreateAndSetMaterialInstanceDynamicFromMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct CreateDynamicMaterialInstance_method {
            static internal IntPtr CreateDynamicMaterialInstance_ptr;
            static CreateDynamicMaterialInstance_method() {
                CreateDynamicMaterialInstance_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "CreateDynamicMaterialInstance");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj, int ElementIndex, MaterialInterface SourceMaterial, Name OptionalName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ElementIndex;
                *((IntPtr*)(b+8)) = SourceMaterial;
                *((Name*)(b+16)) = OptionalName;
                Main.GetProcessEvent(obj, CreateDynamicMaterialInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+32));
            }
        }
        internal struct GetAngularDamping_method {
            static internal IntPtr GetAngularDamping_ptr;
            static GetAngularDamping_method() {
                GetAngularDamping_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetAngularDamping");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAngularDamping_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetCenterOfMass_method {
            static internal IntPtr GetCenterOfMass_ptr;
            static GetCenterOfMass_method() {
                GetCenterOfMass_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetCenterOfMass");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, GetCenterOfMass_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetClosestPointOnCollision_method {
            static internal IntPtr GetClosestPointOnCollision_ptr;
            static GetClosestPointOnCollision_method() {
                GetClosestPointOnCollision_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetClosestPointOnCollision");
            }

            internal static unsafe (Vector, float) Invoke(IntPtr obj, Vector Point, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *((Name*)(b+24)) = BoneName;
                Main.GetProcessEvent(obj, GetClosestPointOnCollision_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+12)),*((float*)(b+36)));
            }
        }
        internal struct GetCollisionEnabled_method {
            static internal IntPtr GetCollisionEnabled_ptr;
            static GetCollisionEnabled_method() {
                GetCollisionEnabled_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetCollisionEnabled");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCollisionEnabled_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetCollisionObjectType_method {
            static internal IntPtr GetCollisionObjectType_ptr;
            static GetCollisionObjectType_method() {
                GetCollisionObjectType_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetCollisionObjectType");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCollisionObjectType_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetCollisionProfileName_method {
            static internal IntPtr GetCollisionProfileName_ptr;
            static GetCollisionProfileName_method() {
                GetCollisionProfileName_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetCollisionProfileName");
            }

            internal static unsafe Name Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCollisionProfileName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+0));
            }
        }
        internal struct GetCollisionResponseToChannel_method {
            static internal IntPtr GetCollisionResponseToChannel_ptr;
            static GetCollisionResponseToChannel_method() {
                GetCollisionResponseToChannel_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetCollisionResponseToChannel");
            }

            internal static unsafe byte Invoke(IntPtr obj, byte Channel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Channel;
                Main.GetProcessEvent(obj, GetCollisionResponseToChannel_ptr, new IntPtr(p)); ;
                return *(b+1);
            }
        }
        internal struct GetGenerateOverlapEvents_method {
            static internal IntPtr GetGenerateOverlapEvents_ptr;
            static GetGenerateOverlapEvents_method() {
                GetGenerateOverlapEvents_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetGenerateOverlapEvents");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetGenerateOverlapEvents_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetInertiaTensor_method {
            static internal IntPtr GetInertiaTensor_ptr;
            static GetInertiaTensor_method() {
                GetInertiaTensor_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetInertiaTensor");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, GetInertiaTensor_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetLinearDamping_method {
            static internal IntPtr GetLinearDamping_ptr;
            static GetLinearDamping_method() {
                GetLinearDamping_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetLinearDamping");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLinearDamping_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMass_method {
            static internal IntPtr GetMass_ptr;
            static GetMass_method() {
                GetMass_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetMass");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMass_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMassScale_method {
            static internal IntPtr GetMassScale_ptr;
            static GetMassScale_method() {
                GetMassScale_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetMassScale");
            }

            internal static unsafe float Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, GetMassScale_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetMaterial_method {
            static internal IntPtr GetMaterial_ptr;
            static GetMaterial_method() {
                GetMaterial_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetMaterial");
            }

            internal static unsafe MaterialInterface Invoke(IntPtr obj, int ElementIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ElementIndex;
                Main.GetProcessEvent(obj, GetMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetMaterialFromCollisionFaceIndex_method {
            static internal IntPtr GetMaterialFromCollisionFaceIndex_ptr;
            static GetMaterialFromCollisionFaceIndex_method() {
                GetMaterialFromCollisionFaceIndex_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetMaterialFromCollisionFaceIndex");
            }

            internal static unsafe (int, MaterialInterface) Invoke(IntPtr obj, int FaceIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = FaceIndex;
                Main.GetProcessEvent(obj, GetMaterialFromCollisionFaceIndex_ptr, new IntPtr(p)); ;
                return (*((int*)(b+4)),*((IntPtr*)(b+8)));
            }
        }
        internal struct GetNumMaterials_method {
            static internal IntPtr GetNumMaterials_ptr;
            static GetNumMaterials_method() {
                GetNumMaterials_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetNumMaterials");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumMaterials_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetOverlappingActors_method {
            static internal IntPtr GetOverlappingActors_ptr;
            static GetOverlappingActors_method() {
                GetOverlappingActors_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetOverlappingActors");
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
                GetOverlappingComponents_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetOverlappingComponents");
            }

            internal static unsafe IReadOnlyCollection<PrimitiveComponent> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOverlappingComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutOverlappingComponents
                return UObject.ToUObjectCollection<PrimitiveComponent>(b+0);
            }
        }
        internal struct GetPhysicsAngularVelocity_method {
            static internal IntPtr GetPhysicsAngularVelocity_ptr;
            static GetPhysicsAngularVelocity_method() {
                GetPhysicsAngularVelocity_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetPhysicsAngularVelocity");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, GetPhysicsAngularVelocity_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetPhysicsAngularVelocityInDegrees_method {
            static internal IntPtr GetPhysicsAngularVelocityInDegrees_ptr;
            static GetPhysicsAngularVelocityInDegrees_method() {
                GetPhysicsAngularVelocityInDegrees_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetPhysicsAngularVelocityInDegrees");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, GetPhysicsAngularVelocityInDegrees_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetPhysicsAngularVelocityInRadians_method {
            static internal IntPtr GetPhysicsAngularVelocityInRadians_ptr;
            static GetPhysicsAngularVelocityInRadians_method() {
                GetPhysicsAngularVelocityInRadians_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetPhysicsAngularVelocityInRadians");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, GetPhysicsAngularVelocityInRadians_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetPhysicsLinearVelocity_method {
            static internal IntPtr GetPhysicsLinearVelocity_ptr;
            static GetPhysicsLinearVelocity_method() {
                GetPhysicsLinearVelocity_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetPhysicsLinearVelocity");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, GetPhysicsLinearVelocity_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetPhysicsLinearVelocityAtPoint_method {
            static internal IntPtr GetPhysicsLinearVelocityAtPoint_ptr;
            static GetPhysicsLinearVelocityAtPoint_method() {
                GetPhysicsLinearVelocityAtPoint_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetPhysicsLinearVelocityAtPoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector Point, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *((Name*)(b+12)) = BoneName;
                Main.GetProcessEvent(obj, GetPhysicsLinearVelocityAtPoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct GetWalkableSlopeOverride_method {
            static internal IntPtr GetWalkableSlopeOverride_ptr;
            static GetWalkableSlopeOverride_method() {
                GetWalkableSlopeOverride_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "GetWalkableSlopeOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, WalkableSlopeOverride ReturnValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((WalkableSlopeOverride*)(b+0)) = ReturnValue;
                Main.GetProcessEvent(obj, GetWalkableSlopeOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IgnoreActorWhenMoving_method {
            static internal IntPtr IgnoreActorWhenMoving_ptr;
            static IgnoreActorWhenMoving_method() {
                IgnoreActorWhenMoving_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "IgnoreActorWhenMoving");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor Actor, bool bShouldIgnore) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Actor;
                *((bool*)(b+8)) = bShouldIgnore;
                Main.GetProcessEvent(obj, IgnoreActorWhenMoving_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IgnoreComponentWhenMoving_method {
            static internal IntPtr IgnoreComponentWhenMoving_ptr;
            static IgnoreComponentWhenMoving_method() {
                IgnoreComponentWhenMoving_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "IgnoreComponentWhenMoving");
            }

            internal static unsafe void Invoke(IntPtr obj, PrimitiveComponent Component, bool bShouldIgnore) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                *((bool*)(b+8)) = bShouldIgnore;
                Main.GetProcessEvent(obj, IgnoreComponentWhenMoving_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsAnyRigidBodyAwake_method {
            static internal IntPtr IsAnyRigidBodyAwake_ptr;
            static IsAnyRigidBodyAwake_method() {
                IsAnyRigidBodyAwake_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "IsAnyRigidBodyAwake");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsAnyRigidBodyAwake_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsGravityEnabled_method {
            static internal IntPtr IsGravityEnabled_ptr;
            static IsGravityEnabled_method() {
                IsGravityEnabled_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "IsGravityEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsGravityEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsOverlappingActor_method {
            static internal IntPtr IsOverlappingActor_ptr;
            static IsOverlappingActor_method() {
                IsOverlappingActor_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "IsOverlappingActor");
            }

            internal static unsafe bool Invoke(IntPtr obj, Actor Other) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Other;
                Main.GetProcessEvent(obj, IsOverlappingActor_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsOverlappingComponent_method {
            static internal IntPtr IsOverlappingComponent_ptr;
            static IsOverlappingComponent_method() {
                IsOverlappingComponent_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "IsOverlappingComponent");
            }

            internal static unsafe bool Invoke(IntPtr obj, PrimitiveComponent OtherComp) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = OtherComp;
                Main.GetProcessEvent(obj, IsOverlappingComponent_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct K2_BoxOverlapComponent_method {
            static internal IntPtr K2_BoxOverlapComponent_ptr;
            static K2_BoxOverlapComponent_method() {
                K2_BoxOverlapComponent_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "K2_BoxOverlapComponent");
            }

            internal static unsafe (Vector, Vector, Name, HitResult, bool) Invoke(IntPtr obj, Vector InBoxCentre, Box InBox, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InBoxCentre;
                *((Box*)(b+12)) = InBox;
                *((bool*)(b+40)) = bTraceComplex;
                *((bool*)(b+41)) = bShowTrace;
                *((bool*)(b+42)) = bPersistentShowTrace;
                Main.GetProcessEvent(obj, K2_BoxOverlapComponent_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+44)),*((Vector*)(b+56)),*((Name*)(b+68)),*((HitResult*)(b+80)),*((bool*)(b+224)));
            }
        }
        internal struct K2_IsCollisionEnabled_method {
            static internal IntPtr K2_IsCollisionEnabled_ptr;
            static K2_IsCollisionEnabled_method() {
                K2_IsCollisionEnabled_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "K2_IsCollisionEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_IsCollisionEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_IsPhysicsCollisionEnabled_method {
            static internal IntPtr K2_IsPhysicsCollisionEnabled_ptr;
            static K2_IsPhysicsCollisionEnabled_method() {
                K2_IsPhysicsCollisionEnabled_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "K2_IsPhysicsCollisionEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_IsPhysicsCollisionEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_IsQueryCollisionEnabled_method {
            static internal IntPtr K2_IsQueryCollisionEnabled_ptr;
            static K2_IsQueryCollisionEnabled_method() {
                K2_IsQueryCollisionEnabled_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "K2_IsQueryCollisionEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_IsQueryCollisionEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_LineTraceComponent_method {
            static internal IntPtr K2_LineTraceComponent_ptr;
            static K2_LineTraceComponent_method() {
                K2_LineTraceComponent_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "K2_LineTraceComponent");
            }

            internal static unsafe (Vector, Vector, Name, HitResult, bool) Invoke(IntPtr obj, Vector TraceStart, Vector TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = TraceStart;
                *((Vector*)(b+12)) = TraceEnd;
                *((bool*)(b+24)) = bTraceComplex;
                *((bool*)(b+25)) = bShowTrace;
                *((bool*)(b+26)) = bPersistentShowTrace;
                Main.GetProcessEvent(obj, K2_LineTraceComponent_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+28)),*((Vector*)(b+40)),*((Name*)(b+52)),*((HitResult*)(b+64)),*((bool*)(b+208)));
            }
        }
        internal struct K2_SphereOverlapComponent_method {
            static internal IntPtr K2_SphereOverlapComponent_ptr;
            static K2_SphereOverlapComponent_method() {
                K2_SphereOverlapComponent_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "K2_SphereOverlapComponent");
            }

            internal static unsafe (Vector, Vector, Name, HitResult, bool) Invoke(IntPtr obj, Vector InSphereCentre, float InSphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InSphereCentre;
                *((float*)(b+12)) = InSphereRadius;
                *((bool*)(b+16)) = bTraceComplex;
                *((bool*)(b+17)) = bShowTrace;
                *((bool*)(b+18)) = bPersistentShowTrace;
                Main.GetProcessEvent(obj, K2_SphereOverlapComponent_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+20)),*((Vector*)(b+32)),*((Name*)(b+44)),*((HitResult*)(b+56)),*((bool*)(b+200)));
            }
        }
        internal struct K2_SphereTraceComponent_method {
            static internal IntPtr K2_SphereTraceComponent_ptr;
            static K2_SphereTraceComponent_method() {
                K2_SphereTraceComponent_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "K2_SphereTraceComponent");
            }

            internal static unsafe (Vector, Vector, Name, HitResult, bool) Invoke(IntPtr obj, Vector TraceStart, Vector TraceEnd, float SphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = TraceStart;
                *((Vector*)(b+12)) = TraceEnd;
                *((float*)(b+24)) = SphereRadius;
                *((bool*)(b+28)) = bTraceComplex;
                *((bool*)(b+29)) = bShowTrace;
                *((bool*)(b+30)) = bPersistentShowTrace;
                Main.GetProcessEvent(obj, K2_SphereTraceComponent_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+32)),*((Vector*)(b+44)),*((Name*)(b+56)),*((HitResult*)(b+68)),*((bool*)(b+212)));
            }
        }
        internal struct PutRigidBodyToSleep_method {
            static internal IntPtr PutRigidBodyToSleep_ptr;
            static PutRigidBodyToSleep_method() {
                PutRigidBodyToSleep_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "PutRigidBodyToSleep");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, PutRigidBodyToSleep_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ScaleByMomentOfInertia_method {
            static internal IntPtr ScaleByMomentOfInertia_ptr;
            static ScaleByMomentOfInertia_method() {
                ScaleByMomentOfInertia_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "ScaleByMomentOfInertia");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector InputVector, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InputVector;
                *((Name*)(b+12)) = BoneName;
                Main.GetProcessEvent(obj, ScaleByMomentOfInertia_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct SetAllMassScale_method {
            static internal IntPtr SetAllMassScale_ptr;
            static SetAllMassScale_method() {
                SetAllMassScale_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetAllMassScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float InMassScale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InMassScale;
                Main.GetProcessEvent(obj, SetAllMassScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllPhysicsAngularVelocity_method {
            static internal IntPtr SetAllPhysicsAngularVelocity_ptr;
            static SetAllPhysicsAngularVelocity_method() {
                SetAllPhysicsAngularVelocity_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetAllPhysicsAngularVelocity");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewAngVel, bool bAddToCurrent) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewAngVel;
                *((bool*)(b+12)) = bAddToCurrent;
                Main.GetProcessEvent(obj, SetAllPhysicsAngularVelocity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllPhysicsAngularVelocityInDegrees_method {
            static internal IntPtr SetAllPhysicsAngularVelocityInDegrees_ptr;
            static SetAllPhysicsAngularVelocityInDegrees_method() {
                SetAllPhysicsAngularVelocityInDegrees_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetAllPhysicsAngularVelocityInDegrees");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewAngVel, bool bAddToCurrent) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewAngVel;
                *((bool*)(b+12)) = bAddToCurrent;
                Main.GetProcessEvent(obj, SetAllPhysicsAngularVelocityInDegrees_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllPhysicsAngularVelocityInRadians_method {
            static internal IntPtr SetAllPhysicsAngularVelocityInRadians_ptr;
            static SetAllPhysicsAngularVelocityInRadians_method() {
                SetAllPhysicsAngularVelocityInRadians_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetAllPhysicsAngularVelocityInRadians");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewAngVel, bool bAddToCurrent) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewAngVel;
                *((bool*)(b+12)) = bAddToCurrent;
                Main.GetProcessEvent(obj, SetAllPhysicsAngularVelocityInRadians_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllPhysicsLinearVelocity_method {
            static internal IntPtr SetAllPhysicsLinearVelocity_ptr;
            static SetAllPhysicsLinearVelocity_method() {
                SetAllPhysicsLinearVelocity_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetAllPhysicsLinearVelocity");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewVel, bool bAddToCurrent) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewVel;
                *((bool*)(b+12)) = bAddToCurrent;
                Main.GetProcessEvent(obj, SetAllPhysicsLinearVelocity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllUseCCD_method {
            static internal IntPtr SetAllUseCCD_ptr;
            static SetAllUseCCD_method() {
                SetAllUseCCD_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetAllUseCCD");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InUseCCD) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InUseCCD;
                Main.GetProcessEvent(obj, SetAllUseCCD_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularDamping_method {
            static internal IntPtr SetAngularDamping_ptr;
            static SetAngularDamping_method() {
                SetAngularDamping_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetAngularDamping");
            }

            internal static unsafe void Invoke(IntPtr obj, float InDamping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InDamping;
                Main.GetProcessEvent(obj, SetAngularDamping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBoundsScale_method {
            static internal IntPtr SetBoundsScale_ptr;
            static SetBoundsScale_method() {
                SetBoundsScale_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetBoundsScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewBoundsScale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewBoundsScale;
                Main.GetProcessEvent(obj, SetBoundsScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCastShadow_method {
            static internal IntPtr SetCastShadow_ptr;
            static SetCastShadow_method() {
                SetCastShadow_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetCastShadow");
            }

            internal static unsafe void Invoke(IntPtr obj, bool NewCastShadow) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = NewCastShadow;
                Main.GetProcessEvent(obj, SetCastShadow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCenterOfMass_method {
            static internal IntPtr SetCenterOfMass_ptr;
            static SetCenterOfMass_method() {
                SetCenterOfMass_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetCenterOfMass");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector CenterOfMassOffset, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = CenterOfMassOffset;
                *((Name*)(b+12)) = BoneName;
                Main.GetProcessEvent(obj, SetCenterOfMass_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCollisionEnabled_method {
            static internal IntPtr SetCollisionEnabled_ptr;
            static SetCollisionEnabled_method() {
                SetCollisionEnabled_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetCollisionEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = NewType;
                Main.GetProcessEvent(obj, SetCollisionEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCollisionObjectType_method {
            static internal IntPtr SetCollisionObjectType_ptr;
            static SetCollisionObjectType_method() {
                SetCollisionObjectType_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetCollisionObjectType");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Channel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Channel;
                Main.GetProcessEvent(obj, SetCollisionObjectType_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCollisionProfileName_method {
            static internal IntPtr SetCollisionProfileName_ptr;
            static SetCollisionProfileName_method() {
                SetCollisionProfileName_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetCollisionProfileName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InCollisionProfileName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InCollisionProfileName;
                Main.GetProcessEvent(obj, SetCollisionProfileName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCollisionResponseToAllChannels_method {
            static internal IntPtr SetCollisionResponseToAllChannels_ptr;
            static SetCollisionResponseToAllChannels_method() {
                SetCollisionResponseToAllChannels_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetCollisionResponseToAllChannels");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewResponse) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = NewResponse;
                Main.GetProcessEvent(obj, SetCollisionResponseToAllChannels_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCollisionResponseToChannel_method {
            static internal IntPtr SetCollisionResponseToChannel_ptr;
            static SetCollisionResponseToChannel_method() {
                SetCollisionResponseToChannel_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetCollisionResponseToChannel");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Channel, byte NewResponse) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Channel;
                *(b+1) = NewResponse;
                Main.GetProcessEvent(obj, SetCollisionResponseToChannel_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetConstraintMode_method {
            static internal IntPtr SetConstraintMode_ptr;
            static SetConstraintMode_method() {
                SetConstraintMode_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetConstraintMode");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ConstraintMode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = ConstraintMode;
                Main.GetProcessEvent(obj, SetConstraintMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCullDistance_method {
            static internal IntPtr SetCullDistance_ptr;
            static SetCullDistance_method() {
                SetCullDistance_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetCullDistance");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewCullDistance) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewCullDistance;
                Main.GetProcessEvent(obj, SetCullDistance_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCustomDepthStencilValue_method {
            static internal IntPtr SetCustomDepthStencilValue_ptr;
            static SetCustomDepthStencilValue_method() {
                SetCustomDepthStencilValue_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetCustomDepthStencilValue");
            }

            internal static unsafe void Invoke(IntPtr obj, int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetCustomDepthStencilValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCustomDepthStencilWriteMask_method {
            static internal IntPtr SetCustomDepthStencilWriteMask_ptr;
            static SetCustomDepthStencilWriteMask_method() {
                SetCustomDepthStencilWriteMask_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetCustomDepthStencilWriteMask");
            }

            internal static unsafe void Invoke(IntPtr obj, ERendererStencilMask WriteMaskBit) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)WriteMaskBit;
                Main.GetProcessEvent(obj, SetCustomDepthStencilWriteMask_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEnableGravity_method {
            static internal IntPtr SetEnableGravity_ptr;
            static SetEnableGravity_method() {
                SetEnableGravity_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetEnableGravity");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bGravityEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bGravityEnabled;
                Main.GetProcessEvent(obj, SetEnableGravity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGenerateOverlapEvents_method {
            static internal IntPtr SetGenerateOverlapEvents_ptr;
            static SetGenerateOverlapEvents_method() {
                SetGenerateOverlapEvents_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetGenerateOverlapEvents");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInGenerateOverlapEvents) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInGenerateOverlapEvents;
                Main.GetProcessEvent(obj, SetGenerateOverlapEvents_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearDamping_method {
            static internal IntPtr SetLinearDamping_ptr;
            static SetLinearDamping_method() {
                SetLinearDamping_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetLinearDamping");
            }

            internal static unsafe void Invoke(IntPtr obj, float InDamping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InDamping;
                Main.GetProcessEvent(obj, SetLinearDamping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLockedAxis_method {
            static internal IntPtr SetLockedAxis_ptr;
            static SetLockedAxis_method() {
                SetLockedAxis_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetLockedAxis");
            }

            internal static unsafe void Invoke(IntPtr obj, byte LockedAxis) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = LockedAxis;
                Main.GetProcessEvent(obj, SetLockedAxis_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMassOverrideInKg_method {
            static internal IntPtr SetMassOverrideInKg_ptr;
            static SetMassOverrideInKg_method() {
                SetMassOverrideInKg_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetMassOverrideInKg");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName, float MassInKg, bool bOverrideMass) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((float*)(b+12)) = MassInKg;
                *((bool*)(b+16)) = bOverrideMass;
                Main.GetProcessEvent(obj, SetMassOverrideInKg_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMassScale_method {
            static internal IntPtr SetMassScale_ptr;
            static SetMassScale_method() {
                SetMassScale_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetMassScale");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName, float InMassScale) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((float*)(b+12)) = InMassScale;
                Main.GetProcessEvent(obj, SetMassScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaterial_method {
            static internal IntPtr SetMaterial_ptr;
            static SetMaterial_method() {
                SetMaterial_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, int ElementIndex, MaterialInterface Material) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ElementIndex;
                *((IntPtr*)(b+8)) = Material;
                Main.GetProcessEvent(obj, SetMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaterialByName_method {
            static internal IntPtr SetMaterialByName_ptr;
            static SetMaterialByName_method() {
                SetMaterialByName_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetMaterialByName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name MaterialSlotName, MaterialInterface Material) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = MaterialSlotName;
                *((IntPtr*)(b+16)) = Material;
                Main.GetProcessEvent(obj, SetMaterialByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetNotifyRigidBodyCollision_method {
            static internal IntPtr SetNotifyRigidBodyCollision_ptr;
            static SetNotifyRigidBodyCollision_method() {
                SetNotifyRigidBodyCollision_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetNotifyRigidBodyCollision");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewNotifyRigidBodyCollision) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewNotifyRigidBodyCollision;
                Main.GetProcessEvent(obj, SetNotifyRigidBodyCollision_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOnlyOwnerSee_method {
            static internal IntPtr SetOnlyOwnerSee_ptr;
            static SetOnlyOwnerSee_method() {
                SetOnlyOwnerSee_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetOnlyOwnerSee");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewOnlyOwnerSee) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewOnlyOwnerSee;
                Main.GetProcessEvent(obj, SetOnlyOwnerSee_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOwnerNoSee_method {
            static internal IntPtr SetOwnerNoSee_ptr;
            static SetOwnerNoSee_method() {
                SetOwnerNoSee_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetOwnerNoSee");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewOwnerNoSee) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewOwnerNoSee;
                Main.GetProcessEvent(obj, SetOwnerNoSee_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPhysicsAngularVelocity_method {
            static internal IntPtr SetPhysicsAngularVelocity_ptr;
            static SetPhysicsAngularVelocity_method() {
                SetPhysicsAngularVelocity_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetPhysicsAngularVelocity");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewAngVel, bool bAddToCurrent, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewAngVel;
                *((bool*)(b+12)) = bAddToCurrent;
                *((Name*)(b+16)) = BoneName;
                Main.GetProcessEvent(obj, SetPhysicsAngularVelocity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPhysicsAngularVelocityInDegrees_method {
            static internal IntPtr SetPhysicsAngularVelocityInDegrees_ptr;
            static SetPhysicsAngularVelocityInDegrees_method() {
                SetPhysicsAngularVelocityInDegrees_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetPhysicsAngularVelocityInDegrees");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewAngVel, bool bAddToCurrent, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewAngVel;
                *((bool*)(b+12)) = bAddToCurrent;
                *((Name*)(b+16)) = BoneName;
                Main.GetProcessEvent(obj, SetPhysicsAngularVelocityInDegrees_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPhysicsAngularVelocityInRadians_method {
            static internal IntPtr SetPhysicsAngularVelocityInRadians_ptr;
            static SetPhysicsAngularVelocityInRadians_method() {
                SetPhysicsAngularVelocityInRadians_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetPhysicsAngularVelocityInRadians");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewAngVel, bool bAddToCurrent, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewAngVel;
                *((bool*)(b+12)) = bAddToCurrent;
                *((Name*)(b+16)) = BoneName;
                Main.GetProcessEvent(obj, SetPhysicsAngularVelocityInRadians_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPhysicsLinearVelocity_method {
            static internal IntPtr SetPhysicsLinearVelocity_ptr;
            static SetPhysicsLinearVelocity_method() {
                SetPhysicsLinearVelocity_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetPhysicsLinearVelocity");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewVel, bool bAddToCurrent, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewVel;
                *((bool*)(b+12)) = bAddToCurrent;
                *((Name*)(b+16)) = BoneName;
                Main.GetProcessEvent(obj, SetPhysicsLinearVelocity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPhysicsMaxAngularVelocity_method {
            static internal IntPtr SetPhysicsMaxAngularVelocity_ptr;
            static SetPhysicsMaxAngularVelocity_method() {
                SetPhysicsMaxAngularVelocity_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetPhysicsMaxAngularVelocity");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewMaxAngVel, bool bAddToCurrent, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewMaxAngVel;
                *((bool*)(b+4)) = bAddToCurrent;
                *((Name*)(b+8)) = BoneName;
                Main.GetProcessEvent(obj, SetPhysicsMaxAngularVelocity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPhysicsMaxAngularVelocityInDegrees_method {
            static internal IntPtr SetPhysicsMaxAngularVelocityInDegrees_ptr;
            static SetPhysicsMaxAngularVelocityInDegrees_method() {
                SetPhysicsMaxAngularVelocityInDegrees_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetPhysicsMaxAngularVelocityInDegrees");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewMaxAngVel, bool bAddToCurrent, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewMaxAngVel;
                *((bool*)(b+4)) = bAddToCurrent;
                *((Name*)(b+8)) = BoneName;
                Main.GetProcessEvent(obj, SetPhysicsMaxAngularVelocityInDegrees_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPhysicsMaxAngularVelocityInRadians_method {
            static internal IntPtr SetPhysicsMaxAngularVelocityInRadians_ptr;
            static SetPhysicsMaxAngularVelocityInRadians_method() {
                SetPhysicsMaxAngularVelocityInRadians_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetPhysicsMaxAngularVelocityInRadians");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewMaxAngVel, bool bAddToCurrent, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewMaxAngVel;
                *((bool*)(b+4)) = bAddToCurrent;
                *((Name*)(b+8)) = BoneName;
                Main.GetProcessEvent(obj, SetPhysicsMaxAngularVelocityInRadians_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPhysMaterialOverride_method {
            static internal IntPtr SetPhysMaterialOverride_ptr;
            static SetPhysMaterialOverride_method() {
                SetPhysMaterialOverride_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetPhysMaterialOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, PhysicalMaterial NewPhysMaterial) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewPhysMaterial;
                Main.GetProcessEvent(obj, SetPhysMaterialOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetReceivesDecals_method {
            static internal IntPtr SetReceivesDecals_ptr;
            static SetReceivesDecals_method() {
                SetReceivesDecals_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetReceivesDecals");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewReceivesDecals) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewReceivesDecals;
                Main.GetProcessEvent(obj, SetReceivesDecals_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderCustomDepth_method {
            static internal IntPtr SetRenderCustomDepth_ptr;
            static SetRenderCustomDepth_method() {
                SetRenderCustomDepth_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetRenderCustomDepth");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bValue;
                Main.GetProcessEvent(obj, SetRenderCustomDepth_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderInMainPass_method {
            static internal IntPtr SetRenderInMainPass_ptr;
            static SetRenderInMainPass_method() {
                SetRenderInMainPass_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetRenderInMainPass");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bValue;
                Main.GetProcessEvent(obj, SetRenderInMainPass_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderInMono_method {
            static internal IntPtr SetRenderInMono_ptr;
            static SetRenderInMono_method() {
                SetRenderInMono_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetRenderInMono");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bValue;
                Main.GetProcessEvent(obj, SetRenderInMono_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSimulatePhysics_method {
            static internal IntPtr SetSimulatePhysics_ptr;
            static SetSimulatePhysics_method() {
                SetSimulatePhysics_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetSimulatePhysics");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bSimulate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bSimulate;
                Main.GetProcessEvent(obj, SetSimulatePhysics_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSingleSampleShadowFromStationaryLights_method {
            static internal IntPtr SetSingleSampleShadowFromStationaryLights_ptr;
            static SetSingleSampleShadowFromStationaryLights_method() {
                SetSingleSampleShadowFromStationaryLights_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetSingleSampleShadowFromStationaryLights");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewSingleSampleShadowFromStationaryLights) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewSingleSampleShadowFromStationaryLights;
                Main.GetProcessEvent(obj, SetSingleSampleShadowFromStationaryLights_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTranslucentSortPriority_method {
            static internal IntPtr SetTranslucentSortPriority_ptr;
            static SetTranslucentSortPriority_method() {
                SetTranslucentSortPriority_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetTranslucentSortPriority");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewTranslucentSortPriority) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewTranslucentSortPriority;
                Main.GetProcessEvent(obj, SetTranslucentSortPriority_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUseCCD_method {
            static internal IntPtr SetUseCCD_ptr;
            static SetUseCCD_method() {
                SetUseCCD_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetUseCCD");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InUseCCD, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InUseCCD;
                *((Name*)(b+4)) = BoneName;
                Main.GetProcessEvent(obj, SetUseCCD_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWalkableSlopeOverride_method {
            static internal IntPtr SetWalkableSlopeOverride_ptr;
            static SetWalkableSlopeOverride_method() {
                SetWalkableSlopeOverride_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "SetWalkableSlopeOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, WalkableSlopeOverride NewOverride) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((WalkableSlopeOverride*)(b+0)) = NewOverride;
                Main.GetProcessEvent(obj, SetWalkableSlopeOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct WakeAllRigidBodies_method {
            static internal IntPtr WakeAllRigidBodies_ptr;
            static WakeAllRigidBodies_method() {
                WakeAllRigidBodies_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "WakeAllRigidBodies");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, WakeAllRigidBodies_ptr, new IntPtr(p)); ;
            }
        }
        internal struct WakeRigidBody_method {
            static internal IntPtr WakeRigidBody_ptr;
            static WakeRigidBody_method() {
                WakeRigidBody_ptr = Main.GetMethodUFunction(PrimitiveComponent.StaticClass, "WakeRigidBody");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, WakeRigidBody_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PrimitiveComponent_events {
    }
}
