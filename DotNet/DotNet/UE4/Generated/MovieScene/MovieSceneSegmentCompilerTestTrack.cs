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
using UE4.MovieScene.Native;

namespace UE4.MovieScene {
    ///<summary>Movie Scene Segment Compiler Test Track</summary>
    public unsafe partial class MovieSceneSegmentCompilerTestTrack : MovieSceneTrack  {
        public bool bHighPassFilter {
            get {return Main.GetGetBoolPropertyByName(this, "bHighPassFilter"); }
            set {Main.SetGetBoolPropertyByName(this, "bHighPassFilter", value); }
        }
        ///<summary>Section Array</summary>
        public ObjectArrayField<MovieSceneSection> SectionArray{ get {
            if(SectionArray_store == null) SectionArray_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneSegmentCompilerTestTrack_ptr->SectionArray);
            return SectionArray_store;
        } }
        private ObjectArrayField<MovieSceneSection> SectionArray_store;

        static MovieSceneSegmentCompilerTestTrack() {
            StaticClass = Main.GetClass("MovieSceneSegmentCompilerTestTrack");
        }
        internal unsafe MovieSceneSegmentCompilerTestTrack_fields* MovieSceneSegmentCompilerTestTrack_ptr => (MovieSceneSegmentCompilerTestTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSegmentCompilerTestTrack(IntPtr p) => UObject.Make<MovieSceneSegmentCompilerTestTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSegmentCompilerTestTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSegmentCompilerTestTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
