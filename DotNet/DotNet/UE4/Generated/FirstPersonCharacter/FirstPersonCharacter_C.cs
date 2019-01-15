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
using UE4.FirstPersonCharacter.Native;
using UE4.DotNetTest;

namespace UE4.FirstPersonCharacter {
    ///<summary>First Person Character</summary>
    public unsafe partial class FirstPersonCharacter_C : DotNetTestCharacter  {
        static FirstPersonCharacter_C() {
            StaticClass = Main.GetClass("FirstPersonCharacter_C");
        }
        internal unsafe FirstPersonCharacter_C_fields* FirstPersonCharacter_C_ptr => (FirstPersonCharacter_C_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FirstPersonCharacter_C(IntPtr p) => UObject.Make<FirstPersonCharacter_C>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FirstPersonCharacter_C DefaultObject => Main.GetDefaultObject(StaticClass);
    }
}
