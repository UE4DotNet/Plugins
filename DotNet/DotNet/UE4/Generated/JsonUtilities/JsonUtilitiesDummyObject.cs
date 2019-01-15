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
using UE4.JsonUtilities.Native;

namespace UE4.JsonUtilities {
    ///<summary>Json Utilities Dummy Object</summary>
    public unsafe partial class JsonUtilitiesDummyObject : UObject  {
        static JsonUtilitiesDummyObject() {
            StaticClass = Main.GetClass("JsonUtilitiesDummyObject");
        }
        internal unsafe JsonUtilitiesDummyObject_fields* JsonUtilitiesDummyObject_ptr => (JsonUtilitiesDummyObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator JsonUtilitiesDummyObject(IntPtr p) => UObject.Make<JsonUtilitiesDummyObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static JsonUtilitiesDummyObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static JsonUtilitiesDummyObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
