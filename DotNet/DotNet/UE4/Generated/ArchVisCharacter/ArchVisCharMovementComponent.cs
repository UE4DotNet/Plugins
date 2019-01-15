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
using UE4.ArchVisCharacter.Native;
using UE4.Engine;

namespace UE4.ArchVisCharacter {
    ///<summary>Arch Vis Char Movement Component</summary>
    public unsafe partial class ArchVisCharMovementComponent : CharacterMovementComponent  {
        ///<summary>Controls how fast the character's turn rate accelerates when rotating and looking up/down</summary>
        public unsafe Rotator RotationalAcceleration {
            get {return ArchVisCharMovementComponent_ptr->RotationalAcceleration;}
        }
        ///<summary>Controls how fast the character's turn rate decelerates to 0 when user stops turning</summary>
        public unsafe Rotator RotationalDeceleration {
            get {return ArchVisCharMovementComponent_ptr->RotationalDeceleration;}
        }
        ///<summary>Fastest possible turn rate</summary>
        public unsafe Rotator MaxRotationalVelocity {
            get {return ArchVisCharMovementComponent_ptr->MaxRotationalVelocity;}
        }
        ///<summary>Controls how far down you can look</summary>
        public unsafe float MinPitch {
            get {return ArchVisCharMovementComponent_ptr->MinPitch;}
        }
        ///<summary>Controls how far up you can look</summary>
        public unsafe float MaxPitch {
            get {return ArchVisCharMovementComponent_ptr->MaxPitch;}
        }
        ///<summary>Controls walking deceleration.</summary>
        public unsafe float WalkingFriction {
            get {return ArchVisCharMovementComponent_ptr->WalkingFriction;}
        }
        ///<summary>How fast the character can walk.</summary>
        public unsafe float WalkingSpeed {
            get {return ArchVisCharMovementComponent_ptr->WalkingSpeed;}
        }
        ///<summary>How fast the character accelerates.</summary>
        public unsafe float WalkingAcceleration {
            get {return ArchVisCharMovementComponent_ptr->WalkingAcceleration;}
        }
        static ArchVisCharMovementComponent() {
            StaticClass = Main.GetClass("ArchVisCharMovementComponent");
        }
        internal unsafe ArchVisCharMovementComponent_fields* ArchVisCharMovementComponent_ptr => (ArchVisCharMovementComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ArchVisCharMovementComponent(IntPtr p) => UObject.Make<ArchVisCharMovementComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ArchVisCharMovementComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ArchVisCharMovementComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
