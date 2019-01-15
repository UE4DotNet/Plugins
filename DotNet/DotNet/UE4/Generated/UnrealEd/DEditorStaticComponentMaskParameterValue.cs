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

namespace UE4.UnrealEd {
    ///<summary>DEditor Static Component Mask Parameter Value</summary>
    public unsafe partial class DEditorStaticComponentMaskParameterValue : DEditorParameterValue  {
        ///<summary>Parameter Value</summary>
        public unsafe DComponentMaskParameter ParameterValue {
            get {return DEditorStaticComponentMaskParameterValue_ptr->ParameterValue;}
            set {DEditorStaticComponentMaskParameterValue_ptr->ParameterValue = value;}
        }
        static DEditorStaticComponentMaskParameterValue() {
            StaticClass = Main.GetClass("DEditorStaticComponentMaskParameterValue");
        }
        internal unsafe DEditorStaticComponentMaskParameterValue_fields* DEditorStaticComponentMaskParameterValue_ptr => (DEditorStaticComponentMaskParameterValue_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DEditorStaticComponentMaskParameterValue(IntPtr p) => UObject.Make<DEditorStaticComponentMaskParameterValue>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DEditorStaticComponentMaskParameterValue DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DEditorStaticComponentMaskParameterValue New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
