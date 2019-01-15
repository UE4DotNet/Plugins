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
    ///<summary>Light</summary>
    public unsafe partial class Light : Actor  {

        ///<summary>Get Brightness</summary>
        public float GetBrightness()  => 
            Light_methods.GetBrightness_method.Invoke(ObjPointer);

        ///<summary>Get Light Color</summary>
        public LinearColor GetLightColor()  => 
            Light_methods.GetLightColor_method.Invoke(ObjPointer);

        ///<summary>Is Enabled</summary>
        public bool IsEnabled()  => 
            Light_methods.IsEnabled_method.Invoke(ObjPointer);

        ///<summary>Set Affect Translucent Lighting</summary>
        public void SetAffectTranslucentLighting(bool bNewValue)  => 
            Light_methods.SetAffectTranslucentLighting_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set Brightness</summary>
        public void SetBrightness(float NewBrightness)  => 
            Light_methods.SetBrightness_method.Invoke(ObjPointer, NewBrightness);

        ///<summary>Set Cast Shadows</summary>
        public void SetCastShadows(bool bNewValue)  => 
            Light_methods.SetCastShadows_method.Invoke(ObjPointer, bNewValue);

        ///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
        public void SetEnabled(bool bSetEnabled)  => 
            Light_methods.SetEnabled_method.Invoke(ObjPointer, bSetEnabled);

        ///<summary>Set Light Color</summary>
        public void SetLightColor(LinearColor NewLightColor)  => 
            Light_methods.SetLightColor_method.Invoke(ObjPointer, NewLightColor);

        ///<summary>Set Light Function Fade Distance</summary>
        public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)  => 
            Light_methods.SetLightFunctionFadeDistance_method.Invoke(ObjPointer, NewLightFunctionFadeDistance);

        ///<summary>Set Light Function Material</summary>
        public void SetLightFunctionMaterial(MaterialInterface NewLightFunctionMaterial)  => 
            Light_methods.SetLightFunctionMaterial_method.Invoke(ObjPointer, NewLightFunctionMaterial);

        ///<summary>Set Light Function Scale</summary>
        public void SetLightFunctionScale(Vector NewLightFunctionScale)  => 
            Light_methods.SetLightFunctionScale_method.Invoke(ObjPointer, NewLightFunctionScale);

        ///<summary>Toggle Enabled</summary>
        public void ToggleEnabled()  => 
            Light_methods.ToggleEnabled_method.Invoke(ObjPointer);
        ///<summary>@todo document</summary>
        public unsafe LightComponent LightComponent {
            get {return Light_ptr->LightComponent;}
        }
        public bool bEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnabled", value); }
        }
        static Light() {
            StaticClass = Main.GetClass("Light");
        }
        internal unsafe Light_fields* Light_ptr => (Light_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Light(IntPtr p) => UObject.Make<Light>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Light DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Light New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
