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
using UE4.NavigationSystem.Native;
using UE4.Engine;

namespace UE4.NavigationSystem {
    ///<summary>Navigation System V1</summary>
    public unsafe partial class NavigationSystemV1 : NavigationSystemBase  {

        ///<summary>Finds path instantly, in a FindPath Synchronously.</summary>
        ///<remarks>
        ///Main advantage over FindPathToLocationSynchronously is that
        ///    the resulting path will automatically get updated if goal actor moves more than TetherDistance away from last path node
        ///    @param PathfindingContext could be one of following: NavigationData (like Navmesh actor), Pawn or Controller. This parameter determines parameters of specific pathfinding query
        ///</remarks>
        public static NavigationPath FindPathToActorSynchronously(UObject WorldContextObject, Vector PathStart, Actor GoalActor, float TetherDistance, Actor PathfindingContext, SubclassOf<NavigationQueryFilter> FilterClass)  => 
            NavigationSystemV1_methods.FindPathToActorSynchronously_method.Invoke(WorldContextObject, PathStart, GoalActor, TetherDistance, PathfindingContext, FilterClass);

        ///<summary>Finds path instantly, in a FindPath Synchronously.</summary>
        ///<remarks>
        ///@param PathfindingContext could be one of following: NavigationData (like Navmesh actor), Pawn or Controller. This parameter determines parameters of specific pathfinding query
        ///</remarks>
        public static NavigationPath FindPathToLocationSynchronously(UObject WorldContextObject, Vector PathStart, Vector PathEnd, Actor PathfindingContext, SubclassOf<NavigationQueryFilter> FilterClass)  => 
            NavigationSystemV1_methods.FindPathToLocationSynchronously_method.Invoke(WorldContextObject, PathStart, PathEnd, PathfindingContext, FilterClass);

        ///<summary>Blueprint functions</summary>
        public static NavigationSystemV1 GetNavigationSystem(UObject WorldContextObject)  => 
            NavigationSystemV1_methods.GetNavigationSystem_method.Invoke(WorldContextObject);

        ///<summary>Potentially expensive. Use with caution. Consider using UPathFollowingComponent::GetRemainingPathCost instead</summary>
        public static (float, byte) GetPathCost(UObject WorldContextObject, Vector PathStart, Vector PathEnd, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass)  => 
            NavigationSystemV1_methods.GetPathCost_method.Invoke(WorldContextObject, PathStart, PathEnd, NavData, FilterClass);

        ///<summary>Potentially expensive. Use with caution</summary>
        public static (float, byte) GetPathLength(UObject WorldContextObject, Vector PathStart, Vector PathEnd, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass)  => 
            NavigationSystemV1_methods.GetPathLength_method.Invoke(WorldContextObject, PathStart, PathEnd, NavData, FilterClass);

        ///<summary>Get Random Point in Navigable Radius</summary>
        public static Vector GetRandomPointInNavigableRadius(UObject WorldContextObject, Vector Origin, float Radius, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass)  => 
            NavigationSystemV1_methods.GetRandomPointInNavigableRadius_method.Invoke(WorldContextObject, Origin, Radius, NavData, FilterClass);

        ///<summary>Get Random Reachable Point in Radius</summary>
        public static Vector GetRandomReachablePointInRadius(UObject WorldContextObject, Vector Origin, float Radius, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass)  => 
            NavigationSystemV1_methods.GetRandomReachablePointInRadius_method.Invoke(WorldContextObject, Origin, Radius, NavData, FilterClass);

        ///<summary>Is Navigation Being Built</summary>
        public static bool IsNavigationBeingBuilt(UObject WorldContextObject)  => 
            NavigationSystemV1_methods.IsNavigationBeingBuilt_method.Invoke(WorldContextObject);

        ///<summary>Is Navigation Being Built or Locked</summary>
        public static bool IsNavigationBeingBuiltOrLocked(UObject WorldContextObject)  => 
            NavigationSystemV1_methods.IsNavigationBeingBuiltOrLocked_method.Invoke(WorldContextObject);

        ///<summary>Generates a random location in navigable space within given radius of Origin.</summary>
        ///<remarks>
        ///@return Return Value represents if the call was successful
        ///</remarks>
        public static (Vector, bool) K2_GetRandomPointInNavigableRadius(UObject WorldContextObject, Vector Origin, float Radius, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass)  => 
            NavigationSystemV1_methods.K2_GetRandomPointInNavigableRadius_method.Invoke(WorldContextObject, Origin, Radius, NavData, FilterClass);

        ///<summary>Generates a random location reachable from given Origin location.</summary>
        ///<remarks>
        ///@return Return Value represents if the call was successful
        ///</remarks>
        public static (Vector, bool) K2_GetRandomReachablePointInRadius(UObject WorldContextObject, Vector Origin, float Radius, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass)  => 
            NavigationSystemV1_methods.K2_GetRandomReachablePointInRadius_method.Invoke(WorldContextObject, Origin, Radius, NavData, FilterClass);

        ///<summary>Project a point onto the NavigationData</summary>
        public static (Vector, bool) K2_ProjectPointToNavigation(UObject WorldContextObject, Vector Point, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass, Vector QueryExtent)  => 
            NavigationSystemV1_methods.K2_ProjectPointToNavigation_method.Invoke(WorldContextObject, Point, NavData, FilterClass, QueryExtent);

        ///<summary>Performs navigation raycast on NavigationData appropriate for given Querier.</summary>
        ///<remarks>
        ///@param Querier if not passed default navigation data will be used
        ///    @param HitLocation if line was obstructed this will be set to hit location. Otherwise it contains SegmentEnd
        ///    @return true if line from RayStart to RayEnd was obstructed. Also, true when no navigation data present
        ///</remarks>
        public static (Vector, bool) NavigationRaycast(UObject WorldContextObject, Vector RayStart, Vector RayEnd, SubclassOf<NavigationQueryFilter> FilterClass, Controller Querier)  => 
            NavigationSystemV1_methods.NavigationRaycast_method.Invoke(WorldContextObject, RayStart, RayEnd, FilterClass, Querier);

        ///<summary>@todo document</summary>
        public void OnNavigationBoundsUpdated(NavMeshBoundsVolume NavVolume)  => 
            NavigationSystemV1_methods.OnNavigationBoundsUpdated_method.Invoke(ObjPointer, NavVolume);

        ///<summary>Project Point to Navigation</summary>
        public static Vector ProjectPointToNavigation(UObject WorldContextObject, Vector Point, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass, Vector QueryExtent)  => 
            NavigationSystemV1_methods.ProjectPointToNavigation_method.Invoke(WorldContextObject, Point, NavData, FilterClass, QueryExtent);

        ///<summary>
        ///Registers given actor as a "navigation enforcer" which means navigation system will
        ///    make sure navigation is being generated in specified radius around it.
        ///</summary>
        ///<remarks>
        ///@note: you need NavigationSystem's GenerateNavigationOnlyAroundNavigationInvokers to be set to true
        ///            to take advantage of this feature
        ///</remarks>
        public void RegisterNavigationInvoker(Actor Invoker, float TileGenerationRadius, float TileRemovalRadius)  => 
            NavigationSystemV1_methods.RegisterNavigationInvoker_method.Invoke(ObjPointer, Invoker, TileGenerationRadius, TileRemovalRadius);

        ///<summary>Brings limit of simultaneous navmesh tile generation jobs back to Project Setting's default value</summary>
        public void ResetMaxSimultaneousTileGenerationJobsCount()  => 
            NavigationSystemV1_methods.ResetMaxSimultaneousTileGenerationJobsCount_method.Invoke(ObjPointer);

        ///<summary>Set Geometry Gathering Mode</summary>
        public void SetGeometryGatheringMode(ENavDataGatheringModeConfig NewMode)  => 
            NavigationSystemV1_methods.SetGeometryGatheringMode_method.Invoke(ObjPointer, NewMode);

        ///<summary>will limit the number of simultaneously running navmesh tile generation jobs to specified number.</summary>
        ///<remarks>
        ///@param MaxNumberOfJobs gets trimmed to be at least 1. You cannot use this function to pause navmesh generation
        ///</remarks>
        public void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs)  => 
            NavigationSystemV1_methods.SetMaxSimultaneousTileGenerationJobsCount_method.Invoke(ObjPointer, MaxNumberOfJobs);

        ///<summary>Simple Move to Actor</summary>
        public static void SimpleMoveToActor(Controller Controller, Actor Goal)  => 
            NavigationSystemV1_methods.SimpleMoveToActor_method.Invoke(Controller, Goal);

        ///<summary>Simple Move to Location</summary>
        public static void SimpleMoveToLocation(Controller Controller, Vector Goal)  => 
            NavigationSystemV1_methods.SimpleMoveToLocation_method.Invoke(Controller, Goal);

        ///<summary>Removes given actor from the list of active navigation enforcers.</summary>
        ///<remarks>
        ///@see RegisterNavigationInvoker for more details
        ///</remarks>
        public void UnregisterNavigationInvoker(Actor Invoker)  => 
            NavigationSystemV1_methods.UnregisterNavigationInvoker_method.Invoke(ObjPointer, Invoker);
        ///<summary>Main Nav Data</summary>
        public unsafe NavigationData MainNavData {
            get {return NavigationSystemV1_ptr->MainNavData;}
            set {NavigationSystemV1_ptr->MainNavData = value;}
        }
        ///<summary>special navigation data for managing direct paths, not part of NavDataSet!</summary>
        public unsafe NavigationData AbstractNavData {
            get {return NavigationSystemV1_ptr->AbstractNavData;}
            set {NavigationSystemV1_ptr->AbstractNavData = value;}
        }
        ///<summary>Crowd Manager Class</summary>
        public unsafe SubclassOf<CrowdManagerBase> CrowdManagerClass {
            get {return NavigationSystemV1_ptr->CrowdManagerClass;}
        }
        public bool bAutoCreateNavigationData {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoCreateNavigationData"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoCreateNavigationData", value); }
        }
        public bool bSpawnNavDataInNavBoundsLevel {
            get {return Main.GetGetBoolPropertyByName(this, "bSpawnNavDataInNavBoundsLevel"); }
            set {Main.SetGetBoolPropertyByName(this, "bSpawnNavDataInNavBoundsLevel", value); }
        }
        public bool bAllowClientSideNavigation {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowClientSideNavigation"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowClientSideNavigation", value); }
        }
        public bool bShouldDiscardSubLevelNavData {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldDiscardSubLevelNavData"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldDiscardSubLevelNavData", value); }
        }
        public bool bTickWhilePaused {
            get {return Main.GetGetBoolPropertyByName(this, "bTickWhilePaused"); }
            set {Main.SetGetBoolPropertyByName(this, "bTickWhilePaused", value); }
        }
        public bool bSupportRebuilding {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportRebuilding"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportRebuilding", value); }
        }
        public bool bInitialBuildingLocked {
            get {return Main.GetGetBoolPropertyByName(this, "bInitialBuildingLocked"); }
            set {Main.SetGetBoolPropertyByName(this, "bInitialBuildingLocked", value); }
        }
        public bool bSkipAgentHeightCheckWhenPickingNavData {
            get {return Main.GetGetBoolPropertyByName(this, "bSkipAgentHeightCheckWhenPickingNavData"); }
            set {Main.SetGetBoolPropertyByName(this, "bSkipAgentHeightCheckWhenPickingNavData", value); }
        }
         //TODO: enum ENavDataGatheringModeConfig DataGatheringMode
        public bool bGenerateNavigationOnlyAroundNavigationInvokers {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateNavigationOnlyAroundNavigationInvokers"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateNavigationOnlyAroundNavigationInvokers", value); }
        }
        ///<summary>Minimal time, in seconds, between active tiles set update</summary>
        public unsafe float ActiveTilesUpdateInterval {
            get {return NavigationSystemV1_ptr->ActiveTilesUpdateInterval;}
            set {NavigationSystemV1_ptr->ActiveTilesUpdateInterval = value;}
        }
         //TODO: array not UObject TArray SupportedAgents
        ///<summary>update frequency for dirty areas on navmesh</summary>
        public unsafe float DirtyAreasUpdateFreq {
            get {return NavigationSystemV1_ptr->DirtyAreasUpdateFreq;}
            set {NavigationSystemV1_ptr->DirtyAreasUpdateFreq = value;}
        }
        ///<summary>Nav Data Set</summary>
        public ObjectArrayField<NavigationData> NavDataSet{ get {
            if(NavDataSet_store == null) NavDataSet_store = new ObjectArrayField<NavigationData> (&NavigationSystemV1_ptr->NavDataSet);
            return NavDataSet_store;
        } }
        private ObjectArrayField<NavigationData> NavDataSet_store;

        ///<summary>Nav Data Registration Queue</summary>
        public ObjectArrayField<NavigationData> NavDataRegistrationQueue{ get {
            if(NavDataRegistrationQueue_store == null) NavDataRegistrationQueue_store = new ObjectArrayField<NavigationData> (&NavigationSystemV1_ptr->NavDataRegistrationQueue);
            return NavDataRegistrationQueue_store;
        } }
        private ObjectArrayField<NavigationData> NavDataRegistrationQueue_store;

         //TODO: multicast delegate FOnNavDataGenericEvent OnNavDataRegisteredEvent
         //TODO: multicast delegate FOnNavDataGenericEvent OnNavigationGenerationFinishedDelegate
         //TODO: enum FNavigationSystemRunMode OperationMode
        static NavigationSystemV1() {
            StaticClass = Main.GetClass("NavigationSystemV1");
        }
        internal unsafe NavigationSystemV1_fields* NavigationSystemV1_ptr => (NavigationSystemV1_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationSystemV1(IntPtr p) => UObject.Make<NavigationSystemV1>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationSystemV1 DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationSystemV1 New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
