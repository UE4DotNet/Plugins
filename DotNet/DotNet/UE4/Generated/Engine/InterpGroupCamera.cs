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
    ///<summary>Interp Group Camera</summary>
    public unsafe partial class InterpGroupCamera : InterpGroup  {
        ///<summary>Camera Anim Inst</summary>
        public unsafe CameraAnim CameraAnimInst {
            get {return InterpGroupCamera_ptr->CameraAnimInst;}
            set {InterpGroupCamera_ptr->CameraAnimInst = value;}
        }
        ///<summary>this is interaction property info for CameraAnim</summary>
        ///<remarks>this information isn't really saved with it</remarks>
        public unsafe CameraPreviewInfo Target {
            get {return InterpGroupCamera_ptr->Target;}
            set {InterpGroupCamera_ptr->Target = value;}
        }
        ///<summary>When compress, tolerance option *</summary>
        public unsafe float CompressTolerance {
            get {return InterpGroupCamera_ptr->CompressTolerance;}
            set {InterpGroupCamera_ptr->CompressTolerance = value;}
        }
        static InterpGroupCamera() {
            StaticClass = Main.GetClass("InterpGroupCamera");
        }
        internal unsafe InterpGroupCamera_fields* InterpGroupCamera_ptr => (InterpGroupCamera_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpGroupCamera(IntPtr p) => UObject.Make<InterpGroupCamera>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpGroupCamera DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpGroupCamera New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
