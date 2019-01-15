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
using UE4.StandardMacros.Native;

namespace UE4.StandardMacros {
    ///<summary>Standard Macros</summary>
    public unsafe partial class SKEL_StandardMacros_C : UObject  {
        static SKEL_StandardMacros_C() {
            StaticClass = Main.GetClass("SKEL_StandardMacros_C");
        }
        internal unsafe SKEL_StandardMacros_C_fields* SKEL_StandardMacros_C_ptr => (SKEL_StandardMacros_C_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SKEL_StandardMacros_C(IntPtr p) => UObject.Make<SKEL_StandardMacros_C>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SKEL_StandardMacros_C DefaultObject => Main.GetDefaultObject(StaticClass);
    }
}
