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
    ///<summary>Aim Offset Blend Space 1D</summary>
    public unsafe partial class AimOffsetBlendSpace1D : BlendSpace1D  {
        static AimOffsetBlendSpace1D() {
            StaticClass = Main.GetClass("AimOffsetBlendSpace1D");
        }
        internal unsafe AimOffsetBlendSpace1D_fields* AimOffsetBlendSpace1D_ptr => (AimOffsetBlendSpace1D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AimOffsetBlendSpace1D(IntPtr p) => UObject.Make<AimOffsetBlendSpace1D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AimOffsetBlendSpace1D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AimOffsetBlendSpace1D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
