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
    ///<summary>The progress bar widget is a simple bar that fills up that can be restyled to fit any number of uses.</summary>
    ///<remarks>* No Children</remarks>
    public unsafe partial class ProgressBar : Widget  {

        ///<summary>Sets the fill color of the progress bar.</summary>
        public void SetFillColorAndOpacity(LinearColor InColor)  => 
            ProgressBar_methods.SetFillColorAndOpacity_method.Invoke(ObjPointer, InColor);

        ///<summary>Sets the progress bar to show as a marquee.</summary>
        public void SetIsMarquee(bool InbIsMarquee)  => 
            ProgressBar_methods.SetIsMarquee_method.Invoke(ObjPointer, InbIsMarquee);

        ///<summary>Sets the current value of the ProgressBar.</summary>
        public void SetPercent(float InPercent)  => 
            ProgressBar_methods.SetPercent_method.Invoke(ObjPointer, InPercent);
        ///<summary>The progress bar style</summary>
        public unsafe ProgressBarStyle WidgetStyle {
            get {return ProgressBar_ptr->WidgetStyle;}
            set {ProgressBar_ptr->WidgetStyle = value;}
        }
        ///<summary>Used to determine the fill position of the progress bar ranging 0..1</summary>
        public unsafe float Percent {
            get {return ProgressBar_ptr->Percent;}
        }
        ///<summary>Defines if this progress bar fills Left to right or right to left</summary>
        public unsafe byte BarFillType {
            get {return ProgressBar_ptr->BarFillType;}
        }
        public bool bIsMarquee {
            get {return Main.GetGetBoolPropertyByName(this, "bIsMarquee"); }
        }
        ///<summary>Border Padding</summary>
        public unsafe Vector2D BorderPadding {
            get {return ProgressBar_ptr->BorderPadding;}
        }
         //TODO: delegate FGetFloat PercentDelegate
        ///<summary>Fill Color and Opacity</summary>
        public unsafe LinearColor FillColorAndOpacity {
            get {return ProgressBar_ptr->FillColorAndOpacity;}
        }
         //TODO: delegate FGetLinearColor FillColorAndOpacityDelegate
        static ProgressBar() {
            StaticClass = Main.GetClass("ProgressBar");
        }
        internal unsafe ProgressBar_fields* ProgressBar_ptr => (ProgressBar_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProgressBar(IntPtr p) => UObject.Make<ProgressBar>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProgressBar DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProgressBar New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
