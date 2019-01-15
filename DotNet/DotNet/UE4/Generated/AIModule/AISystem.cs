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
    ///<summary>AISystem</summary>
    public unsafe partial class AISystem : AISystemBase  {
        ///<summary>Perception System Class Name</summary>
        public unsafe SoftClassPath PerceptionSystemClassName {
            get {return AISystem_ptr->PerceptionSystemClassName;}
            set {AISystem_ptr->PerceptionSystemClassName = value;}
        }
        ///<summary>Hot Spot Manager Class Name</summary>
        public unsafe SoftClassPath HotSpotManagerClassName {
            get {return AISystem_ptr->HotSpotManagerClassName;}
            set {AISystem_ptr->HotSpotManagerClassName = value;}
        }
        ///<summary>Default AI movement's acceptance radius used to determine whether</summary>
        ///<remarks>AI reached path's end</remarks>
        public unsafe float AcceptanceRadius {
            get {return AISystem_ptr->AcceptanceRadius;}
            set {AISystem_ptr->AcceptanceRadius = value;}
        }
        ///<summary>Value used for pathfollowing's internal code to determine whether AI reached path's point.</summary>
        ///<remarks>
        ///@note this value is not used for path's last point. @see AcceptanceRadius
        ///</remarks>
        public unsafe float PathfollowingRegularPathPointAcceptanceRadius {
            get {return AISystem_ptr->PathfollowingRegularPathPointAcceptanceRadius;}
            set {AISystem_ptr->PathfollowingRegularPathPointAcceptanceRadius = value;}
        }
        ///<summary>Similarly to PathfollowingRegularPathPointAcceptanceRadius used by pathfollowing's internals</summary>
        ///<remarks>but gets applied only when next point on a path represents a begining of navigation link</remarks>
        public unsafe float PathfollowingNavLinkAcceptanceRadius {
            get {return AISystem_ptr->PathfollowingNavLinkAcceptanceRadius;}
            set {AISystem_ptr->PathfollowingNavLinkAcceptanceRadius = value;}
        }
        public bool bFinishMoveOnGoalOverlap {
            get {return Main.GetGetBoolPropertyByName(this, "bFinishMoveOnGoalOverlap"); }
            set {Main.SetGetBoolPropertyByName(this, "bFinishMoveOnGoalOverlap", value); }
        }
        public bool bAcceptPartialPaths {
            get {return Main.GetGetBoolPropertyByName(this, "bAcceptPartialPaths"); }
            set {Main.SetGetBoolPropertyByName(this, "bAcceptPartialPaths", value); }
        }
        public bool bAllowStrafing {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowStrafing"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowStrafing", value); }
        }
        public bool bEnableBTAITasks {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableBTAITasks"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableBTAITasks", value); }
        }
        public bool bAllowControllersAsEQSQuerier {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowControllersAsEQSQuerier"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowControllersAsEQSQuerier", value); }
        }
        public bool bEnableDebuggerPlugin {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableDebuggerPlugin"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableDebuggerPlugin", value); }
        }
        ///<summary>Default Sight Collision Channel</summary>
        public unsafe byte DefaultSightCollisionChannel {
            get {return AISystem_ptr->DefaultSightCollisionChannel;}
            set {AISystem_ptr->DefaultSightCollisionChannel = value;}
        }
        ///<summary>Behavior tree manager used by game</summary>
        public unsafe BehaviorTreeManager BehaviorTreeManager {
            get {return AISystem_ptr->BehaviorTreeManager;}
            set {AISystem_ptr->BehaviorTreeManager = value;}
        }
        ///<summary>Environment query manager used by game</summary>
        public unsafe EnvQueryManager EnvironmentQueryManager {
            get {return AISystem_ptr->EnvironmentQueryManager;}
            set {AISystem_ptr->EnvironmentQueryManager = value;}
        }
        ///<summary>Perception System</summary>
        public unsafe AIPerceptionSystem PerceptionSystem {
            get {return AISystem_ptr->PerceptionSystem;}
            set {AISystem_ptr->PerceptionSystem = value;}
        }
        ///<summary>All Proxy Objects</summary>
        public ObjectArrayField<AIAsyncTaskBlueprintProxy> AllProxyObjects{ get {
            if(AllProxyObjects_store == null) AllProxyObjects_store = new ObjectArrayField<AIAsyncTaskBlueprintProxy> (&AISystem_ptr->AllProxyObjects);
            return AllProxyObjects_store;
        } }
        private ObjectArrayField<AIAsyncTaskBlueprintProxy> AllProxyObjects_store;

        ///<summary>Hot Spot Manager</summary>
        public unsafe AIHotSpotManager HotSpotManager {
            get {return AISystem_ptr->HotSpotManager;}
            set {AISystem_ptr->HotSpotManager = value;}
        }
        ///<summary>Nav Local Grids</summary>
        public unsafe NavLocalGridManager NavLocalGrids {
            get {return AISystem_ptr->NavLocalGrids;}
            set {AISystem_ptr->NavLocalGrids = value;}
        }
        static AISystem() {
            StaticClass = Main.GetClass("AISystem");
        }
        internal unsafe AISystem_fields* AISystem_ptr => (AISystem_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISystem(IntPtr p) => UObject.Make<AISystem>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISystem DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISystem New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
