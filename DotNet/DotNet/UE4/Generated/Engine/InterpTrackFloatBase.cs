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
    ///<summary>Interp Track Float Base</summary>
    public unsafe partial class InterpTrackFloatBase : InterpTrack  {
        ///<summary>Actually track data containing keyframes of float as it varies over time.</summary>
        public unsafe InterpCurveFloat FloatTrack {
            get {return InterpTrackFloatBase_ptr->FloatTrack;}
            set {InterpTrackFloatBase_ptr->FloatTrack = value;}
        }
        ///<summary>Tension of curve, used for keypoints using automatic tangents.</summary>
        public unsafe float CurveTension {
            get {return InterpTrackFloatBase_ptr->CurveTension;}
            set {InterpTrackFloatBase_ptr->CurveTension = value;}
        }
        static InterpTrackFloatBase() {
            StaticClass = Main.GetClass("InterpTrackFloatBase");
        }
        internal unsafe InterpTrackFloatBase_fields* InterpTrackFloatBase_ptr => (InterpTrackFloatBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackFloatBase(IntPtr p) => UObject.Make<InterpTrackFloatBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackFloatBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackFloatBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
