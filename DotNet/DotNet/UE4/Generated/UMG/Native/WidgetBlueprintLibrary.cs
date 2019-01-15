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
using UE4.InputCore;
using UE4.SlateCore;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct WidgetBlueprintLibrary_fields {
    }
    internal unsafe struct WidgetBlueprintLibrary_methods {
        internal struct CancelDragDrop_method {
            static internal IntPtr CancelDragDrop_ptr;
            static CancelDragDrop_method() {
                CancelDragDrop_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "CancelDragDrop");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, CancelDragDrop_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CaptureJoystick_method {
            static internal IntPtr CaptureJoystick_ptr;
            static CaptureJoystick_method() {
                CaptureJoystick_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "CaptureJoystick");
            }

            internal static unsafe EventReply Invoke(EventReply Reply, Widget CapturingWidget, bool bInAllJoysticks) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                *((IntPtr*)(b+192)) = CapturingWidget;
                *((bool*)(b+200)) = bInAllJoysticks;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, CaptureJoystick_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+208));
            }
        }
        internal struct CaptureMouse_method {
            static internal IntPtr CaptureMouse_ptr;
            static CaptureMouse_method() {
                CaptureMouse_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "CaptureMouse");
            }

            internal static unsafe EventReply Invoke(EventReply Reply, Widget CapturingWidget) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                *((IntPtr*)(b+192)) = CapturingWidget;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, CaptureMouse_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+200));
            }
        }
        internal struct ClearUserFocus_method {
            static internal IntPtr ClearUserFocus_ptr;
            static ClearUserFocus_method() {
                ClearUserFocus_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "ClearUserFocus");
            }

            internal static unsafe EventReply Invoke(EventReply Reply, bool bInAllUsers) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                *((bool*)(b+192)) = bInAllUsers;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, ClearUserFocus_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+200));
            }
        }
        internal struct Create_method {
            static internal IntPtr Create_ptr;
            static Create_method() {
                Create_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "Create");
            }

            internal static unsafe UserWidget Invoke(UObject WorldContextObject, SubclassOf<UserWidget> WidgetType, PlayerController OwningPlayer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = WidgetType;
                *((IntPtr*)(b+16)) = OwningPlayer;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, Create_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct CreateDragDropOperation_method {
            static internal IntPtr CreateDragDropOperation_ptr;
            static CreateDragDropOperation_method() {
                CreateDragDropOperation_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "CreateDragDropOperation");
            }

            internal static unsafe DragDropOperation Invoke(SubclassOf<DragDropOperation> OperationClass) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = OperationClass;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, CreateDragDropOperation_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct DetectDrag_method {
            static internal IntPtr DetectDrag_ptr;
            static DetectDrag_method() {
                DetectDrag_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "DetectDrag");
            }

            internal static unsafe EventReply Invoke(EventReply Reply, Widget WidgetDetectingDrag, Key DragKey) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                *((IntPtr*)(b+192)) = WidgetDetectingDrag;
                *((Key*)(b+200)) = DragKey;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, DetectDrag_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+232));
            }
        }
        internal struct DetectDragIfPressed_method {
            static internal IntPtr DetectDragIfPressed_ptr;
            static DetectDragIfPressed_method() {
                DetectDragIfPressed_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "DetectDragIfPressed");
            }

            internal static unsafe EventReply Invoke(PointerEvent PointerEvent, Widget WidgetDetectingDrag, Key DragKey) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = PointerEvent;
                *((IntPtr*)(b+120)) = WidgetDetectingDrag;
                *((Key*)(b+128)) = DragKey;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, DetectDragIfPressed_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+160));
            }
        }
        internal struct DismissAllMenus_method {
            static internal IntPtr DismissAllMenus_ptr;
            static DismissAllMenus_method() {
                DismissAllMenus_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "DismissAllMenus");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, DismissAllMenus_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawBox_method {
            static internal IntPtr DrawBox_ptr;
            static DrawBox_method() {
                DrawBox_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "DrawBox");
            }

            internal static unsafe void Invoke(PaintContext Context, Vector2D Position, Vector2D Size, SlateBrushAsset Brush, LinearColor Tint) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PaintContext*)(b+0)) = Context;
                *((Vector2D*)(b+48)) = Position;
                *((Vector2D*)(b+56)) = Size;
                *((IntPtr*)(b+64)) = Brush;
                *((LinearColor*)(b+72)) = Tint;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, DrawBox_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawLine_method {
            static internal IntPtr DrawLine_ptr;
            static DrawLine_method() {
                DrawLine_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "DrawLine");
            }

            internal static unsafe void Invoke(PaintContext Context, Vector2D PositionA, Vector2D PositionB, LinearColor Tint, bool bAntiAlias) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PaintContext*)(b+0)) = Context;
                *((Vector2D*)(b+48)) = PositionA;
                *((Vector2D*)(b+56)) = PositionB;
                *((LinearColor*)(b+64)) = Tint;
                *((bool*)(b+80)) = bAntiAlias;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, DrawLine_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawLines_method {
            static internal IntPtr DrawLines_ptr;
            static DrawLines_method() {
                DrawLines_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "DrawLines");
            }

            internal static unsafe void Invoke(PaintContext Context, byte Points /*TODO: array TArray */, LinearColor Tint, bool bAntiAlias) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PaintContext*)(b+0)) = Context;
                throw new NotImplementedException(); //TODO: array TArray Points
                *((LinearColor*)(b+64)) = Tint;
                *((bool*)(b+80)) = bAntiAlias;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, DrawLines_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Points
            }
        }
        internal struct DrawText_method {
            static internal IntPtr DrawText_ptr;
            static DrawText_method() {
                DrawText_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "DrawText");
            }

            internal static unsafe void Invoke(PaintContext Context, string InString, Vector2D Position, LinearColor Tint) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PaintContext*)(b+0)) = Context;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+48) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+48) = InString.Length;
                *(int*)(b+IntPtr.Size+4+48) = InString.Length;
                *((Vector2D*)(b+64)) = Position;
                *((LinearColor*)(b+72)) = Tint;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, DrawText_ptr, new IntPtr(p)); ;
                InString_handle.Free();
            }
        }
        internal struct DrawTextFormatted_method {
            static internal IntPtr DrawTextFormatted_ptr;
            static DrawTextFormatted_method() {
                DrawTextFormatted_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "DrawTextFormatted");
            }

            internal static unsafe void Invoke(PaintContext Context, byte Text /*TODO: text FText */, Vector2D Position, Font Font, int FontSize, Name FontTypeFace, LinearColor Tint) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PaintContext*)(b+0)) = Context;
                throw new NotImplementedException(); //TODO: text FText Text
                *((Vector2D*)(b+72)) = Position;
                *((IntPtr*)(b+80)) = Font;
                *((int*)(b+88)) = FontSize;
                *((Name*)(b+92)) = FontTypeFace;
                *((LinearColor*)(b+104)) = Tint;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, DrawTextFormatted_ptr, new IntPtr(p)); ;
                 //TODO: text FText Text
            }
        }
        internal struct EndDragDrop_method {
            static internal IntPtr EndDragDrop_ptr;
            static EndDragDrop_method() {
                EndDragDrop_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "EndDragDrop");
            }

            internal static unsafe EventReply Invoke(EventReply Reply) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, EndDragDrop_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+192));
            }
        }
        internal struct GetAllWidgetsOfClass_method {
            static internal IntPtr GetAllWidgetsOfClass_ptr;
            static GetAllWidgetsOfClass_method() {
                GetAllWidgetsOfClass_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetAllWidgetsOfClass");
            }

            internal static unsafe IReadOnlyCollection<UserWidget> Invoke(UObject WorldContextObject, SubclassOf<UserWidget> WidgetClass, bool TopLevelOnly) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+24)) = WidgetClass;
                *((bool*)(b+32)) = TopLevelOnly;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetAllWidgetsOfClass_ptr, new IntPtr(p)); ;
                 //TODO: array TArray FoundWidgets
                return UObject.ToUObjectCollection<UserWidget>(b+8);
            }
        }
        internal struct GetAllWidgetsWithInterface_method {
            static internal IntPtr GetAllWidgetsWithInterface_ptr;
            static GetAllWidgetsWithInterface_method() {
                GetAllWidgetsWithInterface_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetAllWidgetsWithInterface");
            }

            internal static unsafe IReadOnlyCollection<UserWidget> Invoke(UObject WorldContextObject, SubclassOf<Interface> Interface, bool TopLevelOnly) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Interface;
                *((bool*)(b+32)) = TopLevelOnly;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetAllWidgetsWithInterface_ptr, new IntPtr(p)); ;
                 //TODO: array TArray FoundWidgets
                return UObject.ToUObjectCollection<UserWidget>(b+16);
            }
        }
        internal struct GetBrushResource_method {
            static internal IntPtr GetBrushResource_ptr;
            static GetBrushResource_method() {
                GetBrushResource_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetBrushResource");
            }

            internal static unsafe UObject Invoke(SlateBrush Brush) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateBrush*)(b+0)) = Brush;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetBrushResource_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+160));
            }
        }
        internal struct GetBrushResourceAsMaterial_method {
            static internal IntPtr GetBrushResourceAsMaterial_ptr;
            static GetBrushResourceAsMaterial_method() {
                GetBrushResourceAsMaterial_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetBrushResourceAsMaterial");
            }

            internal static unsafe MaterialInterface Invoke(SlateBrush Brush) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateBrush*)(b+0)) = Brush;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetBrushResourceAsMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+160));
            }
        }
        internal struct GetBrushResourceAsTexture2D_method {
            static internal IntPtr GetBrushResourceAsTexture2D_ptr;
            static GetBrushResourceAsTexture2D_method() {
                GetBrushResourceAsTexture2D_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetBrushResourceAsTexture2D");
            }

            internal static unsafe Texture2D Invoke(SlateBrush Brush) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateBrush*)(b+0)) = Brush;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetBrushResourceAsTexture2D_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+160));
            }
        }
        internal struct GetDragDroppingContent_method {
            static internal IntPtr GetDragDroppingContent_ptr;
            static GetDragDroppingContent_method() {
                GetDragDroppingContent_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetDragDroppingContent");
            }

            internal static unsafe DragDropOperation Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetDragDroppingContent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetDynamicMaterial_method {
            static internal IntPtr GetDynamicMaterial_ptr;
            static GetDynamicMaterial_method() {
                GetDynamicMaterial_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetDynamicMaterial");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(SlateBrush Brush) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateBrush*)(b+0)) = Brush;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetDynamicMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+160));
            }
        }
        internal struct GetInputEventFromCharacterEvent_method {
            static internal IntPtr GetInputEventFromCharacterEvent_ptr;
            static GetInputEventFromCharacterEvent_method() {
                GetInputEventFromCharacterEvent_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetInputEventFromCharacterEvent");
            }

            internal static unsafe InputEvent Invoke(CharacterEvent Event) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((CharacterEvent*)(b+0)) = Event;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetInputEventFromCharacterEvent_ptr, new IntPtr(p)); ;
                return *((InputEvent*)(b+32));
            }
        }
        internal struct GetInputEventFromKeyEvent_method {
            static internal IntPtr GetInputEventFromKeyEvent_ptr;
            static GetInputEventFromKeyEvent_method() {
                GetInputEventFromKeyEvent_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetInputEventFromKeyEvent");
            }

            internal static unsafe InputEvent Invoke(KeyEvent Event) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((KeyEvent*)(b+0)) = Event;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetInputEventFromKeyEvent_ptr, new IntPtr(p)); ;
                return *((InputEvent*)(b+64));
            }
        }
        internal struct GetInputEventFromNavigationEvent_method {
            static internal IntPtr GetInputEventFromNavigationEvent_ptr;
            static GetInputEventFromNavigationEvent_method() {
                GetInputEventFromNavigationEvent_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetInputEventFromNavigationEvent");
            }

            internal static unsafe InputEvent Invoke(NavigationEvent Event) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((NavigationEvent*)(b+0)) = Event;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetInputEventFromNavigationEvent_ptr, new IntPtr(p)); ;
                return *((InputEvent*)(b+32));
            }
        }
        internal struct GetInputEventFromPointerEvent_method {
            static internal IntPtr GetInputEventFromPointerEvent_ptr;
            static GetInputEventFromPointerEvent_method() {
                GetInputEventFromPointerEvent_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetInputEventFromPointerEvent");
            }

            internal static unsafe InputEvent Invoke(PointerEvent Event) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PointerEvent*)(b+0)) = Event;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetInputEventFromPointerEvent_ptr, new IntPtr(p)); ;
                return *((InputEvent*)(b+120));
            }
        }
        internal struct GetKeyEventFromAnalogInputEvent_method {
            static internal IntPtr GetKeyEventFromAnalogInputEvent_ptr;
            static GetKeyEventFromAnalogInputEvent_method() {
                GetKeyEventFromAnalogInputEvent_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetKeyEventFromAnalogInputEvent");
            }

            internal static unsafe KeyEvent Invoke(AnalogInputEvent Event) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AnalogInputEvent*)(b+0)) = Event;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetKeyEventFromAnalogInputEvent_ptr, new IntPtr(p)); ;
                return *((KeyEvent*)(b+72));
            }
        }
        internal struct GetSafeZonePadding_method {
            static internal IntPtr GetSafeZonePadding_ptr;
            static GetSafeZonePadding_method() {
                GetSafeZonePadding_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "GetSafeZonePadding");
            }

            internal static unsafe (Vector4, Vector2D, Vector4) Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, GetSafeZonePadding_ptr, new IntPtr(p)); ;
                return (*((Vector4*)(b+16)),*((Vector2D*)(b+32)),*((Vector4*)(b+48)));
            }
        }
        internal struct Handled_method {
            static internal IntPtr Handled_ptr;
            static Handled_method() {
                Handled_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "Handled");
            }

            internal static unsafe EventReply Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, Handled_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+0));
            }
        }
        internal struct IsDragDropping_method {
            static internal IntPtr IsDragDropping_ptr;
            static IsDragDropping_method() {
                IsDragDropping_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "IsDragDropping");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, IsDragDropping_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct LockMouse_method {
            static internal IntPtr LockMouse_ptr;
            static LockMouse_method() {
                LockMouse_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "LockMouse");
            }

            internal static unsafe EventReply Invoke(EventReply Reply, Widget CapturingWidget) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                *((IntPtr*)(b+192)) = CapturingWidget;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, LockMouse_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+200));
            }
        }
        internal struct MakeBrushFromAsset_method {
            static internal IntPtr MakeBrushFromAsset_ptr;
            static MakeBrushFromAsset_method() {
                MakeBrushFromAsset_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "MakeBrushFromAsset");
            }

            internal static unsafe SlateBrush Invoke(SlateBrushAsset BrushAsset) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = BrushAsset;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, MakeBrushFromAsset_ptr, new IntPtr(p)); ;
                return *((SlateBrush*)(b+8));
            }
        }
        internal struct MakeBrushFromMaterial_method {
            static internal IntPtr MakeBrushFromMaterial_ptr;
            static MakeBrushFromMaterial_method() {
                MakeBrushFromMaterial_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "MakeBrushFromMaterial");
            }

            internal static unsafe SlateBrush Invoke(MaterialInterface Material, int Width, int Height) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                *((int*)(b+8)) = Width;
                *((int*)(b+12)) = Height;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, MakeBrushFromMaterial_ptr, new IntPtr(p)); ;
                return *((SlateBrush*)(b+16));
            }
        }
        internal struct MakeBrushFromTexture_method {
            static internal IntPtr MakeBrushFromTexture_ptr;
            static MakeBrushFromTexture_method() {
                MakeBrushFromTexture_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "MakeBrushFromTexture");
            }

            internal static unsafe SlateBrush Invoke(Texture2D Texture, int Width, int Height) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                *((int*)(b+8)) = Width;
                *((int*)(b+12)) = Height;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, MakeBrushFromTexture_ptr, new IntPtr(p)); ;
                return *((SlateBrush*)(b+16));
            }
        }
        internal struct NoResourceBrush_method {
            static internal IntPtr NoResourceBrush_ptr;
            static NoResourceBrush_method() {
                NoResourceBrush_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "NoResourceBrush");
            }

            internal static unsafe SlateBrush Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, NoResourceBrush_ptr, new IntPtr(p)); ;
                return *((SlateBrush*)(b+0));
            }
        }
        internal struct ReleaseJoystickCapture_method {
            static internal IntPtr ReleaseJoystickCapture_ptr;
            static ReleaseJoystickCapture_method() {
                ReleaseJoystickCapture_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "ReleaseJoystickCapture");
            }

            internal static unsafe EventReply Invoke(EventReply Reply, bool bInAllJoysticks) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                *((bool*)(b+192)) = bInAllJoysticks;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, ReleaseJoystickCapture_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+200));
            }
        }
        internal struct ReleaseMouseCapture_method {
            static internal IntPtr ReleaseMouseCapture_ptr;
            static ReleaseMouseCapture_method() {
                ReleaseMouseCapture_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "ReleaseMouseCapture");
            }

            internal static unsafe EventReply Invoke(EventReply Reply) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, ReleaseMouseCapture_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+192));
            }
        }
        internal struct RestorePreviousWindowTitleBarState_method {
            static internal IntPtr RestorePreviousWindowTitleBarState_ptr;
            static RestorePreviousWindowTitleBarState_method() {
                RestorePreviousWindowTitleBarState_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "RestorePreviousWindowTitleBarState");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, RestorePreviousWindowTitleBarState_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushResourceToMaterial_method {
            static internal IntPtr SetBrushResourceToMaterial_ptr;
            static SetBrushResourceToMaterial_method() {
                SetBrushResourceToMaterial_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetBrushResourceToMaterial");
            }

            internal static unsafe void Invoke(SlateBrush Brush, MaterialInterface Material) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateBrush*)(b+0)) = Brush;
                *((IntPtr*)(b+160)) = Material;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetBrushResourceToMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrushResourceToTexture_method {
            static internal IntPtr SetBrushResourceToTexture_ptr;
            static SetBrushResourceToTexture_method() {
                SetBrushResourceToTexture_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetBrushResourceToTexture");
            }

            internal static unsafe void Invoke(SlateBrush Brush, Texture2D Texture) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateBrush*)(b+0)) = Brush;
                *((IntPtr*)(b+160)) = Texture;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetBrushResourceToTexture_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFocusToGameViewport_method {
            static internal IntPtr SetFocusToGameViewport_ptr;
            static SetFocusToGameViewport_method() {
                SetFocusToGameViewport_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetFocusToGameViewport");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetFocusToGameViewport_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHardwareCursor_method {
            static internal IntPtr SetHardwareCursor_ptr;
            static SetHardwareCursor_method() {
                SetHardwareCursor_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetHardwareCursor");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, byte CursorShape, Name CursorName, Vector2D HotSpot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *(b+8) = CursorShape;
                *((Name*)(b+12)) = CursorName;
                *((Vector2D*)(b+24)) = HotSpot;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetHardwareCursor_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct SetInputMode_GameAndUI_method {
            static internal IntPtr SetInputMode_GameAndUI_ptr;
            static SetInputMode_GameAndUI_method() {
                SetInputMode_GameAndUI_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetInputMode_GameAndUI");
            }

            internal static unsafe void Invoke(PlayerController Target, Widget InWidgetToFocus, bool bLockMouseToViewport, bool bHideCursorDuringCapture) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Target;
                *((IntPtr*)(b+8)) = InWidgetToFocus;
                *((bool*)(b+16)) = bLockMouseToViewport;
                *((bool*)(b+17)) = bHideCursorDuringCapture;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetInputMode_GameAndUI_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInputMode_GameAndUIEx_method {
            static internal IntPtr SetInputMode_GameAndUIEx_ptr;
            static SetInputMode_GameAndUIEx_method() {
                SetInputMode_GameAndUIEx_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetInputMode_GameAndUIEx");
            }

            internal static unsafe void Invoke(PlayerController PlayerController, Widget InWidgetToFocus, EMouseLockMode InMouseLockMode, bool bHideCursorDuringCapture) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                *((IntPtr*)(b+8)) = InWidgetToFocus;
                *(b+16) = (byte)InMouseLockMode;
                *((bool*)(b+17)) = bHideCursorDuringCapture;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetInputMode_GameAndUIEx_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInputMode_GameOnly_method {
            static internal IntPtr SetInputMode_GameOnly_ptr;
            static SetInputMode_GameOnly_method() {
                SetInputMode_GameOnly_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetInputMode_GameOnly");
            }

            internal static unsafe void Invoke(PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetInputMode_GameOnly_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInputMode_UIOnly_method {
            static internal IntPtr SetInputMode_UIOnly_ptr;
            static SetInputMode_UIOnly_method() {
                SetInputMode_UIOnly_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetInputMode_UIOnly");
            }

            internal static unsafe void Invoke(PlayerController Target, Widget InWidgetToFocus, bool bLockMouseToViewport) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Target;
                *((IntPtr*)(b+8)) = InWidgetToFocus;
                *((bool*)(b+16)) = bLockMouseToViewport;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetInputMode_UIOnly_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInputMode_UIOnlyEx_method {
            static internal IntPtr SetInputMode_UIOnlyEx_ptr;
            static SetInputMode_UIOnlyEx_method() {
                SetInputMode_UIOnlyEx_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetInputMode_UIOnlyEx");
            }

            internal static unsafe void Invoke(PlayerController PlayerController, Widget InWidgetToFocus, EMouseLockMode InMouseLockMode) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                *((IntPtr*)(b+8)) = InWidgetToFocus;
                *(b+16) = (byte)InMouseLockMode;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetInputMode_UIOnlyEx_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMousePosition_method {
            static internal IntPtr SetMousePosition_ptr;
            static SetMousePosition_method() {
                SetMousePosition_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetMousePosition");
            }

            internal static unsafe EventReply Invoke(EventReply Reply, Vector2D NewMousePosition) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                *((Vector2D*)(b+192)) = NewMousePosition;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetMousePosition_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+200));
            }
        }
        internal struct SetUserFocus_method {
            static internal IntPtr SetUserFocus_ptr;
            static SetUserFocus_method() {
                SetUserFocus_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetUserFocus");
            }

            internal static unsafe EventReply Invoke(EventReply Reply, Widget FocusWidget, bool bInAllUsers) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                *((IntPtr*)(b+192)) = FocusWidget;
                *((bool*)(b+200)) = bInAllUsers;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetUserFocus_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+208));
            }
        }
        internal struct SetWindowTitleBarCloseButtonActive_method {
            static internal IntPtr SetWindowTitleBarCloseButtonActive_ptr;
            static SetWindowTitleBarCloseButtonActive_method() {
                SetWindowTitleBarCloseButtonActive_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetWindowTitleBarCloseButtonActive");
            }

            internal static unsafe void Invoke(bool bActive) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bActive;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetWindowTitleBarCloseButtonActive_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWindowTitleBarOnCloseClickedDelegate_method {
            static internal IntPtr SetWindowTitleBarOnCloseClickedDelegate_ptr;
            static SetWindowTitleBarOnCloseClickedDelegate_method() {
                SetWindowTitleBarOnCloseClickedDelegate_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetWindowTitleBarOnCloseClickedDelegate");
            }

            internal static unsafe void Invoke(byte Delegate /*TODO: delegate FOnGameWindowCloseButtonClickedDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FOnGameWindowCloseButtonClickedDelegate Delegate
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetWindowTitleBarOnCloseClickedDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FOnGameWindowCloseButtonClickedDelegate Delegate
            }
        }
        internal struct SetWindowTitleBarState_method {
            static internal IntPtr SetWindowTitleBarState_ptr;
            static SetWindowTitleBarState_method() {
                SetWindowTitleBarState_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "SetWindowTitleBarState");
            }

            internal static unsafe void Invoke(Widget TitleBarContent, EWindowTitleBarMode Mode, bool bTitleBarDragEnabled, bool bWindowButtonsVisible, bool bTitleBarVisible) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = TitleBarContent;
                *(b+8) = (byte)Mode;
                *((bool*)(b+9)) = bTitleBarDragEnabled;
                *((bool*)(b+10)) = bWindowButtonsVisible;
                *((bool*)(b+11)) = bTitleBarVisible;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, SetWindowTitleBarState_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Unhandled_method {
            static internal IntPtr Unhandled_ptr;
            static Unhandled_method() {
                Unhandled_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "Unhandled");
            }

            internal static unsafe EventReply Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, Unhandled_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+0));
            }
        }
        internal struct UnlockMouse_method {
            static internal IntPtr UnlockMouse_ptr;
            static UnlockMouse_method() {
                UnlockMouse_ptr = Main.GetMethodUFunction(WidgetBlueprintLibrary.StaticClass, "UnlockMouse");
            }

            internal static unsafe EventReply Invoke(EventReply Reply) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((EventReply*)(b+0)) = Reply;
                Main.GetProcessEvent(WidgetBlueprintLibrary.DefaultObject, UnlockMouse_ptr, new IntPtr(p)); ;
                return *((EventReply*)(b+192));
            }
        }
    }
    internal unsafe struct WidgetBlueprintLibrary_events {
    }
}
