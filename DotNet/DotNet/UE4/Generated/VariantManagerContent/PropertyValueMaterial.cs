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
using UE4.VariantManagerContent.Native;

namespace UE4.VariantManagerContent {
    ///<summary>Property Value Material</summary>
    public unsafe partial class PropertyValueMaterial : PropertyValue  {
        static PropertyValueMaterial() {
            StaticClass = Main.GetClass("PropertyValueMaterial");
        }
        internal unsafe PropertyValueMaterial_fields* PropertyValueMaterial_ptr => (PropertyValueMaterial_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PropertyValueMaterial(IntPtr p) => UObject.Make<PropertyValueMaterial>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PropertyValueMaterial DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PropertyValueMaterial New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
