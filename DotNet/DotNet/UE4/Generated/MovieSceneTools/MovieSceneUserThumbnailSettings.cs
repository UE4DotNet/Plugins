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
using UE4.MovieSceneTools.Native;

namespace UE4.MovieSceneTools {
    ///<summary>Movie Scene User Thumbnail Settings</summary>
    public unsafe partial class MovieSceneUserThumbnailSettings : UObject  {
        public bool bDrawThumbnails {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawThumbnails"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawThumbnails", value); }
        }
        public bool bDrawSingleThumbnails {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawSingleThumbnails"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawSingleThumbnails", value); }
        }
        ///<summary>Size at which to draw thumbnails on thumbnail sections</summary>
        public unsafe IntPoint ThumbnailSize {
            get {return MovieSceneUserThumbnailSettings_ptr->ThumbnailSize;}
            set {MovieSceneUserThumbnailSettings_ptr->ThumbnailSize = value;}
        }
         //TODO: enum EThumbnailQuality Quality
        static MovieSceneUserThumbnailSettings() {
            StaticClass = Main.GetClass("MovieSceneUserThumbnailSettings");
        }
        internal unsafe MovieSceneUserThumbnailSettings_fields* MovieSceneUserThumbnailSettings_ptr => (MovieSceneUserThumbnailSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneUserThumbnailSettings(IntPtr p) => UObject.Make<MovieSceneUserThumbnailSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneUserThumbnailSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneUserThumbnailSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
