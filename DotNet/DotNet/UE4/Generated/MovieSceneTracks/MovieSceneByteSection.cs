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
    ///<summary>A single byte section.</summary>
    public unsafe partial class MovieSceneByteSection : MovieSceneSection  {
        ///<summary>Ordered curve data</summary>
        public unsafe MovieSceneByteChannel ByteCurve {
            get {return MovieSceneByteSection_ptr->ByteCurve;}
            set {MovieSceneByteSection_ptr->ByteCurve = value;}
        }
        static MovieSceneByteSection() {
            StaticClass = Main.GetClass("MovieSceneByteSection");
        }
        internal unsafe MovieSceneByteSection_fields* MovieSceneByteSection_ptr => (MovieSceneByteSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneByteSection(IntPtr p) => UObject.Make<MovieSceneByteSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneByteSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneByteSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
