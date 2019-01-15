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
    ///<summary>Base class for constraint tracks (tracks that are dependent upon other objects).</summary>
    public unsafe partial class MovieScene3DConstraintTrack : MovieSceneTrack  {
        ///<summary>List of all constraint sections.</summary>
        public ObjectArrayField<MovieSceneSection> ConstraintSections{ get {
            if(ConstraintSections_store == null) ConstraintSections_store = new ObjectArrayField<MovieSceneSection> (&MovieScene3DConstraintTrack_ptr->ConstraintSections);
            return ConstraintSections_store;
        } }
        private ObjectArrayField<MovieSceneSection> ConstraintSections_store;

        static MovieScene3DConstraintTrack() {
            StaticClass = Main.GetClass("MovieScene3DConstraintTrack");
        }
        internal unsafe MovieScene3DConstraintTrack_fields* MovieScene3DConstraintTrack_ptr => (MovieScene3DConstraintTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieScene3DConstraintTrack(IntPtr p) => UObject.Make<MovieScene3DConstraintTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieScene3DConstraintTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieScene3DConstraintTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
