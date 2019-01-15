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
using UE4.Transient.Native;

namespace UE4.Transient {
    ///<summary>REINST Standard Macros C 1</summary>
    public unsafe partial class REINST_StandardMacros_C_1 : UObject  {
        static REINST_StandardMacros_C_1() {
            StaticClass = Main.GetClass("REINST_StandardMacros_C_1");
        }
        internal unsafe REINST_StandardMacros_C_1_fields* REINST_StandardMacros_C_1_ptr => (REINST_StandardMacros_C_1_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator REINST_StandardMacros_C_1(IntPtr p) => UObject.Make<REINST_StandardMacros_C_1>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static REINST_StandardMacros_C_1 DefaultObject => Main.GetDefaultObject(StaticClass);
    }
}
