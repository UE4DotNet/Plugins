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
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct FileMediaSource_fields {
        [FieldOffset(160)] byte FilePath; //TODO: string FString FilePath
        [FieldOffset(176)] public bool PrecacheFile;
    }
    internal unsafe struct FileMediaSource_methods {
        internal struct SetFilePath_method {
            static internal IntPtr SetFilePath_ptr;
            static SetFilePath_method() {
                SetFilePath_ptr = Main.GetMethodUFunction(FileMediaSource.StaticClass, "SetFilePath");
            }

            internal static unsafe void Invoke(IntPtr obj, string Path) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Path_handle = GCHandle.Alloc(Path, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Path_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Path.Length;
                *(int*)(b+IntPtr.Size+4+0) = Path.Length;
                Main.GetProcessEvent(obj, SetFilePath_ptr, new IntPtr(p)); ;
                Path_handle.Free();
            }
        }
    }
    internal unsafe struct FileMediaSource_events {
    }
}
