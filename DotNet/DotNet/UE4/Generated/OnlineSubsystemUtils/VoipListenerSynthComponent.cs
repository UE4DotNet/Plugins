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
using UE4.OnlineSubsystemUtils.Native;
using UE4.AudioMixer;

namespace UE4.OnlineSubsystemUtils {
    ///<summary>Voip Listener Synth Component</summary>
    public unsafe partial class VoipListenerSynthComponent : SynthComponent  {

        ///<summary>* Thread safe way to get whether this synth component still has buffered packets of audio to play back.</summary>
        ///<remarks>
        ///* This function is used by the Voice Engine to clean up voice sounds when they are not playing back audio
        ///* to make space for other sounds to be rendered.
        ///
        ///* @returns true if this synth component is lollygagging/dawdling/out of audio to play.
        ///</remarks>
        public bool IsIdling()  => 
            VoipListenerSynthComponent_methods.IsIdling_method.Invoke(ObjPointer);
        static VoipListenerSynthComponent() {
            StaticClass = Main.GetClass("VoipListenerSynthComponent");
        }
        internal unsafe VoipListenerSynthComponent_fields* VoipListenerSynthComponent_ptr => (VoipListenerSynthComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VoipListenerSynthComponent(IntPtr p) => UObject.Make<VoipListenerSynthComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VoipListenerSynthComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VoipListenerSynthComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
