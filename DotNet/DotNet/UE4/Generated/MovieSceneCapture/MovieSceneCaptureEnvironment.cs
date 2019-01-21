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
    ///<summary>Movie Scene Capture Environment</summary>
    public unsafe partial class MovieSceneCaptureEnvironment : UObject  {

        ///<summary>Attempt to locate a capture protocol - may not be in a capturing state</summary>
        public static MovieSceneAudioCaptureProtocolBase FindAudioCaptureProtocol()  => 
            MovieSceneCaptureEnvironment_methods.FindAudioCaptureProtocol_method.Invoke();

        ///<summary>Attempt to locate a capture protocol - may not be in a capturing state</summary>
        public static MovieSceneImageCaptureProtocolBase FindImageCaptureProtocol()  => 
            MovieSceneCaptureEnvironment_methods.FindImageCaptureProtocol_method.Invoke();

        ///<summary>Get the total elapsed time of the current capture in seconds</summary>
        public static float GetCaptureElapsedTime()  => 
            MovieSceneCaptureEnvironment_methods.GetCaptureElapsedTime_method.Invoke();

        ///<summary>Get the frame number of the current capture</summary>
        public static int GetCaptureFrameNumber()  => 
            MovieSceneCaptureEnvironment_methods.GetCaptureFrameNumber_method.Invoke();

        ///<summary>Return true if there is any capture currently active (even in a warm-up state).</summary>
        ///<remarks>Useful for checking whether to do certain operations in BeginPlay</remarks>
        public static bool IsCaptureInProgress()  => 
            MovieSceneCaptureEnvironment_methods.IsCaptureInProgress_method.Invoke();
        static MovieSceneCaptureEnvironment() {
            StaticClass = Main.GetClass("MovieSceneCaptureEnvironment");
        }
        internal unsafe MovieSceneCaptureEnvironment_fields* MovieSceneCaptureEnvironment_ptr => (MovieSceneCaptureEnvironment_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCaptureEnvironment(IntPtr p) => UObject.Make<MovieSceneCaptureEnvironment>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCaptureEnvironment DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCaptureEnvironment New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
