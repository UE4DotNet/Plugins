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

using UE4.Slate;
using UE4.SlateCore;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=240 )]
    internal unsafe struct CanvasPanelSlot_fields {
        [FieldOffset(72)] public AnchorData LayoutData;
        [FieldOffset(112)] public bool bAutoSize;
        [FieldOffset(116)] public int ZOrder;
    }
    internal unsafe struct CanvasPanelSlot_methods {
        internal struct GetAlignment_method {
            static internal IntPtr GetAlignment_ptr;
            static GetAlignment_method() {
                GetAlignment_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "GetAlignment");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAlignment_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetAnchors_method {
            static internal IntPtr GetAnchors_ptr;
            static GetAnchors_method() {
                GetAnchors_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "GetAnchors");
            }

            internal static unsafe Anchors Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAnchors_ptr, new IntPtr(p)); ;
                return *((Anchors*)(b+0));
            }
        }
        internal struct GetAutoSize_method {
            static internal IntPtr GetAutoSize_ptr;
            static GetAutoSize_method() {
                GetAutoSize_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "GetAutoSize");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAutoSize_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetLayout_method {
            static internal IntPtr GetLayout_ptr;
            static GetLayout_method() {
                GetLayout_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "GetLayout");
            }

            internal static unsafe AnchorData Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLayout_ptr, new IntPtr(p)); ;
                return *((AnchorData*)(b+0));
            }
        }
        internal struct GetOffsets_method {
            static internal IntPtr GetOffsets_ptr;
            static GetOffsets_method() {
                GetOffsets_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "GetOffsets");
            }

            internal static unsafe Margin Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOffsets_ptr, new IntPtr(p)); ;
                return *((Margin*)(b+0));
            }
        }
        internal struct GetPosition_method {
            static internal IntPtr GetPosition_ptr;
            static GetPosition_method() {
                GetPosition_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "GetPosition");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPosition_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetSize_method {
            static internal IntPtr GetSize_ptr;
            static GetSize_method() {
                GetSize_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "GetSize");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSize_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetZOrder_method {
            static internal IntPtr GetZOrder_ptr;
            static GetZOrder_method() {
                GetZOrder_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "GetZOrder");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetZOrder_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct SetAlignment_method {
            static internal IntPtr SetAlignment_ptr;
            static SetAlignment_method() {
                SetAlignment_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "SetAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D InAlignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InAlignment;
                Main.GetProcessEvent(obj, SetAlignment_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAnchors_method {
            static internal IntPtr SetAnchors_ptr;
            static SetAnchors_method() {
                SetAnchors_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "SetAnchors");
            }

            internal static unsafe void Invoke(IntPtr obj, Anchors InAnchors) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Anchors*)(b+0)) = InAnchors;
                Main.GetProcessEvent(obj, SetAnchors_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAutoSize_method {
            static internal IntPtr SetAutoSize_ptr;
            static SetAutoSize_method() {
                SetAutoSize_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "SetAutoSize");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InbAutoSize) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InbAutoSize;
                Main.GetProcessEvent(obj, SetAutoSize_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLayout_method {
            static internal IntPtr SetLayout_ptr;
            static SetLayout_method() {
                SetLayout_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "SetLayout");
            }

            internal static unsafe void Invoke(IntPtr obj, AnchorData InLayoutData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AnchorData*)(b+0)) = InLayoutData;
                Main.GetProcessEvent(obj, SetLayout_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOffsets_method {
            static internal IntPtr SetOffsets_ptr;
            static SetOffsets_method() {
                SetOffsets_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "SetOffsets");
            }

            internal static unsafe void Invoke(IntPtr obj, Margin InOffset) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Margin*)(b+0)) = InOffset;
                Main.GetProcessEvent(obj, SetOffsets_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPosition_method {
            static internal IntPtr SetPosition_ptr;
            static SetPosition_method() {
                SetPosition_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "SetPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D InPosition) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InPosition;
                Main.GetProcessEvent(obj, SetPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSize_method {
            static internal IntPtr SetSize_ptr;
            static SetSize_method() {
                SetSize_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "SetSize");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D InSize) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InSize;
                Main.GetProcessEvent(obj, SetSize_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetZOrder_method {
            static internal IntPtr SetZOrder_ptr;
            static SetZOrder_method() {
                SetZOrder_ptr = Main.GetMethodUFunction(CanvasPanelSlot.StaticClass, "SetZOrder");
            }

            internal static unsafe void Invoke(IntPtr obj, int InZOrder) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InZOrder;
                Main.GetProcessEvent(obj, SetZOrder_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CanvasPanelSlot_events {
    }
}
