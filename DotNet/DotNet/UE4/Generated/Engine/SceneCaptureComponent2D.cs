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
    ///<summary>Used to capture a 'snapshot' of the scene from a single plane and feed it to a render target.</summary>
    public unsafe partial class SceneCaptureComponent2D : SceneCaptureComponent  {

        ///<summary>Adds an Blendable (implements IBlendableInterface) to the array of Blendables (if it doesn't exist) and update the weight</summary>
        public void AddOrUpdateBlendable(byte InBlendableObject /*TODO: interface TScriptInterface */, float InWeight)  => 
            SceneCaptureComponent2D_methods.AddOrUpdateBlendable_method.Invoke(ObjPointer, InBlendableObject, InWeight);

        ///<summary>Render the scene to the texture target immediately.</summary>
        ///<remarks>This should not be used if bCaptureEveryFrame is enabled, or the scene capture will render redundantly.</remarks>
        public void CaptureScene()  => 
            SceneCaptureComponent2D_methods.CaptureScene_method.Invoke(ObjPointer);
        ///<summary>Projection Type</summary>
        public unsafe byte ProjectionType {
            get {return SceneCaptureComponent2D_ptr->ProjectionType;}
            set {SceneCaptureComponent2D_ptr->ProjectionType = value;}
        }
        ///<summary>Camera field of view (in degrees).</summary>
        public unsafe float FOVAngle {
            get {return SceneCaptureComponent2D_ptr->FOVAngle;}
            set {SceneCaptureComponent2D_ptr->FOVAngle = value;}
        }
        ///<summary>The desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
        public unsafe float OrthoWidth {
            get {return SceneCaptureComponent2D_ptr->OrthoWidth;}
            set {SceneCaptureComponent2D_ptr->OrthoWidth = value;}
        }
        ///<summary>Output render target of the scene capture that can be read in materals.</summary>
        public unsafe TextureRenderTarget2D TextureTarget {
            get {return SceneCaptureComponent2D_ptr->TextureTarget;}
            set {SceneCaptureComponent2D_ptr->TextureTarget = value;}
        }
        ///<summary>Capture Source</summary>
        public unsafe byte CaptureSource {
            get {return SceneCaptureComponent2D_ptr->CaptureSource;}
            set {SceneCaptureComponent2D_ptr->CaptureSource = value;}
        }
        ///<summary>When enabled, the scene capture will composite into the render target instead of overwriting its contents.</summary>
        public unsafe byte CompositeMode {
            get {return SceneCaptureComponent2D_ptr->CompositeMode;}
            set {SceneCaptureComponent2D_ptr->CompositeMode = value;}
        }
        ///<summary>Post Process Settings</summary>
        public unsafe PostProcessSettings PostProcessSettings {
            get {return SceneCaptureComponent2D_ptr->PostProcessSettings;}
            set {SceneCaptureComponent2D_ptr->PostProcessSettings = value;}
        }
        ///<summary>Range (0.0, 1.0) where 0 indicates no effect, 1 indicates full effect.</summary>
        public unsafe float PostProcessBlendWeight {
            get {return SceneCaptureComponent2D_ptr->PostProcessBlendWeight;}
            set {SceneCaptureComponent2D_ptr->PostProcessBlendWeight = value;}
        }
        public bool bUseCustomProjectionMatrix {
            get {return Main.GetGetBoolPropertyByName(this, "bUseCustomProjectionMatrix"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseCustomProjectionMatrix", value); }
        }
        ///<summary>The custom projection matrix to use</summary>
        public unsafe Matrix CustomProjectionMatrix {
            get {return SceneCaptureComponent2D_ptr->CustomProjectionMatrix;}
            set {SceneCaptureComponent2D_ptr->CustomProjectionMatrix = value;}
        }
        public bool bEnableClipPlane {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableClipPlane"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableClipPlane", value); }
        }
        ///<summary>Base position for the clip plane, can be any position on the plane.</summary>
        public unsafe Vector ClipPlaneBase {
            get {return SceneCaptureComponent2D_ptr->ClipPlaneBase;}
            set {SceneCaptureComponent2D_ptr->ClipPlaneBase = value;}
        }
        ///<summary>Normal for the plane.</summary>
        public unsafe Vector ClipPlaneNormal {
            get {return SceneCaptureComponent2D_ptr->ClipPlaneNormal;}
            set {SceneCaptureComponent2D_ptr->ClipPlaneNormal = value;}
        }
        public bool bCameraCutThisFrame {
            get {return Main.GetGetBoolPropertyByName(this, "bCameraCutThisFrame"); }
            set {Main.SetGetBoolPropertyByName(this, "bCameraCutThisFrame", value); }
        }
        static SceneCaptureComponent2D() {
            StaticClass = Main.GetClass("SceneCaptureComponent2D");
        }
        internal unsafe SceneCaptureComponent2D_fields* SceneCaptureComponent2D_ptr => (SceneCaptureComponent2D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SceneCaptureComponent2D(IntPtr p) => UObject.Make<SceneCaptureComponent2D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SceneCaptureComponent2D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SceneCaptureComponent2D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
