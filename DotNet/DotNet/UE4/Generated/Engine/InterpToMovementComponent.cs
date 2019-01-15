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
    ///Move the root component between a series of points over a given time *
    ///@
    ///</summary>
    ///<remarks>see UMovementComponent</remarks>
    public unsafe partial class InterpToMovementComponent : MovementComponent  {

        ///<summary>Initialise the control points array. Call after adding control points if they are add after begin play .</summary>
        public void FinaliseControlPoints()  => 
            InterpToMovementComponent_methods.FinaliseControlPoints_method.Invoke(ObjPointer);

        ///<summary>Reset to start. Sets time to zero and direction to 1.</summary>
        public void RestartMovement(float InitialDirection)  => 
            InterpToMovementComponent_methods.RestartMovement_method.Invoke(ObjPointer, InitialDirection);

        ///<summary>Clears the reference to UpdatedComponent, fires stop event, and stops ticking.</summary>
        public void StopSimulating(HitResult HitResult)  => 
            InterpToMovementComponent_methods.StopSimulating_method.Invoke(ObjPointer, HitResult);
        ///<summary>How long to take to move from the first point to the last (or vice versa)</summary>
        public unsafe float Duration {
            get {return InterpToMovementComponent_ptr->Duration;}
            set {InterpToMovementComponent_ptr->Duration = value;}
        }
        public bool bPauseOnImpact {
            get {return Main.GetGetBoolPropertyByName(this, "bPauseOnImpact"); }
            set {Main.SetGetBoolPropertyByName(this, "bPauseOnImpact", value); }
        }
         //TODO: enum EInterpToBehaviourType BehaviourType
        public bool bForceSubStepping {
            get {return Main.GetGetBoolPropertyByName(this, "bForceSubStepping"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceSubStepping", value); }
        }
         //TODO: multicast delegate FOnInterpToReverseDelegate OnInterpToReverse
         //TODO: multicast delegate FOnInterpToStopDelegate OnInterpToStop
         //TODO: multicast delegate FOnInterpToWaitBeginDelegate OnWaitBeginDelegate
         //TODO: multicast delegate FOnInterpToWaitEndDelegate OnWaitEndDelegate
         //TODO: multicast delegate FOnInterpToResetDelegate OnResetDelegate
        ///<summary>Max time delta for each discrete simulation step.</summary>
        ///<remarks>
        ///Lowering this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
        ///
        ///WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
        ///@see MaxSimulationIterations, bForceSubStepping
        ///</remarks>
        public unsafe float MaxSimulationTimeStep {
            get {return InterpToMovementComponent_ptr->MaxSimulationTimeStep;}
            set {InterpToMovementComponent_ptr->MaxSimulationTimeStep = value;}
        }
        ///<summary>Max number of iterations used for each discrete simulation step.</summary>
        ///<remarks>
        ///Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
        ///
        ///WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
        ///@see MaxSimulationTimeStep, bForceSubStepping
        ///</remarks>
        public unsafe int MaxSimulationIterations {
            get {return InterpToMovementComponent_ptr->MaxSimulationIterations;}
            set {InterpToMovementComponent_ptr->MaxSimulationIterations = value;}
        }
         //TODO: array not UObject TArray ControlPoints
        static InterpToMovementComponent() {
            StaticClass = Main.GetClass("InterpToMovementComponent");
        }
        internal unsafe InterpToMovementComponent_fields* InterpToMovementComponent_ptr => (InterpToMovementComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpToMovementComponent(IntPtr p) => UObject.Make<InterpToMovementComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpToMovementComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpToMovementComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
