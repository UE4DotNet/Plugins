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
using UE4.UMG.Native;
using UE4.MovieSceneTracks;

namespace UE4.UMG {
    ///<summary>Handles manipulation of 2D transforms in a movie scene</summary>
    public unsafe partial class MovieScene2DTransformTrack : MovieScenePropertyTrack  {
        static MovieScene2DTransformTrack() {
            StaticClass = Main.GetClass("MovieScene2DTransformTrack");
        }
        internal unsafe MovieScene2DTransformTrack_fields* MovieScene2DTransformTrack_ptr => (MovieScene2DTransformTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieScene2DTransformTrack(IntPtr p) => UObject.Make<MovieScene2DTransformTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieScene2DTransformTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieScene2DTransformTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
