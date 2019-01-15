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
using UE4.SlateCore.Native;

namespace UE4.SlateCore {
    ///<summary>Just a wrapper for the struct with real data in it.</summary>
    public unsafe partial class SlateWidgetStyleAsset : UObject  {
        ///<summary>Custom Style</summary>
        public unsafe SlateWidgetStyleContainerBase CustomStyle {
            get {return SlateWidgetStyleAsset_ptr->CustomStyle;}
            set {SlateWidgetStyleAsset_ptr->CustomStyle = value;}
        }
        static SlateWidgetStyleAsset() {
            StaticClass = Main.GetClass("SlateWidgetStyleAsset");
        }
        internal unsafe SlateWidgetStyleAsset_fields* SlateWidgetStyleAsset_ptr => (SlateWidgetStyleAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SlateWidgetStyleAsset(IntPtr p) => UObject.Make<SlateWidgetStyleAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SlateWidgetStyleAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SlateWidgetStyleAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
