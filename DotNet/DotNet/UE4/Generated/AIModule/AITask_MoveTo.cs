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
using UE4.AIModule.Native;
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>AITask Move To</summary>
    public unsafe partial class AITask_MoveTo : AITask  {

        ///<summary>AIMove To</summary>
        public static AITask_MoveTo AIMoveTo(AIController Controller, Vector GoalLocation, Actor GoalActor, float AcceptanceRadius, byte StopOnOverlap, byte AcceptPartialPath, bool bUsePathfinding, bool bLockAILogic, bool bUseContinuosGoalTracking)  => 
            AITask_MoveTo_methods.AIMoveTo_method.Invoke(Controller, GoalLocation, GoalActor, AcceptanceRadius, StopOnOverlap, AcceptPartialPath, bUsePathfinding, bLockAILogic, bUseContinuosGoalTracking);
         //TODO: multicast delegate FGenericGameplayTaskDelegate OnRequestFailed
         //TODO: multicast delegate FMoveTaskCompletedSignature OnMoveFinished
        ///<summary>parameters of move request</summary>
        public unsafe AIMoveRequest MoveRequest {
            get {return AITask_MoveTo_ptr->MoveRequest;}
            set {AITask_MoveTo_ptr->MoveRequest = value;}
        }
        static AITask_MoveTo() {
            StaticClass = Main.GetClass("AITask_MoveTo");
        }
        internal unsafe AITask_MoveTo_fields* AITask_MoveTo_ptr => (AITask_MoveTo_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AITask_MoveTo(IntPtr p) => UObject.Make<AITask_MoveTo>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AITask_MoveTo DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AITask_MoveTo New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
