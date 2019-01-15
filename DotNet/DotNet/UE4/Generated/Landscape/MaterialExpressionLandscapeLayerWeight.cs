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
    ///<summary>Material Expression Landscape Layer Weight</summary>
    public unsafe partial class MaterialExpressionLandscapeLayerWeight : MaterialExpression  {
        ///<summary>Defaults to 'ConstBase' if not specified</summary>
        public unsafe ExpressionInput Base {
            get {return MaterialExpressionLandscapeLayerWeight_ptr->Base;}
            set {MaterialExpressionLandscapeLayerWeight_ptr->Base = value;}
        }
        ///<summary>Ignored if not specified</summary>
        public unsafe ExpressionInput Layer {
            get {return MaterialExpressionLandscapeLayerWeight_ptr->Layer;}
            set {MaterialExpressionLandscapeLayerWeight_ptr->Layer = value;}
        }
        ///<summary>Parameter Name</summary>
        public unsafe Name ParameterName {
            get {return MaterialExpressionLandscapeLayerWeight_ptr->ParameterName;}
            set {MaterialExpressionLandscapeLayerWeight_ptr->ParameterName = value;}
        }
        ///<summary>Preview Weight</summary>
        public unsafe float PreviewWeight {
            get {return MaterialExpressionLandscapeLayerWeight_ptr->PreviewWeight;}
            set {MaterialExpressionLandscapeLayerWeight_ptr->PreviewWeight = value;}
        }
        ///<summary>only used if Base is not hooked up</summary>
        public unsafe Vector ConstBase {
            get {return MaterialExpressionLandscapeLayerWeight_ptr->ConstBase;}
            set {MaterialExpressionLandscapeLayerWeight_ptr->ConstBase = value;}
        }
        ///<summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
        public unsafe FGuid ExpressionGUID {
            get {return MaterialExpressionLandscapeLayerWeight_ptr->ExpressionGUID;}
            set {MaterialExpressionLandscapeLayerWeight_ptr->ExpressionGUID = value;}
        }
        static MaterialExpressionLandscapeLayerWeight() {
            StaticClass = Main.GetClass("MaterialExpressionLandscapeLayerWeight");
        }
        internal unsafe MaterialExpressionLandscapeLayerWeight_fields* MaterialExpressionLandscapeLayerWeight_ptr => (MaterialExpressionLandscapeLayerWeight_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionLandscapeLayerWeight(IntPtr p) => UObject.Make<MaterialExpressionLandscapeLayerWeight>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionLandscapeLayerWeight DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionLandscapeLayerWeight New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
