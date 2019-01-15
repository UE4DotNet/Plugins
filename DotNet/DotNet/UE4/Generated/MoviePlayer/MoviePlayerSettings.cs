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
using UE4.MoviePlayer.Native;

namespace UE4.MoviePlayer {
    ///<summary>Implements the settings for the Windows target platform.</summary>
    public unsafe partial class MoviePlayerSettings : UObject  {
        public bool bWaitForMoviesToComplete {
            get {return Main.GetGetBoolPropertyByName(this, "bWaitForMoviesToComplete"); }
            set {Main.SetGetBoolPropertyByName(this, "bWaitForMoviesToComplete", value); }
        }
        public bool bMoviesAreSkippable {
            get {return Main.GetGetBoolPropertyByName(this, "bMoviesAreSkippable"); }
            set {Main.SetGetBoolPropertyByName(this, "bMoviesAreSkippable", value); }
        }
         //TODO: array not UObject TArray StartupMovies
        static MoviePlayerSettings() {
            StaticClass = Main.GetClass("MoviePlayerSettings");
        }
        internal unsafe MoviePlayerSettings_fields* MoviePlayerSettings_ptr => (MoviePlayerSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MoviePlayerSettings(IntPtr p) => UObject.Make<MoviePlayerSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MoviePlayerSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MoviePlayerSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
