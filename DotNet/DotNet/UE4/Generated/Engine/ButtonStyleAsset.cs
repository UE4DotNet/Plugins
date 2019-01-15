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
using UE4.SlateCore;

namespace UE4.Engine {
    ///<summary>An asset describing a button's appearance.</summary>
    ///<remarks>Just a wrapper for the struct with real data in it.style factory</remarks>
    public unsafe partial class ButtonStyleAsset : UObject  {
        ///<summary>The actual data describing the button's appearance.</summary>
        public unsafe ButtonStyle ButtonStyle {
            get {return ButtonStyleAsset_ptr->ButtonStyle;}
            set {ButtonStyleAsset_ptr->ButtonStyle = value;}
        }
        static ButtonStyleAsset() {
            StaticClass = Main.GetClass("ButtonStyleAsset");
        }
        internal unsafe ButtonStyleAsset_fields* ButtonStyleAsset_ptr => (ButtonStyleAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ButtonStyleAsset(IntPtr p) => UObject.Make<ButtonStyleAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ButtonStyleAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ButtonStyleAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
