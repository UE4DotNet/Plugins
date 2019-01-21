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
    ///<summary>Base class for a track in a Movie Scene</summary>
    public unsafe partial class MovieSceneTrack : MovieSceneSignedObject  {
        ///<summary>General evaluation options for a given track</summary>
        public unsafe MovieSceneTrackEvalOptions EvalOptions {
            get {return MovieSceneTrack_ptr->EvalOptions;}
            set {MovieSceneTrack_ptr->EvalOptions = value;}
        }
        ///<summary>This track's tint color</summary>
        public unsafe Color TrackTint {
            get {return MovieSceneTrack_ptr->TrackTint;}
            set {MovieSceneTrack_ptr->TrackTint = value;}
        }
        ///<summary>This folder's desired sorting order</summary>
        public unsafe int SortingOrder {
            get {return MovieSceneTrack_ptr->SortingOrder;}
            set {MovieSceneTrack_ptr->SortingOrder = value;}
        }
        public bool bSupportsDefaultSections {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsDefaultSections"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsDefaultSections", value); }
        }
        static MovieSceneTrack() {
            StaticClass = Main.GetClass("MovieSceneTrack");
        }
        internal unsafe MovieSceneTrack_fields* MovieSceneTrack_ptr => (MovieSceneTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneTrack(IntPtr p) => UObject.Make<MovieSceneTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
