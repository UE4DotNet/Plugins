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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1600 )]
    internal unsafe struct TextRenderComponent_fields {
        [FieldOffset(1520)] byte Text; //TODO: text FText Text
        [FieldOffset(1544)]  public IntPtr  TextMaterial;
        [FieldOffset(1552)]  public IntPtr  Font;
        [FieldOffset(1560)] public byte HorizontalAlignment;
        [FieldOffset(1561)] public byte VerticalAlignment;
        [FieldOffset(1564)] public Color TextRenderColor;
        [FieldOffset(1568)] public float XScale;
        [FieldOffset(1572)] public float YScale;
        [FieldOffset(1576)] public float WorldSize;
        [FieldOffset(1580)] public float InvDefaultSize;
        [FieldOffset(1584)] public float HorizSpacingAdjust;
        [FieldOffset(1588)] public float VertSpacingAdjust;
        [FieldOffset(1592)] public bool bAlwaysRenderAsText;
    }
    internal unsafe struct TextRenderComponent_methods {
        internal struct GetTextLocalSize_method {
            static internal IntPtr GetTextLocalSize_ptr;
            static GetTextLocalSize_method() {
                GetTextLocalSize_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "GetTextLocalSize");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTextLocalSize_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetTextWorldSize_method {
            static internal IntPtr GetTextWorldSize_ptr;
            static GetTextWorldSize_method() {
                GetTextWorldSize_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "GetTextWorldSize");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTextWorldSize_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct K2_SetText_method {
            static internal IntPtr K2_SetText_ptr;
            static K2_SetText_method() {
                K2_SetText_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "K2_SetText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Value /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText Value
                Main.GetProcessEvent(obj, K2_SetText_ptr, new IntPtr(p)); ;
                 //TODO: text FText Value
            }
        }
        internal struct SetFont_method {
            static internal IntPtr SetFont_ptr;
            static SetFont_method() {
                SetFont_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetFont");
            }

            internal static unsafe void Invoke(IntPtr obj, Font Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetFont_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHorizontalAlignment_method {
            static internal IntPtr SetHorizontalAlignment_ptr;
            static SetHorizontalAlignment_method() {
                SetHorizontalAlignment_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetHorizontalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Value;
                Main.GetProcessEvent(obj, SetHorizontalAlignment_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHorizSpacingAdjust_method {
            static internal IntPtr SetHorizSpacingAdjust_ptr;
            static SetHorizSpacingAdjust_method() {
                SetHorizSpacingAdjust_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetHorizSpacingAdjust");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetHorizSpacingAdjust_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetText_method {
            static internal IntPtr SetText_ptr;
            static SetText_method() {
                SetText_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetText");
            }

            internal static unsafe void Invoke(IntPtr obj, string Value) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Value_handle = GCHandle.Alloc(Value, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Value_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Value.Length;
                *(int*)(b+IntPtr.Size+4+0) = Value.Length;
                Main.GetProcessEvent(obj, SetText_ptr, new IntPtr(p)); ;
                Value_handle.Free();
            }
        }
        internal struct SetTextMaterial_method {
            static internal IntPtr SetTextMaterial_ptr;
            static SetTextMaterial_method() {
                SetTextMaterial_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetTextMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface Material) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                Main.GetProcessEvent(obj, SetTextMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTextRenderColor_method {
            static internal IntPtr SetTextRenderColor_ptr;
            static SetTextRenderColor_method() {
                SetTextRenderColor_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetTextRenderColor");
            }

            internal static unsafe void Invoke(IntPtr obj, Color Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Color*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetTextRenderColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVerticalAlignment_method {
            static internal IntPtr SetVerticalAlignment_ptr;
            static SetVerticalAlignment_method() {
                SetVerticalAlignment_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetVerticalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Value;
                Main.GetProcessEvent(obj, SetVerticalAlignment_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVertSpacingAdjust_method {
            static internal IntPtr SetVertSpacingAdjust_ptr;
            static SetVertSpacingAdjust_method() {
                SetVertSpacingAdjust_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetVertSpacingAdjust");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetVertSpacingAdjust_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWorldSize_method {
            static internal IntPtr SetWorldSize_ptr;
            static SetWorldSize_method() {
                SetWorldSize_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetWorldSize");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetWorldSize_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetXScale_method {
            static internal IntPtr SetXScale_ptr;
            static SetXScale_method() {
                SetXScale_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetXScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetXScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetYScale_method {
            static internal IntPtr SetYScale_ptr;
            static SetYScale_method() {
                SetYScale_ptr = Main.GetMethodUFunction(TextRenderComponent.StaticClass, "SetYScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetYScale_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct TextRenderComponent_events {
    }
}
