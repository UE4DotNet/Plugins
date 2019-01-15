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
    ///<summary>PawnMovementComponent can be used to update movement for an associated Pawn.</summary>
    ///<remarks>
    ///It also provides ways to accumulate and read directional input in a generic way (with AddInputVector(), ConsumeInputVector(), etc).
    ///@see APawn
    ///</remarks>
    public unsafe partial class PawnMovementComponent : NavMovementComponent  {

        ///<summary>Adds the given vector to the accumulated input in world space.</summary>
        ///<remarks>
        ///Input vectors are usually between 0 and 1 in magnitude.
        ///They are accumulated during a frame then applied as acceleration during the movement update.
        ///
        ///@param WorldDirection        Direction in world space to apply input
        ///@param ScaleValue            Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value.
        ///@param bForce                        If true always add the input, ignoring the result of IsMoveInputIgnored().
        ///@see APawn::AddMovementInput()
        ///</remarks>
        public void AddInputVector(Vector WorldVector, bool bForce)  => 
            PawnMovementComponent_methods.AddInputVector_method.Invoke(ObjPointer, WorldVector, bForce);

        ///<summary>Returns the pending input vector and resets it to zero.</summary>
        ///<remarks>
        ///* This should be used during a movement update (by the Pawn or PawnMovementComponent) to prevent accumulation of control input between frames.
        ///       * Copies the pending input vector to the saved input vector (GetLastMovementInputVector()).
        ///       * @return The pending input vector.
        ///</remarks>
        public Vector ConsumeInputVector()  => 
            PawnMovementComponent_methods.ConsumeInputVector_method.Invoke(ObjPointer);

        ///<summary>Return the last input vector in world space that was processed by ConsumeInputVector(), which is usually done by the Pawn or PawnMovementComponent.</summary>
        ///<remarks>
        ///Any user that needs to know about the input that last affected movement should use this function.
        ///@return The last input vector in world space that was processed by ConsumeInputVector().
        ///@see AddInputVector(), ConsumeInputVector(), GetPendingInputVector()
        ///</remarks>
        public Vector GetLastInputVector()  => 
            PawnMovementComponent_methods.GetLastInputVector_method.Invoke(ObjPointer);

        ///<summary>Return the Pawn that owns UpdatedComponent.</summary>
        public Pawn GetPawnOwner()  => 
            PawnMovementComponent_methods.GetPawnOwner_method.Invoke(ObjPointer);

        ///<summary>Return the pending input vector in world space.</summary>
        ///<remarks>
        ///This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it.
        ///PawnMovementComponents implementing movement usually want to use either this or ConsumeInputVector() as these functions represent the most recent state of input.
        ///@return The pending input vector in world space.
        ///@see AddInputVector(), ConsumeInputVector(), GetLastInputVector()
        ///</remarks>
        public Vector GetPendingInputVector()  => 
            PawnMovementComponent_methods.GetPendingInputVector_method.Invoke(ObjPointer);

        ///<summary>Helper to see if move input is ignored. If there is no Pawn or UpdatedComponent, returns true, otherwise defers to the Pawn's implementation of IsMoveInputIgnored().</summary>
        public bool IsMoveInputIgnored()  => 
            PawnMovementComponent_methods.IsMoveInputIgnored_method.Invoke(ObjPointer);

        ///<summary>K2 Get Input Vector</summary>
        public Vector K2_GetInputVector()  => 
            PawnMovementComponent_methods.K2_GetInputVector_method.Invoke(ObjPointer);
        ///<summary>Pawn that owns this component.</summary>
        public unsafe Pawn PawnOwner {
            get {return PawnMovementComponent_ptr->PawnOwner;}
            set {PawnMovementComponent_ptr->PawnOwner = value;}
        }
        static PawnMovementComponent() {
            StaticClass = Main.GetClass("PawnMovementComponent");
        }
        internal unsafe PawnMovementComponent_fields* PawnMovementComponent_ptr => (PawnMovementComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PawnMovementComponent(IntPtr p) => UObject.Make<PawnMovementComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PawnMovementComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PawnMovementComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
