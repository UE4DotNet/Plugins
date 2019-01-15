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
    ///<summary>Handles animation of skeletal mesh actors</summary>
    public unsafe partial class MovieSceneSkeletalAnimationTrack : MovieSceneNameableTrack  {
        ///<summary>List of all animation sections</summary>
        public ObjectArrayField<MovieSceneSection> AnimationSections{ get {
            if(AnimationSections_store == null) AnimationSections_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneSkeletalAnimationTrack_ptr->AnimationSections);
            return AnimationSections_store;
        } }
        private ObjectArrayField<MovieSceneSection> AnimationSections_store;

        public bool bUseLegacySectionIndexBlend {
            get {return Main.GetGetBoolPropertyByName(this, "bUseLegacySectionIndexBlend"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseLegacySectionIndexBlend", value); }
        }
        static MovieSceneSkeletalAnimationTrack() {
            StaticClass = Main.GetClass("MovieSceneSkeletalAnimationTrack");
        }
        internal unsafe MovieSceneSkeletalAnimationTrack_fields* MovieSceneSkeletalAnimationTrack_ptr => (MovieSceneSkeletalAnimationTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSkeletalAnimationTrack(IntPtr p) => UObject.Make<MovieSceneSkeletalAnimationTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSkeletalAnimationTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSkeletalAnimationTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
