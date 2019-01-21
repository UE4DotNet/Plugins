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

using UE4.MovieScene;

namespace UE4.LevelSequence.Native {
    [StructLayout( LayoutKind.Explicit, Size=2168 )]
    internal unsafe struct LevelSequencePlayer_fields {
        [FieldOffset(2008)] byte OnCameraCut; //TODO: multicast delegate FOnLevelSequencePlayerCameraCutEvent OnCameraCut
        [FieldOffset(2072)] public NativeArray AdditionalEventReceivers;
    }
    internal unsafe struct LevelSequencePlayer_methods {
        internal struct CreateLevelSequencePlayer_method {
            static internal IntPtr CreateLevelSequencePlayer_ptr;
            static CreateLevelSequencePlayer_method() {
                CreateLevelSequencePlayer_ptr = Main.GetMethodUFunction(LevelSequencePlayer.StaticClass, "CreateLevelSequencePlayer");
            }

            internal static unsafe (LevelSequenceActor, LevelSequencePlayer) Invoke(UObject WorldContextObject, LevelSequence LevelSequence, MovieSceneSequencePlaybackSettings Settings) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = LevelSequence;
                *((MovieSceneSequencePlaybackSettings*)(b+16)) = Settings;
                Main.GetProcessEvent(LevelSequencePlayer.DefaultObject, CreateLevelSequencePlayer_ptr, new IntPtr(p)); ;
                return (*((IntPtr*)(b+80)),*((IntPtr*)(b+88)));
            }
        }
    }
    internal unsafe struct LevelSequencePlayer_events {
    }
}
