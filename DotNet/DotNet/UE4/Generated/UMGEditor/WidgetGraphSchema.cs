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
using UE4.BlueprintGraph;

namespace UE4.UMGEditor {
    ///<summary>Widget Graph Schema</summary>
    public unsafe partial class WidgetGraphSchema : EdGraphSchema_K2  {
        static WidgetGraphSchema() {
            StaticClass = Main.GetClass("WidgetGraphSchema");
        }
        internal unsafe WidgetGraphSchema_fields* WidgetGraphSchema_ptr => (WidgetGraphSchema_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetGraphSchema(IntPtr p) => UObject.Make<WidgetGraphSchema>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetGraphSchema DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetGraphSchema New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
