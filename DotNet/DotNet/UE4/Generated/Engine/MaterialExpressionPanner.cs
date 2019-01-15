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
    ///<summary>Material Expression Panner</summary>
    public unsafe partial class MaterialExpressionPanner : MaterialExpression  {
        ///<summary>Defaults to 'ConstCoordinate' if not specified</summary>
        public unsafe ExpressionInput Coordinate {
            get {return MaterialExpressionPanner_ptr->Coordinate;}
            set {MaterialExpressionPanner_ptr->Coordinate = value;}
        }
        ///<summary>Defaults to Game Time if not specified</summary>
        public unsafe ExpressionInput Time {
            get {return MaterialExpressionPanner_ptr->Time;}
            set {MaterialExpressionPanner_ptr->Time = value;}
        }
        ///<summary>Vector2 speed scale, if specified</summary>
        public unsafe ExpressionInput Speed {
            get {return MaterialExpressionPanner_ptr->Speed;}
            set {MaterialExpressionPanner_ptr->Speed = value;}
        }
        ///<summary>Speed X</summary>
        public unsafe float SpeedX {
            get {return MaterialExpressionPanner_ptr->SpeedX;}
            set {MaterialExpressionPanner_ptr->SpeedX = value;}
        }
        ///<summary>Speed Y</summary>
        public unsafe float SpeedY {
            get {return MaterialExpressionPanner_ptr->SpeedY;}
            set {MaterialExpressionPanner_ptr->SpeedY = value;}
        }
         //TODO: numeric uint32 ConstCoordinate
        public bool bFractionalPart {
            get {return Main.GetGetBoolPropertyByName(this, "bFractionalPart"); }
            set {Main.SetGetBoolPropertyByName(this, "bFractionalPart", value); }
        }
        static MaterialExpressionPanner() {
            StaticClass = Main.GetClass("MaterialExpressionPanner");
        }
        internal unsafe MaterialExpressionPanner_fields* MaterialExpressionPanner_ptr => (MaterialExpressionPanner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionPanner(IntPtr p) => UObject.Make<MaterialExpressionPanner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionPanner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionPanner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
