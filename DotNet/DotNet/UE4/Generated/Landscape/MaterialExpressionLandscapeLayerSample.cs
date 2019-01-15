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
    ///<summary>Material Expression Landscape Layer Sample</summary>
    public unsafe partial class MaterialExpressionLandscapeLayerSample : MaterialExpression  {
        ///<summary>Parameter Name</summary>
        public unsafe Name ParameterName {
            get {return MaterialExpressionLandscapeLayerSample_ptr->ParameterName;}
            set {MaterialExpressionLandscapeLayerSample_ptr->ParameterName = value;}
        }
        ///<summary>Preview Weight</summary>
        public unsafe float PreviewWeight {
            get {return MaterialExpressionLandscapeLayerSample_ptr->PreviewWeight;}
            set {MaterialExpressionLandscapeLayerSample_ptr->PreviewWeight = value;}
        }
        ///<summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
        public unsafe FGuid ExpressionGUID {
            get {return MaterialExpressionLandscapeLayerSample_ptr->ExpressionGUID;}
            set {MaterialExpressionLandscapeLayerSample_ptr->ExpressionGUID = value;}
        }
        static MaterialExpressionLandscapeLayerSample() {
            StaticClass = Main.GetClass("MaterialExpressionLandscapeLayerSample");
        }
        internal unsafe MaterialExpressionLandscapeLayerSample_fields* MaterialExpressionLandscapeLayerSample_ptr => (MaterialExpressionLandscapeLayerSample_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionLandscapeLayerSample(IntPtr p) => UObject.Make<MaterialExpressionLandscapeLayerSample>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionLandscapeLayerSample DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionLandscapeLayerSample New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
