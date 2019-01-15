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
    ///<summary>Allows the user to type in custom text.</summary>
    ///<remarks>
    ///Only permits a single line of text to be entered.
    ///
    ///* No Children
    ///* Text Entry
    ///</remarks>
    public unsafe partial class EditableTextBox : Widget  {

        ///<summary>Clear Error</summary>
        public void ClearError()  => 
            EditableTextBox_methods.ClearError_method.Invoke(ObjPointer);

        ///<summary>Get Text</summary>
        public byte /*TODO: text FText*/ GetText()  => 
            EditableTextBox_methods.GetText_method.Invoke(ObjPointer);

        ///<summary>Has Error</summary>
        public bool HasError()  => 
            EditableTextBox_methods.HasError_method.Invoke(ObjPointer);

        ///<summary>Set Error</summary>
        public void SetError(byte InError /*TODO: text FText */)  => 
            EditableTextBox_methods.SetError_method.Invoke(ObjPointer, InError);

        ///<summary>Set Hint Text</summary>
        public void SetHintText(byte InText /*TODO: text FText */)  => 
            EditableTextBox_methods.SetHintText_method.Invoke(ObjPointer, InText);

        ///<summary>Set Is Password</summary>
        public void SetIsPassword(bool bIsPassword)  => 
            EditableTextBox_methods.SetIsPassword_method.Invoke(ObjPointer, bIsPassword);

        ///<summary>Set Is Read Only</summary>
        public void SetIsReadOnly(bool bReadOnly)  => 
            EditableTextBox_methods.SetIsReadOnly_method.Invoke(ObjPointer, bReadOnly);

        ///<summary>Set Text</summary>
        public void SetText(byte InText /*TODO: text FText */)  => 
            EditableTextBox_methods.SetText_method.Invoke(ObjPointer, InText);
         //TODO: text FText Text
         //TODO: delegate FGetText TextDelegate
        ///<summary>The style</summary>
        public unsafe EditableTextBoxStyle WidgetStyle {
            get {return EditableTextBox_ptr->WidgetStyle;}
            set {EditableTextBox_ptr->WidgetStyle = value;}
        }
         //TODO: text FText HintText
         //TODO: delegate FGetText HintTextDelegate
        public bool IsReadOnly {
            get {return Main.GetGetBoolPropertyByName(this, "IsReadOnly"); }
        }
        public bool IsPassword {
            get {return Main.GetGetBoolPropertyByName(this, "IsPassword"); }
        }
        ///<summary>Minimum width that a text block should be</summary>
        public unsafe float MinimumDesiredWidth {
            get {return EditableTextBox_ptr->MinimumDesiredWidth;}
        }
        public bool IsCaretMovedWhenGainFocus {
            get {return Main.GetGetBoolPropertyByName(this, "IsCaretMovedWhenGainFocus"); }
        }
        public bool SelectAllTextWhenFocused {
            get {return Main.GetGetBoolPropertyByName(this, "SelectAllTextWhenFocused"); }
        }
        public bool RevertTextOnEscape {
            get {return Main.GetGetBoolPropertyByName(this, "RevertTextOnEscape"); }
        }
        public bool ClearKeyboardFocusOnCommit {
            get {return Main.GetGetBoolPropertyByName(this, "ClearKeyboardFocusOnCommit"); }
        }
        public bool SelectAllTextOnCommit {
            get {return Main.GetGetBoolPropertyByName(this, "SelectAllTextOnCommit"); }
        }
        public bool AllowContextMenu {
            get {return Main.GetGetBoolPropertyByName(this, "AllowContextMenu"); }
            set {Main.SetGetBoolPropertyByName(this, "AllowContextMenu", value); }
        }
        ///<summary>If we're on a platform that requires a virtual keyboard, what kind of keyboard should this widget use?</summary>
        public unsafe byte KeyboardType {
            get {return EditableTextBox_ptr->KeyboardType;}
            set {EditableTextBox_ptr->KeyboardType = value;}
        }
        ///<summary>Additional options to use for the virtual keyboard summoned by this widget</summary>
        public unsafe VirtualKeyboardOptions VirtualKeyboardOptions {
            get {return EditableTextBox_ptr->VirtualKeyboardOptions;}
            set {EditableTextBox_ptr->VirtualKeyboardOptions = value;}
        }
         //TODO: enum EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
        ///<summary>How the text should be aligned with the margin.</summary>
        public unsafe byte Justification {
            get {return EditableTextBox_ptr->Justification;}
            set {EditableTextBox_ptr->Justification = value;}
        }
        ///<summary>Controls how the text within this widget should be shaped.</summary>
        public unsafe ShapedTextOptions ShapedTextOptions {
            get {return EditableTextBox_ptr->ShapedTextOptions;}
        }
         //TODO: multicast delegate FOnEditableTextBoxChangedEvent OnTextChanged
         //TODO: multicast delegate FOnEditableTextBoxCommittedEvent OnTextCommitted
        static EditableTextBox() {
            StaticClass = Main.GetClass("EditableTextBox");
        }
        internal unsafe EditableTextBox_fields* EditableTextBox_ptr => (EditableTextBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableTextBox(IntPtr p) => UObject.Make<EditableTextBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableTextBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableTextBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
