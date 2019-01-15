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
    ///<summary>Material Expression Rotator</summary>
    public unsafe partial class MaterialExpressionRotator : MaterialExpression  {
        ///<summary>Defaults to 'ConstCoordinate' if not specified</summary>
        public unsafe ExpressionInput Coordinate {
            get {return MaterialExpressionRotator_ptr->Coordinate;}
            set {MaterialExpressionRotator_ptr->Coordinate = value;}
        }
        ///<summary>Defaults to Game Time if not specified</summary>
        public unsafe ExpressionInput Time {
            get {return MaterialExpressionRotator_ptr->Time;}
            set {MaterialExpressionRotator_ptr->Time = value;}
        }
        ///<summary>Center X</summary>
        public unsafe float CenterX {
            get {return MaterialExpressionRotator_ptr->CenterX;}
            set {MaterialExpressionRotator_ptr->CenterX = value;}
        }
        ///<summary>Center Y</summary>
        public unsafe float CenterY {
            get {return MaterialExpressionRotator_ptr->CenterY;}
            set {MaterialExpressionRotator_ptr->CenterY = value;}
        }
        ///<summary>Speed</summary>
        public unsafe float Speed {
            get {return MaterialExpressionRotator_ptr->Speed;}
            set {MaterialExpressionRotator_ptr->Speed = value;}
        }
         //TODO: numeric uint32 ConstCoordinate
        static MaterialExpressionRotator() {
            StaticClass = Main.GetClass("MaterialExpressionRotator");
        }
        internal unsafe MaterialExpressionRotator_fields* MaterialExpressionRotator_ptr => (MaterialExpressionRotator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionRotator(IntPtr p) => UObject.Make<MaterialExpressionRotator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionRotator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionRotator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
