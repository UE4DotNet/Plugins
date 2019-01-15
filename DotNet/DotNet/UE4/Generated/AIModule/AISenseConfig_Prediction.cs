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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>AISense Config Prediction</summary>
    public unsafe partial class AISenseConfig_Prediction : AISenseConfig  {
        static AISenseConfig_Prediction() {
            StaticClass = Main.GetClass("AISenseConfig_Prediction");
        }
        internal unsafe AISenseConfig_Prediction_fields* AISenseConfig_Prediction_ptr => (AISenseConfig_Prediction_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISenseConfig_Prediction(IntPtr p) => UObject.Make<AISenseConfig_Prediction>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISenseConfig_Prediction DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISenseConfig_Prediction New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
