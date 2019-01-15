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

namespace UE4.ImgMedia.Native {
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct ImgMediaSource_fields {
        [FieldOffset(160)] public FrameRate FrameRateOverride;
        [FieldOffset(168)] byte ProxyOverride; //TODO: string FString ProxyOverride
        [FieldOffset(184)] public DirectoryPath SequencePath;
    }
    internal unsafe struct ImgMediaSource_methods {
        internal struct GetProxies_method {
            static internal IntPtr GetProxies_ptr;
            static GetProxies_method() {
                GetProxies_ptr = Main.GetMethodUFunction(ImgMediaSource.StaticClass, "GetProxies");
            }

            internal static unsafe IReadOnlyCollection<string> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetProxies_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutProxies
                return UObject.ToStringCollection(b+0);
            }
        }
        internal struct GetSequencePath_method {
            static internal IntPtr GetSequencePath_ptr;
            static GetSequencePath_method() {
                GetSequencePath_ptr = Main.GetMethodUFunction(ImgMediaSource.StaticClass, "GetSequencePath");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSequencePath_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct SetSequencePath_method {
            static internal IntPtr SetSequencePath_ptr;
            static SetSequencePath_method() {
                SetSequencePath_ptr = Main.GetMethodUFunction(ImgMediaSource.StaticClass, "SetSequencePath");
            }

            internal static unsafe void Invoke(IntPtr obj, string Path) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Path_handle = GCHandle.Alloc(Path, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Path_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Path.Length;
                *(int*)(b+IntPtr.Size+4+0) = Path.Length;
                Main.GetProcessEvent(obj, SetSequencePath_ptr, new IntPtr(p)); ;
                Path_handle.Free();
            }
        }
    }
    internal unsafe struct ImgMediaSource_events {
    }
}
