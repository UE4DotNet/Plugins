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
    ///<summary>DEditor Vector Parameter Value</summary>
    public unsafe partial class DEditorVectorParameterValue : DEditorParameterValue  {
        ///<summary>Parameter Value</summary>
        public unsafe LinearColor ParameterValue {
            get {return DEditorVectorParameterValue_ptr->ParameterValue;}
            set {DEditorVectorParameterValue_ptr->ParameterValue = value;}
        }
        public bool bIsUsedAsChannelMask {
            get {return Main.GetGetBoolPropertyByName(this, "bIsUsedAsChannelMask"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsUsedAsChannelMask", value); }
        }
        static DEditorVectorParameterValue() {
            StaticClass = Main.GetClass("DEditorVectorParameterValue");
        }
        internal unsafe DEditorVectorParameterValue_fields* DEditorVectorParameterValue_ptr => (DEditorVectorParameterValue_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DEditorVectorParameterValue(IntPtr p) => UObject.Make<DEditorVectorParameterValue>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DEditorVectorParameterValue DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DEditorVectorParameterValue New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
