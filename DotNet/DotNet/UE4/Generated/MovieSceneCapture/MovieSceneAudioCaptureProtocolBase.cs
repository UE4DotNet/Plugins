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
    ///<summary>A class to inherit from for audio capture protocols. Used to filter the UI for protocols used on the audio capture pass.</summary>
    public unsafe partial class MovieSceneAudioCaptureProtocolBase : MovieSceneCaptureProtocolBase  {
        static MovieSceneAudioCaptureProtocolBase() {
            StaticClass = Main.GetClass("MovieSceneAudioCaptureProtocolBase");
        }
        internal unsafe MovieSceneAudioCaptureProtocolBase_fields* MovieSceneAudioCaptureProtocolBase_ptr => (MovieSceneAudioCaptureProtocolBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneAudioCaptureProtocolBase(IntPtr p) => UObject.Make<MovieSceneAudioCaptureProtocolBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneAudioCaptureProtocolBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneAudioCaptureProtocolBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
