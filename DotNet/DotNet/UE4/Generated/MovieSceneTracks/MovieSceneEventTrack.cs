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
    ///<summary>Implements a movie scene track that triggers discrete events during playback.</summary>
    public unsafe partial class MovieSceneEventTrack : MovieSceneNameableTrack  {
        public bool bFireEventsWhenForwards {
            get {return Main.GetGetBoolPropertyByName(this, "bFireEventsWhenForwards"); }
            set {Main.SetGetBoolPropertyByName(this, "bFireEventsWhenForwards", value); }
        }
        public bool bFireEventsWhenBackwards {
            get {return Main.GetGetBoolPropertyByName(this, "bFireEventsWhenBackwards"); }
            set {Main.SetGetBoolPropertyByName(this, "bFireEventsWhenBackwards", value); }
        }
         //TODO: enum EFireEventsAtPosition EventPosition
         //TODO: array not UObject TArray EventReceivers
        ///<summary>The track's sections.</summary>
        public ObjectArrayField<MovieSceneSection> Sections{ get {
            if(Sections_store == null) Sections_store = new ObjectArrayField<MovieSceneSection> (&MovieSceneEventTrack_ptr->Sections);
            return Sections_store;
        } }
        private ObjectArrayField<MovieSceneSection> Sections_store;

        static MovieSceneEventTrack() {
            StaticClass = Main.GetClass("MovieSceneEventTrack");
        }
        internal unsafe MovieSceneEventTrack_fields* MovieSceneEventTrack_ptr => (MovieSceneEventTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneEventTrack(IntPtr p) => UObject.Make<MovieSceneEventTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneEventTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneEventTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
