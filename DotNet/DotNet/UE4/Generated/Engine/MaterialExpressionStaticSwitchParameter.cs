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
    ///<summary>Material Expression Static Switch Parameter</summary>
    public unsafe partial class MaterialExpressionStaticSwitchParameter : MaterialExpressionStaticBoolParameter  {
        ///<summary>A</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionStaticSwitchParameter_ptr->A;}
            set {MaterialExpressionStaticSwitchParameter_ptr->A = value;}
        }
        ///<summary>B</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionStaticSwitchParameter_ptr->B;}
            set {MaterialExpressionStaticSwitchParameter_ptr->B = value;}
        }
        static MaterialExpressionStaticSwitchParameter() {
            StaticClass = Main.GetClass("MaterialExpressionStaticSwitchParameter");
        }
        internal unsafe MaterialExpressionStaticSwitchParameter_fields* MaterialExpressionStaticSwitchParameter_ptr => (MaterialExpressionStaticSwitchParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionStaticSwitchParameter(IntPtr p) => UObject.Make<MaterialExpressionStaticSwitchParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionStaticSwitchParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionStaticSwitchParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
