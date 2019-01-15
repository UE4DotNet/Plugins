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
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct AISense_Prediction_fields {
        [FieldOffset(152)] public NativeArray RegisteredEvents;
    }
    internal unsafe struct AISense_Prediction_methods {
        internal struct RequestControllerPredictionEvent_method {
            static internal IntPtr RequestControllerPredictionEvent_ptr;
            static RequestControllerPredictionEvent_method() {
                RequestControllerPredictionEvent_ptr = Main.GetMethodUFunction(AISense_Prediction.StaticClass, "RequestControllerPredictionEvent");
            }

            internal static unsafe void Invoke(AIController Requestor, Actor PredictedActor, float PredictionTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Requestor;
                *((IntPtr*)(b+8)) = PredictedActor;
                *((float*)(b+16)) = PredictionTime;
                Main.GetProcessEvent(AISense_Prediction.DefaultObject, RequestControllerPredictionEvent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RequestPawnPredictionEvent_method {
            static internal IntPtr RequestPawnPredictionEvent_ptr;
            static RequestPawnPredictionEvent_method() {
                RequestPawnPredictionEvent_ptr = Main.GetMethodUFunction(AISense_Prediction.StaticClass, "RequestPawnPredictionEvent");
            }

            internal static unsafe void Invoke(Pawn Requestor, Actor PredictedActor, float PredictionTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Requestor;
                *((IntPtr*)(b+8)) = PredictedActor;
                *((float*)(b+16)) = PredictionTime;
                Main.GetProcessEvent(AISense_Prediction.DefaultObject, RequestPawnPredictionEvent_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AISense_Prediction_events {
    }
}
