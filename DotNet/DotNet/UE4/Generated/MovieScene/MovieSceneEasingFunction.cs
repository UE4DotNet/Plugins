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

namespace UE4.MovieScene {
    ///<summary>Movie Scene Easing Function</summary>
    public unsafe partial class MovieSceneEasingFunction : Interface  {

        ///<summary>Evaluate the easing with an interpolation value between 0 and 1</summary>
        public event OnEvaluate_delegate OnEvaluate;
        public delegate float OnEvaluate_delegate(float Interp, float ReturnValue);
        internal float on_OnEvaluate(float Interp, float ReturnValue) =>
            OnEvaluate != null ? OnEvaluate(Interp, ReturnValue) : ReturnValue;

        static MovieSceneEasingFunction() {
            StaticClass = Main.GetClass("MovieSceneEasingFunction");
            MovieSceneEasingFunction_events.OnEvaluate_event.Setup();
        }
        internal unsafe MovieSceneEasingFunction_fields* MovieSceneEasingFunction_ptr => (MovieSceneEasingFunction_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneEasingFunction(IntPtr p) => UObject.Make<MovieSceneEasingFunction>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneEasingFunction DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneEasingFunction New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
