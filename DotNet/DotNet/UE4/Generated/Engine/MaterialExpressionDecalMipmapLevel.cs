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
    ///<summary>Material Expression Decal Mipmap Level</summary>
    public unsafe partial class MaterialExpressionDecalMipmapLevel : MaterialExpression  {
        ///<summary>Defaults to '(Const Width, Const Height)' if not specified</summary>
        public unsafe ExpressionInput TextureSize {
            get {return MaterialExpressionDecalMipmapLevel_ptr->TextureSize;}
            set {MaterialExpressionDecalMipmapLevel_ptr->TextureSize = value;}
        }
        ///<summary>only used if TextureSize is not hooked up</summary>
        public unsafe float ConstWidth {
            get {return MaterialExpressionDecalMipmapLevel_ptr->ConstWidth;}
            set {MaterialExpressionDecalMipmapLevel_ptr->ConstWidth = value;}
        }
        ///<summary>Const Height</summary>
        public unsafe float ConstHeight {
            get {return MaterialExpressionDecalMipmapLevel_ptr->ConstHeight;}
            set {MaterialExpressionDecalMipmapLevel_ptr->ConstHeight = value;}
        }
        static MaterialExpressionDecalMipmapLevel() {
            StaticClass = Main.GetClass("MaterialExpressionDecalMipmapLevel");
        }
        internal unsafe MaterialExpressionDecalMipmapLevel_fields* MaterialExpressionDecalMipmapLevel_ptr => (MaterialExpressionDecalMipmapLevel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDecalMipmapLevel(IntPtr p) => UObject.Make<MaterialExpressionDecalMipmapLevel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDecalMipmapLevel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDecalMipmapLevel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
