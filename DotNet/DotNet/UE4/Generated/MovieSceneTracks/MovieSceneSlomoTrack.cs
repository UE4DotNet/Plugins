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
    ///<summary>Implements a movie scene track that controls a movie scene's playback speed.</summary>
    public unsafe partial class MovieSceneSlomoTrack : MovieSceneFloatTrack  {
        static MovieSceneSlomoTrack() {
            StaticClass = Main.GetClass("MovieSceneSlomoTrack");
        }
        internal unsafe MovieSceneSlomoTrack_fields* MovieSceneSlomoTrack_ptr => (MovieSceneSlomoTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSlomoTrack(IntPtr p) => UObject.Make<MovieSceneSlomoTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSlomoTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSlomoTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
