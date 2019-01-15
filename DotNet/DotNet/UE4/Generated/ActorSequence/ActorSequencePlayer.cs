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

namespace UE4.ActorSequence {
    ///<summary>UActorSequencePlayer is used to actually "play" an actor sequence asset at runtime.</summary>
    public unsafe partial class ActorSequencePlayer : MovieSceneSequencePlayer  {
        static ActorSequencePlayer() {
            StaticClass = Main.GetClass("ActorSequencePlayer");
        }
        internal unsafe ActorSequencePlayer_fields* ActorSequencePlayer_ptr => (ActorSequencePlayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ActorSequencePlayer(IntPtr p) => UObject.Make<ActorSequencePlayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ActorSequencePlayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ActorSequencePlayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
