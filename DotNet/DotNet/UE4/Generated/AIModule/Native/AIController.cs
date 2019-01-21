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

using UE4.GameplayTasks;
using UE4.Engine;
using UE4.NavigationSystem;

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=1288 )]
    internal unsafe struct AIController_fields {
        [FieldOffset(1200)] public bool bStopAILogicOnUnposses;
        [FieldOffset(1200)] public bool bLOSflag;
        [FieldOffset(1200)] public bool bSkipExtraLOSChecks;
        [FieldOffset(1200)] public bool bAllowStrafe;
        [FieldOffset(1200)] public bool bWantsPlayerState;
        [FieldOffset(1200)] public bool bSetControlRotationFromPawnOrientation;
        [FieldOffset(1208)]  public IntPtr  PathFollowingComponent;
        [FieldOffset(1216)]  public IntPtr  BrainComponent;
        [FieldOffset(1224)]  public IntPtr  PerceptionComponent;
        [FieldOffset(1232)]  public IntPtr  ActionsComp;
        [FieldOffset(1240)]  public IntPtr  Blackboard;
        [FieldOffset(1248)]  public IntPtr  CachedGameplayTasksComponent;
        [FieldOffset(1256)] public IntPtr DefaultNavigationFilterClass;
        [FieldOffset(1264)] byte ReceiveMoveCompleted; //TODO: multicast delegate FAIMoveCompletedSignature ReceiveMoveCompleted
    }
    internal unsafe struct AIController_methods {
        internal struct ClaimTaskResource_method {
            static internal IntPtr ClaimTaskResource_ptr;
            static ClaimTaskResource_method() {
                ClaimTaskResource_ptr = Main.GetMethodUFunction(AIController.StaticClass, "ClaimTaskResource");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<GameplayTaskResource> ResourceClass) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ResourceClass;
                Main.GetProcessEvent(obj, ClaimTaskResource_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetAIPerceptionComponent_method {
            static internal IntPtr GetAIPerceptionComponent_ptr;
            static GetAIPerceptionComponent_method() {
                GetAIPerceptionComponent_ptr = Main.GetMethodUFunction(AIController.StaticClass, "GetAIPerceptionComponent");
            }

            internal static unsafe AIPerceptionComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAIPerceptionComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetFocalPoint_method {
            static internal IntPtr GetFocalPoint_ptr;
            static GetFocalPoint_method() {
                GetFocalPoint_ptr = Main.GetMethodUFunction(AIController.StaticClass, "GetFocalPoint");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFocalPoint_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetFocalPointOnActor_method {
            static internal IntPtr GetFocalPointOnActor_ptr;
            static GetFocalPointOnActor_method() {
                GetFocalPointOnActor_ptr = Main.GetMethodUFunction(AIController.StaticClass, "GetFocalPointOnActor");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Actor Actor) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Actor;
                Main.GetProcessEvent(obj, GetFocalPointOnActor_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetFocusActor_method {
            static internal IntPtr GetFocusActor_ptr;
            static GetFocusActor_method() {
                GetFocusActor_ptr = Main.GetMethodUFunction(AIController.StaticClass, "GetFocusActor");
            }

            internal static unsafe Actor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFocusActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetImmediateMoveDestination_method {
            static internal IntPtr GetImmediateMoveDestination_ptr;
            static GetImmediateMoveDestination_method() {
                GetImmediateMoveDestination_ptr = Main.GetMethodUFunction(AIController.StaticClass, "GetImmediateMoveDestination");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetImmediateMoveDestination_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetMoveStatus_method {
            static internal IntPtr GetMoveStatus_ptr;
            static GetMoveStatus_method() {
                GetMoveStatus_ptr = Main.GetMethodUFunction(AIController.StaticClass, "GetMoveStatus");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMoveStatus_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetPathFollowingComponent_method {
            static internal IntPtr GetPathFollowingComponent_ptr;
            static GetPathFollowingComponent_method() {
                GetPathFollowingComponent_ptr = Main.GetMethodUFunction(AIController.StaticClass, "GetPathFollowingComponent");
            }

            internal static unsafe PathFollowingComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPathFollowingComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct HasPartialPath_method {
            static internal IntPtr HasPartialPath_ptr;
            static HasPartialPath_method() {
                HasPartialPath_ptr = Main.GetMethodUFunction(AIController.StaticClass, "HasPartialPath");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasPartialPath_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_ClearFocus_method {
            static internal IntPtr K2_ClearFocus_ptr;
            static K2_ClearFocus_method() {
                K2_ClearFocus_ptr = Main.GetMethodUFunction(AIController.StaticClass, "K2_ClearFocus");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_ClearFocus_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_SetFocalPoint_method {
            static internal IntPtr K2_SetFocalPoint_ptr;
            static K2_SetFocalPoint_method() {
                K2_SetFocalPoint_ptr = Main.GetMethodUFunction(AIController.StaticClass, "K2_SetFocalPoint");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector FP) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = FP;
                Main.GetProcessEvent(obj, K2_SetFocalPoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_SetFocus_method {
            static internal IntPtr K2_SetFocus_ptr;
            static K2_SetFocus_method() {
                K2_SetFocus_ptr = Main.GetMethodUFunction(AIController.StaticClass, "K2_SetFocus");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor NewFocus) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewFocus;
                Main.GetProcessEvent(obj, K2_SetFocus_ptr, new IntPtr(p)); ;
            }
        }
        internal struct MoveToActor_method {
            static internal IntPtr MoveToActor_ptr;
            static MoveToActor_method() {
                MoveToActor_ptr = Main.GetMethodUFunction(AIController.StaticClass, "MoveToActor");
            }

            internal static unsafe byte Invoke(IntPtr obj, Actor Goal, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bCanStrafe, SubclassOf<NavigationQueryFilter> FilterClass, bool bAllowPartialPath) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Goal;
                *((float*)(b+8)) = AcceptanceRadius;
                *((bool*)(b+12)) = bStopOnOverlap;
                *((bool*)(b+13)) = bUsePathfinding;
                *((bool*)(b+14)) = bCanStrafe;
                *((IntPtr*)(b+16)) = FilterClass;
                *((bool*)(b+24)) = bAllowPartialPath;
                Main.GetProcessEvent(obj, MoveToActor_ptr, new IntPtr(p)); ;
                return *(b+25);
            }
        }
        internal struct MoveToLocation_method {
            static internal IntPtr MoveToLocation_ptr;
            static MoveToLocation_method() {
                MoveToLocation_ptr = Main.GetMethodUFunction(AIController.StaticClass, "MoveToLocation");
            }

            internal static unsafe byte Invoke(IntPtr obj, Vector Dest, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bProjectDestinationToNavigation, bool bCanStrafe, SubclassOf<NavigationQueryFilter> FilterClass, bool bAllowPartialPath) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Dest;
                *((float*)(b+12)) = AcceptanceRadius;
                *((bool*)(b+16)) = bStopOnOverlap;
                *((bool*)(b+17)) = bUsePathfinding;
                *((bool*)(b+18)) = bProjectDestinationToNavigation;
                *((bool*)(b+19)) = bCanStrafe;
                *((IntPtr*)(b+24)) = FilterClass;
                *((bool*)(b+32)) = bAllowPartialPath;
                Main.GetProcessEvent(obj, MoveToLocation_ptr, new IntPtr(p)); ;
                return *(b+33);
            }
        }
        internal struct RunBehaviorTree_method {
            static internal IntPtr RunBehaviorTree_ptr;
            static RunBehaviorTree_method() {
                RunBehaviorTree_ptr = Main.GetMethodUFunction(AIController.StaticClass, "RunBehaviorTree");
            }

            internal static unsafe bool Invoke(IntPtr obj, BehaviorTree BTAsset) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = BTAsset;
                Main.GetProcessEvent(obj, RunBehaviorTree_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct SetMoveBlockDetection_method {
            static internal IntPtr SetMoveBlockDetection_ptr;
            static SetMoveBlockDetection_method() {
                SetMoveBlockDetection_ptr = Main.GetMethodUFunction(AIController.StaticClass, "SetMoveBlockDetection");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnable;
                Main.GetProcessEvent(obj, SetMoveBlockDetection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPathFollowingComponent_method {
            static internal IntPtr SetPathFollowingComponent_ptr;
            static SetPathFollowingComponent_method() {
                SetPathFollowingComponent_ptr = Main.GetMethodUFunction(AIController.StaticClass, "SetPathFollowingComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, PathFollowingComponent NewPFComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewPFComponent;
                Main.GetProcessEvent(obj, SetPathFollowingComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnclaimTaskResource_method {
            static internal IntPtr UnclaimTaskResource_ptr;
            static UnclaimTaskResource_method() {
                UnclaimTaskResource_ptr = Main.GetMethodUFunction(AIController.StaticClass, "UnclaimTaskResource");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<GameplayTaskResource> ResourceClass) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ResourceClass;
                Main.GetProcessEvent(obj, UnclaimTaskResource_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UseBlackboard_method {
            static internal IntPtr UseBlackboard_ptr;
            static UseBlackboard_method() {
                UseBlackboard_ptr = Main.GetMethodUFunction(AIController.StaticClass, "UseBlackboard");
            }

            internal static unsafe (BlackboardComponent, bool) Invoke(IntPtr obj, BlackboardData BlackboardAsset) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = BlackboardAsset;
                Main.GetProcessEvent(obj, UseBlackboard_ptr, new IntPtr(p)); ;
                return (*((IntPtr*)(b+8)),*((bool*)(b+16)));
            }
        }
    }
    internal unsafe struct AIController_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnPossess_event {
            private static DelegateHolder<NativeFuncDelegate> OnPossess_link;
            private static unsafe void OnPossess_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AIController>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnPossess(UObject.Make<Pawn>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                OnPossess_link = new DelegateHolder<NativeFuncDelegate>(OnPossess_process_event);
                var uf = Main.GetUFunction("OnPossess");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnPossess_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnUnpossess_event {
            private static DelegateHolder<NativeFuncDelegate> OnUnpossess_link;
            private static unsafe void OnUnpossess_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AIController>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnUnpossess(UObject.Make<Pawn>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                OnUnpossess_link = new DelegateHolder<NativeFuncDelegate>(OnUnpossess_process_event);
                var uf = Main.GetUFunction("OnUnpossess");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnUnpossess_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct OnUsingBlackBoard_event {
            private static DelegateHolder<NativeFuncDelegate> OnUsingBlackBoard_link;
            private static unsafe void OnUsingBlackBoard_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AIController>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnUsingBlackBoard(UObject.Make<BlackboardComponent>(*(IntPtr*)(b+0)), UObject.Make<BlackboardData>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                OnUsingBlackBoard_link = new DelegateHolder<NativeFuncDelegate>(OnUsingBlackBoard_process_event);
                var uf = Main.GetUFunction("OnUsingBlackBoard");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnUsingBlackBoard_link.Delegate));
            }
        }
    }
}
