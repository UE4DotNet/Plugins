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
    ///<summary>Material Expression GIReplace</summary>
    public unsafe partial class MaterialExpressionGIReplace : MaterialExpression  {
        ///<summary>Used for direct lighting computations e.g. real-time shaders</summary>
        public unsafe ExpressionInput Default {
            get {return MaterialExpressionGIReplace_ptr->Default;}
            set {MaterialExpressionGIReplace_ptr->Default = value;}
        }
        ///<summary>Used for baked indirect lighting e.g. Lightmass</summary>
        public unsafe ExpressionInput StaticIndirect {
            get {return MaterialExpressionGIReplace_ptr->StaticIndirect;}
            set {MaterialExpressionGIReplace_ptr->StaticIndirect = value;}
        }
        ///<summary>Used for dynamic indirect lighting e.g. Light Propagation Volumes</summary>
        public unsafe ExpressionInput DynamicIndirect {
            get {return MaterialExpressionGIReplace_ptr->DynamicIndirect;}
            set {MaterialExpressionGIReplace_ptr->DynamicIndirect = value;}
        }
        static MaterialExpressionGIReplace() {
            StaticClass = Main.GetClass("MaterialExpressionGIReplace");
        }
        internal unsafe MaterialExpressionGIReplace_fields* MaterialExpressionGIReplace_ptr => (MaterialExpressionGIReplace_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionGIReplace(IntPtr p) => UObject.Make<MaterialExpressionGIReplace>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionGIReplace DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionGIReplace New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
