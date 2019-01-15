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
    ///<summary>PhysicsVolume: A bounding volume which affects actor physics.</summary>
    ///<remarks>Each AActor is affected at any time by one PhysicsVolume.</remarks>
    public unsafe partial class PhysicsVolume : Volume  {
        ///<summary>Terminal velocity of pawns using CharacterMovement when falling.</summary>
        public unsafe float TerminalVelocity {
            get {return PhysicsVolume_ptr->TerminalVelocity;}
            set {PhysicsVolume_ptr->TerminalVelocity = value;}
        }
        ///<summary>Determines which PhysicsVolume takes precedence if they overlap (higher number = higher priority).</summary>
        public unsafe int Priority {
            get {return PhysicsVolume_ptr->Priority;}
            set {PhysicsVolume_ptr->Priority = value;}
        }
        ///<summary>This property controls the amount of friction applied by the volume as pawns using CharacterMovement move through it. The higher this value, the harder it will feel to move through</summary>
        public unsafe float FluidFriction {
            get {return PhysicsVolume_ptr->FluidFriction;}
            set {PhysicsVolume_ptr->FluidFriction = value;}
        }
        public bool bWaterVolume {
            get {return Main.GetGetBoolPropertyByName(this, "bWaterVolume"); }
            set {Main.SetGetBoolPropertyByName(this, "bWaterVolume", value); }
        }
        public bool bPhysicsOnContact {
            get {return Main.GetGetBoolPropertyByName(this, "bPhysicsOnContact"); }
            set {Main.SetGetBoolPropertyByName(this, "bPhysicsOnContact", value); }
        }
        static PhysicsVolume() {
            StaticClass = Main.GetClass("PhysicsVolume");
        }
        internal unsafe PhysicsVolume_fields* PhysicsVolume_ptr => (PhysicsVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsVolume(IntPtr p) => UObject.Make<PhysicsVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
