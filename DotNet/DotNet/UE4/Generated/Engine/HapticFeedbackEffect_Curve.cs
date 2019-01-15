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
    ///<summary>Haptic Feedback Effect Curve</summary>
    public unsafe partial class HapticFeedbackEffect_Curve : HapticFeedbackEffect_Base  {
        ///<summary>Haptic Details</summary>
        public unsafe HapticFeedbackDetails_Curve HapticDetails {
            get {return HapticFeedbackEffect_Curve_ptr->HapticDetails;}
            set {HapticFeedbackEffect_Curve_ptr->HapticDetails = value;}
        }
        static HapticFeedbackEffect_Curve() {
            StaticClass = Main.GetClass("HapticFeedbackEffect_Curve");
        }
        internal unsafe HapticFeedbackEffect_Curve_fields* HapticFeedbackEffect_Curve_ptr => (HapticFeedbackEffect_Curve_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HapticFeedbackEffect_Curve(IntPtr p) => UObject.Make<HapticFeedbackEffect_Curve>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HapticFeedbackEffect_Curve DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HapticFeedbackEffect_Curve New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
