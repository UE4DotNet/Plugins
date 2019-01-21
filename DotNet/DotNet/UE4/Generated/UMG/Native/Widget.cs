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
    [StructLayout( LayoutKind.Explicit, Size=400 )]
    internal unsafe struct Widget_fields {
        [FieldOffset(56)]  public IntPtr  Slot;
        [FieldOffset(64)] byte bIsEnabledDelegate; //TODO: delegate FGetBool bIsEnabledDelegate
        [FieldOffset(88)] byte ToolTipText; //TODO: text FText ToolTipText
        [FieldOffset(112)] byte ToolTipTextDelegate; //TODO: delegate FGetText ToolTipTextDelegate
        [FieldOffset(136)]  public IntPtr  ToolTipWidget;
        [FieldOffset(144)] byte ToolTipWidgetDelegate; //TODO: delegate FGetWidget ToolTipWidgetDelegate
        [FieldOffset(164)] byte VisibilityDelegate; //TODO: delegate FGetSlateVisibility VisibilityDelegate
        [FieldOffset(184)] public WidgetTransform RenderTransform;
        [FieldOffset(212)] public Vector2D RenderTransformPivot;
        [FieldOffset(220)] public bool bIsVariable;
        [FieldOffset(220)] public bool bCreatedByConstructionScript;
        [FieldOffset(220)] public bool bIsEnabled;
        [FieldOffset(220)] public bool bOverride_Cursor;
        [FieldOffset(220)] public bool bIsVolatile;
        [FieldOffset(220)] public bool bHiddenInDesigner;
        [FieldOffset(220)] public bool bExpandedInDesigner;
        [FieldOffset(220)] public bool bLockedInDesigner;
        [FieldOffset(221)] public byte Cursor;
        [FieldOffset(222)] byte Clipping; //TODO: enum EWidgetClipping Clipping
        [FieldOffset(223)] byte Visibility; //TODO: enum ESlateVisibility Visibility
        [FieldOffset(224)] public float RenderOpacity;
        [FieldOffset(232)]  public IntPtr  Navigation;
        [FieldOffset(288)] public NativeArray NativeBindings;
        [FieldOffset(304)] public byte DesignerFlags;
        [FieldOffset(312)] byte DisplayLabel; //TODO: string FString DisplayLabel
        [FieldOffset(344)] byte CategoryName; //TODO: string FString CategoryName
    }
    internal unsafe struct Widget_methods {
        internal struct ForceLayoutPrepass_method {
            static internal IntPtr ForceLayoutPrepass_ptr;
            static ForceLayoutPrepass_method() {
                ForceLayoutPrepass_ptr = Main.GetMethodUFunction(Widget.StaticClass, "ForceLayoutPrepass");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ForceLayoutPrepass_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ForceVolatile_method {
            static internal IntPtr ForceVolatile_ptr;
            static ForceVolatile_method() {
                ForceVolatile_ptr = Main.GetMethodUFunction(Widget.StaticClass, "ForceVolatile");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bForce) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bForce;
                Main.GetProcessEvent(obj, ForceVolatile_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetCachedGeometry_method {
            static internal IntPtr GetCachedGeometry_ptr;
            static GetCachedGeometry_method() {
                GetCachedGeometry_ptr = Main.GetMethodUFunction(Widget.StaticClass, "GetCachedGeometry");
            }

            internal static unsafe void Invoke(IntPtr obj, Geometry ReturnValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Geometry*)(b+0)) = ReturnValue;
                Main.GetProcessEvent(obj, GetCachedGeometry_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetClipping_method {
            static internal IntPtr GetClipping_ptr;
            static GetClipping_method() {
                GetClipping_ptr = Main.GetMethodUFunction(Widget.StaticClass, "GetClipping");
            }

            internal static unsafe EWidgetClipping Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetClipping_ptr, new IntPtr(p)); ;
                return *((EWidgetClipping*)(b+0));
            }
        }
        internal struct GetDesiredSize_method {
            static internal IntPtr GetDesiredSize_ptr;
            static GetDesiredSize_method() {
                GetDesiredSize_ptr = Main.GetMethodUFunction(Widget.StaticClass, "GetDesiredSize");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDesiredSize_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetIsEnabled_method {
            static internal IntPtr GetIsEnabled_ptr;
            static GetIsEnabled_method() {
                GetIsEnabled_ptr = Main.GetMethodUFunction(Widget.StaticClass, "GetIsEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetIsEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetOwningLocalPlayer_method {
            static internal IntPtr GetOwningLocalPlayer_ptr;
            static GetOwningLocalPlayer_method() {
                GetOwningLocalPlayer_ptr = Main.GetMethodUFunction(Widget.StaticClass, "GetOwningLocalPlayer");
            }

            internal static unsafe LocalPlayer Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwningLocalPlayer_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetOwningPlayer_method {
            static internal IntPtr GetOwningPlayer_ptr;
            static GetOwningPlayer_method() {
                GetOwningPlayer_ptr = Main.GetMethodUFunction(Widget.StaticClass, "GetOwningPlayer");
            }

            internal static unsafe PlayerController Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwningPlayer_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetParent_method {
            static internal IntPtr GetParent_ptr;
            static GetParent_method() {
                GetParent_ptr = Main.GetMethodUFunction(Widget.StaticClass, "GetParent");
            }

            internal static unsafe PanelWidget Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetParent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetRenderOpacity_method {
            static internal IntPtr GetRenderOpacity_ptr;
            static GetRenderOpacity_method() {
                GetRenderOpacity_ptr = Main.GetMethodUFunction(Widget.StaticClass, "GetRenderOpacity");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetRenderOpacity_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetVisibility_method {
            static internal IntPtr GetVisibility_ptr;
            static GetVisibility_method() {
                GetVisibility_ptr = Main.GetMethodUFunction(Widget.StaticClass, "GetVisibility");
            }

            internal static unsafe ESlateVisibility Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetVisibility_ptr, new IntPtr(p)); ;
                return *((ESlateVisibility*)(b+0));
            }
        }
        internal struct HasAnyUserFocus_method {
            static internal IntPtr HasAnyUserFocus_ptr;
            static HasAnyUserFocus_method() {
                HasAnyUserFocus_ptr = Main.GetMethodUFunction(Widget.StaticClass, "HasAnyUserFocus");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasAnyUserFocus_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct HasFocusedDescendants_method {
            static internal IntPtr HasFocusedDescendants_ptr;
            static HasFocusedDescendants_method() {
                HasFocusedDescendants_ptr = Main.GetMethodUFunction(Widget.StaticClass, "HasFocusedDescendants");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasFocusedDescendants_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct HasKeyboardFocus_method {
            static internal IntPtr HasKeyboardFocus_ptr;
            static HasKeyboardFocus_method() {
                HasKeyboardFocus_ptr = Main.GetMethodUFunction(Widget.StaticClass, "HasKeyboardFocus");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasKeyboardFocus_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct HasMouseCapture_method {
            static internal IntPtr HasMouseCapture_ptr;
            static HasMouseCapture_method() {
                HasMouseCapture_ptr = Main.GetMethodUFunction(Widget.StaticClass, "HasMouseCapture");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasMouseCapture_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct HasMouseCaptureByUser_method {
            static internal IntPtr HasMouseCaptureByUser_ptr;
            static HasMouseCaptureByUser_method() {
                HasMouseCaptureByUser_ptr = Main.GetMethodUFunction(Widget.StaticClass, "HasMouseCaptureByUser");
            }

            internal static unsafe bool Invoke(IntPtr obj, int UserIndex, int PointerIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = UserIndex;
                *((int*)(b+4)) = PointerIndex;
                Main.GetProcessEvent(obj, HasMouseCaptureByUser_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct HasUserFocus_method {
            static internal IntPtr HasUserFocus_ptr;
            static HasUserFocus_method() {
                HasUserFocus_ptr = Main.GetMethodUFunction(Widget.StaticClass, "HasUserFocus");
            }

            internal static unsafe bool Invoke(IntPtr obj, PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                Main.GetProcessEvent(obj, HasUserFocus_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct HasUserFocusedDescendants_method {
            static internal IntPtr HasUserFocusedDescendants_ptr;
            static HasUserFocusedDescendants_method() {
                HasUserFocusedDescendants_ptr = Main.GetMethodUFunction(Widget.StaticClass, "HasUserFocusedDescendants");
            }

            internal static unsafe bool Invoke(IntPtr obj, PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                Main.GetProcessEvent(obj, HasUserFocusedDescendants_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct InvalidateLayoutAndVolatility_method {
            static internal IntPtr InvalidateLayoutAndVolatility_ptr;
            static InvalidateLayoutAndVolatility_method() {
                InvalidateLayoutAndVolatility_ptr = Main.GetMethodUFunction(Widget.StaticClass, "InvalidateLayoutAndVolatility");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, InvalidateLayoutAndVolatility_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsHovered_method {
            static internal IntPtr IsHovered_ptr;
            static IsHovered_method() {
                IsHovered_ptr = Main.GetMethodUFunction(Widget.StaticClass, "IsHovered");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsHovered_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsVisible_method {
            static internal IntPtr IsVisible_ptr;
            static IsVisible_method() {
                IsVisible_ptr = Main.GetMethodUFunction(Widget.StaticClass, "IsVisible");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsVisible_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct RemoveFromParent_method {
            static internal IntPtr RemoveFromParent_ptr;
            static RemoveFromParent_method() {
                RemoveFromParent_ptr = Main.GetMethodUFunction(Widget.StaticClass, "RemoveFromParent");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RemoveFromParent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetCursor_method {
            static internal IntPtr ResetCursor_ptr;
            static ResetCursor_method() {
                ResetCursor_ptr = Main.GetMethodUFunction(Widget.StaticClass, "ResetCursor");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetCursor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllNavigationRules_method {
            static internal IntPtr SetAllNavigationRules_ptr;
            static SetAllNavigationRules_method() {
                SetAllNavigationRules_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetAllNavigationRules");
            }

            internal static unsafe void Invoke(IntPtr obj, EUINavigationRule Rule, Name WidgetToFocus) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Rule;
                *((Name*)(b+4)) = WidgetToFocus;
                Main.GetProcessEvent(obj, SetAllNavigationRules_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetClipping_method {
            static internal IntPtr SetClipping_ptr;
            static SetClipping_method() {
                SetClipping_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetClipping");
            }

            internal static unsafe void Invoke(IntPtr obj, EWidgetClipping InClipping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)InClipping;
                Main.GetProcessEvent(obj, SetClipping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCursor_method {
            static internal IntPtr SetCursor_ptr;
            static SetCursor_method() {
                SetCursor_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetCursor");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InCursor) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InCursor;
                Main.GetProcessEvent(obj, SetCursor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIsEnabled_method {
            static internal IntPtr SetIsEnabled_ptr;
            static SetIsEnabled_method() {
                SetIsEnabled_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetIsEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInIsEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInIsEnabled;
                Main.GetProcessEvent(obj, SetIsEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetKeyboardFocus_method {
            static internal IntPtr SetKeyboardFocus_ptr;
            static SetKeyboardFocus_method() {
                SetKeyboardFocus_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetKeyboardFocus");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SetKeyboardFocus_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetNavigationRule_method {
            static internal IntPtr SetNavigationRule_ptr;
            static SetNavigationRule_method() {
                SetNavigationRule_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetNavigationRule");
            }

            internal static unsafe void Invoke(IntPtr obj, EUINavigation Direction, EUINavigationRule Rule, Name WidgetToFocus) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Direction;
                *(b+1) = (byte)Rule;
                *((Name*)(b+4)) = WidgetToFocus;
                Main.GetProcessEvent(obj, SetNavigationRule_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderAngle_method {
            static internal IntPtr SetRenderAngle_ptr;
            static SetRenderAngle_method() {
                SetRenderAngle_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetRenderAngle");
            }

            internal static unsafe void Invoke(IntPtr obj, float Angle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Angle;
                Main.GetProcessEvent(obj, SetRenderAngle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderOpacity_method {
            static internal IntPtr SetRenderOpacity_ptr;
            static SetRenderOpacity_method() {
                SetRenderOpacity_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetRenderOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, float InOpacity) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InOpacity;
                Main.GetProcessEvent(obj, SetRenderOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderScale_method {
            static internal IntPtr SetRenderScale_ptr;
            static SetRenderScale_method() {
                SetRenderScale_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetRenderScale");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D Scale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Scale;
                Main.GetProcessEvent(obj, SetRenderScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderShear_method {
            static internal IntPtr SetRenderShear_ptr;
            static SetRenderShear_method() {
                SetRenderShear_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetRenderShear");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D Shear) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Shear;
                Main.GetProcessEvent(obj, SetRenderShear_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderTransform_method {
            static internal IntPtr SetRenderTransform_ptr;
            static SetRenderTransform_method() {
                SetRenderTransform_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetRenderTransform");
            }

            internal static unsafe void Invoke(IntPtr obj, WidgetTransform InTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((WidgetTransform*)(b+0)) = InTransform;
                Main.GetProcessEvent(obj, SetRenderTransform_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderTransformPivot_method {
            static internal IntPtr SetRenderTransformPivot_ptr;
            static SetRenderTransformPivot_method() {
                SetRenderTransformPivot_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetRenderTransformPivot");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D Pivot) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Pivot;
                Main.GetProcessEvent(obj, SetRenderTransformPivot_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderTranslation_method {
            static internal IntPtr SetRenderTranslation_ptr;
            static SetRenderTranslation_method() {
                SetRenderTranslation_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetRenderTranslation");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D Translation) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Translation;
                Main.GetProcessEvent(obj, SetRenderTranslation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetToolTip_method {
            static internal IntPtr SetToolTip_ptr;
            static SetToolTip_method() {
                SetToolTip_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetToolTip");
            }

            internal static unsafe void Invoke(IntPtr obj, Widget Widget) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Widget;
                Main.GetProcessEvent(obj, SetToolTip_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetToolTipText_method {
            static internal IntPtr SetToolTipText_ptr;
            static SetToolTipText_method() {
                SetToolTipText_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetToolTipText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InToolTipText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InToolTipText
                Main.GetProcessEvent(obj, SetToolTipText_ptr, new IntPtr(p)); ;
                 //TODO: text FText InToolTipText
            }
        }
        internal struct SetUserFocus_method {
            static internal IntPtr SetUserFocus_ptr;
            static SetUserFocus_method() {
                SetUserFocus_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetUserFocus");
            }

            internal static unsafe void Invoke(IntPtr obj, PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                Main.GetProcessEvent(obj, SetUserFocus_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVisibility_method {
            static internal IntPtr SetVisibility_ptr;
            static SetVisibility_method() {
                SetVisibility_ptr = Main.GetMethodUFunction(Widget.StaticClass, "SetVisibility");
            }

            internal static unsafe void Invoke(IntPtr obj, ESlateVisibility InVisibility) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)InVisibility;
                Main.GetProcessEvent(obj, SetVisibility_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Widget_events {
    }
}
