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
using UE4.NavigationSystem;

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct AIBlueprintHelperLibrary_fields {
    }
    internal unsafe struct AIBlueprintHelperLibrary_methods {
        internal struct CreateMoveToProxyObject_method {
            static internal IntPtr CreateMoveToProxyObject_ptr;
            static CreateMoveToProxyObject_method() {
                CreateMoveToProxyObject_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "CreateMoveToProxyObject");
            }

            internal static unsafe AIAsyncTaskBlueprintProxy Invoke(UObject WorldContextObject, Pawn Pawn, Vector Destination, Actor TargetActor, float AcceptanceRadius, bool bStopOnOverlap) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Pawn;
                *((Vector*)(b+16)) = Destination;
                *((IntPtr*)(b+32)) = TargetActor;
                *((float*)(b+40)) = AcceptanceRadius;
                *((bool*)(b+44)) = bStopOnOverlap;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, CreateMoveToProxyObject_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+48));
            }
        }
        internal struct GetAIController_method {
            static internal IntPtr GetAIController_ptr;
            static GetAIController_method() {
                GetAIController_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "GetAIController");
            }

            internal static unsafe AIController Invoke(Actor ControlledActor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ControlledActor;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, GetAIController_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetBlackboard_method {
            static internal IntPtr GetBlackboard_ptr;
            static GetBlackboard_method() {
                GetBlackboard_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "GetBlackboard");
            }

            internal static unsafe BlackboardComponent Invoke(Actor Target) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Target;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, GetBlackboard_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetCurrentPath_method {
            static internal IntPtr GetCurrentPath_ptr;
            static GetCurrentPath_method() {
                GetCurrentPath_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "GetCurrentPath");
            }

            internal static unsafe NavigationPath Invoke(Controller Controller) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, GetCurrentPath_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct IsValidAIDirection_method {
            static internal IntPtr IsValidAIDirection_ptr;
            static IsValidAIDirection_method() {
                IsValidAIDirection_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "IsValidAIDirection");
            }

            internal static unsafe bool Invoke(Vector DirectionVector) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = DirectionVector;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, IsValidAIDirection_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct IsValidAILocation_method {
            static internal IntPtr IsValidAILocation_ptr;
            static IsValidAILocation_method() {
                IsValidAILocation_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "IsValidAILocation");
            }

            internal static unsafe bool Invoke(Vector Location) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Location;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, IsValidAILocation_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct IsValidAIRotation_method {
            static internal IntPtr IsValidAIRotation_ptr;
            static IsValidAIRotation_method() {
                IsValidAIRotation_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "IsValidAIRotation");
            }

            internal static unsafe bool Invoke(Rotator Rotation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = Rotation;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, IsValidAIRotation_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct LockAIResourcesWithAnimation_method {
            static internal IntPtr LockAIResourcesWithAnimation_ptr;
            static LockAIResourcesWithAnimation_method() {
                LockAIResourcesWithAnimation_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "LockAIResourcesWithAnimation");
            }

            internal static unsafe void Invoke(AnimInstance AnimInstance, bool bLockMovement, bool LockAILogic) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimInstance;
                *((bool*)(b+8)) = bLockMovement;
                *((bool*)(b+9)) = LockAILogic;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, LockAIResourcesWithAnimation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SendAIMessage_method {
            static internal IntPtr SendAIMessage_ptr;
            static SendAIMessage_method() {
                SendAIMessage_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "SendAIMessage");
            }

            internal static unsafe void Invoke(Pawn Target, Name Message, UObject MessageSource, bool bSuccess) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Target;
                *((Name*)(b+8)) = Message;
                *((IntPtr*)(b+24)) = MessageSource;
                *((bool*)(b+32)) = bSuccess;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, SendAIMessage_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SimpleMoveToActor_method {
            static internal IntPtr SimpleMoveToActor_ptr;
            static SimpleMoveToActor_method() {
                SimpleMoveToActor_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "SimpleMoveToActor");
            }

            internal static unsafe void Invoke(Controller Controller, Actor Goal) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                *((IntPtr*)(b+8)) = Goal;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, SimpleMoveToActor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SimpleMoveToLocation_method {
            static internal IntPtr SimpleMoveToLocation_ptr;
            static SimpleMoveToLocation_method() {
                SimpleMoveToLocation_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "SimpleMoveToLocation");
            }

            internal static unsafe void Invoke(Controller Controller, Vector Goal) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                *((Vector*)(b+8)) = Goal;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, SimpleMoveToLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SpawnAIFromClass_method {
            static internal IntPtr SpawnAIFromClass_ptr;
            static SpawnAIFromClass_method() {
                SpawnAIFromClass_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "SpawnAIFromClass");
            }

            internal static unsafe Pawn Invoke(UObject WorldContextObject, SubclassOf<Pawn> PawnClass, BehaviorTree BehaviorTree, Vector Location, Rotator Rotation, bool bNoCollisionFail) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PawnClass;
                *((IntPtr*)(b+16)) = BehaviorTree;
                *((Vector*)(b+24)) = Location;
                *((Rotator*)(b+36)) = Rotation;
                *((bool*)(b+48)) = bNoCollisionFail;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, SpawnAIFromClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+56));
            }
        }
        internal struct UnlockAIResourcesWithAnimation_method {
            static internal IntPtr UnlockAIResourcesWithAnimation_ptr;
            static UnlockAIResourcesWithAnimation_method() {
                UnlockAIResourcesWithAnimation_ptr = Main.GetMethodUFunction(AIBlueprintHelperLibrary.StaticClass, "UnlockAIResourcesWithAnimation");
            }

            internal static unsafe void Invoke(AnimInstance AnimInstance, bool bUnlockMovement, bool UnlockAILogic) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimInstance;
                *((bool*)(b+8)) = bUnlockMovement;
                *((bool*)(b+9)) = UnlockAILogic;
                Main.GetProcessEvent(AIBlueprintHelperLibrary.DefaultObject, UnlockAIResourcesWithAnimation_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AIBlueprintHelperLibrary_events {
    }
}
