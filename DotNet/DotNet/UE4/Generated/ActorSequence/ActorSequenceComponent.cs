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
using UE4.ActorSequence.Native;
using UE4.MovieScene;
using UE4.Engine;

namespace UE4.ActorSequence {
    ///<summary>Movie scene animation embedded within an actor.</summary>
    public unsafe partial class ActorSequenceComponent : ActorComponent  {
        public bool bAutoPlay {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoPlay"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoPlay", value); }
        }
        ///<summary>Playback Settings</summary>
        public unsafe MovieSceneSequencePlaybackSettings PlaybackSettings {
            get {return ActorSequenceComponent_ptr->PlaybackSettings;}
            set {ActorSequenceComponent_ptr->PlaybackSettings = value;}
        }
        ///<summary>Embedded actor sequence data</summary>
        public unsafe ActorSequence Sequence {
            get {return ActorSequenceComponent_ptr->Sequence;}
            set {ActorSequenceComponent_ptr->Sequence = value;}
        }
        ///<summary>Sequence Player</summary>
        public unsafe ActorSequencePlayer SequencePlayer {
            get {return ActorSequenceComponent_ptr->SequencePlayer;}
        }
        static ActorSequenceComponent() {
            StaticClass = Main.GetClass("ActorSequenceComponent");
        }
        internal unsafe ActorSequenceComponent_fields* ActorSequenceComponent_ptr => (ActorSequenceComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ActorSequenceComponent(IntPtr p) => UObject.Make<ActorSequenceComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ActorSequenceComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ActorSequenceComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
