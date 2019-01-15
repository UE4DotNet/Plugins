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
    [StructLayout( LayoutKind.Explicit, Size=624 )]
    internal unsafe struct SceneComponent_fields {
        [FieldOffset(264)] byte PhysicsVolume; //TODO: weak object TWeakObjectPtr<APhysicsVolume> PhysicsVolume
        [FieldOffset(272)]  public IntPtr  AttachParent;
        [FieldOffset(280)] public Name AttachSocketName;
        [FieldOffset(296)] public NativeArray AttachChildren;
        [FieldOffset(312)] public NativeArray ClientAttachedChildren;
        [FieldOffset(380)] public Vector RelativeLocation;
        [FieldOffset(392)] public Rotator RelativeRotation;
        [FieldOffset(404)] public Vector RelativeScale3D;
        [FieldOffset(464)] public Vector ComponentVelocity;
        [FieldOffset(476)] public bool bComponentToWorldUpdated;
        [FieldOffset(476)] public bool bAbsoluteLocation;
        [FieldOffset(476)] public bool bAbsoluteRotation;
        [FieldOffset(476)] public bool bAbsoluteScale;
        [FieldOffset(476)] public bool bVisible;
        [FieldOffset(476)] public bool bHiddenInGame;
        [FieldOffset(476)] public bool bShouldUpdatePhysicsVolume;
        [FieldOffset(477)] public bool bBoundsChangeTriggersStreamingDataRebuild;
        [FieldOffset(477)] public bool bUseAttachParentBound;
        [FieldOffset(477)] public bool bVisualizeComponent;
        [FieldOffset(478)] public byte Mobility;
        [FieldOffset(479)] public byte DetailMode;
        [FieldOffset(544)] byte PhysicsVolumeChangedDelegate; //TODO: multicast delegate FPhysicsVolumeChanged PhysicsVolumeChangedDelegate
    }
    internal unsafe struct SceneComponent_methods {
        internal struct DetachFromParent_method {
            static internal IntPtr DetachFromParent_ptr;
            static DetachFromParent_method() {
                DetachFromParent_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "DetachFromParent");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bMaintainWorldPosition, bool bCallModify) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bMaintainWorldPosition;
                *((bool*)(b+1)) = bCallModify;
                Main.GetProcessEvent(obj, DetachFromParent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DoesSocketExist_method {
            static internal IntPtr DoesSocketExist_ptr;
            static DoesSocketExist_method() {
                DoesSocketExist_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "DoesSocketExist");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name InSocketName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InSocketName;
                Main.GetProcessEvent(obj, DoesSocketExist_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct GetAllSocketNames_method {
            static internal IntPtr GetAllSocketNames_ptr;
            static GetAllSocketNames_method() {
                GetAllSocketNames_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetAllSocketNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAllSocketNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<Name>(b+0);
            }
        }
        internal struct GetAttachParent_method {
            static internal IntPtr GetAttachParent_ptr;
            static GetAttachParent_method() {
                GetAttachParent_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetAttachParent");
            }

            internal static unsafe SceneComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAttachParent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetAttachSocketName_method {
            static internal IntPtr GetAttachSocketName_ptr;
            static GetAttachSocketName_method() {
                GetAttachSocketName_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetAttachSocketName");
            }

            internal static unsafe Name Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAttachSocketName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+0));
            }
        }
        internal struct GetChildComponent_method {
            static internal IntPtr GetChildComponent_ptr;
            static GetChildComponent_method() {
                GetChildComponent_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetChildComponent");
            }

            internal static unsafe SceneComponent Invoke(IntPtr obj, int ChildIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ChildIndex;
                Main.GetProcessEvent(obj, GetChildComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetChildrenComponents_method {
            static internal IntPtr GetChildrenComponents_ptr;
            static GetChildrenComponents_method() {
                GetChildrenComponents_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetChildrenComponents");
            }

            internal static unsafe IReadOnlyCollection<SceneComponent> Invoke(IntPtr obj, bool bIncludeAllDescendants) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bIncludeAllDescendants;
                Main.GetProcessEvent(obj, GetChildrenComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Children
                return UObject.ToUObjectCollection<SceneComponent>(b+8);
            }
        }
        internal struct GetComponentVelocity_method {
            static internal IntPtr GetComponentVelocity_ptr;
            static GetComponentVelocity_method() {
                GetComponentVelocity_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetComponentVelocity");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetComponentVelocity_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetForwardVector_method {
            static internal IntPtr GetForwardVector_ptr;
            static GetForwardVector_method() {
                GetForwardVector_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetForwardVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetForwardVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetNumChildrenComponents_method {
            static internal IntPtr GetNumChildrenComponents_ptr;
            static GetNumChildrenComponents_method() {
                GetNumChildrenComponents_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetNumChildrenComponents");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumChildrenComponents_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetParentComponents_method {
            static internal IntPtr GetParentComponents_ptr;
            static GetParentComponents_method() {
                GetParentComponents_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetParentComponents");
            }

            internal static unsafe IReadOnlyCollection<SceneComponent> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetParentComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Parents
                return UObject.ToUObjectCollection<SceneComponent>(b+0);
            }
        }
        internal struct GetPhysicsVolume_method {
            static internal IntPtr GetPhysicsVolume_ptr;
            static GetPhysicsVolume_method() {
                GetPhysicsVolume_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetPhysicsVolume");
            }

            internal static unsafe PhysicsVolume Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPhysicsVolume_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetRelativeTransform_method {
            static internal IntPtr GetRelativeTransform_ptr;
            static GetRelativeTransform_method() {
                GetRelativeTransform_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetRelativeTransform");
            }

            internal static unsafe Transform Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetRelativeTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+0));
            }
        }
        internal struct GetRightVector_method {
            static internal IntPtr GetRightVector_ptr;
            static GetRightVector_method() {
                GetRightVector_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetRightVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetRightVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetShouldUpdatePhysicsVolume_method {
            static internal IntPtr GetShouldUpdatePhysicsVolume_ptr;
            static GetShouldUpdatePhysicsVolume_method() {
                GetShouldUpdatePhysicsVolume_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetShouldUpdatePhysicsVolume");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetShouldUpdatePhysicsVolume_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetSocketLocation_method {
            static internal IntPtr GetSocketLocation_ptr;
            static GetSocketLocation_method() {
                GetSocketLocation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetSocketLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Name InSocketName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InSocketName;
                Main.GetProcessEvent(obj, GetSocketLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetSocketQuaternion_method {
            static internal IntPtr GetSocketQuaternion_ptr;
            static GetSocketQuaternion_method() {
                GetSocketQuaternion_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetSocketQuaternion");
            }

            internal static unsafe Quat Invoke(IntPtr obj, Name InSocketName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InSocketName;
                Main.GetProcessEvent(obj, GetSocketQuaternion_ptr, new IntPtr(p)); ;
                return *((Quat*)(b+16));
            }
        }
        internal struct GetSocketRotation_method {
            static internal IntPtr GetSocketRotation_ptr;
            static GetSocketRotation_method() {
                GetSocketRotation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetSocketRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj, Name InSocketName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InSocketName;
                Main.GetProcessEvent(obj, GetSocketRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+12));
            }
        }
        internal struct GetSocketTransform_method {
            static internal IntPtr GetSocketTransform_ptr;
            static GetSocketTransform_method() {
                GetSocketTransform_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetSocketTransform");
            }

            internal static unsafe Transform Invoke(IntPtr obj, Name InSocketName, byte TransformSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InSocketName;
                *(b+12) = TransformSpace;
                Main.GetProcessEvent(obj, GetSocketTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct GetUpVector_method {
            static internal IntPtr GetUpVector_ptr;
            static GetUpVector_method() {
                GetUpVector_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "GetUpVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUpVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct IsAnySimulatingPhysics_method {
            static internal IntPtr IsAnySimulatingPhysics_ptr;
            static IsAnySimulatingPhysics_method() {
                IsAnySimulatingPhysics_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "IsAnySimulatingPhysics");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsAnySimulatingPhysics_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsSimulatingPhysics_method {
            static internal IntPtr IsSimulatingPhysics_ptr;
            static IsSimulatingPhysics_method() {
                IsSimulatingPhysics_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "IsSimulatingPhysics");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, IsSimulatingPhysics_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct IsVisible_method {
            static internal IntPtr IsVisible_ptr;
            static IsVisible_method() {
                IsVisible_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "IsVisible");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsVisible_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_AddLocalOffset_method {
            static internal IntPtr K2_AddLocalOffset_ptr;
            static K2_AddLocalOffset_method() {
                K2_AddLocalOffset_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_AddLocalOffset");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Vector DeltaLocation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = DeltaLocation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddLocalOffset_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_AddLocalRotation_method {
            static internal IntPtr K2_AddLocalRotation_ptr;
            static K2_AddLocalRotation_method() {
                K2_AddLocalRotation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_AddLocalRotation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Rotator DeltaRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = DeltaRotation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddLocalRotation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_AddLocalTransform_method {
            static internal IntPtr K2_AddLocalTransform_ptr;
            static K2_AddLocalTransform_method() {
                K2_AddLocalTransform_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_AddLocalTransform");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Transform DeltaTransform, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = DeltaTransform;
                *((bool*)(b+48)) = bSweep;
                *((bool*)(b+196)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddLocalTransform_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+52));
            }
        }
        internal struct K2_AddRelativeLocation_method {
            static internal IntPtr K2_AddRelativeLocation_ptr;
            static K2_AddRelativeLocation_method() {
                K2_AddRelativeLocation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_AddRelativeLocation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Vector DeltaLocation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = DeltaLocation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddRelativeLocation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_AddRelativeRotation_method {
            static internal IntPtr K2_AddRelativeRotation_ptr;
            static K2_AddRelativeRotation_method() {
                K2_AddRelativeRotation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_AddRelativeRotation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Rotator DeltaRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = DeltaRotation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddRelativeRotation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_AddWorldOffset_method {
            static internal IntPtr K2_AddWorldOffset_ptr;
            static K2_AddWorldOffset_method() {
                K2_AddWorldOffset_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_AddWorldOffset");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Vector DeltaLocation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = DeltaLocation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddWorldOffset_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_AddWorldRotation_method {
            static internal IntPtr K2_AddWorldRotation_ptr;
            static K2_AddWorldRotation_method() {
                K2_AddWorldRotation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_AddWorldRotation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Rotator DeltaRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = DeltaRotation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddWorldRotation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_AddWorldTransform_method {
            static internal IntPtr K2_AddWorldTransform_ptr;
            static K2_AddWorldTransform_method() {
                K2_AddWorldTransform_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_AddWorldTransform");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Transform DeltaTransform, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = DeltaTransform;
                *((bool*)(b+48)) = bSweep;
                *((bool*)(b+196)) = bTeleport;
                Main.GetProcessEvent(obj, K2_AddWorldTransform_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+52));
            }
        }
        internal struct K2_AttachTo_method {
            static internal IntPtr K2_AttachTo_ptr;
            static K2_AttachTo_method() {
                K2_AttachTo_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_AttachTo");
            }

            internal static unsafe bool Invoke(IntPtr obj, SceneComponent InParent, Name InSocketName, byte AttachType, bool bWeldSimulatedBodies) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InParent;
                *((Name*)(b+8)) = InSocketName;
                *(b+20) = AttachType;
                *((bool*)(b+21)) = bWeldSimulatedBodies;
                Main.GetProcessEvent(obj, K2_AttachTo_ptr, new IntPtr(p)); ;
                return *((bool*)(b+22));
            }
        }
        internal struct K2_AttachToComponent_method {
            static internal IntPtr K2_AttachToComponent_ptr;
            static K2_AttachToComponent_method() {
                K2_AttachToComponent_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_AttachToComponent");
            }

            internal static unsafe bool Invoke(IntPtr obj, SceneComponent Parent, Name SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Parent;
                *((Name*)(b+8)) = SocketName;
                *(b+20) = (byte)LocationRule;
                *(b+21) = (byte)RotationRule;
                *(b+22) = (byte)ScaleRule;
                *((bool*)(b+23)) = bWeldSimulatedBodies;
                Main.GetProcessEvent(obj, K2_AttachToComponent_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct K2_DetachFromComponent_method {
            static internal IntPtr K2_DetachFromComponent_ptr;
            static K2_DetachFromComponent_method() {
                K2_DetachFromComponent_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_DetachFromComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, bool bCallModify) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)LocationRule;
                *(b+1) = (byte)RotationRule;
                *(b+2) = (byte)ScaleRule;
                *((bool*)(b+3)) = bCallModify;
                Main.GetProcessEvent(obj, K2_DetachFromComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_GetComponentLocation_method {
            static internal IntPtr K2_GetComponentLocation_ptr;
            static K2_GetComponentLocation_method() {
                K2_GetComponentLocation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_GetComponentLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetComponentLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct K2_GetComponentRotation_method {
            static internal IntPtr K2_GetComponentRotation_ptr;
            static K2_GetComponentRotation_method() {
                K2_GetComponentRotation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_GetComponentRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetComponentRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct K2_GetComponentScale_method {
            static internal IntPtr K2_GetComponentScale_ptr;
            static K2_GetComponentScale_method() {
                K2_GetComponentScale_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_GetComponentScale");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetComponentScale_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct K2_GetComponentToWorld_method {
            static internal IntPtr K2_GetComponentToWorld_ptr;
            static K2_GetComponentToWorld_method() {
                K2_GetComponentToWorld_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_GetComponentToWorld");
            }

            internal static unsafe Transform Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetComponentToWorld_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+0));
            }
        }
        internal struct K2_SetRelativeLocation_method {
            static internal IntPtr K2_SetRelativeLocation_ptr;
            static K2_SetRelativeLocation_method() {
                K2_SetRelativeLocation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_SetRelativeLocation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Vector NewLocation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLocation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetRelativeLocation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_SetRelativeLocationAndRotation_method {
            static internal IntPtr K2_SetRelativeLocationAndRotation_ptr;
            static K2_SetRelativeLocationAndRotation_method() {
                K2_SetRelativeLocationAndRotation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_SetRelativeLocationAndRotation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Vector NewLocation, Rotator NewRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLocation;
                *((Rotator*)(b+12)) = NewRotation;
                *((bool*)(b+24)) = bSweep;
                *((bool*)(b+172)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetRelativeLocationAndRotation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+28));
            }
        }
        internal struct K2_SetRelativeRotation_method {
            static internal IntPtr K2_SetRelativeRotation_ptr;
            static K2_SetRelativeRotation_method() {
                K2_SetRelativeRotation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_SetRelativeRotation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Rotator NewRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = NewRotation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetRelativeRotation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_SetRelativeTransform_method {
            static internal IntPtr K2_SetRelativeTransform_ptr;
            static K2_SetRelativeTransform_method() {
                K2_SetRelativeTransform_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_SetRelativeTransform");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Transform NewTransform, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = NewTransform;
                *((bool*)(b+48)) = bSweep;
                *((bool*)(b+196)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetRelativeTransform_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+52));
            }
        }
        internal struct K2_SetWorldLocation_method {
            static internal IntPtr K2_SetWorldLocation_ptr;
            static K2_SetWorldLocation_method() {
                K2_SetWorldLocation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_SetWorldLocation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Vector NewLocation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLocation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetWorldLocation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_SetWorldLocationAndRotation_method {
            static internal IntPtr K2_SetWorldLocationAndRotation_ptr;
            static K2_SetWorldLocationAndRotation_method() {
                K2_SetWorldLocationAndRotation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_SetWorldLocationAndRotation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Vector NewLocation, Rotator NewRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLocation;
                *((Rotator*)(b+12)) = NewRotation;
                *((bool*)(b+24)) = bSweep;
                *((bool*)(b+172)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetWorldLocationAndRotation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+28));
            }
        }
        internal struct K2_SetWorldRotation_method {
            static internal IntPtr K2_SetWorldRotation_ptr;
            static K2_SetWorldRotation_method() {
                K2_SetWorldRotation_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_SetWorldRotation");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Rotator NewRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = NewRotation;
                *((bool*)(b+12)) = bSweep;
                *((bool*)(b+160)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetWorldRotation_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+16));
            }
        }
        internal struct K2_SetWorldTransform_method {
            static internal IntPtr K2_SetWorldTransform_ptr;
            static K2_SetWorldTransform_method() {
                K2_SetWorldTransform_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "K2_SetWorldTransform");
            }

            internal static unsafe HitResult Invoke(IntPtr obj, Transform NewTransform, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = NewTransform;
                *((bool*)(b+48)) = bSweep;
                *((bool*)(b+196)) = bTeleport;
                Main.GetProcessEvent(obj, K2_SetWorldTransform_ptr, new IntPtr(p)); ;
                return *((HitResult*)(b+52));
            }
        }
        internal struct ResetRelativeTransform_method {
            static internal IntPtr ResetRelativeTransform_ptr;
            static ResetRelativeTransform_method() {
                ResetRelativeTransform_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "ResetRelativeTransform");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetRelativeTransform_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAbsolute_method {
            static internal IntPtr SetAbsolute_ptr;
            static SetAbsolute_method() {
                SetAbsolute_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "SetAbsolute");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewAbsoluteLocation, bool bNewAbsoluteRotation, bool bNewAbsoluteScale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewAbsoluteLocation;
                *((bool*)(b+1)) = bNewAbsoluteRotation;
                *((bool*)(b+2)) = bNewAbsoluteScale;
                Main.GetProcessEvent(obj, SetAbsolute_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHiddenInGame_method {
            static internal IntPtr SetHiddenInGame_ptr;
            static SetHiddenInGame_method() {
                SetHiddenInGame_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "SetHiddenInGame");
            }

            internal static unsafe void Invoke(IntPtr obj, bool NewHidden, bool bPropagateToChildren) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = NewHidden;
                *((bool*)(b+1)) = bPropagateToChildren;
                Main.GetProcessEvent(obj, SetHiddenInGame_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRelativeScale3D_method {
            static internal IntPtr SetRelativeScale3D_ptr;
            static SetRelativeScale3D_method() {
                SetRelativeScale3D_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "SetRelativeScale3D");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewScale3D) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewScale3D;
                Main.GetProcessEvent(obj, SetRelativeScale3D_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetShouldUpdatePhysicsVolume_method {
            static internal IntPtr SetShouldUpdatePhysicsVolume_ptr;
            static SetShouldUpdatePhysicsVolume_method() {
                SetShouldUpdatePhysicsVolume_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "SetShouldUpdatePhysicsVolume");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInShouldUpdatePhysicsVolume) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInShouldUpdatePhysicsVolume;
                Main.GetProcessEvent(obj, SetShouldUpdatePhysicsVolume_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVisibility_method {
            static internal IntPtr SetVisibility_ptr;
            static SetVisibility_method() {
                SetVisibility_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "SetVisibility");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewVisibility, bool bPropagateToChildren) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewVisibility;
                *((bool*)(b+1)) = bPropagateToChildren;
                Main.GetProcessEvent(obj, SetVisibility_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWorldScale3D_method {
            static internal IntPtr SetWorldScale3D_ptr;
            static SetWorldScale3D_method() {
                SetWorldScale3D_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "SetWorldScale3D");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewScale) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewScale;
                Main.GetProcessEvent(obj, SetWorldScale3D_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SnapTo_method {
            static internal IntPtr SnapTo_ptr;
            static SnapTo_method() {
                SnapTo_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "SnapTo");
            }

            internal static unsafe bool Invoke(IntPtr obj, SceneComponent InParent, Name InSocketName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InParent;
                *((Name*)(b+8)) = InSocketName;
                Main.GetProcessEvent(obj, SnapTo_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct ToggleVisibility_method {
            static internal IntPtr ToggleVisibility_ptr;
            static ToggleVisibility_method() {
                ToggleVisibility_ptr = Main.GetMethodUFunction(SceneComponent.StaticClass, "ToggleVisibility");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bPropagateToChildren) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bPropagateToChildren;
                Main.GetProcessEvent(obj, ToggleVisibility_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SceneComponent_events {
    }
}
