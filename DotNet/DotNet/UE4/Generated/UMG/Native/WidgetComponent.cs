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

using UE4.Engine;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=1856 )]
    internal unsafe struct WidgetComponent_fields {
        [FieldOffset(1560)] byte Space; //TODO: enum EWidgetSpace Space
        [FieldOffset(1561)] byte TimingPolicy; //TODO: enum EWidgetTimingPolicy TimingPolicy
        [FieldOffset(1568)] public IntPtr WidgetClass;
        [FieldOffset(1576)] public IntPoint DrawSize;
        [FieldOffset(1584)] public bool bManuallyRedraw;
        [FieldOffset(1585)] public bool bRedrawRequested;
        [FieldOffset(1588)] public float RedrawTime;
        [FieldOffset(1600)] public IntPoint CurrentDrawSize;
        [FieldOffset(1608)] public bool bDrawAtDesiredSize;
        [FieldOffset(1612)] public Vector2D Pivot;
        [FieldOffset(1620)] public bool bReceiveHardwareInput;
        [FieldOffset(1621)] public bool bWindowFocusable;
        [FieldOffset(1622)] public bool bApplyGammaCorrection;
        [FieldOffset(1624)]  public IntPtr  OwnerPlayer;
        [FieldOffset(1632)] public LinearColor BackgroundColor;
        [FieldOffset(1648)] public LinearColor TintColorAndOpacity;
        [FieldOffset(1664)] public float OpacityFromTexture;
        [FieldOffset(1668)] byte BlendMode; //TODO: enum EWidgetBlendMode BlendMode
        [FieldOffset(1669)] public bool bIsTwoSided;
        [FieldOffset(1670)] public bool TickWhenOffscreen;
        [FieldOffset(1672)]  public IntPtr  Widget;
        [FieldOffset(1712)]  public IntPtr  BodySetup;
        [FieldOffset(1720)]  public IntPtr  TranslucentMaterial;
        [FieldOffset(1728)]  public IntPtr  TranslucentMaterial_OneSided;
        [FieldOffset(1736)]  public IntPtr  OpaqueMaterial;
        [FieldOffset(1744)]  public IntPtr  OpaqueMaterial_OneSided;
        [FieldOffset(1752)]  public IntPtr  MaskedMaterial;
        [FieldOffset(1760)]  public IntPtr  MaskedMaterial_OneSided;
        [FieldOffset(1768)]  public IntPtr  RenderTarget;
        [FieldOffset(1776)]  public IntPtr  MaterialInstance;
        [FieldOffset(1784)] public bool bAddedToScreen;
        [FieldOffset(1785)] public bool bEditTimeUsable;
        [FieldOffset(1788)] public Name SharedLayerName;
        [FieldOffset(1800)] public int LayerZOrder;
        [FieldOffset(1804)] byte GeometryMode; //TODO: enum EWidgetGeometryMode GeometryMode
        [FieldOffset(1808)] public float CylinderArcAngle;
    }
    internal unsafe struct WidgetComponent_methods {
        internal struct GetDrawSize_method {
            static internal IntPtr GetDrawSize_ptr;
            static GetDrawSize_method() {
                GetDrawSize_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "GetDrawSize");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDrawSize_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetMaterialInstance_method {
            static internal IntPtr GetMaterialInstance_ptr;
            static GetMaterialInstance_method() {
                GetMaterialInstance_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "GetMaterialInstance");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMaterialInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetOwnerPlayer_method {
            static internal IntPtr GetOwnerPlayer_ptr;
            static GetOwnerPlayer_method() {
                GetOwnerPlayer_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "GetOwnerPlayer");
            }

            internal static unsafe LocalPlayer Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwnerPlayer_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetRenderTarget_method {
            static internal IntPtr GetRenderTarget_ptr;
            static GetRenderTarget_method() {
                GetRenderTarget_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "GetRenderTarget");
            }

            internal static unsafe TextureRenderTarget2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetRenderTarget_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetUserWidgetObject_method {
            static internal IntPtr GetUserWidgetObject_ptr;
            static GetUserWidgetObject_method() {
                GetUserWidgetObject_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "GetUserWidgetObject");
            }

            internal static unsafe UserWidget Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUserWidgetObject_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct RequestRedraw_method {
            static internal IntPtr RequestRedraw_ptr;
            static RequestRedraw_method() {
                RequestRedraw_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "RequestRedraw");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RequestRedraw_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBackgroundColor_method {
            static internal IntPtr SetBackgroundColor_ptr;
            static SetBackgroundColor_method() {
                SetBackgroundColor_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "SetBackgroundColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewBackgroundColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewBackgroundColor;
                Main.GetProcessEvent(obj, SetBackgroundColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDrawSize_method {
            static internal IntPtr SetDrawSize_ptr;
            static SetDrawSize_method() {
                SetDrawSize_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "SetDrawSize");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D Size) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Size;
                Main.GetProcessEvent(obj, SetDrawSize_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetManuallyRedraw_method {
            static internal IntPtr SetManuallyRedraw_ptr;
            static SetManuallyRedraw_method() {
                SetManuallyRedraw_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "SetManuallyRedraw");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bUseManualRedraw) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bUseManualRedraw;
                Main.GetProcessEvent(obj, SetManuallyRedraw_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOwnerPlayer_method {
            static internal IntPtr SetOwnerPlayer_ptr;
            static SetOwnerPlayer_method() {
                SetOwnerPlayer_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "SetOwnerPlayer");
            }

            internal static unsafe void Invoke(IntPtr obj, LocalPlayer LocalPlayer) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = LocalPlayer;
                Main.GetProcessEvent(obj, SetOwnerPlayer_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTintColorAndOpacity_method {
            static internal IntPtr SetTintColorAndOpacity_ptr;
            static SetTintColorAndOpacity_method() {
                SetTintColorAndOpacity_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "SetTintColorAndOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewTintColorAndOpacity) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewTintColorAndOpacity;
                Main.GetProcessEvent(obj, SetTintColorAndOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWidget_method {
            static internal IntPtr SetWidget_ptr;
            static SetWidget_method() {
                SetWidget_ptr = Main.GetMethodUFunction(WidgetComponent.StaticClass, "SetWidget");
            }

            internal static unsafe void Invoke(IntPtr obj, UserWidget Widget) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Widget;
                Main.GetProcessEvent(obj, SetWidget_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct WidgetComponent_events {
    }
}
