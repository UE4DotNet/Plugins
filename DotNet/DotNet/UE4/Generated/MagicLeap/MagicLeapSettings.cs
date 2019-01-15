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
using UE4.MagicLeap.Native;

namespace UE4.MagicLeap {
    ///<summary>Implements the settings for the Magic Leap SDK setup.</summary>
    public unsafe partial class MagicLeapSettings : UObject  {
        public bool bEnableZI {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableZI"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableZI", value); }
        }
        static MagicLeapSettings() {
            StaticClass = Main.GetClass("MagicLeapSettings");
        }
        internal unsafe MagicLeapSettings_fields* MagicLeapSettings_ptr => (MagicLeapSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapSettings(IntPtr p) => UObject.Make<MagicLeapSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
