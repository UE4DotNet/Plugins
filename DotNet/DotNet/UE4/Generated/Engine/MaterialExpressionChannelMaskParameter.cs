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
    ///<summary>Material Expression Channel Mask Parameter</summary>
    public unsafe partial class MaterialExpressionChannelMaskParameter : MaterialExpressionVectorParameter  {
        ///<summary>Mask Channel</summary>
        public unsafe byte MaskChannel {
            get {return MaterialExpressionChannelMaskParameter_ptr->MaskChannel;}
            set {MaterialExpressionChannelMaskParameter_ptr->MaskChannel = value;}
        }
        ///<summary>Input</summary>
        public unsafe ExpressionInput Input {
            get {return MaterialExpressionChannelMaskParameter_ptr->Input;}
            set {MaterialExpressionChannelMaskParameter_ptr->Input = value;}
        }
        static MaterialExpressionChannelMaskParameter() {
            StaticClass = Main.GetClass("MaterialExpressionChannelMaskParameter");
        }
        internal unsafe MaterialExpressionChannelMaskParameter_fields* MaterialExpressionChannelMaskParameter_ptr => (MaterialExpressionChannelMaskParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionChannelMaskParameter(IntPtr p) => UObject.Make<MaterialExpressionChannelMaskParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionChannelMaskParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionChannelMaskParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
