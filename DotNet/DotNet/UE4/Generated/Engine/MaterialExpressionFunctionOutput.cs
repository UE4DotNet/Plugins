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
    ///<summary>Material Expression Function Output</summary>
    public unsafe partial class MaterialExpressionFunctionOutput : MaterialExpression  {
        ///<summary>The output's name, which will be drawn on the connector in function call expressions that use this function.</summary>
        public unsafe Name OutputName {
            get {return MaterialExpressionFunctionOutput_ptr->OutputName;}
            set {MaterialExpressionFunctionOutput_ptr->OutputName = value;}
        }
         //TODO: string FString Description
        ///<summary>Controls where the output is displayed relative to the other outputs.</summary>
        public unsafe int SortPriority {
            get {return MaterialExpressionFunctionOutput_ptr->SortPriority;}
            set {MaterialExpressionFunctionOutput_ptr->SortPriority = value;}
        }
        ///<summary>Stores the expression in the material function connected to this output.</summary>
        public unsafe ExpressionInput A {
            get {return MaterialExpressionFunctionOutput_ptr->A;}
            set {MaterialExpressionFunctionOutput_ptr->A = value;}
        }
        public bool bLastPreviewed {
            get {return Main.GetGetBoolPropertyByName(this, "bLastPreviewed"); }
            set {Main.SetGetBoolPropertyByName(this, "bLastPreviewed", value); }
        }
        ///<summary>Id of this input, used to maintain references through name changes.</summary>
        public unsafe FGuid Id {
            get {return MaterialExpressionFunctionOutput_ptr->Id;}
            set {MaterialExpressionFunctionOutput_ptr->Id = value;}
        }
        static MaterialExpressionFunctionOutput() {
            StaticClass = Main.GetClass("MaterialExpressionFunctionOutput");
        }
        internal unsafe MaterialExpressionFunctionOutput_fields* MaterialExpressionFunctionOutput_ptr => (MaterialExpressionFunctionOutput_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionFunctionOutput(IntPtr p) => UObject.Make<MaterialExpressionFunctionOutput>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionFunctionOutput DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionFunctionOutput New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
