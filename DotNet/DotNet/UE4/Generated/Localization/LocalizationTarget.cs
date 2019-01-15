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
using UE4.Localization.Native;

namespace UE4.Localization {
    ///<summary>Localization Target</summary>
    public unsafe partial class LocalizationTarget : UObject  {
        ///<summary>Settings</summary>
        public unsafe LocalizationTargetSettings Settings {
            get {return LocalizationTarget_ptr->Settings;}
            set {LocalizationTarget_ptr->Settings = value;}
        }
        static LocalizationTarget() {
            StaticClass = Main.GetClass("LocalizationTarget");
        }
        internal unsafe LocalizationTarget_fields* LocalizationTarget_ptr => (LocalizationTarget_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LocalizationTarget(IntPtr p) => UObject.Make<LocalizationTarget>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LocalizationTarget DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LocalizationTarget New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
