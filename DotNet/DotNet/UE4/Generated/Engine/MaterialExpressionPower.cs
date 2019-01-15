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
    ///<summary>Material Expression Power</summary>
    public unsafe partial class MaterialExpressionPower : MaterialExpression  {
        ///<summary>Base</summary>
        public unsafe ExpressionInput Base {
            get {return MaterialExpressionPower_ptr->Base;}
            set {MaterialExpressionPower_ptr->Base = value;}
        }
        ///<summary>Defaults to 'ConstExponent' if not specified</summary>
        public unsafe ExpressionInput Exponent {
            get {return MaterialExpressionPower_ptr->Exponent;}
            set {MaterialExpressionPower_ptr->Exponent = value;}
        }
        ///<summary>only used if Exponent is not hooked up</summary>
        public unsafe float ConstExponent {
            get {return MaterialExpressionPower_ptr->ConstExponent;}
            set {MaterialExpressionPower_ptr->ConstExponent = value;}
        }
        static MaterialExpressionPower() {
            StaticClass = Main.GetClass("MaterialExpressionPower");
        }
        internal unsafe MaterialExpressionPower_fields* MaterialExpressionPower_ptr => (MaterialExpressionPower_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionPower(IntPtr p) => UObject.Make<MaterialExpressionPower>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionPower DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionPower New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
