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
    ///<summary>Movie Scene Camera Shake Section</summary>
    public unsafe partial class MovieSceneCameraShakeSection : MovieSceneSection  {
        ///<summary>Shake Data</summary>
        public unsafe MovieSceneCameraShakeSectionData ShakeData {
            get {return MovieSceneCameraShakeSection_ptr->ShakeData;}
            set {MovieSceneCameraShakeSection_ptr->ShakeData = value;}
        }
        static MovieSceneCameraShakeSection() {
            StaticClass = Main.GetClass("MovieSceneCameraShakeSection");
        }
        internal unsafe MovieSceneCameraShakeSection_fields* MovieSceneCameraShakeSection_ptr => (MovieSceneCameraShakeSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCameraShakeSection(IntPtr p) => UObject.Make<MovieSceneCameraShakeSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCameraShakeSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCameraShakeSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
