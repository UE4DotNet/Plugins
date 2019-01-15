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
using UE4.MovieScene;

namespace UE4.MovieSceneTracks {
    ///<summary>A track that holds consecutive sub sequences.</summary>
    public unsafe partial class MovieSceneCinematicShotTrack : MovieSceneSubTrack  {
        static MovieSceneCinematicShotTrack() {
            StaticClass = Main.GetClass("MovieSceneCinematicShotTrack");
        }
        internal unsafe MovieSceneCinematicShotTrack_fields* MovieSceneCinematicShotTrack_ptr => (MovieSceneCinematicShotTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCinematicShotTrack(IntPtr p) => UObject.Make<MovieSceneCinematicShotTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCinematicShotTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCinematicShotTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
