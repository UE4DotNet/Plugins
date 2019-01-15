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
    ///<summary>Material Expression Sobol</summary>
    public unsafe partial class MaterialExpressionSobol : MaterialExpression  {
        ///<summary>2D integer cell in 256x256 grid.</summary>
        ///<remarks>Uses cell (0,0) if not connected</remarks>
        public unsafe ExpressionInput Cell {
            get {return MaterialExpressionSobol_ptr->Cell;}
            set {MaterialExpressionSobol_ptr->Cell = value;}
        }
        ///<summary>Sobol point number. Use Const Index if not connected.</summary>
        public unsafe ExpressionInput Index {
            get {return MaterialExpressionSobol_ptr->Index;}
            set {MaterialExpressionSobol_ptr->Index = value;}
        }
        ///<summary>2D Seed for sequence randomization (0,0)-(1,1). Use Const Seed if not connected.</summary>
        public unsafe ExpressionInput Seed {
            get {return MaterialExpressionSobol_ptr->Seed;}
            set {MaterialExpressionSobol_ptr->Seed = value;}
        }
         //TODO: numeric uint32 ConstIndex
        ///<summary>2D Seed for sequence randomization. Only used if Seed is not connected.</summary>
        public unsafe Vector2D ConstSeed {
            get {return MaterialExpressionSobol_ptr->ConstSeed;}
            set {MaterialExpressionSobol_ptr->ConstSeed = value;}
        }
        static MaterialExpressionSobol() {
            StaticClass = Main.GetClass("MaterialExpressionSobol");
        }
        internal unsafe MaterialExpressionSobol_fields* MaterialExpressionSobol_ptr => (MaterialExpressionSobol_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionSobol(IntPtr p) => UObject.Make<MaterialExpressionSobol>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionSobol DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionSobol New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
