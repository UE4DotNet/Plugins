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
    ///<summary>A track for controlling the visibility of streamed levels.</summary>
    public unsafe partial class MovieSceneLevelVisibilityTrack : MovieSceneNameableTrack  {
        ///<summary>Sections</summary>
        public ObjectArrayField<MovieSceneSection> Sections{ get {
            if(Sections_store == null) Sections_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneLevelVisibilityTrack_ptr->Sections);
            return Sections_store;
        } }
        private ObjectArrayField<MovieSceneSection> Sections_store;

        static MovieSceneLevelVisibilityTrack() {
            StaticClass = Main.GetClass("MovieSceneLevelVisibilityTrack");
        }
        internal unsafe MovieSceneLevelVisibilityTrack_fields* MovieSceneLevelVisibilityTrack_ptr => (MovieSceneLevelVisibilityTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneLevelVisibilityTrack(IntPtr p) => UObject.Make<MovieSceneLevelVisibilityTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneLevelVisibilityTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneLevelVisibilityTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
