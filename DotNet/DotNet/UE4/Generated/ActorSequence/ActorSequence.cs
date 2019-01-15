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
    ///<summary>Movie scene animation embedded within an actor.</summary>
    public unsafe partial class ActorSequence : MovieSceneSequence  {
        ///<summary>Pointer to the movie scene that controls this animation.</summary>
        public unsafe UMovieScene UMovieScene {
            get {return ActorSequence_ptr->UMovieScene;}
            set {ActorSequence_ptr->UMovieScene = value;}
        }
        ///<summary>Collection of object references.</summary>
        public unsafe ActorSequenceObjectReferenceMap ObjectReferences {
            get {return ActorSequence_ptr->ObjectReferences;}
            set {ActorSequence_ptr->ObjectReferences = value;}
        }
        public bool bHasBeenInitialized {
            get {return Main.GetGetBoolPropertyByName(this, "bHasBeenInitialized"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasBeenInitialized", value); }
        }
        static ActorSequence() {
            StaticClass = Main.GetClass("ActorSequence");
        }
        internal unsafe ActorSequence_fields* ActorSequence_ptr => (ActorSequence_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ActorSequence(IntPtr p) => UObject.Make<ActorSequence>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ActorSequence DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ActorSequence New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
