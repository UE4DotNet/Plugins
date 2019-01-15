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
    ///<summary>Provides access to the EyeAdaptation render target.</summary>
    public unsafe partial class MaterialExpressionEyeAdaptation : MaterialExpression  {
        static MaterialExpressionEyeAdaptation() {
            StaticClass = Main.GetClass("MaterialExpressionEyeAdaptation");
        }
        internal unsafe MaterialExpressionEyeAdaptation_fields* MaterialExpressionEyeAdaptation_ptr => (MaterialExpressionEyeAdaptation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionEyeAdaptation(IntPtr p) => UObject.Make<MaterialExpressionEyeAdaptation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionEyeAdaptation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionEyeAdaptation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
