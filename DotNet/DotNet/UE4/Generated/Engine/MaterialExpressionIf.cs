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
    ///<summary>Material Expression If</summary>
    public unsafe partial class MaterialExpressionIf : MaterialExpression  {
        ///<summary>A</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionIf_ptr->A;}
            set {MaterialExpressionIf_ptr->A = value;}
        }
        ///<summary>Defaults to 'ConstB' if not specified</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionIf_ptr->B;}
            set {MaterialExpressionIf_ptr->B = value;}
        }
        ///<summary>AGreater Than B</summary>
        public unsafe ExpressionInput AGreaterThanB {
            get {return MaterialExpressionIf_ptr->AGreaterThanB;}
            set {MaterialExpressionIf_ptr->AGreaterThanB = value;}
        }
        ///<summary>Defaults to 'A > B' if not specified</summary>
        public unsafe ExpressionInput AEqualsB {
            get {return MaterialExpressionIf_ptr->AEqualsB;}
            set {MaterialExpressionIf_ptr->AEqualsB = value;}
        }
        ///<summary>ALess Than B</summary>
        public unsafe ExpressionInput ALessThanB {
            get {return MaterialExpressionIf_ptr->ALessThanB;}
            set {MaterialExpressionIf_ptr->ALessThanB = value;}
        }
        ///<summary>Equals Threshold</summary>
        public unsafe float EqualsThreshold {
            get {return MaterialExpressionIf_ptr->EqualsThreshold;}
            set {MaterialExpressionIf_ptr->EqualsThreshold = value;}
        }
        ///<summary>only used if B is not hooked up</summary>
        public unsafe float ConstB {
            get {return MaterialExpressionIf_ptr->ConstB;}
            set {MaterialExpressionIf_ptr->ConstB = value;}
        }
        static MaterialExpressionIf() {
            StaticClass = Main.GetClass("MaterialExpressionIf");
        }
        internal unsafe MaterialExpressionIf_fields* MaterialExpressionIf_ptr => (MaterialExpressionIf_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionIf(IntPtr p) => UObject.Make<MaterialExpressionIf>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionIf DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionIf New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
