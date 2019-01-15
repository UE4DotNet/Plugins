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
    ///<summary>Material Expression Temporal Sobol</summary>
    public unsafe partial class MaterialExpressionTemporalSobol : MaterialExpression  {
        ///<summary>Sobol point number. Use Const Index if not connected.</summary>
        public unsafe ExpressionInput Index {
            get {return MaterialExpressionTemporalSobol_ptr->Index;}
            set {MaterialExpressionTemporalSobol_ptr->Index = value;}
        }
        ///<summary>2D Seed for sequence randomization (0,0)-(1,1). Use Const Seed if not connected.</summary>
        public unsafe ExpressionInput Seed {
            get {return MaterialExpressionTemporalSobol_ptr->Seed;}
            set {MaterialExpressionTemporalSobol_ptr->Seed = value;}
        }
         //TODO: numeric uint32 ConstIndex
        ///<summary>2D Seed for sequence randomization. Only used if Seed is not connected.</summary>
        public unsafe Vector2D ConstSeed {
            get {return MaterialExpressionTemporalSobol_ptr->ConstSeed;}
            set {MaterialExpressionTemporalSobol_ptr->ConstSeed = value;}
        }
        static MaterialExpressionTemporalSobol() {
            StaticClass = Main.GetClass("MaterialExpressionTemporalSobol");
        }
        internal unsafe MaterialExpressionTemporalSobol_fields* MaterialExpressionTemporalSobol_ptr => (MaterialExpressionTemporalSobol_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionTemporalSobol(IntPtr p) => UObject.Make<MaterialExpressionTemporalSobol>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionTemporalSobol DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionTemporalSobol New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
