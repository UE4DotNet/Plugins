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
    [StructLayout( LayoutKind.Explicit, Size=448 )]
    internal unsafe struct UniformGridPanel_fields {
        [FieldOffset(408)] public Margin SlotPadding;
        [FieldOffset(424)] public float MinDesiredSlotWidth;
        [FieldOffset(428)] public float MinDesiredSlotHeight;
    }
    internal unsafe struct UniformGridPanel_methods {
        internal struct AddChildToUniformGrid_method {
            static internal IntPtr AddChildToUniformGrid_ptr;
            static AddChildToUniformGrid_method() {
                AddChildToUniformGrid_ptr = Main.GetMethodUFunction(UniformGridPanel.StaticClass, "AddChildToUniformGrid");
            }

            internal static unsafe UniformGridSlot Invoke(IntPtr obj, Widget Content) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Content;
                Main.GetProcessEvent(obj, AddChildToUniformGrid_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SetMinDesiredSlotHeight_method {
            static internal IntPtr SetMinDesiredSlotHeight_ptr;
            static SetMinDesiredSlotHeight_method() {
                SetMinDesiredSlotHeight_ptr = Main.GetMethodUFunction(UniformGridPanel.StaticClass, "SetMinDesiredSlotHeight");
            }

            internal static unsafe void Invoke(IntPtr obj, float InMinDesiredSlotHeight) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InMinDesiredSlotHeight;
                Main.GetProcessEvent(obj, SetMinDesiredSlotHeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMinDesiredSlotWidth_method {
            static internal IntPtr SetMinDesiredSlotWidth_ptr;
            static SetMinDesiredSlotWidth_method() {
                SetMinDesiredSlotWidth_ptr = Main.GetMethodUFunction(UniformGridPanel.StaticClass, "SetMinDesiredSlotWidth");
            }

            internal static unsafe void Invoke(IntPtr obj, float InMinDesiredSlotWidth) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InMinDesiredSlotWidth;
                Main.GetProcessEvent(obj, SetMinDesiredSlotWidth_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSlotPadding_method {
            static internal IntPtr SetSlotPadding_ptr;
            static SetSlotPadding_method() {
                SetSlotPadding_ptr = Main.GetMethodUFunction(UniformGridPanel.StaticClass, "SetSlotPadding");
            }

            internal static unsafe void Invoke(IntPtr obj, Margin InSlotPadding) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Margin*)(b+0)) = InSlotPadding;
                Main.GetProcessEvent(obj, SetSlotPadding_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct UniformGridPanel_events {
    }
}
