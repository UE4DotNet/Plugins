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
using UE4.Engine;

namespace UE4.MovieScene {
    ///<summary>Implements a section in sub-sequence tracks.</summary>
    public unsafe partial class MovieSceneSubSection : MovieSceneSection  {
        ///<summary>Parameters</summary>
        public unsafe MovieSceneSectionParameters Parameters {
            get {return MovieSceneSubSection_ptr->Parameters;}
            set {MovieSceneSubSection_ptr->Parameters = value;}
        }
        ///<summary>Movie scene being played by this section.</summary>
        ///<remarks>
        ///@todo Sequencer: Should this be lazy loaded?
        ///</remarks>
        public unsafe MovieSceneSequence SubSequence {
            get {return MovieSceneSubSection_ptr->SubSequence;}
            set {MovieSceneSubSection_ptr->SubSequence = value;}
        }
         //TODO: lazy object TLazyObjectPtr<AActor> ActorToRecord
         //TODO: string FString TargetSequenceName
        ///<summary>Target path of sequence to record to</summary>
        public unsafe DirectoryPath TargetPathToRecordTo {
            get {return MovieSceneSubSection_ptr->TargetPathToRecordTo;}
            set {MovieSceneSubSection_ptr->TargetPathToRecordTo = value;}
        }
        static MovieSceneSubSection() {
            StaticClass = Main.GetClass("MovieSceneSubSection");
        }
        internal unsafe MovieSceneSubSection_fields* MovieSceneSubSection_ptr => (MovieSceneSubSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSubSection(IntPtr p) => UObject.Make<MovieSceneSubSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSubSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSubSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
