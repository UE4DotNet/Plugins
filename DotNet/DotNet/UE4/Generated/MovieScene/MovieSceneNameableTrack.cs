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
using UE4.MovieScene.Native;

namespace UE4.MovieScene {
    ///<summary>Base class for movie scene tracks that can be renamed by the user.</summary>
    public unsafe partial class MovieSceneNameableTrack : MovieSceneTrack  {
         //TODO: text FText DisplayName
        static MovieSceneNameableTrack() {
            StaticClass = Main.GetClass("MovieSceneNameableTrack");
        }
        internal unsafe MovieSceneNameableTrack_fields* MovieSceneNameableTrack_ptr => (MovieSceneNameableTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneNameableTrack(IntPtr p) => UObject.Make<MovieSceneNameableTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneNameableTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneNameableTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
