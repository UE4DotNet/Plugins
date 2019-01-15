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
    ///<summary>Blend Space 1D</summary>
    public unsafe partial class BlendSpace1D : BlendSpaceBase  {
        public bool bScaleAnimation {
            get {return Main.GetGetBoolPropertyByName(this, "bScaleAnimation"); }
            set {Main.SetGetBoolPropertyByName(this, "bScaleAnimation", value); }
        }
        static BlendSpace1D() {
            StaticClass = Main.GetClass("BlendSpace1D");
        }
        internal unsafe BlendSpace1D_fields* BlendSpace1D_ptr => (BlendSpace1D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlendSpace1D(IntPtr p) => UObject.Make<BlendSpace1D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlendSpace1D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlendSpace1D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
