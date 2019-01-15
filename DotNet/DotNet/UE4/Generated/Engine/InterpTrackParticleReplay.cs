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
    ///<summary>Interp Track Particle Replay</summary>
    public unsafe partial class InterpTrackParticleReplay : InterpTrack  {
         //TODO: array not UObject TArray TrackKeys
        public bool bIsCapturingReplay {
            get {return Main.GetGetBoolPropertyByName(this, "bIsCapturingReplay"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsCapturingReplay", value); }
        }
        ///<summary>Current replay fixed time quantum between frames (one over frame rate)</summary>
        public unsafe float FixedTimeStep {
            get {return InterpTrackParticleReplay_ptr->FixedTimeStep;}
            set {InterpTrackParticleReplay_ptr->FixedTimeStep = value;}
        }
        static InterpTrackParticleReplay() {
            StaticClass = Main.GetClass("InterpTrackParticleReplay");
        }
        internal unsafe InterpTrackParticleReplay_fields* InterpTrackParticleReplay_ptr => (InterpTrackParticleReplay_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackParticleReplay(IntPtr p) => UObject.Make<InterpTrackParticleReplay>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackParticleReplay DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackParticleReplay New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
