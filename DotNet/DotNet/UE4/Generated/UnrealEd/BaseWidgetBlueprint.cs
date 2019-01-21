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
using UE4.UnrealEd.Native;
using UE4.Engine;
using UE4.UMG;

namespace UE4.UnrealEd {
    ///<summary>Base Widget Blueprint</summary>
    public unsafe partial class BaseWidgetBlueprint : Blueprint  {
        ///<summary>A tree of the widget templates to be created</summary>
        public unsafe WidgetTree WidgetTree {
            get {return BaseWidgetBlueprint_ptr->WidgetTree;}
            set {BaseWidgetBlueprint_ptr->WidgetTree = value;}
        }
        static BaseWidgetBlueprint() {
            StaticClass = Main.GetClass("BaseWidgetBlueprint");
        }
        internal unsafe BaseWidgetBlueprint_fields* BaseWidgetBlueprint_ptr => (BaseWidgetBlueprint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BaseWidgetBlueprint(IntPtr p) => UObject.Make<BaseWidgetBlueprint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BaseWidgetBlueprint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BaseWidgetBlueprint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
