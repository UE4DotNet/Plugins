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
    ///<summary>This is effectively a joint that allows you to connect 2 rigid bodies together. You can create different types of joints using the various parameters of this component.</summary>
    public unsafe partial class PhysicsConstraintComponent : SceneComponent  {

        ///<summary>Break this constraint</summary>
        public void BreakConstraint()  => 
            PhysicsConstraintComponent_methods.BreakConstraint_method.Invoke(ObjPointer);

        ///<summary>Retrieve the constraint force most recently applied to maintain this constraint. Returns 0 forces if the constraint is not initialized or broken.</summary>
        public (Vector, Vector) GetConstraintForce()  => 
            PhysicsConstraintComponent_methods.GetConstraintForce_method.Invoke(ObjPointer);

        ///<summary>Gets the current Swing1 of the constraint</summary>
        public float GetCurrentSwing1()  => 
            PhysicsConstraintComponent_methods.GetCurrentSwing1_method.Invoke(ObjPointer);

        ///<summary>Gets the current Swing2 of the constraint</summary>
        public float GetCurrentSwing2()  => 
            PhysicsConstraintComponent_methods.GetCurrentSwing2_method.Invoke(ObjPointer);

        ///<summary>Gets the current Angular Twist of the constraint</summary>
        public float GetCurrentTwist()  => 
            PhysicsConstraintComponent_methods.GetCurrentTwist_method.Invoke(ObjPointer);

        ///<summary>Retrieve the status of constraint being broken.</summary>
        public bool IsBroken()  => 
            PhysicsConstraintComponent_methods.IsBroken_method.Invoke(ObjPointer);

        ///<summary>
        ///Sets the Angular Breakable properties
        ///     @
        ///</summary>
        ///<remarks>
        ///param bAngularBreakable                Whether it is possible to break the joint with angular force
        ///     @param AngularBreakThreshold    Torque needed to break the joint
        ///</remarks>
        public void SetAngularBreakable(bool bAngularBreakable, float AngularBreakThreshold)  => 
            PhysicsConstraintComponent_methods.SetAngularBreakable_method.Invoke(ObjPointer, bAngularBreakable, AngularBreakThreshold);

        ///<summary>
        ///Switches the angular drive mode between SLERP and Twist And Swing
        ///     @
        ///</summary>
        ///<remarks>param DriveMode        The angular drive mode to use. SLERP uses shortest spherical path, but will not work if any angular constraints are locked. Twist and Swing decomposes the path into the different angular degrees of freedom but may experience gimbal lock</remarks>
        public void SetAngularDriveMode(byte DriveMode)  => 
            PhysicsConstraintComponent_methods.SetAngularDriveMode_method.Invoke(ObjPointer, DriveMode);

        ///<summary>Sets the drive params for the angular drive.</summary>
        ///<remarks>
        ///@param PositionStrength         Positional strength for the drive (stiffness)
        ///    @param VelocityStrength         Velocity strength of the drive (damping)
        ///    @param InForceLimit     Max force applied by the drive
        ///</remarks>
        public void SetAngularDriveParams(float PositionStrength, float VelocityStrength, float InForceLimit)  => 
            PhysicsConstraintComponent_methods.SetAngularDriveParams_method.Invoke(ObjPointer, PositionStrength, VelocityStrength, InForceLimit);

        ///<summary>Enables/Disables angular orientation drive.</summary>
        ///<remarks>
        ///Only relevant if the AngularDriveMode is set to Twist and Swing
        ///
        ///    @param bEnableSwingDrive        Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
        ///    @param bEnableTwistDrive        Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
        ///</remarks>
        public void SetAngularOrientationDrive(bool bEnableSwingDrive, bool bEnableTwistDrive)  => 
            PhysicsConstraintComponent_methods.SetAngularOrientationDrive_method.Invoke(ObjPointer, bEnableSwingDrive, bEnableTwistDrive);

        ///<summary>Sets the target orientation for the angular drive.</summary>
        ///<remarks>
        ///@param InPosTarget              Target orientation
        ///</remarks>
        public void SetAngularOrientationTarget(Rotator InPosTarget)  => 
            PhysicsConstraintComponent_methods.SetAngularOrientationTarget_method.Invoke(ObjPointer, InPosTarget);

        ///<summary>
        ///Sets the Angular Swing1 Motion Type
        ///     @
        ///</summary>
        ///<remarks>
        ///param ConstraintType   New Constraint Type
        ///     @param Swing1LimitAngle Size of limit in degrees
        ///</remarks>
        public void SetAngularSwing1Limit(byte MotionType, float Swing1LimitAngle)  => 
            PhysicsConstraintComponent_methods.SetAngularSwing1Limit_method.Invoke(ObjPointer, MotionType, Swing1LimitAngle);

        ///<summary>
        ///Sets the Angular Swing2 Motion Type
        ///     @
        ///</summary>
        ///<remarks>
        ///param ConstraintType   New Constraint Type
        ///     @param Swing2LimitAngle Size of limit in degrees
        ///</remarks>
        public void SetAngularSwing2Limit(byte MotionType, float Swing2LimitAngle)  => 
            PhysicsConstraintComponent_methods.SetAngularSwing2Limit_method.Invoke(ObjPointer, MotionType, Swing2LimitAngle);

        ///<summary>
        ///Sets the Angular Twist Motion Type
        ///     @
        ///</summary>
        ///<remarks>
        ///param ConstraintType   New Constraint Type
        ///     @param TwistLimitAngle  Size of limit in degrees
        ///</remarks>
        public void SetAngularTwistLimit(byte ConstraintType, float TwistLimitAngle)  => 
            PhysicsConstraintComponent_methods.SetAngularTwistLimit_method.Invoke(ObjPointer, ConstraintType, TwistLimitAngle);

        ///<summary>Set Angular Velocity Drive</summary>
        public void SetAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive)  => 
            PhysicsConstraintComponent_methods.SetAngularVelocityDrive_method.Invoke(ObjPointer, bEnableSwingDrive, bEnableTwistDrive);

        ///<summary>Enables/Disables the angular velocity slerp drive.</summary>
        ///<remarks>
        ///Only relevant if the AngularDriveMode is set to SLERP
        ///
        ///     @param bEnableSLERP             Indicates whether the SLERP drive should be enabled. Only relevant if the AngularDriveMode is set to SLERP
        ///</remarks>
        public void SetAngularVelocityDriveSLERP(bool bEnableSLERP)  => 
            PhysicsConstraintComponent_methods.SetAngularVelocityDriveSLERP_method.Invoke(ObjPointer, bEnableSLERP);

        ///<summary>Enables/Disables angular velocity twist and swing drive.</summary>
        ///<remarks>
        ///Only relevant if the AngularDriveMode is set to Twist and Swing
        ///
        ///     @param bEnableSwingDrive        Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
        ///     @param bEnableTwistDrive        Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
        ///</remarks>
        public void SetAngularVelocityDriveTwistAndSwing(bool bEnableTwistDrive, bool bEnableSwingDrive)  => 
            PhysicsConstraintComponent_methods.SetAngularVelocityDriveTwistAndSwing_method.Invoke(ObjPointer, bEnableTwistDrive, bEnableSwingDrive);

        ///<summary>Sets the target velocity for the angular drive.</summary>
        ///<remarks>
        ///@param InVelTarget              Target velocity
        ///</remarks>
        public void SetAngularVelocityTarget(Vector InVelTarget)  => 
            PhysicsConstraintComponent_methods.SetAngularVelocityTarget_method.Invoke(ObjPointer, InVelTarget);

        ///<summary>Directly specify component to connect. Will update frames based on current position.</summary>
        public void SetConstrainedComponents(PrimitiveComponent Component1, Name BoneName1, PrimitiveComponent Component2, Name BoneName2)  => 
            PhysicsConstraintComponent_methods.SetConstrainedComponents_method.Invoke(ObjPointer, Component1, BoneName1, Component2, BoneName2);

        ///<summary>Pass in reference frame in. If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
        public void SetConstraintReferenceFrame(byte Frame, Transform RefFrame)  => 
            PhysicsConstraintComponent_methods.SetConstraintReferenceFrame_method.Invoke(ObjPointer, Frame, RefFrame);

        ///<summary>Pass in reference orientation in (maintains reference position). If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
        public void SetConstraintReferenceOrientation(byte Frame, Vector PriAxis, Vector SecAxis)  => 
            PhysicsConstraintComponent_methods.SetConstraintReferenceOrientation_method.Invoke(ObjPointer, Frame, PriAxis, SecAxis);

        ///<summary>Pass in reference position in (maintains reference orientation). If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
        public void SetConstraintReferencePosition(byte Frame, Vector RefPosition)  => 
            PhysicsConstraintComponent_methods.SetConstraintReferencePosition_method.Invoke(ObjPointer, Frame, RefPosition);

        ///<summary>If true, the collision between the two rigid bodies of the constraint will be disabled.</summary>
        public void SetDisableCollision(bool bDisableCollision)  => 
            PhysicsConstraintComponent_methods.SetDisableCollision_method.Invoke(ObjPointer, bDisableCollision);

        ///<summary>
        ///Sets the Linear Breakable properties
        ///     @
        ///</summary>
        ///<remarks>
        ///param bLinearBreakable         Whether it is possible to break the joint with linear force
        ///     @param LinearBreakThreshold     Force needed to break the joint
        ///</remarks>
        public void SetLinearBreakable(bool bLinearBreakable, float LinearBreakThreshold)  => 
            PhysicsConstraintComponent_methods.SetLinearBreakable_method.Invoke(ObjPointer, bLinearBreakable, LinearBreakThreshold);

        ///<summary>Sets the drive params for the linear drive.</summary>
        ///<remarks>
        ///@param PositionStrength         Positional strength for the drive (stiffness)
        ///    @param VelocityStrength         Velocity strength of the drive (damping)
        ///    @param InForceLimit     Max force applied by the drive
        ///</remarks>
        public void SetLinearDriveParams(float PositionStrength, float VelocityStrength, float InForceLimit)  => 
            PhysicsConstraintComponent_methods.SetLinearDriveParams_method.Invoke(ObjPointer, PositionStrength, VelocityStrength, InForceLimit);

        ///<summary>
        ///Enables/Disables linear position drive
        ///    @
        ///</summary>
        ///<remarks>
        ///param bEnableDriveX    Indicates whether the drive for the X-Axis should be enabled
        ///    @param bEnableDriveY    Indicates whether the drive for the Y-Axis should be enabled
        ///    @param bEnableDriveZ    Indicates whether the drive for the Z-Axis should be enabled
        ///</remarks>
        public void SetLinearPositionDrive(bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)  => 
            PhysicsConstraintComponent_methods.SetLinearPositionDrive_method.Invoke(ObjPointer, bEnableDriveX, bEnableDriveY, bEnableDriveZ);

        ///<summary>Sets the target position for the linear drive.</summary>
        ///<remarks>
        ///@param InPosTarget              Target position
        ///</remarks>
        public void SetLinearPositionTarget(Vector InPosTarget)  => 
            PhysicsConstraintComponent_methods.SetLinearPositionTarget_method.Invoke(ObjPointer, InPosTarget);

        ///<summary>
        ///Enables/Disables linear position drive
        ///    @
        ///</summary>
        ///<remarks>
        ///param bEnableDriveX    Indicates whether the drive for the X-Axis should be enabled
        ///    @param bEnableDriveY    Indicates whether the drive for the Y-Axis should be enabled
        ///    @param bEnableDriveZ    Indicates whether the drive for the Z-Axis should be enabled
        ///</remarks>
        public void SetLinearVelocityDrive(bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)  => 
            PhysicsConstraintComponent_methods.SetLinearVelocityDrive_method.Invoke(ObjPointer, bEnableDriveX, bEnableDriveY, bEnableDriveZ);

        ///<summary>Sets the target velocity for the linear drive.</summary>
        ///<remarks>
        ///@param InVelTarget              Target velocity
        ///</remarks>
        public void SetLinearVelocityTarget(Vector InVelTarget)  => 
            PhysicsConstraintComponent_methods.SetLinearVelocityTarget_method.Invoke(ObjPointer, InVelTarget);

        ///<summary>
        ///Sets the LinearX Motion Type
        ///     @
        ///</summary>
        ///<remarks>
        ///param ConstraintType   New Constraint Type
        ///     @param LimitSize                Size of limit
        ///</remarks>
        public void SetLinearXLimit(byte ConstraintType, float LimitSize)  => 
            PhysicsConstraintComponent_methods.SetLinearXLimit_method.Invoke(ObjPointer, ConstraintType, LimitSize);

        ///<summary>
        ///Sets the LinearY Motion Type
        ///     @
        ///</summary>
        ///<remarks>
        ///param ConstraintType   New Constraint Type
        ///     @param LimitSize                Size of limit
        ///</remarks>
        public void SetLinearYLimit(byte ConstraintType, float LimitSize)  => 
            PhysicsConstraintComponent_methods.SetLinearYLimit_method.Invoke(ObjPointer, ConstraintType, LimitSize);

        ///<summary>
        ///Sets the LinearZ Motion Type
        ///     @
        ///</summary>
        ///<remarks>
        ///param ConstraintType   New Constraint Type
        ///     @param LimitSize                Size of limit
        ///</remarks>
        public void SetLinearZLimit(byte ConstraintType, float LimitSize)  => 
            PhysicsConstraintComponent_methods.SetLinearZLimit_method.Invoke(ObjPointer, ConstraintType, LimitSize);

        ///<summary>Enables/Disables the angular orientation slerp drive.</summary>
        ///<remarks>
        ///Only relevant if the AngularDriveMode is set to SLERP
        ///
        ///     @param bEnableSLERP             Indicates whether the SLERP drive should be enabled. Only relevant if the AngularDriveMode is set to SLERP
        ///</remarks>
        public void SetOrientationDriveSLERP(bool bEnableSLERP)  => 
            PhysicsConstraintComponent_methods.SetOrientationDriveSLERP_method.Invoke(ObjPointer, bEnableSLERP);

        ///<summary>Enables/Disables angular orientation drive.</summary>
        ///<remarks>
        ///Only relevant if the AngularDriveMode is set to Twist and Swing
        ///
        ///     @param bEnableSwingDrive        Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
        ///     @param bEnableTwistDrive        Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
        ///</remarks>
        public void SetOrientationDriveTwistAndSwing(bool bEnableTwistDrive, bool bEnableSwingDrive)  => 
            PhysicsConstraintComponent_methods.SetOrientationDriveTwistAndSwing_method.Invoke(ObjPointer, bEnableTwistDrive, bEnableSwingDrive);
        ///<summary>Pointer to first Actor to constrain.</summary>
        public unsafe Actor ConstraintActor1 {
            get {return PhysicsConstraintComponent_ptr->ConstraintActor1;}
            set {PhysicsConstraintComponent_ptr->ConstraintActor1 = value;}
        }
        ///<summary>Name of first component property to constrain.</summary>
        ///<remarks>
        ///If Actor1 is NULL, will look within Owner.
        ///If this is NULL, will use RootComponent of Actor1
        ///</remarks>
        public unsafe ConstrainComponentPropName ComponentName1 {
            get {return PhysicsConstraintComponent_ptr->ComponentName1;}
            set {PhysicsConstraintComponent_ptr->ComponentName1 = value;}
        }
        ///<summary>Pointer to second Actor to constrain.</summary>
        public unsafe Actor ConstraintActor2 {
            get {return PhysicsConstraintComponent_ptr->ConstraintActor2;}
            set {PhysicsConstraintComponent_ptr->ConstraintActor2 = value;}
        }
        ///<summary>Name of second component property to constrain.</summary>
        ///<remarks>
        ///If Actor2 is NULL, will look within Owner.
        ///If this is NULL, will use RootComponent of Actor2
        ///</remarks>
        public unsafe ConstrainComponentPropName ComponentName2 {
            get {return PhysicsConstraintComponent_ptr->ComponentName2;}
            set {PhysicsConstraintComponent_ptr->ComponentName2 = value;}
        }
         //TODO: multicast delegate FConstraintBrokenSignature OnConstraintBroken
        ///<summary>All constraint settings</summary>
        public unsafe ConstraintInstance ConstraintInstance {
            get {return PhysicsConstraintComponent_ptr->ConstraintInstance;}
            set {PhysicsConstraintComponent_ptr->ConstraintInstance = value;}
        }
        static PhysicsConstraintComponent() {
            StaticClass = Main.GetClass("PhysicsConstraintComponent");
        }
        internal unsafe PhysicsConstraintComponent_fields* PhysicsConstraintComponent_ptr => (PhysicsConstraintComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsConstraintComponent(IntPtr p) => UObject.Make<PhysicsConstraintComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsConstraintComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsConstraintComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
