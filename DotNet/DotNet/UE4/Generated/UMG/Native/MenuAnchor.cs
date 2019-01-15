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
    [StructLayout( LayoutKind.Explicit, Size=472 )]
    internal unsafe struct MenuAnchor_fields {
        [FieldOffset(408)] public IntPtr MenuClass;
        [FieldOffset(416)] byte OnGetMenuContentEvent; //TODO: delegate FGetWidget OnGetMenuContentEvent
        [FieldOffset(436)] public byte Placement;
        [FieldOffset(437)] public bool ShouldDeferPaintingAfterWindowContent;
        [FieldOffset(438)] public bool UseApplicationMenuStack;
        [FieldOffset(440)] byte OnMenuOpenChanged; //TODO: multicast delegate FOnMenuOpenChangedEvent OnMenuOpenChanged
    }
    internal unsafe struct MenuAnchor_methods {
        internal struct Close_method {
            static internal IntPtr Close_ptr;
            static Close_method() {
                Close_ptr = Main.GetMethodUFunction(MenuAnchor.StaticClass, "Close");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Close_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetMenuPosition_method {
            static internal IntPtr GetMenuPosition_ptr;
            static GetMenuPosition_method() {
                GetMenuPosition_ptr = Main.GetMethodUFunction(MenuAnchor.StaticClass, "GetMenuPosition");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMenuPosition_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct HasOpenSubMenus_method {
            static internal IntPtr HasOpenSubMenus_ptr;
            static HasOpenSubMenus_method() {
                HasOpenSubMenus_ptr = Main.GetMethodUFunction(MenuAnchor.StaticClass, "HasOpenSubMenus");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasOpenSubMenus_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsOpen_method {
            static internal IntPtr IsOpen_ptr;
            static IsOpen_method() {
                IsOpen_ptr = Main.GetMethodUFunction(MenuAnchor.StaticClass, "IsOpen");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsOpen_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Open_method {
            static internal IntPtr Open_ptr;
            static Open_method() {
                Open_ptr = Main.GetMethodUFunction(MenuAnchor.StaticClass, "Open");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bFocusMenu) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bFocusMenu;
                Main.GetProcessEvent(obj, Open_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShouldOpenDueToClick_method {
            static internal IntPtr ShouldOpenDueToClick_ptr;
            static ShouldOpenDueToClick_method() {
                ShouldOpenDueToClick_ptr = Main.GetMethodUFunction(MenuAnchor.StaticClass, "ShouldOpenDueToClick");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ShouldOpenDueToClick_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct ToggleOpen_method {
            static internal IntPtr ToggleOpen_ptr;
            static ToggleOpen_method() {
                ToggleOpen_ptr = Main.GetMethodUFunction(MenuAnchor.StaticClass, "ToggleOpen");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bFocusOnOpen) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bFocusOnOpen;
                Main.GetProcessEvent(obj, ToggleOpen_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MenuAnchor_events {
    }
}
