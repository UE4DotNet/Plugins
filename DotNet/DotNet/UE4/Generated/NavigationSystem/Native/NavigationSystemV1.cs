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

using UE4.Engine;

namespace UE4.NavigationSystem.Native {
    [StructLayout( LayoutKind.Explicit, Size=1064 )]
    internal unsafe struct NavigationSystemV1_fields {
        [FieldOffset(56)]  public IntPtr  MainNavData;
        [FieldOffset(64)]  public IntPtr  AbstractNavData;
        [FieldOffset(72)] public IntPtr CrowdManagerClass;
        [FieldOffset(80)] public bool bAutoCreateNavigationData;
        [FieldOffset(80)] public bool bSpawnNavDataInNavBoundsLevel;
        [FieldOffset(80)] public bool bAllowClientSideNavigation;
        [FieldOffset(80)] public bool bShouldDiscardSubLevelNavData;
        [FieldOffset(80)] public bool bTickWhilePaused;
        [FieldOffset(80)] public bool bSupportRebuilding;
        [FieldOffset(80)] public bool bInitialBuildingLocked;
        [FieldOffset(81)] public bool bSkipAgentHeightCheckWhenPickingNavData;
        [FieldOffset(84)] byte DataGatheringMode; //TODO: enum ENavDataGatheringModeConfig DataGatheringMode
        [FieldOffset(88)] public bool bGenerateNavigationOnlyAroundNavigationInvokers;
        [FieldOffset(92)] public float ActiveTilesUpdateInterval;
        [FieldOffset(96)] public NativeArray SupportedAgents;
        [FieldOffset(112)] public float DirtyAreasUpdateFreq;
        [FieldOffset(120)] public NativeArray NavDataSet;
        [FieldOffset(136)] public NativeArray NavDataRegistrationQueue;
        [FieldOffset(248)] byte OnNavDataRegisteredEvent; //TODO: multicast delegate FOnNavDataGenericEvent OnNavDataRegisteredEvent
        [FieldOffset(264)] byte OnNavigationGenerationFinishedDelegate; //TODO: multicast delegate FOnNavDataGenericEvent OnNavigationGenerationFinishedDelegate
        [FieldOffset(484)] byte OperationMode; //TODO: enum FNavigationSystemRunMode OperationMode
    }
    internal unsafe struct NavigationSystemV1_methods {
        internal struct FindPathToActorSynchronously_method {
            static internal IntPtr FindPathToActorSynchronously_ptr;
            static FindPathToActorSynchronously_method() {
                FindPathToActorSynchronously_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "FindPathToActorSynchronously");
            }

            internal static unsafe NavigationPath Invoke(UObject WorldContextObject, Vector PathStart, Actor GoalActor, float TetherDistance, Actor PathfindingContext, SubclassOf<NavigationQueryFilter> FilterClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = PathStart;
                *((IntPtr*)(b+24)) = GoalActor;
                *((float*)(b+32)) = TetherDistance;
                *((IntPtr*)(b+40)) = PathfindingContext;
                *((IntPtr*)(b+48)) = FilterClass;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, FindPathToActorSynchronously_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+56));
            }
        }
        internal struct FindPathToLocationSynchronously_method {
            static internal IntPtr FindPathToLocationSynchronously_ptr;
            static FindPathToLocationSynchronously_method() {
                FindPathToLocationSynchronously_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "FindPathToLocationSynchronously");
            }

            internal static unsafe NavigationPath Invoke(UObject WorldContextObject, Vector PathStart, Vector PathEnd, Actor PathfindingContext, SubclassOf<NavigationQueryFilter> FilterClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = PathStart;
                *((Vector*)(b+20)) = PathEnd;
                *((IntPtr*)(b+32)) = PathfindingContext;
                *((IntPtr*)(b+40)) = FilterClass;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, FindPathToLocationSynchronously_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+48));
            }
        }
        internal struct GetNavigationSystem_method {
            static internal IntPtr GetNavigationSystem_ptr;
            static GetNavigationSystem_method() {
                GetNavigationSystem_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "GetNavigationSystem");
            }

            internal static unsafe NavigationSystemV1 Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, GetNavigationSystem_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetPathCost_method {
            static internal IntPtr GetPathCost_ptr;
            static GetPathCost_method() {
                GetPathCost_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "GetPathCost");
            }

            internal static unsafe (float, byte) Invoke(UObject WorldContextObject, Vector PathStart, Vector PathEnd, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = PathStart;
                *((Vector*)(b+20)) = PathEnd;
                *((IntPtr*)(b+40)) = NavData;
                *((IntPtr*)(b+48)) = FilterClass;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, GetPathCost_ptr, new IntPtr(p)); ;
                return (*((float*)(b+32)),*(b+56));
            }
        }
        internal struct GetPathLength_method {
            static internal IntPtr GetPathLength_ptr;
            static GetPathLength_method() {
                GetPathLength_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "GetPathLength");
            }

            internal static unsafe (float, byte) Invoke(UObject WorldContextObject, Vector PathStart, Vector PathEnd, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = PathStart;
                *((Vector*)(b+20)) = PathEnd;
                *((IntPtr*)(b+40)) = NavData;
                *((IntPtr*)(b+48)) = FilterClass;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, GetPathLength_ptr, new IntPtr(p)); ;
                return (*((float*)(b+32)),*(b+56));
            }
        }
        internal struct GetRandomPointInNavigableRadius_method {
            static internal IntPtr GetRandomPointInNavigableRadius_ptr;
            static GetRandomPointInNavigableRadius_method() {
                GetRandomPointInNavigableRadius_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "GetRandomPointInNavigableRadius");
            }

            internal static unsafe Vector Invoke(UObject WorldContextObject, Vector Origin, float Radius, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Origin;
                *((float*)(b+20)) = Radius;
                *((IntPtr*)(b+24)) = NavData;
                *((IntPtr*)(b+32)) = FilterClass;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, GetRandomPointInNavigableRadius_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+40));
            }
        }
        internal struct GetRandomReachablePointInRadius_method {
            static internal IntPtr GetRandomReachablePointInRadius_ptr;
            static GetRandomReachablePointInRadius_method() {
                GetRandomReachablePointInRadius_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "GetRandomReachablePointInRadius");
            }

            internal static unsafe Vector Invoke(UObject WorldContextObject, Vector Origin, float Radius, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Origin;
                *((float*)(b+20)) = Radius;
                *((IntPtr*)(b+24)) = NavData;
                *((IntPtr*)(b+32)) = FilterClass;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, GetRandomReachablePointInRadius_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+40));
            }
        }
        internal struct IsNavigationBeingBuilt_method {
            static internal IntPtr IsNavigationBeingBuilt_ptr;
            static IsNavigationBeingBuilt_method() {
                IsNavigationBeingBuilt_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "IsNavigationBeingBuilt");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, IsNavigationBeingBuilt_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsNavigationBeingBuiltOrLocked_method {
            static internal IntPtr IsNavigationBeingBuiltOrLocked_ptr;
            static IsNavigationBeingBuiltOrLocked_method() {
                IsNavigationBeingBuiltOrLocked_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "IsNavigationBeingBuiltOrLocked");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, IsNavigationBeingBuiltOrLocked_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct K2_GetRandomPointInNavigableRadius_method {
            static internal IntPtr K2_GetRandomPointInNavigableRadius_ptr;
            static K2_GetRandomPointInNavigableRadius_method() {
                K2_GetRandomPointInNavigableRadius_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "K2_GetRandomPointInNavigableRadius");
            }

            internal static unsafe (Vector, bool) Invoke(UObject WorldContextObject, Vector Origin, float Radius, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Origin;
                *((float*)(b+32)) = Radius;
                *((IntPtr*)(b+40)) = NavData;
                *((IntPtr*)(b+48)) = FilterClass;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, K2_GetRandomPointInNavigableRadius_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+20)),*((bool*)(b+56)));
            }
        }
        internal struct K2_GetRandomReachablePointInRadius_method {
            static internal IntPtr K2_GetRandomReachablePointInRadius_ptr;
            static K2_GetRandomReachablePointInRadius_method() {
                K2_GetRandomReachablePointInRadius_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "K2_GetRandomReachablePointInRadius");
            }

            internal static unsafe (Vector, bool) Invoke(UObject WorldContextObject, Vector Origin, float Radius, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Origin;
                *((float*)(b+32)) = Radius;
                *((IntPtr*)(b+40)) = NavData;
                *((IntPtr*)(b+48)) = FilterClass;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, K2_GetRandomReachablePointInRadius_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+20)),*((bool*)(b+56)));
            }
        }
        internal struct K2_ProjectPointToNavigation_method {
            static internal IntPtr K2_ProjectPointToNavigation_ptr;
            static K2_ProjectPointToNavigation_method() {
                K2_ProjectPointToNavigation_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "K2_ProjectPointToNavigation");
            }

            internal static unsafe (Vector, bool) Invoke(UObject WorldContextObject, Vector Point, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass, Vector QueryExtent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Point;
                *((IntPtr*)(b+32)) = NavData;
                *((IntPtr*)(b+40)) = FilterClass;
                *((Vector*)(b+48)) = QueryExtent;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, K2_ProjectPointToNavigation_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+20)),*((bool*)(b+60)));
            }
        }
        internal struct NavigationRaycast_method {
            static internal IntPtr NavigationRaycast_ptr;
            static NavigationRaycast_method() {
                NavigationRaycast_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "NavigationRaycast");
            }

            internal static unsafe (Vector, bool) Invoke(UObject WorldContextObject, Vector RayStart, Vector RayEnd, SubclassOf<NavigationQueryFilter> FilterClass, Controller Querier) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = RayStart;
                *((Vector*)(b+20)) = RayEnd;
                *((IntPtr*)(b+48)) = FilterClass;
                *((IntPtr*)(b+56)) = Querier;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, NavigationRaycast_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+32)),*((bool*)(b+64)));
            }
        }
        internal struct OnNavigationBoundsUpdated_method {
            static internal IntPtr OnNavigationBoundsUpdated_ptr;
            static OnNavigationBoundsUpdated_method() {
                OnNavigationBoundsUpdated_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "OnNavigationBoundsUpdated");
            }

            internal static unsafe void Invoke(IntPtr obj, NavMeshBoundsVolume NavVolume) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NavVolume;
                Main.GetProcessEvent(obj, OnNavigationBoundsUpdated_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ProjectPointToNavigation_method {
            static internal IntPtr ProjectPointToNavigation_ptr;
            static ProjectPointToNavigation_method() {
                ProjectPointToNavigation_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "ProjectPointToNavigation");
            }

            internal static unsafe Vector Invoke(UObject WorldContextObject, Vector Point, NavigationData NavData, SubclassOf<NavigationQueryFilter> FilterClass, Vector QueryExtent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Point;
                *((IntPtr*)(b+24)) = NavData;
                *((IntPtr*)(b+32)) = FilterClass;
                *((Vector*)(b+40)) = QueryExtent;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, ProjectPointToNavigation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+52));
            }
        }
        internal struct RegisterNavigationInvoker_method {
            static internal IntPtr RegisterNavigationInvoker_ptr;
            static RegisterNavigationInvoker_method() {
                RegisterNavigationInvoker_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "RegisterNavigationInvoker");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor Invoker, float TileGenerationRadius, float TileRemovalRadius) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Invoker;
                *((float*)(b+8)) = TileGenerationRadius;
                *((float*)(b+12)) = TileRemovalRadius;
                Main.GetProcessEvent(obj, RegisterNavigationInvoker_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetMaxSimultaneousTileGenerationJobsCount_method {
            static internal IntPtr ResetMaxSimultaneousTileGenerationJobsCount_ptr;
            static ResetMaxSimultaneousTileGenerationJobsCount_method() {
                ResetMaxSimultaneousTileGenerationJobsCount_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "ResetMaxSimultaneousTileGenerationJobsCount");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetMaxSimultaneousTileGenerationJobsCount_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGeometryGatheringMode_method {
            static internal IntPtr SetGeometryGatheringMode_ptr;
            static SetGeometryGatheringMode_method() {
                SetGeometryGatheringMode_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "SetGeometryGatheringMode");
            }

            internal static unsafe void Invoke(IntPtr obj, ENavDataGatheringModeConfig NewMode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)NewMode;
                Main.GetProcessEvent(obj, SetGeometryGatheringMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaxSimultaneousTileGenerationJobsCount_method {
            static internal IntPtr SetMaxSimultaneousTileGenerationJobsCount_ptr;
            static SetMaxSimultaneousTileGenerationJobsCount_method() {
                SetMaxSimultaneousTileGenerationJobsCount_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "SetMaxSimultaneousTileGenerationJobsCount");
            }

            internal static unsafe void Invoke(IntPtr obj, int MaxNumberOfJobs) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MaxNumberOfJobs;
                Main.GetProcessEvent(obj, SetMaxSimultaneousTileGenerationJobsCount_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SimpleMoveToActor_method {
            static internal IntPtr SimpleMoveToActor_ptr;
            static SimpleMoveToActor_method() {
                SimpleMoveToActor_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "SimpleMoveToActor");
            }

            internal static unsafe void Invoke(Controller Controller, Actor Goal) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                *((IntPtr*)(b+8)) = Goal;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, SimpleMoveToActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SimpleMoveToLocation_method {
            static internal IntPtr SimpleMoveToLocation_ptr;
            static SimpleMoveToLocation_method() {
                SimpleMoveToLocation_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "SimpleMoveToLocation");
            }

            internal static unsafe void Invoke(Controller Controller, Vector Goal) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                *((Vector*)(b+8)) = Goal;
                Main.GetProcessEvent(NavigationSystemV1.DefaultObject, SimpleMoveToLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnregisterNavigationInvoker_method {
            static internal IntPtr UnregisterNavigationInvoker_ptr;
            static UnregisterNavigationInvoker_method() {
                UnregisterNavigationInvoker_ptr = Main.GetMethodUFunction(NavigationSystemV1.StaticClass, "UnregisterNavigationInvoker");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor Invoker) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Invoker;
                Main.GetProcessEvent(obj, UnregisterNavigationInvoker_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct NavigationSystemV1_events {
    }
}
