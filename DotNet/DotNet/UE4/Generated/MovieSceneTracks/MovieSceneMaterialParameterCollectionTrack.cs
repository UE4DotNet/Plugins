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
using UE4.Engine;

namespace UE4.MovieSceneTracks {
    ///<summary>Handles manipulation of material parameter collections in a movie scene.</summary>
    public unsafe partial class MovieSceneMaterialParameterCollectionTrack : MovieSceneMaterialTrack  {
        ///<summary>The material parameter collection to manipulate</summary>
        public unsafe MaterialParameterCollection MPC {
            get {return MovieSceneMaterialParameterCollectionTrack_ptr->MPC;}
            set {MovieSceneMaterialParameterCollectionTrack_ptr->MPC = value;}
        }
        static MovieSceneMaterialParameterCollectionTrack() {
            StaticClass = Main.GetClass("MovieSceneMaterialParameterCollectionTrack");
        }
        internal unsafe MovieSceneMaterialParameterCollectionTrack_fields* MovieSceneMaterialParameterCollectionTrack_ptr => (MovieSceneMaterialParameterCollectionTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneMaterialParameterCollectionTrack(IntPtr p) => UObject.Make<MovieSceneMaterialParameterCollectionTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneMaterialParameterCollectionTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneMaterialParameterCollectionTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
