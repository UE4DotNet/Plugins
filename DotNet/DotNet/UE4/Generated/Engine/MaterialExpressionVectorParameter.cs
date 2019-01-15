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
    ///<summary>Material Expression Vector Parameter</summary>
    public unsafe partial class MaterialExpressionVectorParameter : MaterialExpressionParameter  {
        ///<summary>Default Value</summary>
        public unsafe LinearColor DefaultValue {
            get {return MaterialExpressionVectorParameter_ptr->DefaultValue;}
            set {MaterialExpressionVectorParameter_ptr->DefaultValue = value;}
        }
        static MaterialExpressionVectorParameter() {
            StaticClass = Main.GetClass("MaterialExpressionVectorParameter");
        }
        internal unsafe MaterialExpressionVectorParameter_fields* MaterialExpressionVectorParameter_ptr => (MaterialExpressionVectorParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionVectorParameter(IntPtr p) => UObject.Make<MaterialExpressionVectorParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionVectorParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionVectorParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
