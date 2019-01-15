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
    ///<summary>Handles manipulation of component transforms in a movie scene</summary>
    public unsafe partial class MovieSceneVectorTrack : MovieScenePropertyTrack  {
        ///<summary>The number of channels used by the vector (2,3, or 4)</summary>
        public unsafe int NumChannelsUsed {
            get {return MovieSceneVectorTrack_ptr->NumChannelsUsed;}
            set {MovieSceneVectorTrack_ptr->NumChannelsUsed = value;}
        }
        static MovieSceneVectorTrack() {
            StaticClass = Main.GetClass("MovieSceneVectorTrack");
        }
        internal unsafe MovieSceneVectorTrack_fields* MovieSceneVectorTrack_ptr => (MovieSceneVectorTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneVectorTrack(IntPtr p) => UObject.Make<MovieSceneVectorTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneVectorTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneVectorTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
