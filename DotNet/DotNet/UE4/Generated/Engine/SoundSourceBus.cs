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
    ///<summary>A source bus is a type of USoundBase and can be "played" like any sound.</summary>
    public unsafe partial class SoundSourceBus : SoundWave  {
         //TODO: enum ESourceBusChannels SourceBusChannels
        ///<summary>The duration (in seconds) to use for the source bus. A duration of 0.0 indicates to play the source bus indefinitely.</summary>
        public unsafe float SourceBusDuration {
            get {return SoundSourceBus_ptr->SourceBusDuration;}
            set {SoundSourceBus_ptr->SourceBusDuration = value;}
        }
        public bool bAutoDeactivateWhenSilent {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoDeactivateWhenSilent"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoDeactivateWhenSilent", value); }
        }
        static SoundSourceBus() {
            StaticClass = Main.GetClass("SoundSourceBus");
        }
        internal unsafe SoundSourceBus_fields* SoundSourceBus_ptr => (SoundSourceBus_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundSourceBus(IntPtr p) => UObject.Make<SoundSourceBus>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundSourceBus DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundSourceBus New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
