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
using UE4.GeometryCacheTracks.Native;
using UE4.MovieScene;

namespace UE4.GeometryCacheTracks {
    ///<summary>Movie Scene Geometry Cache Track</summary>
    public unsafe partial class MovieSceneGeometryCacheTrack : MovieSceneNameableTrack  {
        ///<summary>List of all animation sections</summary>
        public ObjectArrayField<MovieSceneSection> AnimationSections{ get {
            if(AnimationSections_store == null) AnimationSections_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneGeometryCacheTrack_ptr->AnimationSections);
            return AnimationSections_store;
        } }
        private ObjectArrayField<MovieSceneSection> AnimationSections_store;

        static MovieSceneGeometryCacheTrack() {
            StaticClass = Main.GetClass("MovieSceneGeometryCacheTrack");
        }
        internal unsafe MovieSceneGeometryCacheTrack_fields* MovieSceneGeometryCacheTrack_ptr => (MovieSceneGeometryCacheTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneGeometryCacheTrack(IntPtr p) => UObject.Make<MovieSceneGeometryCacheTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneGeometryCacheTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneGeometryCacheTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
