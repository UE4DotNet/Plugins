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
using UE4.OverlayEditor.Native;
using UE4.UnrealEd;

namespace UE4.OverlayEditor {
    ///<summary>Implements a factory for new ULocalizedOverlays objects.</summary>
    public unsafe partial class LocalizedOverlaysFactoryNew : Factory  {
        static LocalizedOverlaysFactoryNew() {
            StaticClass = Main.GetClass("LocalizedOverlaysFactoryNew");
        }
        internal unsafe LocalizedOverlaysFactoryNew_fields* LocalizedOverlaysFactoryNew_ptr => (LocalizedOverlaysFactoryNew_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LocalizedOverlaysFactoryNew(IntPtr p) => UObject.Make<LocalizedOverlaysFactoryNew>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LocalizedOverlaysFactoryNew DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LocalizedOverlaysFactoryNew New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
