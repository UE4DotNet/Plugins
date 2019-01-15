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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Material Expression Landscape Grass Output</summary>
    public unsafe partial class MaterialExpressionLandscapeGrassOutput : MaterialExpressionCustomOutput  {
         //TODO: array not UObject TArray GrassTypes
        static MaterialExpressionLandscapeGrassOutput() {
            StaticClass = Main.GetClass("MaterialExpressionLandscapeGrassOutput");
        }
        internal unsafe MaterialExpressionLandscapeGrassOutput_fields* MaterialExpressionLandscapeGrassOutput_ptr => (MaterialExpressionLandscapeGrassOutput_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionLandscapeGrassOutput(IntPtr p) => UObject.Make<MaterialExpressionLandscapeGrassOutput>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionLandscapeGrassOutput DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionLandscapeGrassOutput New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
