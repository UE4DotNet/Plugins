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
    ///<summary>Actor used to capture the scene for reflection in a sphere shape.</summary>
    ///<remarks>
    ///@see https://docs.unrealengine.com/latest/INT/Resources/ContentExamples/Reflections/1_4
    ///</remarks>
    public unsafe partial class SphereReflectionCapture : ReflectionCapture  {
        ///<summary>Sphere component used to visualize the capture radius</summary>
        public unsafe DrawSphereComponent DrawCaptureRadius {
            get {return SphereReflectionCapture_ptr->DrawCaptureRadius;}
            set {SphereReflectionCapture_ptr->DrawCaptureRadius = value;}
        }
        static SphereReflectionCapture() {
            StaticClass = Main.GetClass("SphereReflectionCapture");
        }
        internal unsafe SphereReflectionCapture_fields* SphereReflectionCapture_ptr => (SphereReflectionCapture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SphereReflectionCapture(IntPtr p) => UObject.Make<SphereReflectionCapture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SphereReflectionCapture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SphereReflectionCapture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
