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
    ///<summary>Material Expression Sphere Mask</summary>
    public unsafe partial class MaterialExpressionSphereMask : MaterialExpression  {
        ///<summary>1 to 4 dimensional vector, should be the same type as B</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionSphereMask_ptr->A;}
            set {MaterialExpressionSphereMask_ptr->A = value;}
        }
        ///<summary>1 to 4 dimensional vector, should be the same type as A</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionSphereMask_ptr->B;}
            set {MaterialExpressionSphereMask_ptr->B = value;}
        }
        ///<summary>Defaults to 'AttenuationRadius' if not specified</summary>
        public unsafe ExpressionInput Radius {
            get {return MaterialExpressionSphereMask_ptr->Radius;}
            set {MaterialExpressionSphereMask_ptr->Radius = value;}
        }
        ///<summary>Defaults to 'HardnessPercent' if not specified</summary>
        public unsafe ExpressionInput Hardness {
            get {return MaterialExpressionSphereMask_ptr->Hardness;}
            set {MaterialExpressionSphereMask_ptr->Hardness = value;}
        }
        ///<summary>in the unit that A and B are measured</summary>
        public unsafe float AttenuationRadius {
            get {return MaterialExpressionSphereMask_ptr->AttenuationRadius;}
            set {MaterialExpressionSphereMask_ptr->AttenuationRadius = value;}
        }
        ///<summary>in percent 0%=soft .. 100%=hard</summary>
        public unsafe float HardnessPercent {
            get {return MaterialExpressionSphereMask_ptr->HardnessPercent;}
            set {MaterialExpressionSphereMask_ptr->HardnessPercent = value;}
        }
        static MaterialExpressionSphereMask() {
            StaticClass = Main.GetClass("MaterialExpressionSphereMask");
        }
        internal unsafe MaterialExpressionSphereMask_fields* MaterialExpressionSphereMask_ptr => (MaterialExpressionSphereMask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionSphereMask(IntPtr p) => UObject.Make<MaterialExpressionSphereMask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionSphereMask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionSphereMask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
