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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Used to capture a 'snapshot' of the scene from a 6 planes and feed it to a render target.</summary>
    public unsafe partial class SceneCaptureComponentCube : SceneCaptureComponent  {

        ///<summary>Render the scene to the texture target immediately.</summary>
        ///<remarks>This should not be used if bCaptureEveryFrame is enabled, or the scene capture will render redundantly.</remarks>
        public void CaptureScene()  => 
            SceneCaptureComponentCube_methods.CaptureScene_method.Invoke(ObjPointer);
        ///<summary>Temporary render target that can be used by the editor.</summary>
        public unsafe TextureRenderTargetCube TextureTarget {
            get {return SceneCaptureComponentCube_ptr->TextureTarget;}
            set {SceneCaptureComponentCube_ptr->TextureTarget = value;}
        }
        ///<summary>
        ///Omni-directional Stereo Capture
        ///If vr.
        ///</summary>
        ///<remarks>
        ///ODSCapture is enabled and both left, right and ODS render targets are set,
        ///we'll ignore the texture target and instead do an omni-directional stereo capture.
        ///Warped cube maps will be rendered into the left and right texture targets using the
        ///IPD property for stereo offset. We will then reconstruct a stereo lat-long with the left
        ///eye stacked on top of the right eye in the ODS target.
        ///See: https://developers.google.com/vr/jump/rendering-ods-content.pdf
        ///</remarks>
        public unsafe TextureRenderTargetCube TextureTargetLeft {
            get {return SceneCaptureComponentCube_ptr->TextureTargetLeft;}
            set {SceneCaptureComponentCube_ptr->TextureTargetLeft = value;}
        }
        ///<summary>Texture Target Right</summary>
        public unsafe TextureRenderTargetCube TextureTargetRight {
            get {return SceneCaptureComponentCube_ptr->TextureTargetRight;}
            set {SceneCaptureComponentCube_ptr->TextureTargetRight = value;}
        }
        ///<summary>Texture Target ODS</summary>
        public unsafe TextureRenderTarget2D TextureTargetODS {
            get {return SceneCaptureComponentCube_ptr->TextureTargetODS;}
            set {SceneCaptureComponentCube_ptr->TextureTargetODS = value;}
        }
        ///<summary>IPD</summary>
        public unsafe float IPD {
            get {return SceneCaptureComponentCube_ptr->IPD;}
            set {SceneCaptureComponentCube_ptr->IPD = value;}
        }
        static SceneCaptureComponentCube() {
            StaticClass = Main.GetClass("SceneCaptureComponentCube");
        }
        internal unsafe SceneCaptureComponentCube_fields* SceneCaptureComponentCube_ptr => (SceneCaptureComponentCube_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SceneCaptureComponentCube(IntPtr p) => UObject.Make<SceneCaptureComponentCube>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SceneCaptureComponentCube DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SceneCaptureComponentCube New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
