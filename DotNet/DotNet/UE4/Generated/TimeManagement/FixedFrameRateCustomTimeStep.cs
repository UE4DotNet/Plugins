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
using UE4.TimeManagement.Native;
using UE4.Engine;

namespace UE4.TimeManagement {
    ///<summary>Class to control the Engine TimeStep via a FixedFrameRate</summary>
    public unsafe partial class FixedFrameRateCustomTimeStep : EngineCustomTimeStep  {
        ///<summary>The fixed FrameRate</summary>
        public unsafe FrameRate FixedFrameRate {
            get {return FixedFrameRateCustomTimeStep_ptr->FixedFrameRate;}
            set {FixedFrameRateCustomTimeStep_ptr->FixedFrameRate = value;}
        }
        static FixedFrameRateCustomTimeStep() {
            StaticClass = Main.GetClass("FixedFrameRateCustomTimeStep");
        }
        internal unsafe FixedFrameRateCustomTimeStep_fields* FixedFrameRateCustomTimeStep_ptr => (FixedFrameRateCustomTimeStep_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FixedFrameRateCustomTimeStep(IntPtr p) => UObject.Make<FixedFrameRateCustomTimeStep>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FixedFrameRateCustomTimeStep DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FixedFrameRateCustomTimeStep New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
