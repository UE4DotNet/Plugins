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
using UE4.DotNetTest.Native;
using UE4.Engine;
using UE4.HeadMountedDisplay;

namespace UE4.DotNetTest {
    ///<summary>Dot Net Test Character</summary>
    public unsafe partial class DotNetTestCharacter : Character  {
        ///<summary>Pawn mesh: 1st person view (arms; seen only by self)</summary>
        public unsafe SkeletalMeshComponent Mesh1P {
            get {return DotNetTestCharacter_ptr->Mesh1P;}
            set {DotNetTestCharacter_ptr->Mesh1P = value;}
        }
        ///<summary>Gun mesh: 1st person view (seen only by self)</summary>
        public unsafe SkeletalMeshComponent FP_Gun {
            get {return DotNetTestCharacter_ptr->FP_Gun;}
            set {DotNetTestCharacter_ptr->FP_Gun = value;}
        }
        ///<summary>Location on gun mesh where projectiles should spawn.</summary>
        public unsafe SceneComponent FP_MuzzleLocation {
            get {return DotNetTestCharacter_ptr->FP_MuzzleLocation;}
            set {DotNetTestCharacter_ptr->FP_MuzzleLocation = value;}
        }
        ///<summary>Gun mesh: VR view (attached to the VR controller directly, no arm, just the actual gun)</summary>
        public unsafe SkeletalMeshComponent VR_Gun {
            get {return DotNetTestCharacter_ptr->VR_Gun;}
            set {DotNetTestCharacter_ptr->VR_Gun = value;}
        }
        ///<summary>Location on VR gun mesh where projectiles should spawn.</summary>
        public unsafe SceneComponent VR_MuzzleLocation {
            get {return DotNetTestCharacter_ptr->VR_MuzzleLocation;}
            set {DotNetTestCharacter_ptr->VR_MuzzleLocation = value;}
        }
        ///<summary>First person camera</summary>
        public unsafe CameraComponent FirstPersonCameraComponent {
            get {return DotNetTestCharacter_ptr->FirstPersonCameraComponent;}
        }
        ///<summary>Motion controller (right hand)</summary>
        public unsafe MotionControllerComponent R_MotionController {
            get {return DotNetTestCharacter_ptr->R_MotionController;}
        }
        ///<summary>Motion controller (left hand)</summary>
        public unsafe MotionControllerComponent L_MotionController {
            get {return DotNetTestCharacter_ptr->L_MotionController;}
        }
        ///<summary>Base turn rate, in deg/sec. Other scaling may affect final turn rate.</summary>
        public unsafe float BaseTurnRate {
            get {return DotNetTestCharacter_ptr->BaseTurnRate;}
        }
        ///<summary>Base look up/down rate, in deg/sec. Other scaling may affect final rate.</summary>
        public unsafe float BaseLookUpRate {
            get {return DotNetTestCharacter_ptr->BaseLookUpRate;}
        }
         //TODO: struct FVector GunOffset
        ///<summary>Projectile class to spawn</summary>
        public unsafe SubclassOf<DotNetTestProjectile> ProjectileClass {
            get {return DotNetTestCharacter_ptr->ProjectileClass;}
            set {DotNetTestCharacter_ptr->ProjectileClass = value;}
        }
        ///<summary>Sound to play each time we fire</summary>
        public unsafe SoundBase FireSound {
            get {return DotNetTestCharacter_ptr->FireSound;}
            set {DotNetTestCharacter_ptr->FireSound = value;}
        }
        ///<summary>AnimMontage to play each time we fire</summary>
        public unsafe AnimMontage FireAnimation {
            get {return DotNetTestCharacter_ptr->FireAnimation;}
            set {DotNetTestCharacter_ptr->FireAnimation = value;}
        }
        ///<summary>Whether to use motion controller location for aiming.</summary>
        public unsafe bool bUsingMotionControllers {
            get {return DotNetTestCharacter_ptr->bUsingMotionControllers;}
            set {DotNetTestCharacter_ptr->bUsingMotionControllers = value;}
        }
        static DotNetTestCharacter() {
            StaticClass = Main.GetClass("DotNetTestCharacter");
        }
        internal unsafe DotNetTestCharacter_fields* DotNetTestCharacter_ptr => (DotNetTestCharacter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DotNetTestCharacter(IntPtr p) => UObject.Make<DotNetTestCharacter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DotNetTestCharacter DefaultObject => Main.GetDefaultObject(StaticClass);
    }
}
