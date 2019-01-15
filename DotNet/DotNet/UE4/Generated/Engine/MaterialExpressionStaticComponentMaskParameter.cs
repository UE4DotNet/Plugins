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
    ///<summary>Material Expression Static Component Mask Parameter</summary>
    public unsafe partial class MaterialExpressionStaticComponentMaskParameter : MaterialExpressionParameter  {
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionStaticComponentMaskParameter_ptr->Input;}
            set {MaterialExpressionStaticComponentMaskParameter_ptr->Input = value;}
        }
        public bool DefaultR {
            get {return Main.GetGetBoolPropertyByName(this, "DefaultR"); }
            set {Main.SetGetBoolPropertyByName(this, "DefaultR", value); }
        }
        public bool DefaultG {
            get {return Main.GetGetBoolPropertyByName(this, "DefaultG"); }
            set {Main.SetGetBoolPropertyByName(this, "DefaultG", value); }
        }
        public bool DefaultB {
            get {return Main.GetGetBoolPropertyByName(this, "DefaultB"); }
            set {Main.SetGetBoolPropertyByName(this, "DefaultB", value); }
        }
        public bool DefaultA {
            get {return Main.GetGetBoolPropertyByName(this, "DefaultA"); }
            set {Main.SetGetBoolPropertyByName(this, "DefaultA", value); }
        }
        static MaterialExpressionStaticComponentMaskParameter() {
            StaticClass = Main.GetClass("MaterialExpressionStaticComponentMaskParameter");
        }
        internal unsafe MaterialExpressionStaticComponentMaskParameter_fields* MaterialExpressionStaticComponentMaskParameter_ptr => (MaterialExpressionStaticComponentMaskParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionStaticComponentMaskParameter(IntPtr p) => UObject.Make<MaterialExpressionStaticComponentMaskParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionStaticComponentMaskParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionStaticComponentMaskParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
