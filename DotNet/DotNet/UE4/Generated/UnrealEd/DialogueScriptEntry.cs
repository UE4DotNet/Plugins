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


namespace UE4.UnrealEd{
        ///<summary>Dialogue Script Entry</summary>
        [StructLayout( LayoutKind.Explicit, Size=168 )]
        public unsafe struct DialogueScriptEntry {
            [FieldOffset(0)] byte SpeakingVoice; //TODO: string FString SpeakingVoice

            [FieldOffset(16)] byte TargetVoices; //TODO: array TArray TargetVoices

            [FieldOffset(32)] byte SpokenDialogue; //TODO: string FString SpokenDialogue

            [FieldOffset(48)] byte VoiceActorDirection; //TODO: string FString VoiceActorDirection

            [FieldOffset(64)] byte AudioFileName; //TODO: string FString AudioFileName

            [FieldOffset(80)] byte DialogueAsset; //TODO: string FString DialogueAsset

            [FieldOffset(96)] public bool IsRecorded;

            [FieldOffset(104)] byte LocalizationKeys; //TODO: array TArray LocalizationKeys

            [FieldOffset(120)] byte SpeakingVoiceGUID; //TODO: string FString SpeakingVoiceGUID

            [FieldOffset(136)] byte TargetVoiceGUIDs; //TODO: array TArray TargetVoiceGUIDs

            [FieldOffset(152)] byte DialogueAssetGUID; //TODO: string FString DialogueAssetGUID

        }
}
