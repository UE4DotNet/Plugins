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
using UE4.Sequencer.Native;
using UE4.Engine;
using UE4.MovieSceneTracks;

namespace UE4.Sequencer {
    ///<summary>Sequencer Key Actor</summary>
    public unsafe partial class SequencerKeyActor : Actor  {
        ///<summary>The key mesh</summary>
        public unsafe StaticMeshComponent KeyMeshComponent {
            get {return SequencerKeyActor_ptr->KeyMeshComponent;}
            set {SequencerKeyActor_ptr->KeyMeshComponent = value;}
        }
        ///<summary>The actor whose transform was used to build this key</summary>
        public unsafe Actor AssociatedActor {
            get {return SequencerKeyActor_ptr->AssociatedActor;}
            set {SequencerKeyActor_ptr->AssociatedActor = value;}
        }
        ///<summary>The track section this key resides on</summary>
        public unsafe MovieScene3DTransformSection TrackSection {
            get {return SequencerKeyActor_ptr->TrackSection;}
            set {SequencerKeyActor_ptr->TrackSection = value;}
        }
        ///<summary>The time this key is associated with in Sequencer</summary>
        public unsafe float KeyTime {
            get {return SequencerKeyActor_ptr->KeyTime;}
            set {SequencerKeyActor_ptr->KeyTime = value;}
        }
        static SequencerKeyActor() {
            StaticClass = Main.GetClass("SequencerKeyActor");
        }
        internal unsafe SequencerKeyActor_fields* SequencerKeyActor_ptr => (SequencerKeyActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SequencerKeyActor(IntPtr p) => UObject.Make<SequencerKeyActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SequencerKeyActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SequencerKeyActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
