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
    ///<summary>Material Instances may be used to change the appearance of a material without incurring an expensive recompilation of the material.</summary>
    ///<remarks>
    ///General modification of the material cannot be supported without recompilation, so the instances are limited to changing the values of
    ///predefined material parameters. The parameters are statically defined in the compiled material by a unique name, type and default value.
    ///</remarks>
    public unsafe partial class MaterialInstanceConstant : MaterialInstance  {

        ///<summary>Get the scalar (float) parameter value from an MIC</summary>
        public float K2_GetScalarParameterValue(Name ParameterName)  => 
            MaterialInstanceConstant_methods.K2_GetScalarParameterValue_method.Invoke(ObjPointer, ParameterName);

        ///<summary>Get the MIC texture parameter value</summary>
        public Texture K2_GetTextureParameterValue(Name ParameterName)  => 
            MaterialInstanceConstant_methods.K2_GetTextureParameterValue_method.Invoke(ObjPointer, ParameterName);

        ///<summary>Get the MIC vector parameter value</summary>
        public LinearColor K2_GetVectorParameterValue(Name ParameterName)  => 
            MaterialInstanceConstant_methods.K2_GetVectorParameterValue_method.Invoke(ObjPointer, ParameterName);
        ///<summary>Unique ID for this material instance's parameter set</summary>
        ///<remarks>Updated on changes in the editor to allow those changes to be detected</remarks>
        public unsafe FGuid ParameterStateId {
            get {return MaterialInstanceConstant_ptr->ParameterStateId;}
            set {MaterialInstanceConstant_ptr->ParameterStateId = value;}
        }
        static MaterialInstanceConstant() {
            StaticClass = Main.GetClass("MaterialInstanceConstant");
        }
        internal unsafe MaterialInstanceConstant_fields* MaterialInstanceConstant_ptr => (MaterialInstanceConstant_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialInstanceConstant(IntPtr p) => UObject.Make<MaterialInstanceConstant>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialInstanceConstant DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialInstanceConstant New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
