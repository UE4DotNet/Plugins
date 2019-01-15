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
    ///<summary>Material Expression Material Attribute Layers</summary>
    public unsafe partial class MaterialExpressionMaterialAttributeLayers : MaterialExpression  {
        ///<summary>name to be referenced when we want to find and set this parameter</summary>
        public unsafe Name ParameterName {
            get {return MaterialExpressionMaterialAttributeLayers_ptr->ParameterName;}
            set {MaterialExpressionMaterialAttributeLayers_ptr->ParameterName = value;}
        }
        ///<summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
        public unsafe FGuid ExpressionGUID {
            get {return MaterialExpressionMaterialAttributeLayers_ptr->ExpressionGUID;}
            set {MaterialExpressionMaterialAttributeLayers_ptr->ExpressionGUID = value;}
        }
        ///<summary>Input</summary>
        public unsafe MaterialAttributesInput Input {
            get {return MaterialExpressionMaterialAttributeLayers_ptr->Input;}
            set {MaterialExpressionMaterialAttributeLayers_ptr->Input = value;}
        }
        ///<summary>Default Layers</summary>
        public unsafe MaterialLayersFunctions DefaultLayers {
            get {return MaterialExpressionMaterialAttributeLayers_ptr->DefaultLayers;}
            set {MaterialExpressionMaterialAttributeLayers_ptr->DefaultLayers = value;}
        }
        ///<summary>Layer Callers</summary>
        public ObjectArrayField<MaterialExpressionMaterialFunctionCall> LayerCallers{ get {
            if(LayerCallers_store == null) LayerCallers_store = new ObjectArrayField<MaterialExpressionMaterialFunctionCall> (&MaterialExpressionMaterialAttributeLayers_ptr->LayerCallers);
            return LayerCallers_store;
        } }
        private ObjectArrayField<MaterialExpressionMaterialFunctionCall> LayerCallers_store;

        ///<summary>Num Active Layer Callers</summary>
        public unsafe int NumActiveLayerCallers {
            get {return MaterialExpressionMaterialAttributeLayers_ptr->NumActiveLayerCallers;}
            set {MaterialExpressionMaterialAttributeLayers_ptr->NumActiveLayerCallers = value;}
        }
        ///<summary>Blend Callers</summary>
        public ObjectArrayField<MaterialExpressionMaterialFunctionCall> BlendCallers{ get {
            if(BlendCallers_store == null) BlendCallers_store = new ObjectArrayField<MaterialExpressionMaterialFunctionCall> (&MaterialExpressionMaterialAttributeLayers_ptr->BlendCallers);
            return BlendCallers_store;
        } }
        private ObjectArrayField<MaterialExpressionMaterialFunctionCall> BlendCallers_store;

        ///<summary>Num Active Blend Callers</summary>
        public unsafe int NumActiveBlendCallers {
            get {return MaterialExpressionMaterialAttributeLayers_ptr->NumActiveBlendCallers;}
            set {MaterialExpressionMaterialAttributeLayers_ptr->NumActiveBlendCallers = value;}
        }
        public bool bIsLayerGraphBuilt {
            get {return Main.GetGetBoolPropertyByName(this, "bIsLayerGraphBuilt"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsLayerGraphBuilt", value); }
        }
        static MaterialExpressionMaterialAttributeLayers() {
            StaticClass = Main.GetClass("MaterialExpressionMaterialAttributeLayers");
        }
        internal unsafe MaterialExpressionMaterialAttributeLayers_fields* MaterialExpressionMaterialAttributeLayers_ptr => (MaterialExpressionMaterialAttributeLayers_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionMaterialAttributeLayers(IntPtr p) => UObject.Make<MaterialExpressionMaterialAttributeLayers>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionMaterialAttributeLayers DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionMaterialAttributeLayers New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
