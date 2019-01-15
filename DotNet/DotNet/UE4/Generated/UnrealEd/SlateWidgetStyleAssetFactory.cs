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
using UE4.SlateCore;

namespace UE4.UnrealEd {
    ///<summary>Factory for creating SlateStyles</summary>
    public unsafe partial class SlateWidgetStyleAssetFactory : Factory  {
        ///<summary>Style Type</summary>
        public unsafe SubclassOf<SlateWidgetStyleContainerBase> StyleType {
            get {return SlateWidgetStyleAssetFactory_ptr->StyleType;}
            set {SlateWidgetStyleAssetFactory_ptr->StyleType = value;}
        }
        static SlateWidgetStyleAssetFactory() {
            StaticClass = Main.GetClass("SlateWidgetStyleAssetFactory");
        }
        internal unsafe SlateWidgetStyleAssetFactory_fields* SlateWidgetStyleAssetFactory_ptr => (SlateWidgetStyleAssetFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SlateWidgetStyleAssetFactory(IntPtr p) => UObject.Make<SlateWidgetStyleAssetFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SlateWidgetStyleAssetFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SlateWidgetStyleAssetFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
