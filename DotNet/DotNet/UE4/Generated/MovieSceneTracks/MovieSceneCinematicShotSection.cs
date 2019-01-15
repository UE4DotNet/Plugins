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
    ///<summary>Implements a cinematic shot section.</summary>
    public unsafe partial class MovieSceneCinematicShotSection : MovieSceneSubSection  {
         //TODO: string FString ShotDisplayName
        ///<summary>The shot's reference frame offset for single thumbnail rendering</summary>
        public unsafe float ThumbnailReferenceOffset {
            get {return MovieSceneCinematicShotSection_ptr->ThumbnailReferenceOffset;}
            set {MovieSceneCinematicShotSection_ptr->ThumbnailReferenceOffset = value;}
        }
        static MovieSceneCinematicShotSection() {
            StaticClass = Main.GetClass("MovieSceneCinematicShotSection");
        }
        internal unsafe MovieSceneCinematicShotSection_fields* MovieSceneCinematicShotSection_ptr => (MovieSceneCinematicShotSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCinematicShotSection(IntPtr p) => UObject.Make<MovieSceneCinematicShotSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCinematicShotSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCinematicShotSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
