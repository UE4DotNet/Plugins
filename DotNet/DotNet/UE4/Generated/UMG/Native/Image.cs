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
    [StructLayout( LayoutKind.Explicit, Size=688 )]
    internal unsafe struct Image_fields {
        [FieldOffset(392)] public SlateBrush Brush;
        [FieldOffset(552)] byte BrushDelegate; //TODO: delegate FGetSlateBrush BrushDelegate
        [FieldOffset(572)] public LinearColor ColorAndOpacity;
        [FieldOffset(588)] byte ColorAndOpacityDelegate; //TODO: delegate FGetLinearColor ColorAndOpacityDelegate
        [FieldOffset(608)] byte OnMouseButtonDownEvent; //TODO: delegate FOnPointerEvent OnMouseButtonDownEvent
    }
    internal unsafe struct Image_methods {
        internal struct GetDynamicMaterial_method {
            static internal IntPtr GetDynamicMaterial_ptr;
            static GetDynamicMaterial_method() {
                GetDynamicMaterial_ptr = Main.GetMethodUFunction(Image.StaticClass, "GetDynamicMaterial");
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
                SetBrush_ptr = Main.GetMethodUFunction(Image.StaticClass, "SetBrush");
            }

            internal static unsafe void Invoke(IntPtr obj, SlateBrush InBrush) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateBrush*)(b+0)) = InBrush;
                Main.GetProcessEvent(obj, SetBrush_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushFromAsset_method {
            static internal IntPtr SetBrushFromAsset_ptr;
            static SetBrushFromAsset_method() {
                SetBrushFromAsset_ptr = Main.GetMethodUFunction(Image.StaticClass, "SetBrushFromAsset");
            }

            internal static unsafe void Invoke(IntPtr obj, SlateBrushAsset Asset) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Asset;
                Main.GetProcessEvent(obj, SetBrushFromAsset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushFromAtlasInterface_method {
            static internal IntPtr SetBrushFromAtlasInterface_ptr;
            static SetBrushFromAtlasInterface_method() {
                SetBrushFromAtlasInterface_ptr = Main.GetMethodUFunction(Image.StaticClass, "SetBrushFromAtlasInterface");
            }

            internal static unsafe void Invoke(IntPtr obj, byte AtlasRegion /*TODO: interface TScriptInterface */, bool bMatchSize) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface AtlasRegion
                *((bool*)(b+16)) = bMatchSize;
                Main.GetProcessEvent(obj, SetBrushFromAtlasInterface_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface AtlasRegion
            }
        }
        internal struct SetBrushFromMaterial_method {
            static internal IntPtr SetBrushFromMaterial_ptr;
            static SetBrushFromMaterial_method() {
                SetBrushFromMaterial_ptr = Main.GetMethodUFunction(Image.StaticClass, "SetBrushFromMaterial");
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
                SetBrushFromTexture_ptr = Main.GetMethodUFunction(Image.StaticClass, "SetBrushFromTexture");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture2D Texture, bool bMatchSize) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                *((bool*)(b+8)) = bMatchSize;
                Main.GetProcessEvent(obj, SetBrushFromTexture_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushFromTextureDynamic_method {
            static internal IntPtr SetBrushFromTextureDynamic_ptr;
            static SetBrushFromTextureDynamic_method() {
                SetBrushFromTextureDynamic_ptr = Main.GetMethodUFunction(Image.StaticClass, "SetBrushFromTextureDynamic");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture2DDynamic Texture, bool bMatchSize) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                *((bool*)(b+8)) = bMatchSize;
                Main.GetProcessEvent(obj, SetBrushFromTextureDynamic_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushSize_method {
            static internal IntPtr SetBrushSize_ptr;
            static SetBrushSize_method() {
                SetBrushSize_ptr = Main.GetMethodUFunction(Image.StaticClass, "SetBrushSize");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D DesiredSize) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = DesiredSize;
                Main.GetProcessEvent(obj, SetBrushSize_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushTintColor_method {
            static internal IntPtr SetBrushTintColor_ptr;
            static SetBrushTintColor_method() {
                SetBrushTintColor_ptr = Main.GetMethodUFunction(Image.StaticClass, "SetBrushTintColor");
            }

            internal static unsafe void Invoke(IntPtr obj, SlateColor TintColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateColor*)(b+0)) = TintColor;
                Main.GetProcessEvent(obj, SetBrushTintColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetColorAndOpacity_method {
            static internal IntPtr SetColorAndOpacity_ptr;
            static SetColorAndOpacity_method() {
                SetColorAndOpacity_ptr = Main.GetMethodUFunction(Image.StaticClass, "SetColorAndOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InColorAndOpacity) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InColorAndOpacity;
                Main.GetProcessEvent(obj, SetColorAndOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOpacity_method {
            static internal IntPtr SetOpacity_ptr;
            static SetOpacity_method() {
                SetOpacity_ptr = Main.GetMethodUFunction(Image.StaticClass, "SetOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, float InOpacity) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InOpacity;
                Main.GetProcessEvent(obj, SetOpacity_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Image_events {
    }
}
