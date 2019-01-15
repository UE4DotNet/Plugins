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
    ///<summary>Submix Effect Dynamics Processor Preset</summary>
    public unsafe partial class SubmixEffectDynamicsProcessorPreset : SoundEffectSubmixPreset  {

        ///<summary>Set Settings</summary>
        public void SetSettings(SubmixEffectDynamicsProcessorSettings InSettings)  => 
            SubmixEffectDynamicsProcessorPreset_methods.SetSettings_method.Invoke(ObjPointer, InSettings);
        ///<summary>Settings</summary>
        public unsafe SubmixEffectDynamicsProcessorSettings Settings {
            get {return SubmixEffectDynamicsProcessorPreset_ptr->Settings;}
            set {SubmixEffectDynamicsProcessorPreset_ptr->Settings = value;}
        }
        static SubmixEffectDynamicsProcessorPreset() {
            StaticClass = Main.GetClass("SubmixEffectDynamicsProcessorPreset");
        }
        internal unsafe SubmixEffectDynamicsProcessorPreset_fields* SubmixEffectDynamicsProcessorPreset_ptr => (SubmixEffectDynamicsProcessorPreset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SubmixEffectDynamicsProcessorPreset(IntPtr p) => UObject.Make<SubmixEffectDynamicsProcessorPreset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SubmixEffectDynamicsProcessorPreset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SubmixEffectDynamicsProcessorPreset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
