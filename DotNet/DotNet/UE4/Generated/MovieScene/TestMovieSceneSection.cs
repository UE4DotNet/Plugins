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
    ///<summary>Test Movie Scene Section</summary>
    public unsafe partial class TestMovieSceneSection : MovieSceneSection  {
        static TestMovieSceneSection() {
            StaticClass = Main.GetClass("TestMovieSceneSection");
        }
        internal unsafe TestMovieSceneSection_fields* TestMovieSceneSection_ptr => (TestMovieSceneSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TestMovieSceneSection(IntPtr p) => UObject.Make<TestMovieSceneSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TestMovieSceneSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TestMovieSceneSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
