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
    ///<summary>Variant Set</summary>
    public unsafe partial class VariantSet : UObject  {

        ///<summary>Get Display Text</summary>
        public byte /*TODO: text FText*/ GetDisplayText()  => 
            VariantSet_methods.GetDisplayText_method.Invoke(ObjPointer);

        ///<summary>Get Num Variants</summary>
        public int GetNumVariants()  => 
            VariantSet_methods.GetNumVariants_method.Invoke(ObjPointer);

        ///<summary>Get Variant</summary>
        public Variant GetVariant(int VariantIndex)  => 
            VariantSet_methods.GetVariant_method.Invoke(ObjPointer, VariantIndex);

        ///<summary>Set Display Text</summary>
        public void SetDisplayText(byte NewDisplayText /*TODO: text FText */)  => 
            VariantSet_methods.SetDisplayText_method.Invoke(ObjPointer, NewDisplayText);
         //TODO: text FText DisplayText
        ///<summary>Variants</summary>
        public ObjectArrayField<Variant> Variants{ get {
            if(Variants_store == null) Variants_store = new ObjectArrayField<Variant> (&VariantSet_ptr->Variants);
            return Variants_store;
        } }
        private ObjectArrayField<Variant> Variants_store;

        static VariantSet() {
            StaticClass = Main.GetClass("VariantSet");
        }
        internal unsafe VariantSet_fields* VariantSet_ptr => (VariantSet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VariantSet(IntPtr p) => UObject.Make<VariantSet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VariantSet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VariantSet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
