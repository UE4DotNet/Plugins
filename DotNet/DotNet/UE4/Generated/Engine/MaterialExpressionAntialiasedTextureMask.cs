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
    ///<summary>Material Expression Antialiased Texture Mask</summary>
    public unsafe partial class MaterialExpressionAntialiasedTextureMask : MaterialExpressionTextureSampleParameter2D  {
        ///<summary>Threshold</summary>
        public unsafe float Threshold {
            get {return MaterialExpressionAntialiasedTextureMask_ptr->Threshold;}
            set {MaterialExpressionAntialiasedTextureMask_ptr->Threshold = value;}
        }
        ///<summary>Channel</summary>
        public unsafe byte Channel {
            get {return MaterialExpressionAntialiasedTextureMask_ptr->Channel;}
            set {MaterialExpressionAntialiasedTextureMask_ptr->Channel = value;}
        }
        static MaterialExpressionAntialiasedTextureMask() {
            StaticClass = Main.GetClass("MaterialExpressionAntialiasedTextureMask");
        }
        internal unsafe MaterialExpressionAntialiasedTextureMask_fields* MaterialExpressionAntialiasedTextureMask_ptr => (MaterialExpressionAntialiasedTextureMask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionAntialiasedTextureMask(IntPtr p) => UObject.Make<MaterialExpressionAntialiasedTextureMask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionAntialiasedTextureMask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionAntialiasedTextureMask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
