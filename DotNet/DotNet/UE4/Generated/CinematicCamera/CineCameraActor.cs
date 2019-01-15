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
using UE4.CinematicCamera.Native;
using UE4.Engine;

namespace UE4.CinematicCamera {
    ///<summary>A CineCameraActor is a CameraActor specialized to work like a cinematic camera.</summary>
    public unsafe partial class CineCameraActor : CameraActor  {

        ///<summary>Returns the CineCameraComponent of this CineCamera</summary>
        public CineCameraComponent GetCineCameraComponent()  => 
            CineCameraActor_methods.GetCineCameraComponent_method.Invoke(ObjPointer);
        ///<summary>Lookat Tracking Settings</summary>
        public unsafe CameraLookatTrackingSettings LookatTrackingSettings {
            get {return CineCameraActor_ptr->LookatTrackingSettings;}
            set {CineCameraActor_ptr->LookatTrackingSettings = value;}
        }
        static CineCameraActor() {
            StaticClass = Main.GetClass("CineCameraActor");
        }
        internal unsafe CineCameraActor_fields* CineCameraActor_ptr => (CineCameraActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CineCameraActor(IntPtr p) => UObject.Make<CineCameraActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CineCameraActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CineCameraActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
