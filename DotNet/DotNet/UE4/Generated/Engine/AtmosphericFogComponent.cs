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
    ///<summary>Used to create fogging effects such as clouds.</summary>
    public unsafe partial class AtmosphericFogComponent : SceneComponent  {

        ///<summary>Set DisableGroundScattering</summary>
        public void DisableGroundScattering(bool NewGroundScattering)  => 
            AtmosphericFogComponent_methods.DisableGroundScattering_method.Invoke(ObjPointer, NewGroundScattering);

        ///<summary>Set DisableSunDisk</summary>
        public void DisableSunDisk(bool NewSunDisk)  => 
            AtmosphericFogComponent_methods.DisableSunDisk_method.Invoke(ObjPointer, NewSunDisk);

        ///<summary>Set AltitudeScale</summary>
        public void SetAltitudeScale(float NewAltitudeScale)  => 
            AtmosphericFogComponent_methods.SetAltitudeScale_method.Invoke(ObjPointer, NewAltitudeScale);

        ///<summary>Set brightness of the light</summary>
        public void SetDefaultBrightness(float NewBrightness)  => 
            AtmosphericFogComponent_methods.SetDefaultBrightness_method.Invoke(ObjPointer, NewBrightness);

        ///<summary>Set color of the light</summary>
        public void SetDefaultLightColor(LinearColor NewLightColor)  => 
            AtmosphericFogComponent_methods.SetDefaultLightColor_method.Invoke(ObjPointer, NewLightColor);

        ///<summary>Set DensityMultiplier</summary>
        public void SetDensityMultiplier(float NewDensityMultiplier)  => 
            AtmosphericFogComponent_methods.SetDensityMultiplier_method.Invoke(ObjPointer, NewDensityMultiplier);

        ///<summary>Set DensityOffset</summary>
        public void SetDensityOffset(float NewDensityOffset)  => 
            AtmosphericFogComponent_methods.SetDensityOffset_method.Invoke(ObjPointer, NewDensityOffset);

        ///<summary>Set DistanceOffset</summary>
        public void SetDistanceOffset(float NewDistanceOffset)  => 
            AtmosphericFogComponent_methods.SetDistanceOffset_method.Invoke(ObjPointer, NewDistanceOffset);

        ///<summary>Set DistanceScale</summary>
        public void SetDistanceScale(float NewDistanceScale)  => 
            AtmosphericFogComponent_methods.SetDistanceScale_method.Invoke(ObjPointer, NewDistanceScale);

        ///<summary>Set FogMultiplier</summary>
        public void SetFogMultiplier(float NewFogMultiplier)  => 
            AtmosphericFogComponent_methods.SetFogMultiplier_method.Invoke(ObjPointer, NewFogMultiplier);

        ///<summary>Set PrecomputeParams, only valid in Editor mode</summary>
        public void SetPrecomputeParams(float DensityHeight, int MaxScatteringOrder, int InscatterAltitudeSampleNum)  => 
            AtmosphericFogComponent_methods.SetPrecomputeParams_method.Invoke(ObjPointer, DensityHeight, MaxScatteringOrder, InscatterAltitudeSampleNum);

        ///<summary>Set StartDistance</summary>
        public void SetStartDistance(float NewStartDistance)  => 
            AtmosphericFogComponent_methods.SetStartDistance_method.Invoke(ObjPointer, NewStartDistance);

        ///<summary>Set SunMultiplier</summary>
        public void SetSunMultiplier(float NewSunMultiplier)  => 
            AtmosphericFogComponent_methods.SetSunMultiplier_method.Invoke(ObjPointer, NewSunMultiplier);

        ///<summary>Start Precompute</summary>
        public void StartPrecompute()  => 
            AtmosphericFogComponent_methods.StartPrecompute_method.Invoke(ObjPointer);
        ///<summary>Global scattering factor.</summary>
        public unsafe float SunMultiplier {
            get {return AtmosphericFogComponent_ptr->SunMultiplier;}
            set {AtmosphericFogComponent_ptr->SunMultiplier = value;}
        }
        ///<summary>Scattering factor on object.</summary>
        public unsafe float FogMultiplier {
            get {return AtmosphericFogComponent_ptr->FogMultiplier;}
            set {AtmosphericFogComponent_ptr->FogMultiplier = value;}
        }
        ///<summary>Fog density control factor.</summary>
        public unsafe float DensityMultiplier {
            get {return AtmosphericFogComponent_ptr->DensityMultiplier;}
            set {AtmosphericFogComponent_ptr->DensityMultiplier = value;}
        }
        ///<summary>Fog density offset to control opacity [-1.f ~ 1.f].</summary>
        public unsafe float DensityOffset {
            get {return AtmosphericFogComponent_ptr->DensityOffset;}
            set {AtmosphericFogComponent_ptr->DensityOffset = value;}
        }
        ///<summary>Distance scale.</summary>
        public unsafe float DistanceScale {
            get {return AtmosphericFogComponent_ptr->DistanceScale;}
            set {AtmosphericFogComponent_ptr->DistanceScale = value;}
        }
        ///<summary>Altitude scale (only Z scale).</summary>
        public unsafe float AltitudeScale {
            get {return AtmosphericFogComponent_ptr->AltitudeScale;}
            set {AtmosphericFogComponent_ptr->AltitudeScale = value;}
        }
        ///<summary>Distance offset, in km (to handle large distance)</summary>
        public unsafe float DistanceOffset {
            get {return AtmosphericFogComponent_ptr->DistanceOffset;}
            set {AtmosphericFogComponent_ptr->DistanceOffset = value;}
        }
        ///<summary>Ground offset.</summary>
        public unsafe float GroundOffset {
            get {return AtmosphericFogComponent_ptr->GroundOffset;}
            set {AtmosphericFogComponent_ptr->GroundOffset = value;}
        }
        ///<summary>Start Distance.</summary>
        public unsafe float StartDistance {
            get {return AtmosphericFogComponent_ptr->StartDistance;}
            set {AtmosphericFogComponent_ptr->StartDistance = value;}
        }
        ///<summary>Distance offset, in km (to handle large distance)</summary>
        public unsafe float SunDiscScale {
            get {return AtmosphericFogComponent_ptr->SunDiscScale;}
            set {AtmosphericFogComponent_ptr->SunDiscScale = value;}
        }
        ///<summary>Default light brightness. Used when there is no sunlight placed in the level. Unit is lumens</summary>
        public unsafe float DefaultBrightness {
            get {return AtmosphericFogComponent_ptr->DefaultBrightness;}
        }
        ///<summary>Default light color. Used when there is no sunlight placed in the level.</summary>
        public unsafe Color DefaultLightColor {
            get {return AtmosphericFogComponent_ptr->DefaultLightColor;}
        }
        public bool bDisableSunDisk {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableSunDisk"); }
        }
        public bool bDisableGroundScattering {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableGroundScattering"); }
        }
        ///<summary>Precompute Params</summary>
        public unsafe AtmospherePrecomputeParameters PrecomputeParams {
            get {return AtmosphericFogComponent_ptr->PrecomputeParams;}
        }
        static AtmosphericFogComponent() {
            StaticClass = Main.GetClass("AtmosphericFogComponent");
        }
        internal unsafe AtmosphericFogComponent_fields* AtmosphericFogComponent_ptr => (AtmosphericFogComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AtmosphericFogComponent(IntPtr p) => UObject.Make<AtmosphericFogComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AtmosphericFogComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AtmosphericFogComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
