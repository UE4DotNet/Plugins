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
    ///<summary>Dialogue Wave Factory</summary>
    public unsafe partial class DialogueWaveFactory : Factory  {
        ///<summary>An initial sound wave to place in the newly created dialogue wave</summary>
        public unsafe SoundWave InitialSoundWave {
            get {return DialogueWaveFactory_ptr->InitialSoundWave;}
            set {DialogueWaveFactory_ptr->InitialSoundWave = value;}
        }
        ///<summary>An initial speaking dialogue voice to place in the newly created dialogue wave</summary>
        public unsafe DialogueVoice InitialSpeakerVoice {
            get {return DialogueWaveFactory_ptr->InitialSpeakerVoice;}
            set {DialogueWaveFactory_ptr->InitialSpeakerVoice = value;}
        }
        public bool HasSetInitialTargetVoice {
            get {return Main.GetGetBoolPropertyByName(this, "HasSetInitialTargetVoice"); }
            set {Main.SetGetBoolPropertyByName(this, "HasSetInitialTargetVoice", value); }
        }
        ///<summary>An initial target dialogue voices to place in the newly created dialogue wave</summary>
        public ObjectArrayField<DialogueVoice> InitialTargetVoices{ get {
            if(InitialTargetVoices_store == null) InitialTargetVoices_store = new ObjectArrayField<DialogueVoice> (&DialogueWaveFactory_ptr->InitialTargetVoices);
            return InitialTargetVoices_store;
        } }
        private ObjectArrayField<DialogueVoice> InitialTargetVoices_store;

        static DialogueWaveFactory() {
            StaticClass = Main.GetClass("DialogueWaveFactory");
        }
        internal unsafe DialogueWaveFactory_fields* DialogueWaveFactory_ptr => (DialogueWaveFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DialogueWaveFactory(IntPtr p) => UObject.Make<DialogueWaveFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DialogueWaveFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DialogueWaveFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
