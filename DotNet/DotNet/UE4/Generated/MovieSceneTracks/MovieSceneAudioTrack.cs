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
    ///<summary>Handles manipulation of audio.</summary>
    public unsafe partial class MovieSceneAudioTrack : MovieSceneNameableTrack  {
        ///<summary>List of all master audio sections</summary>
        public ObjectArrayField<MovieSceneSection> AudioSections{ get {
            if(AudioSections_store == null) AudioSections_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneAudioTrack_ptr->AudioSections);
            return AudioSections_store;
        } }
        private ObjectArrayField<MovieSceneSection> AudioSections_store;

        ///<summary>The height for each row of this track</summary>
        public unsafe int RowHeight {
            get {return MovieSceneAudioTrack_ptr->RowHeight;}
            set {MovieSceneAudioTrack_ptr->RowHeight = value;}
        }
        static MovieSceneAudioTrack() {
            StaticClass = Main.GetClass("MovieSceneAudioTrack");
        }
        internal unsafe MovieSceneAudioTrack_fields* MovieSceneAudioTrack_ptr => (MovieSceneAudioTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneAudioTrack(IntPtr p) => UObject.Make<MovieSceneAudioTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneAudioTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneAudioTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
