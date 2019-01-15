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
    ///<summary>FloatingPawnMovement is a movement component that provides simple movement for any Pawn class.</summary>
    ///<remarks>
    ///Limits on speed and acceleration are provided, while gravity is not implemented.
    ///
    ///Normally the root component of the owning actor is moved, however another component may be selected (see SetUpdatedComponent()).
    ///During swept (non-teleporting) movement only collision of UpdatedComponent is considered, attached components will teleport to the end location ignoring collision.
    ///</remarks>
    public unsafe partial class FloatingPawnMovement : PawnMovementComponent  {
        ///<summary>Maximum velocity magnitude allowed for the controlled Pawn.</summary>
        public unsafe float MaxSpeed {
            get {return FloatingPawnMovement_ptr->MaxSpeed;}
            set {FloatingPawnMovement_ptr->MaxSpeed = value;}
        }
        ///<summary>Acceleration applied by input (rate of change of velocity)</summary>
        public unsafe float Acceleration {
            get {return FloatingPawnMovement_ptr->Acceleration;}
            set {FloatingPawnMovement_ptr->Acceleration = value;}
        }
        ///<summary>Deceleration applied when there is no input (rate of change of velocity)</summary>
        public unsafe float Deceleration {
            get {return FloatingPawnMovement_ptr->Deceleration;}
            set {FloatingPawnMovement_ptr->Deceleration = value;}
        }
        ///<summary>Setting affecting extra force applied when changing direction, making turns have less drift and become more responsive.</summary>
        ///<remarks>
        ///Velocity magnitude is not allowed to increase, that only happens due to normal acceleration. It may decrease with large direction changes.
        ///Larger values apply extra force to reach the target direction more quickly, while a zero value disables any extra turn force.
        ///</remarks>
        public unsafe float TurningBoost {
            get {return FloatingPawnMovement_ptr->TurningBoost;}
            set {FloatingPawnMovement_ptr->TurningBoost = value;}
        }
        public bool bPositionCorrected {
            get {return Main.GetGetBoolPropertyByName(this, "bPositionCorrected"); }
            set {Main.SetGetBoolPropertyByName(this, "bPositionCorrected", value); }
        }
        static FloatingPawnMovement() {
            StaticClass = Main.GetClass("FloatingPawnMovement");
        }
        internal unsafe FloatingPawnMovement_fields* FloatingPawnMovement_ptr => (FloatingPawnMovement_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FloatingPawnMovement(IntPtr p) => UObject.Make<FloatingPawnMovement>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FloatingPawnMovement DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FloatingPawnMovement New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
