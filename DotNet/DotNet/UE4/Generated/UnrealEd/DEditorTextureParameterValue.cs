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

namespace UE4.UnrealEd {
    ///<summary>DEditor Texture Parameter Value</summary>
    public unsafe partial class DEditorTextureParameterValue : DEditorParameterValue  {
        ///<summary>Parameter Value</summary>
        public unsafe Texture ParameterValue {
            get {return DEditorTextureParameterValue_ptr->ParameterValue;}
            set {DEditorTextureParameterValue_ptr->ParameterValue = value;}
        }
        static DEditorTextureParameterValue() {
            StaticClass = Main.GetClass("DEditorTextureParameterValue");
        }
        internal unsafe DEditorTextureParameterValue_fields* DEditorTextureParameterValue_ptr => (DEditorTextureParameterValue_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DEditorTextureParameterValue(IntPtr p) => UObject.Make<DEditorTextureParameterValue>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DEditorTextureParameterValue DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DEditorTextureParameterValue New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
