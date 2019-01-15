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
    ///<summary>A Component referencing a vector field.</summary>
    public unsafe partial class VectorFieldComponent : PrimitiveComponent  {

        ///<summary>Set the intensity of the vector field.</summary>
        ///<remarks>
        ///@param NewIntensity - The new intensity of the vector field.
        ///</remarks>
        public void SetIntensity(float NewIntensity)  => 
            VectorFieldComponent_methods.SetIntensity_method.Invoke(ObjPointer, NewIntensity);
        ///<summary>The vector field asset.</summary>
        public unsafe VectorField VectorField {
            get {return VectorFieldComponent_ptr->VectorField;}
            set {VectorFieldComponent_ptr->VectorField = value;}
        }
        ///<summary>The intensity at which the vector field is applied.</summary>
        public unsafe float Intensity {
            get {return VectorFieldComponent_ptr->Intensity;}
            set {VectorFieldComponent_ptr->Intensity = value;}
        }
        ///<summary>How tightly particles follow the vector field.</summary>
        public unsafe float Tightness {
            get {return VectorFieldComponent_ptr->Tightness;}
            set {VectorFieldComponent_ptr->Tightness = value;}
        }
        public bool bPreviewVectorField {
            get {return Main.GetGetBoolPropertyByName(this, "bPreviewVectorField"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreviewVectorField", value); }
        }
        static VectorFieldComponent() {
            StaticClass = Main.GetClass("VectorFieldComponent");
        }
        internal unsafe VectorFieldComponent_fields* VectorFieldComponent_ptr => (VectorFieldComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VectorFieldComponent(IntPtr p) => UObject.Make<VectorFieldComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VectorFieldComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VectorFieldComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
