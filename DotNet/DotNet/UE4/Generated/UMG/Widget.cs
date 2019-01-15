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
using UE4.SlateCore;
using UE4.Engine;

namespace UE4.UMG {
    ///<summary>This is the base class for all wrapped Slate controls that are exposed to UObjects.</summary>
    public unsafe partial class Widget : Visual  {

        ///<summary>Forces a pre-pass.</summary>
        ///<remarks>
        ///A pre-pass caches the desired size of the widget hierarchy owned by this widget.
        ///One pre-pass is already happens for every widget before Tick occurs.  You only need to perform another
        ///pre-pass if you are adding child widgets this frame and want them to immediately be visible this frame.
        ///</remarks>
        public void ForceLayoutPrepass()  => 
            Widget_methods.ForceLayoutPrepass_method.Invoke(ObjPointer);

        ///<summary>Sets the forced volatility of the widget.</summary>
        public void ForceVolatile(bool bForce)  => 
            Widget_methods.ForceVolatile_method.Invoke(ObjPointer, bForce);

        ///<summary>Gets the last geometry used to Tick the widget.</summary>
        ///<remarks>
        ///This data may not exist yet if this call happens prior to
        ///the widget having been ticked/painted, or it may be out of date, or a frame behind.
        ///
        ///We recommend not to use this data unless there's no other way to solve your problem.  Normally in Slate we
        ///try and handle these issues by making a dependent widget part of the hierarchy, as to avoid frame behind
        ///or what are referred to as hysteresis problems, both caused by depending on geometry from the previous frame
        ///being used to advise how to layout a dependent object the current frame.
        ///</remarks>
        public void GetCachedGeometry(Geometry ReturnValue)  => 
            Widget_methods.GetCachedGeometry_method.Invoke(ObjPointer, ReturnValue);

        ///<summary>Gets the clipping state of this widget.</summary>
        public EWidgetClipping GetClipping()  => 
            Widget_methods.GetClipping_method.Invoke(ObjPointer);

        ///<summary>Gets the widgets desired size.</summary>
        ///<remarks>
        ///NOTE: The underlying Slate widget must exist and be valid, also at least one pre-pass must
        ///      have occurred before this value will be of any use.
        ///
        ///@return The widget's desired size
        ///</remarks>
        public Vector2D GetDesiredSize()  => 
            Widget_methods.GetDesiredSize_method.Invoke(ObjPointer);

        ///<summary>Gets the current enabled status of the widget</summary>
        public bool GetIsEnabled()  => 
            Widget_methods.GetIsEnabled_method.Invoke(ObjPointer);

        ///<summary>Gets the local player associated with this UI.</summary>
        ///<remarks>
        ///@return The owning local player.
        ///</remarks>
        public LocalPlayer GetOwningLocalPlayer()  => 
            Widget_methods.GetOwningLocalPlayer_method.Invoke(ObjPointer);

        ///<summary>Gets the player controller associated with this UI.</summary>
        ///<remarks>
        ///@return The player controller that owns the UI.
        ///</remarks>
        public PlayerController GetOwningPlayer()  => 
            Widget_methods.GetOwningPlayer_method.Invoke(ObjPointer);

        ///<summary>Gets the parent widget</summary>
        public PanelWidget GetParent()  => 
            Widget_methods.GetParent_method.Invoke(ObjPointer);

        ///<summary>Gets the current visibility of the widget.</summary>
        public float GetRenderOpacity()  => 
            Widget_methods.GetRenderOpacity_method.Invoke(ObjPointer);

        ///<summary>Gets the current visibility of the widget.</summary>
        public ESlateVisibility GetVisibility()  => 
            Widget_methods.GetVisibility_method.Invoke(ObjPointer);

        ///<summary>@return true if this widget is focused by any user.</summary>
        public bool HasAnyUserFocus()  => 
            Widget_methods.HasAnyUserFocus_method.Invoke(ObjPointer);

        ///<summary>@return true if any descendant widget is focused by any user.</summary>
        public bool HasFocusedDescendants()  => 
            Widget_methods.HasFocusedDescendants_method.Invoke(ObjPointer);

        ///<summary>
        ///Checks to see if this widget currently has the keyboard focus
        ///@
        ///</summary>
        ///<remarks>return  True if this widget has keyboard focus</remarks>
        public bool HasKeyboardFocus()  => 
            Widget_methods.HasKeyboardFocus_method.Invoke(ObjPointer);

        ///<summary>
        ///Checks to see if this widget is the current mouse captor
        ///@
        ///</summary>
        ///<remarks>return  True if this widget has captured the mouse</remarks>
        public bool HasMouseCapture()  => 
            Widget_methods.HasMouseCapture_method.Invoke(ObjPointer);

        ///<summary>
        ///Checks to see if this widget is the current mouse captor
        ///     @
        ///</summary>
        ///<remarks>
        ///param User index to check for capture
        ///     @param Optional pointer index to check for capture
        ///     @return  True if this widget has captured the mouse with given user and pointer
        ///</remarks>
        public bool HasMouseCaptureByUser(int UserIndex, int PointerIndex)  => 
            Widget_methods.HasMouseCaptureByUser_method.Invoke(ObjPointer, UserIndex, PointerIndex);

        ///<summary>@return true if this widget is focused by a specific user.</summary>
        public bool HasUserFocus(PlayerController PlayerController)  => 
            Widget_methods.HasUserFocus_method.Invoke(ObjPointer, PlayerController);

        ///<summary>@return true if any descendant widget is focused by a specific user.</summary>
        public bool HasUserFocusedDescendants(PlayerController PlayerController)  => 
            Widget_methods.HasUserFocusedDescendants_method.Invoke(ObjPointer, PlayerController);

        ///<summary>Invalidates the widget from the view of a layout caching widget that may own this widget.</summary>
        ///<remarks>will force the owning widget to redraw and cache children on the next paint pass.</remarks>
        public void InvalidateLayoutAndVolatility()  => 
            Widget_methods.InvalidateLayoutAndVolatility_method.Invoke(ObjPointer);

        ///<summary>@return true if the widget is currently being hovered by a pointer device</summary>
        public bool IsHovered()  => 
            Widget_methods.IsHovered_method.Invoke(ObjPointer);

        ///<summary>@return true if the widget is Visible, HitTestInvisible or SelfHitTestInvisible.</summary>
        public bool IsVisible()  => 
            Widget_methods.IsVisible_method.Invoke(ObjPointer);

        ///<summary>Removes the widget from its parent widget.</summary>
        ///<remarks>
        ///If this widget was added to the player's screen or the viewport
        ///it will also be removed from those containers.
        ///</remarks>
        public void RemoveFromParent()  => 
            Widget_methods.RemoveFromParent_method.Invoke(ObjPointer);

        ///<summary>Resets the cursor to use on the widget, removing any customization for it.</summary>
        public void ResetCursor()  => 
            Widget_methods.ResetCursor_method.Invoke(ObjPointer);

        ///<summary>Sets the widget navigation rules for all directions.</summary>
        ///<remarks>
        ///This can only be called on widgets that are in a widget tree.
        ///@param Rule The rule to use when navigation is taking place
        ///@param WidgetToFocus When using the Explicit rule, focus on this widget
        ///</remarks>
        public void SetAllNavigationRules(EUINavigationRule Rule, Name WidgetToFocus)  => 
            Widget_methods.SetAllNavigationRules_method.Invoke(ObjPointer, Rule, WidgetToFocus);

        ///<summary>Sets the clipping state of this widget.</summary>
        public void SetClipping(EWidgetClipping InClipping)  => 
            Widget_methods.SetClipping_method.Invoke(ObjPointer, InClipping);

        ///<summary>Sets the cursor to show over the widget.</summary>
        public void SetCursor(byte InCursor)  => 
            Widget_methods.SetCursor_method.Invoke(ObjPointer, InCursor);

        ///<summary>Sets the current enabled status of the widget</summary>
        public void SetIsEnabled(bool bInIsEnabled)  => 
            Widget_methods.SetIsEnabled_method.Invoke(ObjPointer, bInIsEnabled);

        ///<summary>Sets the focus to this widget.</summary>
        public void SetKeyboardFocus()  => 
            Widget_methods.SetKeyboardFocus_method.Invoke(ObjPointer);

        ///<summary>Sets the widget navigation rules for a specific direction.</summary>
        ///<remarks>
        ///This can only be called on widgets that are in a widget tree.
        ///@param Direction
        ///@param Rule The rule to use when navigation is taking place
        ///@param WidgetToFocus When using the Explicit rule, focus on this widget
        ///</remarks>
        public void SetNavigationRule(EUINavigation Direction, EUINavigationRule Rule, Name WidgetToFocus)  => 
            Widget_methods.SetNavigationRule_method.Invoke(ObjPointer, Direction, Rule, WidgetToFocus);

        ///<summary>Set Render Angle</summary>
        public void SetRenderAngle(float Angle)  => 
            Widget_methods.SetRenderAngle_method.Invoke(ObjPointer, Angle);

        ///<summary>Sets the visibility of the widget.</summary>
        public void SetRenderOpacity(float InOpacity)  => 
            Widget_methods.SetRenderOpacity_method.Invoke(ObjPointer, InOpacity);

        ///<summary>Set Render Scale</summary>
        public void SetRenderScale(Vector2D Scale)  => 
            Widget_methods.SetRenderScale_method.Invoke(ObjPointer, Scale);

        ///<summary>Set Render Shear</summary>
        public void SetRenderShear(Vector2D Shear)  => 
            Widget_methods.SetRenderShear_method.Invoke(ObjPointer, Shear);

        ///<summary>Set Render Transform</summary>
        public void SetRenderTransform(WidgetTransform InTransform)  => 
            Widget_methods.SetRenderTransform_method.Invoke(ObjPointer, InTransform);

        ///<summary>Set Render Transform Pivot</summary>
        public void SetRenderTransformPivot(Vector2D Pivot)  => 
            Widget_methods.SetRenderTransformPivot_method.Invoke(ObjPointer, Pivot);

        ///<summary>Set Render Translation</summary>
        public void SetRenderTranslation(Vector2D Translation)  => 
            Widget_methods.SetRenderTranslation_method.Invoke(ObjPointer, Translation);

        ///<summary>Sets a custom widget as the tooltip of the widget.</summary>
        public void SetToolTip(Widget Widget)  => 
            Widget_methods.SetToolTip_method.Invoke(ObjPointer, Widget);

        ///<summary>Sets the tooltip text for the widget.</summary>
        public void SetToolTipText(byte InToolTipText /*TODO: text FText */)  => 
            Widget_methods.SetToolTipText_method.Invoke(ObjPointer, InToolTipText);

        ///<summary>Sets the focus to this widget for a specific user</summary>
        public void SetUserFocus(PlayerController PlayerController)  => 
            Widget_methods.SetUserFocus_method.Invoke(ObjPointer, PlayerController);

        ///<summary>Sets the visibility of the widget.</summary>
        public void SetVisibility(ESlateVisibility InVisibility)  => 
            Widget_methods.SetVisibility_method.Invoke(ObjPointer, InVisibility);
        ///<summary>The parent slot of the UWidget.  Allows us to easily inline edit the layout controlling this widget.</summary>
        public unsafe PanelSlot Slot {
            get {return Widget_ptr->Slot;}
        }
         //TODO: delegate FGetBool bIsEnabledDelegate
         //TODO: text FText ToolTipText
         //TODO: delegate FGetText ToolTipTextDelegate
        ///<summary>Tooltip widget to show when the user hovers over the widget with the mouse</summary>
        public unsafe Widget ToolTipWidget {
            get {return Widget_ptr->ToolTipWidget;}
        }
         //TODO: delegate FGetWidget ToolTipWidgetDelegate
         //TODO: delegate FGetSlateVisibility VisibilityDelegate
        ///<summary>The render transform of the widget allows for arbitrary 2D transforms to be applied to the widget.</summary>
        public unsafe WidgetTransform RenderTransform {
            get {return Widget_ptr->RenderTransform;}
        }
        ///<summary>The render transform pivot controls the location about which transforms are applied.</summary>
        ///<remarks>This value is a normalized coordinate about which things like rotations will occur.</remarks>
        public unsafe Vector2D RenderTransformPivot {
            get {return Widget_ptr->RenderTransformPivot;}
        }
        public bool bIsVariable {
            get {return Main.GetGetBoolPropertyByName(this, "bIsVariable"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsVariable", value); }
        }
        public bool bCreatedByConstructionScript {
            get {return Main.GetGetBoolPropertyByName(this, "bCreatedByConstructionScript"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreatedByConstructionScript", value); }
        }
        public bool bIsEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bIsEnabled"); }
        }
        public bool bOverride_Cursor {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_Cursor"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_Cursor", value); }
        }
        public bool bIsVolatile {
            get {return Main.GetGetBoolPropertyByName(this, "bIsVolatile"); }
        }
        public bool bHiddenInDesigner {
            get {return Main.GetGetBoolPropertyByName(this, "bHiddenInDesigner"); }
            set {Main.SetGetBoolPropertyByName(this, "bHiddenInDesigner", value); }
        }
        public bool bExpandedInDesigner {
            get {return Main.GetGetBoolPropertyByName(this, "bExpandedInDesigner"); }
            set {Main.SetGetBoolPropertyByName(this, "bExpandedInDesigner", value); }
        }
        public bool bLockedInDesigner {
            get {return Main.GetGetBoolPropertyByName(this, "bLockedInDesigner"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockedInDesigner", value); }
        }
        ///<summary>The cursor to show when the mouse is over the widget</summary>
        public unsafe byte Cursor {
            get {return Widget_ptr->Cursor;}
        }
         //TODO: enum EWidgetClipping Clipping
         //TODO: enum ESlateVisibility Visibility
        ///<summary>The opacity of the widget</summary>
        public unsafe float RenderOpacity {
            get {return Widget_ptr->RenderOpacity;}
            set {Widget_ptr->RenderOpacity = value;}
        }
        ///<summary>
        ///The navigation object for this widget is optionally created if the user has configured custom
        ///navigation rules for this widget in the widget designer.
        ///</summary>
        ///<remarks>
        ///Those rules determine how navigation transitions
        ///can occur between widgets.
        ///</remarks>
        public unsafe WidgetNavigation Navigation {
            get {return Widget_ptr->Navigation;}
        }
        ///<summary>Native property bindings.</summary>
        public ObjectArrayField<PropertyBinding> NativeBindings{ get {
            if(NativeBindings_store == null) NativeBindings_store = new ObjectArrayField<PropertyBinding> (&Widget_ptr->NativeBindings);
            return NativeBindings_store;
        } }
        private ObjectArrayField<PropertyBinding> NativeBindings_store;

        ///<summary>Any flags used by the designer at edit time.</summary>
        public unsafe byte DesignerFlags {
            get {return Widget_ptr->DesignerFlags;}
            set {Widget_ptr->DesignerFlags = value;}
        }
         //TODO: string FString DisplayLabel
        static Widget() {
            StaticClass = Main.GetClass("Widget");
        }
        internal unsafe Widget_fields* Widget_ptr => (Widget_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Widget(IntPtr p) => UObject.Make<Widget>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Widget DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Widget New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
