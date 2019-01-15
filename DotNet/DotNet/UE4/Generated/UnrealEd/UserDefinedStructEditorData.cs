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
    ///<summary>User Defined Struct Editor Data</summary>
    public unsafe partial class UserDefinedStructEditorData : UObject  {
         //TODO: numeric uint32 UniqueNameId
         //TODO: array not UObject TArray VariablesDescriptions
         //TODO: string FString ToolTip
        static UserDefinedStructEditorData() {
            StaticClass = Main.GetClass("UserDefinedStructEditorData");
        }
        internal unsafe UserDefinedStructEditorData_fields* UserDefinedStructEditorData_ptr => (UserDefinedStructEditorData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UserDefinedStructEditorData(IntPtr p) => UObject.Make<UserDefinedStructEditorData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UserDefinedStructEditorData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UserDefinedStructEditorData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
