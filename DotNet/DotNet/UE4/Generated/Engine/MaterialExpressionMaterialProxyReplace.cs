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
    ///<summary>Material Expression Material Proxy Replace</summary>
    public unsafe partial class MaterialExpressionMaterialProxyReplace : MaterialExpression  {
        ///<summary>Realtime</summary>
        public unsafe ExpressionInput Realtime {
            get {return MaterialExpressionMaterialProxyReplace_ptr->Realtime;}
            set {MaterialExpressionMaterialProxyReplace_ptr->Realtime = value;}
        }
        ///<summary>Material Proxy</summary>
        public unsafe ExpressionInput MaterialProxy {
            get {return MaterialExpressionMaterialProxyReplace_ptr->MaterialProxy;}
            set {MaterialExpressionMaterialProxyReplace_ptr->MaterialProxy = value;}
        }
        static MaterialExpressionMaterialProxyReplace() {
            StaticClass = Main.GetClass("MaterialExpressionMaterialProxyReplace");
        }
        internal unsafe MaterialExpressionMaterialProxyReplace_fields* MaterialExpressionMaterialProxyReplace_ptr => (MaterialExpressionMaterialProxyReplace_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionMaterialProxyReplace(IntPtr p) => UObject.Make<MaterialExpressionMaterialProxyReplace>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionMaterialProxyReplace DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionMaterialProxyReplace New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
