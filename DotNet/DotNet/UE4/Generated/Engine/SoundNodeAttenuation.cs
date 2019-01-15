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
    ///<summary>Defines how a sound's volume changes based on distance to the listener</summary>
    public unsafe partial class SoundNodeAttenuation : SoundNode  {
        ///<summary>Attenuation Settings</summary>
        public unsafe SoundAttenuation AttenuationSettings {
            get {return SoundNodeAttenuation_ptr->AttenuationSettings;}
            set {SoundNodeAttenuation_ptr->AttenuationSettings = value;}
        }
        ///<summary>Attenuation Overrides</summary>
        public unsafe SoundAttenuationSettings AttenuationOverrides {
            get {return SoundNodeAttenuation_ptr->AttenuationOverrides;}
            set {SoundNodeAttenuation_ptr->AttenuationOverrides = value;}
        }
        public bool bOverrideAttenuation {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideAttenuation"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideAttenuation", value); }
        }
        static SoundNodeAttenuation() {
            StaticClass = Main.GetClass("SoundNodeAttenuation");
        }
        internal unsafe SoundNodeAttenuation_fields* SoundNodeAttenuation_ptr => (SoundNodeAttenuation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeAttenuation(IntPtr p) => UObject.Make<SoundNodeAttenuation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeAttenuation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeAttenuation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
