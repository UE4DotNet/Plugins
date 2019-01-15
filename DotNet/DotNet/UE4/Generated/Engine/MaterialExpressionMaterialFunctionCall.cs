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
    ///<summary>Material Expression Material Function Call</summary>
    public unsafe partial class MaterialExpressionMaterialFunctionCall : MaterialExpression  {

        ///<summary>Set Material Function</summary>
        public bool SetMaterialFunction(MaterialFunctionInterface NewMaterialFunction)  => 
            MaterialExpressionMaterialFunctionCall_methods.SetMaterialFunction_method.Invoke(ObjPointer, NewMaterialFunction);
        ///<summary>The function to call.</summary>
        public unsafe MaterialFunctionInterface MaterialFunction {
            get {return MaterialExpressionMaterialFunctionCall_ptr->MaterialFunction;}
            set {MaterialExpressionMaterialFunctionCall_ptr->MaterialFunction = value;}
        }
         //TODO: array not UObject TArray FunctionInputs
         //TODO: array not UObject TArray FunctionOutputs
        ///<summary>Used by material parameters to split references to separate instances.</summary>
        public unsafe MaterialParameterInfo FunctionParameterInfo {
            get {return MaterialExpressionMaterialFunctionCall_ptr->FunctionParameterInfo;}
            set {MaterialExpressionMaterialFunctionCall_ptr->FunctionParameterInfo = value;}
        }
        static MaterialExpressionMaterialFunctionCall() {
            StaticClass = Main.GetClass("MaterialExpressionMaterialFunctionCall");
        }
        internal unsafe MaterialExpressionMaterialFunctionCall_fields* MaterialExpressionMaterialFunctionCall_ptr => (MaterialExpressionMaterialFunctionCall_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionMaterialFunctionCall(IntPtr p) => UObject.Make<MaterialExpressionMaterialFunctionCall>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionMaterialFunctionCall DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionMaterialFunctionCall New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
