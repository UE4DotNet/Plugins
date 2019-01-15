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
using UE4.TranslationEditor.Native;

namespace UE4.TranslationEditor {
    ///<summary>Translation Picker Settings</summary>
    public unsafe partial class TranslationPickerSettings : UObject  {
        public bool bSubmitTranslationPickerChangesToLocalizationService {
            get {return Main.GetGetBoolPropertyByName(this, "bSubmitTranslationPickerChangesToLocalizationService"); }
            set {Main.SetGetBoolPropertyByName(this, "bSubmitTranslationPickerChangesToLocalizationService", value); }
        }
        static TranslationPickerSettings() {
            StaticClass = Main.GetClass("TranslationPickerSettings");
        }
        internal unsafe TranslationPickerSettings_fields* TranslationPickerSettings_ptr => (TranslationPickerSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TranslationPickerSettings(IntPtr p) => UObject.Make<TranslationPickerSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TranslationPickerSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TranslationPickerSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
