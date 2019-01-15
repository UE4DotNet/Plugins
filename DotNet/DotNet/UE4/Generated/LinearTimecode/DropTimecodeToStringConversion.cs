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
using UE4.LinearTimecode.Native;
using UE4.Engine;

namespace UE4.LinearTimecode {
    ///<summary>Extend type conversions to handle FDropTimecode structure</summary>
    public unsafe partial class DropTimecodeToStringConversion : BlueprintFunctionLibrary  {

        ///<summary>Convert a timecode structure into a string</summary>
        public static string Conv_DropTimecodeToString(DropTimecode InTimecode)  => 
            DropTimecodeToStringConversion_methods.Conv_DropTimecodeToString_method.Invoke(InTimecode);
        static DropTimecodeToStringConversion() {
            StaticClass = Main.GetClass("DropTimecodeToStringConversion");
        }
        internal unsafe DropTimecodeToStringConversion_fields* DropTimecodeToStringConversion_ptr => (DropTimecodeToStringConversion_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DropTimecodeToStringConversion(IntPtr p) => UObject.Make<DropTimecodeToStringConversion>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DropTimecodeToStringConversion DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DropTimecodeToStringConversion New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
