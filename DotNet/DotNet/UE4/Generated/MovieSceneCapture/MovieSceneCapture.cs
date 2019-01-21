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
    ///<summary>Class responsible for capturing scene data</summary>
    public unsafe partial class MovieSceneCapture : UObject  {

        ///<summary>Get Audio Capture Protocol</summary>
        public MovieSceneCaptureProtocolBase GetAudioCaptureProtocol()  => 
            MovieSceneCapture_methods.GetAudioCaptureProtocol_method.Invoke(ObjPointer);

        ///<summary>Access the capture protocol we are using</summary>
        public MovieSceneCaptureProtocolBase GetImageCaptureProtocol()  => 
            MovieSceneCapture_methods.GetImageCaptureProtocol_method.Invoke(ObjPointer);

        ///<summary>Set Audio Capture Protocol Type</summary>
        public void SetAudioCaptureProtocolType(SubclassOf<MovieSceneCaptureProtocolBase> ProtocolType)  => 
            MovieSceneCapture_methods.SetAudioCaptureProtocolType_method.Invoke(ObjPointer, ProtocolType);

        ///<summary>Set Image Capture Protocol Type</summary>
        public void SetImageCaptureProtocolType(SubclassOf<MovieSceneCaptureProtocolBase> ProtocolType)  => 
            MovieSceneCapture_methods.SetImageCaptureProtocolType_method.Invoke(ObjPointer, ProtocolType);
        ///<summary>The type of capture protocol to use for image data</summary>
        public unsafe SoftClassPath ImageCaptureProtocolType {
            get {return MovieSceneCapture_ptr->ImageCaptureProtocolType;}
            set {MovieSceneCapture_ptr->ImageCaptureProtocolType = value;}
        }
        ///<summary>The type of capture protocol to use for audio data. Requires experimental audio mixer (launch editor via with -audiomixer).</summary>
        public unsafe SoftClassPath AudioCaptureProtocolType {
            get {return MovieSceneCapture_ptr->AudioCaptureProtocolType;}
            set {MovieSceneCapture_ptr->AudioCaptureProtocolType = value;}
        }
        ///<summary>Capture protocol responsible for actually capturing frame data</summary>
        public unsafe MovieSceneImageCaptureProtocolBase ImageCaptureProtocol {
            get {return MovieSceneCapture_ptr->ImageCaptureProtocol;}
            set {MovieSceneCapture_ptr->ImageCaptureProtocol = value;}
        }
        ///<summary>Audio Capture Protocol</summary>
        public unsafe MovieSceneAudioCaptureProtocolBase AudioCaptureProtocol {
            get {return MovieSceneCapture_ptr->AudioCaptureProtocol;}
            set {MovieSceneCapture_ptr->AudioCaptureProtocol = value;}
        }
        ///<summary>Settings that define how to capture</summary>
        public unsafe MovieSceneCaptureSettings Settings {
            get {return MovieSceneCapture_ptr->Settings;}
            set {MovieSceneCapture_ptr->Settings = value;}
        }
        public bool bUseSeparateProcess {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSeparateProcess"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSeparateProcess", value); }
        }
        public bool bCloseEditorWhenCaptureStarts {
            get {return Main.GetGetBoolPropertyByName(this, "bCloseEditorWhenCaptureStarts"); }
            set {Main.SetGetBoolPropertyByName(this, "bCloseEditorWhenCaptureStarts", value); }
        }
         //TODO: string FString AdditionalCommandLineArguments
         //TODO: string FString InheritedCommandLineArguments
        static MovieSceneCapture() {
            StaticClass = Main.GetClass("MovieSceneCapture");
        }
        internal unsafe MovieSceneCapture_fields* MovieSceneCapture_ptr => (MovieSceneCapture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCapture(IntPtr p) => UObject.Make<MovieSceneCapture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCapture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCapture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
