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
    ///<summary>Variant Object Binding</summary>
    public unsafe partial class VariantObjectBinding : UObject  {
        ///<summary>Object Ptr</summary>
        public unsafe SoftObjectPath ObjectPtr {
            get {return VariantObjectBinding_ptr->ObjectPtr;}
            set {VariantObjectBinding_ptr->ObjectPtr = value;}
        }
         //TODO: lazy object TLazyObjectPtr<UObject> LazyObjectPtr
        ///<summary>Captured Properties</summary>
        public ObjectArrayField<PropertyValue> CapturedProperties{ get {
            if(CapturedProperties_store == null) CapturedProperties_store = new ObjectArrayField<PropertyValue> (&VariantObjectBinding_ptr->CapturedProperties);
            return CapturedProperties_store;
        } }
        private ObjectArrayField<PropertyValue> CapturedProperties_store;

        static VariantObjectBinding() {
            StaticClass = Main.GetClass("VariantObjectBinding");
        }
        internal unsafe VariantObjectBinding_fields* VariantObjectBinding_ptr => (VariantObjectBinding_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VariantObjectBinding(IntPtr p) => UObject.Make<VariantObjectBinding>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VariantObjectBinding DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VariantObjectBinding New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
