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
    ///<summary>Specialized Material Function that acts as a blend</summary>
    public unsafe partial class MaterialFunctionMaterialLayerBlend : MaterialFunction  {
        static MaterialFunctionMaterialLayerBlend() {
            StaticClass = Main.GetClass("MaterialFunctionMaterialLayerBlend");
        }
        internal unsafe MaterialFunctionMaterialLayerBlend_fields* MaterialFunctionMaterialLayerBlend_ptr => (MaterialFunctionMaterialLayerBlend_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialFunctionMaterialLayerBlend(IntPtr p) => UObject.Make<MaterialFunctionMaterialLayerBlend>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialFunctionMaterialLayerBlend DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialFunctionMaterialLayerBlend New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
