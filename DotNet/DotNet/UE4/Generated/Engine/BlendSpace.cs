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
    ///<summary>Contains a grid of data points with weights from sample points in the space</summary>
    public unsafe partial class BlendSpace : BlendSpaceBase  {
        ///<summary>If you have input interpolation, which axis to drive animation speed (scale) - i.e. for locomotion animation, speed axis will drive animation speed (thus scale)*</summary>
        public unsafe byte AxisToScaleAnimation {
            get {return BlendSpace_ptr->AxisToScaleAnimation;}
            set {BlendSpace_ptr->AxisToScaleAnimation = value;}
        }
        static BlendSpace() {
            StaticClass = Main.GetClass("BlendSpace");
        }
        internal unsafe BlendSpace_fields* BlendSpace_ptr => (BlendSpace_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlendSpace(IntPtr p) => UObject.Make<BlendSpace>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlendSpace DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlendSpace New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
