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
    ///<summary>A single floating point section.</summary>
    public unsafe partial class MovieSceneFadeSection : MovieSceneFloatSection  {
        ///<summary>Fade color.</summary>
        public unsafe LinearColor FadeColor {
            get {return MovieSceneFadeSection_ptr->FadeColor;}
            set {MovieSceneFadeSection_ptr->FadeColor = value;}
        }
        public bool bFadeAudio {
            get {return Main.GetGetBoolPropertyByName(this, "bFadeAudio"); }
            set {Main.SetGetBoolPropertyByName(this, "bFadeAudio", value); }
        }
        static MovieSceneFadeSection() {
            StaticClass = Main.GetClass("MovieSceneFadeSection");
        }
        internal unsafe MovieSceneFadeSection_fields* MovieSceneFadeSection_ptr => (MovieSceneFadeSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneFadeSection(IntPtr p) => UObject.Make<MovieSceneFadeSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneFadeSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneFadeSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
