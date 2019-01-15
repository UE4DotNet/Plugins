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

#pragma warning disable CS0108
using UE4.UMG.Native;
using UE4.Engine;
using UE4.InputCore;
using UE4.SlateCore;

namespace UE4.UMG {
    ///<summary>Widget Blueprint Library</summary>
    public unsafe partial class WidgetBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Cancels any current drag drop operation.</summary>
        public static void CancelDragDrop()  => 
            WidgetBlueprintLibrary_methods.CancelDragDrop_method.Invoke();

        ///<summary>Capture Joystick</summary>
        public static EventReply CaptureJoystick(EventReply Reply, Widget CapturingWidget, bool bInAllJoysticks)  => 
            WidgetBlueprintLibrary_methods.CaptureJoystick_method.Invoke(Reply, CapturingWidget, bInAllJoysticks);

        ///<summary>Capture Mouse</summary>
        public static EventReply CaptureMouse(EventReply Reply, Widget CapturingWidget)  => 
            WidgetBlueprintLibrary_methods.CaptureMouse_method.Invoke(Reply, CapturingWidget);

        ///<summary>Clear User Focus</summary>
        public static EventReply ClearUserFocus(EventReply Reply, bool bInAllUsers)  => 
            WidgetBlueprintLibrary_methods.ClearUserFocus_method.Invoke(Reply, bInAllUsers);

        ///<summary>Creates a widget</summary>
        public static UserWidget Create(UObject WorldContextObject, SubclassOf<UserWidget> WidgetType, PlayerController OwningPlayer)  => 
            WidgetBlueprintLibrary_methods.Create_method.Invoke(WorldContextObject, WidgetType, OwningPlayer);

        ///<summary>
        ///Creates a new drag and drop operation that can be returned from a drag begin to inform the UI what i
        ///being dragged and dropped and what it looks like.
        ///</summary>
        public static DragDropOperation CreateDragDropOperation(SubclassOf<DragDropOperation> OperationClass)  => 
            WidgetBlueprintLibrary_methods.CreateDragDropOperation_method.Invoke(OperationClass);

        ///<summary>Ask Slate to detect if a user starts dragging in this widget later.</summary>
        ///<remarks>
        ///Slate internally tracks the movement
        ///and if it surpasses the drag threshold, Slate will send an OnDragDetected event to the widget.
        ///
        ///@param WidgetDetectingDrag  Detect dragging in this widget
        ///@param DragKey                      This button should be pressed to detect the drag
        ///</remarks>
        public static EventReply DetectDrag(EventReply Reply, Widget WidgetDetectingDrag, Key DragKey)  => 
            WidgetBlueprintLibrary_methods.DetectDrag_method.Invoke(Reply, WidgetDetectingDrag, DragKey);

        ///<summary>Given the pointer event, emit the DetectDrag reply if the provided key was pressed.</summary>
        ///<remarks>
        ///If the DragKey is a touch key, that will also automatically work.
        ///@param PointerEvent  The pointer device event coming in.
        ///@param WidgetDetectingDrag  Detect dragging in this widget.
        ///@param DragKey                      This button should be pressed to detect the drag, won't emit the DetectDrag FEventReply unless this is pressed.
        ///</remarks>
        public static EventReply DetectDragIfPressed(PointerEvent PointerEvent, Widget WidgetDetectingDrag, Key DragKey)  => 
            WidgetBlueprintLibrary_methods.DetectDragIfPressed_method.Invoke(PointerEvent, WidgetDetectingDrag, DragKey);

        ///<summary>Closes any popup menu</summary>
        public static void DismissAllMenus()  => 
            WidgetBlueprintLibrary_methods.DismissAllMenus_method.Invoke();

        ///<summary>Draws a box</summary>
        public static void DrawBox(PaintContext Context, Vector2D Position, Vector2D Size, SlateBrushAsset Brush, LinearColor Tint)  => 
            WidgetBlueprintLibrary_methods.DrawBox_method.Invoke(Context, Position, Size, Brush, Tint);

        ///<summary>Draws a line.</summary>
        ///<remarks>
        ///@param PositionA             Starting position of the line in local space.
        ///@param PositionB             Ending position of the line in local space.
        ///@param Thickness             How many pixels thick this line should be.
        ///@param Tint                  Color to render the line.
        ///</remarks>
        public static void DrawLine(PaintContext Context, Vector2D PositionA, Vector2D PositionB, LinearColor Tint, bool bAntiAlias)  => 
            WidgetBlueprintLibrary_methods.DrawLine_method.Invoke(Context, PositionA, PositionB, Tint, bAntiAlias);

        ///<summary>Draws several line segments.</summary>
        ///<remarks>
        ///@param Points                Line pairs, each line needs to be 2 separate points in the array.
        ///@param Thickness             How many pixels thick this line should be.
        ///@param Tint                  Color to render the line.
        ///</remarks>
        public static void DrawLines(PaintContext Context, byte Points /*TODO: array TArray */, LinearColor Tint, bool bAntiAlias)  => 
            WidgetBlueprintLibrary_methods.DrawLines_method.Invoke(Context, Points, Tint, bAntiAlias);

        ///<summary>Draws text.</summary>
        ///<remarks>
        ///@param InString              The string to draw.
        ///@param Position              The starting position where the text is drawn in local space.
        ///@param Tint                  Color to render the line.
        ///</remarks>
        public static void DrawText(PaintContext Context, string InString, Vector2D Position, LinearColor Tint)  => 
            WidgetBlueprintLibrary_methods.DrawText_method.Invoke(Context, InString, Position, Tint);

        ///<summary>Draws text.</summary>
        ///<remarks>
        ///@param Text                  The string to draw.
        ///@param Position              The starting position where the text is drawn in local space.
        ///@param Tint                  Color to render the line.
        ///</remarks>
        public static void DrawTextFormatted(PaintContext Context, byte Text /*TODO: text FText */, Vector2D Position, Font Font, int FontSize, Name FontTypeFace, LinearColor Tint)  => 
            WidgetBlueprintLibrary_methods.DrawTextFormatted_method.Invoke(Context, Text, Position, Font, FontSize, FontTypeFace, Tint);

        ///<summary>An event should return FReply::Handled().EndDragDrop() to request that the current drag/drop operation be terminated.</summary>
        public static EventReply EndDragDrop(EventReply Reply)  => 
            WidgetBlueprintLibrary_methods.EndDragDrop_method.Invoke(Reply);

        ///<summary>Find all widgets of a certain class.</summary>
        ///<remarks>
        ///@param FoundWidgets The widgets that were found matching the filter.
        ///@param WidgetClass The widget class to filter by.
        ///@param TopLevelOnly Only the widgets that are direct children of the viewport will be returned.
        ///</remarks>
        public static IReadOnlyCollection<UserWidget> GetAllWidgetsOfClass(UObject WorldContextObject, SubclassOf<UserWidget> WidgetClass, bool TopLevelOnly)  => 
            WidgetBlueprintLibrary_methods.GetAllWidgetsOfClass_method.Invoke(WorldContextObject, WidgetClass, TopLevelOnly);

        ///<summary>Find all widgets in the world with the specified interface.</summary>
        ///<remarks>
        ///This is a slow operation, use with caution e.g. do not use every frame.
        ///@param Interface The interface to find. Must be specified or result array will be empty.
        ///@param FoundWidgets Output array of widgets that implement the specified interface.
        ///@param TopLevelOnly Only the widgets that are direct children of the viewport will be returned.
        ///</remarks>
        public static IReadOnlyCollection<UserWidget> GetAllWidgetsWithInterface(UObject WorldContextObject, SubclassOf<Interface> Interface, bool TopLevelOnly)  => 
            WidgetBlueprintLibrary_methods.GetAllWidgetsWithInterface_method.Invoke(WorldContextObject, Interface, TopLevelOnly);

        ///<summary>Gets the resource object on a brush.  This could be a UTexture2D or a UMaterialInterface.</summary>
        public static UObject GetBrushResource(SlateBrush Brush)  => 
            WidgetBlueprintLibrary_methods.GetBrushResource_method.Invoke(Brush);

        ///<summary>Gets the brush resource as a material.</summary>
        public static MaterialInterface GetBrushResourceAsMaterial(SlateBrush Brush)  => 
            WidgetBlueprintLibrary_methods.GetBrushResourceAsMaterial_method.Invoke(Brush);

        ///<summary>Gets the brush resource as a texture 2D.</summary>
        public static Texture2D GetBrushResourceAsTexture2D(SlateBrush Brush)  => 
            WidgetBlueprintLibrary_methods.GetBrushResourceAsTexture2D_method.Invoke(Brush);

        ///<summary>Returns the drag and drop operation that is currently occurring if any, otherwise nothing.</summary>
        public static DragDropOperation GetDragDroppingContent()  => 
            WidgetBlueprintLibrary_methods.GetDragDroppingContent_method.Invoke();

        ///<summary>Gets the material that allows changes to parameters at runtime.</summary>
        ///<remarks>
        ///The brush must already have a material assigned to it,
        ///if it does it will automatically be converted to a MID.
        ///
        ///@return A material that supports dynamic input from the game.
        ///</remarks>
        public static MaterialInstanceDynamic GetDynamicMaterial(SlateBrush Brush)  => 
            WidgetBlueprintLibrary_methods.GetDynamicMaterial_method.Invoke(Brush);

        ///<summary>Get Input Event from Character Event</summary>
        public static InputEvent GetInputEventFromCharacterEvent(CharacterEvent Event)  => 
            WidgetBlueprintLibrary_methods.GetInputEventFromCharacterEvent_method.Invoke(Event);

        ///<summary>Get Input Event from Key Event</summary>
        public static InputEvent GetInputEventFromKeyEvent(KeyEvent Event)  => 
            WidgetBlueprintLibrary_methods.GetInputEventFromKeyEvent_method.Invoke(Event);

        ///<summary>Get Input Event from Navigation Event</summary>
        public static InputEvent GetInputEventFromNavigationEvent(NavigationEvent Event)  => 
            WidgetBlueprintLibrary_methods.GetInputEventFromNavigationEvent_method.Invoke(Event);

        ///<summary>Get Input Event from Pointer Event</summary>
        public static InputEvent GetInputEventFromPointerEvent(PointerEvent Event)  => 
            WidgetBlueprintLibrary_methods.GetInputEventFromPointerEvent_method.Invoke(Event);

        ///<summary>Get Key Event from Analog Input Event</summary>
        public static KeyEvent GetKeyEventFromAnalogInputEvent(AnalogInputEvent Event)  => 
            WidgetBlueprintLibrary_methods.GetKeyEventFromAnalogInputEvent_method.Invoke(Event);

        ///<summary>Gets the amount of padding that needs to be added when accounting for the safe zone on TVs.</summary>
        public static (Vector4, Vector2D, Vector4) GetSafeZonePadding(UObject WorldContextObject)  => 
            WidgetBlueprintLibrary_methods.GetSafeZonePadding_method.Invoke(WorldContextObject);

        ///<summary>The event reply to use when you choose to handle an event.</summary>
        ///<remarks>
        ///This will prevent the event
        ///from continuing to bubble up / down the widget hierarchy.
        ///</remarks>
        public static EventReply Handled()  => 
            WidgetBlueprintLibrary_methods.Handled_method.Invoke();

        ///<summary>Returns true if a drag/drop event is occurring that a widget can handle.</summary>
        public static bool IsDragDropping()  => 
            WidgetBlueprintLibrary_methods.IsDragDropping_method.Invoke();

        ///<summary>Lock Mouse</summary>
        public static EventReply LockMouse(EventReply Reply, Widget CapturingWidget)  => 
            WidgetBlueprintLibrary_methods.LockMouse_method.Invoke(Reply, CapturingWidget);

        ///<summary>
        ///Creates a Slate Brush from a Slate Brush Asset
        ///@
        ///</summary>
        ///<remarks>return A new slate brush using the asset's brush.</remarks>
        public static SlateBrush MakeBrushFromAsset(SlateBrushAsset BrushAsset)  => 
            WidgetBlueprintLibrary_methods.MakeBrushFromAsset_method.Invoke(BrushAsset);

        ///<summary>Creates a Slate Brush from a Material.</summary>
        ///<remarks>
        ///Materials don't have an implicit size, so providing a widget and height
        ///is required to hint slate with how large the image wants to be by default.
        ///
        ///@return A new slate brush using the material.
        ///</remarks>
        public static SlateBrush MakeBrushFromMaterial(MaterialInterface Material, int Width, int Height)  => 
            WidgetBlueprintLibrary_methods.MakeBrushFromMaterial_method.Invoke(Material, Width, Height);

        ///<summary>
        ///Creates a Slate Brush from a Texture2D
        ///@
        ///</summary>
        ///<remarks>
        ///param Width  When less than or equal to zero, the Width of the brush will default to the Width of the Texture
        ///@param Height  When less than or equal to zero, the Height of the brush will default to the Height of the Texture
        ///
        ///@return A new slate brush using the texture.
        ///</remarks>
        public static SlateBrush MakeBrushFromTexture(Texture2D Texture, int Width, int Height)  => 
            WidgetBlueprintLibrary_methods.MakeBrushFromTexture_method.Invoke(Texture, Width, Height);

        ///<summary>Creates a Slate Brush that wont draw anything, the "Null Brush".</summary>
        ///<remarks>
        ///@return A new slate brush that wont draw anything.
        ///</remarks>
        public static SlateBrush NoResourceBrush()  => 
            WidgetBlueprintLibrary_methods.NoResourceBrush_method.Invoke();

        ///<summary>Release Joystick Capture</summary>
        public static EventReply ReleaseJoystickCapture(EventReply Reply, bool bInAllJoysticks)  => 
            WidgetBlueprintLibrary_methods.ReleaseJoystickCapture_method.Invoke(Reply, bInAllJoysticks);

        ///<summary>Release Mouse Capture</summary>
        public static EventReply ReleaseMouseCapture(EventReply Reply)  => 
            WidgetBlueprintLibrary_methods.ReleaseMouseCapture_method.Invoke(Reply);

        ///<summary>Restore Previous Window Title Bar State</summary>
        public static void RestorePreviousWindowTitleBarState()  => 
            WidgetBlueprintLibrary_methods.RestorePreviousWindowTitleBarState_method.Invoke();

        ///<summary>Sets the resource on a brush to be a Material.</summary>
        public static void SetBrushResourceToMaterial(SlateBrush Brush, MaterialInterface Material)  => 
            WidgetBlueprintLibrary_methods.SetBrushResourceToMaterial_method.Invoke(Brush, Material);

        ///<summary>Sets the resource on a brush to be a UTexture2D.</summary>
        public static void SetBrushResourceToTexture(SlateBrush Brush, Texture2D Texture)  => 
            WidgetBlueprintLibrary_methods.SetBrushResourceToTexture_method.Invoke(Brush, Texture);

        ///<summary>Set Focus to Game Viewport</summary>
        public static void SetFocusToGameViewport()  => 
            WidgetBlueprintLibrary_methods.SetFocusToGameViewport_method.Invoke();

        ///<summary>Loads or sets a hardware cursor from the content directory in the game.</summary>
        public static bool SetHardwareCursor(UObject WorldContextObject, byte CursorShape, Name CursorName, Vector2D HotSpot)  => 
            WidgetBlueprintLibrary_methods.SetHardwareCursor_method.Invoke(WorldContextObject, CursorShape, CursorName, HotSpot);

        ///<summary>Set Input Mode Game and UI</summary>
        public static void SetInputMode_GameAndUI(PlayerController Target, Widget InWidgetToFocus, bool bLockMouseToViewport, bool bHideCursorDuringCapture)  => 
            WidgetBlueprintLibrary_methods.SetInputMode_GameAndUI_method.Invoke(Target, InWidgetToFocus, bLockMouseToViewport, bHideCursorDuringCapture);

        ///<summary>Setup an input mode that allows only the UI to respond to user input, and if the UI doesn't handle it player input / player controller gets a chance.</summary>
        public static void SetInputMode_GameAndUIEx(PlayerController PlayerController, Widget InWidgetToFocus, EMouseLockMode InMouseLockMode, bool bHideCursorDuringCapture)  => 
            WidgetBlueprintLibrary_methods.SetInputMode_GameAndUIEx_method.Invoke(PlayerController, InWidgetToFocus, InMouseLockMode, bHideCursorDuringCapture);

        ///<summary>Setup an input mode that allows only player input / player controller to respond to user input.</summary>
        public static void SetInputMode_GameOnly(PlayerController PlayerController)  => 
            WidgetBlueprintLibrary_methods.SetInputMode_GameOnly_method.Invoke(PlayerController);

        ///<summary>Set Input Mode UIOnly</summary>
        public static void SetInputMode_UIOnly(PlayerController Target, Widget InWidgetToFocus, bool bLockMouseToViewport)  => 
            WidgetBlueprintLibrary_methods.SetInputMode_UIOnly_method.Invoke(Target, InWidgetToFocus, bLockMouseToViewport);

        ///<summary>Setup an input mode that allows only the UI to respond to user input.</summary>
        public static void SetInputMode_UIOnlyEx(PlayerController PlayerController, Widget InWidgetToFocus, EMouseLockMode InMouseLockMode)  => 
            WidgetBlueprintLibrary_methods.SetInputMode_UIOnlyEx_method.Invoke(PlayerController, InWidgetToFocus, InMouseLockMode);

        ///<summary>Set Mouse Position</summary>
        public static EventReply SetMousePosition(EventReply Reply, Vector2D NewMousePosition)  => 
            WidgetBlueprintLibrary_methods.SetMousePosition_method.Invoke(Reply, NewMousePosition);

        ///<summary>Set User Focus</summary>
        public static EventReply SetUserFocus(EventReply Reply, Widget FocusWidget, bool bInAllUsers)  => 
            WidgetBlueprintLibrary_methods.SetUserFocus_method.Invoke(Reply, FocusWidget, bInAllUsers);

        ///<summary>Set Window Title Bar Close Button Active</summary>
        public static void SetWindowTitleBarCloseButtonActive(bool bActive)  => 
            WidgetBlueprintLibrary_methods.SetWindowTitleBarCloseButtonActive_method.Invoke(bActive);

        ///<summary>Set Window Title Bar on Close Clicked Delegate</summary>
        public static void SetWindowTitleBarOnCloseClickedDelegate(byte Delegate /*TODO: delegate FOnGameWindowCloseButtonClickedDelegate */)  => 
            WidgetBlueprintLibrary_methods.SetWindowTitleBarOnCloseClickedDelegate_method.Invoke(Delegate);

        ///<summary>Set Window Title Bar State</summary>
        public static void SetWindowTitleBarState(Widget TitleBarContent, EWindowTitleBarMode Mode, bool bTitleBarDragEnabled, bool bWindowButtonsVisible, bool bTitleBarVisible)  => 
            WidgetBlueprintLibrary_methods.SetWindowTitleBarState_method.Invoke(TitleBarContent, Mode, bTitleBarDragEnabled, bWindowButtonsVisible, bTitleBarVisible);

        ///<summary>The event reply to use when you choose not to handle an event.</summary>
        public static EventReply Unhandled()  => 
            WidgetBlueprintLibrary_methods.Unhandled_method.Invoke();

        ///<summary>Unlock Mouse</summary>
        public static EventReply UnlockMouse(EventReply Reply)  => 
            WidgetBlueprintLibrary_methods.UnlockMouse_method.Invoke(Reply);
        static WidgetBlueprintLibrary() {
            StaticClass = Main.GetClass("WidgetBlueprintLibrary");
        }
        internal unsafe WidgetBlueprintLibrary_fields* WidgetBlueprintLibrary_ptr => (WidgetBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetBlueprintLibrary(IntPtr p) => UObject.Make<WidgetBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
