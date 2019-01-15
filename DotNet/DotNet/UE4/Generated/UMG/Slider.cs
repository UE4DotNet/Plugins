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
    ///<summary>A simple widget that shows a sliding bar with a handle that allows you to control the value between 0.</summary>
    ///<remarks>
    ///.1.
    ///
    ///* No Children
    ///</remarks>
    public unsafe partial class Slider : Widget  {

        ///<summary>Gets the current value of the slider.</summary>
        public float GetValue()  => 
            Slider_methods.GetValue_method.Invoke(ObjPointer);

        ///<summary>Sets if the slidable area should be indented to fit the handle</summary>
        public void SetIndentHandle(bool InValue)  => 
            Slider_methods.SetIndentHandle_method.Invoke(ObjPointer, InValue);

        ///<summary>Sets the handle to be interactive or fixed</summary>
        public void SetLocked(bool InValue)  => 
            Slider_methods.SetLocked_method.Invoke(ObjPointer, InValue);

        ///<summary>Sets the color of the slider bar</summary>
        public void SetSliderBarColor(LinearColor InValue)  => 
            Slider_methods.SetSliderBarColor_method.Invoke(ObjPointer, InValue);

        ///<summary>Sets the color of the handle bar</summary>
        public void SetSliderHandleColor(LinearColor InValue)  => 
            Slider_methods.SetSliderHandleColor_method.Invoke(ObjPointer, InValue);

        ///<summary>Sets the amount to adjust the value by, when using a controller or keyboard</summary>
        public void SetStepSize(float InValue)  => 
            Slider_methods.SetStepSize_method.Invoke(ObjPointer, InValue);

        ///<summary>Sets the current value of the slider.</summary>
        public void SetValue(float InValue)  => 
            Slider_methods.SetValue_method.Invoke(ObjPointer, InValue);
        ///<summary>The volume value to display.</summary>
        public unsafe float Value {
            get {return Slider_ptr->Value;}
            set {Slider_ptr->Value = value;}
        }
         //TODO: delegate FGetFloat ValueDelegate
        ///<summary>The progress bar style</summary>
        public unsafe SliderStyle WidgetStyle {
            get {return Slider_ptr->WidgetStyle;}
            set {Slider_ptr->WidgetStyle = value;}
        }
        ///<summary>The slider's orientation.</summary>
        public unsafe byte Orientation {
            get {return Slider_ptr->Orientation;}
        }
        ///<summary>The color to draw the slider bar in.</summary>
        public unsafe LinearColor SliderBarColor {
            get {return Slider_ptr->SliderBarColor;}
        }
        ///<summary>The color to draw the slider handle in.</summary>
        public unsafe LinearColor SliderHandleColor {
            get {return Slider_ptr->SliderHandleColor;}
        }
        public bool IndentHandle {
            get {return Main.GetGetBoolPropertyByName(this, "IndentHandle"); }
        }
        public bool Locked {
            get {return Main.GetGetBoolPropertyByName(this, "Locked"); }
        }
        ///<summary>The amount to adjust the value by, when using a controller or keyboard</summary>
        public unsafe float StepSize {
            get {return Slider_ptr->StepSize;}
        }
        public bool IsFocusable {
            get {return Main.GetGetBoolPropertyByName(this, "IsFocusable"); }
        }
         //TODO: multicast delegate FOnMouseCaptureBeginEvent OnMouseCaptureBegin
         //TODO: multicast delegate FOnMouseCaptureEndEvent OnMouseCaptureEnd
         //TODO: multicast delegate FOnControllerCaptureBeginEvent OnControllerCaptureBegin
         //TODO: multicast delegate FOnControllerCaptureEndEvent OnControllerCaptureEnd
         //TODO: multicast delegate FOnFloatValueChangedEvent OnValueChanged
        static Slider() {
            StaticClass = Main.GetClass("Slider");
        }
        internal unsafe Slider_fields* Slider_ptr => (Slider_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Slider(IntPtr p) => UObject.Make<Slider>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Slider DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Slider New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
