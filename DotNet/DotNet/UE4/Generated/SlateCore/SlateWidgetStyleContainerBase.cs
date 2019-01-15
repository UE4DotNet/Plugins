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
    public unsafe partial class SlateWidgetStyleContainerBase : UObject  {
        static SlateWidgetStyleContainerBase() {
            StaticClass = Main.GetClass("SlateWidgetStyleContainerBase");
        }
        internal unsafe SlateWidgetStyleContainerBase_fields* SlateWidgetStyleContainerBase_ptr => (SlateWidgetStyleContainerBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SlateWidgetStyleContainerBase(IntPtr p) => UObject.Make<SlateWidgetStyleContainerBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SlateWidgetStyleContainerBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SlateWidgetStyleContainerBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
