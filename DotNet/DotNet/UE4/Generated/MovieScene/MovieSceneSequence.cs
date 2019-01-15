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
    ///<summary>Abstract base class for movie scene animations (C++ version).</summary>
    public unsafe partial class MovieSceneSequence : MovieSceneSignedObject  {
        ///<summary>Precompiled Evaluation Template</summary>
        public unsafe MovieSceneEvaluationTemplate PrecompiledEvaluationTemplate {
            get {return MovieSceneSequence_ptr->PrecompiledEvaluationTemplate;}
            set {MovieSceneSequence_ptr->PrecompiledEvaluationTemplate = value;}
        }
         //TODO: enum EMovieSceneCompletionMode DefaultCompletionMode
        public bool bParentContextsAreSignificant {
            get {return Main.GetGetBoolPropertyByName(this, "bParentContextsAreSignificant"); }
            set {Main.SetGetBoolPropertyByName(this, "bParentContextsAreSignificant", value); }
        }
        static MovieSceneSequence() {
            StaticClass = Main.GetClass("MovieSceneSequence");
        }
        internal unsafe MovieSceneSequence_fields* MovieSceneSequence_ptr => (MovieSceneSequence_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSequence(IntPtr p) => UObject.Make<MovieSceneSequence>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSequence DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSequence New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
