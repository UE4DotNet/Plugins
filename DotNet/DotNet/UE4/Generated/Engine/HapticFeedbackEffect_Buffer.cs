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
    ///<summary>Haptic Feedback Effect Buffer</summary>
    public unsafe partial class HapticFeedbackEffect_Buffer : HapticFeedbackEffect_Base  {
         //TODO: array not UObject TArray Amplitudes
        ///<summary>Sample Rate</summary>
        public unsafe int SampleRate {
            get {return HapticFeedbackEffect_Buffer_ptr->SampleRate;}
            set {HapticFeedbackEffect_Buffer_ptr->SampleRate = value;}
        }
        static HapticFeedbackEffect_Buffer() {
            StaticClass = Main.GetClass("HapticFeedbackEffect_Buffer");
        }
        internal unsafe HapticFeedbackEffect_Buffer_fields* HapticFeedbackEffect_Buffer_ptr => (HapticFeedbackEffect_Buffer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HapticFeedbackEffect_Buffer(IntPtr p) => UObject.Make<HapticFeedbackEffect_Buffer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HapticFeedbackEffect_Buffer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HapticFeedbackEffect_Buffer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
