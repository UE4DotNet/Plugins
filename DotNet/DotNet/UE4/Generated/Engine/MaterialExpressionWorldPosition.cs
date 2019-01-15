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
    ///<summary>Material Expression World Position</summary>
    public unsafe partial class MaterialExpressionWorldPosition : MaterialExpression  {
        ///<summary>World Position Shader Offset</summary>
        public unsafe byte WorldPositionShaderOffset {
            get {return MaterialExpressionWorldPosition_ptr->WorldPositionShaderOffset;}
            set {MaterialExpressionWorldPosition_ptr->WorldPositionShaderOffset = value;}
        }
        static MaterialExpressionWorldPosition() {
            StaticClass = Main.GetClass("MaterialExpressionWorldPosition");
        }
        internal unsafe MaterialExpressionWorldPosition_fields* MaterialExpressionWorldPosition_ptr => (MaterialExpressionWorldPosition_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionWorldPosition(IntPtr p) => UObject.Make<MaterialExpressionWorldPosition>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionWorldPosition DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionWorldPosition New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
