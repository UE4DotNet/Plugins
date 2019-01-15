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
    public unsafe partial class SphereReflectionCaptureComponent : ReflectionCaptureComponent  {
        ///<summary>Radius of the area that can receive reflections from this capture.</summary>
        public unsafe float InfluenceRadius {
            get {return SphereReflectionCaptureComponent_ptr->InfluenceRadius;}
            set {SphereReflectionCaptureComponent_ptr->InfluenceRadius = value;}
        }
        ///<summary>Not needed anymore, not yet removed in case the artist setup values are needed in the future</summary>
        public unsafe float CaptureDistanceScale {
            get {return SphereReflectionCaptureComponent_ptr->CaptureDistanceScale;}
            set {SphereReflectionCaptureComponent_ptr->CaptureDistanceScale = value;}
        }
        ///<summary>Preview Influence Radius</summary>
        public unsafe DrawSphereComponent PreviewInfluenceRadius {
            get {return SphereReflectionCaptureComponent_ptr->PreviewInfluenceRadius;}
            set {SphereReflectionCaptureComponent_ptr->PreviewInfluenceRadius = value;}
        }
        static SphereReflectionCaptureComponent() {
            StaticClass = Main.GetClass("SphereReflectionCaptureComponent");
        }
        internal unsafe SphereReflectionCaptureComponent_fields* SphereReflectionCaptureComponent_ptr => (SphereReflectionCaptureComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SphereReflectionCaptureComponent(IntPtr p) => UObject.Make<SphereReflectionCaptureComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SphereReflectionCaptureComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SphereReflectionCaptureComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
