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
    ///<summary>
    ///A capture protocol responsible for dealing with captured frames using some custom method (writing out to disk, streaming, etc)
    ///A typical process for capture consits of the following process:
    ///</summary>
    ///<remarks>Setup -> [ Warm up -> [ Capture Frame ] ] -> Begin Finalize -> [ HasFinishedProcessing ] -> Finalize</remarks>
    public unsafe partial class MovieSceneCaptureProtocolBase : UObject  {

        ///<summary>Get the current state of this capture protocol</summary>
        public EMovieSceneCaptureProtocolState GetState()  => 
            MovieSceneCaptureProtocolBase_methods.GetState_method.Invoke(ObjPointer);

        ///<summary>Check whether we can capture a frame from this protocol</summary>
        public bool IsCapturing()  => 
            MovieSceneCaptureProtocolBase_methods.IsCapturing_method.Invoke(ObjPointer);
         //TODO: enum EMovieSceneCaptureProtocolState State
        public bool bFrameRequested {
            get {return Main.GetGetBoolPropertyByName(this, "bFrameRequested"); }
            set {Main.SetGetBoolPropertyByName(this, "bFrameRequested", value); }
        }
        static MovieSceneCaptureProtocolBase() {
            StaticClass = Main.GetClass("MovieSceneCaptureProtocolBase");
        }
        internal unsafe MovieSceneCaptureProtocolBase_fields* MovieSceneCaptureProtocolBase_ptr => (MovieSceneCaptureProtocolBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCaptureProtocolBase(IntPtr p) => UObject.Make<MovieSceneCaptureProtocolBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCaptureProtocolBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCaptureProtocolBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
