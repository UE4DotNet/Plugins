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


namespace UE4.MediaAssets.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MediaBlueprintFunctionLibrary_fields {
    }
    internal unsafe struct MediaBlueprintFunctionLibrary_methods {
        internal struct EnumerateAudioCaptureDevices_method {
            static internal IntPtr EnumerateAudioCaptureDevices_ptr;
            static EnumerateAudioCaptureDevices_method() {
                EnumerateAudioCaptureDevices_ptr = Main.GetMethodUFunction(MediaBlueprintFunctionLibrary.StaticClass, "EnumerateAudioCaptureDevices");
            }

            internal static unsafe IReadOnlyCollection<MediaCaptureDevice> Invoke(int Filter) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+16)) = Filter;
                Main.GetProcessEvent(MediaBlueprintFunctionLibrary.DefaultObject, EnumerateAudioCaptureDevices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutDevices
                return UObject.ToUnmangedCollection<MediaCaptureDevice>(b+0);
            }
        }
        internal struct EnumerateVideoCaptureDevices_method {
            static internal IntPtr EnumerateVideoCaptureDevices_ptr;
            static EnumerateVideoCaptureDevices_method() {
                EnumerateVideoCaptureDevices_ptr = Main.GetMethodUFunction(MediaBlueprintFunctionLibrary.StaticClass, "EnumerateVideoCaptureDevices");
            }

            internal static unsafe IReadOnlyCollection<MediaCaptureDevice> Invoke(int Filter) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+16)) = Filter;
                Main.GetProcessEvent(MediaBlueprintFunctionLibrary.DefaultObject, EnumerateVideoCaptureDevices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutDevices
                return UObject.ToUnmangedCollection<MediaCaptureDevice>(b+0);
            }
        }
        internal struct EnumerateWebcamCaptureDevices_method {
            static internal IntPtr EnumerateWebcamCaptureDevices_ptr;
            static EnumerateWebcamCaptureDevices_method() {
                EnumerateWebcamCaptureDevices_ptr = Main.GetMethodUFunction(MediaBlueprintFunctionLibrary.StaticClass, "EnumerateWebcamCaptureDevices");
            }

            internal static unsafe IReadOnlyCollection<MediaCaptureDevice> Invoke(int Filter) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+16)) = Filter;
                Main.GetProcessEvent(MediaBlueprintFunctionLibrary.DefaultObject, EnumerateWebcamCaptureDevices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutDevices
                return UObject.ToUnmangedCollection<MediaCaptureDevice>(b+0);
            }
        }
    }
    internal unsafe struct MediaBlueprintFunctionLibrary_events {
    }
}
