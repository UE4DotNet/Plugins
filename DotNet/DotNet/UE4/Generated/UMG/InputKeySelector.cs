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
    ///<summary>A widget for selecting a single key or a single key with a modifier.</summary>
    public unsafe partial class InputKeySelector : Widget  {

        ///<summary>Returns true if the widget is currently selecting a key, otherwise returns false.</summary>
        public bool GetIsSelectingKey()  => 
            InputKeySelector_methods.GetIsSelectingKey_method.Invoke(ObjPointer);

        ///<summary>Sets whether or not gamepad keys are allowed in the selected key.</summary>
        public void SetAllowGamepadKeys(bool bInAllowGamepadKeys)  => 
            InputKeySelector_methods.SetAllowGamepadKeys_method.Invoke(ObjPointer, bInAllowGamepadKeys);

        ///<summary>Sets whether or not modifier keys are allowed in the selected key.</summary>
        public void SetAllowModifierKeys(bool bInAllowModifierKeys)  => 
            InputKeySelector_methods.SetAllowModifierKeys_method.Invoke(ObjPointer, bInAllowModifierKeys);

        ///<summary>Sets escape keys.</summary>
        public void SetEscapeKeys(byte InKeys /*TODO: array TArray */)  => 
            InputKeySelector_methods.SetEscapeKeys_method.Invoke(ObjPointer, InKeys);

        ///<summary>Sets the text which is displayed while selecting keys.</summary>
        public void SetKeySelectionText(byte InKeySelectionText /*TODO: text FText */)  => 
            InputKeySelector_methods.SetKeySelectionText_method.Invoke(ObjPointer, InKeySelectionText);

        ///<summary>Sets the text to display when no key text is available or not selecting a key.</summary>
        public void SetNoKeySpecifiedText(byte InNoKeySpecifiedText /*TODO: text FText */)  => 
            InputKeySelector_methods.SetNoKeySpecifiedText_method.Invoke(ObjPointer, InNoKeySpecifiedText);

        ///<summary>Sets the currently selected key.</summary>
        public void SetSelectedKey(InputChord InSelectedKey)  => 
            InputKeySelector_methods.SetSelectedKey_method.Invoke(ObjPointer, InSelectedKey);

        ///<summary>Sets the visibility of the text block.</summary>
        public void SetTextBlockVisibility(ESlateVisibility InVisibility)  => 
            InputKeySelector_methods.SetTextBlockVisibility_method.Invoke(ObjPointer, InVisibility);
        ///<summary>The button style used at runtime</summary>
        public unsafe ButtonStyle WidgetStyle {
            get {return InputKeySelector_ptr->WidgetStyle;}
            set {InputKeySelector_ptr->WidgetStyle = value;}
        }
        ///<summary>The button style used at runtime</summary>
        public unsafe TextBlockStyle TextStyle {
            get {return InputKeySelector_ptr->TextStyle;}
            set {InputKeySelector_ptr->TextStyle = value;}
        }
        ///<summary>The currently selected key chord.</summary>
        public unsafe InputChord SelectedKey {
            get {return InputKeySelector_ptr->SelectedKey;}
        }
        ///<summary>The amount of blank space around the text used to display the currently selected key.</summary>
        public unsafe Margin Margin {
            get {return InputKeySelector_ptr->Margin;}
        }
         //TODO: text FText KeySelectionText
         //TODO: text FText NoKeySpecifiedText
        public bool bAllowModifierKeys {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowModifierKeys"); }
        }
        public bool bAllowGamepadKeys {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowGamepadKeys"); }
        }
         //TODO: array not UObject TArray EscapeKeys
         //TODO: multicast delegate FOnKeySelected OnKeySelected
         //TODO: multicast delegate FOnIsSelectingKeyChanged OnIsSelectingKeyChanged
        static InputKeySelector() {
            StaticClass = Main.GetClass("InputKeySelector");
        }
        internal unsafe InputKeySelector_fields* InputKeySelector_ptr => (InputKeySelector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InputKeySelector(IntPtr p) => UObject.Make<InputKeySelector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InputKeySelector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InputKeySelector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
