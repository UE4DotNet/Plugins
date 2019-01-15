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

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=304 )]
    internal unsafe struct AITask_MoveTo_fields {
        [FieldOffset(144)] byte OnRequestFailed; //TODO: multicast delegate FGenericGameplayTaskDelegate OnRequestFailed
        [FieldOffset(160)] byte OnMoveFinished; //TODO: multicast delegate FMoveTaskCompletedSignature OnMoveFinished
        [FieldOffset(176)] public AIMoveRequest MoveRequest;
    }
    internal unsafe struct AITask_MoveTo_methods {
        internal struct AIMoveTo_method {
            static internal IntPtr AIMoveTo_ptr;
            static AIMoveTo_method() {
                AIMoveTo_ptr = Main.GetMethodUFunction(AITask_MoveTo.StaticClass, "AIMoveTo");
            }

            internal static unsafe AITask_MoveTo Invoke(AIController Controller, Vector GoalLocation, Actor GoalActor, float AcceptanceRadius, byte StopOnOverlap, byte AcceptPartialPath, bool bUsePathfinding, bool bLockAILogic, bool bUseContinuosGoalTracking) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                *((Vector*)(b+8)) = GoalLocation;
                *((IntPtr*)(b+24)) = GoalActor;
                *((float*)(b+32)) = AcceptanceRadius;
                *(b+36) = StopOnOverlap;
                *(b+37) = AcceptPartialPath;
                *((bool*)(b+38)) = bUsePathfinding;
                *((bool*)(b+39)) = bLockAILogic;
                *((bool*)(b+40)) = bUseContinuosGoalTracking;
                Main.GetProcessEvent(AITask_MoveTo.DefaultObject, AIMoveTo_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+48));
            }
        }
    }
    internal unsafe struct AITask_MoveTo_events {
    }
}
