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
    ///<summary>Haptic Feedback Effect Sound Wave</summary>
    public unsafe partial class HapticFeedbackEffect_SoundWave : HapticFeedbackEffect_Base  {
        ///<summary>Sound Wave</summary>
        public unsafe SoundWave SoundWave {
            get {return HapticFeedbackEffect_SoundWave_ptr->SoundWave;}
            set {HapticFeedbackEffect_SoundWave_ptr->SoundWave = value;}
        }
        static HapticFeedbackEffect_SoundWave() {
            StaticClass = Main.GetClass("HapticFeedbackEffect_SoundWave");
        }
        internal unsafe HapticFeedbackEffect_SoundWave_fields* HapticFeedbackEffect_SoundWave_ptr => (HapticFeedbackEffect_SoundWave_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HapticFeedbackEffect_SoundWave(IntPtr p) => UObject.Make<HapticFeedbackEffect_SoundWave>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HapticFeedbackEffect_SoundWave DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HapticFeedbackEffect_SoundWave New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
