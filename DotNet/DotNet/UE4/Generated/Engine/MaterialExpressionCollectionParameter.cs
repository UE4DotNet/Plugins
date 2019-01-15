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
    ///<summary>Material Expression Collection Parameter</summary>
    public unsafe partial class MaterialExpressionCollectionParameter : MaterialExpression  {
        ///<summary>The Parameter Collection to use.</summary>
        public unsafe MaterialParameterCollection Collection {
            get {return MaterialExpressionCollectionParameter_ptr->Collection;}
            set {MaterialExpressionCollectionParameter_ptr->Collection = value;}
        }
        ///<summary>Name of the parameter being referenced.</summary>
        public unsafe Name ParameterName {
            get {return MaterialExpressionCollectionParameter_ptr->ParameterName;}
            set {MaterialExpressionCollectionParameter_ptr->ParameterName = value;}
        }
        ///<summary>Id that is set from the name, and used to handle renaming of collection parameters.</summary>
        public unsafe FGuid ParameterId {
            get {return MaterialExpressionCollectionParameter_ptr->ParameterId;}
            set {MaterialExpressionCollectionParameter_ptr->ParameterId = value;}
        }
        static MaterialExpressionCollectionParameter() {
            StaticClass = Main.GetClass("MaterialExpressionCollectionParameter");
        }
        internal unsafe MaterialExpressionCollectionParameter_fields* MaterialExpressionCollectionParameter_ptr => (MaterialExpressionCollectionParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionCollectionParameter(IntPtr p) => UObject.Make<MaterialExpressionCollectionParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionCollectionParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionCollectionParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
