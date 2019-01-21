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
    ///<summary>Base class for all event sections. Manages dirtying the section and track on recompilation of the director blueprint.</summary>
    public unsafe partial class MovieSceneEventSectionBase : MovieSceneSection  {
         //TODO: weak object TWeakObjectPtr<UBlueprint> DirectorBlueprint
        static MovieSceneEventSectionBase() {
            StaticClass = Main.GetClass("MovieSceneEventSectionBase");
        }
        internal unsafe MovieSceneEventSectionBase_fields* MovieSceneEventSectionBase_ptr => (MovieSceneEventSectionBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneEventSectionBase(IntPtr p) => UObject.Make<MovieSceneEventSectionBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneEventSectionBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneEventSectionBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
