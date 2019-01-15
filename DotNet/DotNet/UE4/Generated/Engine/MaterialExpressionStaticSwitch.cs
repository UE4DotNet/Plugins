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
    ///<summary>Material Expression Static Switch</summary>
    public unsafe partial class MaterialExpressionStaticSwitch : MaterialExpression  {
        public bool DefaultValue {
            get {return Main.GetGetBoolPropertyByName(this, "DefaultValue"); }
            set {Main.SetGetBoolPropertyByName(this, "DefaultValue", value); }
        }
        ///<summary>A</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionStaticSwitch_ptr->A;}
            set {MaterialExpressionStaticSwitch_ptr->A = value;}
        }
        ///<summary>B</summary>
        public unsafe ExpressionInput B {
            get {return MaterialExpressionStaticSwitch_ptr->B;}
            set {MaterialExpressionStaticSwitch_ptr->B = value;}
        }
        ///<summary>Ignored if not specified</summary>
        public unsafe ExpressionInput Value {
            get {return MaterialExpressionStaticSwitch_ptr->Value;}
            set {MaterialExpressionStaticSwitch_ptr->Value = value;}
        }
        static MaterialExpressionStaticSwitch() {
            StaticClass = Main.GetClass("MaterialExpressionStaticSwitch");
        }
        internal unsafe MaterialExpressionStaticSwitch_fields* MaterialExpressionStaticSwitch_ptr => (MaterialExpressionStaticSwitch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionStaticSwitch(IntPtr p) => UObject.Make<MaterialExpressionStaticSwitch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionStaticSwitch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionStaticSwitch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
