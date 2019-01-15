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
    ///<summary>Material Expression Break Material Attributes</summary>
    public unsafe partial class MaterialExpressionBreakMaterialAttributes : MaterialExpression  {
        ///<summary>Material Attributes</summary>
        public unsafe MaterialAttributesInput MaterialAttributes {
            get {return MaterialExpressionBreakMaterialAttributes_ptr->MaterialAttributes;}
            set {MaterialExpressionBreakMaterialAttributes_ptr->MaterialAttributes = value;}
        }
        static MaterialExpressionBreakMaterialAttributes() {
            StaticClass = Main.GetClass("MaterialExpressionBreakMaterialAttributes");
        }
        internal unsafe MaterialExpressionBreakMaterialAttributes_fields* MaterialExpressionBreakMaterialAttributes_ptr => (MaterialExpressionBreakMaterialAttributes_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionBreakMaterialAttributes(IntPtr p) => UObject.Make<MaterialExpressionBreakMaterialAttributes>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionBreakMaterialAttributes DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionBreakMaterialAttributes New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
