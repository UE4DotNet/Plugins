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
    ///<summary>Int Serialization</summary>
    public unsafe partial class IntSerialization : UObject  {
         //TODO: numeric uint16 UnsignedInt16Variable
         //TODO: numeric uint32 UnsignedInt32Variable
         //TODO: numeric uint64 UnsignedInt64Variable
        ///<summary>Signed Int 8Variable</summary>
        public unsafe sbyte SignedInt8Variable {
            get {return IntSerialization_ptr->SignedInt8Variable;}
            set {IntSerialization_ptr->SignedInt8Variable = value;}
        }
        ///<summary>Signed Int 16Variable</summary>
        public unsafe short SignedInt16Variable {
            get {return IntSerialization_ptr->SignedInt16Variable;}
            set {IntSerialization_ptr->SignedInt16Variable = value;}
        }
        ///<summary>Signed Int 64Variable</summary>
        public unsafe long SignedInt64Variable {
            get {return IntSerialization_ptr->SignedInt64Variable;}
            set {IntSerialization_ptr->SignedInt64Variable = value;}
        }
        ///<summary>Existing types</summary>
        public unsafe byte UnsignedInt8Variable {
            get {return IntSerialization_ptr->UnsignedInt8Variable;}
            set {IntSerialization_ptr->UnsignedInt8Variable = value;}
        }
        ///<summary>Signed Int 32Variable</summary>
        public unsafe int SignedInt32Variable {
            get {return IntSerialization_ptr->SignedInt32Variable;}
            set {IntSerialization_ptr->SignedInt32Variable = value;}
        }
        static IntSerialization() {
            StaticClass = Main.GetClass("IntSerialization");
        }
        internal unsafe IntSerialization_fields* IntSerialization_ptr => (IntSerialization_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator IntSerialization(IntPtr p) => UObject.Make<IntSerialization>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static IntSerialization DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static IntSerialization New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
