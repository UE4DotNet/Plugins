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
    ///<summary>Used to create fogging effects such as clouds but with a density that is related to the height of the fog.</summary>
    public unsafe partial class ExponentialHeightFogComponent : SceneComponent  {

        ///<summary>Set Directional Inscattering Color</summary>
        public void SetDirectionalInscatteringColor(LinearColor Value)  => 
            ExponentialHeightFogComponent_methods.SetDirectionalInscatteringColor_method.Invoke(ObjPointer, Value);

        ///<summary>Set Directional Inscattering Exponent</summary>
        public void SetDirectionalInscatteringExponent(float Value)  => 
            ExponentialHeightFogComponent_methods.SetDirectionalInscatteringExponent_method.Invoke(ObjPointer, Value);

        ///<summary>Set Directional Inscattering Start Distance</summary>
        public void SetDirectionalInscatteringStartDistance(float Value)  => 
            ExponentialHeightFogComponent_methods.SetDirectionalInscatteringStartDistance_method.Invoke(ObjPointer, Value);

        ///<summary>Set Fog Cutoff Distance</summary>
        public void SetFogCutoffDistance(float Value)  => 
            ExponentialHeightFogComponent_methods.SetFogCutoffDistance_method.Invoke(ObjPointer, Value);

        ///<summary>Set Fog Density</summary>
        public void SetFogDensity(float Value)  => 
            ExponentialHeightFogComponent_methods.SetFogDensity_method.Invoke(ObjPointer, Value);

        ///<summary>Set Fog Height Falloff</summary>
        public void SetFogHeightFalloff(float Value)  => 
            ExponentialHeightFogComponent_methods.SetFogHeightFalloff_method.Invoke(ObjPointer, Value);

        ///<summary>Set Fog Inscattering Color</summary>
        public void SetFogInscatteringColor(LinearColor Value)  => 
            ExponentialHeightFogComponent_methods.SetFogInscatteringColor_method.Invoke(ObjPointer, Value);

        ///<summary>Set Fog Max Opacity</summary>
        public void SetFogMaxOpacity(float Value)  => 
            ExponentialHeightFogComponent_methods.SetFogMaxOpacity_method.Invoke(ObjPointer, Value);

        ///<summary>Set Fully Directional Inscattering Color Distance</summary>
        public void SetFullyDirectionalInscatteringColorDistance(float Value)  => 
            ExponentialHeightFogComponent_methods.SetFullyDirectionalInscatteringColorDistance_method.Invoke(ObjPointer, Value);

        ///<summary>Set Inscattering Color Cubemap</summary>
        public void SetInscatteringColorCubemap(TextureCube Value)  => 
            ExponentialHeightFogComponent_methods.SetInscatteringColorCubemap_method.Invoke(ObjPointer, Value);

        ///<summary>Set Inscattering Color Cubemap Angle</summary>
        public void SetInscatteringColorCubemapAngle(float Value)  => 
            ExponentialHeightFogComponent_methods.SetInscatteringColorCubemapAngle_method.Invoke(ObjPointer, Value);

        ///<summary>Set Inscattering Texture Tint</summary>
        public void SetInscatteringTextureTint(LinearColor Value)  => 
            ExponentialHeightFogComponent_methods.SetInscatteringTextureTint_method.Invoke(ObjPointer, Value);

        ///<summary>Set Non Directional Inscattering Color Distance</summary>
        public void SetNonDirectionalInscatteringColorDistance(float Value)  => 
            ExponentialHeightFogComponent_methods.SetNonDirectionalInscatteringColorDistance_method.Invoke(ObjPointer, Value);

        ///<summary>Set Start Distance</summary>
        public void SetStartDistance(float Value)  => 
            ExponentialHeightFogComponent_methods.SetStartDistance_method.Invoke(ObjPointer, Value);

        ///<summary>Set Volumetric Fog</summary>
        public void SetVolumetricFog(bool bNewValue)  => 
            ExponentialHeightFogComponent_methods.SetVolumetricFog_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set Volumetric Fog Albedo</summary>
        public void SetVolumetricFogAlbedo(Color NewValue)  => 
            ExponentialHeightFogComponent_methods.SetVolumetricFogAlbedo_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Volumetric Fog Distance</summary>
        public void SetVolumetricFogDistance(float NewValue)  => 
            ExponentialHeightFogComponent_methods.SetVolumetricFogDistance_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Volumetric Fog Emissive</summary>
        public void SetVolumetricFogEmissive(LinearColor NewValue)  => 
            ExponentialHeightFogComponent_methods.SetVolumetricFogEmissive_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Volumetric Fog Extinction Scale</summary>
        public void SetVolumetricFogExtinctionScale(float NewValue)  => 
            ExponentialHeightFogComponent_methods.SetVolumetricFogExtinctionScale_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Volumetric Fog Scattering Distribution</summary>
        public void SetVolumetricFogScatteringDistribution(float NewValue)  => 
            ExponentialHeightFogComponent_methods.SetVolumetricFogScatteringDistribution_method.Invoke(ObjPointer, NewValue);
        ///<summary>Global density factor.</summary>
        public unsafe float FogDensity {
            get {return ExponentialHeightFogComponent_ptr->FogDensity;}
        }
        ///<summary>Fog Inscattering Color</summary>
        public unsafe LinearColor FogInscatteringColor {
            get {return ExponentialHeightFogComponent_ptr->FogInscatteringColor;}
        }
        ///<summary>Cubemap that can be specified for fog color, which is useful to make distant, heavily fogged scene elements match the sky.</summary>
        ///<remarks>When the cubemap is specified, FogInscatteringColor is ignored and Directional inscattering is disabled.</remarks>
        public unsafe TextureCube InscatteringColorCubemap {
            get {return ExponentialHeightFogComponent_ptr->InscatteringColorCubemap;}
        }
        ///<summary>Angle to rotate the InscatteringColorCubemap around the Z axis.</summary>
        public unsafe float InscatteringColorCubemapAngle {
            get {return ExponentialHeightFogComponent_ptr->InscatteringColorCubemapAngle;}
        }
        ///<summary>Tint color used when InscatteringColorCubemap is specified, for quick edits without having to reimport InscatteringColorCubemap.</summary>
        public unsafe LinearColor InscatteringTextureTint {
            get {return ExponentialHeightFogComponent_ptr->InscatteringTextureTint;}
        }
        ///<summary>Distance at which InscatteringColorCubemap should be used directly for the Inscattering Color.</summary>
        public unsafe float FullyDirectionalInscatteringColorDistance {
            get {return ExponentialHeightFogComponent_ptr->FullyDirectionalInscatteringColorDistance;}
        }
        ///<summary>Distance at which only the average color of InscatteringColorCubemap should be used as Inscattering Color.</summary>
        public unsafe float NonDirectionalInscatteringColorDistance {
            get {return ExponentialHeightFogComponent_ptr->NonDirectionalInscatteringColorDistance;}
        }
        ///<summary>Controls the size of the directional inscattering cone, which is used to approximate inscattering from a directional light.</summary>
        ///<remarks>Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used.</remarks>
        public unsafe float DirectionalInscatteringExponent {
            get {return ExponentialHeightFogComponent_ptr->DirectionalInscatteringExponent;}
        }
        ///<summary>Controls the start distance from the viewer of the directional inscattering, which is used to approximate inscattering from a directional light.</summary>
        ///<remarks>Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used.</remarks>
        public unsafe float DirectionalInscatteringStartDistance {
            get {return ExponentialHeightFogComponent_ptr->DirectionalInscatteringStartDistance;}
        }
        ///<summary>Controls the color of the directional inscattering, which is used to approximate inscattering from a directional light.</summary>
        ///<remarks>Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used.</remarks>
        public unsafe LinearColor DirectionalInscatteringColor {
            get {return ExponentialHeightFogComponent_ptr->DirectionalInscatteringColor;}
        }
        ///<summary>Height density factor, controls how the density increases as height decreases.</summary>
        ///<remarks>Smaller values make the visible transition larger.</remarks>
        public unsafe float FogHeightFalloff {
            get {return ExponentialHeightFogComponent_ptr->FogHeightFalloff;}
        }
        ///<summary>Maximum opacity of the fog.</summary>
        ///<remarks>
        ///A value of 1 means the fog can become fully opaque at a distance and replace scene color completely,
        ///A value of 0 means the fog color will not be factored in at all.
        ///</remarks>
        public unsafe float FogMaxOpacity {
            get {return ExponentialHeightFogComponent_ptr->FogMaxOpacity;}
        }
        ///<summary>Distance from the camera that the fog will start, in world units.</summary>
        public unsafe float StartDistance {
            get {return ExponentialHeightFogComponent_ptr->StartDistance;}
        }
        ///<summary>Scene elements past this distance will not have fog applied.  This is useful for excluding skyboxes which already have fog baked in.</summary>
        public unsafe float FogCutoffDistance {
            get {return ExponentialHeightFogComponent_ptr->FogCutoffDistance;}
        }
        public bool bEnableVolumetricFog {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableVolumetricFog"); }
        }
        ///<summary>Controls the scattering phase function - how much incoming light scatters in various directions.</summary>
        ///<remarks>
        ///A distribution value of 0 scatters equally in all directions, while .9 scatters predominantly in the light direction.
        ///In order to have visible volumetric fog light shafts from the side, the distribution will need to be closer to 0.
        ///</remarks>
        public unsafe float VolumetricFogScatteringDistribution {
            get {return ExponentialHeightFogComponent_ptr->VolumetricFogScatteringDistribution;}
        }
        ///<summary>The height fog particle reflectiveness used by volumetric fog.</summary>
        ///<remarks>Water particles in air have an albedo near white, while dust has slightly darker value.</remarks>
        public unsafe Color VolumetricFogAlbedo {
            get {return ExponentialHeightFogComponent_ptr->VolumetricFogAlbedo;}
        }
        ///<summary>Light emitted by height fog.</summary>
        ///<remarks>
        ///This is a density so more light is emitted the further you are looking through the fog.
        ///In most cases skylight is a better choice, however right now volumetric fog does not support precomputed lighting,
        ///So stationary skylights are unshadowed and static skylights don't affect volumetric fog at all.
        ///</remarks>
        public unsafe LinearColor VolumetricFogEmissive {
            get {return ExponentialHeightFogComponent_ptr->VolumetricFogEmissive;}
        }
        ///<summary>Scales the height fog particle extinction amount used by volumetric fog.  Values larger than 1 cause fog particles everywhere absorb more light.</summary>
        public unsafe float VolumetricFogExtinctionScale {
            get {return ExponentialHeightFogComponent_ptr->VolumetricFogExtinctionScale;}
        }
        ///<summary>Distance over which volumetric fog should be computed.  Larger values extend the effect into the distance but expose under-sampling artifacts in details.</summary>
        public unsafe float VolumetricFogDistance {
            get {return ExponentialHeightFogComponent_ptr->VolumetricFogDistance;}
        }
        ///<summary>Volumetric Fog Static Lighting Scattering Intensity</summary>
        public unsafe float VolumetricFogStaticLightingScatteringIntensity {
            get {return ExponentialHeightFogComponent_ptr->VolumetricFogStaticLightingScatteringIntensity;}
        }
        public bool bOverrideLightColorsWithFogInscatteringColors {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideLightColorsWithFogInscatteringColors"); }
        }
        static ExponentialHeightFogComponent() {
            StaticClass = Main.GetClass("ExponentialHeightFogComponent");
        }
        internal unsafe ExponentialHeightFogComponent_fields* ExponentialHeightFogComponent_ptr => (ExponentialHeightFogComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ExponentialHeightFogComponent(IntPtr p) => UObject.Make<ExponentialHeightFogComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ExponentialHeightFogComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ExponentialHeightFogComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
