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
using UE4.AudioEditor.Native;
using UE4.UnrealEd;
using UE4.Engine;

namespace UE4.AudioEditor {
    ///<summary>Sound Cue Factory New</summary>
    public unsafe partial class SoundCueFactoryNew : Factory  {
        ///<summary>An initial sound wave to place in the newly created cue</summary>
        public unsafe SoundWave InitialSoundWave {
            get {return SoundCueFactoryNew_ptr->InitialSoundWave;}
            set {SoundCueFactoryNew_ptr->InitialSoundWave = value;}
        }
        ///<summary>An initial dialogue wave to place in the newly created cue</summary>
        public unsafe DialogueWave InitialDialogueWave {
            get {return SoundCueFactoryNew_ptr->InitialDialogueWave;}
            set {SoundCueFactoryNew_ptr->InitialDialogueWave = value;}
        }
        static SoundCueFactoryNew() {
            StaticClass = Main.GetClass("SoundCueFactoryNew");
        }
        internal unsafe SoundCueFactoryNew_fields* SoundCueFactoryNew_ptr => (SoundCueFactoryNew_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundCueFactoryNew(IntPtr p) => UObject.Make<SoundCueFactoryNew>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundCueFactoryNew DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundCueFactoryNew New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
