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
    [StructLayout( LayoutKind.Explicit, Size=1376 )]
    internal unsafe struct PhysicsConstraintComponent_fields {
        [FieldOffset(624)]  public IntPtr  ConstraintActor1;
        [FieldOffset(632)] public ConstrainComponentPropName ComponentName1;
        [FieldOffset(648)]  public IntPtr  ConstraintActor2;
        [FieldOffset(656)] public ConstrainComponentPropName ComponentName2;
        [FieldOffset(696)] byte OnConstraintBroken; //TODO: multicast delegate FConstraintBrokenSignature OnConstraintBroken
        [FieldOffset(720)] public ConstraintInstance ConstraintInstance;
    }
    internal unsafe struct PhysicsConstraintComponent_methods {
        internal struct BreakConstraint_method {
            static internal IntPtr BreakConstraint_ptr;
            static BreakConstraint_method() {
                BreakConstraint_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "BreakConstraint");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BreakConstraint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetConstraintForce_method {
            static internal IntPtr GetConstraintForce_ptr;
            static GetConstraintForce_method() {
                GetConstraintForce_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "GetConstraintForce");
            }

            internal static unsafe (Vector, Vector) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetConstraintForce_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+0)),*((Vector*)(b+12)));
            }
        }
        internal struct GetCurrentSwing1_method {
            static internal IntPtr GetCurrentSwing1_ptr;
            static GetCurrentSwing1_method() {
                GetCurrentSwing1_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "GetCurrentSwing1");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentSwing1_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetCurrentSwing2_method {
            static internal IntPtr GetCurrentSwing2_ptr;
            static GetCurrentSwing2_method() {
                GetCurrentSwing2_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "GetCurrentSwing2");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentSwing2_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetCurrentTwist_method {
            static internal IntPtr GetCurrentTwist_ptr;
            static GetCurrentTwist_method() {
                GetCurrentTwist_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "GetCurrentTwist");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentTwist_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct IsBroken_method {
            static internal IntPtr IsBroken_ptr;
            static IsBroken_method() {
                IsBroken_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "IsBroken");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsBroken_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetAngularBreakable_method {
            static internal IntPtr SetAngularBreakable_ptr;
            static SetAngularBreakable_method() {
                SetAngularBreakable_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularBreakable");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bAngularBreakable, float AngularBreakThreshold) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bAngularBreakable;
                *((float*)(b+4)) = AngularBreakThreshold;
                Main.GetProcessEvent(obj, SetAngularBreakable_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularDriveMode_method {
            static internal IntPtr SetAngularDriveMode_ptr;
            static SetAngularDriveMode_method() {
                SetAngularDriveMode_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularDriveMode");
            }

            internal static unsafe void Invoke(IntPtr obj, byte DriveMode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = DriveMode;
                Main.GetProcessEvent(obj, SetAngularDriveMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularDriveParams_method {
            static internal IntPtr SetAngularDriveParams_ptr;
            static SetAngularDriveParams_method() {
                SetAngularDriveParams_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularDriveParams");
            }

            internal static unsafe void Invoke(IntPtr obj, float PositionStrength, float VelocityStrength, float InForceLimit) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = PositionStrength;
                *((float*)(b+4)) = VelocityStrength;
                *((float*)(b+8)) = InForceLimit;
                Main.GetProcessEvent(obj, SetAngularDriveParams_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularOrientationDrive_method {
            static internal IntPtr SetAngularOrientationDrive_ptr;
            static SetAngularOrientationDrive_method() {
                SetAngularOrientationDrive_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularOrientationDrive");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableSwingDrive, bool bEnableTwistDrive) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableSwingDrive;
                *((bool*)(b+1)) = bEnableTwistDrive;
                Main.GetProcessEvent(obj, SetAngularOrientationDrive_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularOrientationTarget_method {
            static internal IntPtr SetAngularOrientationTarget_ptr;
            static SetAngularOrientationTarget_method() {
                SetAngularOrientationTarget_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularOrientationTarget");
            }

            internal static unsafe void Invoke(IntPtr obj, Rotator InPosTarget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InPosTarget;
                Main.GetProcessEvent(obj, SetAngularOrientationTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularSwing1Limit_method {
            static internal IntPtr SetAngularSwing1Limit_ptr;
            static SetAngularSwing1Limit_method() {
                SetAngularSwing1Limit_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularSwing1Limit");
            }

            internal static unsafe void Invoke(IntPtr obj, byte MotionType, float Swing1LimitAngle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = MotionType;
                *((float*)(b+4)) = Swing1LimitAngle;
                Main.GetProcessEvent(obj, SetAngularSwing1Limit_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularSwing2Limit_method {
            static internal IntPtr SetAngularSwing2Limit_ptr;
            static SetAngularSwing2Limit_method() {
                SetAngularSwing2Limit_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularSwing2Limit");
            }

            internal static unsafe void Invoke(IntPtr obj, byte MotionType, float Swing2LimitAngle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = MotionType;
                *((float*)(b+4)) = Swing2LimitAngle;
                Main.GetProcessEvent(obj, SetAngularSwing2Limit_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularTwistLimit_method {
            static internal IntPtr SetAngularTwistLimit_ptr;
            static SetAngularTwistLimit_method() {
                SetAngularTwistLimit_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularTwistLimit");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ConstraintType, float TwistLimitAngle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = ConstraintType;
                *((float*)(b+4)) = TwistLimitAngle;
                Main.GetProcessEvent(obj, SetAngularTwistLimit_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularVelocityDrive_method {
            static internal IntPtr SetAngularVelocityDrive_ptr;
            static SetAngularVelocityDrive_method() {
                SetAngularVelocityDrive_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularVelocityDrive");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableSwingDrive, bool bEnableTwistDrive) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableSwingDrive;
                *((bool*)(b+1)) = bEnableTwistDrive;
                Main.GetProcessEvent(obj, SetAngularVelocityDrive_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularVelocityDriveSLERP_method {
            static internal IntPtr SetAngularVelocityDriveSLERP_ptr;
            static SetAngularVelocityDriveSLERP_method() {
                SetAngularVelocityDriveSLERP_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularVelocityDriveSLERP");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableSLERP) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableSLERP;
                Main.GetProcessEvent(obj, SetAngularVelocityDriveSLERP_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularVelocityDriveTwistAndSwing_method {
            static internal IntPtr SetAngularVelocityDriveTwistAndSwing_ptr;
            static SetAngularVelocityDriveTwistAndSwing_method() {
                SetAngularVelocityDriveTwistAndSwing_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularVelocityDriveTwistAndSwing");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableTwistDrive, bool bEnableSwingDrive) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableTwistDrive;
                *((bool*)(b+1)) = bEnableSwingDrive;
                Main.GetProcessEvent(obj, SetAngularVelocityDriveTwistAndSwing_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAngularVelocityTarget_method {
            static internal IntPtr SetAngularVelocityTarget_ptr;
            static SetAngularVelocityTarget_method() {
                SetAngularVelocityTarget_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetAngularVelocityTarget");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector InVelTarget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVelTarget;
                Main.GetProcessEvent(obj, SetAngularVelocityTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetConstrainedComponents_method {
            static internal IntPtr SetConstrainedComponents_ptr;
            static SetConstrainedComponents_method() {
                SetConstrainedComponents_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetConstrainedComponents");
            }

            internal static unsafe void Invoke(IntPtr obj, PrimitiveComponent Component1, Name BoneName1, PrimitiveComponent Component2, Name BoneName2) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component1;
                *((Name*)(b+8)) = BoneName1;
                *((IntPtr*)(b+24)) = Component2;
                *((Name*)(b+32)) = BoneName2;
                Main.GetProcessEvent(obj, SetConstrainedComponents_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetConstraintReferenceFrame_method {
            static internal IntPtr SetConstraintReferenceFrame_ptr;
            static SetConstraintReferenceFrame_method() {
                SetConstraintReferenceFrame_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetConstraintReferenceFrame");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Frame, Transform RefFrame) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Frame;
                *((Transform*)(b+16)) = RefFrame;
                Main.GetProcessEvent(obj, SetConstraintReferenceFrame_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetConstraintReferenceOrientation_method {
            static internal IntPtr SetConstraintReferenceOrientation_ptr;
            static SetConstraintReferenceOrientation_method() {
                SetConstraintReferenceOrientation_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetConstraintReferenceOrientation");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Frame, Vector PriAxis, Vector SecAxis) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Frame;
                *((Vector*)(b+4)) = PriAxis;
                *((Vector*)(b+16)) = SecAxis;
                Main.GetProcessEvent(obj, SetConstraintReferenceOrientation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetConstraintReferencePosition_method {
            static internal IntPtr SetConstraintReferencePosition_ptr;
            static SetConstraintReferencePosition_method() {
                SetConstraintReferencePosition_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetConstraintReferencePosition");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Frame, Vector RefPosition) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Frame;
                *((Vector*)(b+4)) = RefPosition;
                Main.GetProcessEvent(obj, SetConstraintReferencePosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDisableCollision_method {
            static internal IntPtr SetDisableCollision_ptr;
            static SetDisableCollision_method() {
                SetDisableCollision_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetDisableCollision");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bDisableCollision) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bDisableCollision;
                Main.GetProcessEvent(obj, SetDisableCollision_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearBreakable_method {
            static internal IntPtr SetLinearBreakable_ptr;
            static SetLinearBreakable_method() {
                SetLinearBreakable_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetLinearBreakable");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bLinearBreakable, float LinearBreakThreshold) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bLinearBreakable;
                *((float*)(b+4)) = LinearBreakThreshold;
                Main.GetProcessEvent(obj, SetLinearBreakable_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearDriveParams_method {
            static internal IntPtr SetLinearDriveParams_ptr;
            static SetLinearDriveParams_method() {
                SetLinearDriveParams_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetLinearDriveParams");
            }

            internal static unsafe void Invoke(IntPtr obj, float PositionStrength, float VelocityStrength, float InForceLimit) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = PositionStrength;
                *((float*)(b+4)) = VelocityStrength;
                *((float*)(b+8)) = InForceLimit;
                Main.GetProcessEvent(obj, SetLinearDriveParams_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearPositionDrive_method {
            static internal IntPtr SetLinearPositionDrive_ptr;
            static SetLinearPositionDrive_method() {
                SetLinearPositionDrive_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetLinearPositionDrive");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableDriveX;
                *((bool*)(b+1)) = bEnableDriveY;
                *((bool*)(b+2)) = bEnableDriveZ;
                Main.GetProcessEvent(obj, SetLinearPositionDrive_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearPositionTarget_method {
            static internal IntPtr SetLinearPositionTarget_ptr;
            static SetLinearPositionTarget_method() {
                SetLinearPositionTarget_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetLinearPositionTarget");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector InPosTarget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InPosTarget;
                Main.GetProcessEvent(obj, SetLinearPositionTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearVelocityDrive_method {
            static internal IntPtr SetLinearVelocityDrive_ptr;
            static SetLinearVelocityDrive_method() {
                SetLinearVelocityDrive_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetLinearVelocityDrive");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableDriveX;
                *((bool*)(b+1)) = bEnableDriveY;
                *((bool*)(b+2)) = bEnableDriveZ;
                Main.GetProcessEvent(obj, SetLinearVelocityDrive_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearVelocityTarget_method {
            static internal IntPtr SetLinearVelocityTarget_ptr;
            static SetLinearVelocityTarget_method() {
                SetLinearVelocityTarget_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetLinearVelocityTarget");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector InVelTarget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVelTarget;
                Main.GetProcessEvent(obj, SetLinearVelocityTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearXLimit_method {
            static internal IntPtr SetLinearXLimit_ptr;
            static SetLinearXLimit_method() {
                SetLinearXLimit_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetLinearXLimit");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ConstraintType, float LimitSize) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = ConstraintType;
                *((float*)(b+4)) = LimitSize;
                Main.GetProcessEvent(obj, SetLinearXLimit_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearYLimit_method {
            static internal IntPtr SetLinearYLimit_ptr;
            static SetLinearYLimit_method() {
                SetLinearYLimit_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetLinearYLimit");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ConstraintType, float LimitSize) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = ConstraintType;
                *((float*)(b+4)) = LimitSize;
                Main.GetProcessEvent(obj, SetLinearYLimit_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearZLimit_method {
            static internal IntPtr SetLinearZLimit_ptr;
            static SetLinearZLimit_method() {
                SetLinearZLimit_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetLinearZLimit");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ConstraintType, float LimitSize) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = ConstraintType;
                *((float*)(b+4)) = LimitSize;
                Main.GetProcessEvent(obj, SetLinearZLimit_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOrientationDriveSLERP_method {
            static internal IntPtr SetOrientationDriveSLERP_ptr;
            static SetOrientationDriveSLERP_method() {
                SetOrientationDriveSLERP_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetOrientationDriveSLERP");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableSLERP) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableSLERP;
                Main.GetProcessEvent(obj, SetOrientationDriveSLERP_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOrientationDriveTwistAndSwing_method {
            static internal IntPtr SetOrientationDriveTwistAndSwing_ptr;
            static SetOrientationDriveTwistAndSwing_method() {
                SetOrientationDriveTwistAndSwing_ptr = Main.GetMethodUFunction(PhysicsConstraintComponent.StaticClass, "SetOrientationDriveTwistAndSwing");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnableTwistDrive, bool bEnableSwingDrive) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnableTwistDrive;
                *((bool*)(b+1)) = bEnableSwingDrive;
                Main.GetProcessEvent(obj, SetOrientationDriveTwistAndSwing_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PhysicsConstraintComponent_events {
    }
}
