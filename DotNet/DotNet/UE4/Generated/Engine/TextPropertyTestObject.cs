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
    ///<summary>Text Property Test Object</summary>
    public unsafe partial class TextPropertyTestObject : UObject  {
         //TODO: text FText DefaultedText
         //TODO: text FText UndefaultedText
         //TODO: text FText TransientText
        static TextPropertyTestObject() {
            StaticClass = Main.GetClass("TextPropertyTestObject");
        }
        internal unsafe TextPropertyTestObject_fields* TextPropertyTestObject_ptr => (TextPropertyTestObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextPropertyTestObject(IntPtr p) => UObject.Make<TextPropertyTestObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextPropertyTestObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextPropertyTestObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
