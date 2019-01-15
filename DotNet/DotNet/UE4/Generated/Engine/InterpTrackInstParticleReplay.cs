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
    ///<summary>Interp Track Inst Particle Replay</summary>
    public unsafe partial class InterpTrackInstParticleReplay : InterpTrackInst  {
        ///<summary>Position we were in last time we evaluated.</summary>
        ///<remarks>During UpdateTrack, events between this time and the current time will be processed.</remarks>
        public unsafe float LastUpdatePosition {
            get {return InterpTrackInstParticleReplay_ptr->LastUpdatePosition;}
            set {InterpTrackInstParticleReplay_ptr->LastUpdatePosition = value;}
        }
        static InterpTrackInstParticleReplay() {
            StaticClass = Main.GetClass("InterpTrackInstParticleReplay");
        }
        internal unsafe InterpTrackInstParticleReplay_fields* InterpTrackInstParticleReplay_ptr => (InterpTrackInstParticleReplay_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstParticleReplay(IntPtr p) => UObject.Make<InterpTrackInstParticleReplay>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstParticleReplay DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstParticleReplay New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
