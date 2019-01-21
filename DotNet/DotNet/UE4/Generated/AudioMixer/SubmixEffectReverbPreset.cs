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
    ///<summary>Submix Effect Reverb Preset</summary>
    public unsafe partial class SubmixEffectReverbPreset : SoundEffectSubmixPreset  {

        ///<summary>Set Settings</summary>
        public void SetSettings(SubmixEffectReverbSettings InSettings)  => 
            SubmixEffectReverbPreset_methods.SetSettings_method.Invoke(ObjPointer, InSettings);

        ///<summary>Set Settings with Reverb Effect</summary>
        public void SetSettingsWithReverbEffect(ReverbEffect InReverbEffect, float WetLevel, float DryLevel)  => 
            SubmixEffectReverbPreset_methods.SetSettingsWithReverbEffect_method.Invoke(ObjPointer, InReverbEffect, WetLevel, DryLevel);
        ///<summary>Settings</summary>
        public unsafe SubmixEffectReverbSettings Settings {
            get {return SubmixEffectReverbPreset_ptr->Settings;}
            set {SubmixEffectReverbPreset_ptr->Settings = value;}
        }
        static SubmixEffectReverbPreset() {
            StaticClass = Main.GetClass("SubmixEffectReverbPreset");
        }
        internal unsafe SubmixEffectReverbPreset_fields* SubmixEffectReverbPreset_ptr => (SubmixEffectReverbPreset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SubmixEffectReverbPreset(IntPtr p) => UObject.Make<SubmixEffectReverbPreset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SubmixEffectReverbPreset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SubmixEffectReverbPreset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
