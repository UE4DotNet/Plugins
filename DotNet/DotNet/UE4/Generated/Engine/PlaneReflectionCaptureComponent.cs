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
    ///<summary>-> will be exported to EngineDecalClasses.h</summary>
    public unsafe partial class PlaneReflectionCaptureComponent : ReflectionCaptureComponent  {
        ///<summary>Radius of the area that can receive reflections from this capture.</summary>
        public unsafe float InfluenceRadiusScale {
            get {return PlaneReflectionCaptureComponent_ptr->InfluenceRadiusScale;}
            set {PlaneReflectionCaptureComponent_ptr->InfluenceRadiusScale = value;}
        }
        ///<summary>Preview Influence Radius</summary>
        public unsafe DrawSphereComponent PreviewInfluenceRadius {
            get {return PlaneReflectionCaptureComponent_ptr->PreviewInfluenceRadius;}
            set {PlaneReflectionCaptureComponent_ptr->PreviewInfluenceRadius = value;}
        }
        ///<summary>Preview Capture Box</summary>
        public unsafe BoxComponent PreviewCaptureBox {
            get {return PlaneReflectionCaptureComponent_ptr->PreviewCaptureBox;}
            set {PlaneReflectionCaptureComponent_ptr->PreviewCaptureBox = value;}
        }
        static PlaneReflectionCaptureComponent() {
            StaticClass = Main.GetClass("PlaneReflectionCaptureComponent");
        }
        internal unsafe PlaneReflectionCaptureComponent_fields* PlaneReflectionCaptureComponent_ptr => (PlaneReflectionCaptureComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlaneReflectionCaptureComponent(IntPtr p) => UObject.Make<PlaneReflectionCaptureComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlaneReflectionCaptureComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlaneReflectionCaptureComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
