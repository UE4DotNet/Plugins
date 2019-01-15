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
    ///<summary>DEditor Scalar Parameter Value</summary>
    public unsafe partial class DEditorScalarParameterValue : DEditorParameterValue  {
        ///<summary>Parameter Value</summary>
        public unsafe float ParameterValue {
            get {return DEditorScalarParameterValue_ptr->ParameterValue;}
            set {DEditorScalarParameterValue_ptr->ParameterValue = value;}
        }
        ///<summary>Atlas Data</summary>
        public unsafe ScalarParameterAtlasData AtlasData {
            get {return DEditorScalarParameterValue_ptr->AtlasData;}
            set {DEditorScalarParameterValue_ptr->AtlasData = value;}
        }
        static DEditorScalarParameterValue() {
            StaticClass = Main.GetClass("DEditorScalarParameterValue");
        }
        internal unsafe DEditorScalarParameterValue_fields* DEditorScalarParameterValue_ptr => (DEditorScalarParameterValue_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DEditorScalarParameterValue(IntPtr p) => UObject.Make<DEditorScalarParameterValue>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DEditorScalarParameterValue DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DEditorScalarParameterValue New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
