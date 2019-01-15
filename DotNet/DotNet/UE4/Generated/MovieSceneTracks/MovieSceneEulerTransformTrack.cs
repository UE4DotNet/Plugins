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
using UE4.MovieSceneTracks.Native;

namespace UE4.MovieSceneTracks {
    ///<summary>Handles manipulation of 3D euler transform properties in a movie scene</summary>
    public unsafe partial class MovieSceneEulerTransformTrack : MovieScenePropertyTrack  {
        static MovieSceneEulerTransformTrack() {
            StaticClass = Main.GetClass("MovieSceneEulerTransformTrack");
        }
        internal unsafe MovieSceneEulerTransformTrack_fields* MovieSceneEulerTransformTrack_ptr => (MovieSceneEulerTransformTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneEulerTransformTrack(IntPtr p) => UObject.Make<MovieSceneEulerTransformTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneEulerTransformTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneEulerTransformTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
