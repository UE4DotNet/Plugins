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
    ///<summary>Movie Scene Transform Origin</summary>
    public unsafe partial class MovieSceneTransformOrigin : Interface  {

        ///<summary>Get the transform from which all absolute component transform sections should be relative. Scale is ignored.</summary>
        public event BP_GetTransformOrigin_delegate BP_GetTransformOrigin;
        public delegate Transform BP_GetTransformOrigin_delegate(Transform ReturnValue);
        internal Transform on_BP_GetTransformOrigin(Transform ReturnValue) =>
            BP_GetTransformOrigin != null ? BP_GetTransformOrigin(ReturnValue) : ReturnValue;

        static MovieSceneTransformOrigin() {
            StaticClass = Main.GetClass("MovieSceneTransformOrigin");
            MovieSceneTransformOrigin_events.BP_GetTransformOrigin_event.Setup();
        }
        internal unsafe MovieSceneTransformOrigin_fields* MovieSceneTransformOrigin_ptr => (MovieSceneTransformOrigin_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneTransformOrigin(IntPtr p) => UObject.Make<MovieSceneTransformOrigin>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneTransformOrigin DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneTransformOrigin New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
