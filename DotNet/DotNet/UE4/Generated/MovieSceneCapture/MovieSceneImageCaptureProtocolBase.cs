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
using UE4.MovieSceneCapture.Native;

namespace UE4.MovieSceneCapture {
    ///<summary>A class to inherit from for image capture protocols. Used to filter the UI for protocols used on the image capture pass.</summary>
    public unsafe partial class MovieSceneImageCaptureProtocolBase : MovieSceneCaptureProtocolBase  {
        static MovieSceneImageCaptureProtocolBase() {
            StaticClass = Main.GetClass("MovieSceneImageCaptureProtocolBase");
        }
        internal unsafe MovieSceneImageCaptureProtocolBase_fields* MovieSceneImageCaptureProtocolBase_ptr => (MovieSceneImageCaptureProtocolBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneImageCaptureProtocolBase(IntPtr p) => UObject.Make<MovieSceneImageCaptureProtocolBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneImageCaptureProtocolBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneImageCaptureProtocolBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
