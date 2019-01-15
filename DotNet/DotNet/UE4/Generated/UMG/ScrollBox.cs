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
using UE4.Slate;

namespace UE4.UMG {
    ///<summary>An arbitrary scrollable collection of widgets.  Great for presenting 10-100 widgets in a list.  Doesn't support virtualization.</summary>
    public unsafe partial class ScrollBox : PanelWidget  {

        ///<summary>Gets the scroll offset of the scrollbox in Slate Units.</summary>
        public float GetScrollOffset()  => 
            ScrollBox_methods.GetScrollOffset_method.Invoke(ObjPointer);

        ///<summary>Get View Offset Fraction</summary>
        public float GetViewOffsetFraction()  => 
            ScrollBox_methods.GetViewOffsetFraction_method.Invoke(ObjPointer);

        ///<summary>Scrolls the ScrollBox to the bottom instantly during the next layout pass.</summary>
        public void ScrollToEnd()  => 
            ScrollBox_methods.ScrollToEnd_method.Invoke(ObjPointer);

        ///<summary>Scrolls the ScrollBox to the top instantly</summary>
        public void ScrollToStart()  => 
            ScrollBox_methods.ScrollToStart_method.Invoke(ObjPointer);

        ///<summary>Scrolls the ScrollBox to the widget during the next layout pass.</summary>
        public void ScrollWidgetIntoView(Widget WidgetToFind, bool AnimateScroll, EDescendantScrollDestination ScrollDestination)  => 
            ScrollBox_methods.ScrollWidgetIntoView_method.Invoke(ObjPointer, WidgetToFind, AnimateScroll, ScrollDestination);

        ///<summary>Set Allow Overscroll</summary>
        public void SetAllowOverscroll(bool NewAllowOverscroll)  => 
            ScrollBox_methods.SetAllowOverscroll_method.Invoke(ObjPointer, NewAllowOverscroll);

        ///<summary>Set Always Show Scrollbar</summary>
        public void SetAlwaysShowScrollbar(bool NewAlwaysShowScrollbar)  => 
            ScrollBox_methods.SetAlwaysShowScrollbar_method.Invoke(ObjPointer, NewAlwaysShowScrollbar);

        ///<summary>Set Orientation</summary>
        public void SetOrientation(byte NewOrientation)  => 
            ScrollBox_methods.SetOrientation_method.Invoke(ObjPointer, NewOrientation);

        ///<summary>Set Scrollbar Thickness</summary>
        public void SetScrollbarThickness(Vector2D NewScrollbarThickness)  => 
            ScrollBox_methods.SetScrollbarThickness_method.Invoke(ObjPointer, NewScrollbarThickness);

        ///<summary>Set Scroll Bar Visibility</summary>
        public void SetScrollBarVisibility(ESlateVisibility NewScrollBarVisibility)  => 
            ScrollBox_methods.SetScrollBarVisibility_method.Invoke(ObjPointer, NewScrollBarVisibility);

        ///<summary>Updates the scroll offset of the scrollbox.</summary>
        ///<remarks>
        ///@param NewScrollOffset is in Slate Units.
        ///</remarks>
        public void SetScrollOffset(float NewScrollOffset)  => 
            ScrollBox_methods.SetScrollOffset_method.Invoke(ObjPointer, NewScrollOffset);
        ///<summary>The style</summary>
        public unsafe ScrollBoxStyle WidgetStyle {
            get {return ScrollBox_ptr->WidgetStyle;}
            set {ScrollBox_ptr->WidgetStyle = value;}
        }
        ///<summary>The bar style</summary>
        public unsafe ScrollBarStyle WidgetBarStyle {
            get {return ScrollBox_ptr->WidgetBarStyle;}
            set {ScrollBox_ptr->WidgetBarStyle = value;}
        }
        ///<summary>The orientation of the scrolling and stacking in the box.</summary>
        public unsafe byte Orientation {
            get {return ScrollBox_ptr->Orientation;}
        }
         //TODO: enum ESlateVisibility ScrollBarVisibility
         //TODO: enum EConsumeMouseWheel ConsumeMouseWheel
        ///<summary>Scrollbar Thickness</summary>
        public unsafe Vector2D ScrollbarThickness {
            get {return ScrollBox_ptr->ScrollbarThickness;}
        }
        public bool AlwaysShowScrollbar {
            get {return Main.GetGetBoolPropertyByName(this, "AlwaysShowScrollbar"); }
        }
        public bool AllowOverscroll {
            get {return Main.GetGetBoolPropertyByName(this, "AllowOverscroll"); }
        }
         //TODO: enum EDescendantScrollDestination NavigationDestination
        ///<summary>
        ///The amount of padding to ensure exists between the item being navigated to, at the edge of the
        ///scrollbox.
        ///</summary>
        ///<remarks>Use this if you want to ensure there's a preview of the next item the user could scroll to.</remarks>
        public unsafe float NavigationScrollPadding {
            get {return ScrollBox_ptr->NavigationScrollPadding;}
        }
        public bool bAllowRightClickDragScrolling {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowRightClickDragScrolling"); }
        }
         //TODO: multicast delegate FOnUserScrolledEvent OnUserScrolled
        static ScrollBox() {
            StaticClass = Main.GetClass("ScrollBox");
        }
        internal unsafe ScrollBox_fields* ScrollBox_ptr => (ScrollBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ScrollBox(IntPtr p) => UObject.Make<ScrollBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ScrollBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ScrollBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
