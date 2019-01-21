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
using UE4.LevelSequence.Native;

namespace UE4.LevelSequence {
    ///<summary>Level Sequence Director</summary>
    public unsafe partial class LevelSequenceDirector : UObject  {

        ///<summary>Called when this director is created</summary>
        public event OnCreated_delegate OnCreated;
        public delegate void OnCreated_delegate();
        internal void on_OnCreated() =>
            OnCreated?.Invoke();

        ///<summary>Pointer to the player that's playing back this director's sequence</summary>
        public unsafe LevelSequencePlayer Player {
            get {return LevelSequenceDirector_ptr->Player;}
        }
        static LevelSequenceDirector() {
            StaticClass = Main.GetClass("LevelSequenceDirector");
            LevelSequenceDirector_events.OnCreated_event.Setup();
        }
        internal unsafe LevelSequenceDirector_fields* LevelSequenceDirector_ptr => (LevelSequenceDirector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelSequenceDirector(IntPtr p) => UObject.Make<LevelSequenceDirector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelSequenceDirector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelSequenceDirector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
