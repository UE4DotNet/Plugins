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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct SoundSubmix_fields {
        [FieldOffset(56)] public NativeArray ChildSubmixes;
        [FieldOffset(72)]  public IntPtr  ParentSubmix;
        [FieldOffset(88)] byte ChannelFormat; //TODO: enum ESubmixChannelFormat ChannelFormat
        [FieldOffset(96)] public NativeArray SubmixEffectChain;
        [FieldOffset(112)]  public IntPtr  AmbisonicsPluginSettings;
        [FieldOffset(120)] public int EnvelopeFollowerAttackTime;
        [FieldOffset(124)] public int EnvelopeFollowerReleaseTime;
        [FieldOffset(128)] byte OnSubmixRecordedFileDone; //TODO: multicast delegate FOnSubmixRecordedFileDone OnSubmixRecordedFileDone
    }
    internal unsafe struct SoundSubmix_methods {
        internal struct AddEnvelopeFollowerDelegate_method {
            static internal IntPtr AddEnvelopeFollowerDelegate_ptr;
            static AddEnvelopeFollowerDelegate_method() {
                AddEnvelopeFollowerDelegate_ptr = Main.GetMethodUFunction(SoundSubmix.StaticClass, "AddEnvelopeFollowerDelegate");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject WorldContextObject, byte OnSubmixEnvelopeBP /*TODO: delegate FOnSubmixEnvelopeBP */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: delegate FOnSubmixEnvelopeBP OnSubmixEnvelopeBP
                Main.GetProcessEvent(obj, AddEnvelopeFollowerDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FOnSubmixEnvelopeBP OnSubmixEnvelopeBP
            }
        }
        internal struct StartEnvelopeFollowing_method {
            static internal IntPtr StartEnvelopeFollowing_ptr;
            static StartEnvelopeFollowing_method() {
                StartEnvelopeFollowing_ptr = Main.GetMethodUFunction(SoundSubmix.StaticClass, "StartEnvelopeFollowing");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(obj, StartEnvelopeFollowing_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StartRecordingOutput_method {
            static internal IntPtr StartRecordingOutput_ptr;
            static StartRecordingOutput_method() {
                StartRecordingOutput_ptr = Main.GetMethodUFunction(SoundSubmix.StaticClass, "StartRecordingOutput");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject WorldContextObject, float ExpectedDuration) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((float*)(b+8)) = ExpectedDuration;
                Main.GetProcessEvent(obj, StartRecordingOutput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopEnvelopeFollowing_method {
            static internal IntPtr StopEnvelopeFollowing_ptr;
            static StopEnvelopeFollowing_method() {
                StopEnvelopeFollowing_ptr = Main.GetMethodUFunction(SoundSubmix.StaticClass, "StopEnvelopeFollowing");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(obj, StopEnvelopeFollowing_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopRecordingOutput_method {
            static internal IntPtr StopRecordingOutput_ptr;
            static StopRecordingOutput_method() {
                StopRecordingOutput_ptr = Main.GetMethodUFunction(SoundSubmix.StaticClass, "StopRecordingOutput");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject WorldContextObject, EAudioRecordingExportType ExportType, string Name, string Path, SoundWave ExistingSoundWaveToOverwrite) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
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
                *((IntPtr*)(b+48)) = ExistingSoundWaveToOverwrite;
                Main.GetProcessEvent(obj, StopRecordingOutput_ptr, new IntPtr(p)); ;
                Name_handle.Free();
                Path_handle.Free();
            }
        }
    }
    internal unsafe struct SoundSubmix_events {
    }
}
