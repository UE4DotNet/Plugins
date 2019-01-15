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
    ///<summary>Material Expression Font Sample</summary>
    public unsafe partial class MaterialExpressionFontSample : MaterialExpression  {
        ///<summary>font resource that will be sampled</summary>
        public unsafe Font Font {
            get {return MaterialExpressionFontSample_ptr->Font;}
            set {MaterialExpressionFontSample_ptr->Font = value;}
        }
        ///<summary>allow access to the various font pages</summary>
        public unsafe int FontTexturePage {
            get {return MaterialExpressionFontSample_ptr->FontTexturePage;}
            set {MaterialExpressionFontSample_ptr->FontTexturePage = value;}
        }
        static MaterialExpressionFontSample() {
            StaticClass = Main.GetClass("MaterialExpressionFontSample");
        }
        internal unsafe MaterialExpressionFontSample_fields* MaterialExpressionFontSample_ptr => (MaterialExpressionFontSample_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionFontSample(IntPtr p) => UObject.Make<MaterialExpressionFontSample>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionFontSample DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionFontSample New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
