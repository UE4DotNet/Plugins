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
    ///<summary>Computes doppler pitch shift</summary>
    public unsafe partial class SoundNodeDoppler : SoundNode  {
        ///<summary>How much to scale the doppler shift (1.0 is normal).</summary>
        public unsafe float DopplerIntensity {
            get {return SoundNodeDoppler_ptr->DopplerIntensity;}
            set {SoundNodeDoppler_ptr->DopplerIntensity = value;}
        }
        static SoundNodeDoppler() {
            StaticClass = Main.GetClass("SoundNodeDoppler");
        }
        internal unsafe SoundNodeDoppler_fields* SoundNodeDoppler_ptr => (SoundNodeDoppler_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeDoppler(IntPtr p) => UObject.Make<SoundNodeDoppler>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeDoppler DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeDoppler New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
