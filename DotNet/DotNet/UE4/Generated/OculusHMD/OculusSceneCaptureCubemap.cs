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
using UE4.OculusHMD.Native;
using UE4.Engine;

namespace UE4.OculusHMD {
    ///<summary>Oculus Scene Capture Cubemap</summary>
    public unsafe partial class OculusSceneCaptureCubemap : UObject  {
        ///<summary>Capture Components</summary>
        public ObjectArrayField<SceneCaptureComponent2D> CaptureComponents{ get {
            if(CaptureComponents_store == null) CaptureComponents_store = new ObjectArrayField<SceneCaptureComponent2D> (&OculusSceneCaptureCubemap_ptr->CaptureComponents);
            return CaptureComponents_store;
        } }
        private ObjectArrayField<SceneCaptureComponent2D> CaptureComponents_store;

        static OculusSceneCaptureCubemap() {
            StaticClass = Main.GetClass("OculusSceneCaptureCubemap");
        }
        internal unsafe OculusSceneCaptureCubemap_fields* OculusSceneCaptureCubemap_ptr => (OculusSceneCaptureCubemap_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OculusSceneCaptureCubemap(IntPtr p) => UObject.Make<OculusSceneCaptureCubemap>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OculusSceneCaptureCubemap DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OculusSceneCaptureCubemap New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
