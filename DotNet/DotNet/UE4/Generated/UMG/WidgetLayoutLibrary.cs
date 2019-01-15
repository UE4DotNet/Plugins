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
using UE4.SlateCore;

namespace UE4.UMG {
    ///<summary>Widget Layout Library</summary>
    public unsafe partial class WidgetLayoutLibrary : BlueprintFunctionLibrary  {

        ///<summary>Gets the platform's mouse cursor position.  This is the 'absolute' desktop location of the mouse.</summary>
        public static Vector2D GetMousePositionOnPlatform()  => 
            WidgetLayoutLibrary_methods.GetMousePositionOnPlatform_method.Invoke();

        ///<summary>Gets the platform's mouse cursor position in the local space of the viewport widget.</summary>
        public static Vector2D GetMousePositionOnViewport(UObject WorldContextObject)  => 
            WidgetLayoutLibrary_methods.GetMousePositionOnViewport_method.Invoke(WorldContextObject);

        ///<summary>Gets the mouse position of the player controller, scaled by the DPI.</summary>
        ///<remarks>
        ///If you're trying to go from raw mouse screenspace coordinates
        ///to fullscreen widget space, you'll need to transform the mouse into DPI Scaled space.  This function performs that scaling.
        ///
        ///MousePositionScaledByDPI = MousePosition * (1 / ViewportScale).
        ///        //DEPRECATED(4.17, "Use GetMousePositionOnViewport() instead.  Optionally and for more options, you can use GetViewportWidgetGeometry and GetPlayerScreenWidgetGeometry are newly introduced to give you the geometry of the viewport and the player screen for widgets to help convert between spaces.")
        ///</remarks>
        public static (float, float, bool) GetMousePositionScaledByDPI(PlayerController Player)  => 
            WidgetLayoutLibrary_methods.GetMousePositionScaledByDPI_method.Invoke(Player);

        ///<summary>Gets the geometry of the widget holding all widgets added to the "Player Screen".</summary>
        ///<remarks>
        ///You
        ///can use this geometry to convert between absolute and local space of widgets held on this
        ///widget.
        ///</remarks>
        public static Geometry GetPlayerScreenWidgetGeometry(PlayerController PlayerController)  => 
            WidgetLayoutLibrary_methods.GetPlayerScreenWidgetGeometry_method.Invoke(PlayerController);

        ///<summary>Gets the current DPI Scale being applied to the viewport and all the Widgets.</summary>
        public static float GetViewportScale(UObject WorldContextObject)  => 
            WidgetLayoutLibrary_methods.GetViewportScale_method.Invoke(WorldContextObject);

        ///<summary>Gets the size of the game viewport.</summary>
        public static Vector2D GetViewportSize(UObject WorldContextObject)  => 
            WidgetLayoutLibrary_methods.GetViewportSize_method.Invoke(WorldContextObject);

        ///<summary>Gets the geometry of the widget holding all widgets added to the "Viewport".</summary>
        ///<remarks>
        ///You
        ///can use this geometry to convert between absolute and local space of widgets held on this
        ///widget.
        ///</remarks>
        public static Geometry GetViewportWidgetGeometry(UObject WorldContextObject)  => 
            WidgetLayoutLibrary_methods.GetViewportWidgetGeometry_method.Invoke(WorldContextObject);

        ///<summary>
        ///Gets the projected world to screen position for a player, then converts it into a widget
        ///position, which takes into account any quality scaling.
        ///</summary>
        ///<remarks>
        ///@param PlayerController The player controller to project the position in the world to their screen.
        ///@param WorldLocation The world location to project from.
        ///@param ScreenPosition The position in the viewport with quality scale removed and DPI scale remove.
        ///@return true if the position projects onto the screen.
        ///</remarks>
        public static (Vector2D, bool) ProjectWorldLocationToWidgetPosition(PlayerController PlayerController, Vector WorldLocation)  => 
            WidgetLayoutLibrary_methods.ProjectWorldLocationToWidgetPosition_method.Invoke(PlayerController, WorldLocation);

        ///<summary>Removes all widgets from the viewport.</summary>
        public static void RemoveAllWidgets(UObject WorldContextObject)  => 
            WidgetLayoutLibrary_methods.RemoveAllWidgets_method.Invoke(WorldContextObject);

        ///<summary>Gets the slot object on the child widget as a Border Slot, allowing you to manipulate layout information.</summary>
        ///<remarks>
        ///@param Widget The child widget of a border panel.
        ///</remarks>
        public static BorderSlot SlotAsBorderSlot(Widget Widget)  => 
            WidgetLayoutLibrary_methods.SlotAsBorderSlot_method.Invoke(Widget);

        ///<summary>Gets the slot object on the child widget as a Canvas Slot, allowing you to manipulate layout information.</summary>
        ///<remarks>
        ///@param Widget The child widget of a canvas panel.
        ///</remarks>
        public static CanvasPanelSlot SlotAsCanvasSlot(Widget Widget)  => 
            WidgetLayoutLibrary_methods.SlotAsCanvasSlot_method.Invoke(Widget);

        ///<summary>Gets the slot object on the child widget as a Grid Slot, allowing you to manipulate layout information.</summary>
        ///<remarks>
        ///@param Widget The child widget of a grid panel.
        ///</remarks>
        public static GridSlot SlotAsGridSlot(Widget Widget)  => 
            WidgetLayoutLibrary_methods.SlotAsGridSlot_method.Invoke(Widget);

        ///<summary>Gets the slot object on the child widget as a Horizontal Box Slot, allowing you to manipulate its information.</summary>
        ///<remarks>
        ///@param Widget The child widget of a Horizontal Box.
        ///</remarks>
        public static HorizontalBoxSlot SlotAsHorizontalBoxSlot(Widget Widget)  => 
            WidgetLayoutLibrary_methods.SlotAsHorizontalBoxSlot_method.Invoke(Widget);

        ///<summary>Gets the slot object on the child widget as a Overlay Slot, allowing you to manipulate layout information.</summary>
        ///<remarks>
        ///@param Widget The child widget of a overlay panel.
        ///</remarks>
        public static OverlaySlot SlotAsOverlaySlot(Widget Widget)  => 
            WidgetLayoutLibrary_methods.SlotAsOverlaySlot_method.Invoke(Widget);

        ///<summary>Gets the slot object on the child widget as a Uniform Grid Slot, allowing you to manipulate layout information.</summary>
        ///<remarks>
        ///@param Widget The child widget of a uniform grid panel.
        ///</remarks>
        public static UniformGridSlot SlotAsUniformGridSlot(Widget Widget)  => 
            WidgetLayoutLibrary_methods.SlotAsUniformGridSlot_method.Invoke(Widget);

        ///<summary>Gets the slot object on the child widget as a Vertical Box Slot, allowing you to manipulate its information.</summary>
        ///<remarks>
        ///@param Widget The child widget of a Vertical Box.
        ///</remarks>
        public static VerticalBoxSlot SlotAsVerticalBoxSlot(Widget Widget)  => 
            WidgetLayoutLibrary_methods.SlotAsVerticalBoxSlot_method.Invoke(Widget);
        static WidgetLayoutLibrary() {
            StaticClass = Main.GetClass("WidgetLayoutLibrary");
        }
        internal unsafe WidgetLayoutLibrary_fields* WidgetLayoutLibrary_ptr => (WidgetLayoutLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetLayoutLibrary(IntPtr p) => UObject.Make<WidgetLayoutLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetLayoutLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetLayoutLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
