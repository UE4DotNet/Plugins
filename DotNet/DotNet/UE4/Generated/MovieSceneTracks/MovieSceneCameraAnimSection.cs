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
    ///<summary>Movie Scene Camera Anim Section</summary>
    public unsafe partial class MovieSceneCameraAnimSection : MovieSceneSection  {
        ///<summary>Anim Data</summary>
        public unsafe MovieSceneCameraAnimSectionData AnimData {
            get {return MovieSceneCameraAnimSection_ptr->AnimData;}
            set {MovieSceneCameraAnimSection_ptr->AnimData = value;}
        }
        static MovieSceneCameraAnimSection() {
            StaticClass = Main.GetClass("MovieSceneCameraAnimSection");
        }
        internal unsafe MovieSceneCameraAnimSection_fields* MovieSceneCameraAnimSection_ptr => (MovieSceneCameraAnimSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCameraAnimSection(IntPtr p) => UObject.Make<MovieSceneCameraAnimSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCameraAnimSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCameraAnimSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
