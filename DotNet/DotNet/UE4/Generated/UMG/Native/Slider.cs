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
    [StructLayout( LayoutKind.Explicit, Size=1216 )]
    internal unsafe struct Slider_fields {
        [FieldOffset(384)] public float Value;
        [FieldOffset(388)] byte ValueDelegate; //TODO: delegate FGetFloat ValueDelegate
        [FieldOffset(408)] public SliderStyle WidgetStyle;
        [FieldOffset(1064)] public byte Orientation;
        [FieldOffset(1068)] public LinearColor SliderBarColor;
        [FieldOffset(1084)] public LinearColor SliderHandleColor;
        [FieldOffset(1100)] public bool IndentHandle;
        [FieldOffset(1101)] public bool Locked;
        [FieldOffset(1104)] public float StepSize;
        [FieldOffset(1108)] public bool IsFocusable;
        [FieldOffset(1112)] byte OnMouseCaptureBegin; //TODO: multicast delegate FOnMouseCaptureBeginEvent OnMouseCaptureBegin
        [FieldOffset(1128)] byte OnMouseCaptureEnd; //TODO: multicast delegate FOnMouseCaptureEndEvent OnMouseCaptureEnd
        [FieldOffset(1144)] byte OnControllerCaptureBegin; //TODO: multicast delegate FOnControllerCaptureBeginEvent OnControllerCaptureBegin
        [FieldOffset(1160)] byte OnControllerCaptureEnd; //TODO: multicast delegate FOnControllerCaptureEndEvent OnControllerCaptureEnd
        [FieldOffset(1176)] byte OnValueChanged; //TODO: multicast delegate FOnFloatValueChangedEvent OnValueChanged
    }
    internal unsafe struct Slider_methods {
        internal struct GetValue_method {
            static internal IntPtr GetValue_ptr;
            static GetValue_method() {
                GetValue_ptr = Main.GetMethodUFunction(Slider.StaticClass, "GetValue");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct SetIndentHandle_method {
            static internal IntPtr SetIndentHandle_ptr;
            static SetIndentHandle_method() {
                SetIndentHandle_ptr = Main.GetMethodUFunction(Slider.StaticClass, "SetIndentHandle");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InValue;
                Main.GetProcessEvent(obj, SetIndentHandle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLocked_method {
            static internal IntPtr SetLocked_ptr;
            static SetLocked_method() {
                SetLocked_ptr = Main.GetMethodUFunction(Slider.StaticClass, "SetLocked");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InValue;
                Main.GetProcessEvent(obj, SetLocked_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSliderBarColor_method {
            static internal IntPtr SetSliderBarColor_ptr;
            static SetSliderBarColor_method() {
                SetSliderBarColor_ptr = Main.GetMethodUFunction(Slider.StaticClass, "SetSliderBarColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InValue;
                Main.GetProcessEvent(obj, SetSliderBarColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSliderHandleColor_method {
            static internal IntPtr SetSliderHandleColor_ptr;
            static SetSliderHandleColor_method() {
                SetSliderHandleColor_ptr = Main.GetMethodUFunction(Slider.StaticClass, "SetSliderHandleColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InValue;
                Main.GetProcessEvent(obj, SetSliderHandleColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStepSize_method {
            static internal IntPtr SetStepSize_ptr;
            static SetStepSize_method() {
                SetStepSize_ptr = Main.GetMethodUFunction(Slider.StaticClass, "SetStepSize");
            }

            internal static unsafe void Invoke(IntPtr obj, float InValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InValue;
                Main.GetProcessEvent(obj, SetStepSize_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetValue_method {
            static internal IntPtr SetValue_ptr;
            static SetValue_method() {
                SetValue_ptr = Main.GetMethodUFunction(Slider.StaticClass, "SetValue");
            }

            internal static unsafe void Invoke(IntPtr obj, float InValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InValue;
                Main.GetProcessEvent(obj, SetValue_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Slider_events {
    }
}
