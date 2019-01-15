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
    ///<summary>Material Expression Previous Frame Switch</summary>
    public unsafe partial class MaterialExpressionPreviousFrameSwitch : MaterialExpression  {
        ///<summary>Current Frame</summary>
        public unsafe ExpressionInput CurrentFrame {
            get {return MaterialExpressionPreviousFrameSwitch_ptr->CurrentFrame;}
            set {MaterialExpressionPreviousFrameSwitch_ptr->CurrentFrame = value;}
        }
        ///<summary>Previous Frame</summary>
        public unsafe ExpressionInput PreviousFrame {
            get {return MaterialExpressionPreviousFrameSwitch_ptr->PreviousFrame;}
            set {MaterialExpressionPreviousFrameSwitch_ptr->PreviousFrame = value;}
        }
        static MaterialExpressionPreviousFrameSwitch() {
            StaticClass = Main.GetClass("MaterialExpressionPreviousFrameSwitch");
        }
        internal unsafe MaterialExpressionPreviousFrameSwitch_fields* MaterialExpressionPreviousFrameSwitch_ptr => (MaterialExpressionPreviousFrameSwitch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionPreviousFrameSwitch(IntPtr p) => UObject.Make<MaterialExpressionPreviousFrameSwitch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionPreviousFrameSwitch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionPreviousFrameSwitch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
