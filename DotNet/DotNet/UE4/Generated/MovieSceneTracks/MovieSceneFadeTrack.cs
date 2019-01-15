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
    ///<summary>Implements a movie scene track that controls a fade.</summary>
    public unsafe partial class MovieSceneFadeTrack : MovieSceneFloatTrack  {
        static MovieSceneFadeTrack() {
            StaticClass = Main.GetClass("MovieSceneFadeTrack");
        }
        internal unsafe MovieSceneFadeTrack_fields* MovieSceneFadeTrack_ptr => (MovieSceneFadeTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneFadeTrack(IntPtr p) => UObject.Make<MovieSceneFadeTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneFadeTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneFadeTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
