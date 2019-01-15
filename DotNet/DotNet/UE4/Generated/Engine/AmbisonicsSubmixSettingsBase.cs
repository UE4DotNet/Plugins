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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>This is a class which should be overridden to provide users with settings to use for individual sounds</summary>
    public unsafe partial class AmbisonicsSubmixSettingsBase : UObject  {
        static AmbisonicsSubmixSettingsBase() {
            StaticClass = Main.GetClass("AmbisonicsSubmixSettingsBase");
        }
        internal unsafe AmbisonicsSubmixSettingsBase_fields* AmbisonicsSubmixSettingsBase_ptr => (AmbisonicsSubmixSettingsBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AmbisonicsSubmixSettingsBase(IntPtr p) => UObject.Make<AmbisonicsSubmixSettingsBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AmbisonicsSubmixSettingsBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AmbisonicsSubmixSettingsBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
