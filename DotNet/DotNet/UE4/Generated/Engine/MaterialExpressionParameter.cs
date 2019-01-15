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
    ///<summary>Material Expression Parameter</summary>
    public unsafe partial class MaterialExpressionParameter : MaterialExpression  {
        ///<summary>The name of the parameter</summary>
        public unsafe Name ParameterName {
            get {return MaterialExpressionParameter_ptr->ParameterName;}
            set {MaterialExpressionParameter_ptr->ParameterName = value;}
        }
        ///<summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
        public unsafe FGuid ExpressionGUID {
            get {return MaterialExpressionParameter_ptr->ExpressionGUID;}
            set {MaterialExpressionParameter_ptr->ExpressionGUID = value;}
        }
        ///<summary>The name of the parameter Group to display in MaterialInstance Editor. Default is None group</summary>
        public unsafe Name Group {
            get {return MaterialExpressionParameter_ptr->Group;}
            set {MaterialExpressionParameter_ptr->Group = value;}
        }
        ///<summary>Controls where the this parameter is displayed in a material instance parameter list.  The lower the number the higher up in the parameter list.</summary>
        public unsafe int SortPriority {
            get {return MaterialExpressionParameter_ptr->SortPriority;}
            set {MaterialExpressionParameter_ptr->SortPriority = value;}
        }
        static MaterialExpressionParameter() {
            StaticClass = Main.GetClass("MaterialExpressionParameter");
        }
        internal unsafe MaterialExpressionParameter_fields* MaterialExpressionParameter_ptr => (MaterialExpressionParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionParameter(IntPtr p) => UObject.Make<MaterialExpressionParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
