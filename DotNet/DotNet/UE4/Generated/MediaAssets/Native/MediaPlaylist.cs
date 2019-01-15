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
    [StructLayout( LayoutKind.Explicit, Size=72 )]
    internal unsafe struct MediaPlaylist_fields {
        [FieldOffset(56)] public NativeArray Items;
    }
    internal unsafe struct MediaPlaylist_methods {
        internal struct Add_method {
            static internal IntPtr Add_ptr;
            static Add_method() {
                Add_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "Add");
            }

            internal static unsafe bool Invoke(IntPtr obj, MediaSource MediaSource) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MediaSource;
                Main.GetProcessEvent(obj, Add_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct AddFile_method {
            static internal IntPtr AddFile_ptr;
            static AddFile_method() {
                AddFile_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "AddFile");
            }

            internal static unsafe bool Invoke(IntPtr obj, string FilePath) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var FilePath_handle = GCHandle.Alloc(FilePath, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = FilePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = FilePath.Length;
                *(int*)(b+IntPtr.Size+4+0) = FilePath.Length;
                Main.GetProcessEvent(obj, AddFile_ptr, new IntPtr(p)); ;
                FilePath_handle.Free();
                return *((bool*)(b+16));
            }
        }
        internal struct AddUrl_method {
            static internal IntPtr AddUrl_ptr;
            static AddUrl_method() {
                AddUrl_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "AddUrl");
            }

            internal static unsafe bool Invoke(IntPtr obj, string Url) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Url_handle = GCHandle.Alloc(Url, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Url_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Url.Length;
                *(int*)(b+IntPtr.Size+4+0) = Url.Length;
                Main.GetProcessEvent(obj, AddUrl_ptr, new IntPtr(p)); ;
                Url_handle.Free();
                return *((bool*)(b+16));
            }
        }
        internal struct Get_method {
            static internal IntPtr Get_ptr;
            static Get_method() {
                Get_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "Get");
            }

            internal static unsafe MediaSource Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, Get_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetNext_method {
            static internal IntPtr GetNext_ptr;
            static GetNext_method() {
                GetNext_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "GetNext");
            }

            internal static unsafe (int, MediaSource) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNext_ptr, new IntPtr(p)); ;
                return (*((int*)(b+0)),*((IntPtr*)(b+8)));
            }
        }
        internal struct GetPrevious_method {
            static internal IntPtr GetPrevious_ptr;
            static GetPrevious_method() {
                GetPrevious_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "GetPrevious");
            }

            internal static unsafe (int, MediaSource) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPrevious_ptr, new IntPtr(p)); ;
                return (*((int*)(b+0)),*((IntPtr*)(b+8)));
            }
        }
        internal struct GetRandom_method {
            static internal IntPtr GetRandom_ptr;
            static GetRandom_method() {
                GetRandom_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "GetRandom");
            }

            internal static unsafe (int, MediaSource) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetRandom_ptr, new IntPtr(p)); ;
                return (*((int*)(b+0)),*((IntPtr*)(b+8)));
            }
        }
        internal struct Insert_method {
            static internal IntPtr Insert_ptr;
            static Insert_method() {
                Insert_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "Insert");
            }

            internal static unsafe void Invoke(IntPtr obj, MediaSource MediaSource, int Index) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MediaSource;
                *((int*)(b+8)) = Index;
                Main.GetProcessEvent(obj, Insert_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Num_method {
            static internal IntPtr Num_ptr;
            static Num_method() {
                Num_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "Num");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Num_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct Remove_method {
            static internal IntPtr Remove_ptr;
            static Remove_method() {
                Remove_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "Remove");
            }

            internal static unsafe bool Invoke(IntPtr obj, MediaSource MediaSource) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MediaSource;
                Main.GetProcessEvent(obj, Remove_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct RemoveAt_method {
            static internal IntPtr RemoveAt_ptr;
            static RemoveAt_method() {
                RemoveAt_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "RemoveAt");
            }

            internal static unsafe bool Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, RemoveAt_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct Replace_method {
            static internal IntPtr Replace_ptr;
            static Replace_method() {
                Replace_ptr = Main.GetMethodUFunction(MediaPlaylist.StaticClass, "Replace");
            }

            internal static unsafe bool Invoke(IntPtr obj, int Index, MediaSource Replacement) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                *((IntPtr*)(b+8)) = Replacement;
                Main.GetProcessEvent(obj, Replace_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
    }
    internal unsafe struct MediaPlaylist_events {
    }
}
