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
using UE4.AudioMixer.Native;
using UE4.Engine;

namespace UE4.AudioMixer {
    ///<summary>Audio Mixer Blueprint Library</summary>
    public unsafe partial class AudioMixerBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Adds a submix effect preset to the master submix.</summary>
        public static void AddMasterSubmixEffect(UObject WorldContextObject, SoundEffectSubmixPreset SubmixEffectPreset)  => 
            AudioMixerBlueprintLibrary_methods.AddMasterSubmixEffect_method.Invoke(WorldContextObject, SubmixEffectPreset);

        ///<summary>Adds source effect entry to preset chain. Only effects the instance of the preset chain</summary>
        public static void AddSourceEffectToPresetChain(UObject WorldContextObject, SoundEffectSourcePresetChain PresetChain, SourceEffectChainEntry Entry)  => 
            AudioMixerBlueprintLibrary_methods.AddSourceEffectToPresetChain_method.Invoke(WorldContextObject, PresetChain, Entry);

        ///<summary>Clears all master submix effects.</summary>
        public static void ClearMasterSubmixEffects(UObject WorldContextObject)  => 
            AudioMixerBlueprintLibrary_methods.ClearMasterSubmixEffects_method.Invoke(WorldContextObject);

        ///<summary>Returns the number of effect chain entries in the given source effect chain.</summary>
        public static int GetNumberOfEntriesInSourceEffectChain(UObject WorldContextObject, SoundEffectSourcePresetChain PresetChain)  => 
            AudioMixerBlueprintLibrary_methods.GetNumberOfEntriesInSourceEffectChain_method.Invoke(WorldContextObject, PresetChain);

        ///<summary>Removes a submix effect preset from the master submix.</summary>
        public static void RemoveMasterSubmixEffect(UObject WorldContextObject, SoundEffectSubmixPreset SubmixEffectPreset)  => 
            AudioMixerBlueprintLibrary_methods.RemoveMasterSubmixEffect_method.Invoke(WorldContextObject, SubmixEffectPreset);

        ///<summary>Adds source effect entry to preset chain. Only affects the instance of preset chain.</summary>
        public static void RemoveSourceEffectFromPresetChain(UObject WorldContextObject, SoundEffectSourcePresetChain PresetChain, int EntryIndex)  => 
            AudioMixerBlueprintLibrary_methods.RemoveSourceEffectFromPresetChain_method.Invoke(WorldContextObject, PresetChain, EntryIndex);

        ///<summary>Set whether or not to bypass the effect at the source effect chain index.</summary>
        public static void SetBypassSourceEffectChainEntry(UObject WorldContextObject, SoundEffectSourcePresetChain PresetChain, int EntryIndex, bool bBypassed)  => 
            AudioMixerBlueprintLibrary_methods.SetBypassSourceEffectChainEntry_method.Invoke(WorldContextObject, PresetChain, EntryIndex, bBypassed);

        ///<summary>Start recording audio. By leaving the Submix To Record field blank, you can record the master output of the game.</summary>
        public static void StartRecordingOutput(UObject WorldContextObject, float ExpectedDuration, SoundSubmix SubmixToRecord)  => 
            AudioMixerBlueprintLibrary_methods.StartRecordingOutput_method.Invoke(WorldContextObject, ExpectedDuration, SubmixToRecord);

        ///<summary>Stop recording audio. By leaving the Submix To Record field blank, you can record the master output of the game.</summary>
        public static SoundWave StopRecordingOutput(UObject WorldContextObject, EAudioRecordingExportType ExportType, string Name, string Path, SoundSubmix SubmixToRecord, SoundWave ExistingSoundWaveToOverwrite)  => 
            AudioMixerBlueprintLibrary_methods.StopRecordingOutput_method.Invoke(WorldContextObject, ExportType, Name, Path, SubmixToRecord, ExistingSoundWaveToOverwrite);
        static AudioMixerBlueprintLibrary() {
            StaticClass = Main.GetClass("AudioMixerBlueprintLibrary");
        }
        internal unsafe AudioMixerBlueprintLibrary_fields* AudioMixerBlueprintLibrary_ptr => (AudioMixerBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AudioMixerBlueprintLibrary(IntPtr p) => UObject.Make<AudioMixerBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AudioMixerBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AudioMixerBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
