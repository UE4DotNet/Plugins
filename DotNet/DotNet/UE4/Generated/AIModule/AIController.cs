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
using UE4.GameplayTasks;
using UE4.Engine;
using UE4.NavigationSystem;

namespace UE4.AIModule {
    ///<summary>AIController is the base class of controllers for AI-controlled Pawns.</summary>
    ///<remarks>
    ///Controllers are non-physical actors that can be attached to a pawn to control its actions.
    ///AIControllers manage the artificial intelligence for the pawns they control.
    ///In networked games, they only exist on the server.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Controller/
    ///</remarks>
    public unsafe partial class AIController : Controller  {

        ///<summary>Event called when PossessedPawn is possessed by this controller.</summary>
        public event OnPossess_delegate OnPossess;
        public delegate void OnPossess_delegate(Pawn PossessedPawn);
        internal void on_OnPossess(Pawn PossessedPawn) =>
            OnPossess?.Invoke(PossessedPawn);


        ///<summary>Gets triggered after given pawn has been unpossesed</summary>
        public event OnUnpossess_delegate OnUnpossess;
        public delegate void OnUnpossess_delegate(Pawn UnpossessedPawn);
        internal void on_OnUnpossess(Pawn UnpossessedPawn) =>
            OnUnpossess?.Invoke(UnpossessedPawn);


        ///<summary>On Using Black Board</summary>
        public event OnUsingBlackBoard_delegate OnUsingBlackBoard;
        public delegate void OnUsingBlackBoard_delegate(BlackboardComponent BlackboardComp, BlackboardData BlackboardAsset);
        internal void on_OnUsingBlackBoard(BlackboardComponent BlackboardComp, BlackboardData BlackboardAsset) =>
            OnUsingBlackBoard?.Invoke(BlackboardComp, BlackboardAsset);


        ///<summary>Claim Task Resource</summary>
        public void ClaimTaskResource(SubclassOf<GameplayTaskResource> ResourceClass)  => 
            AIController_methods.ClaimTaskResource_method.Invoke(ObjPointer, ResourceClass);

        ///<summary>Get AIPerception Component</summary>
        public AIPerceptionComponent GetAIPerceptionComponent()  => 
            AIController_methods.GetAIPerceptionComponent_method.Invoke(ObjPointer);

        ///<summary>Retrieve the final position that controller should be looking at.</summary>
        public Vector GetFocalPoint()  => 
            AIController_methods.GetFocalPoint_method.Invoke(ObjPointer);

        ///<summary>Retrieve the focal point this controller should focus to on given actor.</summary>
        public Vector GetFocalPointOnActor(Actor Actor)  => 
            AIController_methods.GetFocalPointOnActor_method.Invoke(ObjPointer, Actor);

        ///<summary>Get the focused actor.</summary>
        public Actor GetFocusActor()  => 
            AIController_methods.GetFocusActor_method.Invoke(ObjPointer);

        ///<summary>Returns position of current path segment's end.</summary>
        public Vector GetImmediateMoveDestination()  => 
            AIController_methods.GetImmediateMoveDestination_method.Invoke(ObjPointer);

        ///<summary>Returns status of path following</summary>
        public byte GetMoveStatus()  => 
            AIController_methods.GetMoveStatus_method.Invoke(ObjPointer);

        ///<summary>Returns PathFollowingComponent subobject *</summary>
        public PathFollowingComponent GetPathFollowingComponent()  => 
            AIController_methods.GetPathFollowingComponent_method.Invoke(ObjPointer);

        ///<summary>Returns true if the current PathFollowingComponent's path is partial (does not reach desired destination).</summary>
        public bool HasPartialPath()  => 
            AIController_methods.HasPartialPath_method.Invoke(ObjPointer);

        ///<summary>Clears Focus, will also clear FocalPoint as a result</summary>
        public void K2_ClearFocus()  => 
            AIController_methods.K2_ClearFocus_method.Invoke(ObjPointer);

        ///<summary>Set the position that controller should be looking at.</summary>
        public void K2_SetFocalPoint(Vector FP)  => 
            AIController_methods.K2_SetFocalPoint_method.Invoke(ObjPointer, FP);

        ///<summary>Set Focus for actor, will set FocalPoint as a result.</summary>
        public void K2_SetFocus(Actor NewFocus)  => 
            AIController_methods.K2_SetFocus_method.Invoke(ObjPointer, NewFocus);

        ///<summary>
        ///Makes AI go toward specified Goal actor (destination will be continuously updated), aborts any active path following
        ///@
        ///</summary>
        ///<remarks>
        ///param AcceptanceRadius - finish move if pawn gets close enough
        ///@param bStopOnOverlap - add pawn's radius to AcceptanceRadius
        ///@param bUsePathfinding - use navigation data to calculate path (otherwise it will go in straight line)
        ///@param bCanStrafe - set focus related flag: bAllowStrafe
        ///@param FilterClass - navigation filter for pathfinding adjustments. If none specified DefaultNavigationFilterClass will be used
        ///@param bAllowPartialPath - use incomplete path when goal can't be reached
        ///    @note AcceptanceRadius has default value or -1 due to Header Parser not being able to recognize UPathFollowingComponent::DefaultAcceptanceRadius
        ///</remarks>
        public byte MoveToActor(Actor Goal, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bCanStrafe, SubclassOf<NavigationQueryFilter> FilterClass, bool bAllowPartialPath)  => 
            AIController_methods.MoveToActor_method.Invoke(ObjPointer, Goal, AcceptanceRadius, bStopOnOverlap, bUsePathfinding, bCanStrafe, FilterClass, bAllowPartialPath);

        ///<summary>
        ///Makes AI go toward specified Dest location, aborts any active path following
        ///@
        ///</summary>
        ///<remarks>
        ///param AcceptanceRadius - finish move if pawn gets close enough
        ///@param bStopOnOverlap - add pawn's radius to AcceptanceRadius
        ///@param bUsePathfinding - use navigation data to calculate path (otherwise it will go in straight line)
        ///@param bProjectDestinationToNavigation - project location on navigation data before using it
        ///@param bCanStrafe - set focus related flag: bAllowStrafe
        ///@param FilterClass - navigation filter for pathfinding adjustments. If none specified DefaultNavigationFilterClass will be used
        ///@param bAllowPartialPath - use incomplete path when goal can't be reached
        ///    @note AcceptanceRadius has default value or -1 due to Header Parser not being able to recognize UPathFollowingComponent::DefaultAcceptanceRadius
        ///</remarks>
        public byte MoveToLocation(Vector Dest, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bProjectDestinationToNavigation, bool bCanStrafe, SubclassOf<NavigationQueryFilter> FilterClass, bool bAllowPartialPath)  => 
            AIController_methods.MoveToLocation_method.Invoke(ObjPointer, Dest, AcceptanceRadius, bStopOnOverlap, bUsePathfinding, bProjectDestinationToNavigation, bCanStrafe, FilterClass, bAllowPartialPath);

        ///<summary>Starts executing behavior tree.</summary>
        public bool RunBehaviorTree(BehaviorTree BTAsset)  => 
            AIController_methods.RunBehaviorTree_method.Invoke(ObjPointer, BTAsset);

        ///<summary>Updates state of movement block detection.</summary>
        public void SetMoveBlockDetection(bool bEnable)  => 
            AIController_methods.SetMoveBlockDetection_method.Invoke(ObjPointer, bEnable);

        ///<summary>Unclaim Task Resource</summary>
        public void UnclaimTaskResource(SubclassOf<GameplayTaskResource> ResourceClass)  => 
            AIController_methods.UnclaimTaskResource_method.Invoke(ObjPointer, ResourceClass);

        ///<summary>Makes AI use the specified Blackboard asset & creates a Blackboard Component if one does not already exist.</summary>
        ///<remarks>
        ///@param       BlackboardAsset                 The Blackboard asset to use.
        ///@param       BlackboardComponent             The Blackboard component that was used or created to work with the passed-in Blackboard Asset.
        ///@return true if we successfully linked the blackboard asset to the blackboard component.
        ///</remarks>
        public (BlackboardComponent, bool) UseBlackboard(BlackboardData BlackboardAsset)  => 
            AIController_methods.UseBlackboard_method.Invoke(ObjPointer, BlackboardAsset);
        public bool bStopAILogicOnUnposses {
            get {return Main.GetGetBoolPropertyByName(this, "bStopAILogicOnUnposses"); }
            set {Main.SetGetBoolPropertyByName(this, "bStopAILogicOnUnposses", value); }
        }
        public bool bLOSflag {
            get {return Main.GetGetBoolPropertyByName(this, "bLOSflag"); }
            set {Main.SetGetBoolPropertyByName(this, "bLOSflag", value); }
        }
        public bool bSkipExtraLOSChecks {
            get {return Main.GetGetBoolPropertyByName(this, "bSkipExtraLOSChecks"); }
            set {Main.SetGetBoolPropertyByName(this, "bSkipExtraLOSChecks", value); }
        }
        public bool bAllowStrafe {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowStrafe"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowStrafe", value); }
        }
        public bool bWantsPlayerState {
            get {return Main.GetGetBoolPropertyByName(this, "bWantsPlayerState"); }
            set {Main.SetGetBoolPropertyByName(this, "bWantsPlayerState", value); }
        }
        public bool bSetControlRotationFromPawnOrientation {
            get {return Main.GetGetBoolPropertyByName(this, "bSetControlRotationFromPawnOrientation"); }
            set {Main.SetGetBoolPropertyByName(this, "bSetControlRotationFromPawnOrientation", value); }
        }
        ///<summary>Component used for moving along a path.</summary>
        public unsafe PathFollowingComponent PathFollowingComponent {
            get {return AIController_ptr->PathFollowingComponent;}
            set {AIController_ptr->PathFollowingComponent = value;}
        }
        ///<summary>Component responsible for behaviors.</summary>
        public unsafe BrainComponent BrainComponent {
            get {return AIController_ptr->BrainComponent;}
            set {AIController_ptr->BrainComponent = value;}
        }
        ///<summary>Perception Component</summary>
        public unsafe AIPerceptionComponent PerceptionComponent {
            get {return AIController_ptr->PerceptionComponent;}
            set {AIController_ptr->PerceptionComponent = value;}
        }
        ///<summary>Actions Comp</summary>
        public unsafe PawnActionsComponent ActionsComp {
            get {return AIController_ptr->ActionsComp;}
        }
        ///<summary>blackboard</summary>
        public unsafe BlackboardComponent Blackboard {
            get {return AIController_ptr->Blackboard;}
        }
        ///<summary>Cached Gameplay Tasks Component</summary>
        public unsafe GameplayTasksComponent CachedGameplayTasksComponent {
            get {return AIController_ptr->CachedGameplayTasksComponent;}
            set {AIController_ptr->CachedGameplayTasksComponent = value;}
        }
        ///<summary>Default Navigation Filter Class</summary>
        public unsafe SubclassOf<NavigationQueryFilter> DefaultNavigationFilterClass {
            get {return AIController_ptr->DefaultNavigationFilterClass;}
            set {AIController_ptr->DefaultNavigationFilterClass = value;}
        }
         //TODO: multicast delegate FAIMoveCompletedSignature ReceiveMoveCompleted
        static AIController() {
            StaticClass = Main.GetClass("AIController");
            AIController_events.OnPossess_event.Setup();
            AIController_events.OnUnpossess_event.Setup();
            AIController_events.OnUsingBlackBoard_event.Setup();
        }
        internal unsafe AIController_fields* AIController_ptr => (AIController_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIController(IntPtr p) => UObject.Make<AIController>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIController DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIController New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
