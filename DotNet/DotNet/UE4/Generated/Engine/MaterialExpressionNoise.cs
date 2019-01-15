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
    ///<summary>Material Expression Noise</summary>
    public unsafe partial class MaterialExpressionNoise : MaterialExpression  {
        ///<summary>2 to 3 dimensional vector</summary>
        public unsafe ExpressionInput Position {
            get {return MaterialExpressionNoise_ptr->Position;}
            set {MaterialExpressionNoise_ptr->Position = value;}
        }
        ///<summary>scalar, to clamp the Levels at pixel level, can be computed like this: max(length(ddx(Position)), length(ddy(Position))</summary>
        public unsafe ExpressionInput FilterWidth {
            get {return MaterialExpressionNoise_ptr->FilterWidth;}
            set {MaterialExpressionNoise_ptr->FilterWidth = value;}
        }
        ///<summary>can also be done with a multiply on the Position</summary>
        public unsafe float Scale {
            get {return MaterialExpressionNoise_ptr->Scale;}
            set {MaterialExpressionNoise_ptr->Scale = value;}
        }
        ///<summary>Lower numbers are faster and lower quality, higher numbers are slower and higher quality</summary>
        public unsafe int Quality {
            get {return MaterialExpressionNoise_ptr->Quality;}
            set {MaterialExpressionNoise_ptr->Quality = value;}
        }
        ///<summary>Noise function, affects performance and look</summary>
        public unsafe byte NoiseFunction {
            get {return MaterialExpressionNoise_ptr->NoiseFunction;}
            set {MaterialExpressionNoise_ptr->NoiseFunction = value;}
        }
        public bool bTurbulence {
            get {return Main.GetGetBoolPropertyByName(this, "bTurbulence"); }
            set {Main.SetGetBoolPropertyByName(this, "bTurbulence", value); }
        }
        ///<summary>1 = fast but little detail, .. larger numbers cost more performance</summary>
        public unsafe int Levels {
            get {return MaterialExpressionNoise_ptr->Levels;}
            set {MaterialExpressionNoise_ptr->Levels = value;}
        }
        ///<summary>Output Min</summary>
        public unsafe float OutputMin {
            get {return MaterialExpressionNoise_ptr->OutputMin;}
            set {MaterialExpressionNoise_ptr->OutputMin = value;}
        }
        ///<summary>Output Max</summary>
        public unsafe float OutputMax {
            get {return MaterialExpressionNoise_ptr->OutputMax;}
            set {MaterialExpressionNoise_ptr->OutputMax = value;}
        }
        ///<summary>usually 2 but higher values allow efficient use of few levels</summary>
        public unsafe float LevelScale {
            get {return MaterialExpressionNoise_ptr->LevelScale;}
            set {MaterialExpressionNoise_ptr->LevelScale = value;}
        }
        public bool bTiling {
            get {return Main.GetGetBoolPropertyByName(this, "bTiling"); }
            set {Main.SetGetBoolPropertyByName(this, "bTiling", value); }
        }
         //TODO: numeric uint32 RepeatSize
        static MaterialExpressionNoise() {
            StaticClass = Main.GetClass("MaterialExpressionNoise");
        }
        internal unsafe MaterialExpressionNoise_fields* MaterialExpressionNoise_ptr => (MaterialExpressionNoise_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionNoise(IntPtr p) => UObject.Make<MaterialExpressionNoise>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionNoise DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionNoise New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
