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
    ///<summary>A single bool section.</summary>
    public unsafe partial class MovieSceneBoolSection : MovieSceneSection  {
        ///<summary>Ordered curve data</summary>
        public unsafe MovieSceneBoolChannel BoolCurve {
            get {return MovieSceneBoolSection_ptr->BoolCurve;}
            set {MovieSceneBoolSection_ptr->BoolCurve = value;}
        }
        public bool bIsExternallyInverted {
            get {return Main.GetGetBoolPropertyByName(this, "bIsExternallyInverted"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsExternallyInverted", value); }
        }
        static MovieSceneBoolSection() {
            StaticClass = Main.GetClass("MovieSceneBoolSection");
        }
        internal unsafe MovieSceneBoolSection_fields* MovieSceneBoolSection_ptr => (MovieSceneBoolSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneBoolSection(IntPtr p) => UObject.Make<MovieSceneBoolSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneBoolSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneBoolSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
