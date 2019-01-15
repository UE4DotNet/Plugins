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
    ///<summary>DefaultPawn implements a simple Pawn with spherical collision and built-in flying movement.</summary>
    ///<remarks>
    ///@see UFloatingPawnMovement
    ///</remarks>
    public unsafe partial class DefaultPawn : Pawn  {

        ///<summary>Called via input to look up at a given rate (or down if Rate is negative).</summary>
        ///<remarks>
        ///@param Rate   This is a normalized rate, i.e. 1.0 means 100% of desired turn rate
        ///</remarks>
        public void LookUpAtRate(float Rate)  => 
            DefaultPawn_methods.LookUpAtRate_method.Invoke(ObjPointer, Rate);

        ///<summary>Input callback to move forward in local space (or backward if Val is negative).</summary>
        ///<remarks>
        ///@param Val Amount of movement in the forward direction (or backward if negative).
        ///@see APawn::AddMovementInput()
        ///</remarks>
        public void MoveForward(float Val)  => 
            DefaultPawn_methods.MoveForward_method.Invoke(ObjPointer, Val);

        ///<summary>Input callback to strafe right in local space (or left if Val is negative).</summary>
        ///<remarks>
        ///@param Val Amount of movement in the right direction (or left if negative).
        ///@see APawn::AddMovementInput()
        ///</remarks>
        public void MoveRight(float Val)  => 
            DefaultPawn_methods.MoveRight_method.Invoke(ObjPointer, Val);

        ///<summary>Input callback to move up in world space (or down if Val is negative).</summary>
        ///<remarks>
        ///@param Val Amount of movement in the world up direction (or down if negative).
        ///@see APawn::AddMovementInput()
        ///</remarks>
        public void MoveUp_World(float Val)  => 
            DefaultPawn_methods.MoveUp_World_method.Invoke(ObjPointer, Val);

        ///<summary>Called via input to turn at a given rate.</summary>
        ///<remarks>
        ///@param Rate  This is a normalized rate, i.e. 1.0 means 100% of desired turn rate
        ///</remarks>
        public void TurnAtRate(float Rate)  => 
            DefaultPawn_methods.TurnAtRate_method.Invoke(ObjPointer, Rate);
        ///<summary>Base turn rate, in deg/sec. Other scaling may affect final turn rate.</summary>
        public unsafe float BaseTurnRate {
            get {return DefaultPawn_ptr->BaseTurnRate;}
        }
        ///<summary>Base lookup rate, in deg/sec. Other scaling may affect final lookup rate.</summary>
        public unsafe float BaseLookUpRate {
            get {return DefaultPawn_ptr->BaseLookUpRate;}
        }
        ///<summary>DefaultPawn movement component</summary>
        public unsafe PawnMovementComponent MovementComponent {
            get {return DefaultPawn_ptr->MovementComponent;}
        }
        ///<summary>DefaultPawn collision component</summary>
        public unsafe SphereComponent CollisionComponent {
            get {return DefaultPawn_ptr->CollisionComponent;}
        }
        ///<summary>The mesh associated with this Pawn.</summary>
        public unsafe StaticMeshComponent MeshComponent {
            get {return DefaultPawn_ptr->MeshComponent;}
        }
        public bool bAddDefaultMovementBindings {
            get {return Main.GetGetBoolPropertyByName(this, "bAddDefaultMovementBindings"); }
        }
        static DefaultPawn() {
            StaticClass = Main.GetClass("DefaultPawn");
        }
        internal unsafe DefaultPawn_fields* DefaultPawn_ptr => (DefaultPawn_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DefaultPawn(IntPtr p) => UObject.Make<DefaultPawn>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DefaultPawn DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DefaultPawn New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
