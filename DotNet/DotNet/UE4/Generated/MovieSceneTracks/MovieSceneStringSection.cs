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
    ///<summary>A single string section</summary>
    public unsafe partial class MovieSceneStringSection : MovieSceneSection  {
        ///<summary>Curve data</summary>
        public unsafe MovieSceneStringChannel StringCurve {
            get {return MovieSceneStringSection_ptr->StringCurve;}
            set {MovieSceneStringSection_ptr->StringCurve = value;}
        }
        static MovieSceneStringSection() {
            StaticClass = Main.GetClass("MovieSceneStringSection");
        }
        internal unsafe MovieSceneStringSection_fields* MovieSceneStringSection_ptr => (MovieSceneStringSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneStringSection(IntPtr p) => UObject.Make<MovieSceneStringSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneStringSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneStringSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
