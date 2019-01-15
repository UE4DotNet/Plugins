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
    [StructLayout( LayoutKind.Explicit, Size=1032 )]
    internal unsafe struct ProgressBar_fields {
        [FieldOffset(384)] public ProgressBarStyle WidgetStyle;
        [FieldOffset(904)] public float Percent;
        [FieldOffset(908)] public byte BarFillType;
        [FieldOffset(909)] public bool bIsMarquee;
        [FieldOffset(912)] public Vector2D BorderPadding;
        [FieldOffset(920)] byte PercentDelegate; //TODO: delegate FGetFloat PercentDelegate
        [FieldOffset(940)] public LinearColor FillColorAndOpacity;
        [FieldOffset(956)] byte FillColorAndOpacityDelegate; //TODO: delegate FGetLinearColor FillColorAndOpacityDelegate
    }
    internal unsafe struct ProgressBar_methods {
        internal struct SetFillColorAndOpacity_method {
            static internal IntPtr SetFillColorAndOpacity_ptr;
            static SetFillColorAndOpacity_method() {
                SetFillColorAndOpacity_ptr = Main.GetMethodUFunction(ProgressBar.StaticClass, "SetFillColorAndOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InColor;
                Main.GetProcessEvent(obj, SetFillColorAndOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIsMarquee_method {
            static internal IntPtr SetIsMarquee_ptr;
            static SetIsMarquee_method() {
                SetIsMarquee_ptr = Main.GetMethodUFunction(ProgressBar.StaticClass, "SetIsMarquee");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InbIsMarquee) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InbIsMarquee;
                Main.GetProcessEvent(obj, SetIsMarquee_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPercent_method {
            static internal IntPtr SetPercent_ptr;
            static SetPercent_method() {
                SetPercent_ptr = Main.GetMethodUFunction(ProgressBar.StaticClass, "SetPercent");
            }

            internal static unsafe void Invoke(IntPtr obj, float InPercent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InPercent;
                Main.GetProcessEvent(obj, SetPercent_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ProgressBar_events {
    }
}
