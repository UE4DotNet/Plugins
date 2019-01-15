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
        ///<summary>The type of capture protocol to use</summary>
        public unsafe CaptureProtocolID CaptureType {
            get {return MovieSceneCapture_ptr->CaptureType;}
            set {MovieSceneCapture_ptr->CaptureType = value;}
        }
        ///<summary>Settings specific to the capture protocol</summary>
        public unsafe MovieSceneCaptureProtocolSettings ProtocolSettings {
            get {return MovieSceneCapture_ptr->ProtocolSettings;}
            set {MovieSceneCapture_ptr->ProtocolSettings = value;}
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
