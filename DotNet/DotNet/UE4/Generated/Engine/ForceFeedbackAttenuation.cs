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
    ///<summary>Wrapper class that can be created as an asset for force feedback attenuation properties which allows reuse</summary>
    ///<remarks>of the properties for multiple attenuation components</remarks>
    public unsafe partial class ForceFeedbackAttenuation : UObject  {
        ///<summary>Attenuation</summary>
        public unsafe ForceFeedbackAttenuationSettings Attenuation {
            get {return ForceFeedbackAttenuation_ptr->Attenuation;}
        }
        static ForceFeedbackAttenuation() {
            StaticClass = Main.GetClass("ForceFeedbackAttenuation");
        }
        internal unsafe ForceFeedbackAttenuation_fields* ForceFeedbackAttenuation_ptr => (ForceFeedbackAttenuation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ForceFeedbackAttenuation(IntPtr p) => UObject.Make<ForceFeedbackAttenuation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ForceFeedbackAttenuation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ForceFeedbackAttenuation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
