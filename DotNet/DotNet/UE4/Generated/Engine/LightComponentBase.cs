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
    ///<summary>Light Component Base</summary>
    public unsafe partial class LightComponentBase : SceneComponent  {

        ///<summary>Gets the light color as a linear color</summary>
        public LinearColor GetLightColor()  => 
            LightComponentBase_methods.GetLightColor_method.Invoke(ObjPointer);

        ///<summary>Sets whether this light casts shadows</summary>
        public void SetCastShadows(bool bNewValue)  => 
            LightComponentBase_methods.SetCastShadows_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set Cast Volumetric Shadow</summary>
        public void SetCastVolumetricShadow(bool bNewValue)  => 
            LightComponentBase_methods.SetCastVolumetricShadow_method.Invoke(ObjPointer, bNewValue);
        ///<summary>GUID used to associate a light component with precomputed shadowing information across levels.</summary>
        ///<remarks>The GUID changes whenever the light position changes.</remarks>
        public unsafe FGuid LightGuid {
            get {return LightComponentBase_ptr->LightGuid;}
            set {LightComponentBase_ptr->LightGuid = value;}
        }
        ///<summary>Total energy that the light emits.</summary>
        public unsafe float Intensity {
            get {return LightComponentBase_ptr->Intensity;}
        }
        ///<summary>Filter color of the light.</summary>
        ///<remarks>Note that this can change the light's effective intensity.</remarks>
        public unsafe Color LightColor {
            get {return LightComponentBase_ptr->LightColor;}
        }
        public bool bAffectsWorld {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectsWorld"); }
        }
        public bool CastShadows {
            get {return Main.GetGetBoolPropertyByName(this, "CastShadows"); }
        }
        public bool CastStaticShadows {
            get {return Main.GetGetBoolPropertyByName(this, "CastStaticShadows"); }
        }
        public bool CastDynamicShadows {
            get {return Main.GetGetBoolPropertyByName(this, "CastDynamicShadows"); }
        }
        public bool bAffectTranslucentLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectTranslucentLighting"); }
        }
        public bool bTransmission {
            get {return Main.GetGetBoolPropertyByName(this, "bTransmission"); }
        }
        public bool bCastVolumetricShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastVolumetricShadow"); }
        }
        ///<summary>Scales the indirect lighting contribution from this light.</summary>
        ///<remarks>A value of 0 disables any GI from this light. Default is 1.</remarks>
        public unsafe float IndirectLightingIntensity {
            get {return LightComponentBase_ptr->IndirectLightingIntensity;}
        }
        ///<summary>Intensity of the volumetric scattering from this light.  This scales Intensity and LightColor.</summary>
        public unsafe float VolumetricScatteringIntensity {
            get {return LightComponentBase_ptr->VolumetricScatteringIntensity;}
        }
        ///<summary>Sprite for static light in the editor.</summary>
        public unsafe Texture2D StaticEditorTexture {
            get {return LightComponentBase_ptr->StaticEditorTexture;}
            set {LightComponentBase_ptr->StaticEditorTexture = value;}
        }
        ///<summary>Sprite scaling for static light in the editor.</summary>
        public unsafe float StaticEditorTextureScale {
            get {return LightComponentBase_ptr->StaticEditorTextureScale;}
            set {LightComponentBase_ptr->StaticEditorTextureScale = value;}
        }
        ///<summary>Sprite for dynamic light in the editor.</summary>
        public unsafe Texture2D DynamicEditorTexture {
            get {return LightComponentBase_ptr->DynamicEditorTexture;}
            set {LightComponentBase_ptr->DynamicEditorTexture = value;}
        }
        ///<summary>Sprite scaling for dynamic light in the editor.</summary>
        public unsafe float DynamicEditorTextureScale {
            get {return LightComponentBase_ptr->DynamicEditorTextureScale;}
            set {LightComponentBase_ptr->DynamicEditorTextureScale = value;}
        }
        static LightComponentBase() {
            StaticClass = Main.GetClass("LightComponentBase");
        }
        internal unsafe LightComponentBase_fields* LightComponentBase_ptr => (LightComponentBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightComponentBase(IntPtr p) => UObject.Make<LightComponentBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightComponentBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightComponentBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
