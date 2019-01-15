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
using UE4.Engine;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=784 )]
    internal unsafe struct TextBlock_fields {
        [FieldOffset(416)] byte Text; //TODO: text FText Text
        [FieldOffset(440)] byte TextDelegate; //TODO: delegate FGetText TextDelegate
        [FieldOffset(464)] public SlateColor ColorAndOpacity;
        [FieldOffset(504)] byte ColorAndOpacityDelegate; //TODO: delegate FGetSlateColor ColorAndOpacityDelegate
        [FieldOffset(528)] public SlateFontInfo Font;
        [FieldOffset(632)] public Vector2D ShadowOffset;
        [FieldOffset(640)] public LinearColor ShadowColorAndOpacity;
        [FieldOffset(656)] byte ShadowColorAndOpacityDelegate; //TODO: delegate FGetLinearColor ShadowColorAndOpacityDelegate
        [FieldOffset(676)] public float MinDesiredWidth;
        [FieldOffset(680)] public bool bWrapWithInvalidationPanel;
        [FieldOffset(681)] public bool bAutoWrapText;
    }
    internal unsafe struct TextBlock_methods {
        internal struct GetDynamicFontMaterial_method {
            static internal IntPtr GetDynamicFontMaterial_ptr;
            static GetDynamicFontMaterial_method() {
                GetDynamicFontMaterial_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "GetDynamicFontMaterial");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDynamicFontMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetDynamicOutlineMaterial_method {
            static internal IntPtr GetDynamicOutlineMaterial_ptr;
            static GetDynamicOutlineMaterial_method() {
                GetDynamicOutlineMaterial_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "GetDynamicOutlineMaterial");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDynamicOutlineMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetText_method {
            static internal IntPtr GetText_ptr;
            static GetText_method() {
                GetText_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "GetText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct SetAutoWrapText_method {
            static internal IntPtr SetAutoWrapText_ptr;
            static SetAutoWrapText_method() {
                SetAutoWrapText_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "SetAutoWrapText");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InAutoTextWrap) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InAutoTextWrap;
                Main.GetProcessEvent(obj, SetAutoWrapText_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetColorAndOpacity_method {
            static internal IntPtr SetColorAndOpacity_ptr;
            static SetColorAndOpacity_method() {
                SetColorAndOpacity_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "SetColorAndOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, SlateColor InColorAndOpacity) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateColor*)(b+0)) = InColorAndOpacity;
                Main.GetProcessEvent(obj, SetColorAndOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFont_method {
            static internal IntPtr SetFont_ptr;
            static SetFont_method() {
                SetFont_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "SetFont");
            }

            internal static unsafe void Invoke(IntPtr obj, SlateFontInfo InFontInfo) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateFontInfo*)(b+0)) = InFontInfo;
                Main.GetProcessEvent(obj, SetFont_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetJustification_method {
            static internal IntPtr SetJustification_ptr;
            static SetJustification_method() {
                SetJustification_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "SetJustification");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InJustification) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InJustification;
                Main.GetProcessEvent(obj, SetJustification_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMinDesiredWidth_method {
            static internal IntPtr SetMinDesiredWidth_ptr;
            static SetMinDesiredWidth_method() {
                SetMinDesiredWidth_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "SetMinDesiredWidth");
            }

            internal static unsafe void Invoke(IntPtr obj, float InMinDesiredWidth) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InMinDesiredWidth;
                Main.GetProcessEvent(obj, SetMinDesiredWidth_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOpacity_method {
            static internal IntPtr SetOpacity_ptr;
            static SetOpacity_method() {
                SetOpacity_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "SetOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, float InOpacity) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InOpacity;
                Main.GetProcessEvent(obj, SetOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetShadowColorAndOpacity_method {
            static internal IntPtr SetShadowColorAndOpacity_ptr;
            static SetShadowColorAndOpacity_method() {
                SetShadowColorAndOpacity_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "SetShadowColorAndOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InShadowColorAndOpacity) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InShadowColorAndOpacity;
                Main.GetProcessEvent(obj, SetShadowColorAndOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetShadowOffset_method {
            static internal IntPtr SetShadowOffset_ptr;
            static SetShadowOffset_method() {
                SetShadowOffset_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "SetShadowOffset");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D InShadowOffset) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InShadowOffset;
                Main.GetProcessEvent(obj, SetShadowOffset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetText_method {
            static internal IntPtr SetText_ptr;
            static SetText_method() {
                SetText_ptr = Main.GetMethodUFunction(TextBlock.StaticClass, "SetText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(obj, SetText_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
            }
        }
    }
    internal unsafe struct TextBlock_events {
    }
}
