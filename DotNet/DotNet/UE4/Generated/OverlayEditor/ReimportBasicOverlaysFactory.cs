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

namespace UE4.OverlayEditor {
    ///<summary>A factory for reimporting basic overlays</summary>
    public unsafe partial class ReimportBasicOverlaysFactory : BasicOverlaysFactory  {
        static ReimportBasicOverlaysFactory() {
            StaticClass = Main.GetClass("ReimportBasicOverlaysFactory");
        }
        internal unsafe ReimportBasicOverlaysFactory_fields* ReimportBasicOverlaysFactory_ptr => (ReimportBasicOverlaysFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ReimportBasicOverlaysFactory(IntPtr p) => UObject.Make<ReimportBasicOverlaysFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ReimportBasicOverlaysFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ReimportBasicOverlaysFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
