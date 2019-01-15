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
using UE4.UObjectPlugin.Native;

namespace UE4.UObjectPlugin {
    ///<summary>Example of declaring a UObject in a plugin module</summary>
    public unsafe partial class MyPluginObject : UObject  {
        ///<summary>My Struct</summary>
        public unsafe MyPluginStruct MyStruct {
            get {return MyPluginObject_ptr->MyStruct;}
            set {MyPluginObject_ptr->MyStruct = value;}
        }
        static MyPluginObject() {
            StaticClass = Main.GetClass("MyPluginObject");
        }
        internal unsafe MyPluginObject_fields* MyPluginObject_ptr => (MyPluginObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MyPluginObject(IntPtr p) => UObject.Make<MyPluginObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MyPluginObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MyPluginObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
