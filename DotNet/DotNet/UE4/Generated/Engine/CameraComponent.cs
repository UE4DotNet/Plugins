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
    ///<summary>Represents a camera viewpoint and settings, such as projection type, field of view, and post-process overrides.</summary>
    ///<remarks>The default behavior for an actor used as the camera view target is to look for an attached camera component and use its location, rotation, and settings.</remarks>
    public unsafe partial class CameraComponent : SceneComponent  {

        ///<summary>Adds an Blendable (implements IBlendableInterface) to the array of Blendables (if it doesn't exist) and update the weight</summary>
        public void AddOrUpdateBlendable(byte InBlendableObject /*TODO: interface TScriptInterface */, float InWeight)  => 
            CameraComponent_methods.AddOrUpdateBlendable_method.Invoke(ObjPointer, InBlendableObject, InWeight);

        ///<summary>Returns camera's Point of View.</summary>
        ///<remarks>Called by Camera class. Subclass and postprocess to add any effects.</remarks>
        public MinimalViewInfo GetCameraView(float DeltaTime)  => 
            CameraComponent_methods.GetCameraView_method.Invoke(ObjPointer, DeltaTime);

        ///<summary>Removes a blendable.</summary>
        public void RemoveBlendable(byte InBlendableObject /*TODO: interface TScriptInterface */)  => 
            CameraComponent_methods.RemoveBlendable_method.Invoke(ObjPointer, InBlendableObject);

        ///<summary>Set Aspect Ratio</summary>
        public void SetAspectRatio(float InAspectRatio)  => 
            CameraComponent_methods.SetAspectRatio_method.Invoke(ObjPointer, InAspectRatio);

        ///<summary>Set Constraint Aspect Ratio</summary>
        public void SetConstraintAspectRatio(bool bInConstrainAspectRatio)  => 
            CameraComponent_methods.SetConstraintAspectRatio_method.Invoke(ObjPointer, bInConstrainAspectRatio);

        ///<summary>Set Field Of View</summary>
        public void SetFieldOfView(float InFieldOfView)  => 
            CameraComponent_methods.SetFieldOfView_method.Invoke(ObjPointer, InFieldOfView);

        ///<summary>Set Ortho Far Clip Plane</summary>
        public void SetOrthoFarClipPlane(float InOrthoFarClipPlane)  => 
            CameraComponent_methods.SetOrthoFarClipPlane_method.Invoke(ObjPointer, InOrthoFarClipPlane);

        ///<summary>Set Ortho Near Clip Plane</summary>
        public void SetOrthoNearClipPlane(float InOrthoNearClipPlane)  => 
            CameraComponent_methods.SetOrthoNearClipPlane_method.Invoke(ObjPointer, InOrthoNearClipPlane);

        ///<summary>Set Ortho Width</summary>
        public void SetOrthoWidth(float InOrthoWidth)  => 
            CameraComponent_methods.SetOrthoWidth_method.Invoke(ObjPointer, InOrthoWidth);

        ///<summary>Set Post Process Blend Weight</summary>
        public void SetPostProcessBlendWeight(float InPostProcessBlendWeight)  => 
            CameraComponent_methods.SetPostProcessBlendWeight_method.Invoke(ObjPointer, InPostProcessBlendWeight);

        ///<summary>Set Projection Mode</summary>
        public void SetProjectionMode(byte InProjectionMode)  => 
            CameraComponent_methods.SetProjectionMode_method.Invoke(ObjPointer, InProjectionMode);

        ///<summary>Set Use Field Of View for LOD</summary>
        public void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD)  => 
            CameraComponent_methods.SetUseFieldOfViewForLOD_method.Invoke(ObjPointer, bInUseFieldOfViewForLOD);
        ///<summary>The horizontal field of view (in degrees) in perspective mode (ignored in Orthographic mode)</summary>
        public unsafe float FieldOfView {
            get {return CameraComponent_ptr->FieldOfView;}
            set {CameraComponent_ptr->FieldOfView = value;}
        }
        ///<summary>The desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
        public unsafe float OrthoWidth {
            get {return CameraComponent_ptr->OrthoWidth;}
            set {CameraComponent_ptr->OrthoWidth = value;}
        }
        ///<summary>The near plane distance of the orthographic view (in world units)</summary>
        public unsafe float OrthoNearClipPlane {
            get {return CameraComponent_ptr->OrthoNearClipPlane;}
            set {CameraComponent_ptr->OrthoNearClipPlane = value;}
        }
        ///<summary>The far plane distance of the orthographic view (in world units)</summary>
        public unsafe float OrthoFarClipPlane {
            get {return CameraComponent_ptr->OrthoFarClipPlane;}
            set {CameraComponent_ptr->OrthoFarClipPlane = value;}
        }
        ///<summary>Aspect Ratio (Width/Height)</summary>
        public unsafe float AspectRatio {
            get {return CameraComponent_ptr->AspectRatio;}
            set {CameraComponent_ptr->AspectRatio = value;}
        }
        public bool bConstrainAspectRatio {
            get {return Main.GetGetBoolPropertyByName(this, "bConstrainAspectRatio"); }
            set {Main.SetGetBoolPropertyByName(this, "bConstrainAspectRatio", value); }
        }
        public bool bUseFieldOfViewForLOD {
            get {return Main.GetGetBoolPropertyByName(this, "bUseFieldOfViewForLOD"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseFieldOfViewForLOD", value); }
        }
        public bool bLockToHmd {
            get {return Main.GetGetBoolPropertyByName(this, "bLockToHmd"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockToHmd", value); }
        }
        public bool bUsePawnControlRotation {
            get {return Main.GetGetBoolPropertyByName(this, "bUsePawnControlRotation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsePawnControlRotation", value); }
        }
        ///<summary>The type of camera</summary>
        public unsafe byte ProjectionMode {
            get {return CameraComponent_ptr->ProjectionMode;}
            set {CameraComponent_ptr->ProjectionMode = value;}
        }
        ///<summary>Camera Mesh</summary>
        public unsafe StaticMesh CameraMesh {
            get {return CameraComponent_ptr->CameraMesh;}
            set {CameraComponent_ptr->CameraMesh = value;}
        }
        ///<summary>Indicates if PostProcessSettings should be used when using this Camera to view through.</summary>
        public unsafe float PostProcessBlendWeight {
            get {return CameraComponent_ptr->PostProcessBlendWeight;}
            set {CameraComponent_ptr->PostProcessBlendWeight = value;}
        }
        ///<summary>Post process settings to use for this camera. Don't forget to check the properties you want to override</summary>
        public unsafe PostProcessSettings PostProcessSettings {
            get {return CameraComponent_ptr->PostProcessSettings;}
            set {CameraComponent_ptr->PostProcessSettings = value;}
        }
        static CameraComponent() {
            StaticClass = Main.GetClass("CameraComponent");
        }
        internal unsafe CameraComponent_fields* CameraComponent_ptr => (CameraComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraComponent(IntPtr p) => UObject.Make<CameraComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
