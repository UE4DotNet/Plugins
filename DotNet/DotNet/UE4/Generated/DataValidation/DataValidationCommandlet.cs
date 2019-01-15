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
using UE4.DataValidation.Native;
using UE4.Engine;

namespace UE4.DataValidation {
    ///<summary>Data Validation Commandlet</summary>
    public unsafe partial class DataValidationCommandlet : Commandlet  {
        static DataValidationCommandlet() {
            StaticClass = Main.GetClass("DataValidationCommandlet");
        }
        internal unsafe DataValidationCommandlet_fields* DataValidationCommandlet_ptr => (DataValidationCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DataValidationCommandlet(IntPtr p) => UObject.Make<DataValidationCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DataValidationCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DataValidationCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
