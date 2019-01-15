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
    [StructLayout( LayoutKind.Explicit, Size=328 )]
    internal unsafe struct MovementComponent_fields {
        [FieldOffset(256)]  public IntPtr  UpdatedComponent;
        [FieldOffset(264)]  public IntPtr  UpdatedPrimitive;
        [FieldOffset(276)] public Vector Velocity;
        [FieldOffset(288)] public bool bConstrainToPlane;
        [FieldOffset(288)] public bool bSnapToPlaneAtStart;
        [FieldOffset(292)] byte PlaneConstraintAxisSetting; //TODO: enum EPlaneConstraintAxisSetting PlaneConstraintAxisSetting
        [FieldOffset(296)] public Vector PlaneConstraintNormal;
        [FieldOffset(308)] public Vector PlaneConstraintOrigin;
        [FieldOffset(320)] public bool bUpdateOnlyIfRendered;
        [FieldOffset(320)] public bool bAutoUpdateTickRegistration;
        [FieldOffset(320)] public bool bTickBeforeOwner;
        [FieldOffset(320)] public bool bAutoRegisterUpdatedComponent;
    }
    internal unsafe struct MovementComponent_methods {
        internal struct ConstrainDirectionToPlane_method {
            static internal IntPtr ConstrainDirectionToPlane_ptr;
            static ConstrainDirectionToPlane_method() {
                ConstrainDirectionToPlane_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "ConstrainDirectionToPlane");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector Direction) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Direction;
                Main.GetProcessEvent(obj, ConstrainDirectionToPlane_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct ConstrainLocationToPlane_method {
            static internal IntPtr ConstrainLocationToPlane_ptr;
            static ConstrainLocationToPlane_method() {
                ConstrainLocationToPlane_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "ConstrainLocationToPlane");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector Location) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Location;
                Main.GetProcessEvent(obj, ConstrainLocationToPlane_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct ConstrainNormalToPlane_method {
            static internal IntPtr ConstrainNormalToPlane_ptr;
            static ConstrainNormalToPlane_method() {
                ConstrainNormalToPlane_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "ConstrainNormalToPlane");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector Normal) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Normal;
                Main.GetProcessEvent(obj, ConstrainNormalToPlane_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetGravityZ_method {
            static internal IntPtr GetGravityZ_ptr;
            static GetGravityZ_method() {
                GetGravityZ_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "GetGravityZ");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetGravityZ_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMaxSpeed_method {
            static internal IntPtr GetMaxSpeed_ptr;
            static GetMaxSpeed_method() {
                GetMaxSpeed_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "GetMaxSpeed");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMaxSpeed_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPhysicsVolume_method {
            static internal IntPtr GetPhysicsVolume_ptr;
            static GetPhysicsVolume_method() {
                GetPhysicsVolume_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "GetPhysicsVolume");
            }

            internal static unsafe PhysicsVolume Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPhysicsVolume_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetPlaneConstraintAxisSetting_method {
            static internal IntPtr GetPlaneConstraintAxisSetting_ptr;
            static GetPlaneConstraintAxisSetting_method() {
                GetPlaneConstraintAxisSetting_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "GetPlaneConstraintAxisSetting");
            }

            internal static unsafe EPlaneConstraintAxisSetting Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaneConstraintAxisSetting_ptr, new IntPtr(p)); ;
                return *((EPlaneConstraintAxisSetting*)(b+0));
            }
        }
        internal struct GetPlaneConstraintNormal_method {
            static internal IntPtr GetPlaneConstraintNormal_ptr;
            static GetPlaneConstraintNormal_method() {
                GetPlaneConstraintNormal_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "GetPlaneConstraintNormal");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector ReturnValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = ReturnValue;
                Main.GetProcessEvent(obj, GetPlaneConstraintNormal_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetPlaneConstraintOrigin_method {
            static internal IntPtr GetPlaneConstraintOrigin_ptr;
            static GetPlaneConstraintOrigin_method() {
                GetPlaneConstraintOrigin_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "GetPlaneConstraintOrigin");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector ReturnValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = ReturnValue;
                Main.GetProcessEvent(obj, GetPlaneConstraintOrigin_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsExceedingMaxSpeed_method {
            static internal IntPtr IsExceedingMaxSpeed_ptr;
            static IsExceedingMaxSpeed_method() {
                IsExceedingMaxSpeed_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "IsExceedingMaxSpeed");
            }

            internal static unsafe bool Invoke(IntPtr obj, float MaxSpeed) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = MaxSpeed;
                Main.GetProcessEvent(obj, IsExceedingMaxSpeed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct K2_GetMaxSpeedModifier_method {
            static internal IntPtr K2_GetMaxSpeedModifier_ptr;
            static K2_GetMaxSpeedModifier_method() {
                K2_GetMaxSpeedModifier_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "K2_GetMaxSpeedModifier");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetMaxSpeedModifier_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct K2_GetModifiedMaxSpeed_method {
            static internal IntPtr K2_GetModifiedMaxSpeed_ptr;
            static K2_GetModifiedMaxSpeed_method() {
                K2_GetModifiedMaxSpeed_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "K2_GetModifiedMaxSpeed");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetModifiedMaxSpeed_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct K2_MoveUpdatedComponent_method {
            static internal IntPtr K2_MoveUpdatedComponent_ptr;
            static K2_MoveUpdatedComponent_method() {
                K2_MoveUpdatedComponent_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "K2_MoveUpdatedComponent");
            }

            internal static unsafe (HitResult, bool) Invoke(IntPtr obj, Vector Delta, Rotator NewRotation, bool bSweep, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Delta;
                *((Rotator*)(b+12)) = NewRotation;
                *((bool*)(b+168)) = bSweep;
                *((bool*)(b+169)) = bTeleport;
                Main.GetProcessEvent(obj, K2_MoveUpdatedComponent_ptr, new IntPtr(p)); ;
                return (*((HitResult*)(b+24)),*((bool*)(b+170)));
            }
        }
        internal struct SetPlaneConstraintAxisSetting_method {
            static internal IntPtr SetPlaneConstraintAxisSetting_ptr;
            static SetPlaneConstraintAxisSetting_method() {
                SetPlaneConstraintAxisSetting_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "SetPlaneConstraintAxisSetting");
            }

            internal static unsafe void Invoke(IntPtr obj, EPlaneConstraintAxisSetting NewAxisSetting) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)NewAxisSetting;
                Main.GetProcessEvent(obj, SetPlaneConstraintAxisSetting_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaneConstraintEnabled_method {
            static internal IntPtr SetPlaneConstraintEnabled_ptr;
            static SetPlaneConstraintEnabled_method() {
                SetPlaneConstraintEnabled_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "SetPlaneConstraintEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnabled;
                Main.GetProcessEvent(obj, SetPlaneConstraintEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaneConstraintFromVectors_method {
            static internal IntPtr SetPlaneConstraintFromVectors_ptr;
            static SetPlaneConstraintFromVectors_method() {
                SetPlaneConstraintFromVectors_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "SetPlaneConstraintFromVectors");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector Forward, Vector Up) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Forward;
                *((Vector*)(b+12)) = Up;
                Main.GetProcessEvent(obj, SetPlaneConstraintFromVectors_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaneConstraintNormal_method {
            static internal IntPtr SetPlaneConstraintNormal_ptr;
            static SetPlaneConstraintNormal_method() {
                SetPlaneConstraintNormal_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "SetPlaneConstraintNormal");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector PlaneNormal) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = PlaneNormal;
                Main.GetProcessEvent(obj, SetPlaneConstraintNormal_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaneConstraintOrigin_method {
            static internal IntPtr SetPlaneConstraintOrigin_ptr;
            static SetPlaneConstraintOrigin_method() {
                SetPlaneConstraintOrigin_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "SetPlaneConstraintOrigin");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector PlaneOrigin) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = PlaneOrigin;
                Main.GetProcessEvent(obj, SetPlaneConstraintOrigin_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUpdatedComponent_method {
            static internal IntPtr SetUpdatedComponent_ptr;
            static SetUpdatedComponent_method() {
                SetUpdatedComponent_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "SetUpdatedComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, SceneComponent NewUpdatedComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewUpdatedComponent;
                Main.GetProcessEvent(obj, SetUpdatedComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SnapUpdatedComponentToPlane_method {
            static internal IntPtr SnapUpdatedComponentToPlane_ptr;
            static SnapUpdatedComponentToPlane_method() {
                SnapUpdatedComponentToPlane_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "SnapUpdatedComponentToPlane");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SnapUpdatedComponentToPlane_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopMovementImmediately_method {
            static internal IntPtr StopMovementImmediately_ptr;
            static StopMovementImmediately_method() {
                StopMovementImmediately_ptr = Main.GetMethodUFunction(MovementComponent.StaticClass, "StopMovementImmediately");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopMovementImmediately_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MovementComponent_events {
    }
}
