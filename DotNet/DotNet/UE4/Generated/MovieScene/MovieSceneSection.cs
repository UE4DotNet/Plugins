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
    ///<summary>Base class for movie scene sections</summary>
    public unsafe partial class MovieSceneSection : MovieSceneSignedObject  {
        ///<summary>Eval Options</summary>
        public unsafe MovieSceneSectionEvalOptions EvalOptions {
            get {return MovieSceneSection_ptr->EvalOptions;}
            set {MovieSceneSection_ptr->EvalOptions = value;}
        }
        ///<summary>Easing</summary>
        public unsafe MovieSceneEasingSettings Easing {
            get {return MovieSceneSection_ptr->Easing;}
            set {MovieSceneSection_ptr->Easing = value;}
        }
        ///<summary>The range in which this section is active</summary>
        public unsafe MovieSceneFrameRange SectionRange {
            get {return MovieSceneSection_ptr->SectionRange;}
            set {MovieSceneSection_ptr->SectionRange = value;}
        }
        ///<summary>The timecode at which this movie scene section is based (ie. when it was recorded)</summary>
        public unsafe MovieSceneTimecodeSource TimecodeSource {
            get {return MovieSceneSection_ptr->TimecodeSource;}
            set {MovieSceneSection_ptr->TimecodeSource = value;}
        }
        ///<summary>The amount of time to prepare this section for evaluation before it actually starts.</summary>
        public unsafe FrameNumber PreRollFrames {
            get {return MovieSceneSection_ptr->PreRollFrames;}
            set {MovieSceneSection_ptr->PreRollFrames = value;}
        }
        ///<summary>The amount of time to continue 'postrolling' this section for after evaluation has ended.</summary>
        public unsafe FrameNumber PostRollFrames {
            get {return MovieSceneSection_ptr->PostRollFrames;}
            set {MovieSceneSection_ptr->PostRollFrames = value;}
        }
        ///<summary>The row index that this section sits on</summary>
        public unsafe int RowIndex {
            get {return MovieSceneSection_ptr->RowIndex;}
            set {MovieSceneSection_ptr->RowIndex = value;}
        }
        ///<summary>This section's priority over overlapping sections</summary>
        public unsafe int OverlapPriority {
            get {return MovieSceneSection_ptr->OverlapPriority;}
            set {MovieSceneSection_ptr->OverlapPriority = value;}
        }
        public bool bIsActive {
            get {return Main.GetGetBoolPropertyByName(this, "bIsActive"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsActive", value); }
        }
        public bool bIsLocked {
            get {return Main.GetGetBoolPropertyByName(this, "bIsLocked"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsLocked", value); }
        }
        public bool bSupportsInfiniteRange {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsInfiniteRange"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsInfiniteRange", value); }
        }
        ///<summary>Blend Type</summary>
        public unsafe OptionalMovieSceneBlendType BlendType {
            get {return MovieSceneSection_ptr->BlendType;}
            set {MovieSceneSection_ptr->BlendType = value;}
        }
        static MovieSceneSection() {
            StaticClass = Main.GetClass("MovieSceneSection");
        }
        internal unsafe MovieSceneSection_fields* MovieSceneSection_ptr => (MovieSceneSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSection(IntPtr p) => UObject.Make<MovieSceneSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
