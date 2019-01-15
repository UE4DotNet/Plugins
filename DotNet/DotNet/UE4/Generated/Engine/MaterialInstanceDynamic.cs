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
    ///<summary>Material Instance Dynamic</summary>
    public unsafe partial class MaterialInstanceDynamic : MaterialInstance  {

        ///<summary>Copy parameter values from another material instance.</summary>
        ///<remarks>
        ///This will copy only
        ///parameters explicitly overridden in that material instance!!
        ///</remarks>
        public void CopyParameterOverrides(MaterialInstance MaterialInstance)  => 
            MaterialInstanceDynamic_methods.CopyParameterOverrides_method.Invoke(ObjPointer, MaterialInstance);

        ///<summary>
        ///Copies over parameters given a material interface (copy each instance following the hierarchy)
        ///Very slow implementation, avoid using at runtime.
        ///</summary>
        ///<remarks>
        ///Hopefully we can replace it later with something like CopyInterpParameters()
        ///The output is the object itself (this). Copying 'quick parameters only' will result in a much
        ///faster copy process but will only copy dynamic scalar, vector and texture parameters on clients.
        ///@param bQuickParametersOnly Copy scalar, vector and texture parameters only. Much faster but may not include required data
        ///</remarks>
        public void K2_CopyMaterialInstanceParameters(MaterialInterface Source, bool bQuickParametersOnly)  => 
            MaterialInstanceDynamic_methods.K2_CopyMaterialInstanceParameters_method.Invoke(ObjPointer, Source, bQuickParametersOnly);

        ///<summary>Get the current scalar (float) parameter value from an MID</summary>
        public float K2_GetScalarParameterValue(Name ParameterName)  => 
            MaterialInstanceDynamic_methods.K2_GetScalarParameterValue_method.Invoke(ObjPointer, ParameterName);

        ///<summary>Get the current MID texture parameter value</summary>
        public Texture K2_GetTextureParameterValue(Name ParameterName)  => 
            MaterialInstanceDynamic_methods.K2_GetTextureParameterValue_method.Invoke(ObjPointer, ParameterName);

        ///<summary>Get the current MID vector parameter value</summary>
        public LinearColor K2_GetVectorParameterValue(Name ParameterName)  => 
            MaterialInstanceDynamic_methods.K2_GetVectorParameterValue_method.Invoke(ObjPointer, ParameterName);

        ///<summary>
        ///Interpolates the scalar and vector parameters of this material instance based on two other material instances, and an alpha blending factor
        ///The output is the object itself (this).
        ///</summary>
        ///<remarks>
        ///Supports the case SourceA==this || SourceB==this
        ///Both material have to be from the same base material
        ///@param SourceA value that is used for Alpha=0, silently ignores the case if 0
        ///@param SourceB value that is used for Alpha=1, silently ignores the case if 0
        ///@param Alpha usually in the range 0..1, values outside the range extrapolate
        ///</remarks>
        public void K2_InterpolateMaterialInstanceParams(MaterialInstance SourceA, MaterialInstance SourceB, float Alpha)  => 
            MaterialInstanceDynamic_methods.K2_InterpolateMaterialInstanceParams_method.Invoke(ObjPointer, SourceA, SourceB, Alpha);

        ///<summary>Set a MID scalar (float) parameter value</summary>
        public void SetScalarParameterValue(Name ParameterName, float Value)  => 
            MaterialInstanceDynamic_methods.SetScalarParameterValue_method.Invoke(ObjPointer, ParameterName, Value);

        ///<summary>Set an MID texture parameter value</summary>
        public void SetTextureParameterValue(Name ParameterName, Texture Value)  => 
            MaterialInstanceDynamic_methods.SetTextureParameterValue_method.Invoke(ObjPointer, ParameterName, Value);

        ///<summary>Set an MID vector parameter value</summary>
        public void SetVectorParameterValue(Name ParameterName, LinearColor Value)  => 
            MaterialInstanceDynamic_methods.SetVectorParameterValue_method.Invoke(ObjPointer, ParameterName, Value);
        static MaterialInstanceDynamic() {
            StaticClass = Main.GetClass("MaterialInstanceDynamic");
        }
        internal unsafe MaterialInstanceDynamic_fields* MaterialInstanceDynamic_ptr => (MaterialInstanceDynamic_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialInstanceDynamic(IntPtr p) => UObject.Make<MaterialInstanceDynamic>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialInstanceDynamic DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialInstanceDynamic New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
