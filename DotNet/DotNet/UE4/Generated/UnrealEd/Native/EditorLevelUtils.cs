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

namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct EditorLevelUtils_fields {
    }
    internal unsafe struct EditorLevelUtils_methods {
        internal struct CreateNewStreamingLevel_method {
            static internal IntPtr CreateNewStreamingLevel_ptr;
            static CreateNewStreamingLevel_method() {
                CreateNewStreamingLevel_ptr = Main.GetMethodUFunction(EditorLevelUtils.StaticClass, "CreateNewStreamingLevel");
            }

            internal static unsafe LevelStreaming Invoke(SubclassOf<LevelStreaming> LevelStreamingClass, string NewLevelPath, bool bMoveSelectedActorsIntoNewLevel) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = LevelStreamingClass;
                var NewLevelPath_handle = GCHandle.Alloc(NewLevelPath, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = NewLevelPath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = NewLevelPath.Length;
                *(int*)(b+IntPtr.Size+4+8) = NewLevelPath.Length;
                *((bool*)(b+24)) = bMoveSelectedActorsIntoNewLevel;
                Main.GetProcessEvent(EditorLevelUtils.DefaultObject, CreateNewStreamingLevel_ptr, new IntPtr(p)); ;
                NewLevelPath_handle.Free();
                return *((IntPtr*)(b+32));
            }
        }
        internal struct MakeLevelCurrent_method {
            static internal IntPtr MakeLevelCurrent_ptr;
            static MakeLevelCurrent_method() {
                MakeLevelCurrent_ptr = Main.GetMethodUFunction(EditorLevelUtils.StaticClass, "MakeLevelCurrent");
            }

            internal static unsafe void Invoke(LevelStreaming InStreamingLevel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InStreamingLevel;
                Main.GetProcessEvent(EditorLevelUtils.DefaultObject, MakeLevelCurrent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct MoveActorsToLevel_method {
            static internal IntPtr MoveActorsToLevel_ptr;
            static MoveActorsToLevel_method() {
                MoveActorsToLevel_ptr = Main.GetMethodUFunction(EditorLevelUtils.StaticClass, "MoveActorsToLevel");
            }

            internal static unsafe int Invoke(byte ActorsToMove /*TODO: array TArray */, LevelStreaming DestStreamingLevel, bool bWarnAboutReferences) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ActorsToMove
                *((IntPtr*)(b+16)) = DestStreamingLevel;
                *((bool*)(b+24)) = bWarnAboutReferences;
                Main.GetProcessEvent(EditorLevelUtils.DefaultObject, MoveActorsToLevel_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToMove
                return *((int*)(b+28));
            }
        }
        internal struct MoveSelectedActorsToLevel_method {
            static internal IntPtr MoveSelectedActorsToLevel_ptr;
            static MoveSelectedActorsToLevel_method() {
                MoveSelectedActorsToLevel_ptr = Main.GetMethodUFunction(EditorLevelUtils.StaticClass, "MoveSelectedActorsToLevel");
            }

            internal static unsafe int Invoke(LevelStreaming DestLevel, bool bWarnAboutReferences) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = DestLevel;
                *((bool*)(b+8)) = bWarnAboutReferences;
                Main.GetProcessEvent(EditorLevelUtils.DefaultObject, MoveSelectedActorsToLevel_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
    }
    internal unsafe struct EditorLevelUtils_events {
    }
}
