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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Sound Surround Exporter WAV</summary>
    public unsafe partial class SoundSurroundExporterWAV : Exporter  {
        static SoundSurroundExporterWAV() {
            StaticClass = Main.GetClass("SoundSurroundExporterWAV");
        }
        internal unsafe SoundSurroundExporterWAV_fields* SoundSurroundExporterWAV_ptr => (SoundSurroundExporterWAV_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundSurroundExporterWAV(IntPtr p) => UObject.Make<SoundSurroundExporterWAV>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundSurroundExporterWAV DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundSurroundExporterWAV New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
