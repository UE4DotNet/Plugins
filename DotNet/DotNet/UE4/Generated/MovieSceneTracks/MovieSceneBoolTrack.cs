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
    ///<summary>Handles manipulation of float properties in a movie scene</summary>
    public unsafe partial class MovieSceneBoolTrack : MovieScenePropertyTrack  {
        static MovieSceneBoolTrack() {
            StaticClass = Main.GetClass("MovieSceneBoolTrack");
        }
        internal unsafe MovieSceneBoolTrack_fields* MovieSceneBoolTrack_ptr => (MovieSceneBoolTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneBoolTrack(IntPtr p) => UObject.Make<MovieSceneBoolTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneBoolTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneBoolTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
