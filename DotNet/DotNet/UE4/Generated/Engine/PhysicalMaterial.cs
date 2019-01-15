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
    ///<summary>Physical materials are used to define the response of a physical object when interacting dynamically with the world.</summary>
    public unsafe partial class PhysicalMaterial : UObject  {
        ///<summary>Friction value of surface, controls how easily things can slide on this surface (0 is frictionless, higher values increase the amount of friction)</summary>
        public unsafe float Friction {
            get {return PhysicalMaterial_ptr->Friction;}
        }
        ///<summary>Friction combine mode, controls how friction is computed for multiple materials.</summary>
        public unsafe byte FrictionCombineMode {
            get {return PhysicalMaterial_ptr->FrictionCombineMode;}
        }
        public bool bOverrideFrictionCombineMode {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideFrictionCombineMode"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideFrictionCombineMode", value); }
        }
        ///<summary>Restitution or 'bounciness' of this surface, between 0 (no bounce) and 1 (outgoing velocity is same as incoming).</summary>
        public unsafe float Restitution {
            get {return PhysicalMaterial_ptr->Restitution;}
        }
        ///<summary>Restitution combine mode, controls how restitution is computed for multiple materials.</summary>
        public unsafe byte RestitutionCombineMode {
            get {return PhysicalMaterial_ptr->RestitutionCombineMode;}
        }
        public bool bOverrideRestitutionCombineMode {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideRestitutionCombineMode"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideRestitutionCombineMode", value); }
        }
        ///<summary>Used with the shape of the object to calculate its mass properties. The higher the number, the heavier the object. g per cubic cm.</summary>
        public unsafe float Density {
            get {return PhysicalMaterial_ptr->Density;}
        }
        ///<summary>Used to adjust the way that mass increases as objects get larger.</summary>
        ///<remarks>
        ///This is applied to the mass as calculated based on a 'solid' object.
        ///In actuality, larger objects do not tend to be solid, and become more like 'shells' (e.g. a car is not a solid piece of metal).
        ///Values are clamped to 1 or less.
        ///</remarks>
        public unsafe float RaiseMassToPower {
            get {return PhysicalMaterial_ptr->RaiseMassToPower;}
        }
        ///<summary>How much to scale the damage threshold by on any destructible we are applied to</summary>
        public unsafe float DestructibleDamageThresholdScale {
            get {return PhysicalMaterial_ptr->DestructibleDamageThresholdScale;}
        }
        ///<summary>deprecated</summary>
        public unsafe PhysicalMaterialPropertyBase PhysicalMaterialProperty {
            get {return PhysicalMaterial_ptr->PhysicalMaterialProperty;}
            set {PhysicalMaterial_ptr->PhysicalMaterialProperty = value;}
        }
        ///<summary>To edit surface type for your project, use ProjectSettings/Physics/PhysicalSurface section</summary>
        public unsafe byte SurfaceType {
            get {return PhysicalMaterial_ptr->SurfaceType;}
        }
        ///<summary>DEPRECATED - Overall tire friction scalar for every type of tire. This value is multiplied against our parents' values.</summary>
        public unsafe float TireFrictionScale {
            get {return PhysicalMaterial_ptr->TireFrictionScale;}
            set {PhysicalMaterial_ptr->TireFrictionScale = value;}
        }
         //TODO: array not UObject TArray TireFrictionScales
        static PhysicalMaterial() {
            StaticClass = Main.GetClass("PhysicalMaterial");
        }
        internal unsafe PhysicalMaterial_fields* PhysicalMaterial_ptr => (PhysicalMaterial_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicalMaterial(IntPtr p) => UObject.Make<PhysicalMaterial>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicalMaterial DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicalMaterial New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
