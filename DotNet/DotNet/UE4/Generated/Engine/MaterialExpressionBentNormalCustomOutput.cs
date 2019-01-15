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
    ///<summary>Material Expression Bent Normal Custom Output</summary>
    public unsafe partial class MaterialExpressionBentNormalCustomOutput : MaterialExpressionCustomOutput  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionBentNormalCustomOutput_ptr->Input;}
            set {MaterialExpressionBentNormalCustomOutput_ptr->Input = value;}
        }
        static MaterialExpressionBentNormalCustomOutput() {
            StaticClass = Main.GetClass("MaterialExpressionBentNormalCustomOutput");
        }
        internal unsafe MaterialExpressionBentNormalCustomOutput_fields* MaterialExpressionBentNormalCustomOutput_ptr => (MaterialExpressionBentNormalCustomOutput_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionBentNormalCustomOutput(IntPtr p) => UObject.Make<MaterialExpressionBentNormalCustomOutput>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionBentNormalCustomOutput DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionBentNormalCustomOutput New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
