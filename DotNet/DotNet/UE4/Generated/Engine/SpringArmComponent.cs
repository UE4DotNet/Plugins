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
    ///<summary>
    ///This component tries to maintain its children at a fixed distance from the parent,
    ///but will retract the children if there is a collision, and spring back when there is no collision.
    ///</summary>
    ///<remarks>Example: Use as a 'camera boom' to keep the follow camera for a player from colliding into the world.</remarks>
    public unsafe partial class SpringArmComponent : SceneComponent  {

        ///<summary>Get the target rotation we inherit, used as the base target for the boom rotation.</summary>
        ///<remarks>This is derived from attachment to our parent and considering the UsePawnControlRotation and absolute rotation flags.</remarks>
        public Rotator GetTargetRotation()  => 
            SpringArmComponent_methods.GetTargetRotation_method.Invoke(ObjPointer);

        ///<summary>Get the position where the camera should be without applying the Collision Test displacement</summary>
        public Vector GetUnfixedCameraPosition()  => 
            SpringArmComponent_methods.GetUnfixedCameraPosition_method.Invoke(ObjPointer);

        ///<summary>Is the Collision Test displacement being applied?</summary>
        public bool IsCollisionFixApplied()  => 
            SpringArmComponent_methods.IsCollisionFixApplied_method.Invoke(ObjPointer);
        ///<summary>Natural length of the spring arm when there are no collisions</summary>
        public unsafe float TargetArmLength {
            get {return SpringArmComponent_ptr->TargetArmLength;}
            set {SpringArmComponent_ptr->TargetArmLength = value;}
        }
        ///<summary>offset at end of spring arm; use this instead of the relative offset of the attached component to ensure the line trace works as desired</summary>
        public unsafe Vector SocketOffset {
            get {return SpringArmComponent_ptr->SocketOffset;}
            set {SpringArmComponent_ptr->SocketOffset = value;}
        }
        ///<summary>Offset at start of spring, applied in world space. Use this if you want a world-space offset from the parent component instead of the usual relative-space offset.</summary>
        public unsafe Vector TargetOffset {
            get {return SpringArmComponent_ptr->TargetOffset;}
            set {SpringArmComponent_ptr->TargetOffset = value;}
        }
        ///<summary>How big should the query probe sphere be (in unreal units)</summary>
        public unsafe float ProbeSize {
            get {return SpringArmComponent_ptr->ProbeSize;}
            set {SpringArmComponent_ptr->ProbeSize = value;}
        }
        ///<summary>Collision channel of the query probe (defaults to ECC_Camera)</summary>
        public unsafe byte ProbeChannel {
            get {return SpringArmComponent_ptr->ProbeChannel;}
            set {SpringArmComponent_ptr->ProbeChannel = value;}
        }
        public bool bDoCollisionTest {
            get {return Main.GetGetBoolPropertyByName(this, "bDoCollisionTest"); }
            set {Main.SetGetBoolPropertyByName(this, "bDoCollisionTest", value); }
        }
        public bool bUsePawnControlRotation {
            get {return Main.GetGetBoolPropertyByName(this, "bUsePawnControlRotation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsePawnControlRotation", value); }
        }
        public bool bInheritPitch {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritPitch"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritPitch", value); }
        }
        public bool bInheritYaw {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritYaw"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritYaw", value); }
        }
        public bool bInheritRoll {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritRoll"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritRoll", value); }
        }
        public bool bEnableCameraLag {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableCameraLag"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableCameraLag", value); }
        }
        public bool bEnableCameraRotationLag {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableCameraRotationLag"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableCameraRotationLag", value); }
        }
        public bool bUseCameraLagSubstepping {
            get {return Main.GetGetBoolPropertyByName(this, "bUseCameraLagSubstepping"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseCameraLagSubstepping", value); }
        }
        public bool bDrawDebugLagMarkers {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawDebugLagMarkers"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawDebugLagMarkers", value); }
        }
        ///<summary>If bEnableCameraLag is true, controls how quickly camera reaches target position. Low values are slower (more lag), high values are faster (less lag), while zero is instant (no lag).</summary>
        public unsafe float CameraLagSpeed {
            get {return SpringArmComponent_ptr->CameraLagSpeed;}
            set {SpringArmComponent_ptr->CameraLagSpeed = value;}
        }
        ///<summary>If bEnableCameraRotationLag is true, controls how quickly camera reaches target position. Low values are slower (more lag), high values are faster (less lag), while zero is instant (no lag).</summary>
        public unsafe float CameraRotationLagSpeed {
            get {return SpringArmComponent_ptr->CameraRotationLagSpeed;}
            set {SpringArmComponent_ptr->CameraRotationLagSpeed = value;}
        }
        ///<summary>Max time step used when sub-stepping camera lag.</summary>
        public unsafe float CameraLagMaxTimeStep {
            get {return SpringArmComponent_ptr->CameraLagMaxTimeStep;}
            set {SpringArmComponent_ptr->CameraLagMaxTimeStep = value;}
        }
        ///<summary>Max distance the camera target may lag behind the current location. If set to zero, no max distance is enforced.</summary>
        public unsafe float CameraLagMaxDistance {
            get {return SpringArmComponent_ptr->CameraLagMaxDistance;}
            set {SpringArmComponent_ptr->CameraLagMaxDistance = value;}
        }
        static SpringArmComponent() {
            StaticClass = Main.GetClass("SpringArmComponent");
        }
        internal unsafe SpringArmComponent_fields* SpringArmComponent_ptr => (SpringArmComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SpringArmComponent(IntPtr p) => UObject.Make<SpringArmComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SpringArmComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SpringArmComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
