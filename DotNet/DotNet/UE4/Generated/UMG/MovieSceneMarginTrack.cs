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
using UE4.UMG.Native;
using UE4.MovieSceneTracks;

namespace UE4.UMG {
    ///<summary>Handles manipulation of FMargins in a movie scene</summary>
    public unsafe partial class MovieSceneMarginTrack : MovieScenePropertyTrack  {
        static MovieSceneMarginTrack() {
            StaticClass = Main.GetClass("MovieSceneMarginTrack");
        }
        internal unsafe MovieSceneMarginTrack_fields* MovieSceneMarginTrack_ptr => (MovieSceneMarginTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneMarginTrack(IntPtr p) => UObject.Make<MovieSceneMarginTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneMarginTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneMarginTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
