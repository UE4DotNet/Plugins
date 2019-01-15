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
    ///<summary>Material Expression Feature Level Switch</summary>
    public unsafe partial class MaterialExpressionFeatureLevelSwitch : MaterialExpression  {
        ///<summary>Default connection, used when a certain feature level doesn't have an override.</summary>
        public unsafe ExpressionInput Default {
            get {return MaterialExpressionFeatureLevelSwitch_ptr->Default;}
            set {MaterialExpressionFeatureLevelSwitch_ptr->Default = value;}
        }
        ///<summary>Inputs</summary>
        public unsafe ExpressionInput Inputs {
            get {return MaterialExpressionFeatureLevelSwitch_ptr->Inputs;}
            set {MaterialExpressionFeatureLevelSwitch_ptr->Inputs = value;}
        }
        static MaterialExpressionFeatureLevelSwitch() {
            StaticClass = Main.GetClass("MaterialExpressionFeatureLevelSwitch");
        }
        internal unsafe MaterialExpressionFeatureLevelSwitch_fields* MaterialExpressionFeatureLevelSwitch_ptr => (MaterialExpressionFeatureLevelSwitch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionFeatureLevelSwitch(IntPtr p) => UObject.Make<MaterialExpressionFeatureLevelSwitch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionFeatureLevelSwitch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionFeatureLevelSwitch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
