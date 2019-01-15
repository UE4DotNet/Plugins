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
    ///<summary>A 2d material that will be rendered always facing the camera.</summary>
    public unsafe partial class MaterialBillboardComponent : PrimitiveComponent  {

        ///<summary>Adds an element to the sprite.</summary>
        public void AddElement(MaterialInterface Material, CurveFloat DistanceToOpacityCurve, bool bSizeIsInScreenSpace, float BaseSizeX, float BaseSizeY, CurveFloat DistanceToSizeCurve)  => 
            MaterialBillboardComponent_methods.AddElement_method.Invoke(ObjPointer, Material, DistanceToOpacityCurve, bSizeIsInScreenSpace, BaseSizeX, BaseSizeY, DistanceToSizeCurve);

        ///<summary>Set all elements of this material billboard component</summary>
        public void SetElements(byte NewElements /*TODO: array TArray */)  => 
            MaterialBillboardComponent_methods.SetElements_method.Invoke(ObjPointer, NewElements);
         //TODO: array not UObject TArray Elements
        static MaterialBillboardComponent() {
            StaticClass = Main.GetClass("MaterialBillboardComponent");
        }
        internal unsafe MaterialBillboardComponent_fields* MaterialBillboardComponent_ptr => (MaterialBillboardComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialBillboardComponent(IntPtr p) => UObject.Make<MaterialBillboardComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialBillboardComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialBillboardComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
