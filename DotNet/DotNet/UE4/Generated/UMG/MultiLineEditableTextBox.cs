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
    ///<summary>Allows a user to enter multiple lines of text</summary>
    public unsafe partial class MultiLineEditableTextBox : TextLayoutWidget  {

        ///<summary>Get Text</summary>
        public byte /*TODO: text FText*/ GetText()  => 
            MultiLineEditableTextBox_methods.GetText_method.Invoke(ObjPointer);

        ///<summary>Set Error</summary>
        public void SetError(byte InError /*TODO: text FText */)  => 
            MultiLineEditableTextBox_methods.SetError_method.Invoke(ObjPointer, InError);

        ///<summary>Set Is Read Only</summary>
        public void SetIsReadOnly(bool bReadOnly)  => 
            MultiLineEditableTextBox_methods.SetIsReadOnly_method.Invoke(ObjPointer, bReadOnly);

        ///<summary>Set Text</summary>
        public void SetText(byte InText /*TODO: text FText */)  => 
            MultiLineEditableTextBox_methods.SetText_method.Invoke(ObjPointer, InText);
         //TODO: text FText Text
         //TODO: text FText HintText
         //TODO: delegate FGetText HintTextDelegate
        ///<summary>The style</summary>
        public unsafe EditableTextBoxStyle WidgetStyle {
            get {return MultiLineEditableTextBox_ptr->WidgetStyle;}
            set {MultiLineEditableTextBox_ptr->WidgetStyle = value;}
        }
        ///<summary>The text style</summary>
        public unsafe TextBlockStyle TextStyle {
            get {return MultiLineEditableTextBox_ptr->TextStyle;}
            set {MultiLineEditableTextBox_ptr->TextStyle = value;}
        }
        public bool bIsReadOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bIsReadOnly"); }
        }
        public bool AllowContextMenu {
            get {return Main.GetGetBoolPropertyByName(this, "AllowContextMenu"); }
            set {Main.SetGetBoolPropertyByName(this, "AllowContextMenu", value); }
        }
        ///<summary>Additional options to be used by the virtual keyboard summoned from this widget</summary>
        public unsafe VirtualKeyboardOptions VirtualKeyboardOptions {
            get {return MultiLineEditableTextBox_ptr->VirtualKeyboardOptions;}
            set {MultiLineEditableTextBox_ptr->VirtualKeyboardOptions = value;}
        }
         //TODO: enum EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
         //TODO: multicast delegate FOnMultiLineEditableTextBoxChangedEvent OnTextChanged
         //TODO: multicast delegate FOnMultiLineEditableTextBoxCommittedEvent OnTextCommitted
        static MultiLineEditableTextBox() {
            StaticClass = Main.GetClass("MultiLineEditableTextBox");
        }
        internal unsafe MultiLineEditableTextBox_fields* MultiLineEditableTextBox_ptr => (MultiLineEditableTextBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MultiLineEditableTextBox(IntPtr p) => UObject.Make<MultiLineEditableTextBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MultiLineEditableTextBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MultiLineEditableTextBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
