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
    ///<summary>Material Expression Texture Sample Parameter 2D</summary>
    public unsafe partial class MaterialExpressionTextureSampleParameter2D : MaterialExpressionTextureSampleParameter  {
        static MaterialExpressionTextureSampleParameter2D() {
            StaticClass = Main.GetClass("MaterialExpressionTextureSampleParameter2D");
        }
        internal unsafe MaterialExpressionTextureSampleParameter2D_fields* MaterialExpressionTextureSampleParameter2D_ptr => (MaterialExpressionTextureSampleParameter2D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionTextureSampleParameter2D(IntPtr p) => UObject.Make<MaterialExpressionTextureSampleParameter2D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionTextureSampleParameter2D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionTextureSampleParameter2D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
