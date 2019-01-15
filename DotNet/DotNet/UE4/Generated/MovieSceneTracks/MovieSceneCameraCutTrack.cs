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
    ///<summary>Handles manipulation of CameraCut properties in a movie scene.</summary>
    public unsafe partial class MovieSceneCameraCutTrack : MovieSceneNameableTrack  {
        ///<summary>All movie scene sections.</summary>
        public ObjectArrayField<MovieSceneSection> Sections{ get {
            if(Sections_store == null) Sections_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneCameraCutTrack_ptr->Sections);
            return Sections_store;
        } }
        private ObjectArrayField<MovieSceneSection> Sections_store;

        static MovieSceneCameraCutTrack() {
            StaticClass = Main.GetClass("MovieSceneCameraCutTrack");
        }
        internal unsafe MovieSceneCameraCutTrack_fields* MovieSceneCameraCutTrack_ptr => (MovieSceneCameraCutTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCameraCutTrack(IntPtr p) => UObject.Make<MovieSceneCameraCutTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCameraCutTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCameraCutTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
