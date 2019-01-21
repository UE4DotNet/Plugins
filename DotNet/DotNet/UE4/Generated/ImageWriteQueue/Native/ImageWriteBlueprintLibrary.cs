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

namespace UE4.ImageWriteQueue.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct ImageWriteBlueprintLibrary_fields {
    }
    internal unsafe struct ImageWriteBlueprintLibrary_methods {
        internal struct ExportToDisk_method {
            static internal IntPtr ExportToDisk_ptr;
            static ExportToDisk_method() {
                ExportToDisk_ptr = Main.GetMethodUFunction(ImageWriteBlueprintLibrary.StaticClass, "ExportToDisk");
            }

            internal static unsafe void Invoke(Texture Texture, string Filename, ImageWriteOptions Options) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                var Filename_handle = GCHandle.Alloc(Filename, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = Filename_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = Filename.Length;
                *(int*)(b+IntPtr.Size+4+8) = Filename.Length;
                *((ImageWriteOptions*)(b+32)) = Options;
                Main.GetProcessEvent(ImageWriteBlueprintLibrary.DefaultObject, ExportToDisk_ptr, new IntPtr(p)); ;
                Filename_handle.Free();
            }
        }
    }
    internal unsafe struct ImageWriteBlueprintLibrary_events {
    }
}
