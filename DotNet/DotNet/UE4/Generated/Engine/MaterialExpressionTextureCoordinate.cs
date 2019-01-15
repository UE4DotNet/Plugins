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
    ///<summary>Material Expression Texture Coordinate</summary>
    public unsafe partial class MaterialExpressionTextureCoordinate : MaterialExpression  {
        ///<summary>Texture coordinate index</summary>
        public unsafe int CoordinateIndex {
            get {return MaterialExpressionTextureCoordinate_ptr->CoordinateIndex;}
            set {MaterialExpressionTextureCoordinate_ptr->CoordinateIndex = value;}
        }
        ///<summary>Controls how much the texture tiles horizontally, by scaling the U component of the vertex UVs by the specified amount.</summary>
        public unsafe float UTiling {
            get {return MaterialExpressionTextureCoordinate_ptr->UTiling;}
            set {MaterialExpressionTextureCoordinate_ptr->UTiling = value;}
        }
        ///<summary>Controls how much the texture tiles vertically, by scaling the V component of the vertex UVs by the specified amount.</summary>
        public unsafe float VTiling {
            get {return MaterialExpressionTextureCoordinate_ptr->VTiling;}
            set {MaterialExpressionTextureCoordinate_ptr->VTiling = value;}
        }
        public bool UnMirrorU {
            get {return Main.GetGetBoolPropertyByName(this, "UnMirrorU"); }
            set {Main.SetGetBoolPropertyByName(this, "UnMirrorU", value); }
        }
        public bool UnMirrorV {
            get {return Main.GetGetBoolPropertyByName(this, "UnMirrorV"); }
            set {Main.SetGetBoolPropertyByName(this, "UnMirrorV", value); }
        }
        static MaterialExpressionTextureCoordinate() {
            StaticClass = Main.GetClass("MaterialExpressionTextureCoordinate");
        }
        internal unsafe MaterialExpressionTextureCoordinate_fields* MaterialExpressionTextureCoordinate_ptr => (MaterialExpressionTextureCoordinate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionTextureCoordinate(IntPtr p) => UObject.Make<MaterialExpressionTextureCoordinate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionTextureCoordinate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionTextureCoordinate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
