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
    ///<summary>An asset describing a CheckBox's appearance.</summary>
    ///<remarks>Just a wrapper for the struct with real data in it.</remarks>
    public unsafe partial class CheckBoxStyleAsset : UObject  {
        ///<summary>The actual data describing the Check Box's appearance.</summary>
        public unsafe CheckBoxStyle CheckBoxStyle {
            get {return CheckBoxStyleAsset_ptr->CheckBoxStyle;}
            set {CheckBoxStyleAsset_ptr->CheckBoxStyle = value;}
        }
        static CheckBoxStyleAsset() {
            StaticClass = Main.GetClass("CheckBoxStyleAsset");
        }
        internal unsafe CheckBoxStyleAsset_fields* CheckBoxStyleAsset_ptr => (CheckBoxStyleAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CheckBoxStyleAsset(IntPtr p) => UObject.Make<CheckBoxStyleAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CheckBoxStyleAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CheckBoxStyleAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
