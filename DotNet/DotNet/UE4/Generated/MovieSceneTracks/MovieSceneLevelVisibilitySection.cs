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
    ///<summary>A section for use with the movie scene level visibility track, which controls streamed level visibility.</summary>
    public unsafe partial class MovieSceneLevelVisibilitySection : MovieSceneSection  {
         //TODO: enum ELevelVisibility Visibility
         //TODO: array not UObject TArray LevelNames
        static MovieSceneLevelVisibilitySection() {
            StaticClass = Main.GetClass("MovieSceneLevelVisibilitySection");
        }
        internal unsafe MovieSceneLevelVisibilitySection_fields* MovieSceneLevelVisibilitySection_ptr => (MovieSceneLevelVisibilitySection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneLevelVisibilitySection(IntPtr p) => UObject.Make<MovieSceneLevelVisibilitySection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneLevelVisibilitySection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneLevelVisibilitySection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
