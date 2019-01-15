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
    ///<summary>Base class for tracks that animate an object property</summary>
    public unsafe partial class MovieScenePropertyTrack : MovieSceneNameableTrack  {
        ///<summary>Unique name for this track to afford multiple tracks on a given object (i.e. for array properties)</summary>
        public unsafe Name UniqueTrackName {
            get {return MovieScenePropertyTrack_ptr->UniqueTrackName;}
            set {MovieScenePropertyTrack_ptr->UniqueTrackName = value;}
        }
        ///<summary>Name of the property being changed</summary>
        public unsafe Name PropertyName {
            get {return MovieScenePropertyTrack_ptr->PropertyName;}
            set {MovieScenePropertyTrack_ptr->PropertyName = value;}
        }
         //TODO: string FString PropertyPath
        ///<summary>All the sections in this list</summary>
        public ObjectArrayField<MovieSceneSection> Sections{ get {
            if(Sections_store == null) Sections_store = new ObjectArrayField<MovieSceneSection> (&MovieScenePropertyTrack_ptr->Sections);
            return Sections_store;
        } }
        private ObjectArrayField<MovieSceneSection> Sections_store;

        static MovieScenePropertyTrack() {
            StaticClass = Main.GetClass("MovieScenePropertyTrack");
        }
        internal unsafe MovieScenePropertyTrack_fields* MovieScenePropertyTrack_ptr => (MovieScenePropertyTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieScenePropertyTrack(IntPtr p) => UObject.Make<MovieScenePropertyTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieScenePropertyTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieScenePropertyTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
