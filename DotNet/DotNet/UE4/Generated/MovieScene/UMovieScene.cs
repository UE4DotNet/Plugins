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
    ///<summary>Implements a movie scene asset.</summary>
    public unsafe partial class UMovieScene : MovieSceneSignedObject  {
        ///<summary>The timecode at which this movie scene section is based (ie. when it was recorded)</summary>
        public unsafe MovieSceneTimecodeSource TimecodeSource {
            get {return UMovieScene_ptr->TimecodeSource;}
            set {UMovieScene_ptr->TimecodeSource = value;}
        }
         //TODO: array not UObject TArray Spawnables
         //TODO: array not UObject TArray Possessables
         //TODO: array not UObject TArray ObjectBindings
        ///<summary>Master tracks which are not bound to spawned or possessed objects</summary>
        public ObjectArrayField<MovieSceneTrack> MasterTracks{ get {
            if(MasterTracks_store == null) MasterTracks_store = new ObjectArrayField<MovieSceneTrack> (&UMovieScene_ptr->MasterTracks);
            return MasterTracks_store;
        } }
        private ObjectArrayField<MovieSceneTrack> MasterTracks_store;

        ///<summary>The camera cut track is a specialized track for switching between cameras on a cinematic</summary>
        public unsafe MovieSceneTrack CameraCutTrack {
            get {return UMovieScene_ptr->CameraCutTrack;}
            set {UMovieScene_ptr->CameraCutTrack = value;}
        }
        ///<summary>User-defined selection range.</summary>
        public unsafe MovieSceneFrameRange SelectionRange {
            get {return UMovieScene_ptr->SelectionRange;}
            set {UMovieScene_ptr->SelectionRange = value;}
        }
        ///<summary>User-defined playback range for this movie scene. Must be a finite range. Relative to this movie-scene's 0-time origin.</summary>
        public unsafe MovieSceneFrameRange PlaybackRange {
            get {return UMovieScene_ptr->PlaybackRange;}
            set {UMovieScene_ptr->PlaybackRange = value;}
        }
        ///<summary>The resolution at which all frame numbers within this movie-scene data are stored</summary>
        public unsafe FrameRate TickResolution {
            get {return UMovieScene_ptr->TickResolution;}
            set {UMovieScene_ptr->TickResolution = value;}
        }
        ///<summary>The rate at which we should interact with this moviescene data on UI, and to movie scene players. Also defines the frame locked frame rate.</summary>
        public unsafe FrameRate DisplayRate {
            get {return UMovieScene_ptr->DisplayRate;}
            set {UMovieScene_ptr->DisplayRate = value;}
        }
         //TODO: enum EMovieSceneEvaluationType EvaluationType
         //TODO: enum EUpdateClockSource ClockSource
        public bool bPlaybackRangeLocked {
            get {return Main.GetGetBoolPropertyByName(this, "bPlaybackRangeLocked"); }
            set {Main.SetGetBoolPropertyByName(this, "bPlaybackRangeLocked", value); }
        }
         //TODO: map TMap ObjectsToDisplayNames
         //TODO: map TMap ObjectsToLabels
        ///<summary>Editor only data that needs to be saved between sessions for editing but has no runtime purpose</summary>
        public unsafe MovieSceneEditorData EditorData {
            get {return UMovieScene_ptr->EditorData;}
            set {UMovieScene_ptr->EditorData = value;}
        }
        ///<summary>The root folders for this movie scene.</summary>
        public ObjectArrayField<MovieSceneFolder> RootFolders{ get {
            if(RootFolders_store == null) RootFolders_store = new ObjectArrayField<MovieSceneFolder> (&UMovieScene_ptr->RootFolders);
            return RootFolders_store;
        } }
        private ObjectArrayField<MovieSceneFolder> RootFolders_store;

        static UMovieScene() {
            StaticClass = Main.GetClass("MovieScene");
        }
        internal unsafe UMovieScene_fields* UMovieScene_ptr => (UMovieScene_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UMovieScene(IntPtr p) => UObject.Make<UMovieScene>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UMovieScene DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UMovieScene New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
