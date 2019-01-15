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

namespace UE4.MovieSceneTracks {
    ///<summary>Handles manipulation of byte properties in a movie scene</summary>
    public unsafe partial class MovieSceneByteTrack : MovieScenePropertyTrack  {
        ///<summary>Enum</summary>
        public unsafe UEnum UEnum {
            get {return MovieSceneByteTrack_ptr->UEnum;}
            set {MovieSceneByteTrack_ptr->UEnum = value;}
        }
        static MovieSceneByteTrack() {
            StaticClass = Main.GetClass("MovieSceneByteTrack");
        }
        internal unsafe MovieSceneByteTrack_fields* MovieSceneByteTrack_ptr => (MovieSceneByteTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneByteTrack(IntPtr p) => UObject.Make<MovieSceneByteTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneByteTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneByteTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
