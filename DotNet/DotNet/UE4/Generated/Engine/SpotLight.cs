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
    ///<summary>Spot Light</summary>
    public unsafe partial class SpotLight : Light  {

        ///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
        public void SetInnerConeAngle(float NewInnerConeAngle)  => 
            SpotLight_methods.SetInnerConeAngle_method.Invoke(ObjPointer, NewInnerConeAngle);

        ///<summary>Set Outer Cone Angle</summary>
        public void SetOuterConeAngle(float NewOuterConeAngle)  => 
            SpotLight_methods.SetOuterConeAngle_method.Invoke(ObjPointer, NewOuterConeAngle);
        ///<summary>Spot Light Component</summary>
        public unsafe SpotLightComponent SpotLightComponent {
            get {return SpotLight_ptr->SpotLightComponent;}
        }
        ///<summary>Arrow Component</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return SpotLight_ptr->ArrowComponent;}
            set {SpotLight_ptr->ArrowComponent = value;}
        }
        static SpotLight() {
            StaticClass = Main.GetClass("SpotLight");
        }
        internal unsafe SpotLight_fields* SpotLight_ptr => (SpotLight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SpotLight(IntPtr p) => UObject.Make<SpotLight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SpotLight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SpotLight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
