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
    ///<summary>Handles when a spawnable should be spawned and destroyed</summary>
    public unsafe partial class MovieSceneSpawnTrack : MovieSceneTrack  {
        ///<summary>All the sections in this track</summary>
        public ObjectArrayField<MovieSceneSection> Sections{ get {
            if(Sections_store == null) Sections_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneSpawnTrack_ptr->Sections);
            return Sections_store;
        } }
        private ObjectArrayField<MovieSceneSection> Sections_store;

        ///<summary>The guid relating to the object we are to spawn and destroy</summary>
        public unsafe FGuid ObjectGuid {
            get {return MovieSceneSpawnTrack_ptr->ObjectGuid;}
            set {MovieSceneSpawnTrack_ptr->ObjectGuid = value;}
        }
        static MovieSceneSpawnTrack() {
            StaticClass = Main.GetClass("MovieSceneSpawnTrack");
        }
        internal unsafe MovieSceneSpawnTrack_fields* MovieSceneSpawnTrack_ptr => (MovieSceneSpawnTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSpawnTrack(IntPtr p) => UObject.Make<MovieSceneSpawnTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSpawnTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSpawnTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
