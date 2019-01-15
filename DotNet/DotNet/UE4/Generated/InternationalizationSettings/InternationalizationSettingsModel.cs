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
using UE4.InternationalizationSettings.Native;

namespace UE4.InternationalizationSettings {
    ///<summary>Implements loading and saving of internationalization settings.</summary>
    public unsafe partial class InternationalizationSettingsModel : UObject  {
         //TODO: enum ETimezoneSetting DisplayTimezone
        static InternationalizationSettingsModel() {
            StaticClass = Main.GetClass("InternationalizationSettingsModel");
        }
        internal unsafe InternationalizationSettingsModel_fields* InternationalizationSettingsModel_ptr => (InternationalizationSettingsModel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InternationalizationSettingsModel(IntPtr p) => UObject.Make<InternationalizationSettingsModel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InternationalizationSettingsModel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InternationalizationSettingsModel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
