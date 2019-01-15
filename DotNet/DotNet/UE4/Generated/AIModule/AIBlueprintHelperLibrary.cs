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
using UE4.NavigationSystem;

namespace UE4.AIModule {
    ///<summary>AIBlueprint Helper Library</summary>
    public unsafe partial class AIBlueprintHelperLibrary : BlueprintFunctionLibrary  {

        ///<summary>Create Move to Proxy Object</summary>
        public static AIAsyncTaskBlueprintProxy CreateMoveToProxyObject(UObject WorldContextObject, Pawn Pawn, Vector Destination, Actor TargetActor, float AcceptanceRadius, bool bStopOnOverlap)  => 
            AIBlueprintHelperLibrary_methods.CreateMoveToProxyObject_method.Invoke(WorldContextObject, Pawn, Destination, TargetActor, AcceptanceRadius, bStopOnOverlap);

        ///<summary>
        ///The way it works exactly is if the actor passed in is a pawn, then the function retrieves
        ///    pawn's controller cast to AIController.
        ///</summary>
        ///<remarks>Otherwise the function returns actor cast to AIController.</remarks>
        public static AIController GetAIController(Actor ControlledActor)  => 
            AIBlueprintHelperLibrary_methods.GetAIController_method.Invoke(ControlledActor);

        ///<summary>Get Blackboard</summary>
        public static BlackboardComponent GetBlackboard(Actor Target)  => 
            AIBlueprintHelperLibrary_methods.GetBlackboard_method.Invoke(Target);

        ///<summary>Returns a copy of navigation path given controller is currently using.</summary>
        ///<remarks>
        ///The result being a copy means you won't be able to influence agent's pathfollowing
        ///    by manipulating received path
        ///</remarks>
        public static NavigationPath GetCurrentPath(Controller Controller)  => 
            AIBlueprintHelperLibrary_methods.GetCurrentPath_method.Invoke(Controller);

        ///<summary>Is Valid AIDirection</summary>
        public static bool IsValidAIDirection(Vector DirectionVector)  => 
            AIBlueprintHelperLibrary_methods.IsValidAIDirection_method.Invoke(DirectionVector);

        ///<summary>Is Valid AILocation</summary>
        public static bool IsValidAILocation(Vector Location)  => 
            AIBlueprintHelperLibrary_methods.IsValidAILocation_method.Invoke(Location);

        ///<summary>Is Valid AIRotation</summary>
        public static bool IsValidAIRotation(Rotator Rotation)  => 
            AIBlueprintHelperLibrary_methods.IsValidAIRotation_method.Invoke(Rotation);

        ///<summary>locks indicated AI resources of animated pawn</summary>
        public static void LockAIResourcesWithAnimation(AnimInstance AnimInstance, bool bLockMovement, bool LockAILogic)  => 
            AIBlueprintHelperLibrary_methods.LockAIResourcesWithAnimation_method.Invoke(AnimInstance, bLockMovement, LockAILogic);

        ///<summary>Send AIMessage</summary>
        public static void SendAIMessage(Pawn Target, Name Message, UObject MessageSource, bool bSuccess)  => 
            AIBlueprintHelperLibrary_methods.SendAIMessage_method.Invoke(Target, Message, MessageSource, bSuccess);

        ///<summary>Simple Move to Actor</summary>
        public static void SimpleMoveToActor(Controller Controller, Actor Goal)  => 
            AIBlueprintHelperLibrary_methods.SimpleMoveToActor_method.Invoke(Controller, Goal);

        ///<summary>Simple Move to Location</summary>
        public static void SimpleMoveToLocation(Controller Controller, Vector Goal)  => 
            AIBlueprintHelperLibrary_methods.SimpleMoveToLocation_method.Invoke(Controller, Goal);

        ///<summary>Spawn AIFrom Class</summary>
        public static Pawn SpawnAIFromClass(UObject WorldContextObject, SubclassOf<Pawn> PawnClass, BehaviorTree BehaviorTree, Vector Location, Rotator Rotation, bool bNoCollisionFail)  => 
            AIBlueprintHelperLibrary_methods.SpawnAIFromClass_method.Invoke(WorldContextObject, PawnClass, BehaviorTree, Location, Rotation, bNoCollisionFail);

        ///<summary>unlocks indicated AI resources of animated pawn. Will unlock only animation-locked resources</summary>
        public static void UnlockAIResourcesWithAnimation(AnimInstance AnimInstance, bool bUnlockMovement, bool UnlockAILogic)  => 
            AIBlueprintHelperLibrary_methods.UnlockAIResourcesWithAnimation_method.Invoke(AnimInstance, bUnlockMovement, UnlockAILogic);
        static AIBlueprintHelperLibrary() {
            StaticClass = Main.GetClass("AIBlueprintHelperLibrary");
        }
        internal unsafe AIBlueprintHelperLibrary_fields* AIBlueprintHelperLibrary_ptr => (AIBlueprintHelperLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIBlueprintHelperLibrary(IntPtr p) => UObject.Make<AIBlueprintHelperLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIBlueprintHelperLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIBlueprintHelperLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
