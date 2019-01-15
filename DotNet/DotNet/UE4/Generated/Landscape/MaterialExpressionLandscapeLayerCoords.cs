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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Material Expression Landscape Layer Coords</summary>
    public unsafe partial class MaterialExpressionLandscapeLayerCoords : MaterialExpression  {
        ///<summary>Determines the mapping place to use on the terrain.</summary>
        public unsafe byte MappingType {
            get {return MaterialExpressionLandscapeLayerCoords_ptr->MappingType;}
            set {MaterialExpressionLandscapeLayerCoords_ptr->MappingType = value;}
        }
        ///<summary>Determines the mapping place to use on the terrain.</summary>
        public unsafe byte CustomUVType {
            get {return MaterialExpressionLandscapeLayerCoords_ptr->CustomUVType;}
            set {MaterialExpressionLandscapeLayerCoords_ptr->CustomUVType = value;}
        }
        ///<summary>Uniform scale to apply to the mapping.</summary>
        public unsafe float MappingScale {
            get {return MaterialExpressionLandscapeLayerCoords_ptr->MappingScale;}
            set {MaterialExpressionLandscapeLayerCoords_ptr->MappingScale = value;}
        }
        ///<summary>Rotation to apply to the mapping.</summary>
        public unsafe float MappingRotation {
            get {return MaterialExpressionLandscapeLayerCoords_ptr->MappingRotation;}
            set {MaterialExpressionLandscapeLayerCoords_ptr->MappingRotation = value;}
        }
        ///<summary>Offset to apply to the mapping along U.</summary>
        public unsafe float MappingPanU {
            get {return MaterialExpressionLandscapeLayerCoords_ptr->MappingPanU;}
            set {MaterialExpressionLandscapeLayerCoords_ptr->MappingPanU = value;}
        }
        ///<summary>Offset to apply to the mapping along V.</summary>
        public unsafe float MappingPanV {
            get {return MaterialExpressionLandscapeLayerCoords_ptr->MappingPanV;}
            set {MaterialExpressionLandscapeLayerCoords_ptr->MappingPanV = value;}
        }
        static MaterialExpressionLandscapeLayerCoords() {
            StaticClass = Main.GetClass("MaterialExpressionLandscapeLayerCoords");
        }
        internal unsafe MaterialExpressionLandscapeLayerCoords_fields* MaterialExpressionLandscapeLayerCoords_ptr => (MaterialExpressionLandscapeLayerCoords_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionLandscapeLayerCoords(IntPtr p) => UObject.Make<MaterialExpressionLandscapeLayerCoords>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionLandscapeLayerCoords DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionLandscapeLayerCoords New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
