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
    ///<summary>Material Expression Lightmass Replace</summary>
    public unsafe partial class MaterialExpressionLightmassReplace : MaterialExpression  {
        ///<summary>Realtime</summary>
        public unsafe ExpressionInput Realtime {
            get {return MaterialExpressionLightmassReplace_ptr->Realtime;}
            set {MaterialExpressionLightmassReplace_ptr->Realtime = value;}
        }
        ///<summary>Lightmass</summary>
        public unsafe ExpressionInput Lightmass {
            get {return MaterialExpressionLightmassReplace_ptr->Lightmass;}
            set {MaterialExpressionLightmassReplace_ptr->Lightmass = value;}
        }
        static MaterialExpressionLightmassReplace() {
            StaticClass = Main.GetClass("MaterialExpressionLightmassReplace");
        }
        internal unsafe MaterialExpressionLightmassReplace_fields* MaterialExpressionLightmassReplace_ptr => (MaterialExpressionLightmassReplace_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionLightmassReplace(IntPtr p) => UObject.Make<MaterialExpressionLightmassReplace>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionLightmassReplace DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionLightmassReplace New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
