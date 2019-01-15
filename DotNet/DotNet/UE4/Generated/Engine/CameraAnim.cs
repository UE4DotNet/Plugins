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
    ///<summary>A predefined animation to be played on a camera</summary>
    public unsafe partial class CameraAnim : UObject  {
        ///<summary>The UInterpGroup that holds our actual interpolation data.</summary>
        public unsafe InterpGroup CameraInterpGroup {
            get {return CameraAnim_ptr->CameraInterpGroup;}
            set {CameraAnim_ptr->CameraInterpGroup = value;}
        }
        ///<summary>This is to preview and they only exists in editor</summary>
        public unsafe InterpGroup PreviewInterpGroup {
            get {return CameraAnim_ptr->PreviewInterpGroup;}
            set {CameraAnim_ptr->PreviewInterpGroup = value;}
        }
        ///<summary>Length, in seconds.</summary>
        public unsafe float AnimLength {
            get {return CameraAnim_ptr->AnimLength;}
            set {CameraAnim_ptr->AnimLength = value;}
        }
        ///<summary>AABB in local space.</summary>
        public unsafe Box BoundingBox {
            get {return CameraAnim_ptr->BoundingBox;}
            set {CameraAnim_ptr->BoundingBox = value;}
        }
        public bool bRelativeToInitialTransform {
            get {return Main.GetGetBoolPropertyByName(this, "bRelativeToInitialTransform"); }
            set {Main.SetGetBoolPropertyByName(this, "bRelativeToInitialTransform", value); }
        }
        public bool bRelativeToInitialFOV {
            get {return Main.GetGetBoolPropertyByName(this, "bRelativeToInitialFOV"); }
            set {Main.SetGetBoolPropertyByName(this, "bRelativeToInitialFOV", value); }
        }
        ///<summary>The base FOV that all FOV keys are relative to.</summary>
        public unsafe float BaseFOV {
            get {return CameraAnim_ptr->BaseFOV;}
            set {CameraAnim_ptr->BaseFOV = value;}
        }
        ///<summary>Default PP settings to put on the animated camera. For modifying PP without keyframes.</summary>
        public unsafe PostProcessSettings BasePostProcessSettings {
            get {return CameraAnim_ptr->BasePostProcessSettings;}
            set {CameraAnim_ptr->BasePostProcessSettings = value;}
        }
        ///<summary>Default PP blend weight to put on the animated camera. For modifying PP without keyframes.</summary>
        public unsafe float BasePostProcessBlendWeight {
            get {return CameraAnim_ptr->BasePostProcessBlendWeight;}
            set {CameraAnim_ptr->BasePostProcessBlendWeight = value;}
        }
        static CameraAnim() {
            StaticClass = Main.GetClass("CameraAnim");
        }
        internal unsafe CameraAnim_fields* CameraAnim_ptr => (CameraAnim_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraAnim(IntPtr p) => UObject.Make<CameraAnim>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraAnim DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraAnim New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
