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
    ///<summary>Material Expression Distance to Nearest Surface</summary>
    public unsafe partial class MaterialExpressionDistanceToNearestSurface : MaterialExpression  {
        ///<summary>Defaults to current world position if not specified</summary>
        public unsafe ExpressionInput Position {
            get {return MaterialExpressionDistanceToNearestSurface_ptr->Position;}
            set {MaterialExpressionDistanceToNearestSurface_ptr->Position = value;}
        }
        static MaterialExpressionDistanceToNearestSurface() {
            StaticClass = Main.GetClass("MaterialExpressionDistanceToNearestSurface");
        }
        internal unsafe MaterialExpressionDistanceToNearestSurface_fields* MaterialExpressionDistanceToNearestSurface_ptr => (MaterialExpressionDistanceToNearestSurface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionDistanceToNearestSurface(IntPtr p) => UObject.Make<MaterialExpressionDistanceToNearestSurface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionDistanceToNearestSurface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionDistanceToNearestSurface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
