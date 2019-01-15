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
    ///<summary>Movie Scene Camera Anim Track</summary>
    public unsafe partial class MovieSceneCameraAnimTrack : MovieSceneNameableTrack  {
        ///<summary>List of all sections</summary>
        public ObjectArrayField<MovieSceneSection> CameraAnimSections{ get {
            if(CameraAnimSections_store == null) CameraAnimSections_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneCameraAnimTrack_ptr->CameraAnimSections);
            return CameraAnimSections_store;
        } }
        private ObjectArrayField<MovieSceneSection> CameraAnimSections_store;

        static MovieSceneCameraAnimTrack() {
            StaticClass = Main.GetClass("MovieSceneCameraAnimTrack");
        }
        internal unsafe MovieSceneCameraAnimTrack_fields* MovieSceneCameraAnimTrack_ptr => (MovieSceneCameraAnimTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCameraAnimTrack(IntPtr p) => UObject.Make<MovieSceneCameraAnimTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCameraAnimTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCameraAnimTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
