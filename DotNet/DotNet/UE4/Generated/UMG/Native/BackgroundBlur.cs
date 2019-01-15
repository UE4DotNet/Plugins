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
    [StructLayout( LayoutKind.Explicit, Size=616 )]
    internal unsafe struct BackgroundBlur_fields {
        [FieldOffset(408)] public Margin Padding;
        [FieldOffset(424)] public byte HorizontalAlignment;
        [FieldOffset(425)] public byte VerticalAlignment;
        [FieldOffset(426)] public bool bApplyAlphaToBlur;
        [FieldOffset(428)] public float BlurStrength;
        [FieldOffset(432)] public bool bOverrideAutoRadiusCalculation;
        [FieldOffset(436)] public int BlurRadius;
        [FieldOffset(440)] public SlateBrush LowQualityFallbackBrush;
    }
    internal unsafe struct BackgroundBlur_methods {
        internal struct SetApplyAlphaToBlur_method {
            static internal IntPtr SetApplyAlphaToBlur_ptr;
            static SetApplyAlphaToBlur_method() {
                SetApplyAlphaToBlur_ptr = Main.GetMethodUFunction(BackgroundBlur.StaticClass, "SetApplyAlphaToBlur");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInApplyAlphaToBlur) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInApplyAlphaToBlur;
                Main.GetProcessEvent(obj, SetApplyAlphaToBlur_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlurRadius_method {
            static internal IntPtr SetBlurRadius_ptr;
            static SetBlurRadius_method() {
                SetBlurRadius_ptr = Main.GetMethodUFunction(BackgroundBlur.StaticClass, "SetBlurRadius");
            }

            internal static unsafe void Invoke(IntPtr obj, int InBlurRadius) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InBlurRadius;
                Main.GetProcessEvent(obj, SetBlurRadius_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlurStrength_method {
            static internal IntPtr SetBlurStrength_ptr;
            static SetBlurStrength_method() {
                SetBlurStrength_ptr = Main.GetMethodUFunction(BackgroundBlur.StaticClass, "SetBlurStrength");
            }

            internal static unsafe void Invoke(IntPtr obj, float InStrength) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InStrength;
                Main.GetProcessEvent(obj, SetBlurStrength_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHorizontalAlignment_method {
            static internal IntPtr SetHorizontalAlignment_ptr;
            static SetHorizontalAlignment_method() {
                SetHorizontalAlignment_ptr = Main.GetMethodUFunction(BackgroundBlur.StaticClass, "SetHorizontalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InHorizontalAlignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InHorizontalAlignment;
                Main.GetProcessEvent(obj, SetHorizontalAlignment_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLowQualityFallbackBrush_method {
            static internal IntPtr SetLowQualityFallbackBrush_ptr;
            static SetLowQualityFallbackBrush_method() {
                SetLowQualityFallbackBrush_ptr = Main.GetMethodUFunction(BackgroundBlur.StaticClass, "SetLowQualityFallbackBrush");
            }

            internal static unsafe void Invoke(IntPtr obj, SlateBrush InBrush) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateBrush*)(b+0)) = InBrush;
                Main.GetProcessEvent(obj, SetLowQualityFallbackBrush_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPadding_method {
            static internal IntPtr SetPadding_ptr;
            static SetPadding_method() {
                SetPadding_ptr = Main.GetMethodUFunction(BackgroundBlur.StaticClass, "SetPadding");
            }

            internal static unsafe void Invoke(IntPtr obj, Margin InPadding) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Margin*)(b+0)) = InPadding;
                Main.GetProcessEvent(obj, SetPadding_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVerticalAlignment_method {
            static internal IntPtr SetVerticalAlignment_ptr;
            static SetVerticalAlignment_method() {
                SetVerticalAlignment_ptr = Main.GetMethodUFunction(BackgroundBlur.StaticClass, "SetVerticalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InVerticalAlignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InVerticalAlignment;
                Main.GetProcessEvent(obj, SetVerticalAlignment_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct BackgroundBlur_events {
    }
}
