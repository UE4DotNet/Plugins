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
    ///<summary>A Material Function is a collection of material expressions that can be reused in different materials</summary>
    public unsafe partial class MaterialFunction : MaterialFunctionInterface  {
        ///<summary>Used in the material editor, points to the function asset being edited, which this function is just a preview for.</summary>
        public unsafe MaterialFunction ParentFunction {
            get {return MaterialFunction_ptr->ParentFunction;}
            set {MaterialFunction_ptr->ParentFunction = value;}
        }
         //TODO: string FString Description
        public bool bExposeToLibrary {
            get {return Main.GetGetBoolPropertyByName(this, "bExposeToLibrary"); }
            set {Main.SetGetBoolPropertyByName(this, "bExposeToLibrary", value); }
        }
        public bool bPrefixParameterNames {
            get {return Main.GetGetBoolPropertyByName(this, "bPrefixParameterNames"); }
            set {Main.SetGetBoolPropertyByName(this, "bPrefixParameterNames", value); }
        }
         //TODO: array not UObject TArray LibraryCategoriesText
        ///<summary>Array of material expressions, excluding Comments.  Used by the material editor.</summary>
        public ObjectArrayField<MaterialExpression> FunctionExpressions{ get {
            if(FunctionExpressions_store == null) FunctionExpressions_store = new ObjectArrayField<MaterialExpression> (&MaterialFunction_ptr->FunctionExpressions);
            return FunctionExpressions_store;
        } }
        private ObjectArrayField<MaterialExpression> FunctionExpressions_store;

        ///<summary>Array of comments associated with this material; viewed in the material editor.</summary>
        public ObjectArrayField<MaterialExpressionComment> FunctionEditorComments{ get {
            if(FunctionEditorComments_store == null) FunctionEditorComments_store = new ObjectArrayField<MaterialExpressionComment> (&MaterialFunction_ptr->FunctionEditorComments);
            return FunctionEditorComments_store;
        } }
        private ObjectArrayField<MaterialExpressionComment> FunctionEditorComments_store;

        ///<summary>Preview Material</summary>
        public unsafe Material PreviewMaterial {
            get {return MaterialFunction_ptr->PreviewMaterial;}
            set {MaterialFunction_ptr->PreviewMaterial = value;}
        }
        public bool bReentrantFlag {
            get {return Main.GetGetBoolPropertyByName(this, "bReentrantFlag"); }
            set {Main.SetGetBoolPropertyByName(this, "bReentrantFlag", value); }
        }
        static MaterialFunction() {
            StaticClass = Main.GetClass("MaterialFunction");
        }
        internal unsafe MaterialFunction_fields* MaterialFunction_ptr => (MaterialFunction_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialFunction(IntPtr p) => UObject.Make<MaterialFunction>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialFunction DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialFunction New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
