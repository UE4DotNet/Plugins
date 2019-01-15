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
    [StructLayout( LayoutKind.Explicit, Size=1560 )]
    internal unsafe struct SpinBox_fields {
        [FieldOffset(384)] public float Value;
        [FieldOffset(388)] byte ValueDelegate; //TODO: delegate FGetFloat ValueDelegate
        [FieldOffset(408)] public SpinBoxStyle WidgetStyle;
        [FieldOffset(1280)] public float Delta;
        [FieldOffset(1284)] public float SliderExponent;
        [FieldOffset(1288)] public SlateFontInfo Font;
        [FieldOffset(1392)] public byte Justification;
        [FieldOffset(1396)] public float MinDesiredWidth;
        [FieldOffset(1400)] public bool ClearKeyboardFocusOnCommit;
        [FieldOffset(1401)] public bool SelectAllTextOnCommit;
        [FieldOffset(1408)] public SlateColor ForegroundColor;
        [FieldOffset(1448)] byte OnValueChanged; //TODO: multicast delegate FOnSpinBoxValueChangedEvent OnValueChanged
        [FieldOffset(1464)] byte OnValueCommitted; //TODO: multicast delegate FOnSpinBoxValueCommittedEvent OnValueCommitted
        [FieldOffset(1480)] byte OnBeginSliderMovement; //TODO: multicast delegate FOnSpinBoxBeginSliderMovement OnBeginSliderMovement
        [FieldOffset(1496)] byte OnEndSliderMovement; //TODO: multicast delegate FOnSpinBoxValueChangedEvent OnEndSliderMovement
        [FieldOffset(1512)] public bool bOverride_MinValue;
        [FieldOffset(1512)] public bool bOverride_MaxValue;
        [FieldOffset(1512)] public bool bOverride_MinSliderValue;
        [FieldOffset(1512)] public bool bOverride_MaxSliderValue;
        [FieldOffset(1516)] public float MinValue;
        [FieldOffset(1520)] public float MaxValue;
        [FieldOffset(1524)] public float MinSliderValue;
        [FieldOffset(1528)] public float MaxSliderValue;
    }
    internal unsafe struct SpinBox_methods {
        internal struct ClearMaxSliderValue_method {
            static internal IntPtr ClearMaxSliderValue_ptr;
            static ClearMaxSliderValue_method() {
                ClearMaxSliderValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "ClearMaxSliderValue");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMaxSliderValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMaxValue_method {
            static internal IntPtr ClearMaxValue_ptr;
            static ClearMaxValue_method() {
                ClearMaxValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "ClearMaxValue");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMaxValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMinSliderValue_method {
            static internal IntPtr ClearMinSliderValue_ptr;
            static ClearMinSliderValue_method() {
                ClearMinSliderValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "ClearMinSliderValue");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMinSliderValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMinValue_method {
            static internal IntPtr ClearMinValue_ptr;
            static ClearMinValue_method() {
                ClearMinValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "ClearMinValue");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMinValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetMaxSliderValue_method {
            static internal IntPtr GetMaxSliderValue_ptr;
            static GetMaxSliderValue_method() {
                GetMaxSliderValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "GetMaxSliderValue");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMaxSliderValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMaxValue_method {
            static internal IntPtr GetMaxValue_ptr;
            static GetMaxValue_method() {
                GetMaxValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "GetMaxValue");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMaxValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMinSliderValue_method {
            static internal IntPtr GetMinSliderValue_ptr;
            static GetMinSliderValue_method() {
                GetMinSliderValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "GetMinSliderValue");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMinSliderValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMinValue_method {
            static internal IntPtr GetMinValue_ptr;
            static GetMinValue_method() {
                GetMinValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "GetMinValue");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMinValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetValue_method {
            static internal IntPtr GetValue_ptr;
            static GetValue_method() {
                GetValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "GetValue");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct SetForegroundColor_method {
            static internal IntPtr SetForegroundColor_ptr;
            static SetForegroundColor_method() {
                SetForegroundColor_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "SetForegroundColor");
            }

            internal static unsafe void Invoke(IntPtr obj, SlateColor InForegroundColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateColor*)(b+0)) = InForegroundColor;
                Main.GetProcessEvent(obj, SetForegroundColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaxSliderValue_method {
            static internal IntPtr SetMaxSliderValue_ptr;
            static SetMaxSliderValue_method() {
                SetMaxSliderValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "SetMaxSliderValue");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetMaxSliderValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaxValue_method {
            static internal IntPtr SetMaxValue_ptr;
            static SetMaxValue_method() {
                SetMaxValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "SetMaxValue");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetMaxValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMinSliderValue_method {
            static internal IntPtr SetMinSliderValue_ptr;
            static SetMinSliderValue_method() {
                SetMinSliderValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "SetMinSliderValue");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetMinSliderValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMinValue_method {
            static internal IntPtr SetMinValue_ptr;
            static SetMinValue_method() {
                SetMinValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "SetMinValue");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetMinValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetValue_method {
            static internal IntPtr SetValue_ptr;
            static SetValue_method() {
                SetValue_ptr = Main.GetMethodUFunction(SpinBox.StaticClass, "SetValue");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetValue_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SpinBox_events {
    }
}
