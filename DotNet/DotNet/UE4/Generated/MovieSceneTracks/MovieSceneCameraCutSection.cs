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
    ///<summary>Movie CameraCuts are sections on the CameraCuts track, that show what the viewer "sees"</summary>
    public unsafe partial class MovieSceneCameraCutSection : MovieSceneSection  {
        ///<summary>The camera binding that this movie CameraCut uses</summary>
        public unsafe MovieSceneObjectBindingID CameraBindingID {
            get {return MovieSceneCameraCutSection_ptr->CameraBindingID;}
            set {MovieSceneCameraCutSection_ptr->CameraBindingID = value;}
        }
        ///<summary>The reference frame offset for single thumbnail rendering</summary>
        public unsafe float ThumbnailReferenceOffset {
            get {return MovieSceneCameraCutSection_ptr->ThumbnailReferenceOffset;}
            set {MovieSceneCameraCutSection_ptr->ThumbnailReferenceOffset = value;}
        }
        static MovieSceneCameraCutSection() {
            StaticClass = Main.GetClass("MovieSceneCameraCutSection");
        }
        internal unsafe MovieSceneCameraCutSection_fields* MovieSceneCameraCutSection_ptr => (MovieSceneCameraCutSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCameraCutSection(IntPtr p) => UObject.Make<MovieSceneCameraCutSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCameraCutSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCameraCutSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
