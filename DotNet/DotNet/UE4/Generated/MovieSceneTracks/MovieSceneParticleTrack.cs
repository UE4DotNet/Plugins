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
    ///<summary>Handles triggering of particle emitters</summary>
    public unsafe partial class MovieSceneParticleTrack : MovieSceneNameableTrack  {
        ///<summary>List of all particle sections.</summary>
        public ObjectArrayField<MovieSceneSection> ParticleSections{ get {
            if(ParticleSections_store == null) ParticleSections_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneParticleTrack_ptr->ParticleSections);
            return ParticleSections_store;
        } }
        private ObjectArrayField<MovieSceneSection> ParticleSections_store;

        static MovieSceneParticleTrack() {
            StaticClass = Main.GetClass("MovieSceneParticleTrack");
        }
        internal unsafe MovieSceneParticleTrack_fields* MovieSceneParticleTrack_ptr => (MovieSceneParticleTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneParticleTrack(IntPtr p) => UObject.Make<MovieSceneParticleTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneParticleTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneParticleTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
