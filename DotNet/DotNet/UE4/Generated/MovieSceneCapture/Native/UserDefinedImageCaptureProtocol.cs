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

namespace UE4.MovieSceneCapture.Native {
    [StructLayout( LayoutKind.Explicit, Size=256 )]
    internal unsafe struct UserDefinedImageCaptureProtocol_fields {
        [FieldOffset(248)] byte Format; //TODO: enum EDesiredImageFormat Format
        [FieldOffset(249)] public bool bEnableCompression;
        [FieldOffset(252)] public int CompressionQuality;
    }
    internal unsafe struct UserDefinedImageCaptureProtocol_methods {
        internal struct GenerateFilenameForBuffer_method {
            static internal IntPtr GenerateFilenameForBuffer_ptr;
            static GenerateFilenameForBuffer_method() {
                GenerateFilenameForBuffer_ptr = Main.GetMethodUFunction(UserDefinedImageCaptureProtocol.StaticClass, "GenerateFilenameForBuffer");
            }

            internal static unsafe string Invoke(IntPtr obj, Texture Buffer, Name StreamName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Buffer;
                *((Name*)(b+8)) = StreamName;
                Main.GetProcessEvent(obj, GenerateFilenameForBuffer_ptr, new IntPtr(p)); ;
                return FString.Get(b+24);
            }
        }
        internal struct GenerateFilenameForCurrentFrame_method {
            static internal IntPtr GenerateFilenameForCurrentFrame_ptr;
            static GenerateFilenameForCurrentFrame_method() {
                GenerateFilenameForCurrentFrame_ptr = Main.GetMethodUFunction(UserDefinedImageCaptureProtocol.StaticClass, "GenerateFilenameForCurrentFrame");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GenerateFilenameForCurrentFrame_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct WriteImageToDisk_method {
            static internal IntPtr WriteImageToDisk_ptr;
            static WriteImageToDisk_method() {
                WriteImageToDisk_ptr = Main.GetMethodUFunction(UserDefinedImageCaptureProtocol.StaticClass, "WriteImageToDisk");
            }

            internal static unsafe void Invoke(IntPtr obj, CapturedPixels PixelData, Name StreamName, FrameMetrics FrameMetrics, bool bCopyImageData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((CapturedPixels*)(b+0)) = PixelData;
                *((Name*)(b+16)) = StreamName;
                *((FrameMetrics*)(b+28)) = FrameMetrics;
                *((bool*)(b+44)) = bCopyImageData;
                Main.GetProcessEvent(obj, WriteImageToDisk_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct UserDefinedImageCaptureProtocol_events {
    }
}
