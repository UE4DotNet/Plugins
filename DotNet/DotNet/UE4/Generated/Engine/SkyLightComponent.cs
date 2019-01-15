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
    ///<summary>Sky Light Component</summary>
    public unsafe partial class SkyLightComponent : LightComponentBase  {

        ///<summary>Recaptures the scene for the skylight.</summary>
        ///<remarks>
        ///This is useful for making sure the sky light is up to date after changing something in the world that it would capture.
        ///Warning: this is very costly and will definitely cause a hitch.
        ///</remarks>
        public void RecaptureSky()  => 
            SkyLightComponent_methods.RecaptureSky_method.Invoke(ObjPointer);

        ///<summary>Sets the cubemap used when SourceType is set to SpecifiedCubemap, and causes a skylight update on the next tick.</summary>
        public void SetCubemap(TextureCube NewCubemap)  => 
            SkyLightComponent_methods.SetCubemap_method.Invoke(ObjPointer, NewCubemap);

        ///<summary>Creates sky lighting from a blend between two cubemaps, which is only valid when SourceType is set to SpecifiedCubemap.</summary>
        ///<remarks>
        ///This can be used to seamlessly transition sky lighting between different times of day.
        ///The caller should continue to update the blend until BlendFraction is 0 or 1 to reduce rendering cost.
        ///The caller is responsible for avoiding pops due to changing the source or destination.
        ///</remarks>
        public void SetCubemapBlend(TextureCube SourceCubemap, TextureCube DestinationCubemap, float InBlendFraction)  => 
            SkyLightComponent_methods.SetCubemapBlend_method.Invoke(ObjPointer, SourceCubemap, DestinationCubemap, InBlendFraction);

        ///<summary>Set Indirect Lighting Intensity</summary>
        public void SetIndirectLightingIntensity(float NewIntensity)  => 
            SkyLightComponent_methods.SetIndirectLightingIntensity_method.Invoke(ObjPointer, NewIntensity);

        ///<summary>Set Intensity</summary>
        public void SetIntensity(float NewIntensity)  => 
            SkyLightComponent_methods.SetIntensity_method.Invoke(ObjPointer, NewIntensity);

        ///<summary>Set color of the light</summary>
        public void SetLightColor(LinearColor NewLightColor)  => 
            SkyLightComponent_methods.SetLightColor_method.Invoke(ObjPointer, NewLightColor);

        ///<summary>Set Lower Hemisphere Color</summary>
        public void SetLowerHemisphereColor(LinearColor InLowerHemisphereColor)  => 
            SkyLightComponent_methods.SetLowerHemisphereColor_method.Invoke(ObjPointer, InLowerHemisphereColor);

        ///<summary>Set Min Occlusion</summary>
        public void SetMinOcclusion(float InMinOcclusion)  => 
            SkyLightComponent_methods.SetMinOcclusion_method.Invoke(ObjPointer, InMinOcclusion);

        ///<summary>Set Occlusion Contrast</summary>
        public void SetOcclusionContrast(float InOcclusionContrast)  => 
            SkyLightComponent_methods.SetOcclusionContrast_method.Invoke(ObjPointer, InOcclusionContrast);

        ///<summary>Set Occlusion Exponent</summary>
        public void SetOcclusionExponent(float InOcclusionExponent)  => 
            SkyLightComponent_methods.SetOcclusionExponent_method.Invoke(ObjPointer, InOcclusionExponent);

        ///<summary>Set Occlusion Tint</summary>
        public void SetOcclusionTint(Color InTint)  => 
            SkyLightComponent_methods.SetOcclusionTint_method.Invoke(ObjPointer, InTint);

        ///<summary>Set Volumetric Scattering Intensity</summary>
        public void SetVolumetricScatteringIntensity(float NewIntensity)  => 
            SkyLightComponent_methods.SetVolumetricScatteringIntensity_method.Invoke(ObjPointer, NewIntensity);
        ///<summary>Indicates where to get the light contribution from.</summary>
        public unsafe byte SourceType {
            get {return SkyLightComponent_ptr->SourceType;}
        }
        ///<summary>Cubemap to use for sky lighting if SourceType is set to SLS_SpecifiedCubemap.</summary>
        public unsafe TextureCube Cubemap {
            get {return SkyLightComponent_ptr->Cubemap;}
        }
        ///<summary>Angle to rotate the source cubemap when SourceType is set to SLS_SpecifiedCubemap.</summary>
        public unsafe float SourceCubemapAngle {
            get {return SkyLightComponent_ptr->SourceCubemapAngle;}
        }
        ///<summary>Maximum resolution for the very top processed cubemap mip. Must be a power of 2.</summary>
        public unsafe int CubemapResolution {
            get {return SkyLightComponent_ptr->CubemapResolution;}
        }
        ///<summary>Distance from the sky light at which any geometry should be treated as part of the sky.</summary>
        ///<remarks>This is also used by reflection captures, so update reflection captures to see the impact.</remarks>
        public unsafe float SkyDistanceThreshold {
            get {return SkyLightComponent_ptr->SkyDistanceThreshold;}
        }
        public bool bCaptureEmissiveOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bCaptureEmissiveOnly"); }
        }
        public bool bLowerHemisphereIsBlack {
            get {return Main.GetGetBoolPropertyByName(this, "bLowerHemisphereIsBlack"); }
        }
        ///<summary>Lower Hemisphere Color</summary>
        public unsafe LinearColor LowerHemisphereColor {
            get {return SkyLightComponent_ptr->LowerHemisphereColor;}
        }
        ///<summary>Max distance that the occlusion of one point will affect another.</summary>
        ///<remarks>Higher values increase the cost of Distance Field AO exponentially.</remarks>
        public unsafe float OcclusionMaxDistance {
            get {return SkyLightComponent_ptr->OcclusionMaxDistance;}
        }
        ///<summary>Contrast S-curve applied to the computed AO.  A value of 0 means no contrast increase, 1 is a significant contrast increase.</summary>
        public unsafe float Contrast {
            get {return SkyLightComponent_ptr->Contrast;}
        }
        ///<summary>Exponent applied to the computed AO.  Values lower than 1 brighten occlusion overall without losing contact shadows.</summary>
        public unsafe float OcclusionExponent {
            get {return SkyLightComponent_ptr->OcclusionExponent;}
        }
        ///<summary>Controls the darkest that a fully occluded area can get.  This tends to destroy contact shadows, use Contrast or OcclusionExponent instead.</summary>
        public unsafe float MinOcclusion {
            get {return SkyLightComponent_ptr->MinOcclusion;}
        }
        ///<summary>Tint color on occluded areas, artistic control.</summary>
        public unsafe Color OcclusionTint {
            get {return SkyLightComponent_ptr->OcclusionTint;}
        }
        ///<summary>Controls how occlusion from Distance Field Ambient Occlusion is combined with Screen Space Ambient Occlusion.</summary>
        public unsafe byte OcclusionCombineMode {
            get {return SkyLightComponent_ptr->OcclusionCombineMode;}
        }
        ///<summary>Blend Destination Cubemap</summary>
        public unsafe TextureCube BlendDestinationCubemap {
            get {return SkyLightComponent_ptr->BlendDestinationCubemap;}
            set {SkyLightComponent_ptr->BlendDestinationCubemap = value;}
        }
        static SkyLightComponent() {
            StaticClass = Main.GetClass("SkyLightComponent");
        }
        internal unsafe SkyLightComponent_fields* SkyLightComponent_ptr => (SkyLightComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkyLightComponent(IntPtr p) => UObject.Make<SkyLightComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkyLightComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkyLightComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
