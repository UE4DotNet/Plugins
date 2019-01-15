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
using UE4.GeometryCacheTracks.Native;
using UE4.MovieScene;

namespace UE4.GeometryCacheTracks {
    ///<summary>Movie scene section that control geometry cache playback</summary>
    public unsafe partial class MovieSceneGeometryCacheSection : MovieSceneSection  {
        ///<summary>Params</summary>
        public unsafe MovieSceneGeometryCacheParams Params {
            get {return MovieSceneGeometryCacheSection_ptr->Params;}
            set {MovieSceneGeometryCacheSection_ptr->Params = value;}
        }
        static MovieSceneGeometryCacheSection() {
            StaticClass = Main.GetClass("MovieSceneGeometryCacheSection");
        }
        internal unsafe MovieSceneGeometryCacheSection_fields* MovieSceneGeometryCacheSection_ptr => (MovieSceneGeometryCacheSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneGeometryCacheSection(IntPtr p) => UObject.Make<MovieSceneGeometryCacheSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneGeometryCacheSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneGeometryCacheSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
