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
    public unsafe partial class MovieSceneEnumTrack : MovieScenePropertyTrack  {
        ///<summary>Enum</summary>
        public unsafe UEnum UEnum {
            get {return MovieSceneEnumTrack_ptr->UEnum;}
            set {MovieSceneEnumTrack_ptr->UEnum = value;}
        }
        static MovieSceneEnumTrack() {
            StaticClass = Main.GetClass("MovieSceneEnumTrack");
        }
        internal unsafe MovieSceneEnumTrack_fields* MovieSceneEnumTrack_ptr => (MovieSceneEnumTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneEnumTrack(IntPtr p) => UObject.Make<MovieSceneEnumTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneEnumTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneEnumTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
