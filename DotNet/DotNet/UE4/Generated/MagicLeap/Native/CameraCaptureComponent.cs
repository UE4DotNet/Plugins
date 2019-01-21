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


namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=376 )]
    internal unsafe struct CameraCaptureComponent_fields {
        [FieldOffset(264)] byte CaptureLogMessage; //TODO: multicast delegate FCameraCaptureLogMessage CaptureLogMessage
        [FieldOffset(280)] byte CaptureImgToFileSuccess; //TODO: multicast delegate FCameraCaptureImgToFileSuccess CaptureImgToFileSuccess
        [FieldOffset(296)] byte CaptureImgToFileFailure; //TODO: multicast delegate FCameraCaptureImgToFileFailure CaptureImgToFileFailure
        [FieldOffset(312)] byte CaptureImgToTextureSuccess; //TODO: multicast delegate FCameraCaptureImgToTextureSuccess CaptureImgToTextureSuccess
        [FieldOffset(328)] byte CaptureImgToTextureFailure; //TODO: multicast delegate FCameraCaptureImgToTextureFailure CaptureImgToTextureFailure
        [FieldOffset(344)] byte CaptureVidToFileSuccess; //TODO: multicast delegate FCameraCaptureVidToFileSuccess CaptureVidToFileSuccess
        [FieldOffset(360)] byte CaptureVidToFileFailure; //TODO: multicast delegate FCameraCaptureVidToFileFailure CaptureVidToFileFailure
    }
    internal unsafe struct CameraCaptureComponent_methods {
        internal struct CaptureImageToFileAsync_method {
            static internal IntPtr CaptureImageToFileAsync_ptr;
            static CaptureImageToFileAsync_method() {
                CaptureImageToFileAsync_ptr = Main.GetMethodUFunction(CameraCaptureComponent.StaticClass, "CaptureImageToFileAsync");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CaptureImageToFileAsync_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct CaptureImageToTextureAsync_method {
            static internal IntPtr CaptureImageToTextureAsync_ptr;
            static CaptureImageToTextureAsync_method() {
                CaptureImageToTextureAsync_ptr = Main.GetMethodUFunction(CameraCaptureComponent.StaticClass, "CaptureImageToTextureAsync");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CaptureImageToTextureAsync_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct CaptureVideoToFileAsync_method {
            static internal IntPtr CaptureVideoToFileAsync_ptr;
            static CaptureVideoToFileAsync_method() {
                CaptureVideoToFileAsync_ptr = Main.GetMethodUFunction(CameraCaptureComponent.StaticClass, "CaptureVideoToFileAsync");
            }

            internal static unsafe bool Invoke(IntPtr obj, float VideoLength) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = VideoLength;
                Main.GetProcessEvent(obj, CaptureVideoToFileAsync_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
    }
    internal unsafe struct CameraCaptureComponent_events {
    }
}
