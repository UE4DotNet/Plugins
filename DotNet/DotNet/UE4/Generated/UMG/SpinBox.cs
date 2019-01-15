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
    ///<summary>A numerical entry box that allows for direct entry of the number or allows the user to click and slide the number.</summary>
    public unsafe partial class SpinBox : Widget  {

        ///<summary>Clear the maximum value that can be specified using the slider.</summary>
        public void ClearMaxSliderValue()  => 
            SpinBox_methods.ClearMaxSliderValue_method.Invoke(ObjPointer);

        ///<summary>Clear the maximum value that can be manually set in the spin box.</summary>
        public void ClearMaxValue()  => 
            SpinBox_methods.ClearMaxValue_method.Invoke(ObjPointer);

        ///<summary>Clear the minimum value that can be specified using the slider.</summary>
        public void ClearMinSliderValue()  => 
            SpinBox_methods.ClearMinSliderValue_method.Invoke(ObjPointer);

        ///<summary>Clear the minimum value that can be manually set in the spin box.</summary>
        public void ClearMinValue()  => 
            SpinBox_methods.ClearMinValue_method.Invoke(ObjPointer);

        ///<summary>Get the current maximum value that can be specified using the slider.</summary>
        public float GetMaxSliderValue()  => 
            SpinBox_methods.GetMaxSliderValue_method.Invoke(ObjPointer);

        ///<summary>Get the current maximum value that can be manually set in the spin box.</summary>
        public float GetMaxValue()  => 
            SpinBox_methods.GetMaxValue_method.Invoke(ObjPointer);

        ///<summary>Get the current minimum value that can be specified using the slider.</summary>
        public float GetMinSliderValue()  => 
            SpinBox_methods.GetMinSliderValue_method.Invoke(ObjPointer);

        ///<summary>Get the current minimum value that can be manually set in the spin box.</summary>
        public float GetMinValue()  => 
            SpinBox_methods.GetMinValue_method.Invoke(ObjPointer);

        ///<summary>Get the current value of the spin box.</summary>
        public float GetValue()  => 
            SpinBox_methods.GetValue_method.Invoke(ObjPointer);

        ///<summary>Set Foreground Color</summary>
        public void SetForegroundColor(SlateColor InForegroundColor)  => 
            SpinBox_methods.SetForegroundColor_method.Invoke(ObjPointer, InForegroundColor);

        ///<summary>Set the maximum value that can be specified using the slider.</summary>
        public void SetMaxSliderValue(float NewValue)  => 
            SpinBox_methods.SetMaxSliderValue_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set the maximum value that can be manually set in the spin box.</summary>
        public void SetMaxValue(float NewValue)  => 
            SpinBox_methods.SetMaxValue_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set the minimum value that can be specified using the slider.</summary>
        public void SetMinSliderValue(float NewValue)  => 
            SpinBox_methods.SetMinSliderValue_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set the minimum value that can be manually set in the spin box.</summary>
        public void SetMinValue(float NewValue)  => 
            SpinBox_methods.SetMinValue_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set the value of the spin box.</summary>
        public void SetValue(float NewValue)  => 
            SpinBox_methods.SetValue_method.Invoke(ObjPointer, NewValue);
        ///<summary>Value stored in this spin box</summary>
        public unsafe float Value {
            get {return SpinBox_ptr->Value;}
            set {SpinBox_ptr->Value = value;}
        }
         //TODO: delegate FGetFloat ValueDelegate
        ///<summary>The Style</summary>
        public unsafe SpinBoxStyle WidgetStyle {
            get {return SpinBox_ptr->WidgetStyle;}
            set {SpinBox_ptr->WidgetStyle = value;}
        }
        ///<summary>The amount by which to change the spin box value as the slider moves.</summary>
        public unsafe float Delta {
            get {return SpinBox_ptr->Delta;}
        }
        ///<summary>The exponent by which to increase the delta as the mouse moves. 1 is constant (never increases the delta).</summary>
        public unsafe float SliderExponent {
            get {return SpinBox_ptr->SliderExponent;}
        }
        ///<summary>Font color and opacity (overrides style)</summary>
        public unsafe SlateFontInfo Font {
            get {return SpinBox_ptr->Font;}
        }
        ///<summary>The justification the value text should appear as.</summary>
        public unsafe byte Justification {
            get {return SpinBox_ptr->Justification;}
        }
        ///<summary>The minimum width of the spin box</summary>
        public unsafe float MinDesiredWidth {
            get {return SpinBox_ptr->MinDesiredWidth;}
        }
        public bool ClearKeyboardFocusOnCommit {
            get {return Main.GetGetBoolPropertyByName(this, "ClearKeyboardFocusOnCommit"); }
        }
        public bool SelectAllTextOnCommit {
            get {return Main.GetGetBoolPropertyByName(this, "SelectAllTextOnCommit"); }
        }
        ///<summary>Foreground Color</summary>
        public unsafe SlateColor ForegroundColor {
            get {return SpinBox_ptr->ForegroundColor;}
        }
         //TODO: multicast delegate FOnSpinBoxValueChangedEvent OnValueChanged
         //TODO: multicast delegate FOnSpinBoxValueCommittedEvent OnValueCommitted
         //TODO: multicast delegate FOnSpinBoxBeginSliderMovement OnBeginSliderMovement
         //TODO: multicast delegate FOnSpinBoxValueChangedEvent OnEndSliderMovement
        public bool bOverride_MinValue {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_MinValue"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_MinValue", value); }
        }
        public bool bOverride_MaxValue {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_MaxValue"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_MaxValue", value); }
        }
        public bool bOverride_MinSliderValue {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_MinSliderValue"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_MinSliderValue", value); }
        }
        public bool bOverride_MaxSliderValue {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_MaxSliderValue"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_MaxSliderValue", value); }
        }
        ///<summary>The minimum allowable value that can be manually entered into the spin box</summary>
        public unsafe float MinValue {
            get {return SpinBox_ptr->MinValue;}
            set {SpinBox_ptr->MinValue = value;}
        }
        ///<summary>The maximum allowable value that can be manually entered into the spin box</summary>
        public unsafe float MaxValue {
            get {return SpinBox_ptr->MaxValue;}
            set {SpinBox_ptr->MaxValue = value;}
        }
        ///<summary>The minimum allowable value that can be specified using the slider</summary>
        public unsafe float MinSliderValue {
            get {return SpinBox_ptr->MinSliderValue;}
            set {SpinBox_ptr->MinSliderValue = value;}
        }
        ///<summary>The maximum allowable value that can be specified using the slider</summary>
        public unsafe float MaxSliderValue {
            get {return SpinBox_ptr->MaxSliderValue;}
            set {SpinBox_ptr->MaxSliderValue = value;}
        }
        static SpinBox() {
            StaticClass = Main.GetClass("SpinBox");
        }
        internal unsafe SpinBox_fields* SpinBox_ptr => (SpinBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SpinBox(IntPtr p) => UObject.Make<SpinBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SpinBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SpinBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
