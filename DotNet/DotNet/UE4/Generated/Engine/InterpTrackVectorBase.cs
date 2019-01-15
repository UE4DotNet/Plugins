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
    ///<summary>Interp Track Vector Base</summary>
    public unsafe partial class InterpTrackVectorBase : InterpTrack  {
        ///<summary>Actually track data containing keyframes of a FVector as it varies over time.</summary>
        public unsafe InterpCurveVector VectorTrack {
            get {return InterpTrackVectorBase_ptr->VectorTrack;}
            set {InterpTrackVectorBase_ptr->VectorTrack = value;}
        }
        ///<summary>Tension of curve, used for keypoints using automatic tangents.</summary>
        public unsafe float CurveTension {
            get {return InterpTrackVectorBase_ptr->CurveTension;}
            set {InterpTrackVectorBase_ptr->CurveTension = value;}
        }
        static InterpTrackVectorBase() {
            StaticClass = Main.GetClass("InterpTrackVectorBase");
        }
        internal unsafe InterpTrackVectorBase_fields* InterpTrackVectorBase_ptr => (InterpTrackVectorBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackVectorBase(IntPtr p) => UObject.Make<InterpTrackVectorBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackVectorBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackVectorBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
