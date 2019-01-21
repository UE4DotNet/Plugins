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
    ///<summary>Frame Grabber Protocol</summary>
    public unsafe partial class FrameGrabberProtocol : MovieSceneImageCaptureProtocolBase  {
        static FrameGrabberProtocol() {
            StaticClass = Main.GetClass("FrameGrabberProtocol");
        }
        internal unsafe FrameGrabberProtocol_fields* FrameGrabberProtocol_ptr => (FrameGrabberProtocol_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FrameGrabberProtocol(IntPtr p) => UObject.Make<FrameGrabberProtocol>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FrameGrabberProtocol DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FrameGrabberProtocol New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
