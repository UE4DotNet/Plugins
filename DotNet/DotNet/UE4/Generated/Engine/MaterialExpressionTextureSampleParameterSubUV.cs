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
    ///<summary>Material Expression Texture Sample Parameter Sub UV</summary>
    public unsafe partial class MaterialExpressionTextureSampleParameterSubUV : MaterialExpressionTextureSampleParameter2D  {
        public bool bBlend {
            get {return Main.GetGetBoolPropertyByName(this, "bBlend"); }
            set {Main.SetGetBoolPropertyByName(this, "bBlend", value); }
        }
        static MaterialExpressionTextureSampleParameterSubUV() {
            StaticClass = Main.GetClass("MaterialExpressionTextureSampleParameterSubUV");
        }
        internal unsafe MaterialExpressionTextureSampleParameterSubUV_fields* MaterialExpressionTextureSampleParameterSubUV_ptr => (MaterialExpressionTextureSampleParameterSubUV_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionTextureSampleParameterSubUV(IntPtr p) => UObject.Make<MaterialExpressionTextureSampleParameterSubUV>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionTextureSampleParameterSubUV DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionTextureSampleParameterSubUV New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
