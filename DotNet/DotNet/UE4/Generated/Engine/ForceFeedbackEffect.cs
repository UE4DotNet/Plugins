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
    ///<summary>A predefined force-feedback effect to be played on a controller</summary>
    public unsafe partial class ForceFeedbackEffect : UObject  {
         //TODO: array not UObject TArray ChannelDetails
        ///<summary>Duration of force feedback pattern in seconds.</summary>
        public unsafe float Duration {
            get {return ForceFeedbackEffect_ptr->Duration;}
        }
        static ForceFeedbackEffect() {
            StaticClass = Main.GetClass("ForceFeedbackEffect");
        }
        internal unsafe ForceFeedbackEffect_fields* ForceFeedbackEffect_ptr => (ForceFeedbackEffect_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ForceFeedbackEffect(IntPtr p) => UObject.Make<ForceFeedbackEffect>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ForceFeedbackEffect DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ForceFeedbackEffect New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
