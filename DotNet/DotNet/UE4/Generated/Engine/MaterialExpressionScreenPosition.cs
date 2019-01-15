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
    ///<summary>Material Expression Screen Position</summary>
    public unsafe partial class MaterialExpressionScreenPosition : MaterialExpression  {
        static MaterialExpressionScreenPosition() {
            StaticClass = Main.GetClass("MaterialExpressionScreenPosition");
        }
        internal unsafe MaterialExpressionScreenPosition_fields* MaterialExpressionScreenPosition_ptr => (MaterialExpressionScreenPosition_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionScreenPosition(IntPtr p) => UObject.Make<MaterialExpressionScreenPosition>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionScreenPosition DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionScreenPosition New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
