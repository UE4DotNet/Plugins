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
    ///<summary>Sound node that contains a reference to the dialogue table to pull from and be played</summary>
    public unsafe partial class SoundNodeDialoguePlayer : SoundNode  {
        ///<summary>Dialogue Wave Parameter</summary>
        public unsafe DialogueWaveParameter DialogueWaveParameter {
            get {return SoundNodeDialoguePlayer_ptr->DialogueWaveParameter;}
            set {SoundNodeDialoguePlayer_ptr->DialogueWaveParameter = value;}
        }
        public bool bLooping {
            get {return Main.GetGetBoolPropertyByName(this, "bLooping"); }
            set {Main.SetGetBoolPropertyByName(this, "bLooping", value); }
        }
        static SoundNodeDialoguePlayer() {
            StaticClass = Main.GetClass("SoundNodeDialoguePlayer");
        }
        internal unsafe SoundNodeDialoguePlayer_fields* SoundNodeDialoguePlayer_ptr => (SoundNodeDialoguePlayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNodeDialoguePlayer(IntPtr p) => UObject.Make<SoundNodeDialoguePlayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNodeDialoguePlayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNodeDialoguePlayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
