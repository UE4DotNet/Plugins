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

using UE4.SlateCore;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct SlateBlueprintLibrary_fields {
    }
    internal unsafe struct SlateBlueprintLibrary_methods {
        internal struct AbsoluteToLocal_method {
            static internal IntPtr AbsoluteToLocal_ptr;
            static AbsoluteToLocal_method() {
                AbsoluteToLocal_ptr = Main.GetMethodUFunction(SlateBlueprintLibrary.StaticClass, "AbsoluteToLocal");
            }

            internal static unsafe Vector2D Invoke(Geometry Geometry, Vector2D AbsoluteCoordinate) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Geometry*)(b+0)) = Geometry;
                *((Vector2D*)(b+56)) = AbsoluteCoordinate;
                Main.GetProcessEvent(SlateBlueprintLibrary.DefaultObject, AbsoluteToLocal_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+64));
            }
        }
        internal struct AbsoluteToViewport_method {
            static internal IntPtr AbsoluteToViewport_ptr;
            static AbsoluteToViewport_method() {
                AbsoluteToViewport_ptr = Main.GetMethodUFunction(SlateBlueprintLibrary.StaticClass, "AbsoluteToViewport");
            }

            internal static unsafe (Vector2D, Vector2D) Invoke(UObject WorldContextObject, Vector2D AbsoluteDesktopCoordinate) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector2D*)(b+8)) = AbsoluteDesktopCoordinate;
                Main.GetProcessEvent(SlateBlueprintLibrary.DefaultObject, AbsoluteToViewport_ptr, new IntPtr(p)); ;
                return (*((Vector2D*)(b+16)),*((Vector2D*)(b+24)));
            }
        }
        internal struct EqualEqual_SlateBrush_method {
            static internal IntPtr EqualEqual_SlateBrush_ptr;
            static EqualEqual_SlateBrush_method() {
                EqualEqual_SlateBrush_ptr = Main.GetMethodUFunction(SlateBlueprintLibrary.StaticClass, "EqualEqual_SlateBrush");
            }

            internal static unsafe bool Invoke(SlateBrush A, SlateBrush B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateBrush*)(b+0)) = A;
                *((SlateBrush*)(b+160)) = B;
                Main.GetProcessEvent(SlateBlueprintLibrary.DefaultObject, EqualEqual_SlateBrush_ptr, new IntPtr(p)); ;
                return *((bool*)(b+320));
            }
        }
        internal struct GetAbsoluteSize_method {
            static internal IntPtr GetAbsoluteSize_ptr;
            static GetAbsoluteSize_method() {
                GetAbsoluteSize_ptr = Main.GetMethodUFunction(SlateBlueprintLibrary.StaticClass, "GetAbsoluteSize");
            }

            internal static unsafe Vector2D Invoke(Geometry Geometry) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Geometry*)(b+0)) = Geometry;
                Main.GetProcessEvent(SlateBlueprintLibrary.DefaultObject, GetAbsoluteSize_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+56));
            }
        }
        internal struct GetLocalSize_method {
            static internal IntPtr GetLocalSize_ptr;
            static GetLocalSize_method() {
                GetLocalSize_ptr = Main.GetMethodUFunction(SlateBlueprintLibrary.StaticClass, "GetLocalSize");
            }

            internal static unsafe Vector2D Invoke(Geometry Geometry) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Geometry*)(b+0)) = Geometry;
                Main.GetProcessEvent(SlateBlueprintLibrary.DefaultObject, GetLocalSize_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+56));
            }
        }
        internal struct IsUnderLocation_method {
            static internal IntPtr IsUnderLocation_ptr;
            static IsUnderLocation_method() {
                IsUnderLocation_ptr = Main.GetMethodUFunction(SlateBlueprintLibrary.StaticClass, "IsUnderLocation");
            }

            internal static unsafe bool Invoke(Geometry Geometry, Vector2D AbsoluteCoordinate) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Geometry*)(b+0)) = Geometry;
                *((Vector2D*)(b+56)) = AbsoluteCoordinate;
                Main.GetProcessEvent(SlateBlueprintLibrary.DefaultObject, IsUnderLocation_ptr, new IntPtr(p)); ;
                return *((bool*)(b+64));
            }
        }
        internal struct LocalToAbsolute_method {
            static internal IntPtr LocalToAbsolute_ptr;
            static LocalToAbsolute_method() {
                LocalToAbsolute_ptr = Main.GetMethodUFunction(SlateBlueprintLibrary.StaticClass, "LocalToAbsolute");
            }

            internal static unsafe Vector2D Invoke(Geometry Geometry, Vector2D LocalCoordinate) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Geometry*)(b+0)) = Geometry;
                *((Vector2D*)(b+56)) = LocalCoordinate;
                Main.GetProcessEvent(SlateBlueprintLibrary.DefaultObject, LocalToAbsolute_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+64));
            }
        }
        internal struct LocalToViewport_method {
            static internal IntPtr LocalToViewport_ptr;
            static LocalToViewport_method() {
                LocalToViewport_ptr = Main.GetMethodUFunction(SlateBlueprintLibrary.StaticClass, "LocalToViewport");
            }

            internal static unsafe (Vector2D, Vector2D) Invoke(UObject WorldContextObject, Geometry Geometry, Vector2D LocalCoordinate) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Geometry*)(b+8)) = Geometry;
                *((Vector2D*)(b+64)) = LocalCoordinate;
                Main.GetProcessEvent(SlateBlueprintLibrary.DefaultObject, LocalToViewport_ptr, new IntPtr(p)); ;
                return (*((Vector2D*)(b+72)),*((Vector2D*)(b+80)));
            }
        }
    }
    internal unsafe struct SlateBlueprintLibrary_events {
    }
}
