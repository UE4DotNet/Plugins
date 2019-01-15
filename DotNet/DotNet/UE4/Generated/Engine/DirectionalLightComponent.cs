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
    ///<summary>A light component that has parallel rays. Will provide a uniform lighting across any affected surface (eg. The Sun). This will affect all objects in the defined light-mass importance volume.</summary>
    public unsafe partial class DirectionalLightComponent : LightComponent  {

        ///<summary>Set Cascade Distribution Exponent</summary>
        public void SetCascadeDistributionExponent(float NewValue)  => 
            DirectionalLightComponent_methods.SetCascadeDistributionExponent_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Cascade Transition Fraction</summary>
        public void SetCascadeTransitionFraction(float NewValue)  => 
            DirectionalLightComponent_methods.SetCascadeTransitionFraction_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Dynamic Shadow Cascades</summary>
        public void SetDynamicShadowCascades(int NewValue)  => 
            DirectionalLightComponent_methods.SetDynamicShadowCascades_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Dynamic Shadow Distance Movable Light</summary>
        public void SetDynamicShadowDistanceMovableLight(float NewValue)  => 
            DirectionalLightComponent_methods.SetDynamicShadowDistanceMovableLight_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Dynamic Shadow Distance Stationary Light</summary>
        public void SetDynamicShadowDistanceStationaryLight(float NewValue)  => 
            DirectionalLightComponent_methods.SetDynamicShadowDistanceStationaryLight_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Enable Light Shaft Occlusion</summary>
        public void SetEnableLightShaftOcclusion(bool bNewValue)  => 
            DirectionalLightComponent_methods.SetEnableLightShaftOcclusion_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set Light Shaft Override Direction</summary>
        public void SetLightShaftOverrideDirection(Vector NewValue)  => 
            DirectionalLightComponent_methods.SetLightShaftOverrideDirection_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Occlusion Mask Darkness</summary>
        public void SetOcclusionMaskDarkness(float NewValue)  => 
            DirectionalLightComponent_methods.SetOcclusionMaskDarkness_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Shadow Distance Fadeout Fraction</summary>
        public void SetShadowDistanceFadeoutFraction(float NewValue)  => 
            DirectionalLightComponent_methods.SetShadowDistanceFadeoutFraction_method.Invoke(ObjPointer, NewValue);
        public bool bEnableLightShaftOcclusion {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableLightShaftOcclusion"); }
        }
        ///<summary>Controls how dark the occlusion masking is, a value of 1 results in no darkening term.</summary>
        public unsafe float OcclusionMaskDarkness {
            get {return DirectionalLightComponent_ptr->OcclusionMaskDarkness;}
        }
        ///<summary>Everything closer to the camera than this distance will occlude light shafts.</summary>
        public unsafe float OcclusionDepthRange {
            get {return DirectionalLightComponent_ptr->OcclusionDepthRange;}
        }
        ///<summary>Can be used to make light shafts come from somewhere other than the light's actual direction.</summary>
        ///<remarks>This will only be used when non-zero.  It does not have to be normalized.</remarks>
        public unsafe Vector LightShaftOverrideDirection {
            get {return DirectionalLightComponent_ptr->LightShaftOverrideDirection;}
        }
        ///<summary>How far Cascaded Shadow Map dynamic shadows will cover for a movable light, measured from the camera.</summary>
        ///<remarks>A value of 0 disables the dynamic shadow.</remarks>
        public unsafe float DynamicShadowDistanceMovableLight {
            get {return DirectionalLightComponent_ptr->DynamicShadowDistanceMovableLight;}
        }
        ///<summary>How far Cascaded Shadow Map dynamic shadows will cover for a stationary light, measured from the camera.</summary>
        ///<remarks>A value of 0 disables the dynamic shadow.</remarks>
        public unsafe float DynamicShadowDistanceStationaryLight {
            get {return DirectionalLightComponent_ptr->DynamicShadowDistanceStationaryLight;}
        }
        ///<summary>Number of cascades to split the view frustum into for the whole scene dynamic shadow.</summary>
        ///<remarks>More cascades result in better shadow resolution, but adds significant rendering cost.</remarks>
        public unsafe int DynamicShadowCascades {
            get {return DirectionalLightComponent_ptr->DynamicShadowCascades;}
        }
        ///<summary>Controls whether the cascades are distributed closer to the camera (larger exponent) or further from the camera (smaller exponent).</summary>
        ///<remarks>An exponent of 1 means that cascade transitions will happen at a distance proportional to their resolution.</remarks>
        public unsafe float CascadeDistributionExponent {
            get {return DirectionalLightComponent_ptr->CascadeDistributionExponent;}
        }
        ///<summary>Proportion of the fade region between cascades.</summary>
        ///<remarks>
        ///Pixels within the fade region of two cascades have their shadows blended to avoid hard transitions between quality levels.
        ///A value of zero eliminates the fade region, creating hard transitions.
        ///Higher values increase the size of the fade region, creating a more gradual transition between cascades.
        ///The value is expressed as a percentage proportion (i.e. 0.1 = 10% overlap).
        ///Ideal values are the smallest possible which still hide the transition.
        ///An increased fade region size causes an increase in shadow rendering cost.
        ///</remarks>
        public unsafe float CascadeTransitionFraction {
            get {return DirectionalLightComponent_ptr->CascadeTransitionFraction;}
        }
        ///<summary>Controls the size of the fade out region at the far extent of the dynamic shadow's influence.</summary>
        ///<remarks>This is specified as a fraction of DynamicShadowDistance.</remarks>
        public unsafe float ShadowDistanceFadeoutFraction {
            get {return DirectionalLightComponent_ptr->ShadowDistanceFadeoutFraction;}
        }
        public bool bUseInsetShadowsForMovableObjects {
            get {return Main.GetGetBoolPropertyByName(this, "bUseInsetShadowsForMovableObjects"); }
        }
        ///<summary>0: no DistantShadowCascades, otherwise the count of cascades between WholeSceneDynamicShadowRadius and DistantShadowDistance that are covered by distant shadow cascades.</summary>
        public unsafe int FarShadowCascadeCount {
            get {return DirectionalLightComponent_ptr->FarShadowCascadeCount;}
        }
        ///<summary>Distance at which the far shadow cascade should end.  Far shadows will cover the range between 'Dynamic Shadow Distance' and this distance.</summary>
        public unsafe float FarShadowDistance {
            get {return DirectionalLightComponent_ptr->FarShadowDistance;}
        }
        ///<summary>Distance at which the ray traced shadow cascade should end.  Distance field shadows will cover the range between 'Dynamic Shadow Distance' this distance.</summary>
        public unsafe float DistanceFieldShadowDistance {
            get {return DirectionalLightComponent_ptr->DistanceFieldShadowDistance;}
        }
        ///<summary>Angle subtended by light source in degrees (also known as angular diameter).</summary>
        ///<remarks>Defaults to 0.5357 which is the angle for our sun.</remarks>
        public unsafe float LightSourceAngle {
            get {return DirectionalLightComponent_ptr->LightSourceAngle;}
        }
        ///<summary>Angle subtended by soft light source in degrees.</summary>
        public unsafe float LightSourceSoftAngle {
            get {return DirectionalLightComponent_ptr->LightSourceSoftAngle;}
        }
        ///<summary>Determines how far shadows can be cast, in world units.  Larger values increase the shadowing cost.</summary>
        public unsafe float TraceDistance {
            get {return DirectionalLightComponent_ptr->TraceDistance;}
        }
        ///<summary>The Lightmass settings for this object.</summary>
        public unsafe LightmassDirectionalLightSettings LightmassSettings {
            get {return DirectionalLightComponent_ptr->LightmassSettings;}
            set {DirectionalLightComponent_ptr->LightmassSettings = value;}
        }
        public bool bCastModulatedShadows {
            get {return Main.GetGetBoolPropertyByName(this, "bCastModulatedShadows"); }
        }
        ///<summary>Color to modulate against the scene color when rendering modulated shadows. (mobile only)</summary>
        public unsafe Color ModulatedShadowColor {
            get {return DirectionalLightComponent_ptr->ModulatedShadowColor;}
        }
        public bool bUsedAsAtmosphereSunLight {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedAsAtmosphereSunLight"); }
        }
        static DirectionalLightComponent() {
            StaticClass = Main.GetClass("DirectionalLightComponent");
        }
        internal unsafe DirectionalLightComponent_fields* DirectionalLightComponent_ptr => (DirectionalLightComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DirectionalLightComponent(IntPtr p) => UObject.Make<DirectionalLightComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DirectionalLightComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DirectionalLightComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
