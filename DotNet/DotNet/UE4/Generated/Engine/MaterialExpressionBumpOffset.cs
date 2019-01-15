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
    ///<summary>Material Expression Bump Offset</summary>
    public unsafe partial class MaterialExpressionBumpOffset : MaterialExpression  {
        ///<summary>Defaults to 'ConstCoordinate' if not specified</summary>
        public unsafe ExpressionInput Coordinate {
            get {return MaterialExpressionBumpOffset_ptr->Coordinate;}
            set {MaterialExpressionBumpOffset_ptr->Coordinate = value;}
        }
        ///<summary>Height</summary>
        public unsafe ExpressionInput Height {
            get {return MaterialExpressionBumpOffset_ptr->Height;}
            set {MaterialExpressionBumpOffset_ptr->Height = value;}
        }
        ///<summary>Height Ratio Input</summary>
        public unsafe ExpressionInput HeightRatioInput {
            get {return MaterialExpressionBumpOffset_ptr->HeightRatioInput;}
            set {MaterialExpressionBumpOffset_ptr->HeightRatioInput = value;}
        }
        ///<summary>Height Ratio</summary>
        public unsafe float HeightRatio {
            get {return MaterialExpressionBumpOffset_ptr->HeightRatio;}
            set {MaterialExpressionBumpOffset_ptr->HeightRatio = value;}
        }
        ///<summary>Perceived height as a fraction of width.</summary>
        public unsafe float ReferencePlane {
            get {return MaterialExpressionBumpOffset_ptr->ReferencePlane;}
            set {MaterialExpressionBumpOffset_ptr->ReferencePlane = value;}
        }
         //TODO: numeric uint32 ConstCoordinate
        static MaterialExpressionBumpOffset() {
            StaticClass = Main.GetClass("MaterialExpressionBumpOffset");
        }
        internal unsafe MaterialExpressionBumpOffset_fields* MaterialExpressionBumpOffset_ptr => (MaterialExpressionBumpOffset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionBumpOffset(IntPtr p) => UObject.Make<MaterialExpressionBumpOffset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionBumpOffset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionBumpOffset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
