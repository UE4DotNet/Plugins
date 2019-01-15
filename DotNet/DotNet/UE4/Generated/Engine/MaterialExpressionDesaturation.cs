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
    ///<summary>Material Expression Desaturation</summary>
    public unsafe partial class MaterialExpressionDesaturation : MaterialExpression  {
        ///<summary>Outputs: Lerp(Input,dot(Input,LuminanceFactors)),Fraction)</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionDesaturation_ptr->Input;}
            set {MaterialExpressionDesaturation_ptr->Input = value;}
        }
        ///<summary>Fraction</summary>
        public unsafe ExpressionInput Fraction {
            get {return MaterialExpressionDesaturation_ptr->Fraction;}
            set {MaterialExpressionDesaturation_ptr->Fraction = value;}
        }
        ///<summary>Luminance Factors</summary>
        public unsafe LinearColor LuminanceFactors {
            get {return MaterialExpressionDesaturation_ptr->LuminanceFactors;}
            set {MaterialExpressionDesaturation_ptr->LuminanceFactors = value;}
        }
        static MaterialExpressionDesaturation() {
            StaticClass = Main.GetClass("MaterialExpressionDesaturation");
        }
        internal unsafe MaterialExpressionDesaturation_fields* MaterialExpressionDesaturation_ptr => (MaterialExpressionDesaturation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDesaturation(IntPtr p) => UObject.Make<MaterialExpressionDesaturation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDesaturation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDesaturation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
