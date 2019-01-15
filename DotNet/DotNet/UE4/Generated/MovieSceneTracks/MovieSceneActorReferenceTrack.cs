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
    ///<summary>Handles manipulation of actor reference properties in a movie scene</summary>
    public unsafe partial class MovieSceneActorReferenceTrack : MovieScenePropertyTrack  {
        static MovieSceneActorReferenceTrack() {
            StaticClass = Main.GetClass("MovieSceneActorReferenceTrack");
        }
        internal unsafe MovieSceneActorReferenceTrack_fields* MovieSceneActorReferenceTrack_ptr => (MovieSceneActorReferenceTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneActorReferenceTrack(IntPtr p) => UObject.Make<MovieSceneActorReferenceTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneActorReferenceTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneActorReferenceTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
