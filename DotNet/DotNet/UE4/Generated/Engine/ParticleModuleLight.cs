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
    ///<summary>Particle Module Light</summary>
    public unsafe partial class ParticleModuleLight : ParticleModuleLightBase  {
        public bool bUseInverseSquaredFalloff {
            get {return Main.GetGetBoolPropertyByName(this, "bUseInverseSquaredFalloff"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseInverseSquaredFalloff", value); }
        }
        public bool bAffectsTranslucency {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectsTranslucency"); }
            set {Main.SetGetBoolPropertyByName(this, "bAffectsTranslucency", value); }
        }
        public bool bPreviewLightRadius {
            get {return Main.GetGetBoolPropertyByName(this, "bPreviewLightRadius"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreviewLightRadius", value); }
        }
        ///<summary>Fraction of particles in this emitter to create lights on.</summary>
        public unsafe float SpawnFraction {
            get {return ParticleModuleLight_ptr->SpawnFraction;}
            set {ParticleModuleLight_ptr->SpawnFraction = value;}
        }
        ///<summary>Scale that is applied to the particle's color to calculate the light's color, and can be setup as a curve over the particle's lifetime.</summary>
        public unsafe RawDistributionVector ColorScaleOverLife {
            get {return ParticleModuleLight_ptr->ColorScaleOverLife;}
            set {ParticleModuleLight_ptr->ColorScaleOverLife = value;}
        }
        ///<summary>Brightness scale for the light, which can be setup as a curve over the particle's lifetime.</summary>
        public unsafe RawDistributionFloat BrightnessOverLife {
            get {return ParticleModuleLight_ptr->BrightnessOverLife;}
            set {ParticleModuleLight_ptr->BrightnessOverLife = value;}
        }
        ///<summary>Scales the particle's radius, to calculate the light's radius.</summary>
        public unsafe RawDistributionFloat RadiusScale {
            get {return ParticleModuleLight_ptr->RadiusScale;}
            set {ParticleModuleLight_ptr->RadiusScale = value;}
        }
        ///<summary>Provides the light's exponent when inverse squared falloff is disabled.</summary>
        public unsafe RawDistributionFloat LightExponent {
            get {return ParticleModuleLight_ptr->LightExponent;}
            set {ParticleModuleLight_ptr->LightExponent = value;}
        }
        ///<summary>Channels that this light should affect.</summary>
        ///<remarks>
        ///Only affect high quality lights
        ///These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
        ///</remarks>
        public unsafe LightingChannels LightingChannels {
            get {return ParticleModuleLight_ptr->LightingChannels;}
        }
        ///<summary>Intensity of the volumetric scattering from this light.  This scales Intensity and LightColor.</summary>
        public unsafe float VolumetricScatteringIntensity {
            get {return ParticleModuleLight_ptr->VolumetricScatteringIntensity;}
        }
        public bool bHighQualityLights {
            get {return Main.GetGetBoolPropertyByName(this, "bHighQualityLights"); }
            set {Main.SetGetBoolPropertyByName(this, "bHighQualityLights", value); }
        }
        public bool bShadowCastingLights {
            get {return Main.GetGetBoolPropertyByName(this, "bShadowCastingLights"); }
            set {Main.SetGetBoolPropertyByName(this, "bShadowCastingLights", value); }
        }
        static ParticleModuleLight() {
            StaticClass = Main.GetClass("ParticleModuleLight");
        }
        internal unsafe ParticleModuleLight_fields* ParticleModuleLight_ptr => (ParticleModuleLight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLight(IntPtr p) => UObject.Make<ParticleModuleLight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
