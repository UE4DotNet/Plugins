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
    ///<summary>A light component which emits light from a single point equally in all directions.</summary>
    public unsafe partial class LocalLightComponent : LightComponent  {

        ///<summary>Get Units Conversion Factor</summary>
        public static float GetUnitsConversionFactor(ELightUnits SrcUnits, ELightUnits TargetUnits, float CosHalfConeAngle)  => 
            LocalLightComponent_methods.GetUnitsConversionFactor_method.Invoke(SrcUnits, TargetUnits, CosHalfConeAngle);

        ///<summary>Set Attenuation Radius</summary>
        public void SetAttenuationRadius(float NewRadius)  => 
            LocalLightComponent_methods.SetAttenuationRadius_method.Invoke(ObjPointer, NewRadius);
         //TODO: enum ELightUnits IntensityUnits
        ///<summary>Bounds the light's visible influence.</summary>
        ///<remarks>This clamping of the light's influence is not physically correct but very important for performance, larger lights cost more.</remarks>
        public unsafe float AttenuationRadius {
            get {return LocalLightComponent_ptr->AttenuationRadius;}
        }
        ///<summary>The Lightmass settings for this object.</summary>
        public unsafe LightmassPointLightSettings LightmassSettings {
            get {return LocalLightComponent_ptr->LightmassSettings;}
            set {LocalLightComponent_ptr->LightmassSettings = value;}
        }
        static LocalLightComponent() {
            StaticClass = Main.GetClass("LocalLightComponent");
        }
        internal unsafe LocalLightComponent_fields* LocalLightComponent_ptr => (LocalLightComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LocalLightComponent(IntPtr p) => UObject.Make<LocalLightComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LocalLightComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LocalLightComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
