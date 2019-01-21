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
using UE4.Engine;

namespace UE4.VariantManagerContent {
    ///<summary>Variant</summary>
    public unsafe partial class Variant : UObject  {

        ///<summary>Get Actor</summary>
        public Actor GetActor(int ActorIndex)  => 
            Variant_methods.GetActor_method.Invoke(ObjPointer, ActorIndex);

        ///<summary>Get Display Text</summary>
        public byte /*TODO: text FText*/ GetDisplayText()  => 
            Variant_methods.GetDisplayText_method.Invoke(ObjPointer);

        ///<summary>Get Num Actors</summary>
        public int GetNumActors()  => 
            Variant_methods.GetNumActors_method.Invoke(ObjPointer);

        ///<summary>Set Display Text</summary>
        public void SetDisplayText(byte NewDisplayText /*TODO: text FText */)  => 
            Variant_methods.SetDisplayText_method.Invoke(ObjPointer, NewDisplayText);

        ///<summary>Switch On</summary>
        public void SwitchOn()  => 
            Variant_methods.SwitchOn_method.Invoke(ObjPointer);
         //TODO: text FText DisplayText
        ///<summary>Object Bindings</summary>
        public ObjectArrayField<VariantObjectBinding> ObjectBindings{ get {
            if(ObjectBindings_store == null) ObjectBindings_store = new ObjectArrayField<VariantObjectBinding> (&Variant_ptr->ObjectBindings);
            return ObjectBindings_store;
        } }
        private ObjectArrayField<VariantObjectBinding> ObjectBindings_store;

        static Variant() {
            StaticClass = Main.GetClass("Variant");
        }
        internal unsafe Variant_fields* Variant_ptr => (Variant_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Variant(IntPtr p) => UObject.Make<Variant>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Variant DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Variant New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
