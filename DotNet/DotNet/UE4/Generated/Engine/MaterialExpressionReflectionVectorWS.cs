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
    ///<summary>Material Expression Reflection Vector WS</summary>
    public unsafe partial class MaterialExpressionReflectionVectorWS : MaterialExpression  {
        ///<summary>Defaults to Reflection Vector if not specified</summary>
        public unsafe ExpressionInput CustomWorldNormal {
            get {return MaterialExpressionReflectionVectorWS_ptr->CustomWorldNormal;}
            set {MaterialExpressionReflectionVectorWS_ptr->CustomWorldNormal = value;}
        }
        public bool bNormalizeCustomWorldNormal {
            get {return Main.GetGetBoolPropertyByName(this, "bNormalizeCustomWorldNormal"); }
            set {Main.SetGetBoolPropertyByName(this, "bNormalizeCustomWorldNormal", value); }
        }
        static MaterialExpressionReflectionVectorWS() {
            StaticClass = Main.GetClass("MaterialExpressionReflectionVectorWS");
        }
        internal unsafe MaterialExpressionReflectionVectorWS_fields* MaterialExpressionReflectionVectorWS_ptr => (MaterialExpressionReflectionVectorWS_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionReflectionVectorWS(IntPtr p) => UObject.Make<MaterialExpressionReflectionVectorWS>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionReflectionVectorWS DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionReflectionVectorWS New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
