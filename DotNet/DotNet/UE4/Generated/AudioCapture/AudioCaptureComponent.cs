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
using UE4.AudioCapture.Native;
using UE4.AudioMixer;

namespace UE4.AudioCapture {
    ///<summary>Audio Capture Component</summary>
    public unsafe partial class AudioCaptureComponent : SynthComponent  {
        ///<summary>Induced latency in audio frames to use to account for jitter between mic capture hardware and audio render hardware.</summary>
        ///<remarks>Increasing this number will increase latency but reduce potential for underruns.</remarks>
        public unsafe int JitterLatencyFrames {
            get {return AudioCaptureComponent_ptr->JitterLatencyFrames;}
            set {AudioCaptureComponent_ptr->JitterLatencyFrames = value;}
        }
        static AudioCaptureComponent() {
            StaticClass = Main.GetClass("AudioCaptureComponent");
        }
        internal unsafe AudioCaptureComponent_fields* AudioCaptureComponent_ptr => (AudioCaptureComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AudioCaptureComponent(IntPtr p) => UObject.Make<AudioCaptureComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AudioCaptureComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AudioCaptureComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
