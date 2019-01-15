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
using UE4.MaterialEditor.Native;
using UE4.Engine;

namespace UE4.MaterialEditor {
    ///<summary>Blueprint library for creating/editing Materials</summary>
    public unsafe partial class MaterialEditingLibrary : BlueprintFunctionLibrary  {

        ///<summary>Clears all material parameters set by this Material Instance</summary>
        public static void ClearAllMaterialInstanceParameters(MaterialInstanceConstant Instance)  => 
            MaterialEditingLibrary_methods.ClearAllMaterialInstanceParameters_method.Invoke(Instance);

        ///<summary>
        ///Create connection between two material expressions
        ///@
        ///</summary>
        ///<remarks>
        ///param  FromExpression          Expression to make connection from
        ///@param  FromOutputName          Name of output of FromExpression to make connection from. Leave empty to use first output.
        ///@param  ToExpression            Expression to make connection to
        ///@param  ToInputName                     Name of input of ToExpression to make connection to. Leave empty to use first input.
        ///</remarks>
        public static bool ConnectMaterialExpressions(MaterialExpression FromExpression, string FromOutputName, MaterialExpression ToExpression, string ToInputName)  => 
            MaterialEditingLibrary_methods.ConnectMaterialExpressions_method.Invoke(FromExpression, FromOutputName, ToExpression, ToInputName);

        ///<summary>Connect a material expression output to one of the material property inputs (e.</summary>
        ///<remarks>
        ///g. diffuse color, opacity etc)
        ///@param  FromExpression          Expression to make connection from
        ///@param  FromOutputName          Name of output of FromExpression to make connection from
        ///@param  Property                        Property input on material to make connection to
        ///</remarks>
        public static bool ConnectMaterialProperty(MaterialExpression FromExpression, string FromOutputName, byte Property)  => 
            MaterialEditingLibrary_methods.ConnectMaterialProperty_method.Invoke(FromExpression, FromOutputName, Property);

        ///<summary>
        ///Create a new material expression node within the supplied material
        ///@
        ///</summary>
        ///<remarks>
        ///param  Material                        Material asset to add an expression to
        ///@param  ExpressionClass         Class of expression to add
        ///@param  NodePosX                        X position of new expression node
        ///@param  NodePosY                        Y position of new expression node
        ///</remarks>
        public static MaterialExpression CreateMaterialExpression(Material Material, SubclassOf<MaterialExpression> ExpressionClass, int NodePosX, int NodePosY)  => 
            MaterialEditingLibrary_methods.CreateMaterialExpression_method.Invoke(Material, ExpressionClass, NodePosX, NodePosY);

        ///<summary>
        ///Create a new material expression node within the supplied material function
        ///@
        ///</summary>
        ///<remarks>
        ///param  MaterialFunction        Material function asset to add an expression to
        ///@param  ExpressionClass         Class of expression to add
        ///@param  NodePosX                        X position of new expression node
        ///@param  NodePosY                        Y position of new expression node
        ///</remarks>
        public static MaterialExpression CreateMaterialExpressionInFunction(MaterialFunction MaterialFunction, SubclassOf<MaterialExpression> ExpressionClass, int NodePosX, int NodePosY)  => 
            MaterialEditingLibrary_methods.CreateMaterialExpressionInFunction_method.Invoke(MaterialFunction, ExpressionClass, NodePosX, NodePosY);

        ///<summary>Delete all material expressions in the supplied material</summary>
        public static void DeleteAllMaterialExpressions(Material Material)  => 
            MaterialEditingLibrary_methods.DeleteAllMaterialExpressions_method.Invoke(Material);

        ///<summary>Delete all material expressions in the supplied material function</summary>
        public static void DeleteAllMaterialExpressionsInFunction(MaterialFunction MaterialFunction)  => 
            MaterialEditingLibrary_methods.DeleteAllMaterialExpressionsInFunction_method.Invoke(MaterialFunction);

        ///<summary>Delete a specific expression from a material. Will disconnect from other expressions.</summary>
        public static void DeleteMaterialExpression(Material Material, MaterialExpression Expression)  => 
            MaterialEditingLibrary_methods.DeleteMaterialExpression_method.Invoke(Material, Expression);

        ///<summary>Delete a specific expression from a material function. Will disconnect from other expressions.</summary>
        public static void DeleteMaterialExpressionInFunction(MaterialFunction MaterialFunction, MaterialExpression Expression)  => 
            MaterialEditingLibrary_methods.DeleteMaterialExpressionInFunction_method.Invoke(MaterialFunction, Expression);

        ///<summary>Get the current scalar (float) parameter value from a Material Instance</summary>
        public static float GetMaterialInstanceScalarParameterValue(MaterialInstanceConstant Instance, Name ParameterName)  => 
            MaterialEditingLibrary_methods.GetMaterialInstanceScalarParameterValue_method.Invoke(Instance, ParameterName);

        ///<summary>Get the current texture parameter value from a Material Instance</summary>
        public static Texture GetMaterialInstanceTextureParameterValue(MaterialInstanceConstant Instance, Name ParameterName)  => 
            MaterialEditingLibrary_methods.GetMaterialInstanceTextureParameterValue_method.Invoke(Instance, ParameterName);

        ///<summary>Get the current vector parameter value from a Material Instance</summary>
        public static LinearColor GetMaterialInstanceVectorParameterValue(MaterialInstanceConstant Instance, Name ParameterName)  => 
            MaterialEditingLibrary_methods.GetMaterialInstanceVectorParameterValue_method.Invoke(Instance, ParameterName);

        ///<summary>Returns number of material expressions in the supplied material</summary>
        public static int GetNumMaterialExpressions(Material Material)  => 
            MaterialEditingLibrary_methods.GetNumMaterialExpressions_method.Invoke(Material);

        ///<summary>Returns number of material expressions in the supplied material</summary>
        public static int GetNumMaterialExpressionsInFunction(MaterialFunction MaterialFunction)  => 
            MaterialEditingLibrary_methods.GetNumMaterialExpressionsInFunction_method.Invoke(MaterialFunction);

        ///<summary>Trigger a recompile of a material. Must be performed after making changes to the graph to have changes reflected.</summary>
        public static void RecompileMaterial(Material Material)  => 
            MaterialEditingLibrary_methods.RecompileMaterial_method.Invoke(Material);

        ///<summary>Set the parent Material or Material Instance to use for this Material Instance</summary>
        public static void SetMaterialInstanceParent(MaterialInstanceConstant Instance, MaterialInterface NewParent)  => 
            MaterialEditingLibrary_methods.SetMaterialInstanceParent_method.Invoke(Instance, NewParent);

        ///<summary>Set the scalar (float) parameter value for a Material Instance</summary>
        public static bool SetMaterialInstanceScalarParameterValue(MaterialInstanceConstant Instance, Name ParameterName, float Value)  => 
            MaterialEditingLibrary_methods.SetMaterialInstanceScalarParameterValue_method.Invoke(Instance, ParameterName, Value);

        ///<summary>Set the texture parameter value for a Material Instance</summary>
        public static bool SetMaterialInstanceTextureParameterValue(MaterialInstanceConstant Instance, Name ParameterName, Texture Value)  => 
            MaterialEditingLibrary_methods.SetMaterialInstanceTextureParameterValue_method.Invoke(Instance, ParameterName, Value);

        ///<summary>Set the vector parameter value for a Material Instance</summary>
        public static bool SetMaterialInstanceVectorParameterValue(MaterialInstanceConstant Instance, Name ParameterName, LinearColor Value)  => 
            MaterialEditingLibrary_methods.SetMaterialInstanceVectorParameterValue_method.Invoke(Instance, ParameterName, Value);

        ///<summary>Enable a particular usage for the supplied material (e.</summary>
        ///<remarks>
        ///g. SkeletalMesh, ParticleSprite etc)
        ///@param  Material                        Material to change usage for
        ///@param  Usage                           New usage type to enable for this material
        ///@param  bNeedsRecompile         Returned to indicate if material needs recompiling after this change
        ///</remarks>
        public static (bool, bool) SetMaterialUsage(Material Material, byte Usage)  => 
            MaterialEditingLibrary_methods.SetMaterialUsage_method.Invoke(Material, Usage);

        ///<summary>Update a Material Function after edits have been made.</summary>
        ///<remarks>Will recompile any Materials that use the supplied Material Function.</remarks>
        public static void UpdateMaterialFunction(MaterialFunctionInterface MaterialFunction, Material PreviewMaterial)  => 
            MaterialEditingLibrary_methods.UpdateMaterialFunction_method.Invoke(MaterialFunction, PreviewMaterial);

        ///<summary>Called after making modifications to a Material Instance to recompile shaders etc.</summary>
        public static void UpdateMaterialInstance(MaterialInstanceConstant Instance)  => 
            MaterialEditingLibrary_methods.UpdateMaterialInstance_method.Invoke(Instance);
        static MaterialEditingLibrary() {
            StaticClass = Main.GetClass("MaterialEditingLibrary");
        }
        internal unsafe MaterialEditingLibrary_fields* MaterialEditingLibrary_ptr => (MaterialEditingLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialEditingLibrary(IntPtr p) => UObject.Make<MaterialEditingLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialEditingLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialEditingLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
