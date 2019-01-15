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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=488 )]
    internal unsafe struct InterpToMovementComponent_fields {
        [FieldOffset(328)] public float Duration;
        [FieldOffset(332)] public bool bPauseOnImpact;
        [FieldOffset(336)] byte BehaviourType; //TODO: enum EInterpToBehaviourType BehaviourType
        [FieldOffset(340)] public bool bForceSubStepping;
        [FieldOffset(344)] byte OnInterpToReverse; //TODO: multicast delegate FOnInterpToReverseDelegate OnInterpToReverse
        [FieldOffset(360)] byte OnInterpToStop; //TODO: multicast delegate FOnInterpToStopDelegate OnInterpToStop
        [FieldOffset(376)] byte OnWaitBeginDelegate; //TODO: multicast delegate FOnInterpToWaitBeginDelegate OnWaitBeginDelegate
        [FieldOffset(392)] byte OnWaitEndDelegate; //TODO: multicast delegate FOnInterpToWaitEndDelegate OnWaitEndDelegate
        [FieldOffset(408)] byte OnResetDelegate; //TODO: multicast delegate FOnInterpToResetDelegate OnResetDelegate
        [FieldOffset(424)] public float MaxSimulationTimeStep;
        [FieldOffset(428)] public int MaxSimulationIterations;
        [FieldOffset(432)] public NativeArray ControlPoints;
    }
    internal unsafe struct InterpToMovementComponent_methods {
        internal struct FinaliseControlPoints_method {
            static internal IntPtr FinaliseControlPoints_ptr;
            static FinaliseControlPoints_method() {
                FinaliseControlPoints_ptr = Main.GetMethodUFunction(InterpToMovementComponent.StaticClass, "FinaliseControlPoints");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, FinaliseControlPoints_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RestartMovement_method {
            static internal IntPtr RestartMovement_ptr;
            static RestartMovement_method() {
                RestartMovement_ptr = Main.GetMethodUFunction(InterpToMovementComponent.StaticClass, "RestartMovement");
            }

            internal static unsafe void Invoke(IntPtr obj, float InitialDirection) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InitialDirection;
                Main.GetProcessEvent(obj, RestartMovement_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopSimulating_method {
            static internal IntPtr StopSimulating_ptr;
            static StopSimulating_method() {
                StopSimulating_ptr = Main.GetMethodUFunction(InterpToMovementComponent.StaticClass, "StopSimulating");
            }

            internal static unsafe void Invoke(IntPtr obj, HitResult HitResult) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((HitResult*)(b+0)) = HitResult;
                Main.GetProcessEvent(obj, StopSimulating_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct InterpToMovementComponent_events {
    }
}
