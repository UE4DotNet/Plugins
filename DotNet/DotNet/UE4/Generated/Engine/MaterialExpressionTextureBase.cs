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
    ///<summary>Material Expression Texture Base</summary>
    public unsafe partial class MaterialExpressionTextureBase : MaterialExpression  {
        ///<summary>Texture</summary>
        public unsafe Texture Texture {
            get {return MaterialExpressionTextureBase_ptr->Texture;}
            set {MaterialExpressionTextureBase_ptr->Texture = value;}
        }
        ///<summary>Sampler Type</summary>
        public unsafe byte SamplerType {
            get {return MaterialExpressionTextureBase_ptr->SamplerType;}
            set {MaterialExpressionTextureBase_ptr->SamplerType = value;}
        }
        public bool IsDefaultMeshpaintTexture {
            get {return Main.GetGetBoolPropertyByName(this, "IsDefaultMeshpaintTexture"); }
            set {Main.SetGetBoolPropertyByName(this, "IsDefaultMeshpaintTexture", value); }
        }
        static MaterialExpressionTextureBase() {
            StaticClass = Main.GetClass("MaterialExpressionTextureBase");
        }
        internal unsafe MaterialExpressionTextureBase_fields* MaterialExpressionTextureBase_ptr => (MaterialExpressionTextureBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionTextureBase(IntPtr p) => UObject.Make<MaterialExpressionTextureBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionTextureBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionTextureBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
