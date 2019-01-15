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
using UE4.UMG.Native;
using UE4.MovieSceneTracks;

namespace UE4.UMG {
    ///<summary>A material track which is specialized for materials which are owned by widget brushes.</summary>
    public unsafe partial class MovieSceneWidgetMaterialTrack : MovieSceneMaterialTrack  {
         //TODO: array not UObject TArray BrushPropertyNamePath
        ///<summary>The name of this track, generated from the property name path.</summary>
        public unsafe Name TrackName {
            get {return MovieSceneWidgetMaterialTrack_ptr->TrackName;}
            set {MovieSceneWidgetMaterialTrack_ptr->TrackName = value;}
        }
        static MovieSceneWidgetMaterialTrack() {
            StaticClass = Main.GetClass("MovieSceneWidgetMaterialTrack");
        }
        internal unsafe MovieSceneWidgetMaterialTrack_fields* MovieSceneWidgetMaterialTrack_ptr => (MovieSceneWidgetMaterialTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneWidgetMaterialTrack(IntPtr p) => UObject.Make<MovieSceneWidgetMaterialTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneWidgetMaterialTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneWidgetMaterialTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
