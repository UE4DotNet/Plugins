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
    ///<summary>Editable text box widget</summary>
    public unsafe partial class EditableText : Widget  {

        ///<summary>
        ///Gets the widget text
        ///@
        ///</summary>
        ///<remarks>return The widget text</remarks>
        public byte /*TODO: text FText*/ GetText()  => 
            EditableText_methods.GetText_method.Invoke(ObjPointer);

        ///<summary>Set Hint Text</summary>
        public void SetHintText(byte InHintText /*TODO: text FText */)  => 
            EditableText_methods.SetHintText_method.Invoke(ObjPointer, InHintText);

        ///<summary>Set Is Password</summary>
        public void SetIsPassword(bool InbIsPassword)  => 
            EditableText_methods.SetIsPassword_method.Invoke(ObjPointer, InbIsPassword);

        ///<summary>Set Is Read Only</summary>
        public void SetIsReadOnly(bool InbIsReadyOnly)  => 
            EditableText_methods.SetIsReadOnly_method.Invoke(ObjPointer, InbIsReadyOnly);

        ///<summary>Directly sets the widget text.</summary>
        ///<remarks>
        ///Warning: This will wipe any binding created for the Text property!
        ///@param InText The text to assign to the widget
        ///</remarks>
        public void SetText(byte InText /*TODO: text FText */)  => 
            EditableText_methods.SetText_method.Invoke(ObjPointer, InText);
         //TODO: text FText Text
         //TODO: delegate FGetText TextDelegate
         //TODO: text FText HintText
         //TODO: delegate FGetText HintTextDelegate
        ///<summary>The style</summary>
        public unsafe EditableTextStyle WidgetStyle {
            get {return EditableText_ptr->WidgetStyle;}
            set {EditableText_ptr->WidgetStyle = value;}
        }
        public bool IsReadOnly {
            get {return Main.GetGetBoolPropertyByName(this, "IsReadOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "IsReadOnly", value); }
        }
        public bool IsPassword {
            get {return Main.GetGetBoolPropertyByName(this, "IsPassword"); }
            set {Main.SetGetBoolPropertyByName(this, "IsPassword", value); }
        }
        ///<summary>Minimum width that a text block should be</summary>
        public unsafe float MinimumDesiredWidth {
            get {return EditableText_ptr->MinimumDesiredWidth;}
            set {EditableText_ptr->MinimumDesiredWidth = value;}
        }
        public bool IsCaretMovedWhenGainFocus {
            get {return Main.GetGetBoolPropertyByName(this, "IsCaretMovedWhenGainFocus"); }
            set {Main.SetGetBoolPropertyByName(this, "IsCaretMovedWhenGainFocus", value); }
        }
        public bool SelectAllTextWhenFocused {
            get {return Main.GetGetBoolPropertyByName(this, "SelectAllTextWhenFocused"); }
            set {Main.SetGetBoolPropertyByName(this, "SelectAllTextWhenFocused", value); }
        }
        public bool RevertTextOnEscape {
            get {return Main.GetGetBoolPropertyByName(this, "RevertTextOnEscape"); }
            set {Main.SetGetBoolPropertyByName(this, "RevertTextOnEscape", value); }
        }
        public bool ClearKeyboardFocusOnCommit {
            get {return Main.GetGetBoolPropertyByName(this, "ClearKeyboardFocusOnCommit"); }
            set {Main.SetGetBoolPropertyByName(this, "ClearKeyboardFocusOnCommit", value); }
        }
        public bool SelectAllTextOnCommit {
            get {return Main.GetGetBoolPropertyByName(this, "SelectAllTextOnCommit"); }
            set {Main.SetGetBoolPropertyByName(this, "SelectAllTextOnCommit", value); }
        }
        public bool AllowContextMenu {
            get {return Main.GetGetBoolPropertyByName(this, "AllowContextMenu"); }
            set {Main.SetGetBoolPropertyByName(this, "AllowContextMenu", value); }
        }
        ///<summary>If we're on a platform that requires a virtual keyboard, what kind of keyboard should this widget use?</summary>
        public unsafe byte KeyboardType {
            get {return EditableText_ptr->KeyboardType;}
            set {EditableText_ptr->KeyboardType = value;}
        }
        ///<summary>Additional options for the virtual keyboard</summary>
        public unsafe VirtualKeyboardOptions VirtualKeyboardOptions {
            get {return EditableText_ptr->VirtualKeyboardOptions;}
            set {EditableText_ptr->VirtualKeyboardOptions = value;}
        }
         //TODO: enum EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
        ///<summary>How the text should be aligned with the margin.</summary>
        public unsafe byte Justification {
            get {return EditableText_ptr->Justification;}
            set {EditableText_ptr->Justification = value;}
        }
        ///<summary>Controls how the text within this widget should be shaped.</summary>
        public unsafe ShapedTextOptions ShapedTextOptions {
            get {return EditableText_ptr->ShapedTextOptions;}
        }
         //TODO: multicast delegate FOnEditableTextChangedEvent OnTextChanged
         //TODO: multicast delegate FOnEditableTextCommittedEvent OnTextCommitted
        static EditableText() {
            StaticClass = Main.GetClass("EditableText");
        }
        internal unsafe EditableText_fields* EditableText_ptr => (EditableText_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableText(IntPtr p) => UObject.Make<EditableText>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableText DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableText New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
