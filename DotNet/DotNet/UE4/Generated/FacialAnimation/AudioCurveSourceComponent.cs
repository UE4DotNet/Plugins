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
using UE4.FacialAnimation.Native;
using UE4.Engine;

namespace UE4.FacialAnimation {
    ///<summary>An audio component that also provides curves to drive animation</summary>
    public unsafe partial class AudioCurveSourceComponent : AudioComponent  {
        ///<summary>Get the name that this curve source can be bound to by.</summary>
        ///<remarks>Clients of this curve source will use this name to identify this source.</remarks>
        public unsafe Name CurveSourceBindingName {
            get {return AudioCurveSourceComponent_ptr->CurveSourceBindingName;}
            set {AudioCurveSourceComponent_ptr->CurveSourceBindingName = value;}
        }
        ///<summary>Offset in time applied to audio position when evaluating curves</summary>
        public unsafe float CurveSyncOffset {
            get {return AudioCurveSourceComponent_ptr->CurveSyncOffset;}
            set {AudioCurveSourceComponent_ptr->CurveSyncOffset = value;}
        }
        static AudioCurveSourceComponent() {
            StaticClass = Main.GetClass("AudioCurveSourceComponent");
        }
        internal unsafe AudioCurveSourceComponent_fields* AudioCurveSourceComponent_ptr => (AudioCurveSourceComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AudioCurveSourceComponent(IntPtr p) => UObject.Make<AudioCurveSourceComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AudioCurveSourceComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AudioCurveSourceComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
