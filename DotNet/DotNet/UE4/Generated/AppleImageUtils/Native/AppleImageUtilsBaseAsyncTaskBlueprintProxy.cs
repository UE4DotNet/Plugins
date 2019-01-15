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

namespace UE4.AppleImageUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct AppleImageUtilsBaseAsyncTaskBlueprintProxy_fields {
        [FieldOffset(64)] byte OnSuccess; //TODO: multicast delegate FAppleImageConversionDelegate OnSuccess
        [FieldOffset(80)] byte OnFailure; //TODO: multicast delegate FAppleImageConversionDelegate OnFailure
        [FieldOffset(112)] public AppleImageUtilsImageConversionResult ConversionResult;
    }
    internal unsafe struct AppleImageUtilsBaseAsyncTaskBlueprintProxy_methods {
        internal struct CreateProxyObjectForConvertToHEIF_method {
            static internal IntPtr CreateProxyObjectForConvertToHEIF_ptr;
            static CreateProxyObjectForConvertToHEIF_method() {
                CreateProxyObjectForConvertToHEIF_ptr = Main.GetMethodUFunction(AppleImageUtilsBaseAsyncTaskBlueprintProxy.StaticClass, "CreateProxyObjectForConvertToHEIF");
            }

            internal static unsafe AppleImageUtilsBaseAsyncTaskBlueprintProxy Invoke(Texture SourceImage, int Quality, bool bWantColor, bool bUseGpu) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SourceImage;
                *((int*)(b+8)) = Quality;
                *((bool*)(b+12)) = bWantColor;
                *((bool*)(b+13)) = bUseGpu;
                Main.GetProcessEvent(AppleImageUtilsBaseAsyncTaskBlueprintProxy.DefaultObject, CreateProxyObjectForConvertToHEIF_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct CreateProxyObjectForConvertToJPEG_method {
            static internal IntPtr CreateProxyObjectForConvertToJPEG_ptr;
            static CreateProxyObjectForConvertToJPEG_method() {
                CreateProxyObjectForConvertToJPEG_ptr = Main.GetMethodUFunction(AppleImageUtilsBaseAsyncTaskBlueprintProxy.StaticClass, "CreateProxyObjectForConvertToJPEG");
            }

            internal static unsafe AppleImageUtilsBaseAsyncTaskBlueprintProxy Invoke(Texture SourceImage, int Quality, bool bWantColor, bool bUseGpu) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SourceImage;
                *((int*)(b+8)) = Quality;
                *((bool*)(b+12)) = bWantColor;
                *((bool*)(b+13)) = bUseGpu;
                Main.GetProcessEvent(AppleImageUtilsBaseAsyncTaskBlueprintProxy.DefaultObject, CreateProxyObjectForConvertToJPEG_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct CreateProxyObjectForConvertToPNG_method {
            static internal IntPtr CreateProxyObjectForConvertToPNG_ptr;
            static CreateProxyObjectForConvertToPNG_method() {
                CreateProxyObjectForConvertToPNG_ptr = Main.GetMethodUFunction(AppleImageUtilsBaseAsyncTaskBlueprintProxy.StaticClass, "CreateProxyObjectForConvertToPNG");
            }

            internal static unsafe AppleImageUtilsBaseAsyncTaskBlueprintProxy Invoke(Texture SourceImage, bool bWantColor, bool bUseGpu) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SourceImage;
                *((bool*)(b+8)) = bWantColor;
                *((bool*)(b+9)) = bUseGpu;
                Main.GetProcessEvent(AppleImageUtilsBaseAsyncTaskBlueprintProxy.DefaultObject, CreateProxyObjectForConvertToPNG_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct CreateProxyObjectForConvertToTIFF_method {
            static internal IntPtr CreateProxyObjectForConvertToTIFF_ptr;
            static CreateProxyObjectForConvertToTIFF_method() {
                CreateProxyObjectForConvertToTIFF_ptr = Main.GetMethodUFunction(AppleImageUtilsBaseAsyncTaskBlueprintProxy.StaticClass, "CreateProxyObjectForConvertToTIFF");
            }

            internal static unsafe AppleImageUtilsBaseAsyncTaskBlueprintProxy Invoke(Texture SourceImage, bool bWantColor, bool bUseGpu) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SourceImage;
                *((bool*)(b+8)) = bWantColor;
                *((bool*)(b+9)) = bUseGpu;
                Main.GetProcessEvent(AppleImageUtilsBaseAsyncTaskBlueprintProxy.DefaultObject, CreateProxyObjectForConvertToTIFF_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
    }
    internal unsafe struct AppleImageUtilsBaseAsyncTaskBlueprintProxy_events {
    }
}
