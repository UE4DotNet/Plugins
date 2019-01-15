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
    ///<summary>Aim Offset Blend Space Factory 1D</summary>
    public unsafe partial class AimOffsetBlendSpaceFactory1D : BlendSpaceFactory1D  {
        static AimOffsetBlendSpaceFactory1D() {
            StaticClass = Main.GetClass("AimOffsetBlendSpaceFactory1D");
        }
        internal unsafe AimOffsetBlendSpaceFactory1D_fields* AimOffsetBlendSpaceFactory1D_ptr => (AimOffsetBlendSpaceFactory1D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AimOffsetBlendSpaceFactory1D(IntPtr p) => UObject.Make<AimOffsetBlendSpaceFactory1D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AimOffsetBlendSpaceFactory1D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AimOffsetBlendSpaceFactory1D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
