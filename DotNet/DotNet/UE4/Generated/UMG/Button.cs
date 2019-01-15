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

namespace UE4.UMG {
    ///<summary>
    ///The button is a click-able primitive widget to enable basic interaction, you
    ///can place any other widget inside a button to make a more complex and
    ///interesting click-able element in your UI.
    ///</summary>
    ///<remarks>
    ///* Single Child
    ///* Clickable
    ///</remarks>
    public unsafe partial class Button : ContentWidget  {

        ///<summary>Returns true if the user is actively pressing the button.</summary>
        ///<remarks>
        ///Do not use this for detecting 'Clicks', use the OnClicked event instead.
        ///
        ///@return true if the user is actively pressing the button otherwise false.
        ///</remarks>
        public bool IsPressed()  => 
            Button_methods.IsPressed_method.Invoke(ObjPointer);

        ///<summary>Sets the color multiplier for the button background</summary>
        public void SetBackgroundColor(LinearColor InBackgroundColor)  => 
            Button_methods.SetBackgroundColor_method.Invoke(ObjPointer, InBackgroundColor);

        ///<summary>Set Click Method</summary>
        public void SetClickMethod(byte InClickMethod)  => 
            Button_methods.SetClickMethod_method.Invoke(ObjPointer, InClickMethod);

        ///<summary>Sets the color multiplier for the button content</summary>
        public void SetColorAndOpacity(LinearColor InColorAndOpacity)  => 
            Button_methods.SetColorAndOpacity_method.Invoke(ObjPointer, InColorAndOpacity);

        ///<summary>Set Press Method</summary>
        public void SetPressMethod(byte InPressMethod)  => 
            Button_methods.SetPressMethod_method.Invoke(ObjPointer, InPressMethod);

        ///<summary>Sets the color multiplier for the button background</summary>
        public void SetStyle(ButtonStyle InStyle)  => 
            Button_methods.SetStyle_method.Invoke(ObjPointer, InStyle);

        ///<summary>Set Touch Method</summary>
        public void SetTouchMethod(byte InTouchMethod)  => 
            Button_methods.SetTouchMethod_method.Invoke(ObjPointer, InTouchMethod);
        ///<summary>The button style used at runtime</summary>
        public unsafe ButtonStyle WidgetStyle {
            get {return Button_ptr->WidgetStyle;}
            set {Button_ptr->WidgetStyle = value;}
        }
        ///<summary>The color multiplier for the button content</summary>
        public unsafe LinearColor ColorAndOpacity {
            get {return Button_ptr->ColorAndOpacity;}
        }
        ///<summary>The color multiplier for the button background</summary>
        public unsafe LinearColor BackgroundColor {
            get {return Button_ptr->BackgroundColor;}
        }
        ///<summary>The type of mouse action required by the user to trigger the buttons 'Click'</summary>
        public unsafe byte ClickMethod {
            get {return Button_ptr->ClickMethod;}
        }
        ///<summary>The type of touch action required by the user to trigger the buttons 'Click'</summary>
        public unsafe byte TouchMethod {
            get {return Button_ptr->TouchMethod;}
        }
        ///<summary>The type of keyboard/gamepad button press action required by the user to trigger the buttons 'Click'</summary>
        public unsafe byte PressMethod {
            get {return Button_ptr->PressMethod;}
        }
        public bool IsFocusable {
            get {return Main.GetGetBoolPropertyByName(this, "IsFocusable"); }
        }
         //TODO: multicast delegate FOnButtonClickedEvent OnClicked
         //TODO: multicast delegate FOnButtonPressedEvent OnPressed
         //TODO: multicast delegate FOnButtonReleasedEvent OnReleased
         //TODO: multicast delegate FOnButtonHoverEvent OnHovered
         //TODO: multicast delegate FOnButtonHoverEvent OnUnhovered
        static Button() {
            StaticClass = Main.GetClass("Button");
        }
        internal unsafe Button_fields* Button_ptr => (Button_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Button(IntPtr p) => UObject.Make<Button>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Button DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Button New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
