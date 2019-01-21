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
    [StructLayout( LayoutKind.Explicit, Size=824 )]
    internal unsafe struct Border_fields {
        [FieldOffset(424)] public byte HorizontalAlignment;
        [FieldOffset(425)] public byte VerticalAlignment;
        [FieldOffset(426)] public bool bShowEffectWhenDisabled;
        [FieldOffset(428)] public LinearColor ContentColorAndOpacity;
        [FieldOffset(444)] byte ContentColorAndOpacityDelegate; //TODO: delegate FGetLinearColor ContentColorAndOpacityDelegate
        [FieldOffset(464)] public Margin Padding;
        [FieldOffset(480)] public SlateBrush Background;
        [FieldOffset(640)] byte BackgroundDelegate; //TODO: delegate FGetSlateBrush BackgroundDelegate
        [FieldOffset(660)] public LinearColor BrushColor;
        [FieldOffset(676)] byte BrushColorDelegate; //TODO: delegate FGetLinearColor BrushColorDelegate
        [FieldOffset(696)] public Vector2D DesiredSizeScale;
        [FieldOffset(704)] byte OnMouseButtonDownEvent; //TODO: delegate FOnPointerEvent OnMouseButtonDownEvent
        [FieldOffset(724)] byte OnMouseButtonUpEvent; //TODO: delegate FOnPointerEvent OnMouseButtonUpEvent
        [FieldOffset(744)] byte OnMouseMoveEvent; //TODO: delegate FOnPointerEvent OnMouseMoveEvent
        [FieldOffset(764)] byte OnMouseDoubleClickEvent; //TODO: delegate FOnPointerEvent OnMouseDoubleClickEvent
    }
    internal unsafe struct Border_methods {
        internal struct GetDynamicMaterial_method {
            static internal IntPtr GetDynamicMaterial_ptr;
            static GetDynamicMaterial_method() {
                GetDynamicMaterial_ptr = Main.GetMethodUFunction(Border.StaticClass, "GetDynamicMaterial");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDynamicMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SetBrush_method {
            static internal IntPtr SetBrush_ptr;
            static SetBrush_method() {
                SetBrush_ptr = Main.GetMethodUFunction(Border.StaticClass, "SetBrush");
            }

            internal static unsafe void Invoke(IntPtr obj, SlateBrush InBrush) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateBrush*)(b+0)) = InBrush;
                Main.GetProcessEvent(obj, SetBrush_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushColor_method {
            static internal IntPtr SetBrushColor_ptr;
            static SetBrushColor_method() {
                SetBrushColor_ptr = Main.GetMethodUFunction(Border.StaticClass, "SetBrushColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InBrushColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InBrushColor;
                Main.GetProcessEvent(obj, SetBrushColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushFromAsset_method {
            static internal IntPtr SetBrushFromAsset_ptr;
            static SetBrushFromAsset_method() {
                SetBrushFromAsset_ptr = Main.GetMethodUFunction(Border.StaticClass, "SetBrushFromAsset");
            }

            internal static unsafe void Invoke(IntPtr obj, SlateBrushAsset Asset) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Asset;
                Main.GetProcessEvent(obj, SetBrushFromAsset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushFromMaterial_method {
            static internal IntPtr SetBrushFromMaterial_ptr;
            static SetBrushFromMaterial_method() {
                SetBrushFromMaterial_ptr = Main.GetMethodUFunction(Border.StaticClass, "SetBrushFromMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface Material) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                Main.GetProcessEvent(obj, SetBrushFromMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushFromTexture_method {
            static internal IntPtr SetBrushFromTexture_ptr;
            static SetBrushFromTexture_method() {
                SetBrushFromTexture_ptr = Main.GetMethodUFunction(Border.StaticClass, "SetBrushFromTexture");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture2D Texture) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                Main.GetProcessEvent(obj, SetBrushFromTexture_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetContentColorAndOpacity_method {
            static internal IntPtr SetContentColorAndOpacity_ptr;
            static SetContentColorAndOpacity_method() {
                SetContentColorAndOpacity_ptr = Main.GetMethodUFunction(Border.StaticClass, "SetContentColorAndOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InContentColorAndOpacity) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InContentColorAndOpacity;
                Main.GetProcessEvent(obj, SetContentColorAndOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDesiredSizeScale_method {
            static internal IntPtr SetDesiredSizeScale_ptr;
            static SetDesiredSizeScale_method() {
                SetDesiredSizeScale_ptr = Main.GetMethodUFunction(Border.StaticClass, "SetDesiredSizeScale");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D InScale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InScale;
                Main.GetProcessEvent(obj, SetDesiredSizeScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHorizontalAlignment_method {
            static internal IntPtr SetHorizontalAlignment_ptr;
            static SetHorizontalAlignment_method() {
                SetHorizontalAlignment_ptr = Main.GetMethodUFunction(Border.StaticClass, "SetHorizontalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InHorizontalAlignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InHorizontalAlignment;
                Main.GetProcessEvent(obj, SetHorizontalAlignment_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPadding_method {
            static internal IntPtr SetPadding_ptr;
            static SetPadding_method() {
                SetPadding_ptr = Main.GetMethodUFunction(Border.StaticClass, "SetPadding");
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
                SetVerticalAlignment_ptr = Main.GetMethodUFunction(Border.StaticClass, "SetVerticalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InVerticalAlignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InVerticalAlignment;
                Main.GetProcessEvent(obj, SetVerticalAlignment_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Border_events {
    }
}
