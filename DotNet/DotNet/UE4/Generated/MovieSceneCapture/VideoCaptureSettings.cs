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
    ///<summary>Video Capture Settings</summary>
    public unsafe partial class VideoCaptureSettings : FrameGrabberProtocolSettings  {
        public bool bUseCompression {
            get {return Main.GetGetBoolPropertyByName(this, "bUseCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseCompression", value); }
        }
        ///<summary>Compression Quality</summary>
        public unsafe float CompressionQuality {
            get {return VideoCaptureSettings_ptr->CompressionQuality;}
            set {VideoCaptureSettings_ptr->CompressionQuality = value;}
        }
         //TODO: string FString VideoCodec
        static VideoCaptureSettings() {
            StaticClass = Main.GetClass("VideoCaptureSettings");
        }
        internal unsafe VideoCaptureSettings_fields* VideoCaptureSettings_ptr => (VideoCaptureSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VideoCaptureSettings(IntPtr p) => UObject.Make<VideoCaptureSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VideoCaptureSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VideoCaptureSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
