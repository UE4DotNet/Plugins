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
    ///<summary>Input Touch Delegate Binding</summary>
    public unsafe partial class InputTouchDelegateBinding : InputDelegateBinding  {
         //TODO: array not UObject TArray InputTouchDelegateBindings
        static InputTouchDelegateBinding() {
            StaticClass = Main.GetClass("InputTouchDelegateBinding");
        }
        internal unsafe InputTouchDelegateBinding_fields* InputTouchDelegateBinding_ptr => (InputTouchDelegateBinding_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InputTouchDelegateBinding(IntPtr p) => UObject.Make<InputTouchDelegateBinding>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InputTouchDelegateBinding DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InputTouchDelegateBinding New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
