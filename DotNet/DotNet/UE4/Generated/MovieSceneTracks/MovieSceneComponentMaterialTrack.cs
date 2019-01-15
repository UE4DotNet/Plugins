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
    ///<summary>A material track which is specialized for animation materials which are owned by actor components.</summary>
    public unsafe partial class MovieSceneComponentMaterialTrack : MovieSceneMaterialTrack  {
        ///<summary>The index of this material this track is animating.</summary>
        public unsafe int MaterialIndex {
            get {return MovieSceneComponentMaterialTrack_ptr->MaterialIndex;}
            set {MovieSceneComponentMaterialTrack_ptr->MaterialIndex = value;}
        }
        static MovieSceneComponentMaterialTrack() {
            StaticClass = Main.GetClass("MovieSceneComponentMaterialTrack");
        }
        internal unsafe MovieSceneComponentMaterialTrack_fields* MovieSceneComponentMaterialTrack_ptr => (MovieSceneComponentMaterialTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneComponentMaterialTrack(IntPtr p) => UObject.Make<MovieSceneComponentMaterialTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneComponentMaterialTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneComponentMaterialTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
