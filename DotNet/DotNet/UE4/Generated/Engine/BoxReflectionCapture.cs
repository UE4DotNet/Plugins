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
    ///<summary>
    ///Actor used to capture the scene for reflection in a box shape
    ///@
    ///</summary>
    ///<remarks>see https://docs.unrealengine.com/latest/INT/Resources/ContentExamples/Reflections/1_3/index.html</remarks>
    public unsafe partial class BoxReflectionCapture : ReflectionCapture  {
        static BoxReflectionCapture() {
            StaticClass = Main.GetClass("BoxReflectionCapture");
        }
        internal unsafe BoxReflectionCapture_fields* BoxReflectionCapture_ptr => (BoxReflectionCapture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BoxReflectionCapture(IntPtr p) => UObject.Make<BoxReflectionCapture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BoxReflectionCapture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BoxReflectionCapture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
