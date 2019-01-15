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
    ///<summary>A single enum section.</summary>
    public unsafe partial class MovieSceneEnumSection : MovieSceneSection  {
        ///<summary>Ordered curve data</summary>
        public unsafe MovieSceneByteChannel EnumCurve {
            get {return MovieSceneEnumSection_ptr->EnumCurve;}
            set {MovieSceneEnumSection_ptr->EnumCurve = value;}
        }
        static MovieSceneEnumSection() {
            StaticClass = Main.GetClass("MovieSceneEnumSection");
        }
        internal unsafe MovieSceneEnumSection_fields* MovieSceneEnumSection_ptr => (MovieSceneEnumSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneEnumSection(IntPtr p) => UObject.Make<MovieSceneEnumSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneEnumSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneEnumSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
