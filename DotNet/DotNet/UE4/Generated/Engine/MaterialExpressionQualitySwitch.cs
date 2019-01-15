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
    ///<summary>Material Expression Quality Switch</summary>
    public unsafe partial class MaterialExpressionQualitySwitch : MaterialExpression  {
        ///<summary>Default connection, used when a specific quality level input is missing.</summary>
        public unsafe ExpressionInput Default {
            get {return MaterialExpressionQualitySwitch_ptr->Default;}
            set {MaterialExpressionQualitySwitch_ptr->Default = value;}
        }
        ///<summary>Inputs</summary>
        public unsafe ExpressionInput Inputs {
            get {return MaterialExpressionQualitySwitch_ptr->Inputs;}
            set {MaterialExpressionQualitySwitch_ptr->Inputs = value;}
        }
        static MaterialExpressionQualitySwitch() {
            StaticClass = Main.GetClass("MaterialExpressionQualitySwitch");
        }
        internal unsafe MaterialExpressionQualitySwitch_fields* MaterialExpressionQualitySwitch_ptr => (MaterialExpressionQualitySwitch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionQualitySwitch(IntPtr p) => UObject.Make<MaterialExpressionQualitySwitch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionQualitySwitch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionQualitySwitch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
