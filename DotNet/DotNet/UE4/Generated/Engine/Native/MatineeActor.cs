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
    [StructLayout( LayoutKind.Explicit, Size=1352 )]
    internal unsafe struct MatineeActor_fields {
        [FieldOffset(1008)]  public IntPtr  MatineeData;
        [FieldOffset(1016)] public Name MatineeControllerName;
        [FieldOffset(1028)] public float PlayRate;
        [FieldOffset(1032)] public bool bPlayOnLevelLoad;
        [FieldOffset(1032)] public bool bForceStartPos;
        [FieldOffset(1036)] public float ForceStartPosition;
        [FieldOffset(1040)] public bool bLooping;
        [FieldOffset(1040)] public bool bRewindOnPlay;
        [FieldOffset(1040)] public bool bNoResetOnRewind;
        [FieldOffset(1040)] public bool bRewindIfAlreadyPlaying;
        [FieldOffset(1040)] public bool bDisableRadioFilter;
        [FieldOffset(1040)] public bool bClientSideOnly;
        [FieldOffset(1040)] public bool bSkipUpdateIfNotVisible;
        [FieldOffset(1040)] public bool bIsSkippable;
        [FieldOffset(1044)] public int PreferredSplitScreenNum;
        [FieldOffset(1048)] public bool bDisableMovementInput;
        [FieldOffset(1048)] public bool bDisableLookAtInput;
        [FieldOffset(1048)] public bool bHidePlayer;
        [FieldOffset(1048)] public bool bHideHud;
        [FieldOffset(1056)] public NativeArray GroupActorInfos;
        [FieldOffset(1072)] public bool bShouldShowGore;
        [FieldOffset(1080)] public NativeArray GroupInst;
        [FieldOffset(1096)] public NativeArray CameraCuts;
        [FieldOffset(1112)]  public IntPtr  SpriteComponent;
        [FieldOffset(1120)] public bool bIsBeingEdited;
        [FieldOffset(1120)] public bool bIsScrubbing;
        [FieldOffset(1120)] public bool bIsPlaying;
        [FieldOffset(1120)] public bool bReversePlayback;
        [FieldOffset(1120)] public bool bPaused;
        [FieldOffset(1120)] public bool bPendingStop;
        [FieldOffset(1124)] public float InterpPosition;
        [FieldOffset(1132)] public byte ReplicationForceIsPlaying;
        [FieldOffset(1136)] byte OnPlay; //TODO: multicast delegate FOnMatineeEvent OnPlay
        [FieldOffset(1152)] byte OnStop; //TODO: multicast delegate FOnMatineeEvent OnStop
        [FieldOffset(1168)] byte OnPause; //TODO: multicast delegate FOnMatineeEvent OnPause
    }
    internal unsafe struct MatineeActor_methods {
        internal struct ChangePlaybackDirection_method {
            static internal IntPtr ChangePlaybackDirection_ptr;
            static ChangePlaybackDirection_method() {
                ChangePlaybackDirection_ptr = Main.GetMethodUFunction(MatineeActor.StaticClass, "ChangePlaybackDirection");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ChangePlaybackDirection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableGroupByName_method {
            static internal IntPtr EnableGroupByName_ptr;
            static EnableGroupByName_method() {
                EnableGroupByName_ptr = Main.GetMethodUFunction(MatineeActor.StaticClass, "EnableGroupByName");
            }

            internal static unsafe void Invoke(IntPtr obj, string GroupName, bool bEnable) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var GroupName_handle = GCHandle.Alloc(GroupName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = GroupName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = GroupName.Length;
                *(int*)(b+IntPtr.Size+4+0) = GroupName.Length;
                *((bool*)(b+16)) = bEnable;
                Main.GetProcessEvent(obj, EnableGroupByName_ptr, new IntPtr(p)); ;
                GroupName_handle.Free();
            }
        }
        internal struct Pause_method {
            static internal IntPtr Pause_ptr;
            static Pause_method() {
                Pause_ptr = Main.GetMethodUFunction(MatineeActor.StaticClass, "Pause");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Pause_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Play_method {
            static internal IntPtr Play_ptr;
            static Play_method() {
                Play_ptr = Main.GetMethodUFunction(MatineeActor.StaticClass, "Play");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Play_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Reverse_method {
            static internal IntPtr Reverse_ptr;
            static Reverse_method() {
                Reverse_ptr = Main.GetMethodUFunction(MatineeActor.StaticClass, "Reverse");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Reverse_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLoopingState_method {
            static internal IntPtr SetLoopingState_ptr;
            static SetLoopingState_method() {
                SetLoopingState_ptr = Main.GetMethodUFunction(MatineeActor.StaticClass, "SetLoopingState");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewLooping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewLooping;
                Main.GetProcessEvent(obj, SetLoopingState_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPosition_method {
            static internal IntPtr SetPosition_ptr;
            static SetPosition_method() {
                SetPosition_ptr = Main.GetMethodUFunction(MatineeActor.StaticClass, "SetPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewPosition, bool bJump) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewPosition;
                *((bool*)(b+4)) = bJump;
                Main.GetProcessEvent(obj, SetPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(MatineeActor.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MatineeActor_events {
    }
}
