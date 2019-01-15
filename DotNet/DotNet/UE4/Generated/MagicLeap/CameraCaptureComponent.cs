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
using UE4.MagicLeap.Native;
using UE4.Engine;

namespace UE4.MagicLeap {
    ///<summary>The CameraCaptureComponent provides access to and maintains state for camera capture functionality.</summary>
    ///<remarks>
    ///The connection to the device's camera is managed internally.  Users of this component
    ///are able to asynchronously capture camera images and footage to file.  Alternatively,
    ///a camera image can be captured directly to texture.  The user need only make the relevant
    ///asynchronous call and then register the appropriate success/fail event handlers for the
    ///operation's completion.
    ///</remarks>
    public unsafe partial class CameraCaptureComponent : ActorComponent  {

        ///<summary>Instigates a capture image to file task on a separate thread.</summary>
        ///<remarks>
        ///@brief The newly created jpeg file will have an automatically generated name which is guaranteed
        ///           to be unique.  The user should register event handlers for both the success and fail events.
        ///           Upon completion, a successful operation will provide the file path of the newly created jpeg
        ///           to the FCameraCaptureImgToFileSuccess event handler.
        ///</remarks>
        public bool CaptureImageToFileAsync()  => 
            CameraCaptureComponent_methods.CaptureImageToFileAsync_method.Invoke(ObjPointer);

        ///<summary>Instigates a capture image to memory task on a speparate thread.</summary>
        ///<remarks>
        ///@brief The user should register event handlers for both the success and fail events.  Upon completion,
        ///              a successful operation will provide a dynamically generated texture containing the captured
        ///              image to the FCameraCaptureImgToTextureSuccess event handler.
        ///@note The generated texture will be garbage collected when this class is destroyed.
        ///</remarks>
        public bool CaptureImageToTextureAsync()  => 
            CameraCaptureComponent_methods.CaptureImageToTextureAsync_method.Invoke(ObjPointer);

        ///<summary>Instigates a capture video to file task on a separate thread.</summary>
        ///<remarks>
        ///@brief The newly created mp4 file will have an automatically generated name which is guaranteed
        ///              to be unique.  The user should register event handlers for both the success and fail events.
        ///              Upon completion, a successful operation will provide the file path of the saved mp4 file to the
        ///              FCameraCaptureVidToFileSuccess event handler.
        ///   @param VideoLength The length in seconds of the footage to be captured.
        ///</remarks>
        public bool CaptureVideoToFileAsync(float VideoLength)  => 
            CameraCaptureComponent_methods.CaptureVideoToFileAsync_method.Invoke(ObjPointer, VideoLength);
         //TODO: multicast delegate FCameraCaptureLogMessage CaptureLogMessage
         //TODO: multicast delegate FCameraCaptureImgToFileSuccess CaptureImgToFileSuccess
         //TODO: multicast delegate FCameraCaptureImgToFileFailure CaptureImgToFileFailure
         //TODO: multicast delegate FCameraCaptureImgToTextureSuccess CaptureImgToTextureSuccess
         //TODO: multicast delegate FCameraCaptureImgToTextureFailure CaptureImgToTextureFailure
         //TODO: multicast delegate FCameraCaptureVidToFileSuccess CaptureVidToFileSuccess
         //TODO: multicast delegate FCameraCaptureVidToFileFailure CaptureVidToFileFailure
        static CameraCaptureComponent() {
            StaticClass = Main.GetClass("CameraCaptureComponent");
        }
        internal unsafe CameraCaptureComponent_fields* CameraCaptureComponent_ptr => (CameraCaptureComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraCaptureComponent(IntPtr p) => UObject.Make<CameraCaptureComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraCaptureComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraCaptureComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
