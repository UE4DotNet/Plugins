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
    ///<summary>Performs continuous rotation of a component at a specific rotation rate.</summary>
    ///<remarks>
    ///Rotation can optionally be offset around a pivot point.
    ///Collision testing is not performed during movement.
    ///</remarks>
    public unsafe partial class RotatingMovementComponent : MovementComponent  {
        ///<summary>How fast to update roll/pitch/yaw of the component we update.</summary>
        public unsafe Rotator RotationRate {
            get {return RotatingMovementComponent_ptr->RotationRate;}
            set {RotatingMovementComponent_ptr->RotationRate = value;}
        }
        ///<summary>Translation of pivot point around which we rotate, relative to current rotation.</summary>
        ///<remarks>
        ///For instance, with PivotTranslation set to (X=+100, Y=0, Z=0), rotation will occur
        ///around the point +100 units along the local X axis from the center of the object,
        ///rather than around the object's origin (the default).
        ///</remarks>
        public unsafe Vector PivotTranslation {
            get {return RotatingMovementComponent_ptr->PivotTranslation;}
            set {RotatingMovementComponent_ptr->PivotTranslation = value;}
        }
        public bool bRotationInLocalSpace {
            get {return Main.GetGetBoolPropertyByName(this, "bRotationInLocalSpace"); }
            set {Main.SetGetBoolPropertyByName(this, "bRotationInLocalSpace", value); }
        }
        static RotatingMovementComponent() {
            StaticClass = Main.GetClass("RotatingMovementComponent");
        }
        internal unsafe RotatingMovementComponent_fields* RotatingMovementComponent_ptr => (RotatingMovementComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RotatingMovementComponent(IntPtr p) => UObject.Make<RotatingMovementComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RotatingMovementComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RotatingMovementComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
