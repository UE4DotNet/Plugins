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
    ///<summary>A single actor reference point section</summary>
    public unsafe partial class MovieSceneActorReferenceSection : MovieSceneSection  {
        ///<summary>Actor Reference Data</summary>
        public unsafe MovieSceneActorReferenceData ActorReferenceData {
            get {return MovieSceneActorReferenceSection_ptr->ActorReferenceData;}
            set {MovieSceneActorReferenceSection_ptr->ActorReferenceData = value;}
        }
        static MovieSceneActorReferenceSection() {
            StaticClass = Main.GetClass("MovieSceneActorReferenceSection");
        }
        internal unsafe MovieSceneActorReferenceSection_fields* MovieSceneActorReferenceSection_ptr => (MovieSceneActorReferenceSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneActorReferenceSection(IntPtr p) => UObject.Make<MovieSceneActorReferenceSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneActorReferenceSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneActorReferenceSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
