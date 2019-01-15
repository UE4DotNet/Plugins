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
    ///<summary>Audio Volume</summary>
    public unsafe partial class AudioVolume : Volume  {

        ///<summary>Set Enabled</summary>
        public void SetEnabled(bool bNewEnabled)  => 
            AudioVolume_methods.SetEnabled_method.Invoke(ObjPointer, bNewEnabled);

        ///<summary>Set Interior Settings</summary>
        public void SetInteriorSettings(InteriorSettings NewInteriorSettings)  => 
            AudioVolume_methods.SetInteriorSettings_method.Invoke(ObjPointer, NewInteriorSettings);

        ///<summary>Set Priority</summary>
        public void SetPriority(float NewPriority)  => 
            AudioVolume_methods.SetPriority_method.Invoke(ObjPointer, NewPriority);

        ///<summary>Set Reverb Settings</summary>
        public void SetReverbSettings(ReverbSettings NewReverbSettings)  => 
            AudioVolume_methods.SetReverbSettings_method.Invoke(ObjPointer, NewReverbSettings);
        ///<summary>Priority of this volume.</summary>
        ///<remarks>
        ///In the case of overlapping volumes the one with the highest priority
        ///is chosen. The order is undefined if two or more overlapping volumes have the same priority.
        ///</remarks>
        public unsafe float Priority {
            get {return AudioVolume_ptr->Priority;}
        }
        public bool bEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bEnabled"); }
        }
        ///<summary>Reverb settings to use for this volume.</summary>
        public unsafe ReverbSettings Settings {
            get {return AudioVolume_ptr->Settings;}
        }
        ///<summary>Interior settings used for this volume</summary>
        public unsafe InteriorSettings AmbientZoneSettings {
            get {return AudioVolume_ptr->AmbientZoneSettings;}
        }
        static AudioVolume() {
            StaticClass = Main.GetClass("AudioVolume");
        }
        internal unsafe AudioVolume_fields* AudioVolume_ptr => (AudioVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AudioVolume(IntPtr p) => UObject.Make<AudioVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AudioVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AudioVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
