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
    ///<summary>Material Expression</summary>
    public unsafe partial class MaterialExpression : UObject  {
        ///<summary>Material Expression Editor X</summary>
        public unsafe int MaterialExpressionEditorX {
            get {return MaterialExpression_ptr->MaterialExpressionEditorX;}
            set {MaterialExpression_ptr->MaterialExpressionEditorX = value;}
        }
        ///<summary>Material Expression Editor Y</summary>
        public unsafe int MaterialExpressionEditorY {
            get {return MaterialExpression_ptr->MaterialExpressionEditorY;}
            set {MaterialExpression_ptr->MaterialExpressionEditorY = value;}
        }
        ///<summary>Expression's Graph representation</summary>
        public unsafe EdGraphNode GraphNode {
            get {return MaterialExpression_ptr->GraphNode;}
            set {MaterialExpression_ptr->GraphNode = value;}
        }
        ///<summary>GUID to uniquely identify this node, to help the tutorials out</summary>
        public unsafe FGuid MaterialExpressionGuid {
            get {return MaterialExpression_ptr->MaterialExpressionGuid;}
            set {MaterialExpression_ptr->MaterialExpressionGuid = value;}
        }
        ///<summary>The material that this expression is currently being compiled in.</summary>
        ///<remarks>This is not necessarily the object which owns this expression, for example a preview material compiling a material function's expressions.</remarks>
        public unsafe Material Material {
            get {return MaterialExpression_ptr->Material;}
            set {MaterialExpression_ptr->Material = value;}
        }
        ///<summary>The material function that this expression is being used with, if any.</summary>
        ///<remarks>This will be NULL if the expression belongs to a function that is currently being edited,</remarks>
        public unsafe MaterialFunction Function {
            get {return MaterialExpression_ptr->Function;}
            set {MaterialExpression_ptr->Function = value;}
        }
         //TODO: string FString Desc
        public bool bRealtimePreview {
            get {return Main.GetGetBoolPropertyByName(this, "bRealtimePreview"); }
            set {Main.SetGetBoolPropertyByName(this, "bRealtimePreview", value); }
        }
        public bool bNeedToUpdatePreview {
            get {return Main.GetGetBoolPropertyByName(this, "bNeedToUpdatePreview"); }
            set {Main.SetGetBoolPropertyByName(this, "bNeedToUpdatePreview", value); }
        }
        public bool bIsParameterExpression {
            get {return Main.GetGetBoolPropertyByName(this, "bIsParameterExpression"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsParameterExpression", value); }
        }
        public bool bCommentBubbleVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bCommentBubbleVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bCommentBubbleVisible", value); }
        }
        public bool bShowOutputNameOnPin {
            get {return Main.GetGetBoolPropertyByName(this, "bShowOutputNameOnPin"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowOutputNameOnPin", value); }
        }
        public bool bShowMaskColorsOnPin {
            get {return Main.GetGetBoolPropertyByName(this, "bShowMaskColorsOnPin"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowMaskColorsOnPin", value); }
        }
        public bool bHidePreviewWindow {
            get {return Main.GetGetBoolPropertyByName(this, "bHidePreviewWindow"); }
            set {Main.SetGetBoolPropertyByName(this, "bHidePreviewWindow", value); }
        }
        public bool bCollapsed {
            get {return Main.GetGetBoolPropertyByName(this, "bCollapsed"); }
            set {Main.SetGetBoolPropertyByName(this, "bCollapsed", value); }
        }
        public bool bShaderInputData {
            get {return Main.GetGetBoolPropertyByName(this, "bShaderInputData"); }
            set {Main.SetGetBoolPropertyByName(this, "bShaderInputData", value); }
        }
        public bool bShowInputs {
            get {return Main.GetGetBoolPropertyByName(this, "bShowInputs"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowInputs", value); }
        }
        public bool bShowOutputs {
            get {return Main.GetGetBoolPropertyByName(this, "bShowOutputs"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowOutputs", value); }
        }
         //TODO: array not UObject TArray MenuCategories
         //TODO: array not UObject TArray Outputs
        static MaterialExpression() {
            StaticClass = Main.GetClass("MaterialExpression");
        }
        internal unsafe MaterialExpression_fields* MaterialExpression_ptr => (MaterialExpression_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpression(IntPtr p) => UObject.Make<MaterialExpression>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpression DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpression New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
