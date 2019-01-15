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
using UE4.AppleVision.Native;
using UE4.Engine;

namespace UE4.AppleVision {
    ///<summary>Apple Vision Detect Faces Async Task Blueprint Proxy</summary>
    public unsafe partial class AppleVisionDetectFacesAsyncTaskBlueprintProxy : UObject  {

        ///<summary>
        ///Detects faces within an image
        ///@
        ///</summary>
        ///<remarks>param SourceImage the image to detect faces in</remarks>
        public static AppleVisionDetectFacesAsyncTaskBlueprintProxy CreateProxyObjectForDetectFaces(Texture SourceImage)  => 
            AppleVisionDetectFacesAsyncTaskBlueprintProxy_methods.CreateProxyObjectForDetectFaces_method.Invoke(SourceImage);
         //TODO: multicast delegate FAppleVisionDetectFacesDelegate OnSuccess
         //TODO: multicast delegate FAppleVisionDetectFacesDelegate OnFailure
        ///<summary>Face Detection Result</summary>
        public unsafe FaceDetectionResult FaceDetectionResult {
            get {return AppleVisionDetectFacesAsyncTaskBlueprintProxy_ptr->FaceDetectionResult;}
        }
        static AppleVisionDetectFacesAsyncTaskBlueprintProxy() {
            StaticClass = Main.GetClass("AppleVisionDetectFacesAsyncTaskBlueprintProxy");
        }
        internal unsafe AppleVisionDetectFacesAsyncTaskBlueprintProxy_fields* AppleVisionDetectFacesAsyncTaskBlueprintProxy_ptr => (AppleVisionDetectFacesAsyncTaskBlueprintProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AppleVisionDetectFacesAsyncTaskBlueprintProxy(IntPtr p) => UObject.Make<AppleVisionDetectFacesAsyncTaskBlueprintProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AppleVisionDetectFacesAsyncTaskBlueprintProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AppleVisionDetectFacesAsyncTaskBlueprintProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
