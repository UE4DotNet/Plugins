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
    ///<summary>Material Expression Scalar Parameter</summary>
    public unsafe partial class MaterialExpressionScalarParameter : MaterialExpressionParameter  {
        ///<summary>Default Value</summary>
        public unsafe float DefaultValue {
            get {return MaterialExpressionScalarParameter_ptr->DefaultValue;}
            set {MaterialExpressionScalarParameter_ptr->DefaultValue = value;}
        }
        ///<summary>Sets the lower bound for the slider on this parameter in the material instance editor.</summary>
        public unsafe float SliderMin {
            get {return MaterialExpressionScalarParameter_ptr->SliderMin;}
            set {MaterialExpressionScalarParameter_ptr->SliderMin = value;}
        }
        ///<summary>Sets the upper bound for the slider on this parameter in the material instance editor.</summary>
        ///<remarks>The slider will be disabled if SliderMax <= SliderMin.</remarks>
        public unsafe float SliderMax {
            get {return MaterialExpressionScalarParameter_ptr->SliderMax;}
            set {MaterialExpressionScalarParameter_ptr->SliderMax = value;}
        }
        static MaterialExpressionScalarParameter() {
            StaticClass = Main.GetClass("MaterialExpressionScalarParameter");
        }
        internal unsafe MaterialExpressionScalarParameter_fields* MaterialExpressionScalarParameter_ptr => (MaterialExpressionScalarParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionScalarParameter(IntPtr p) => UObject.Make<MaterialExpressionScalarParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionScalarParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionScalarParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
