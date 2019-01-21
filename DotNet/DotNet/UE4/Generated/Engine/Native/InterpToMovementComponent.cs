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
    [StructLayout( LayoutKind.Explicit, Size=480 )]
    internal unsafe struct InterpToMovementComponent_fields {
        [FieldOffset(320)] public float Duration;
        [FieldOffset(324)] public bool bPauseOnImpact;
        [FieldOffset(328)] byte BehaviourType; //TODO: enum EInterpToBehaviourType BehaviourType
        [FieldOffset(332)] public bool bForceSubStepping;
        [FieldOffset(336)] byte OnInterpToReverse; //TODO: multicast delegate FOnInterpToReverseDelegate OnInterpToReverse
        [FieldOffset(352)] byte OnInterpToStop; //TODO: multicast delegate FOnInterpToStopDelegate OnInterpToStop
        [FieldOffset(368)] byte OnWaitBeginDelegate; //TODO: multicast delegate FOnInterpToWaitBeginDelegate OnWaitBeginDelegate
        [FieldOffset(384)] byte OnWaitEndDelegate; //TODO: multicast delegate FOnInterpToWaitEndDelegate OnWaitEndDelegate
        [FieldOffset(400)] byte OnResetDelegate; //TODO: multicast delegate FOnInterpToResetDelegate OnResetDelegate
        [FieldOffset(416)] public float MaxSimulationTimeStep;
        [FieldOffset(420)] public int MaxSimulationIterations;
        [FieldOffset(424)] public NativeArray ControlPoints;
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
