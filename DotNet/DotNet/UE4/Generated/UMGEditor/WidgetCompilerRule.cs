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
using UE4.UMGEditor.Native;

namespace UE4.UMGEditor {
    ///<summary>Widget Compiler Rule</summary>
    public unsafe partial class WidgetCompilerRule : UObject  {
        static WidgetCompilerRule() {
            StaticClass = Main.GetClass("WidgetCompilerRule");
        }
        internal unsafe WidgetCompilerRule_fields* WidgetCompilerRule_ptr => (WidgetCompilerRule_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetCompilerRule(IntPtr p) => UObject.Make<WidgetCompilerRule>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetCompilerRule DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetCompilerRule New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
