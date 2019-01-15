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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Actor Factory Plane Reflection Capture</summary>
    public unsafe partial class ActorFactoryPlaneReflectionCapture : ActorFactory  {
        static ActorFactoryPlaneReflectionCapture() {
            StaticClass = Main.GetClass("ActorFactoryPlaneReflectionCapture");
        }
        internal unsafe ActorFactoryPlaneReflectionCapture_fields* ActorFactoryPlaneReflectionCapture_ptr => (ActorFactoryPlaneReflectionCapture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ActorFactoryPlaneReflectionCapture(IntPtr p) => UObject.Make<ActorFactoryPlaneReflectionCapture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ActorFactoryPlaneReflectionCapture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ActorFactoryPlaneReflectionCapture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
