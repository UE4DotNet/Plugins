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
using UE4.AudioMixer.Native;
using UE4.Engine;

namespace UE4.AudioMixer {
    ///<summary>Submix Effect Submix EQPreset</summary>
    public unsafe partial class SubmixEffectSubmixEQPreset : SoundEffectSubmixPreset  {

        ///<summary>Set Settings</summary>
        public void SetSettings(SubmixEffectSubmixEQSettings InSettings)  => 
            SubmixEffectSubmixEQPreset_methods.SetSettings_method.Invoke(ObjPointer, InSettings);
        ///<summary>Settings</summary>
        public unsafe SubmixEffectSubmixEQSettings Settings {
            get {return SubmixEffectSubmixEQPreset_ptr->Settings;}
            set {SubmixEffectSubmixEQPreset_ptr->Settings = value;}
        }
        static SubmixEffectSubmixEQPreset() {
            StaticClass = Main.GetClass("SubmixEffectSubmixEQPreset");
        }
        internal unsafe SubmixEffectSubmixEQPreset_fields* SubmixEffectSubmixEQPreset_ptr => (SubmixEffectSubmixEQPreset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SubmixEffectSubmixEQPreset(IntPtr p) => UObject.Make<SubmixEffectSubmixEQPreset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SubmixEffectSubmixEQPreset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SubmixEffectSubmixEQPreset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
