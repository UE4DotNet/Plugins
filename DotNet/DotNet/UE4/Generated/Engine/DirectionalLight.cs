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
    ///<summary>Implements a directional light actor.</summary>
    public unsafe partial class DirectionalLight : Light  {
        ///<summary>Arrow Component</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return DirectionalLight_ptr->ArrowComponent;}
            set {DirectionalLight_ptr->ArrowComponent = value;}
        }
        static DirectionalLight() {
            StaticClass = Main.GetClass("DirectionalLight");
        }
        internal unsafe DirectionalLight_fields* DirectionalLight_ptr => (DirectionalLight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DirectionalLight(IntPtr p) => UObject.Make<DirectionalLight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DirectionalLight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DirectionalLight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
