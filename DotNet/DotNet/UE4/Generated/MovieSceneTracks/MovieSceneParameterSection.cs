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
    ///<summary>A single movie scene section which can contain data for multiple named parameters.</summary>
    public unsafe partial class MovieSceneParameterSection : MovieSceneSection  {
         //TODO: array not UObject TArray ScalarParameterNamesAndCurves
         //TODO: array not UObject TArray VectorParameterNamesAndCurves
         //TODO: array not UObject TArray ColorParameterNamesAndCurves
        static MovieSceneParameterSection() {
            StaticClass = Main.GetClass("MovieSceneParameterSection");
        }
        internal unsafe MovieSceneParameterSection_fields* MovieSceneParameterSection_ptr => (MovieSceneParameterSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneParameterSection(IntPtr p) => UObject.Make<MovieSceneParameterSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneParameterSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneParameterSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
