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
    ///<summary>Internal commandlet to fix any conflicting localization keys that are found in a manifest.</summary>
    ///<remarks>
    ///@note Hard-coded to work with the "Game" localization target.
    ///</remarks>
    public unsafe partial class FixConflictingLocalizationKeysCommandlet : Commandlet  {
        static FixConflictingLocalizationKeysCommandlet() {
            StaticClass = Main.GetClass("FixConflictingLocalizationKeysCommandlet");
        }
        internal unsafe FixConflictingLocalizationKeysCommandlet_fields* FixConflictingLocalizationKeysCommandlet_ptr => (FixConflictingLocalizationKeysCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FixConflictingLocalizationKeysCommandlet(IntPtr p) => UObject.Make<FixConflictingLocalizationKeysCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FixConflictingLocalizationKeysCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FixConflictingLocalizationKeysCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
