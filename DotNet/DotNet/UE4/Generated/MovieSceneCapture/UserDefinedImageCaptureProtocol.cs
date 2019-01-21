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
using UE4.Engine;

namespace UE4.MovieSceneCapture {
    ///<summary>A blueprintable capture protocol tailored to capturing and exporting frames as images</summary>
    public unsafe partial class UserDefinedImageCaptureProtocol : UserDefinedCaptureProtocol  {

        ///<summary>
        ///* Generate a filename for the specified buffer using this protocol's file name formatter
        ///*
        ///* @
        ///</summary>
        ///<remarks>
        ///param Buffer          The desired buffer to generate a filename for
        ///* @param StreamName      The name of the stream for this buffer (e.g. a composition pass name)
        ///* @return A fully qualified file name
        ///</remarks>
        public string GenerateFilenameForBuffer(Texture Buffer, Name StreamName)  => 
            UserDefinedImageCaptureProtocol_methods.GenerateFilenameForBuffer_method.Invoke(ObjPointer, Buffer, StreamName);

        ///<summary>
        ///* Generate a filename for the current frame using this protocol's file name formatter
        ///*
        ///* @
        ///</summary>
        ///<remarks>return A fully qualified file name for the current frame number</remarks>
        public string GenerateFilenameForCurrentFrame()  => 
            UserDefinedImageCaptureProtocol_methods.GenerateFilenameForCurrentFrame_method.Invoke(ObjPointer);

        ///<summary>
        ///* Generate a filename for the current frame using this protocol's file name formatter
        ///*
        ///* @
        ///</summary>
        ///<remarks>return A fully qualified file name for the current frame number</remarks>
        public void WriteImageToDisk(CapturedPixels PixelData, Name StreamName, FrameMetrics FrameMetrics, bool bCopyImageData)  => 
            UserDefinedImageCaptureProtocol_methods.WriteImageToDisk_method.Invoke(ObjPointer, PixelData, StreamName, FrameMetrics, bCopyImageData);
         //TODO: enum EDesiredImageFormat Format
        public bool bEnableCompression {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableCompression"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableCompression", value); }
        }
        ///<summary>The compression quality for the image type. For EXRs, 0 = Default ZIP compression, 1 = No compression, PNGs and JPEGs expect a value between 0 and 100</summary>
        public unsafe int CompressionQuality {
            get {return UserDefinedImageCaptureProtocol_ptr->CompressionQuality;}
            set {UserDefinedImageCaptureProtocol_ptr->CompressionQuality = value;}
        }
        static UserDefinedImageCaptureProtocol() {
            StaticClass = Main.GetClass("UserDefinedImageCaptureProtocol");
        }
        internal unsafe UserDefinedImageCaptureProtocol_fields* UserDefinedImageCaptureProtocol_ptr => (UserDefinedImageCaptureProtocol_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UserDefinedImageCaptureProtocol(IntPtr p) => UObject.Make<UserDefinedImageCaptureProtocol>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UserDefinedImageCaptureProtocol DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UserDefinedImageCaptureProtocol New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
