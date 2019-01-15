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
    ///<summary>A single floating point section</summary>
    public unsafe partial class MovieSceneFloatSection : MovieSceneSection  {
        ///<summary>Float data</summary>
        public unsafe MovieSceneFloatChannel FloatCurve {
            get {return MovieSceneFloatSection_ptr->FloatCurve;}
            set {MovieSceneFloatSection_ptr->FloatCurve = value;}
        }
        static MovieSceneFloatSection() {
            StaticClass = Main.GetClass("MovieSceneFloatSection");
        }
        internal unsafe MovieSceneFloatSection_fields* MovieSceneFloatSection_ptr => (MovieSceneFloatSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneFloatSection(IntPtr p) => UObject.Make<MovieSceneFloatSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneFloatSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneFloatSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
