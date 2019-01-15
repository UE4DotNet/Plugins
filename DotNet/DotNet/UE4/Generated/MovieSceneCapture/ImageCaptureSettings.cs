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
    ///<summary>Image Capture Settings</summary>
    public unsafe partial class ImageCaptureSettings : FrameGrabberProtocolSettings  {
        ///<summary>Level of compression to apply to the image, between 1 (worst quality, best compression) and 100 (best quality, worst compression)</summary>
        public unsafe int CompressionQuality {
            get {return ImageCaptureSettings_ptr->CompressionQuality;}
            set {ImageCaptureSettings_ptr->CompressionQuality = value;}
        }
        static ImageCaptureSettings() {
            StaticClass = Main.GetClass("ImageCaptureSettings");
        }
        internal unsafe ImageCaptureSettings_fields* ImageCaptureSettings_ptr => (ImageCaptureSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImageCaptureSettings(IntPtr p) => UObject.Make<ImageCaptureSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImageCaptureSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImageCaptureSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
