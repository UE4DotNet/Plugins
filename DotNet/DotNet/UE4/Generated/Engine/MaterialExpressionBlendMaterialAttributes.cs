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
    ///<summary>Material Expression Blend Material Attributes</summary>
    public unsafe partial class MaterialExpressionBlendMaterialAttributes : MaterialExpression  {
        ///<summary>A</summary>
        public unsafe MaterialAttributesInput A {
            get {return MaterialExpressionBlendMaterialAttributes_ptr->A;}
            set {MaterialExpressionBlendMaterialAttributes_ptr->A = value;}
        }
        ///<summary>B</summary>
        public unsafe MaterialAttributesInput B {
            get {return MaterialExpressionBlendMaterialAttributes_ptr->B;}
            set {MaterialExpressionBlendMaterialAttributes_ptr->B = value;}
        }
        ///<summary>Alpha</summary>
        public unsafe ExpressionInput Alpha {
            get {return MaterialExpressionBlendMaterialAttributes_ptr->Alpha;}
            set {MaterialExpressionBlendMaterialAttributes_ptr->Alpha = value;}
        }
        ///<summary>Optionally skip blending attributes of this type.</summary>
        public unsafe byte PixelAttributeBlendType {
            get {return MaterialExpressionBlendMaterialAttributes_ptr->PixelAttributeBlendType;}
            set {MaterialExpressionBlendMaterialAttributes_ptr->PixelAttributeBlendType = value;}
        }
        ///<summary>Optionally skip blending attributes of this type.</summary>
        public unsafe byte VertexAttributeBlendType {
            get {return MaterialExpressionBlendMaterialAttributes_ptr->VertexAttributeBlendType;}
            set {MaterialExpressionBlendMaterialAttributes_ptr->VertexAttributeBlendType = value;}
        }
        static MaterialExpressionBlendMaterialAttributes() {
            StaticClass = Main.GetClass("MaterialExpressionBlendMaterialAttributes");
        }
        internal unsafe MaterialExpressionBlendMaterialAttributes_fields* MaterialExpressionBlendMaterialAttributes_ptr => (MaterialExpressionBlendMaterialAttributes_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionBlendMaterialAttributes(IntPtr p) => UObject.Make<MaterialExpressionBlendMaterialAttributes>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionBlendMaterialAttributes DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionBlendMaterialAttributes New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
