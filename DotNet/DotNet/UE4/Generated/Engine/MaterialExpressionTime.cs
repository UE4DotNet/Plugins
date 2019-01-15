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
    ///<summary>Material Expression Time</summary>
    public unsafe partial class MaterialExpressionTime : MaterialExpression  {
        public bool bIgnorePause {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnorePause"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnorePause", value); }
        }
        public bool bOverride_Period {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_Period"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_Period", value); }
        }
        ///<summary>Period at which to wrap around time</summary>
        public unsafe float Period {
            get {return MaterialExpressionTime_ptr->Period;}
            set {MaterialExpressionTime_ptr->Period = value;}
        }
        static MaterialExpressionTime() {
            StaticClass = Main.GetClass("MaterialExpressionTime");
        }
        internal unsafe MaterialExpressionTime_fields* MaterialExpressionTime_ptr => (MaterialExpressionTime_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionTime(IntPtr p) => UObject.Make<MaterialExpressionTime>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionTime DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionTime New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
