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
using UE4.SlateCore;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct WidgetLayoutLibrary_fields {
    }
    internal unsafe struct WidgetLayoutLibrary_methods {
        internal struct GetMousePositionOnPlatform_method {
            static internal IntPtr GetMousePositionOnPlatform_ptr;
            static GetMousePositionOnPlatform_method() {
                GetMousePositionOnPlatform_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "GetMousePositionOnPlatform");
            }

            internal static unsafe Vector2D Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, GetMousePositionOnPlatform_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetMousePositionOnViewport_method {
            static internal IntPtr GetMousePositionOnViewport_ptr;
            static GetMousePositionOnViewport_method() {
                GetMousePositionOnViewport_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "GetMousePositionOnViewport");
            }

            internal static unsafe Vector2D Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, GetMousePositionOnViewport_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+8));
            }
        }
        internal struct GetMousePositionScaledByDPI_method {
            static internal IntPtr GetMousePositionScaledByDPI_ptr;
            static GetMousePositionScaledByDPI_method() {
                GetMousePositionScaledByDPI_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "GetMousePositionScaledByDPI");
            }

            internal static unsafe (float, float, bool) Invoke(PlayerController Player) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Player;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, GetMousePositionScaledByDPI_ptr, new IntPtr(p)); ;
                return (*((float*)(b+8)),*((float*)(b+12)),*((bool*)(b+16)));
            }
        }
        internal struct GetPlayerScreenWidgetGeometry_method {
            static internal IntPtr GetPlayerScreenWidgetGeometry_ptr;
            static GetPlayerScreenWidgetGeometry_method() {
                GetPlayerScreenWidgetGeometry_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "GetPlayerScreenWidgetGeometry");
            }

            internal static unsafe Geometry Invoke(PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, GetPlayerScreenWidgetGeometry_ptr, new IntPtr(p)); ;
                return *((Geometry*)(b+8));
            }
        }
        internal struct GetViewportScale_method {
            static internal IntPtr GetViewportScale_ptr;
            static GetViewportScale_method() {
                GetViewportScale_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "GetViewportScale");
            }

            internal static unsafe float Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, GetViewportScale_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetViewportSize_method {
            static internal IntPtr GetViewportSize_ptr;
            static GetViewportSize_method() {
                GetViewportSize_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "GetViewportSize");
            }

            internal static unsafe Vector2D Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, GetViewportSize_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+8));
            }
        }
        internal struct GetViewportWidgetGeometry_method {
            static internal IntPtr GetViewportWidgetGeometry_ptr;
            static GetViewportWidgetGeometry_method() {
                GetViewportWidgetGeometry_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "GetViewportWidgetGeometry");
            }

            internal static unsafe Geometry Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, GetViewportWidgetGeometry_ptr, new IntPtr(p)); ;
                return *((Geometry*)(b+8));
            }
        }
        internal struct ProjectWorldLocationToWidgetPosition_method {
            static internal IntPtr ProjectWorldLocationToWidgetPosition_ptr;
            static ProjectWorldLocationToWidgetPosition_method() {
                ProjectWorldLocationToWidgetPosition_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "ProjectWorldLocationToWidgetPosition");
            }

            internal static unsafe (Vector2D, bool) Invoke(PlayerController PlayerController, Vector WorldLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                *((Vector*)(b+8)) = WorldLocation;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, ProjectWorldLocationToWidgetPosition_ptr, new IntPtr(p)); ;
                return (*((Vector2D*)(b+20)),*((bool*)(b+28)));
            }
        }
        internal struct RemoveAllWidgets_method {
            static internal IntPtr RemoveAllWidgets_ptr;
            static RemoveAllWidgets_method() {
                RemoveAllWidgets_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "RemoveAllWidgets");
            }

            internal static unsafe void Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, RemoveAllWidgets_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SlotAsBorderSlot_method {
            static internal IntPtr SlotAsBorderSlot_ptr;
            static SlotAsBorderSlot_method() {
                SlotAsBorderSlot_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "SlotAsBorderSlot");
            }

            internal static unsafe BorderSlot Invoke(Widget Widget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Widget;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, SlotAsBorderSlot_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SlotAsCanvasSlot_method {
            static internal IntPtr SlotAsCanvasSlot_ptr;
            static SlotAsCanvasSlot_method() {
                SlotAsCanvasSlot_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "SlotAsCanvasSlot");
            }

            internal static unsafe CanvasPanelSlot Invoke(Widget Widget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Widget;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, SlotAsCanvasSlot_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SlotAsGridSlot_method {
            static internal IntPtr SlotAsGridSlot_ptr;
            static SlotAsGridSlot_method() {
                SlotAsGridSlot_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "SlotAsGridSlot");
            }

            internal static unsafe GridSlot Invoke(Widget Widget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Widget;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, SlotAsGridSlot_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SlotAsHorizontalBoxSlot_method {
            static internal IntPtr SlotAsHorizontalBoxSlot_ptr;
            static SlotAsHorizontalBoxSlot_method() {
                SlotAsHorizontalBoxSlot_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "SlotAsHorizontalBoxSlot");
            }

            internal static unsafe HorizontalBoxSlot Invoke(Widget Widget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Widget;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, SlotAsHorizontalBoxSlot_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SlotAsOverlaySlot_method {
            static internal IntPtr SlotAsOverlaySlot_ptr;
            static SlotAsOverlaySlot_method() {
                SlotAsOverlaySlot_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "SlotAsOverlaySlot");
            }

            internal static unsafe OverlaySlot Invoke(Widget Widget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Widget;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, SlotAsOverlaySlot_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SlotAsUniformGridSlot_method {
            static internal IntPtr SlotAsUniformGridSlot_ptr;
            static SlotAsUniformGridSlot_method() {
                SlotAsUniformGridSlot_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "SlotAsUniformGridSlot");
            }

            internal static unsafe UniformGridSlot Invoke(Widget Widget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Widget;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, SlotAsUniformGridSlot_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SlotAsVerticalBoxSlot_method {
            static internal IntPtr SlotAsVerticalBoxSlot_ptr;
            static SlotAsVerticalBoxSlot_method() {
                SlotAsVerticalBoxSlot_ptr = Main.GetMethodUFunction(WidgetLayoutLibrary.StaticClass, "SlotAsVerticalBoxSlot");
            }

            internal static unsafe VerticalBoxSlot Invoke(Widget Widget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Widget;
                Main.GetProcessEvent(WidgetLayoutLibrary.DefaultObject, SlotAsVerticalBoxSlot_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
    }
    internal unsafe struct WidgetLayoutLibrary_events {
    }
}
