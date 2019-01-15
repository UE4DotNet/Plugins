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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct KismetGuidLibrary_fields {
    }
    internal unsafe struct KismetGuidLibrary_methods {
        internal struct Conv_GuidToString_method {
            static internal IntPtr Conv_GuidToString_ptr;
            static Conv_GuidToString_method() {
                Conv_GuidToString_ptr = Main.GetMethodUFunction(KismetGuidLibrary.StaticClass, "Conv_GuidToString");
            }

            internal static unsafe string Invoke(FGuid InGuid) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FGuid*)(b+0)) = InGuid;
                Main.GetProcessEvent(KismetGuidLibrary.DefaultObject, Conv_GuidToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct EqualEqual_GuidGuid_method {
            static internal IntPtr EqualEqual_GuidGuid_ptr;
            static EqualEqual_GuidGuid_method() {
                EqualEqual_GuidGuid_ptr = Main.GetMethodUFunction(KismetGuidLibrary.StaticClass, "EqualEqual_GuidGuid");
            }

            internal static unsafe bool Invoke(FGuid A, FGuid B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FGuid*)(b+0)) = A;
                *((FGuid*)(b+16)) = B;
                Main.GetProcessEvent(KismetGuidLibrary.DefaultObject, EqualEqual_GuidGuid_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct Invalidate_Guid_method {
            static internal IntPtr Invalidate_Guid_ptr;
            static Invalidate_Guid_method() {
                Invalidate_Guid_ptr = Main.GetMethodUFunction(KismetGuidLibrary.StaticClass, "Invalidate_Guid");
            }

            internal static unsafe void Invoke(FGuid InGuid) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FGuid*)(b+0)) = InGuid;
                Main.GetProcessEvent(KismetGuidLibrary.DefaultObject, Invalidate_Guid_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsValid_Guid_method {
            static internal IntPtr IsValid_Guid_ptr;
            static IsValid_Guid_method() {
                IsValid_Guid_ptr = Main.GetMethodUFunction(KismetGuidLibrary.StaticClass, "IsValid_Guid");
            }

            internal static unsafe bool Invoke(FGuid InGuid) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FGuid*)(b+0)) = InGuid;
                Main.GetProcessEvent(KismetGuidLibrary.DefaultObject, IsValid_Guid_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct NewGuid_method {
            static internal IntPtr NewGuid_ptr;
            static NewGuid_method() {
                NewGuid_ptr = Main.GetMethodUFunction(KismetGuidLibrary.StaticClass, "NewGuid");
            }

            internal static unsafe FGuid Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetGuidLibrary.DefaultObject, NewGuid_ptr, new IntPtr(p)); ;
                return *((FGuid*)(b+0));
            }
        }
        internal struct NotEqual_GuidGuid_method {
            static internal IntPtr NotEqual_GuidGuid_ptr;
            static NotEqual_GuidGuid_method() {
                NotEqual_GuidGuid_ptr = Main.GetMethodUFunction(KismetGuidLibrary.StaticClass, "NotEqual_GuidGuid");
            }

            internal static unsafe bool Invoke(FGuid A, FGuid B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FGuid*)(b+0)) = A;
                *((FGuid*)(b+16)) = B;
                Main.GetProcessEvent(KismetGuidLibrary.DefaultObject, NotEqual_GuidGuid_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct Parse_StringToGuid_method {
            static internal IntPtr Parse_StringToGuid_ptr;
            static Parse_StringToGuid_method() {
                Parse_StringToGuid_ptr = Main.GetMethodUFunction(KismetGuidLibrary.StaticClass, "Parse_StringToGuid");
            }

            internal static unsafe (FGuid, bool) Invoke(string GuidString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var GuidString_handle = GCHandle.Alloc(GuidString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = GuidString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = GuidString.Length;
                *(int*)(b+IntPtr.Size+4+0) = GuidString.Length;
                Main.GetProcessEvent(KismetGuidLibrary.DefaultObject, Parse_StringToGuid_ptr, new IntPtr(p)); ;
                GuidString_handle.Free();
                return (*((FGuid*)(b+16)),*((bool*)(b+32)));
            }
        }
    }
    internal unsafe struct KismetGuidLibrary_events {
    }
}
