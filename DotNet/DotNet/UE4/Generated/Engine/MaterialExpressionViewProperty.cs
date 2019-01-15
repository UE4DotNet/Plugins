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
    ///<summary>Material Expression View Property</summary>
    public unsafe partial class MaterialExpressionViewProperty : MaterialExpression  {
        ///<summary>View input property to be accessed</summary>
        public unsafe byte Property {
            get {return MaterialExpressionViewProperty_ptr->Property;}
            set {MaterialExpressionViewProperty_ptr->Property = value;}
        }
        static MaterialExpressionViewProperty() {
            StaticClass = Main.GetClass("MaterialExpressionViewProperty");
        }
        internal unsafe MaterialExpressionViewProperty_fields* MaterialExpressionViewProperty_ptr => (MaterialExpressionViewProperty_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionViewProperty(IntPtr p) => UObject.Make<MaterialExpressionViewProperty>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionViewProperty DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionViewProperty New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
