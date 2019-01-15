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
    ///<summary>Material Expression Landscape Visibility Mask</summary>
    public unsafe partial class MaterialExpressionLandscapeVisibilityMask : MaterialExpression  {
        ///<summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
        public unsafe FGuid ExpressionGUID {
            get {return MaterialExpressionLandscapeVisibilityMask_ptr->ExpressionGUID;}
            set {MaterialExpressionLandscapeVisibilityMask_ptr->ExpressionGUID = value;}
        }
        static MaterialExpressionLandscapeVisibilityMask() {
            StaticClass = Main.GetClass("MaterialExpressionLandscapeVisibilityMask");
        }
        internal unsafe MaterialExpressionLandscapeVisibilityMask_fields* MaterialExpressionLandscapeVisibilityMask_ptr => (MaterialExpressionLandscapeVisibilityMask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionLandscapeVisibilityMask(IntPtr p) => UObject.Make<MaterialExpressionLandscapeVisibilityMask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionLandscapeVisibilityMask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionLandscapeVisibilityMask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
