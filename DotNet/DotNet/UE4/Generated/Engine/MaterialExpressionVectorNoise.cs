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
    ///<summary>Material Expression Vector Noise</summary>
    public unsafe partial class MaterialExpressionVectorNoise : MaterialExpression  {
        ///<summary>2 to 3 dimensional vector</summary>
        public unsafe ExpressionInput Position {
            get {return MaterialExpressionVectorNoise_ptr->Position;}
            set {MaterialExpressionVectorNoise_ptr->Position = value;}
        }
        ///<summary>Noise function, affects performance and look</summary>
        public unsafe byte NoiseFunction {
            get {return MaterialExpressionVectorNoise_ptr->NoiseFunction;}
            set {MaterialExpressionVectorNoise_ptr->NoiseFunction = value;}
        }
        ///<summary>For noise functions where applicable, lower numbers are faster and lower quality, higher numbers are slower and higher quality</summary>
        public unsafe int Quality {
            get {return MaterialExpressionVectorNoise_ptr->Quality;}
            set {MaterialExpressionVectorNoise_ptr->Quality = value;}
        }
        public bool bTiling {
            get {return Main.GetGetBoolPropertyByName(this, "bTiling"); }
            set {Main.SetGetBoolPropertyByName(this, "bTiling", value); }
        }
         //TODO: numeric uint32 TileSize
        static MaterialExpressionVectorNoise() {
            StaticClass = Main.GetClass("MaterialExpressionVectorNoise");
        }
        internal unsafe MaterialExpressionVectorNoise_fields* MaterialExpressionVectorNoise_ptr => (MaterialExpressionVectorNoise_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionVectorNoise(IntPtr p) => UObject.Make<MaterialExpressionVectorNoise>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionVectorNoise DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionVectorNoise New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
