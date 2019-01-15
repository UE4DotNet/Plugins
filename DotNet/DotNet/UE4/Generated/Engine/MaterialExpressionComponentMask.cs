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
    ///<summary>Material Expression Component Mask</summary>
    public unsafe partial class MaterialExpressionComponentMask : MaterialExpression  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionComponentMask_ptr->Input;}
            set {MaterialExpressionComponentMask_ptr->Input = value;}
        }
        public bool R {
            get {return Main.GetGetBoolPropertyByName(this, "R"); }
            set {Main.SetGetBoolPropertyByName(this, "R", value); }
        }
        public bool G {
            get {return Main.GetGetBoolPropertyByName(this, "G"); }
            set {Main.SetGetBoolPropertyByName(this, "G", value); }
        }
        public bool B {
            get {return Main.GetGetBoolPropertyByName(this, "B"); }
            set {Main.SetGetBoolPropertyByName(this, "B", value); }
        }
        public bool A {
            get {return Main.GetGetBoolPropertyByName(this, "A"); }
            set {Main.SetGetBoolPropertyByName(this, "A", value); }
        }
        static MaterialExpressionComponentMask() {
            StaticClass = Main.GetClass("MaterialExpressionComponentMask");
        }
        internal unsafe MaterialExpressionComponentMask_fields* MaterialExpressionComponentMask_ptr => (MaterialExpressionComponentMask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionComponentMask(IntPtr p) => UObject.Make<MaterialExpressionComponentMask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionComponentMask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionComponentMask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
