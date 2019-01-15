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
    ///<summary>Kismet Material Library</summary>
    public unsafe partial class KismetMaterialLibrary : BlueprintFunctionLibrary  {

        ///<summary>Creates a Dynamic Material Instance which you can modify during gameplay.</summary>
        public static MaterialInstanceDynamic CreateDynamicMaterialInstance(UObject WorldContextObject, MaterialInterface Parent, Name OptionalName)  => 
            KismetMaterialLibrary_methods.CreateDynamicMaterialInstance_method.Invoke(WorldContextObject, Parent, OptionalName);

        ///<summary>Gets a scalar parameter value from the material collection instance. Logs if ParameterName is invalid.</summary>
        public static float GetScalarParameterValue(UObject WorldContextObject, MaterialParameterCollection Collection, Name ParameterName)  => 
            KismetMaterialLibrary_methods.GetScalarParameterValue_method.Invoke(WorldContextObject, Collection, ParameterName);

        ///<summary>Gets a vector parameter value from the material collection instance. Logs if ParameterName is invalid.</summary>
        public static LinearColor GetVectorParameterValue(UObject WorldContextObject, MaterialParameterCollection Collection, Name ParameterName)  => 
            KismetMaterialLibrary_methods.GetVectorParameterValue_method.Invoke(WorldContextObject, Collection, ParameterName);

        ///<summary>Sets a scalar parameter value on the material collection instance. Logs if ParameterName is invalid.</summary>
        public static void SetScalarParameterValue(UObject WorldContextObject, MaterialParameterCollection Collection, Name ParameterName, float ParameterValue)  => 
            KismetMaterialLibrary_methods.SetScalarParameterValue_method.Invoke(WorldContextObject, Collection, ParameterName, ParameterValue);

        ///<summary>Sets a vector parameter value on the material collection instance. Logs if ParameterName is invalid.</summary>
        public static void SetVectorParameterValue(UObject WorldContextObject, MaterialParameterCollection Collection, Name ParameterName, LinearColor ParameterValue)  => 
            KismetMaterialLibrary_methods.SetVectorParameterValue_method.Invoke(WorldContextObject, Collection, ParameterName, ParameterValue);
        static KismetMaterialLibrary() {
            StaticClass = Main.GetClass("KismetMaterialLibrary");
        }
        internal unsafe KismetMaterialLibrary_fields* KismetMaterialLibrary_ptr => (KismetMaterialLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetMaterialLibrary(IntPtr p) => UObject.Make<KismetMaterialLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetMaterialLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetMaterialLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
