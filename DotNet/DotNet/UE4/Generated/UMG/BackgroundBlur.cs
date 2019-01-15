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
    ///A background blur is a container widget that can contain one child widget, providing an opportunity
    ///to surround it with adjustable padding and apply a post-process Gaussian blur to all content beneath the widget.
    ///</summary>
    ///<remarks>
    ///* Single Child
    ///* Blur Effect
    ///</remarks>
    public unsafe partial class BackgroundBlur : ContentWidget  {

        ///<summary>Set Apply Alpha to Blur</summary>
        public void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur)  => 
            BackgroundBlur_methods.SetApplyAlphaToBlur_method.Invoke(ObjPointer, bInApplyAlphaToBlur);

        ///<summary>Set Blur Radius</summary>
        public void SetBlurRadius(int InBlurRadius)  => 
            BackgroundBlur_methods.SetBlurRadius_method.Invoke(ObjPointer, InBlurRadius);

        ///<summary>Set Blur Strength</summary>
        public void SetBlurStrength(float InStrength)  => 
            BackgroundBlur_methods.SetBlurStrength_method.Invoke(ObjPointer, InStrength);

        ///<summary>Set Horizontal Alignment</summary>
        public void SetHorizontalAlignment(byte InHorizontalAlignment)  => 
            BackgroundBlur_methods.SetHorizontalAlignment_method.Invoke(ObjPointer, InHorizontalAlignment);

        ///<summary>Set Low Quality Fallback Brush</summary>
        public void SetLowQualityFallbackBrush(SlateBrush InBrush)  => 
            BackgroundBlur_methods.SetLowQualityFallbackBrush_method.Invoke(ObjPointer, InBrush);

        ///<summary>Set Padding</summary>
        public void SetPadding(Margin InPadding)  => 
            BackgroundBlur_methods.SetPadding_method.Invoke(ObjPointer, InPadding);

        ///<summary>Set Vertical Alignment</summary>
        public void SetVerticalAlignment(byte InVerticalAlignment)  => 
            BackgroundBlur_methods.SetVerticalAlignment_method.Invoke(ObjPointer, InVerticalAlignment);
        ///<summary>The padding area between the slot and the content it contains.</summary>
        public unsafe Margin Padding {
            get {return BackgroundBlur_ptr->Padding;}
        }
        ///<summary>The alignment of the content horizontally.</summary>
        public unsafe byte HorizontalAlignment {
            get {return BackgroundBlur_ptr->HorizontalAlignment;}
        }
        ///<summary>The alignment of the content vertically.</summary>
        public unsafe byte VerticalAlignment {
            get {return BackgroundBlur_ptr->VerticalAlignment;}
        }
        public bool bApplyAlphaToBlur {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyAlphaToBlur"); }
        }
        ///<summary>How blurry the background is.  Larger numbers mean more blurry but will result in larger runtime cost on the gpu.</summary>
        public unsafe float BlurStrength {
            get {return BackgroundBlur_ptr->BlurStrength;}
        }
        public bool bOverrideAutoRadiusCalculation {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideAutoRadiusCalculation"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideAutoRadiusCalculation", value); }
        }
        ///<summary>
        ///This is the number of pixels which will be weighted in each direction from any given pixel when computing the blur
        ///A larger value is more costly but allows for stronger blurs.
        ///</summary>
        public unsafe int BlurRadius {
            get {return BackgroundBlur_ptr->BlurRadius;}
        }
        ///<summary>An image to draw instead of applying a blur when low quality override mode is enabled.</summary>
        ///<remarks>
        ///You can enable low quality mode for background blurs by setting the cvar Slate.ForceBackgroundBlurLowQualityOverride to 1.
        ///This is usually done in the project's scalability settings
        ///</remarks>
        public unsafe SlateBrush LowQualityFallbackBrush {
            get {return BackgroundBlur_ptr->LowQualityFallbackBrush;}
        }
        static BackgroundBlur() {
            StaticClass = Main.GetClass("BackgroundBlur");
        }
        internal unsafe BackgroundBlur_fields* BackgroundBlur_ptr => (BackgroundBlur_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BackgroundBlur(IntPtr p) => UObject.Make<BackgroundBlur>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BackgroundBlur DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BackgroundBlur New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
