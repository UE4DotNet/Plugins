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
using UE4.MediaCompositing.Native;
using UE4.MovieScene;

namespace UE4.MediaCompositing {
    ///<summary>Implements a movie scene track for media playback.</summary>
    public unsafe partial class MovieSceneMediaTrack : MovieSceneNameableTrack  {
        ///<summary>List of all master media sections.</summary>
        public ObjectArrayField<MovieSceneSection> MediaSections{ get {
            if(MediaSections_store == null) MediaSections_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneMediaTrack_ptr->MediaSections);
            return MediaSections_store;
        } }
        private ObjectArrayField<MovieSceneSection> MediaSections_store;

        static MovieSceneMediaTrack() {
            StaticClass = Main.GetClass("MovieSceneMediaTrack");
        }
        internal unsafe MovieSceneMediaTrack_fields* MovieSceneMediaTrack_ptr => (MovieSceneMediaTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneMediaTrack(IntPtr p) => UObject.Make<MovieSceneMediaTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneMediaTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneMediaTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
