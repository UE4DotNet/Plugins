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
    ///<summary>Material Expression Function Input</summary>
    public unsafe partial class MaterialExpressionFunctionInput : MaterialExpression  {
        ///<summary>Used for previewing when editing the function, or when bUsePreviewValueAsDefault is enabled.</summary>
        public unsafe ExpressionInput Preview {
            get {return MaterialExpressionFunctionInput_ptr->Preview;}
            set {MaterialExpressionFunctionInput_ptr->Preview = value;}
        }
        ///<summary>The input's name, which will be drawn on the connector in function call expressions that use this function.</summary>
        public unsafe Name InputName {
            get {return MaterialExpressionFunctionInput_ptr->InputName;}
            set {MaterialExpressionFunctionInput_ptr->InputName = value;}
        }
         //TODO: string FString Description
        ///<summary>Id of this input, used to maintain references through name changes.</summary>
        public unsafe FGuid Id {
            get {return MaterialExpressionFunctionInput_ptr->Id;}
            set {MaterialExpressionFunctionInput_ptr->Id = value;}
        }
        ///<summary>Type of this input.</summary>
        ///<remarks>Input code chunks will be cast to this type, and a compiler error will be emitted if the cast fails.</remarks>
        public unsafe byte InputType {
            get {return MaterialExpressionFunctionInput_ptr->InputType;}
            set {MaterialExpressionFunctionInput_ptr->InputType = value;}
        }
        ///<summary>Value used to preview this input when editing the material function.</summary>
        public unsafe Vector4 PreviewValue {
            get {return MaterialExpressionFunctionInput_ptr->PreviewValue;}
            set {MaterialExpressionFunctionInput_ptr->PreviewValue = value;}
        }
        public bool bUsePreviewValueAsDefault {
            get {return Main.GetGetBoolPropertyByName(this, "bUsePreviewValueAsDefault"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsePreviewValueAsDefault", value); }
        }
        ///<summary>Controls where the input is displayed relative to the other inputs.</summary>
        public unsafe int SortPriority {
            get {return MaterialExpressionFunctionInput_ptr->SortPriority;}
            set {MaterialExpressionFunctionInput_ptr->SortPriority = value;}
        }
        public bool bCompilingFunctionPreview {
            get {return Main.GetGetBoolPropertyByName(this, "bCompilingFunctionPreview"); }
            set {Main.SetGetBoolPropertyByName(this, "bCompilingFunctionPreview", value); }
        }
        static MaterialExpressionFunctionInput() {
            StaticClass = Main.GetClass("MaterialExpressionFunctionInput");
        }
        internal unsafe MaterialExpressionFunctionInput_fields* MaterialExpressionFunctionInput_ptr => (MaterialExpressionFunctionInput_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionFunctionInput(IntPtr p) => UObject.Make<MaterialExpressionFunctionInput>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionFunctionInput DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionFunctionInput New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
