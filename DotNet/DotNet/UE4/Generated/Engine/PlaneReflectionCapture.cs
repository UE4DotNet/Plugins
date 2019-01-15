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
    ///<summary>Plane Reflection Capture</summary>
    public unsafe partial class PlaneReflectionCapture : ReflectionCapture  {
        static PlaneReflectionCapture() {
            StaticClass = Main.GetClass("PlaneReflectionCapture");
        }
        internal unsafe PlaneReflectionCapture_fields* PlaneReflectionCapture_ptr => (PlaneReflectionCapture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlaneReflectionCapture(IntPtr p) => UObject.Make<PlaneReflectionCapture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlaneReflectionCapture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlaneReflectionCapture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
