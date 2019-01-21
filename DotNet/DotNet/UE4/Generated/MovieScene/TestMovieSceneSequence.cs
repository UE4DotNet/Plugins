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
    ///<summary>Test Movie Scene Sequence</summary>
    public unsafe partial class TestMovieSceneSequence : MovieSceneSequence  {
        ///<summary>Movie Scene</summary>
        public unsafe UMovieScene UMovieScene {
            get {return TestMovieSceneSequence_ptr->UMovieScene;}
            set {TestMovieSceneSequence_ptr->UMovieScene = value;}
        }
        static TestMovieSceneSequence() {
            StaticClass = Main.GetClass("TestMovieSceneSequence");
        }
        internal unsafe TestMovieSceneSequence_fields* TestMovieSceneSequence_ptr => (TestMovieSceneSequence_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TestMovieSceneSequence(IntPtr p) => UObject.Make<TestMovieSceneSequence>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TestMovieSceneSequence DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TestMovieSceneSequence New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
