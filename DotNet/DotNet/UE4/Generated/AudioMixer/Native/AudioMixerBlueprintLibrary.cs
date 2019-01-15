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

using UE4.Engine;

namespace UE4.AudioMixer.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct AudioMixerBlueprintLibrary_fields {
    }
    internal unsafe struct AudioMixerBlueprintLibrary_methods {
        internal struct AddMasterSubmixEffect_method {
            static internal IntPtr AddMasterSubmixEffect_ptr;
            static AddMasterSubmixEffect_method() {
                AddMasterSubmixEffect_ptr = Main.GetMethodUFunction(AudioMixerBlueprintLibrary.StaticClass, "AddMasterSubmixEffect");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundEffectSubmixPreset SubmixEffectPreset) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = SubmixEffectPreset;
                Main.GetProcessEvent(AudioMixerBlueprintLibrary.DefaultObject, AddMasterSubmixEffect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddSourceEffectToPresetChain_method {
            static internal IntPtr AddSourceEffectToPresetChain_ptr;
            static AddSourceEffectToPresetChain_method() {
                AddSourceEffectToPresetChain_ptr = Main.GetMethodUFunction(AudioMixerBlueprintLibrary.StaticClass, "AddSourceEffectToPresetChain");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundEffectSourcePresetChain PresetChain, SourceEffectChainEntry Entry) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PresetChain;
                *((SourceEffectChainEntry*)(b+16)) = Entry;
                Main.GetProcessEvent(AudioMixerBlueprintLibrary.DefaultObject, AddSourceEffectToPresetChain_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMasterSubmixEffects_method {
            static internal IntPtr ClearMasterSubmixEffects_ptr;
            static ClearMasterSubmixEffects_method() {
                ClearMasterSubmixEffects_ptr = Main.GetMethodUFunction(AudioMixerBlueprintLibrary.StaticClass, "ClearMasterSubmixEffects");
            }

            internal static unsafe void Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(AudioMixerBlueprintLibrary.DefaultObject, ClearMasterSubmixEffects_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetNumberOfEntriesInSourceEffectChain_method {
            static internal IntPtr GetNumberOfEntriesInSourceEffectChain_ptr;
            static GetNumberOfEntriesInSourceEffectChain_method() {
                GetNumberOfEntriesInSourceEffectChain_ptr = Main.GetMethodUFunction(AudioMixerBlueprintLibrary.StaticClass, "GetNumberOfEntriesInSourceEffectChain");
            }

            internal static unsafe int Invoke(UObject WorldContextObject, SoundEffectSourcePresetChain PresetChain) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PresetChain;
                Main.GetProcessEvent(AudioMixerBlueprintLibrary.DefaultObject, GetNumberOfEntriesInSourceEffectChain_ptr, new IntPtr(p)); ;
                return *((int*)(b+16));
            }
        }
        internal struct RemoveMasterSubmixEffect_method {
            static internal IntPtr RemoveMasterSubmixEffect_ptr;
            static RemoveMasterSubmixEffect_method() {
                RemoveMasterSubmixEffect_ptr = Main.GetMethodUFunction(AudioMixerBlueprintLibrary.StaticClass, "RemoveMasterSubmixEffect");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundEffectSubmixPreset SubmixEffectPreset) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = SubmixEffectPreset;
                Main.GetProcessEvent(AudioMixerBlueprintLibrary.DefaultObject, RemoveMasterSubmixEffect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveSourceEffectFromPresetChain_method {
            static internal IntPtr RemoveSourceEffectFromPresetChain_ptr;
            static RemoveSourceEffectFromPresetChain_method() {
                RemoveSourceEffectFromPresetChain_ptr = Main.GetMethodUFunction(AudioMixerBlueprintLibrary.StaticClass, "RemoveSourceEffectFromPresetChain");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundEffectSourcePresetChain PresetChain, int EntryIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PresetChain;
                *((int*)(b+16)) = EntryIndex;
                Main.GetProcessEvent(AudioMixerBlueprintLibrary.DefaultObject, RemoveSourceEffectFromPresetChain_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBypassSourceEffectChainEntry_method {
            static internal IntPtr SetBypassSourceEffectChainEntry_ptr;
            static SetBypassSourceEffectChainEntry_method() {
                SetBypassSourceEffectChainEntry_ptr = Main.GetMethodUFunction(AudioMixerBlueprintLibrary.StaticClass, "SetBypassSourceEffectChainEntry");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, SoundEffectSourcePresetChain PresetChain, int EntryIndex, bool bBypassed) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PresetChain;
                *((int*)(b+16)) = EntryIndex;
                *((bool*)(b+20)) = bBypassed;
                Main.GetProcessEvent(AudioMixerBlueprintLibrary.DefaultObject, SetBypassSourceEffectChainEntry_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StartRecordingOutput_method {
            static internal IntPtr StartRecordingOutput_ptr;
            static StartRecordingOutput_method() {
                StartRecordingOutput_ptr = Main.GetMethodUFunction(AudioMixerBlueprintLibrary.StaticClass, "StartRecordingOutput");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, float ExpectedDuration, SoundSubmix SubmixToRecord) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((float*)(b+8)) = ExpectedDuration;
                *((IntPtr*)(b+16)) = SubmixToRecord;
                Main.GetProcessEvent(AudioMixerBlueprintLibrary.DefaultObject, StartRecordingOutput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopRecordingOutput_method {
            static internal IntPtr StopRecordingOutput_ptr;
            static StopRecordingOutput_method() {
                StopRecordingOutput_ptr = Main.GetMethodUFunction(AudioMixerBlueprintLibrary.StaticClass, "StopRecordingOutput");
            }

            internal static unsafe SoundWave Invoke(UObject WorldContextObject, EAudioRecordingExportType ExportType, string Name, string Path, SoundSubmix SubmixToRecord, SoundWave ExistingSoundWaveToOverwrite) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *(b+8) = (byte)ExportType;
                var Name_handle = GCHandle.Alloc(Name, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Name_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Name.Length;
                *(int*)(b+IntPtr.Size+4+16) = Name.Length;
                var Path_handle = GCHandle.Alloc(Path, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = Path_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = Path.Length;
                *(int*)(b+IntPtr.Size+4+32) = Path.Length;
                *((IntPtr*)(b+48)) = SubmixToRecord;
                *((IntPtr*)(b+56)) = ExistingSoundWaveToOverwrite;
                Main.GetProcessEvent(AudioMixerBlueprintLibrary.DefaultObject, StopRecordingOutput_ptr, new IntPtr(p)); ;
                Name_handle.Free();
                Path_handle.Free();
                return *((IntPtr*)(b+64));
            }
        }
    }
    internal unsafe struct AudioMixerBlueprintLibrary_events {
    }
}
