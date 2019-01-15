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
using UE4.MagicLeapEmulator.Native;
using UE4.Engine;

namespace UE4.MagicLeapEmulator {
    ///<summary>CameraModifier used to inject postprocess blending for the ML emulator.</summary>
    public unsafe partial class EmulatorCameraModifier : CameraModifier  {
        ///<summary>Compositing Mat Inst</summary>
        public unsafe MaterialInstanceDynamic CompositingMatInst {
            get {return EmulatorCameraModifier_ptr->CompositingMatInst;}
            set {EmulatorCameraModifier_ptr->CompositingMatInst = value;}
        }
        static EmulatorCameraModifier() {
            StaticClass = Main.GetClass("EmulatorCameraModifier");
        }
        internal unsafe EmulatorCameraModifier_fields* EmulatorCameraModifier_ptr => (EmulatorCameraModifier_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EmulatorCameraModifier(IntPtr p) => UObject.Make<EmulatorCameraModifier>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EmulatorCameraModifier DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EmulatorCameraModifier New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
