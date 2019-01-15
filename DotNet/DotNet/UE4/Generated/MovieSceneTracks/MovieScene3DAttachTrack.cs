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
    ///<summary>Handles manipulation of path tracks in a movie scene.</summary>
    public unsafe partial class MovieScene3DAttachTrack : MovieScene3DConstraintTrack  {
        static MovieScene3DAttachTrack() {
            StaticClass = Main.GetClass("MovieScene3DAttachTrack");
        }
        internal unsafe MovieScene3DAttachTrack_fields* MovieScene3DAttachTrack_ptr => (MovieScene3DAttachTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieScene3DAttachTrack(IntPtr p) => UObject.Make<MovieScene3DAttachTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieScene3DAttachTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieScene3DAttachTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
