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
    ///<summary>Property Value Visibility</summary>
    public unsafe partial class PropertyValueVisibility : PropertyValue  {
        static PropertyValueVisibility() {
            StaticClass = Main.GetClass("PropertyValueVisibility");
        }
        internal unsafe PropertyValueVisibility_fields* PropertyValueVisibility_ptr => (PropertyValueVisibility_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PropertyValueVisibility(IntPtr p) => UObject.Make<PropertyValueVisibility>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PropertyValueVisibility DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PropertyValueVisibility New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
