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

namespace UE4.OnlineSubsystemUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct LeaderboardBlueprintLibrary_fields {
    }
    internal unsafe struct LeaderboardBlueprintLibrary_methods {
        internal struct WriteLeaderboardInteger_method {
            static internal IntPtr WriteLeaderboardInteger_ptr;
            static WriteLeaderboardInteger_method() {
                WriteLeaderboardInteger_ptr = Main.GetMethodUFunction(LeaderboardBlueprintLibrary.StaticClass, "WriteLeaderboardInteger");
            }

            internal static unsafe bool Invoke(PlayerController PlayerController, Name StatName, int StatValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                *((Name*)(b+8)) = StatName;
                *((int*)(b+20)) = StatValue;
                Main.GetProcessEvent(LeaderboardBlueprintLibrary.DefaultObject, WriteLeaderboardInteger_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
    }
    internal unsafe struct LeaderboardBlueprintLibrary_events {
    }
}
