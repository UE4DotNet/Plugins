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
    ///<summary>Material Expression Dynamic Parameter</summary>
    public unsafe partial class MaterialExpressionDynamicParameter : MaterialExpression  {
         //TODO: array not UObject TArray ParamNames
        ///<summary>Default Value</summary>
        public unsafe LinearColor DefaultValue {
            get {return MaterialExpressionDynamicParameter_ptr->DefaultValue;}
            set {MaterialExpressionDynamicParameter_ptr->DefaultValue = value;}
        }
         //TODO: numeric uint32 ParameterIndex
        static MaterialExpressionDynamicParameter() {
            StaticClass = Main.GetClass("MaterialExpressionDynamicParameter");
        }
        internal unsafe MaterialExpressionDynamicParameter_fields* MaterialExpressionDynamicParameter_ptr => (MaterialExpressionDynamicParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDynamicParameter(IntPtr p) => UObject.Make<MaterialExpressionDynamicParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDynamicParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDynamicParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
