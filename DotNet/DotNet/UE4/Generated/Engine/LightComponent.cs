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
    ///<summary>Light Component</summary>
    public unsafe partial class LightComponent : LightComponentBase  {

        ///<summary>Set Affect Dynamic Indirect Lighting</summary>
        public void SetAffectDynamicIndirectLighting(bool bNewValue)  => 
            LightComponent_methods.SetAffectDynamicIndirectLighting_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set Affect Translucent Lighting</summary>
        public void SetAffectTranslucentLighting(bool bNewValue)  => 
            LightComponent_methods.SetAffectTranslucentLighting_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set Bloom Scale</summary>
        public void SetBloomScale(float NewValue)  => 
            LightComponent_methods.SetBloomScale_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Bloom Threshold</summary>
        public void SetBloomThreshold(float NewValue)  => 
            LightComponent_methods.SetBloomThreshold_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Bloom Tint</summary>
        public void SetBloomTint(Color NewValue)  => 
            LightComponent_methods.SetBloomTint_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Enable Light Shaft Bloom</summary>
        public void SetEnableLightShaftBloom(bool bNewValue)  => 
            LightComponent_methods.SetEnableLightShaftBloom_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set Force Cached Shadows for Movable Primitives</summary>
        public void SetForceCachedShadowsForMovablePrimitives(bool bNewValue)  => 
            LightComponent_methods.SetForceCachedShadowsForMovablePrimitives_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set IESTexture</summary>
        public void SetIESTexture(TextureLightProfile NewValue)  => 
            LightComponent_methods.SetIESTexture_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Indirect Lighting Intensity</summary>
        public void SetIndirectLightingIntensity(float NewIntensity)  => 
            LightComponent_methods.SetIndirectLightingIntensity_method.Invoke(ObjPointer, NewIntensity);

        ///<summary>Set intensity of the light</summary>
        public void SetIntensity(float NewIntensity)  => 
            LightComponent_methods.SetIntensity_method.Invoke(ObjPointer, NewIntensity);

        ///<summary>Set color of the light</summary>
        public void SetLightColor(LinearColor NewLightColor, bool bSRGB)  => 
            LightComponent_methods.SetLightColor_method.Invoke(ObjPointer, NewLightColor, bSRGB);

        ///<summary>Set Light Function Disabled Brightness</summary>
        public void SetLightFunctionDisabledBrightness(float NewValue)  => 
            LightComponent_methods.SetLightFunctionDisabledBrightness_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Light Function Fade Distance</summary>
        public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)  => 
            LightComponent_methods.SetLightFunctionFadeDistance_method.Invoke(ObjPointer, NewLightFunctionFadeDistance);

        ///<summary>Set Light Function Material</summary>
        public void SetLightFunctionMaterial(MaterialInterface NewLightFunctionMaterial)  => 
            LightComponent_methods.SetLightFunctionMaterial_method.Invoke(ObjPointer, NewLightFunctionMaterial);

        ///<summary>Set Light Function Scale</summary>
        public void SetLightFunctionScale(Vector NewLightFunctionScale)  => 
            LightComponent_methods.SetLightFunctionScale_method.Invoke(ObjPointer, NewLightFunctionScale);

        ///<summary>Set Shadow Bias</summary>
        public void SetShadowBias(float NewValue)  => 
            LightComponent_methods.SetShadowBias_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Temperature</summary>
        public void SetTemperature(float NewTemperature)  => 
            LightComponent_methods.SetTemperature_method.Invoke(ObjPointer, NewTemperature);

        ///<summary>Set Transmission</summary>
        public void SetTransmission(bool bNewValue)  => 
            LightComponent_methods.SetTransmission_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set Volumetric Scattering Intensity</summary>
        public void SetVolumetricScatteringIntensity(float NewIntensity)  => 
            LightComponent_methods.SetVolumetricScatteringIntensity_method.Invoke(ObjPointer, NewIntensity);
        ///<summary>Color temperature in Kelvin of the blackbody illuminant.</summary>
        ///<remarks>White (D65) is 6500K.</remarks>
        public unsafe float Temperature {
            get {return LightComponent_ptr->Temperature;}
        }
        ///<summary>Max Draw Distance</summary>
        public unsafe float MaxDrawDistance {
            get {return LightComponent_ptr->MaxDrawDistance;}
            set {LightComponent_ptr->MaxDrawDistance = value;}
        }
        ///<summary>Max Distance Fade Range</summary>
        public unsafe float MaxDistanceFadeRange {
            get {return LightComponent_ptr->MaxDistanceFadeRange;}
            set {LightComponent_ptr->MaxDistanceFadeRange = value;}
        }
        public bool bUseTemperature {
            get {return Main.GetGetBoolPropertyByName(this, "bUseTemperature"); }
        }
        ///<summary>Multiplier on specular highlights.</summary>
        ///<remarks>
        ///Use only with great care! Any value besides 1 is not physical!
        ///Can be used to artistically remove highlights mimicking polarizing filters or photo touch up.
        ///</remarks>
        public unsafe float SpecularScale {
            get {return LightComponent_ptr->SpecularScale;}
        }
        ///<summary>Scales the resolution of shadowmaps used to shadow this light.</summary>
        ///<remarks>
        ///By default shadowmap resolution is chosen based on screen size of the caster.
        ///Note: shadowmap resolution is still clamped by 'r.Shadow.MaxResolution'
        ///</remarks>
        public unsafe float ShadowResolutionScale {
            get {return LightComponent_ptr->ShadowResolutionScale;}
        }
        ///<summary>Controls how accurate self shadowing of whole scene shadows from this light are.</summary>
        ///<remarks>
        ///At 0, shadows will start at the their caster surface, but there will be many self shadowing artifacts.
        ///larger values, shadows will start further from their caster, and there won't be self shadowing artifacts but object might appear to fly.
        ///around 0.5 seems to be a good tradeoff. This also affects the soft transition of shadows
        ///</remarks>
        public unsafe float ShadowBias {
            get {return LightComponent_ptr->ShadowBias;}
        }
        ///<summary>Amount to sharpen shadow filtering</summary>
        public unsafe float ShadowSharpen {
            get {return LightComponent_ptr->ShadowSharpen;}
        }
        ///<summary>Length of screen space ray trace for sharp contact shadows. Zero is disabled.</summary>
        public unsafe float ContactShadowLength {
            get {return LightComponent_ptr->ContactShadowLength;}
            set {LightComponent_ptr->ContactShadowLength = value;}
        }
        public bool ContactShadowLengthInWS {
            get {return Main.GetGetBoolPropertyByName(this, "ContactShadowLengthInWS"); }
            set {Main.SetGetBoolPropertyByName(this, "ContactShadowLengthInWS", value); }
        }
        public bool CastTranslucentShadows {
            get {return Main.GetGetBoolPropertyByName(this, "CastTranslucentShadows"); }
        }
        public bool bCastShadowsFromCinematicObjectsOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bCastShadowsFromCinematicObjectsOnly"); }
        }
        public bool bAffectDynamicIndirectLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectDynamicIndirectLighting"); }
        }
        public bool bForceCachedShadowsForMovablePrimitives {
            get {return Main.GetGetBoolPropertyByName(this, "bForceCachedShadowsForMovablePrimitives"); }
        }
        ///<summary>Channels that this light should affect.</summary>
        ///<remarks>These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.</remarks>
        public unsafe LightingChannels LightingChannels {
            get {return LightComponent_ptr->LightingChannels;}
        }
        ///<summary>The light function material to be applied to this light.</summary>
        ///<remarks>Note that only non-lightmapped lights (UseDirectLightMap=False) can have a light function.</remarks>
        public unsafe MaterialInterface LightFunctionMaterial {
            get {return LightComponent_ptr->LightFunctionMaterial;}
        }
        ///<summary>Scales the light function projection.  X and Y scale in the directions perpendicular to the light's direction, Z scales along the light direction.</summary>
        public unsafe Vector LightFunctionScale {
            get {return LightComponent_ptr->LightFunctionScale;}
        }
        ///<summary>IES texture (light profiles from real world measured data)</summary>
        public unsafe TextureLightProfile IESTexture {
            get {return LightComponent_ptr->IESTexture;}
        }
        public bool bUseIESBrightness {
            get {return Main.GetGetBoolPropertyByName(this, "bUseIESBrightness"); }
        }
        ///<summary>Global scale for IES brightness contribution. Only available when "Use IES Brightness" is selected, and a valid IES profile texture is set</summary>
        public unsafe float IESBrightnessScale {
            get {return LightComponent_ptr->IESBrightnessScale;}
        }
        ///<summary>Distance at which the light function should be completely faded to DisabledBrightness.</summary>
        ///<remarks>This is useful for hiding aliasing from light functions applied in the distance.</remarks>
        public unsafe float LightFunctionFadeDistance {
            get {return LightComponent_ptr->LightFunctionFadeDistance;}
        }
        ///<summary>Brightness factor applied to the light when the light function is specified but disabled, for example in scene captures that use SceneCapView_LitNoShadows.</summary>
        ///<remarks>This should be set to the average brightness of the light function material's emissive input, which should be between 0 and 1.</remarks>
        public unsafe float DisabledBrightness {
            get {return LightComponent_ptr->DisabledBrightness;}
        }
        public bool bEnableLightShaftBloom {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableLightShaftBloom"); }
        }
        ///<summary>Scales the additive color.</summary>
        public unsafe float BloomScale {
            get {return LightComponent_ptr->BloomScale;}
        }
        ///<summary>Scene color must be larger than this to create bloom in the light shafts.</summary>
        public unsafe float BloomThreshold {
            get {return LightComponent_ptr->BloomThreshold;}
        }
        ///<summary>Multiplies against scene color to create the bloom color.</summary>
        public unsafe Color BloomTint {
            get {return LightComponent_ptr->BloomTint;}
        }
        public bool bUseRayTracedDistanceFieldShadows {
            get {return Main.GetGetBoolPropertyByName(this, "bUseRayTracedDistanceFieldShadows"); }
        }
        ///<summary>Controls how large of an offset ray traced shadows have from the receiving surface as the camera gets further away.</summary>
        ///<remarks>This can be useful to hide self-shadowing artifacts from low resolution distance fields on huge static meshes.</remarks>
        public unsafe float RayStartOffsetDepthScale {
            get {return LightComponent_ptr->RayStartOffsetDepthScale;}
        }
        static LightComponent() {
            StaticClass = Main.GetClass("LightComponent");
        }
        internal unsafe LightComponent_fields* LightComponent_ptr => (LightComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightComponent(IntPtr p) => UObject.Make<LightComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
