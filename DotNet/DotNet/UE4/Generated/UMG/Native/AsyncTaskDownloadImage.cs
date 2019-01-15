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


namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct AsyncTaskDownloadImage_fields {
        [FieldOffset(64)] byte OnSuccess; //TODO: multicast delegate FDownloadImageDelegate OnSuccess
        [FieldOffset(80)] byte OnFail; //TODO: multicast delegate FDownloadImageDelegate OnFail
    }
    internal unsafe struct AsyncTaskDownloadImage_methods {
        internal struct DownloadImage_method {
            static internal IntPtr DownloadImage_ptr;
            static DownloadImage_method() {
                DownloadImage_ptr = Main.GetMethodUFunction(AsyncTaskDownloadImage.StaticClass, "DownloadImage");
            }

            internal static unsafe AsyncTaskDownloadImage Invoke(string URL) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var URL_handle = GCHandle.Alloc(URL, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = URL_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = URL.Length;
                *(int*)(b+IntPtr.Size+4+0) = URL.Length;
                Main.GetProcessEvent(AsyncTaskDownloadImage.DefaultObject, DownloadImage_ptr, new IntPtr(p)); ;
                URL_handle.Free();
                return *((IntPtr*)(b+16));
            }
        }
    }
    internal unsafe struct AsyncTaskDownloadImage_events {
    }
}
