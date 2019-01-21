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
    [StructLayout( LayoutKind.Explicit, Size=528 )]
    internal unsafe struct MovieSceneCapture_fields {
        [FieldOffset(72)] public SoftClassPath ImageCaptureProtocolType;
        [FieldOffset(104)] public SoftClassPath AudioCaptureProtocolType;
        [FieldOffset(136)]  public IntPtr  ImageCaptureProtocol;
        [FieldOffset(144)]  public IntPtr  AudioCaptureProtocol;
        [FieldOffset(152)] public MovieSceneCaptureSettings Settings;
        [FieldOffset(232)] public bool bUseSeparateProcess;
        [FieldOffset(233)] public bool bCloseEditorWhenCaptureStarts;
        [FieldOffset(240)] byte AdditionalCommandLineArguments; //TODO: string FString AdditionalCommandLineArguments
        [FieldOffset(256)] byte InheritedCommandLineArguments; //TODO: string FString InheritedCommandLineArguments
    }
    internal unsafe struct MovieSceneCapture_methods {
        internal struct GetAudioCaptureProtocol_method {
            static internal IntPtr GetAudioCaptureProtocol_ptr;
            static GetAudioCaptureProtocol_method() {
                GetAudioCaptureProtocol_ptr = Main.GetMethodUFunction(MovieSceneCapture.StaticClass, "GetAudioCaptureProtocol");
            }

            internal static unsafe MovieSceneCaptureProtocolBase Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAudioCaptureProtocol_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetImageCaptureProtocol_method {
            static internal IntPtr GetImageCaptureProtocol_ptr;
            static GetImageCaptureProtocol_method() {
                GetImageCaptureProtocol_ptr = Main.GetMethodUFunction(MovieSceneCapture.StaticClass, "GetImageCaptureProtocol");
            }

            internal static unsafe MovieSceneCaptureProtocolBase Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetImageCaptureProtocol_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SetAudioCaptureProtocolType_method {
            static internal IntPtr SetAudioCaptureProtocolType_ptr;
            static SetAudioCaptureProtocolType_method() {
                SetAudioCaptureProtocolType_ptr = Main.GetMethodUFunction(MovieSceneCapture.StaticClass, "SetAudioCaptureProtocolType");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<MovieSceneCaptureProtocolBase> ProtocolType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ProtocolType;
                Main.GetProcessEvent(obj, SetAudioCaptureProtocolType_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetImageCaptureProtocolType_method {
            static internal IntPtr SetImageCaptureProtocolType_ptr;
            static SetImageCaptureProtocolType_method() {
                SetImageCaptureProtocolType_ptr = Main.GetMethodUFunction(MovieSceneCapture.StaticClass, "SetImageCaptureProtocolType");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<MovieSceneCaptureProtocolBase> ProtocolType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ProtocolType;
                Main.GetProcessEvent(obj, SetImageCaptureProtocolType_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MovieSceneCapture_events {
    }
}
