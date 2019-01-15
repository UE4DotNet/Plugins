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
    public unsafe partial class MultiLineEditableText : TextLayoutWidget  {

        ///<summary>Get Text</summary>
        public byte /*TODO: text FText*/ GetText()  => 
            MultiLineEditableText_methods.GetText_method.Invoke(ObjPointer);

        ///<summary>Set Is Read Only</summary>
        public void SetIsReadOnly(bool bReadOnly)  => 
            MultiLineEditableText_methods.SetIsReadOnly_method.Invoke(ObjPointer, bReadOnly);

        ///<summary>Set Text</summary>
        public void SetText(byte InText /*TODO: text FText */)  => 
            MultiLineEditableText_methods.SetText_method.Invoke(ObjPointer, InText);
         //TODO: text FText Text
         //TODO: text FText HintText
         //TODO: delegate FGetText HintTextDelegate
        ///<summary>The style</summary>
        public unsafe TextBlockStyle WidgetStyle {
            get {return MultiLineEditableText_ptr->WidgetStyle;}
            set {MultiLineEditableText_ptr->WidgetStyle = value;}
        }
        public bool bIsReadOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bIsReadOnly"); }
        }
        public bool SelectAllTextWhenFocused {
            get {return Main.GetGetBoolPropertyByName(this, "SelectAllTextWhenFocused"); }
            set {Main.SetGetBoolPropertyByName(this, "SelectAllTextWhenFocused", value); }
        }
        public bool ClearTextSelectionOnFocusLoss {
            get {return Main.GetGetBoolPropertyByName(this, "ClearTextSelectionOnFocusLoss"); }
            set {Main.SetGetBoolPropertyByName(this, "ClearTextSelectionOnFocusLoss", value); }
        }
        public bool RevertTextOnEscape {
            get {return Main.GetGetBoolPropertyByName(this, "RevertTextOnEscape"); }
            set {Main.SetGetBoolPropertyByName(this, "RevertTextOnEscape", value); }
        }
        public bool ClearKeyboardFocusOnCommit {
            get {return Main.GetGetBoolPropertyByName(this, "ClearKeyboardFocusOnCommit"); }
            set {Main.SetGetBoolPropertyByName(this, "ClearKeyboardFocusOnCommit", value); }
        }
        public bool AllowContextMenu {
            get {return Main.GetGetBoolPropertyByName(this, "AllowContextMenu"); }
            set {Main.SetGetBoolPropertyByName(this, "AllowContextMenu", value); }
        }
        ///<summary>Additional options for the virtual keyboard</summary>
        public unsafe VirtualKeyboardOptions VirtualKeyboardOptions {
            get {return MultiLineEditableText_ptr->VirtualKeyboardOptions;}
            set {MultiLineEditableText_ptr->VirtualKeyboardOptions = value;}
        }
         //TODO: enum EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
         //TODO: multicast delegate FOnMultiLineEditableTextChangedEvent OnTextChanged
         //TODO: multicast delegate FOnMultiLineEditableTextCommittedEvent OnTextCommitted
        static MultiLineEditableText() {
            StaticClass = Main.GetClass("MultiLineEditableText");
        }
        internal unsafe MultiLineEditableText_fields* MultiLineEditableText_ptr => (MultiLineEditableText_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MultiLineEditableText(IntPtr p) => UObject.Make<MultiLineEditableText>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MultiLineEditableText DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MultiLineEditableText New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
