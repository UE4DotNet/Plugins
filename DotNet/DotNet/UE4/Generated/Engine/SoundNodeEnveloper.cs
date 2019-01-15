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
    ///<summary>Allows manipulation of volume and pitch over a set time period</summary>
    public unsafe partial class SoundNodeEnveloper : SoundNode  {
        ///<summary>The time in seconds where the envelope's loop begins.</summary>
        public unsafe float LoopStart {
            get {return SoundNodeEnveloper_ptr->LoopStart;}
            set {SoundNodeEnveloper_ptr->LoopStart = value;}
        }
        ///<summary>The time in seconds where the envelope's loop ends.</summary>
        public unsafe float LoopEnd {
            get {return SoundNodeEnveloper_ptr->LoopEnd;}
            set {SoundNodeEnveloper_ptr->LoopEnd = value;}
        }
        ///<summary>The time in seconds it takes the evelope to fade out after the last loop is completed.</summary>
        public unsafe float DurationAfterLoop {
            get {return SoundNodeEnveloper_ptr->DurationAfterLoop;}
            set {SoundNodeEnveloper_ptr->DurationAfterLoop = value;}
        }
        ///<summary>The number of times the envelope should loop if looping is enabled and the envelope is not set to loop indefinitely.</summary>
        public unsafe int LoopCount {
            get {return SoundNodeEnveloper_ptr->LoopCount;}
            set {SoundNodeEnveloper_ptr->LoopCount = value;}
        }
        public bool bLoopIndefinitely {
            get {return Main.GetGetBoolPropertyByName(this, "bLoopIndefinitely"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoopIndefinitely", value); }
        }
        public bool bLoop {
            get {return Main.GetGetBoolPropertyByName(this, "bLoop"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoop", value); }
        }
        ///<summary>The distribution defining the volume envelope.</summary>
        public unsafe RuntimeFloatCurve VolumeCurve {
            get {return SoundNodeEnveloper_ptr->VolumeCurve;}
            set {SoundNodeEnveloper_ptr->VolumeCurve = value;}
        }
        ///<summary>The distribution defining the pitch envelope.</summary>
        public unsafe RuntimeFloatCurve PitchCurve {
            get {return SoundNodeEnveloper_ptr->PitchCurve;}
            set {SoundNodeEnveloper_ptr->PitchCurve = value;}
        }
        ///<summary>The lower bound of pitch (1.0 is no change)</summary>
        public unsafe float PitchMin {
            get {return SoundNodeEnveloper_ptr->PitchMin;}
            set {SoundNodeEnveloper_ptr->PitchMin = value;}
        }
        ///<summary>The upper bound of pitch (1.0 is no change)</summary>
        public unsafe float PitchMax {
            get {return SoundNodeEnveloper_ptr->PitchMax;}
            set {SoundNodeEnveloper_ptr->PitchMax = value;}
        }
        ///<summary>The lower bound of volume (1.0 is no change)</summary>
        public unsafe float VolumeMin {
            get {return SoundNodeEnveloper_ptr->VolumeMin;}
            set {SoundNodeEnveloper_ptr->VolumeMin = value;}
        }
        ///<summary>The upper bound of volume (1.0 is no change)</summary>
        public unsafe float VolumeMax {
            get {return SoundNodeEnveloper_ptr->VolumeMax;}
            set {SoundNodeEnveloper_ptr->VolumeMax = value;}
        }
        static SoundNodeEnveloper() {
            StaticClass = Main.GetClass("SoundNodeEnveloper");
        }
        internal unsafe SoundNodeEnveloper_fields* SoundNodeEnveloper_ptr => (SoundNodeEnveloper_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeEnveloper(IntPtr p) => UObject.Make<SoundNodeEnveloper>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeEnveloper DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeEnveloper New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
