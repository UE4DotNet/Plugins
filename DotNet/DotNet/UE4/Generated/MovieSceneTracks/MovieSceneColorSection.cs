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
    public unsafe partial class MovieSceneColorSection : MovieSceneSection  {
        ///<summary>Red curve data</summary>
        public unsafe MovieSceneFloatChannel RedCurve {
            get {return MovieSceneColorSection_ptr->RedCurve;}
            set {MovieSceneColorSection_ptr->RedCurve = value;}
        }
        ///<summary>Green curve data</summary>
        public unsafe MovieSceneFloatChannel GreenCurve {
            get {return MovieSceneColorSection_ptr->GreenCurve;}
            set {MovieSceneColorSection_ptr->GreenCurve = value;}
        }
        ///<summary>Blue curve data</summary>
        public unsafe MovieSceneFloatChannel BlueCurve {
            get {return MovieSceneColorSection_ptr->BlueCurve;}
            set {MovieSceneColorSection_ptr->BlueCurve = value;}
        }
        ///<summary>Alpha curve data</summary>
        public unsafe MovieSceneFloatChannel AlphaCurve {
            get {return MovieSceneColorSection_ptr->AlphaCurve;}
            set {MovieSceneColorSection_ptr->AlphaCurve = value;}
        }
        static MovieSceneColorSection() {
            StaticClass = Main.GetClass("MovieSceneColorSection");
        }
        internal unsafe MovieSceneColorSection_fields* MovieSceneColorSection_ptr => (MovieSceneColorSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneColorSection(IntPtr p) => UObject.Make<MovieSceneColorSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneColorSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneColorSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
