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
    ///<summary>Particle section, for particle toggling and triggering.</summary>
    public unsafe partial class MovieSceneParticleSection : MovieSceneSection  {
        ///<summary>Curve containing the particle keys.</summary>
        public unsafe MovieSceneParticleChannel ParticleKeys {
            get {return MovieSceneParticleSection_ptr->ParticleKeys;}
            set {MovieSceneParticleSection_ptr->ParticleKeys = value;}
        }
        static MovieSceneParticleSection() {
            StaticClass = Main.GetClass("MovieSceneParticleSection");
        }
        internal unsafe MovieSceneParticleSection_fields* MovieSceneParticleSection_ptr => (MovieSceneParticleSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneParticleSection(IntPtr p) => UObject.Make<MovieSceneParticleSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneParticleSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneParticleSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
