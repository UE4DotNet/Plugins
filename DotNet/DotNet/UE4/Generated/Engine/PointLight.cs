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
    ///<summary>Point Light</summary>
    public unsafe partial class PointLight : Light  {

        ///<summary>Set Light Falloff Exponent</summary>
        public void SetLightFalloffExponent(float NewLightFalloffExponent)  => 
            PointLight_methods.SetLightFalloffExponent_method.Invoke(ObjPointer, NewLightFalloffExponent);

        ///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
        public void SetRadius(float NewRadius)  => 
            PointLight_methods.SetRadius_method.Invoke(ObjPointer, NewRadius);
        ///<summary>Point Light Component</summary>
        public unsafe PointLightComponent PointLightComponent {
            get {return PointLight_ptr->PointLightComponent;}
        }
        static PointLight() {
            StaticClass = Main.GetClass("PointLight");
        }
        internal unsafe PointLight_fields* PointLight_ptr => (PointLight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PointLight(IntPtr p) => UObject.Make<PointLight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PointLight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PointLight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
