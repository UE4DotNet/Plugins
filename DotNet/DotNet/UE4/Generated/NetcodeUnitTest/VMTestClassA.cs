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
using UE4.NetcodeUnitTest.Native;
using UE4.Engine;

namespace UE4.NetcodeUnitTest {
    ///<summary>Test classes for testing different types/combinations of property reflection</summary>
    public unsafe partial class VMTestClassA : UObject  {
        ///<summary>AObject Ref</summary>
        public unsafe UObject AObjectRef {
            get {return VMTestClassA_ptr->AObjectRef;}
            set {VMTestClassA_ptr->AObjectRef = value;}
        }
        ///<summary>Byte Prop</summary>
        public unsafe byte ByteProp {
            get {return VMTestClassA_ptr->ByteProp;}
            set {VMTestClassA_ptr->ByteProp = value;}
        }
         //TODO: numeric uint16 UInt16Prop
         //TODO: numeric uint32 UInt32Prop
         //TODO: numeric uint64 UInt64Prop
        ///<summary>Int 8Prop</summary>
        public unsafe sbyte Int8Prop {
            get {return VMTestClassA_ptr->Int8Prop;}
            set {VMTestClassA_ptr->Int8Prop = value;}
        }
        ///<summary>Int 16Prop</summary>
        public unsafe short Int16Prop {
            get {return VMTestClassA_ptr->Int16Prop;}
            set {VMTestClassA_ptr->Int16Prop = value;}
        }
        ///<summary>Int 32Prop</summary>
        public unsafe int Int32Prop {
            get {return VMTestClassA_ptr->Int32Prop;}
            set {VMTestClassA_ptr->Int32Prop = value;}
        }
        ///<summary>Int 64Prop</summary>
        public unsafe long Int64Prop {
            get {return VMTestClassA_ptr->Int64Prop;}
            set {VMTestClassA_ptr->Int64Prop = value;}
        }
        ///<summary>Float Prop</summary>
        public unsafe float FloatProp {
            get {return VMTestClassA_ptr->FloatProp;}
            set {VMTestClassA_ptr->FloatProp = value;}
        }
        ///<summary>Double Prop</summary>
        public unsafe double DoubleProp {
            get {return VMTestClassA_ptr->DoubleProp;}
            set {VMTestClassA_ptr->DoubleProp = value;}
        }
        public bool bBoolPropA {
            get {return Main.GetGetBoolPropertyByName(this, "bBoolPropA"); }
            set {Main.SetGetBoolPropertyByName(this, "bBoolPropA", value); }
        }
        public bool bBoolPropB {
            get {return Main.GetGetBoolPropertyByName(this, "bBoolPropB"); }
            set {Main.SetGetBoolPropertyByName(this, "bBoolPropB", value); }
        }
        public bool bBoolPropC {
            get {return Main.GetGetBoolPropertyByName(this, "bBoolPropC"); }
            set {Main.SetGetBoolPropertyByName(this, "bBoolPropC", value); }
        }
        public bool bBoolPropD {
            get {return Main.GetGetBoolPropertyByName(this, "bBoolPropD"); }
            set {Main.SetGetBoolPropertyByName(this, "bBoolPropD", value); }
        }
        public bool bBoolPropE {
            get {return Main.GetGetBoolPropertyByName(this, "bBoolPropE"); }
            set {Main.SetGetBoolPropertyByName(this, "bBoolPropE", value); }
        }
        ///<summary>Name Prop</summary>
        public unsafe Name NameProp {
            get {return VMTestClassA_ptr->NameProp;}
            set {VMTestClassA_ptr->NameProp = value;}
        }
         //TODO: string FString StringProp
         //TODO: text FText TextProp
        ///<summary>Byte Prop Array</summary>
        public unsafe byte BytePropArray {
            get {return VMTestClassA_ptr->BytePropArray;}
            set {VMTestClassA_ptr->BytePropArray = value;}
        }
        ///<summary>Object Prop Array</summary>
        public unsafe UObject ObjectPropArray {
            get {return VMTestClassA_ptr->ObjectPropArray;}
            set {VMTestClassA_ptr->ObjectPropArray = value;}
        }
         //TODO: array not UObject TArray DynBytePropArray
         //TODO: array not UObject TArray DynBoolPropArray
        ///<summary>Dyn Object Prop Array</summary>
        public ObjectArrayField<UObject> DynObjectPropArray{ get {
            if(DynObjectPropArray_store == null) DynObjectPropArray_store = new ObjectArrayField<UObject> (&VMTestClassA_ptr->DynObjectPropArray);
            return DynObjectPropArray_store;
        } }
        private ObjectArrayField<UObject> DynObjectPropArray_store;

         //TODO: array not UObject TArray DynNamePropArray
         //TODO: array not UObject TArray DynDoublePropArray
         //TODO: array not UObject TArray DynFloatPropArray
         //TODO: array not UObject TArray DynInt16PropArray
         //TODO: array not UObject TArray DynInt64PropArray
         //TODO: array not UObject TArray DynInt8PropArray
         //TODO: array not UObject TArray DynIntPropArray
         //TODO: array not UObject TArray DynUInt16PropArray
         //TODO: array not UObject TArray DynUIntPropArray
         //TODO: array not UObject TArray DynUInt64PropArray
         //TODO: array not UObject TArray DynStringPropArray
         //TODO: array not UObject TArray DynTextPropArray
        ///<summary>Dyn Class Prop Array</summary>
        public ObjectArrayField<Class> DynClassPropArray{ get {
            if(DynClassPropArray_store == null) DynClassPropArray_store = new ObjectArrayField<Class> (&VMTestClassA_ptr->DynClassPropArray);
            return DynClassPropArray_store;
        } }
        private ObjectArrayField<Class> DynClassPropArray_store;

        ///<summary>Dyn Pawn Prop Array</summary>
        public ObjectArrayField<Pawn> DynPawnPropArray{ get {
            if(DynPawnPropArray_store == null) DynPawnPropArray_store = new ObjectArrayField<Pawn> (&VMTestClassA_ptr->DynPawnPropArray);
            return DynPawnPropArray_store;
        } }
        private ObjectArrayField<Pawn> DynPawnPropArray_store;

        ///<summary>Struct Prop</summary>
        public unsafe Vector StructProp {
            get {return VMTestClassA_ptr->StructProp;}
            set {VMTestClassA_ptr->StructProp = value;}
        }
        ///<summary>Struct Prop Array</summary>
        public unsafe Vector StructPropArray {
            get {return VMTestClassA_ptr->StructPropArray;}
            set {VMTestClassA_ptr->StructPropArray = value;}
        }
         //TODO: array not UObject TArray DynStructPropArray
        static VMTestClassA() {
            StaticClass = Main.GetClass("VMTestClassA");
        }
        internal unsafe VMTestClassA_fields* VMTestClassA_ptr => (VMTestClassA_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VMTestClassA(IntPtr p) => UObject.Make<VMTestClassA>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VMTestClassA DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VMTestClassA New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
