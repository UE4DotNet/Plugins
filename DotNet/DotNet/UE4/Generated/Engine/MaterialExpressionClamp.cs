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
    ///<summary>Material Expression Clamp</summary>
    public unsafe partial class MaterialExpressionClamp : MaterialExpression  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionClamp_ptr->Input;}
            set {MaterialExpressionClamp_ptr->Input = value;}
        }
        ///<summary>Defaults to 'MinDefault' if not specified</summary>
        public unsafe ExpressionInput Min {
            get {return MaterialExpressionClamp_ptr->Min;}
            set {MaterialExpressionClamp_ptr->Min = value;}
        }
        ///<summary>Defaults to 'MaxDefault' if not specified</summary>
        public unsafe ExpressionInput Max {
            get {return MaterialExpressionClamp_ptr->Max;}
            set {MaterialExpressionClamp_ptr->Max = value;}
        }
        ///<summary>Clamp Mode</summary>
        public unsafe byte ClampMode {
            get {return MaterialExpressionClamp_ptr->ClampMode;}
            set {MaterialExpressionClamp_ptr->ClampMode = value;}
        }
        ///<summary>Min Default</summary>
        public unsafe float MinDefault {
            get {return MaterialExpressionClamp_ptr->MinDefault;}
            set {MaterialExpressionClamp_ptr->MinDefault = value;}
        }
        ///<summary>Max Default</summary>
        public unsafe float MaxDefault {
            get {return MaterialExpressionClamp_ptr->MaxDefault;}
            set {MaterialExpressionClamp_ptr->MaxDefault = value;}
        }
        static MaterialExpressionClamp() {
            StaticClass = Main.GetClass("MaterialExpressionClamp");
        }
        internal unsafe MaterialExpressionClamp_fields* MaterialExpressionClamp_ptr => (MaterialExpressionClamp_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionClamp(IntPtr p) => UObject.Make<MaterialExpressionClamp>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionClamp DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionClamp New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
