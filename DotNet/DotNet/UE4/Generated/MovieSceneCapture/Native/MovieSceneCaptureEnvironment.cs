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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MovieSceneCaptureEnvironment_fields {
    }
    internal unsafe struct MovieSceneCaptureEnvironment_methods {
        internal struct FindAudioCaptureProtocol_method {
            static internal IntPtr FindAudioCaptureProtocol_ptr;
            static FindAudioCaptureProtocol_method() {
                FindAudioCaptureProtocol_ptr = Main.GetMethodUFunction(MovieSceneCaptureEnvironment.StaticClass, "FindAudioCaptureProtocol");
            }

            internal static unsafe MovieSceneAudioCaptureProtocolBase Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MovieSceneCaptureEnvironment.DefaultObject, FindAudioCaptureProtocol_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct FindImageCaptureProtocol_method {
            static internal IntPtr FindImageCaptureProtocol_ptr;
            static FindImageCaptureProtocol_method() {
                FindImageCaptureProtocol_ptr = Main.GetMethodUFunction(MovieSceneCaptureEnvironment.StaticClass, "FindImageCaptureProtocol");
            }

            internal static unsafe MovieSceneImageCaptureProtocolBase Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MovieSceneCaptureEnvironment.DefaultObject, FindImageCaptureProtocol_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetCaptureElapsedTime_method {
            static internal IntPtr GetCaptureElapsedTime_ptr;
            static GetCaptureElapsedTime_method() {
                GetCaptureElapsedTime_ptr = Main.GetMethodUFunction(MovieSceneCaptureEnvironment.StaticClass, "GetCaptureElapsedTime");
            }

            internal static unsafe float Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MovieSceneCaptureEnvironment.DefaultObject, GetCaptureElapsedTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetCaptureFrameNumber_method {
            static internal IntPtr GetCaptureFrameNumber_ptr;
            static GetCaptureFrameNumber_method() {
                GetCaptureFrameNumber_ptr = Main.GetMethodUFunction(MovieSceneCaptureEnvironment.StaticClass, "GetCaptureFrameNumber");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MovieSceneCaptureEnvironment.DefaultObject, GetCaptureFrameNumber_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct IsCaptureInProgress_method {
            static internal IntPtr IsCaptureInProgress_ptr;
            static IsCaptureInProgress_method() {
                IsCaptureInProgress_ptr = Main.GetMethodUFunction(MovieSceneCaptureEnvironment.StaticClass, "IsCaptureInProgress");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MovieSceneCaptureEnvironment.DefaultObject, IsCaptureInProgress_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct MovieSceneCaptureEnvironment_events {
    }
}
