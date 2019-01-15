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
using UE4.SlateCore.Native;

namespace UE4.SlateCore {
    ///<summary>Font Bulk Data</summary>
    public unsafe partial class FontBulkData : UObject  {
        static FontBulkData() {
            StaticClass = Main.GetClass("FontBulkData");
        }
        internal unsafe FontBulkData_fields* FontBulkData_ptr => (FontBulkData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FontBulkData(IntPtr p) => UObject.Make<FontBulkData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FontBulkData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FontBulkData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
