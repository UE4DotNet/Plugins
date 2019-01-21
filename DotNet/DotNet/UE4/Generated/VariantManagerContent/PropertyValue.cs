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
    ///<summary>Property Value</summary>
    public unsafe partial class PropertyValue : UObject  {
         //TODO: string FString FullDisplayString
        public bool bHasRecordedData {
            get {return Main.GetGetBoolPropertyByName(this, "bHasRecordedData"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasRecordedData", value); }
        }
        public bool bIsObjectProperty {
            get {return Main.GetGetBoolPropertyByName(this, "bIsObjectProperty"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsObjectProperty", value); }
        }
         //TODO: array not UObject TArray ValueBytes
         //TODO: enum EPropertyValueCategory PropCategory
        ///<summary>Properties</summary>
        public ObjectArrayField<Property> Properties{ get {
            if(Properties_store == null) Properties_store = new ObjectArrayField<Property> (&PropertyValue_ptr->Properties);
            return Properties_store;
        } }
        private ObjectArrayField<Property> Properties_store;

         //TODO: array not UObject TArray PropertyIndices
        static PropertyValue() {
            StaticClass = Main.GetClass("PropertyValue");
        }
        internal unsafe PropertyValue_fields* PropertyValue_ptr => (PropertyValue_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PropertyValue(IntPtr p) => UObject.Make<PropertyValue>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PropertyValue DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PropertyValue New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
