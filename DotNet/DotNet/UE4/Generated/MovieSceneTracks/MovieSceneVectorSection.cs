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
    ///<summary>A vector section.</summary>
    public unsafe partial class MovieSceneVectorSection : MovieSceneSection  {
        ///<summary>Float functions for the X,Y,Z,W components of the vector</summary>
        public unsafe MovieSceneFloatChannel Curves {
            get {return MovieSceneVectorSection_ptr->Curves;}
            set {MovieSceneVectorSection_ptr->Curves = value;}
        }
        ///<summary>How many curves are actually used</summary>
        public unsafe int ChannelsUsed {
            get {return MovieSceneVectorSection_ptr->ChannelsUsed;}
            set {MovieSceneVectorSection_ptr->ChannelsUsed = value;}
        }
        static MovieSceneVectorSection() {
            StaticClass = Main.GetClass("MovieSceneVectorSection");
        }
        internal unsafe MovieSceneVectorSection_fields* MovieSceneVectorSection_ptr => (MovieSceneVectorSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneVectorSection(IntPtr p) => UObject.Make<MovieSceneVectorSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneVectorSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneVectorSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
