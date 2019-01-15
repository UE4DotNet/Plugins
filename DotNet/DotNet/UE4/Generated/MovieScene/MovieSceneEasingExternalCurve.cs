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
using UE4.MovieScene.Native;
using UE4.Engine;

namespace UE4.MovieScene {
    ///<summary>Movie Scene Easing External Curve</summary>
    public unsafe partial class MovieSceneEasingExternalCurve : UObject  {
        ///<summary>Curve data</summary>
        public unsafe CurveFloat Curve {
            get {return MovieSceneEasingExternalCurve_ptr->Curve;}
            set {MovieSceneEasingExternalCurve_ptr->Curve = value;}
        }
        static MovieSceneEasingExternalCurve() {
            StaticClass = Main.GetClass("MovieSceneEasingExternalCurve");
        }
        internal unsafe MovieSceneEasingExternalCurve_fields* MovieSceneEasingExternalCurve_ptr => (MovieSceneEasingExternalCurve_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneEasingExternalCurve(IntPtr p) => UObject.Make<MovieSceneEasingExternalCurve>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneEasingExternalCurve DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneEasingExternalCurve New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
