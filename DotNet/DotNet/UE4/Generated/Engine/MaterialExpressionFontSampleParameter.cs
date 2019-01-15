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
    ///<summary>Material Expression Font Sample Parameter</summary>
    public unsafe partial class MaterialExpressionFontSampleParameter : MaterialExpressionFontSample  {
        ///<summary>name to be referenced when we want to find and set thsi parameter</summary>
        public unsafe Name ParameterName {
            get {return MaterialExpressionFontSampleParameter_ptr->ParameterName;}
            set {MaterialExpressionFontSampleParameter_ptr->ParameterName = value;}
        }
        ///<summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
        public unsafe FGuid ExpressionGUID {
            get {return MaterialExpressionFontSampleParameter_ptr->ExpressionGUID;}
            set {MaterialExpressionFontSampleParameter_ptr->ExpressionGUID = value;}
        }
        ///<summary>The name of the parameter Group to display in MaterialInstance Editor. Default is None group</summary>
        public unsafe Name Group {
            get {return MaterialExpressionFontSampleParameter_ptr->Group;}
            set {MaterialExpressionFontSampleParameter_ptr->Group = value;}
        }
        ///<summary>Controls where the this parameter is displayed in a material instance parameter list. The lower the number the higher up in the parameter list.</summary>
        public unsafe int SortPriority {
            get {return MaterialExpressionFontSampleParameter_ptr->SortPriority;}
            set {MaterialExpressionFontSampleParameter_ptr->SortPriority = value;}
        }
        static MaterialExpressionFontSampleParameter() {
            StaticClass = Main.GetClass("MaterialExpressionFontSampleParameter");
        }
        internal unsafe MaterialExpressionFontSampleParameter_fields* MaterialExpressionFontSampleParameter_ptr => (MaterialExpressionFontSampleParameter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionFontSampleParameter(IntPtr p) => UObject.Make<MaterialExpressionFontSampleParameter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionFontSampleParameter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionFontSampleParameter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
