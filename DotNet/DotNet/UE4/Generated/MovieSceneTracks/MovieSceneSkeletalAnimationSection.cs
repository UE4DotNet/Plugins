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
    ///<summary>Movie scene section that control skeletal animation</summary>
    public unsafe partial class MovieSceneSkeletalAnimationSection : MovieSceneSection  {
        ///<summary>Params</summary>
        public unsafe MovieSceneSkeletalAnimationParams Params {
            get {return MovieSceneSkeletalAnimationSection_ptr->Params;}
            set {MovieSceneSkeletalAnimationSection_ptr->Params = value;}
        }
        static MovieSceneSkeletalAnimationSection() {
            StaticClass = Main.GetClass("MovieSceneSkeletalAnimationSection");
        }
        internal unsafe MovieSceneSkeletalAnimationSection_fields* MovieSceneSkeletalAnimationSection_ptr => (MovieSceneSkeletalAnimationSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSkeletalAnimationSection(IntPtr p) => UObject.Make<MovieSceneSkeletalAnimationSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSkeletalAnimationSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSkeletalAnimationSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
