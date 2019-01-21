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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Curve Linear Color</summary>
    public unsafe partial class CurveLinearColor : CurveBase  {

        ///<summary>Get Clamped Linear Color Value</summary>
        public LinearColor GetClampedLinearColorValue(float InTime)  => 
            CurveLinearColor_methods.GetClampedLinearColorValue_method.Invoke(ObjPointer, InTime);

        ///<summary>Get Linear Color Value</summary>
        public LinearColor GetLinearColorValue(float InTime)  => 
            CurveLinearColor_methods.GetLinearColorValue_method.Invoke(ObjPointer, InTime);
        ///<summary>Keyframe data, one curve for red, green, blue, and alpha</summary>
        public unsafe RichCurve FloatCurves {
            get {return CurveLinearColor_ptr->FloatCurves;}
            set {CurveLinearColor_ptr->FloatCurves = value;}
        }
        ///<summary>Properties for adjusting the color of the gradient</summary>
        public unsafe float AdjustHue {
            get {return CurveLinearColor_ptr->AdjustHue;}
            set {CurveLinearColor_ptr->AdjustHue = value;}
        }
        ///<summary>Adjust Saturation</summary>
        public unsafe float AdjustSaturation {
            get {return CurveLinearColor_ptr->AdjustSaturation;}
            set {CurveLinearColor_ptr->AdjustSaturation = value;}
        }
        ///<summary>Adjust Brightness</summary>
        public unsafe float AdjustBrightness {
            get {return CurveLinearColor_ptr->AdjustBrightness;}
            set {CurveLinearColor_ptr->AdjustBrightness = value;}
        }
        ///<summary>Adjust Brightness Curve</summary>
        public unsafe float AdjustBrightnessCurve {
            get {return CurveLinearColor_ptr->AdjustBrightnessCurve;}
            set {CurveLinearColor_ptr->AdjustBrightnessCurve = value;}
        }
        ///<summary>Adjust Vibrance</summary>
        public unsafe float AdjustVibrance {
            get {return CurveLinearColor_ptr->AdjustVibrance;}
            set {CurveLinearColor_ptr->AdjustVibrance = value;}
        }
        ///<summary>Adjust Min Alpha</summary>
        public unsafe float AdjustMinAlpha {
            get {return CurveLinearColor_ptr->AdjustMinAlpha;}
            set {CurveLinearColor_ptr->AdjustMinAlpha = value;}
        }
        ///<summary>Adjust Max Alpha</summary>
        public unsafe float AdjustMaxAlpha {
            get {return CurveLinearColor_ptr->AdjustMaxAlpha;}
            set {CurveLinearColor_ptr->AdjustMaxAlpha = value;}
        }
        static CurveLinearColor() {
            StaticClass = Main.GetClass("CurveLinearColor");
        }
        internal unsafe CurveLinearColor_fields* CurveLinearColor_ptr => (CurveLinearColor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveLinearColor(IntPtr p) => UObject.Make<CurveLinearColor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveLinearColor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveLinearColor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
