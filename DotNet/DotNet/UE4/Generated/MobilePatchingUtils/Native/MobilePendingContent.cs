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


namespace UE4.MobilePatchingUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct MobilePendingContent_fields {
    }
    internal unsafe struct MobilePendingContent_methods {
        internal struct GetDownloadSize_method {
            static internal IntPtr GetDownloadSize_ptr;
            static GetDownloadSize_method() {
                GetDownloadSize_ptr = Main.GetMethodUFunction(MobilePendingContent.StaticClass, "GetDownloadSize");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDownloadSize_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetDownloadSpeed_method {
            static internal IntPtr GetDownloadSpeed_ptr;
            static GetDownloadSpeed_method() {
                GetDownloadSpeed_ptr = Main.GetMethodUFunction(MobilePendingContent.StaticClass, "GetDownloadSpeed");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDownloadSpeed_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetDownloadStatusText_method {
            static internal IntPtr GetDownloadStatusText_ptr;
            static GetDownloadStatusText_method() {
                GetDownloadStatusText_ptr = Main.GetMethodUFunction(MobilePendingContent.StaticClass, "GetDownloadStatusText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDownloadStatusText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct GetInstallProgress_method {
            static internal IntPtr GetInstallProgress_ptr;
            static GetInstallProgress_method() {
                GetInstallProgress_ptr = Main.GetMethodUFunction(MobilePendingContent.StaticClass, "GetInstallProgress");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetInstallProgress_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetRequiredDiskSpace_method {
            static internal IntPtr GetRequiredDiskSpace_ptr;
            static GetRequiredDiskSpace_method() {
                GetRequiredDiskSpace_ptr = Main.GetMethodUFunction(MobilePendingContent.StaticClass, "GetRequiredDiskSpace");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetRequiredDiskSpace_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetTotalDownloadedSize_method {
            static internal IntPtr GetTotalDownloadedSize_ptr;
            static GetTotalDownloadedSize_method() {
                GetTotalDownloadedSize_ptr = Main.GetMethodUFunction(MobilePendingContent.StaticClass, "GetTotalDownloadedSize");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTotalDownloadedSize_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct StartInstall_method {
            static internal IntPtr StartInstall_ptr;
            static StartInstall_method() {
                StartInstall_ptr = Main.GetMethodUFunction(MobilePendingContent.StaticClass, "StartInstall");
            }

            internal static unsafe void Invoke(IntPtr obj, byte OnSucceeded /*TODO: delegate FOnContentInstallSucceeded */, byte OnFailed /*TODO: delegate FOnContentInstallFailed */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FOnContentInstallSucceeded OnSucceeded
                throw new NotImplementedException(); //TODO: delegate FOnContentInstallFailed OnFailed
                Main.GetProcessEvent(obj, StartInstall_ptr, new IntPtr(p)); ;
                 //TODO: delegate FOnContentInstallSucceeded OnSucceeded
                 //TODO: delegate FOnContentInstallFailed OnFailed
            }
        }
    }
    internal unsafe struct MobilePendingContent_events {
    }
}
