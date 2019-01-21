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


namespace UE4.MovieSceneCapture.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct MovieSceneCaptureProtocolBase_fields {
        [FieldOffset(96)] byte State; //TODO: enum EMovieSceneCaptureProtocolState State
        [FieldOffset(97)] public bool bFrameRequested;
    }
    internal unsafe struct MovieSceneCaptureProtocolBase_methods {
        internal struct GetState_method {
            static internal IntPtr GetState_ptr;
            static GetState_method() {
                GetState_ptr = Main.GetMethodUFunction(MovieSceneCaptureProtocolBase.StaticClass, "GetState");
            }

            internal static unsafe EMovieSceneCaptureProtocolState Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetState_ptr, new IntPtr(p)); ;
                return *((EMovieSceneCaptureProtocolState*)(b+0));
            }
        }
        internal struct IsCapturing_method {
            static internal IntPtr IsCapturing_ptr;
            static IsCapturing_method() {
                IsCapturing_ptr = Main.GetMethodUFunction(MovieSceneCaptureProtocolBase.StaticClass, "IsCapturing");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsCapturing_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct MovieSceneCaptureProtocolBase_events {
    }
}
