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
using UE4.InputCore.Native;

namespace UE4.InputCore {
    ///<summary>Input Core Types</summary>
    public unsafe partial class InputCoreTypes : UObject  {
        static InputCoreTypes() {
            StaticClass = Main.GetClass("InputCoreTypes");
        }
        internal unsafe InputCoreTypes_fields* InputCoreTypes_ptr => (InputCoreTypes_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InputCoreTypes(IntPtr p) => UObject.Make<InputCoreTypes>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InputCoreTypes DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InputCoreTypes New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
