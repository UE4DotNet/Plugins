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
    ///<summary>Scene Capture 2D</summary>
    public unsafe partial class SceneCapture2D : SceneCapture  {

        ///<summary>On Interp Toggle</summary>
        public void OnInterpToggle(bool bEnable)  => 
            SceneCapture2D_methods.OnInterpToggle_method.Invoke(ObjPointer, bEnable);
        ///<summary>Scene capture component.</summary>
        public unsafe SceneCaptureComponent2D CaptureComponent2D {
            get {return SceneCapture2D_ptr->CaptureComponent2D;}
        }
        ///<summary>To allow drawing the camera frustum in the editor.</summary>
        public unsafe DrawFrustumComponent DrawFrustum {
            get {return SceneCapture2D_ptr->DrawFrustum;}
            set {SceneCapture2D_ptr->DrawFrustum = value;}
        }
        static SceneCapture2D() {
            StaticClass = Main.GetClass("SceneCapture2D");
        }
        internal unsafe SceneCapture2D_fields* SceneCapture2D_ptr => (SceneCapture2D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SceneCapture2D(IntPtr p) => UObject.Make<SceneCapture2D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SceneCapture2D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SceneCapture2D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
