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
    ///<summary>Video Capture Protocol</summary>
    public unsafe partial class VideoCaptureProtocol : FrameGrabberProtocol  {
        public bool bUseCompression {
            get {return Main.GetGetBoolPropertyByName(this, "bUseCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseCompression", value); }
        }
        ///<summary>Compression Quality</summary>
        public unsafe float CompressionQuality {
            get {return VideoCaptureProtocol_ptr->CompressionQuality;}
            set {VideoCaptureProtocol_ptr->CompressionQuality = value;}
        }
         //TODO: string FString VideoCodec
        static VideoCaptureProtocol() {
            StaticClass = Main.GetClass("VideoCaptureProtocol");
        }
        internal unsafe VideoCaptureProtocol_fields* VideoCaptureProtocol_ptr => (VideoCaptureProtocol_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VideoCaptureProtocol(IntPtr p) => UObject.Make<VideoCaptureProtocol>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VideoCaptureProtocol DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VideoCaptureProtocol New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
