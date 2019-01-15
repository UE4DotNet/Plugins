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
    ///<summary>A spot light component emits a directional cone shaped light (Eg a Torch).</summary>
    public unsafe partial class SpotLightComponent : PointLightComponent  {

        ///<summary>Set Inner Cone Angle</summary>
        public void SetInnerConeAngle(float NewInnerConeAngle)  => 
            SpotLightComponent_methods.SetInnerConeAngle_method.Invoke(ObjPointer, NewInnerConeAngle);

        ///<summary>Set Outer Cone Angle</summary>
        public void SetOuterConeAngle(float NewOuterConeAngle)  => 
            SpotLightComponent_methods.SetOuterConeAngle_method.Invoke(ObjPointer, NewOuterConeAngle);
        ///<summary>Degrees.</summary>
        public unsafe float InnerConeAngle {
            get {return SpotLightComponent_ptr->InnerConeAngle;}
        }
        ///<summary>Degrees.</summary>
        public unsafe float OuterConeAngle {
            get {return SpotLightComponent_ptr->OuterConeAngle;}
        }
        ///<summary>EditAnywhere, BlueprintReadOnly, Category=LightShaft, meta=(UIMin = "1.0", UIMax = "180.0")</summary>
        public unsafe float LightShaftConeAngle {
            get {return SpotLightComponent_ptr->LightShaftConeAngle;}
            set {SpotLightComponent_ptr->LightShaftConeAngle = value;}
        }
        static SpotLightComponent() {
            StaticClass = Main.GetClass("SpotLightComponent");
        }
        internal unsafe SpotLightComponent_fields* SpotLightComponent_ptr => (SpotLightComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SpotLightComponent(IntPtr p) => UObject.Make<SpotLightComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SpotLightComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SpotLightComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
