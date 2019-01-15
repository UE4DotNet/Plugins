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
    ///<summary>Sound Wave</summary>
    public unsafe partial class SoundWave : SoundBase  {
        ///<summary>Platform agnostic compression quality. 1..100 with 1 being best compression and 100 being best quality.</summary>
        public unsafe int CompressionQuality {
            get {return SoundWave_ptr->CompressionQuality;}
            set {SoundWave_ptr->CompressionQuality = value;}
        }
        ///<summary>Priority of this sound when streaming (lower priority streams may not always play)</summary>
        public unsafe int StreamingPriority {
            get {return SoundWave_ptr->StreamingPriority;}
            set {SoundWave_ptr->StreamingPriority = value;}
        }
         //TODO: enum ESoundwaveSampleRateSettings SampleRateQuality
        ///<summary>Sound Group</summary>
        public unsafe byte SoundGroup {
            get {return SoundWave_ptr->SoundGroup;}
            set {SoundWave_ptr->SoundGroup = value;}
        }
        public bool bLooping {
            get {return Main.GetGetBoolPropertyByName(this, "bLooping"); }
            set {Main.SetGetBoolPropertyByName(this, "bLooping", value); }
        }
        public bool bStreaming {
            get {return Main.GetGetBoolPropertyByName(this, "bStreaming"); }
            set {Main.SetGetBoolPropertyByName(this, "bStreaming", value); }
        }
        public bool bMature {
            get {return Main.GetGetBoolPropertyByName(this, "bMature"); }
            set {Main.SetGetBoolPropertyByName(this, "bMature", value); }
        }
        public bool bManualWordWrap {
            get {return Main.GetGetBoolPropertyByName(this, "bManualWordWrap"); }
            set {Main.SetGetBoolPropertyByName(this, "bManualWordWrap", value); }
        }
        public bool bSingleLine {
            get {return Main.GetGetBoolPropertyByName(this, "bSingleLine"); }
            set {Main.SetGetBoolPropertyByName(this, "bSingleLine", value); }
        }
        public bool bVirtualizeWhenSilent {
            get {return Main.GetGetBoolPropertyByName(this, "bVirtualizeWhenSilent"); }
            set {Main.SetGetBoolPropertyByName(this, "bVirtualizeWhenSilent", value); }
        }
        public bool bIsAmbisonics {
            get {return Main.GetGetBoolPropertyByName(this, "bIsAmbisonics"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsAmbisonics", value); }
        }
         //TODO: string FString SpokenText
        ///<summary>The priority of the subtitle.</summary>
        public unsafe float SubtitlePriority {
            get {return SoundWave_ptr->SubtitlePriority;}
            set {SoundWave_ptr->SubtitlePriority = value;}
        }
        ///<summary>Playback volume of sound 0 to 1 - Default is 1.0.</summary>
        public unsafe float Volume {
            get {return SoundWave_ptr->Volume;}
            set {SoundWave_ptr->Volume = value;}
        }
        ///<summary>Playback pitch for sound.</summary>
        public unsafe float Pitch {
            get {return SoundWave_ptr->Pitch;}
            set {SoundWave_ptr->Pitch = value;}
        }
        ///<summary>Number of channels of multichannel data; 1 or 2 for regular mono and stereo files</summary>
        public unsafe int NumChannels {
            get {return SoundWave_ptr->NumChannels;}
            set {SoundWave_ptr->NumChannels = value;}
        }
         //TODO: array not UObject TArray ChannelOffsets
         //TODO: array not UObject TArray ChannelSizes
        ///<summary>Size of RawPCMData, or what RawPCMData would be if the sound was fully decompressed</summary>
        public unsafe int RawPCMDataSize {
            get {return SoundWave_ptr->RawPCMDataSize;}
            set {SoundWave_ptr->RawPCMDataSize = value;}
        }
        ///<summary>Cached sample rate for displaying in the tools</summary>
        public unsafe int SampleRate {
            get {return SoundWave_ptr->SampleRate;}
            set {SoundWave_ptr->SampleRate = value;}
        }
         //TODO: array not UObject TArray Subtitles
         //TODO: string FString Comment
         //TODO: array not UObject TArray LocalizedSubtitles
        ///<summary>Asset Import Data</summary>
        public unsafe AssetImportData AssetImportData {
            get {return SoundWave_ptr->AssetImportData;}
            set {SoundWave_ptr->AssetImportData = value;}
        }
        ///<summary>Curves associated with this sound wave</summary>
        public unsafe CurveTable Curves {
            get {return SoundWave_ptr->Curves;}
            set {SoundWave_ptr->Curves = value;}
        }
        ///<summary>Hold a reference to our internal curve so we can switch back to it if we want to</summary>
        public unsafe CurveTable InternalCurves {
            get {return SoundWave_ptr->InternalCurves;}
            set {SoundWave_ptr->InternalCurves = value;}
        }
        static SoundWave() {
            StaticClass = Main.GetClass("SoundWave");
        }
        internal unsafe SoundWave_fields* SoundWave_ptr => (SoundWave_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundWave(IntPtr p) => UObject.Make<SoundWave>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundWave DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundWave New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
