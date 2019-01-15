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
using UE4.UMG;

namespace UE4.LevelSequence {
    ///<summary>Base class for level sequence burn ins</summary>
    public unsafe partial class LevelSequenceBurnIn : UserWidget  {

        ///<summary>Called when this burn in is receiving its settings</summary>
        public event SetSettings_delegate SetSettings;
        public delegate void SetSettings_delegate(UObject InSettings);
        internal void on_SetSettings(UObject InSettings) =>
            SetSettings?.Invoke(InSettings);


        ///<summary>Get the settings class to use for this burn in</summary>
        public event GetSettingsClass_delegate GetSettingsClass;
        public delegate SubclassOf<LevelSequenceBurnInInitSettings> GetSettingsClass_delegate(SubclassOf<LevelSequenceBurnInInitSettings> ReturnValue);
        internal SubclassOf<LevelSequenceBurnInInitSettings> on_GetSettingsClass(SubclassOf<LevelSequenceBurnInInitSettings> ReturnValue) =>
            GetSettingsClass != null ? GetSettingsClass(ReturnValue) : ReturnValue;

        ///<summary>Snapshot of frame information.</summary>
        public unsafe LevelSequencePlayerSnapshot FrameInformation {
            get {return LevelSequenceBurnIn_ptr->FrameInformation;}
        }
        ///<summary>The actor to get our burn in frames from</summary>
        public unsafe LevelSequenceActor LevelSequenceActor {
            get {return LevelSequenceBurnIn_ptr->LevelSequenceActor;}
        }
        static LevelSequenceBurnIn() {
            StaticClass = Main.GetClass("LevelSequenceBurnIn");
            LevelSequenceBurnIn_events.SetSettings_event.Setup();
            LevelSequenceBurnIn_events.GetSettingsClass_event.Setup();
        }
        internal unsafe LevelSequenceBurnIn_fields* LevelSequenceBurnIn_ptr => (LevelSequenceBurnIn_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelSequenceBurnIn(IntPtr p) => UObject.Make<LevelSequenceBurnIn>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelSequenceBurnIn DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelSequenceBurnIn New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
