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
    ///<summary>Reflection Capture</summary>
    public unsafe partial class ReflectionCapture : Actor  {
        ///<summary>Reflection capture component.</summary>
        public unsafe ReflectionCaptureComponent CaptureComponent {
            get {return ReflectionCapture_ptr->CaptureComponent;}
        }
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return ReflectionCapture_ptr->SpriteComponent;}
            set {ReflectionCapture_ptr->SpriteComponent = value;}
        }
        ///<summary>Capture Offset Component</summary>
        public unsafe BillboardComponent CaptureOffsetComponent {
            get {return ReflectionCapture_ptr->CaptureOffsetComponent;}
            set {ReflectionCapture_ptr->CaptureOffsetComponent = value;}
        }
        static ReflectionCapture() {
            StaticClass = Main.GetClass("ReflectionCapture");
        }
        internal unsafe ReflectionCapture_fields* ReflectionCapture_ptr => (ReflectionCapture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ReflectionCapture(IntPtr p) => UObject.Make<ReflectionCapture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ReflectionCapture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ReflectionCapture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
