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
    public unsafe partial class PointLightComponent : LocalLightComponent  {

        ///<summary>Set Light Falloff Exponent</summary>
        public void SetLightFalloffExponent(float NewLightFalloffExponent)  => 
            PointLightComponent_methods.SetLightFalloffExponent_method.Invoke(ObjPointer, NewLightFalloffExponent);

        ///<summary>Set Soft Source Radius</summary>
        public void SetSoftSourceRadius(float bNewValue)  => 
            PointLightComponent_methods.SetSoftSourceRadius_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set Source Length</summary>
        public void SetSourceLength(float NewValue)  => 
            PointLightComponent_methods.SetSourceLength_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Source Radius</summary>
        public void SetSourceRadius(float bNewValue)  => 
            PointLightComponent_methods.SetSourceRadius_method.Invoke(ObjPointer, bNewValue);
        public bool bUseInverseSquaredFalloff {
            get {return Main.GetGetBoolPropertyByName(this, "bUseInverseSquaredFalloff"); }
        }
        ///<summary>Controls the radial falloff of the light when UseInverseSquaredFalloff is disabled.</summary>
        ///<remarks>
        ///2 is almost linear and very unrealistic and around 8 it looks reasonable.
        ///With large exponents, the light has contribution to only a small area of its influence radius but still costs the same as low exponents.
        ///</remarks>
        public unsafe float LightFalloffExponent {
            get {return PointLightComponent_ptr->LightFalloffExponent;}
        }
        ///<summary>Radius of light source shape.</summary>
        ///<remarks>Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts.</remarks>
        public unsafe float SourceRadius {
            get {return PointLightComponent_ptr->SourceRadius;}
        }
        ///<summary>Soft radius of light source shape.</summary>
        ///<remarks>Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts.</remarks>
        public unsafe float SoftSourceRadius {
            get {return PointLightComponent_ptr->SoftSourceRadius;}
        }
        ///<summary>Length of light source shape.</summary>
        ///<remarks>Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts.</remarks>
        public unsafe float SourceLength {
            get {return PointLightComponent_ptr->SourceLength;}
        }
        static PointLightComponent() {
            StaticClass = Main.GetClass("PointLightComponent");
        }
        internal unsafe PointLightComponent_fields* PointLightComponent_ptr => (PointLightComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PointLightComponent(IntPtr p) => UObject.Make<PointLightComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PointLightComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PointLightComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
