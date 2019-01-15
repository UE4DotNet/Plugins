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
    ///<summary>Material Expression Custom</summary>
    public unsafe partial class MaterialExpressionCustom : MaterialExpression  {
         //TODO: string FString Code
        ///<summary>Output Type</summary>
        public unsafe byte OutputType {
            get {return MaterialExpressionCustom_ptr->OutputType;}
            set {MaterialExpressionCustom_ptr->OutputType = value;}
        }
         //TODO: string FString Description
         //TODO: array not UObject TArray Inputs
        static MaterialExpressionCustom() {
            StaticClass = Main.GetClass("MaterialExpressionCustom");
        }
        internal unsafe MaterialExpressionCustom_fields* MaterialExpressionCustom_ptr => (MaterialExpressionCustom_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionCustom(IntPtr p) => UObject.Make<MaterialExpressionCustom>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionCustom DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionCustom New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
