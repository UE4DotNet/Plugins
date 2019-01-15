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
    ///The checkbox widget allows you to display a toggled state of 'unchecked', 'checked' and
    ///'indeterminable.
    ///</summary>
    ///<remarks>
    ///You can use the checkbox for a classic checkbox, or as a toggle button,
    ///or as radio buttons.
    ///
    ///* Single Child
    ///* Toggle
    ///</remarks>
    public unsafe partial class CheckBox : ContentWidget  {

        ///<summary>@return the full current checked state.</summary>
        public ECheckBoxState GetCheckedState()  => 
            CheckBox_methods.GetCheckedState_method.Invoke(ObjPointer);

        ///<summary>Returns true if the checkbox is currently checked</summary>
        public bool IsChecked()  => 
            CheckBox_methods.IsChecked_method.Invoke(ObjPointer);

        ///<summary>Returns true if this button is currently pressed</summary>
        public bool IsPressed()  => 
            CheckBox_methods.IsPressed_method.Invoke(ObjPointer);

        ///<summary>Sets the checked state.</summary>
        public void SetCheckedState(ECheckBoxState InCheckedState)  => 
            CheckBox_methods.SetCheckedState_method.Invoke(ObjPointer, InCheckedState);

        ///<summary>Sets the checked state.</summary>
        public void SetIsChecked(bool InIsChecked)  => 
            CheckBox_methods.SetIsChecked_method.Invoke(ObjPointer, InIsChecked);
         //TODO: enum ECheckBoxState CheckedState
         //TODO: delegate FGetCheckBoxState CheckedStateDelegate
        ///<summary>The checkbox bar style</summary>
        public unsafe CheckBoxStyle WidgetStyle {
            get {return CheckBox_ptr->WidgetStyle;}
            set {CheckBox_ptr->WidgetStyle = value;}
        }
        ///<summary>How the content of the toggle button should align within the given space</summary>
        public unsafe byte HorizontalAlignment {
            get {return CheckBox_ptr->HorizontalAlignment;}
        }
        public bool IsFocusable {
            get {return Main.GetGetBoolPropertyByName(this, "IsFocusable"); }
        }
         //TODO: multicast delegate FOnCheckBoxComponentStateChanged OnCheckStateChanged
        static CheckBox() {
            StaticClass = Main.GetClass("CheckBox");
        }
        internal unsafe CheckBox_fields* CheckBox_ptr => (CheckBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CheckBox(IntPtr p) => UObject.Make<CheckBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CheckBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CheckBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
